using HtmlAgilityPack;
using System.Collections;

namespace ModulatorLib
{
	/// <summary>
	/// 模拟HTML的表单
	/// </summary>
	public class HtmlForm : IEnumerable<KeyValuePair<string, FormItem>>
	{
		#region 网络相关
		public string Action { get; set; } = @"http://192.168.1.15/ChannelSetup.htm";

		/// <summary>
		/// 获得表单的http post请求体字符串
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string reValue = string.Empty;
			foreach (KeyValuePair<string, FormItem> item in Items)
			{
				reValue += item.Value.ToString() + "&";
			}
			// 去除结尾的&符
			if (reValue.EndsWith("&"))
			{
				reValue = reValue.Substring(0, reValue.Length - 1);
			}

			return reValue;
		}
		#endregion

		#region 让用户操作容器
		/// <summary>
		/// 解析html字符串，用来填充此类中储存的表单项的值
		/// </summary>
		/// <param name="html"></param>
		public void ParseHtml(string html)
		{
			HtmlDocument document = new HtmlDocument();
			document.LoadHtml(html);
			// 选择form标签中具有name属性的标签
			HtmlNodeCollection formItems = document.DocumentNode.SelectNodes("//form//@name");
			formItems.Remove(0);// 去除form标签本身。
								// 遍历每个表单项节点，添加到容器中
			foreach (HtmlNode? formItem in formItems)
			{
				SelectTag selectTag = new(formItem.Attributes["name"].Value);
				selectTag.ParseHtml(formItem);
				Add(selectTag);
			}
		}
		#endregion

		#region 将此类作为容器的实现
		/// <summary>
		/// 存放表单项的字典
		/// </summary>
		public Dictionary<string, FormItem> Items = new();

		public FormItem this[string formItemName]
		{
			get => Items[formItemName];
			set => Items[formItemName] = value;
		}

		public void Add(FormItem item)
		{
			try
			{
				Items.Add(item.Name, item);
			}
			catch { }
		}

		IEnumerator<KeyValuePair<string, FormItem>> IEnumerable<KeyValuePair<string, FormItem>>.GetEnumerator()
		{
			return Items.GetEnumerator();
		}

		public IEnumerator GetEnumerator()
		{
			return Items.GetEnumerator();
		}
		#endregion
	}

	/// <summary>
	/// 表单项基类
	/// </summary>
	public class FormItem
	{
		#region 构造函数
		public FormItem() { }
		public FormItem(string name)
		{
			Name = name;
		}
		public FormItem(string name, string value)
		{
			Name = name;
			Value = value;
		}
		#endregion

		public virtual string Type => "FormItem";

		/// <summary>
		/// 表单项的name属性
		/// </summary>
		public virtual string Name
		{
			get => Attributes["name"];
			set => Attributes["name"] = value;
		}

		/// <summary>
		/// 表单项的value属性
		/// </summary>
		public virtual string Value
		{
			get => Attributes["value"];
			set => Attributes["value"] = value;
		}
		/// <summary>
		/// 标签属性
		/// </summary>
		public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>()
		{
			{"name",string.Empty},
			{"value",string.Empty},
		};

		/// <summary>
		/// 返回名值对的字符串。格式为：key=value，例如：name=张三
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{Name}={Value}";
		}

		/// <summary>
		/// 解析html，用来填充Name属性和Value属性
		/// </summary>
		/// <param name="node"></param>
		public virtual void ParseHtml(HtmlNode node)
		{
			HtmlAttribute? tempAtt = node.Attributes["name"];
			if (tempAtt != null)
			{
				Name = tempAtt.Value;
			}
			else
			{
				Name = string.Empty;
			}

			tempAtt = node.Attributes["value"];
			if (tempAtt != null)
			{
				Value = tempAtt.Value;
			}
			else
			{
				Value = string.Empty;
			}
		}
	}

	/// <summary>
	/// 模拟select标签
	/// </summary>
	public class SelectTag : FormItem, IEnumerable<string>
	{
		#region 构造函数
		public SelectTag() { }
		public SelectTag(string name) : base(name) { }
		public SelectTag(string name, string value) : base(name, value) { }
		#endregion

		public override string Type => "SelectTag";

		private string? _value = null;
		public override string Value
		{
			get
			{
				if (_value == null)
				{
					try
					{
						_value = Options[0];
						/*使用override关键字重写后，通过基类的引用访问Value属性时，访问到的
						 是派生类的Value属性。但是，派生类中可以通过base.Value来访问基类的
						Value属性，此行为不影响属性的多态。*/
						base.Value = _value;
					}
					catch
					{
						_value = string.Empty;
					}
				}

				return _value;
			}
			set => _value = value;
		}

		public override void ParseHtml(HtmlNode node)
		{
			// 首先执行基类的方法
			base.ParseHtml(node);

			#region 从option中获取value
			// 执行完基类的方法后，如果还是为空字符串，则从option中获取value
			if (Value == string.Empty)
			{
				/* 首先看看option标签中有没有一个具有selected属性的。
				 * 
				 * 这里的xpath要使用相对路径索引，否则会查找整个html文档，而不是当前HtmlNode
				 * 所对应的节点下的option标签
				 */
				HtmlNode selectedOption = node.SelectSingleNode(".//option//@selected");
				if (selectedOption != null)
				{
					Value = selectedOption.InnerText;
				}
				else
				{
					HtmlNode firstOption = node.SelectSingleNode(".//option");
					if (firstOption != null)
					{
						Value = firstOption.InnerText;
					}
				}
			}
			#endregion

			#region 获取option填充到列表中
			// 如果用户没有自己设置选项，则解析html来获取选项
			if (Options.Count == 0)
			{
				HtmlNodeCollection options = node.SelectNodes(".//option");
				if (options != null)
				{
					foreach (HtmlNode? option in options)
					{
						Add(option.InnerText);
					}
				}
			}
			#endregion
		}

		#region 将此类作为容器的实现
		/// <summary>
		/// select标签的可选项
		/// </summary>
		public List<string> Options { get; set; } = new List<string>();

		public IEnumerator<string> GetEnumerator()
		{
			return Options.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Options.GetEnumerator();
		}

		public void Add(string name)
		{
			Options.Add(name);
		}
		#endregion
	}
}
