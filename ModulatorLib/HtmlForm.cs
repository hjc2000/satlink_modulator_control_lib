using System.Collections;

namespace ModulatorLib
{
	/// <summary>
	/// 模拟HTML的表单
	/// </summary>
	public class HtmlForm : IEnumerable<FormItem>
	{
		public string Action { get; set; } = @"http://192.168.1.15/ChannelSetup.htm";

		/// <summary>
		/// 通过标签的name属性来找到指定的项。表单中的标签的name属性不能重复，所以可以用来
		/// 唯一标识一个标签
		/// </summary>
		/// <param name="name">表单项的name属性的值</param>
		/// <returns>表单项的引用</returns>
		public FormItem? FindFormItemWithName(string name)
		{
			return Items.Find((item) =>
			{
				if (item.Name == name)
				{
					return true;
				}

				return false;
			});
		}

		/// <summary>
		/// 存放表单项的列表
		/// </summary>
		public List<FormItem> Items = new List<FormItem>();

		public IEnumerator<FormItem> GetEnumerator()
		{
			return Items.GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return Items.GetEnumerator();
		}

		public void Add(FormItem item)
		{
			Items.Add(item);
		}

		/// <summary>
		/// 获得表单的http post请求体字符串
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string re_str = string.Empty;
			foreach (FormItem item in Items)
			{
				re_str += item.ToString() + "&";
			}

			re_str = re_str.Substring(0, re_str.Length - 1);
			return re_str;
		}
	}

	/// <summary>
	/// 表单项基类
	/// </summary>
	public class FormItem
	{
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
		public SelectTag() { }
		public SelectTag(string name) : base(name) { }
		public SelectTag(string name, string value) : base(name, value) { }

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
	}
}
