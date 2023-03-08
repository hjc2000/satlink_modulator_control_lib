﻿using HtmlAgilityPack;
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
	public class ST7000Lib
	{
		public static Dictionary<int, double> ChFreMap = new Dictionary<int, double>()
				{
					{ 2, 57.0 },
					{ 3 , 63.0 },
					{ 4 , 69.0 },
					{ 5 , 79.0 },
					{ 6 , 85.0 },
					{ 7 , 177.0 },
					{ 8 , 183.0 },
					{ 9 , 189.0 },
					{ 10 , 195.0 },
					{ 11 , 201.0 },
					{ 12 , 207.0 },
					{ 13 , 213.0 },
					{ 14 , 123.0 },
					{ 15 , 129.0 },
					{ 16 , 135.0 },
					{ 17 , 141.0 },
					{ 18 , 147.0 },
					{ 19 , 153.0 },
					{ 20 , 159.0 },
					{ 21 , 165.0 },
					{ 22 , 171.0 },
					{ 23 , 219.0 },
					{ 24 , 225.0 },
					{ 25 , 231.0 },
					{ 26 , 237.0 },
					{ 27 , 243.0 },
					{ 28 , 249.0 },
					{ 29 , 255.0 },
					{ 30 , 261.0 },
					{ 31 , 267.0 },
					{ 32 , 273.0 },
					{ 33 , 279.0 },
					{ 34 , 285.0 },
					{ 35 , 291.0 },
					{ 36 , 297.0 },
					{ 37 , 303.0 },
					{ 38 , 309.0 },
					{ 39 , 315.0 },
					{ 40 , 321.0 },
					{ 41 , 327.0 },
					{ 42 , 333.0 },
					{ 43 , 339.0 },
					{ 44 , 345.0 },
					{ 45 , 351.0 },
					{ 46 , 357.0 },
					{ 47 , 363.0 },
					{ 48 , 369.0 },
					{ 49 , 375.0 },
					{ 50 , 381.0 },
					{ 51 , 387.0 },
					{ 52 , 393.0 },
					{ 53 , 399.0 },
					{ 54 , 405.0 },
					{ 55 , 411.0 },
					{ 56 , 417.0 },
					{ 57 , 423.0 },
					{ 58 , 429.0 },
					{ 59 , 435.0 },
					{ 60 , 441.0 },
					{ 61 , 447.0 },
					{ 62 , 453.0 },
					{ 63 , 459.0 },
					{ 64 , 465.0 },
					{ 65 , 471.0 },
					{ 66 , 477.0 },
					{ 67 , 483.0 },
					{ 68 , 489.0 },
					{ 69 , 495.0 },
					{ 70 , 501.0 },
					{ 71 , 507.0 },
					{ 72 , 513.0 },
					{ 73 , 519.0 },
					{ 74 , 525.0 },
					{ 75 , 531.0 },
					{ 76 , 537.0 },
					{ 77 , 543.0 },
					{ 78 , 549.0 },
					{ 79 , 555.0 },
					{ 80 , 561.0 },
					{ 81 , 567.0 },
					{ 82 , 573.0 },
					{ 83 , 579.0 },
					{ 84 , 585.0 },
					{ 85 , 591.0 },
					{ 86 , 597.0 },
					{ 87 , 603.0 },
					{ 88 , 609.0 },
					{ 89 , 615.0 },
					{ 90 , 621.0 },
					{ 91 , 627.0 },
					{ 92 , 633.0 },
					{ 93 , 639.0 },
					{ 94 , 645.0 },
					{ 95 , 93.0 },
					{ 96 , 99.0 },
					{ 97 , 105.0 },
					{ 98 , 111.0 },
					{ 99 , 117.0 },
					{ 100 , 651.0 },
					{ 101 , 657.0 },
					{ 102 , 663.0 },
					{ 103 , 669.0 },
					{ 104 , 675.0 },
					{ 105 , 681.0 },
					{ 106 , 687.0 },
					{ 107 , 693.0 },
					{ 108 , 699.0 },
					{ 109 , 705.0 },
					{ 110 , 711.0 },
					{ 111 , 717.0 },
					{ 112 , 723.0 },
					{ 113 , 729.0 },
					{ 114 , 735.0 },
					{ 115 , 741.0 },
					{ 116 , 747.0 },
					{ 117 , 753.0 },
					{ 118 , 759.0 },
					{ 119 , 765.0 },
					{ 120 , 771.0 },
					{ 121 , 777.0 },
					{ 122 , 783.0 },
					{ 123 , 789.0 },
					{ 124 , 795.0 },
					{ 125 , 801.0 },
					{ 126 , 807.0 },
					{ 127 , 813.0 },
					{ 128 , 819.0 },
					{ 129 , 825.0 },
					{ 130 , 831.0 },
					{ 131 , 837.0 },
					{ 132 , 843.0 },
					{ 133 , 849.0 },
					{ 134 , 855.0 },
					{ 135 , 861.0 },
					{ 136 , 867.0 },
					{ 137 , 873.0 },
					{ 138 , 879.0 },
					{ 139 , 885.0 },
					{ 140 , 891.0 },
					{ 141 , 897.0 },
					{ 142 , 903.0 },
					{ 143 , 909.0 },
					{ 144 , 915.0 },
					{ 145 , 921.0 },
					{ 146 , 927.0 },
					{ 147 , 933.0 },
					{ 148 , 939.0 },
					{ 149 , 945.0 },
					{ 150 , 951.0 },
					{ 151 , 957.0 },
					{ 152 , 963.0 },
					{ 153 , 969.0 },
					{ 154 , 975.0 },
					{ 155 , 981.0 },
					{ 156 , 987.0 },
					{ 157 , 993.0 },
					{ 158 , 999.0 },
			};

		public struct ChFre
		{
			public bool Avaliable;
			public int Chanel;
			public double Fre;
		}

		/// <summary>
		/// 向 ST7000 发送请求，获取信道和频率
		/// </summary>
		/// <param name="ip_address"></param>
		/// <returns></returns>
		public static async Task<ChFre> Get_Chanel_And_Fre_From_ST7000(string ip_address)
		{
			ChFre ch_fre = new ChFre();
			ch_fre.Avaliable = false;
			// 发送 HTTP 请求，获取设备信息
			HttpClient client = new HttpClient();
			string st7000_url = $"http://{ip_address}/RFSetup_ATSC_C.htm";
			HttpResponseMessage response = await client.GetAsync(st7000_url);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				string html_str = await response.Content.ReadAsStringAsync();
				if (Get_Chanel_And_Fre_From_Html(html_str, out int chanel_out, out double fre_out))
				{
					ch_fre.Avaliable = true;
					ch_fre.Chanel = chanel_out;
					ch_fre.Fre = fre_out;
				}
			}
			return ch_fre;
		}

		/// <summary>
		/// 从 HTML 字符串中获取信道和频率
		/// </summary>
		/// <param name="html"></param>
		/// <param name="chanel"></param>
		/// <param name="fre"></param>
		/// <returns></returns>
		public static bool Get_Chanel_And_Fre_From_Html(string html, out int chanel, out double fre)
		{
			chanel = 0;
			fre = 0;

			// 加载 html 字符串
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(html);
			// 选出 select 标签
			HtmlNodeCollection nodes_select = doc.DocumentNode.SelectNodes("//select");
			// 遍历每一个 select 标签节点
			foreach (HtmlNode node_select in nodes_select)
			{
				// 如果 name 属性存在且为 channel
				if (node_select?.Attributes["name"]?.Value == "channel")
				{
					// 获取 select 标签的子标签 option 标签
					var nodes_option = node_select.ChildNodes;
					// 遍历每一个 option 标签
					foreach (var node_option in nodes_option)
					{
						// 如果标签存在 selected 属性
						if (!(node_option.Attributes["selected"] == null))
						{
							string inner_text = node_option.InnerText;
							string[] strs = inner_text.Split(new char[] { ' ', '（', '(' },
								StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
							try
							{
								chanel = int.Parse(strs[0]);
								fre = double.Parse(strs[1]);
								return true;
							}
							catch { }
						}
					}
				}
			}
			return false;
		}
	}
}