namespace ModulatorLib
{
	public class ST7000OptionsDatabase : IOptionsDatabase
	{
		public string[] ChannelList { get; set; } = new string[]
	   {
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
		public string[] LevelList { get; set; } = new string[]
	   {
			"100 dBuV",
			"99 dBuV",
			"98 dBuV",
			"97 dBuV",
			"96 dBuV",
			"95 dBuV",
			"94 dBuV",
			"93 dBuV",
			"92 dBuV",
			"91 dBuV",
			"90 dBuV",
			"89 dBuV",
			"88 dBuV",
			"87 dBuV",
			"86 dBuV",
			"85 dBuV",
			"84 dBuV",
			"83 dBuV",
			"82 dBuV",
			"81 dBuV",
			"80 dBuV",
			"79 dBuV",
			"78 dBuV",
			"77 dBuV",
			"76 dBuV",
			"75 dBuV",
			"74 dBuV",
			"73 dBuV",
			"72 dBuV",
			"71 dBuV",
			"70 dBuV",
			"69 dBuV",
	   };

		private int _channel_index = 0;

		int _level_index = 0;

		/// <summary>
		/// 将实际的信道号与本类的数据结构进行同步
		/// </summary>
		/// <param name="channel"></param>
		/// <exception cref="Exception"></exception>
		public void SyncChannel(string channel)
		{
			try
			{
				(_, int ch, _) = channel.ParseChannel();
				_channel_index = ch;
			}
			catch
			{
				throw new Exception("信道字符串非法");
			}

			if (_channel_index < 0 || _channel_index >= ChannelList.Length)
			{
				throw new Exception("数据库中没有此信道编号");
			}
		}

		/// <summary>
		/// 同步强度值
		/// </summary>
		/// <param name="level"></param>
		/// <exception cref="Exception">数据库中没有此强度值</exception>
		public void SyncLevel(string level)
		{
			for (_level_index = 0; _level_index < LevelList.Length; _level_index++)
			{
				if (LevelList[_level_index] == level)
				{
					return;
				}
			}
			throw new Exception("数据库中找不到此level值");
		}

		public string GetFirstLevel()
		{
			_level_index = 0;
			return LevelList[0];
		}

		public string GetLastLevel()
		{
			_level_index = LevelList.Length - 1;
			return LevelList[^1];
		}

		public string GetNextLevel()
		{
			_level_index++;
			if (_level_index >= LevelList.Length)
			{
				_level_index = 0;
			}
			return LevelList[_level_index];
		}

		public string GetPreviousLevel()
		{
			_level_index--;
			if (_level_index < 0)
			{
				_level_index = LevelList.Length - 1;
			}
			return LevelList[_level_index];
		}

		public string GetFirstChannel()
		{
			_channel_index = 0;
			return ChannelList[0];
		}

		public string GetLastChannel()
		{
			_channel_index = ChannelList.Length - 1;
			return ChannelList[^1];
		}

		public string GetNextChannel()
		{
			_channel_index++;
			if (_channel_index >= ChannelList.Length)
			{
				_channel_index = 0;
			}
			return ChannelList[_channel_index];
		}

		public string GetPreviousChannel()
		{
			_channel_index--;
			if (_channel_index < 0)
			{
				_channel_index = ChannelList.Length - 1;
			}
			return ChannelList[_channel_index];
		}
	}

	/// <summary>
	/// ST7000内置数据库
	/// </summary>
	public class ST7000Operator : IModulatorOperator, ICommunicate
	{
		#region 构造函数
		public ST7000Operator() { }
		public ST7000Operator(string ip_address_and_port)
		{
			IPAddressAndPort = ip_address_and_port;
		}
		#endregion

		public string IPAddressAndPort { get; set; } = "192.168.1.15:80";
		public HttpClient Http_Client { get; set; } = new HttpClient();
		public ST7000OptionsDatabase Database { get; set; } = new ST7000OptionsDatabase();

		#region 实现的接口函数
		public async Task<(bool success, int channel, int frequency)> SetChannelAsync(int channel)
		{
			return (false, 0, 0);
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
				return this.ParseChannelFromHtmlStr(html_str);
			}
			return (false, 0, 0);
		}

		public async Task<(bool success, int channel, int frequency)> GoToNextChannelAsync()
		{
			string post_str = $"country=ATSC_Cable&channel={Database.GetNextChannel()}&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save";
			return await this.SendChannelSetupCommand(post_str);
		}

		public async Task<(bool success, int channel, int frequency)> GoToPreviousChannelAsync()
		{
			string post_str = $"country=ATSC_Cable&channel={Database.GetPreviousChannel()}&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save";
			return await this.SendChannelSetupCommand(post_str);
		}

		public async Task<(bool success, int channel, int frequency)> GoToTheFirstChannelAsync()
		{
			string post_str = $"country=ATSC_Cable&channel={Database.GetFirstChannel()}&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save";
			return await this.SendChannelSetupCommand(post_str);
		}

		public async Task<(bool success, int channel, int frequency)> GoToTheLastChannelAsync()
		{
			string post_str = $"country=ATSC_Cable&channel={Database.GetLastChannel()}&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save";
			return await this.SendChannelSetupCommand(post_str);
		}

		public Task<(bool success, int level)> SetLevelAsync(string level_str)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
