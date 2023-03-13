using HtmlAgilityPack;

namespace ModulatorLib
{
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
}
