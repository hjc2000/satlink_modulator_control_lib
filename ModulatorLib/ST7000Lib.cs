using HtmlAgilityPack;
using System.Net;
/** 命名规范
* 1. 类型名使用大驼峰命名法，不使用下划线分隔。
* 2. 字段以下划线 _ 开头，使用下划线分隔每个单词。
* 3. 局部变量不以下划线 _ 开头，使用下划线分隔每个单词。
* 4. 属性、方法使用大驼峰命名法。
* 5. 委托类型名使用 F_ 开头，后续使用大驼峰命名法。
*	  委托变量使用 f_ 开头，后续使用大驼峰命名法。
*/
namespace ModulatorLib
{
	/// <summary>
	/// ST7000内置数据库
	/// </summary>
	public class ST7000Lib : IModulatorOperator
	{
		public Dictionary<int, int> ChannelDictionary { get; set; } = new Dictionary<int, int>()
				{
					{ 2, 57 },
					{ 3 , 63 },
					{ 4 , 69 },
					{ 5 , 79 },
					{ 6 , 85 },
					{ 7 , 177 },
					{ 8 , 183 },
					{ 9 , 189 },
					{ 10 , 195 },
					{ 11 , 201 },
					{ 12 , 207 },
					{ 13 , 213 },
					{ 14 , 123 },
					{ 15 , 129 },
					{ 16 , 135 },
					{ 17 , 141 },
					{ 18 , 147 },
					{ 19 , 153 },
					{ 20 , 159 },
					{ 21 , 165 },
					{ 22 , 171 },
					{ 23 , 219 },
					{ 24 , 225 },
					{ 25 , 231 },
					{ 26 , 237 },
					{ 27 , 243 },
					{ 28 , 249 },
					{ 29 , 255 },
					{ 30 , 261 },
					{ 31 , 267 },
					{ 32 , 273 },
					{ 33 , 279 },
					{ 34 , 285 },
					{ 35 , 291 },
					{ 36 , 297 },
					{ 37 , 303 },
					{ 38 , 309 },
					{ 39 , 315 },
					{ 40 , 321 },
					{ 41 , 327 },
					{ 42 , 333 },
					{ 43 , 339 },
					{ 44 , 345 },
					{ 45 , 351 },
					{ 46 , 357 },
					{ 47 , 363 },
					{ 48 , 369 },
					{ 49 , 375 },
					{ 50 , 381 },
					{ 51 , 387 },
					{ 52 , 393 },
					{ 53 , 399 },
					{ 54 , 405 },
					{ 55 , 411 },
					{ 56 , 417 },
					{ 57 , 423 },
					{ 58 , 429 },
					{ 59 , 435 },
					{ 60 , 441 },
					{ 61 , 447 },
					{ 62 , 453 },
					{ 63 , 459 },
					{ 64 , 465 },
					{ 65 , 471 },
					{ 66 , 477 },
					{ 67 , 483 },
					{ 68 , 489 },
					{ 69 , 495 },
					{ 70 , 501 },
					{ 71 , 507 },
					{ 72 , 513 },
					{ 73 , 519 },
					{ 74 , 525 },
					{ 75 , 531 },
					{ 76 , 537 },
					{ 77 , 543 },
					{ 78 , 549 },
					{ 79 , 555 },
					{ 80 , 561 },
					{ 81 , 567 },
					{ 82 , 573 },
					{ 83 , 579 },
					{ 84 , 585 },
					{ 85 , 591 },
					{ 86 , 597 },
					{ 87 , 603 },
					{ 88 , 609 },
					{ 89 , 615 },
					{ 90 , 621 },
					{ 91 , 627 },
					{ 92 , 633 },
					{ 93 , 639 },
					{ 94 , 645 },
					{ 95 , 93 },
					{ 96 , 99 },
					{ 97 , 105 },
					{ 98 , 111 },
					{ 99 , 117 },
					{ 100 , 651 },
					{ 101 , 657 },
					{ 102 , 663 },
					{ 103 , 669 },
					{ 104 , 675 },
					{ 105 , 681 },
					{ 106 , 687 },
					{ 107 , 693 },
					{ 108 , 699 },
					{ 109 , 705 },
					{ 110 , 711 },
					{ 111 , 717 },
					{ 112 , 723 },
					{ 113 , 729 },
					{ 114 , 735 },
					{ 115 , 741 },
					{ 116 , 747 },
					{ 117 , 753 },
					{ 118 , 759 },
					{ 119 , 765 },
					{ 120 , 771 },
					{ 121 , 777 },
					{ 122 , 783 },
					{ 123 , 789 },
					{ 124 , 795 },
					{ 125 , 801 },
					{ 126 , 807 },
					{ 127 , 813 },
					{ 128 , 819 },
					{ 129 , 825 },
					{ 130 , 831 },
					{ 131 , 837 },
					{ 132 , 843 },
					{ 133 , 849 },
					{ 134 , 855 },
					{ 135 , 861 },
					{ 136 , 867 },
					{ 137 , 873 },
					{ 138 , 879 },
					{ 139 , 885 },
					{ 140 , 891 },
					{ 141 , 897 },
					{ 142 , 903 },
					{ 143 , 909 },
					{ 144 , 915 },
					{ 145 , 921 },
					{ 146 , 927 },
					{ 147 , 933 },
					{ 148 , 939 },
					{ 149 , 945 },
					{ 150 , 951 },
					{ 151 , 957 },
					{ 152 , 963 },
					{ 153 , 969 },
					{ 154 , 975 },
					{ 155 , 981 },
					{ 156 , 987 },
					{ 157 , 993 },
					{ 158 , 999 },
			};
		public string IPAddress { get; set; } = "192.168.1.15";

		/// <summary>
		/// 向 ST7000 发送请求，获取信道和频率
		/// </summary>
		/// <param name="ip_address"></param>
		/// <returns></returns>
		public static async Task<(bool avaliable, int chanel, int frequency)> Get_Chanel_And_Fre_From_ST7000(string ip_address = "192.168.1.15")
		{
			// 发送 HTTP 请求，获取设备信息
			HttpClient client = new HttpClient();
			string st7000_url = $"http://{ip_address}/RFSetup_ATSC_C.htm";
			HttpResponseMessage response = await client.GetAsync(st7000_url);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				string html_str = await response.Content.ReadAsStringAsync();
				(bool avaliable, int ch, int fre) = Get_Chanel_And_Fre_From_Html(html_str);
				if (avaliable)
				{
					return (true, ch, fre);
				}
			}
			return (false, 0, 0);
		}

		#region 内部函数

		#endregion

		/// <summary>
		/// 从html字符串中获取频率
		/// </summary>
		/// <param name="html">内容为html的字符串</param>
		/// <returns></returns>
		public static (bool avaliable, int chanel, int frequency) Get_Chanel_And_Fre_From_Html(string html)
		{
			// 加载 html 字符串
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(html);
			// 选出 select 标签
			HtmlNodeCollection select_nodes = doc.DocumentNode.SelectNodes("//select");
			// 遍历每一个 select 标签节点
			foreach (HtmlNode select_node in select_nodes)
			{
				// 如果 name 属性存在且为 channel
				if (select_node?.Attributes["name"]?.Value == "channel")
				{
					// 获取 select 标签的子标签 option 标签
					HtmlNodeCollection option_nodes = select_node.ChildNodes;
					// 遍历每一个 option 标签
					foreach (HtmlNode? node_option in option_nodes)
					{
						// 如果标签存在 selected 属性
						if (!(node_option.Attributes["selected"] == null))
						{
							string inner_text = node_option.InnerText;
							string[] strs = inner_text.Split(new char[] { ' ', '（', '(' },
								StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
							try
							{
								int re_chanel = int.Parse(strs[0]);
								int re_frequency = int.Parse(strs[1]);
								return (true, re_chanel, re_frequency);
							}
							catch { }
						}
					}
				}
			}
			return (false, 0, 0);
		}

		public Task<(bool success, int channel, int frequency)> SetCurrentChannelAsync(int channel)
		{
			throw new NotImplementedException();
		}

		public Task<(bool success, int channel, int frequency)> GetCurrentChannelAsync()
		{
			throw new NotImplementedException();
		}
	}
}
