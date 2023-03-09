using HtmlAgilityPack;

namespace ModulatorLib
{
	/// <summary>
	/// 与调制器的通信接口
	/// </summary>
	internal interface ICommunicate
	{
		/// <summary>
		/// 调制器的IP地址和端口号。例如 "192.168.1.15:80"
		/// </summary>
		public string IPAddressAndPort { get; set; }

		public HttpClient Http_Client { get; set; }
	}

	/// <summary>
	/// 提供ICommunicate接口的扩展方法
	/// </summary>
	internal static class ExternMethod_For_ICommunicate
	{
		/// <summary>
		/// 从字符串中解析出信道号、频率值
		/// </summary>
		/// <param name="me"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public static (bool success, int channel, int frequency) ParseChannel(this string me)
		{
			string[] strs = me.Split(new char[] { ' ', '（', '(' },
				StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
			try
			{
				int re_chanel = int.Parse(strs[0]);
				int re_frequency = (int)double.Parse(strs[1]);
				return (true, re_chanel, re_frequency);
			}
			catch
			{
				throw new Exception("从字符串中解析信道号和频率值失败");
			}
		}

		/// <summary>
		/// 分析html，从中解析出信道
		/// </summary>
		/// <param name="me"></param>
		/// <param name="html_str"></param>
		/// <returns></returns>
		public static (bool avaliable, int channel, int frequency) ParseChannelFromHtmlStr(this ICommunicate me, string html_str)
		{
			// 加载 html 字符串
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(html_str);
			HtmlNode? select_node = doc.SelectNodeWithTheAttributeValueFromDocument("select", "name", "channel");
			if (select_node != null)
			{
				HtmlNode? option_node = select_node.SelectChildNodeWithTheAttribute("selected");
				if (option_node != null)
				{
					string inner_text = option_node.InnerText;
					try
					{
						return inner_text.ParseChannel();
					}
					catch { }
				}
			}
			return (false, 0, 0);
		}

		/// <summary>
		///		向调制器发送设置信道的命令
		/// </summary>
		/// <param name="command_string">
		///		html表单字符串。因为命令是通过html表单传递的。
		/// </param>
		/// <returns></returns>
		public static async Task<(bool success, int channel, int frequency)> SendChannelSetupCommand(this ICommunicate me, string command_string)
		{
			StringContent string_content = new StringContent(command_string);

			HttpResponseMessage httpResponse = await me.Http_Client.PostAsync($"http://{me.IPAddressAndPort}/RFSetup_ATSC_C.htm", string_content);
			if (httpResponse.IsSuccessStatusCode)
			{
				string str = await httpResponse.Content.ReadAsStringAsync();
				return me.ParseChannelFromHtmlStr(str);
			}
			return (false, 0, 0);
		}
	}

	public static class ExternMethod_For_Html
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
