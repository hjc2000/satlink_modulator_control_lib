using HtmlAgilityPack;
using System.Collections;

namespace ModulatorLib
{
	/// <summary>
	/// 模拟HTML的表单
	/// </summary>
	public class HtmlForm : IEnumerable<KeyValuePair<string, FormItem>>
	{
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

		/// <summary>
		/// 解析html字符串，用来填充此类中储存的表单项的值
		/// </summary>
		/// <param name="html"></param>
		public void ParseHtml(string html)
		{
			Items.Clear();
			HtmlDocument document = new HtmlDocument();
			document.LoadHtml(html);
			// 选择form标签中具有name属性的标签
			HtmlNodeCollection formItems = document.DocumentNode.SelectNodes("//form//@name");
			// 去除form标签本身。
			formItems.Remove(0);
			// 遍历每个表单项节点，添加到容器中
			foreach (HtmlNode? formItem in formItems)
			{
				switch (formItem.Name)
				{
				case "select":
					{
						SelectTag selectTag = new();
						selectTag.ParseHtml(formItem);
						Add(selectTag);
						break;
					}
				default:
					{
						FormItem item = new FormItem();
						item.ParseHtml(formItem);
						Add(item);
						break;
					}
				}
			}
		}

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
}
