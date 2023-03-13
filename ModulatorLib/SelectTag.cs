using HtmlAgilityPack;
using System.Collections;

namespace ModulatorLib
{
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
					if (Options.Count > 0)
					{
						_value = Options[0];
						base.Value = _value;
					}
					else
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
