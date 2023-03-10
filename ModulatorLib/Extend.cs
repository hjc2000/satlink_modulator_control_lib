/**
 * 向其它类、接口添加扩展方法
 */
using HtmlAgilityPack;

namespace ModulatorLib
{
	/// <summary>
	/// 扩展HtmlAgilityPack库
	/// </summary>
	public static class Ex_HtmlAgilityPack
	{
		public static HtmlNode? SelectNodeWithTheAttributeValueFromDocument(this HtmlDocument me, string node_name, string attribute_name, string attribute_value)
		{
			HtmlNodeCollection nodes = me.DocumentNode.SelectNodes("//" + node_name);
			foreach (HtmlNode node in nodes)
			{
				if (node.Attributes[attribute_name]?.Value == attribute_value)
				{
					return node;
				}
			}

			return null;
		}

		/// <summary>
		/// 从特定节点的子节点中选出属性值符合条件的
		/// </summary>
		/// <param name="me"></param>
		/// <param name="node_name"></param>
		/// <param name="attribute_name"></param>
		/// <param name="attribute_value"></param>
		/// <returns></returns>
		public static HtmlNode? SelectChildNodeWithTheAttribute(this HtmlNode me, string attribute_name)
		{
			HtmlNodeCollection nodes = me.ChildNodes;
			foreach (HtmlNode node in nodes)
			{
				if (node.Attributes[attribute_name] != null)
				{
					return node;
				}
			}

			return null;
		}
	}
}
