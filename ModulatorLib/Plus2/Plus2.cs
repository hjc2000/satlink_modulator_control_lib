﻿namespace ModulatorLib.Plus2
{
	/// <summary>
	/// "2+" 机型的表单。此表单为"2+" 机型的ChannelSetup表单
	/// </summary>
	public class Plus2_ChannelSetupForm : IHtmlForm
	{
		public Plus2_ChannelSetupForm()
		{
			#region 公共初始化
			// 所有构造函数的重载都要执行的初始化
			Country = CountryOptions[0];
			Channel = ChannelOptions[0];
			Level = LevelOptions[0];
			Video = VideoOptions[0];
			Audio = AudioOptions[0];
			Caption = CaptionOptions[0];
			P2i = P2iOptions[0];
			Edid = EdidOptions[0];
			Send = SendOptions[0];
			#endregion
		}

		public Plus2_ChannelSetupForm(string target_url)
		{
			TargetUrl = target_url;
			#region 公共初始化
			// 所有构造函数的重载都要执行的初始化
			Country = CountryOptions[0];
			Channel = ChannelOptions[0];
			Level = LevelOptions[0];
			Video = VideoOptions[0];
			Audio = AudioOptions[0];
			Caption = CaptionOptions[0];
			P2i = P2iOptions[0];
			Edid = EdidOptions[0];
			Send = SendOptions[0];
			#endregion
		}

		public string TargetUrl { get; set; } = "192.168.1.15";

		#region 表单项
		public string Country { get; set; }
		public string Channel { get; set; }
		public string Freq { get; set; } = "522.000";
		public string Level { get; set; }
		public string Video { get; set; }
		public string Audio { get; set; }
		public string Caption { get; set; }
		public int Major { get; set; } = 77;
		public int Minor { get; set; } = 1;
		public int LCN1 { get; set; } = 100;
		public string PN1 { get; set; } = "PVI HD1";
		public string P2i { get; set; }
		public string Edid { get; set; }
		public string Send { get; set; }
		#endregion

		#region 表单选项数据库
		// 数据库对象的引用是只读的，不允许更改数据库。但是，数据库内部的成员可以更改
		public readonly string[] CountryOptions = new string[]
		{
			"China",
			"Hongkong",
		};
		public readonly string[] ChannelOptions = new string[]
		{
			"21 (474.0 MHz)",
			"22 (482.0 MHz)",
			"23 (490.0 MHz)",
			"24 (498.0 MHz)",
			"25 (506.0 MHz)",
			"26 (514.0 MHz)",
			"27 (522.0 MHz)",
			"28 (530.0 MHz)",
			"29 (538.0 MHz)",
			"30 (546.0 MHz)",
			"31 (554.0 MHz)",
			"32 (562.0 MHz)",
			"33 (570.0 MHz)",
			"34 (578.0 MHz)",
			"35 (586.0 MHz)",
			"36 (594.0 MHz)",
			"37 (602.0 MHz)",
			"38 (610.0 MHz)",
			"39 (618.0 MHz)",
			"40 (626.0 MHz)",
			"41 (634.0 MHz)",
			"42 (642.0 MHz)",
			"43 (650.0 MHz)",
			"44 (658.0 MHz)",
			"45 (666.0 MHz)",
			"46 (674.0 MHz)",
			"47 (682.0 MHz)",
			"48 (690.0 MHz)",
			"49 (698.0 MHz)",
			"50 (706.0 MHz)",
			"51 (714.0 MHz)",
			"52 (722.0 MHz)",
			"53 (730.0 MHz)",
			"54 (738.0 MHz)",
			"55 (746.0 MHz)",
			"56 (754.0 MHz)",
			"57 (762.0 MHz)",
			"58 (770.0 MHz)",
			"59 (778.0 MHz)",
			"60 (786.0 MHz)",
			"61 (794.0 MHz)",
			"62 (802.0 MHz)",
			"63 (810.0 MHz)",
			"64 (818.0 MHz)",
			"65 (826.0 MHz)",
			"66 (834.0 MHz)",
			"67 (842.0 MHz)",
			"68 (850.0 MHz)",
			"69 (858.0 MHz)",
		};
		public readonly string[] LevelOptions = new string[]
		{
			"45 dBmV",
			"44 dBmV",
			"43 dBmV",
			"42 dBmV",
			"41 dBmV",
			"40 dBmV",
			"39 dBmV",
			"38 dBmV",
			"37 dBmV",
			"36 dBmV",
			"35 dBmV",
			"34 dBmV",
			"33 dBmV",
			"32 dBmV",
			"31 dBmV",
			"30 dBmV",
			"29 dBmV",
			"28 dBmV",
			"27 dBmV",
			"26 dBmV",
			"25 dBmV",
		};
		public readonly string[] VideoOptions = new string[]
		{
			"HDMI",
		};
		public readonly string[] AudioOptions = new string[]
		{
			"HDMI AUDIO",
		};
		public readonly string[] CaptionOptions = new string[]
		{
			"Off",
		};
		public readonly string[] P2iOptions = new string[]
		{
			"Auto",
			"Interlace",
		};
		public readonly string[] EdidOptions = new string[]
		{
			"Auto",
			"1080p",
			"1080i",
			"720p",
		};
		public readonly string[] SendOptions = new string[]
		{
			"Save",
			"Cancel",
		};
		#endregion

		#region 私有字段, 属性
		private HttpClient _http_client = new HttpClient();
		#endregion

		public override string ToString()
		{
			return GetPostString();
		}

		public string GetPostString()
		{
			return $"country={Country}&" +
				$"channel={Channel}&" +
				$"freq={Freq}&" +
				$"level={Level}&" +
				$"video={Video}&" +
				$"audio={Audio}&" +
				$"Caption={Caption}&" +
				$"major={Major}&" +
				$"minor={Minor}&" +
				$"LCN1={LCN1}&" +
				$"PN1={PN1}&" +
				$"p2i={P2i}&" +
				$"edid={Edid}&" +
				$"send={Send}";
		}

		public string ParseHtmlString(string html)
		{
			throw new NotImplementedException();
		}

		public Task<bool> PostAsync()
		{
			throw new NotImplementedException();
		}
	}
}
