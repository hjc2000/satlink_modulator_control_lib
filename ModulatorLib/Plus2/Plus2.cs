namespace ModulatorLib.Plus2
{
	public class Plus2DTMB
	{
		/// <summary>
		/// ChannelSetup的表单
		/// </summary>
		public HtmlForm _channelSetupForm = new HtmlForm()
		{
			new SelectTag("country")
			{
				"China",
				"Hongkong",
			},
			new SelectTag("channel")
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
			},
			new SelectTag("freq")
			{
				"522.000",
			},
			new SelectTag("level")
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
			},
			new SelectTag("video")
			{
				"HDMI",
			},
			new SelectTag("audio")
			{
				"HDMI AUDIO",
			},
			new SelectTag("Caption")
			{
				"Off",
			},
			new SelectTag("major")
			{
				"77",
			},
			new SelectTag("minor")
			{
				"1"
			},
			new SelectTag("LCN1")
			{
				"100",
			},
			new SelectTag("PN1")
			{
				"PVI HD1",
			},
			new SelectTag("p2i")
			{
				"Auto",
				"Interlace",
			},
			new SelectTag("edid")
			{
				"Auto",
				"1080p",
				"1080i",
				"720p",
			},
			new SelectTag("send")
			{
				"Save",
				"Cancel",
			},
		};
	}
}
