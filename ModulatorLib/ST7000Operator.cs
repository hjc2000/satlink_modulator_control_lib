using HtmlAgilityPack;

namespace ModulatorLib
{
	/// <summary>
	/// ST7000内置数据库
	/// </summary>
	public class ST7000Operator : IModulatorOperator
	{
		public ST7000Operator() { }
		public ST7000Operator(string ip_address_and_port)
		{
			IPAddressAndPort = ip_address_and_port;
		}

		// 因为57的信道号是2，所以在数组前面插入两个0，使索引号与信道号一样
		public int[] ChannelList { get; set; } = new int[]
			{
				0,0,57,63,69,79,85,177,183,189,195,201,207,213,123,129,135,141,147,153,159,
				165,171,219,225,231,237,243,249,255,261,267,273,279,285,291,297,303,309,315,321,
				327,333,339,345,351,357,363,369,375,381,387,393,399,405,411,417,423,429,435,441,
				447,453,459,465,471,477,483,489,495,501,507,513,519,525,531,537,543,549,555,561,
				567,573,579,585,591,597,603,609,615,621,627,633,639,645,93,99,105,111,117,651,
				657,663,669,675,681,687,693,699,705,711,717,723,729,735,741,747,753,759,765,771,
				777,783,789,795,801,807,813,819,825,831,837,843,849,855,861,867,873,879,885,891,
				897,903,909,915,921,927,933,939,945,951,957,963,969,975,981,987,993,999,
			};
		public string[] Channel_OptionTagList { get; set; } = new string[]
		{
			string.Empty,
			string.Empty,
			"2 ( 57.0 MHz)",
			"3 ( 63.0 MHz)",
			"4 ( 69.0 MHz)",
			"5 ( 79.0 MHz)",
			"6 ( 85.0 MHz)",
			"7 (177.0 MHz)",
			"8 (183.0 MHz)",
			"9 (189.0 MHz)",
			"10 (195.0 MHz)",
			"11 (201.0 MHz)",
			"12 (207.0 MHz)",
			"13 (213.0 MHz)",
			"14 (123.0 MHz)",
			"15 (129.0 MHz)",
			"16 (135.0 MHz)",
			"17 (141.0 MHz)",
			"18 (147.0 MHz)",
			"19 (153.0 MHz)",
			"20 (159.0 MHz)",
			"21 (165.0 MHz)",
			"22 (171.0 MHz)",
			"23 (219.0 MHz)",
			"24 (225.0 MHz)",
			"25 (231.0 MHz)",
			"26 (237.0 MHz)",
			"27 (243.0 MHz)",
			"28 (249.0 MHz)",
			"29 (255.0 MHz)",
			"30 (261.0 MHz)",
			"31 (267.0 MHz)",
			"32 (273.0 MHz)",
			"33 (279.0 MHz)",
			"34 (285.0 MHz)",
			"35 (291.0 MHz)",
			"36 (297.0 MHz)",
			"37 (303.0 MHz)",
			"38 (309.0 MHz)",
			"39 (315.0 MHz)",
			"40 (321.0 MHz)",
			"41 (327.0 MHz)",
			"42 (333.0 MHz)",
			"43 (339.0 MHz)",
			"44 (345.0 MHz)",
			"45 (351.0 MHz)",
			"46 (357.0 MHz)",
			"47 (363.0 MHz)",
			"48 (369.0 MHz)",
			"49 (375.0 MHz)",
			"50 (381.0 MHz)",
			"51 (387.0 MHz)",
			"52 (393.0 MHz)",
			"53 (399.0 MHz)",
			"54 (405.0 MHz)",
			"55 (411.0 MHz)",
			"56 (417.0 MHz)",
			"57 (423.0 MHz)",
			"58 (429.0 MHz)",
			"59 (435.0 MHz)",
			"60 (441.0 MHz)",
			"61 (447.0 MHz)",
			"62 (453.0 MHz)",
			"63 (459.0 MHz)",
			"64 (465.0 MHz)",
			"65 (471.0 MHz)",
			"66 (477.0 MHz)",
			"67 (483.0 MHz)",
			"68 (489.0 MHz)",
			"69 (495.0 MHz)",
			"70 (501.0 MHz)",
			"71 (507.0 MHz)",
			"72 (513.0 MHz)",
			"73 (519.0 MHz)",
			"74 (525.0 MHz)",
			"75 (531.0 MHz)",
			"76 (537.0 MHz)",
			"77 (543.0 MHz)",
			"78 (549.0 MHz)",
			"79 (555.0 MHz)",
			"80 (561.0 MHz)",
			"81 (567.0 MHz)",
			"82 (573.0 MHz)",
			"83 (579.0 MHz)",
			"84 (585.0 MHz)",
			"85 (591.0 MHz)",
			"86 (597.0 MHz)",
			"87 (603.0 MHz)",
			"88 (609.0 MHz)",
			"89 (615.0 MHz)",
			"90 (621.0 MHz)",
			"91 (627.0 MHz)",
			"92 (633.0 MHz)",
			"93 (639.0 MHz)",
			"94 (645.0 MHz)",
			"95 ( 93.0 MHz)",
			"96 ( 99.0 MHz)",
			"97 (105.0 MHz)",
			"98 (111.0 MHz)",
			"99 (117.0 MHz)",
			"100 (651.0 MHz)",
			"101 (657.0 MHz)",
			"102 (663.0 MHz)",
			"103 (669.0 MHz)",
			"104 (675.0 MHz)",
			"105 (681.0 MHz)",
			"106 (687.0 MHz)",
			"107 (693.0 MHz)",
			"108 (699.0 MHz)",
			"109 (705.0 MHz)",
			"110 (711.0 MHz)",
			"111 (717.0 MHz)",
			"112 (723.0 MHz)",
			"113 (729.0 MHz)",
			"114 (735.0 MHz)",
			"115 (741.0 MHz)",
			"116 (747.0 MHz)",
			"117 (753.0 MHz)",
			"118 (759.0 MHz)",
			"119 (765.0 MHz)",
			"120 (771.0 MHz)",
			"121 (777.0 MHz)",
			"122 (783.0 MHz)",
			"123 (789.0 MHz)",
			"124 (795.0 MHz)",
			"125 (801.0 MHz)",
			"126 (807.0 MHz)",
			"127 (813.0 MHz)",
			"128 (819.0 MHz)",
			"129 (825.0 MHz)",
			"130 (831.0 MHz)",
			"131 (837.0 MHz)",
			"132 (843.0 MHz)",
			"133 (849.0 MHz)",
			"134 (855.0 MHz)",
			"135 (861.0 MHz)",
			"136 (867.0 MHz)",
			"137 (873.0 MHz)",
			"138 (879.0 MHz)",
			"139 (885.0 MHz)",
			"140 (891.0 MHz)",
			"141 (897.0 MHz)",
			"142 (903.0 MHz)",
			"143 (909.0 MHz)",
			"144 (915.0 MHz)",
			"145 (921.0 MHz)",
			"146 (927.0 MHz)",
			"147 (933.0 MHz)",
			"148 (939.0 MHz)",
			"149 (945.0 MHz)",
			"150 (951.0 MHz)",
			"151 (957.0 MHz)",
			"152 (963.0 MHz)",
			"153 (969.0 MHz)",
			"154 (975.0 MHz)",
			"155 (981.0 MHz)",
			"156 (987.0 MHz)",
			"157 (993.0 MHz)",
			"158 (999.0 MHz)",
		};
		public string IPAddressAndPort { get; set; } = "192.168.1.15:80";

		#region 实现的接口函数
		public async Task<(bool success, int channel, int frequency)> SetCurrentChannelAsync(int channel)
		{
			// country=ATSC_Cable&channel=2+%28+57.0+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save
			throw new NotImplementedException();
		}

		public async Task<(bool success, int channel, int frequency)> GetCurrentChannelAsync()
		{
			// 发送 HTTP 请求，获取设备信息
			HttpClient client = new HttpClient();
			string st7000_url = $"http://{IPAddressAndPort}/RFSetup_ATSC_C.htm";
			HttpResponseMessage response = await client.GetAsync(st7000_url);
			if (response.IsSuccessStatusCode)
			{
				string html_str = await response.Content.ReadAsStringAsync();
				(bool avaliable, int ch, int fre) = ParseChannelFromHtmlStr(html_str);
				if (avaliable)
				{
					return (true, ch, fre);
				}
			}
			return (false, 0, 0);
		}

		public async Task<(bool success, int channel, int frequency)> GoToNextChannelAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<(bool success, int channel, int frequency)> GoBackToLastChannelAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<(bool success, int channel, int frequency)> GoToFirstChannelAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<(bool success, int channel, int frequency)> GoToLastChannelAsync()
		{
			throw new NotImplementedException();
		}
		#endregion

		#region 私有函数
		private (bool avaliable, int channel, int frequency) ParseChannelFromHtmlStr(string html_str)
		{
			// 加载 html 字符串
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(html_str);
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
					foreach (HtmlNode node_option in option_nodes)
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
								int re_frequency = (int)double.Parse(strs[1]);
								return (true, re_chanel, re_frequency);
							}
							catch { }
						}
					}
				}
			}
			return (false, 0, 0);
		}
		#endregion

	}
}
