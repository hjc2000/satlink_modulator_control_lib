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
			string re_str = string.Empty;
			foreach (KeyValuePair<string, FormItem> item in Items)
			{
				re_str += item.Value.ToString() + "&";
			}

			re_str = re_str.Substring(0, re_str.Length - 1);
			return re_str;
		}
		#endregion

		#region 让用户操作容器
		/// <summary>
		/// 解析html字符串，用来填充此类中储存的表单项的值
		/// </summary>
		/// <param name="html_str"></param>
		public void ParseValueFromHtmlString(string html_str)
		{

		}
		#endregion

		#region 将此类作为容器的实现
		/// <summary>
		/// 存放表单项的字典
		/// </summary>
		public Dictionary<string, FormItem> Items = new();

		public void Add(FormItem item)
		{
			Items.Add(item.Name, item);
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
