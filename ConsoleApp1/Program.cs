using System.Net;
using System.Text.RegularExpressions;

Regex _regex = new Regex(@"\D");
Fre[] database =
{
	 new Fre{_ch="2",  _fre="57.0"},
	 new Fre{_ch="3 ",  _fre="63.0"},
	 new Fre{_ch="4 ",  _fre="69.0"},
	 new Fre{_ch="5 ",  _fre="79.0"},
	 new Fre{_ch="6 ",  _fre="85.0"},
	 new Fre{_ch="7 ",  _fre="177.0"},
	 new Fre{_ch="8 ",  _fre="183.0"},
	 new Fre{_ch="9 ",  _fre="189.0"},
	 new Fre{_ch="10 ",  _fre="195.0"},
	 new Fre{_ch="11 ",  _fre="201.0"},
	 new Fre{_ch="12 ",  _fre="207.0"},
	 new Fre{_ch="13 ",  _fre="213.0"},
	 new Fre{_ch="14 ",  _fre="123.0"},
	 new Fre{_ch="15 ",  _fre="129.0"},
	 new Fre{_ch="16 ",  _fre="135.0"},
	 new Fre{_ch="17 ",  _fre="141.0"},
	 new Fre{_ch="18 ",  _fre="147.0"},
	 new Fre{_ch="19 ",  _fre="153.0"},
	 new Fre{_ch="20 ",  _fre="159.0"},
	 new Fre{_ch="21 ",  _fre="165.0"},
	 new Fre{_ch="22 ",  _fre="171.0"},
	 new Fre{_ch="23 ",  _fre="219.0"},
	 new Fre{_ch="24 ",  _fre="225.0"},
	 new Fre{_ch="25 ",  _fre="231.0"},
	 new Fre{_ch="26 ",  _fre="237.0"},
	 new Fre{_ch="27 ",  _fre="243.0"},
	 new Fre{_ch="28 ",  _fre="249.0"},
	 new Fre{_ch="29 ",  _fre="255.0"},
	 new Fre{_ch="30 ",  _fre="261.0"},
	 new Fre{_ch="31 ",  _fre="267.0"},
	 new Fre{_ch="32 ",  _fre="273.0"},
	 new Fre{_ch="33 ",  _fre="279.0"},
	 new Fre{_ch="34 ",  _fre="285.0"},
	 new Fre{_ch="35 ",  _fre="291.0"},
	 new Fre{_ch="36 ",  _fre="297.0"},
	 new Fre{_ch="37 ",  _fre="303.0"},
	 new Fre{_ch="38 ",  _fre="309.0"},
	 new Fre{_ch="39 ",  _fre="315.0"},
	 new Fre{_ch="40 ",  _fre="321.0"},
	 new Fre{_ch="41 ",  _fre="327.0"},
	 new Fre{_ch="42 ",  _fre="333.0"},
	 new Fre{_ch="43 ",  _fre="339.0"},
	 new Fre{_ch="44 ",  _fre="345.0"},
	 new Fre{_ch="45 ",  _fre="351.0"},
	 new Fre{_ch="46 ",  _fre="357.0"},
	 new Fre{_ch="47 ",  _fre="363.0"},
	 new Fre{_ch="48 ",  _fre="369.0"},
	 new Fre{_ch="49 ",  _fre="375.0"},
	 new Fre{_ch="50 ",  _fre="381.0"},
	 new Fre{_ch="51 ",  _fre="387.0"},
	 new Fre{_ch="52 ",  _fre="393.0"},
	 new Fre{_ch="53 ",  _fre="399.0"},
	 new Fre{_ch="54 ",  _fre="405.0"},
	 new Fre{_ch="55 ",  _fre="411.0"},
	 new Fre{_ch="56 ",  _fre="417.0"},
	 new Fre{_ch="57 ",  _fre="423.0"},
	 new Fre{_ch="58 ",  _fre="429.0"},
	 new Fre{_ch="59 ",  _fre="435.0"},
	 new Fre{_ch="60 ",  _fre="441.0"},
	 new Fre{_ch="61 ",  _fre="447.0"},
	 new Fre{_ch="62 ",  _fre="453.0"},
	 new Fre{_ch="63 ",  _fre="459.0"},
	 new Fre{_ch="64 ",  _fre="465.0"},
	 new Fre{_ch="65 ",  _fre="471.0"},
	 new Fre{_ch="66 ",  _fre="477.0"},
	 new Fre{_ch="67 ",  _fre="483.0"},
	 new Fre{_ch="68 ",  _fre="489.0"},
	 new Fre{_ch="69 ",  _fre="495.0"},
	 new Fre{_ch="70 ",  _fre="501.0"},
	 new Fre{_ch="71 ",  _fre="507.0"},
	 new Fre{_ch="72 ",  _fre="513.0"},
	 new Fre{_ch="73 ",  _fre="519.0"},
	 new Fre{_ch="74 ",  _fre="525.0"},
	 new Fre{_ch="75 ",  _fre="531.0"},
	 new Fre{_ch="76 ",  _fre="537.0"},
	 new Fre{_ch="77 ",  _fre="543.0"},
	 new Fre{_ch="78 ",  _fre="549.0"},
	 new Fre{_ch="79 ",  _fre="555.0"},
	 new Fre{_ch="80 ",  _fre="561.0"},
	 new Fre{_ch="81 ",  _fre="567.0"},
	 new Fre{_ch="82 ",  _fre="573.0"},
	 new Fre{_ch="83 ",  _fre="579.0"},
	 new Fre{_ch="84 ",  _fre="585.0"},
	 new Fre{_ch="85 ",  _fre="591.0"},
	 new Fre{_ch="86 ",  _fre="597.0"},
	 new Fre{_ch="87 ",  _fre="603.0"},
	 new Fre{_ch="88 ",  _fre="609.0"},
	 new Fre{_ch="89 ",  _fre="615.0"},
	 new Fre{_ch="90 ",  _fre="621.0"},
	 new Fre{_ch="91 ",  _fre="627.0"},
	 new Fre{_ch="92 ",  _fre="633.0"},
	 new Fre{_ch="93 ",  _fre="639.0"},
	 new Fre{_ch="94 ",  _fre="645.0"},
	 new Fre{_ch="95 ",  _fre="93.0"},
	 new Fre{_ch="96 ",  _fre="99.0"},
	 new Fre{_ch="97 ",  _fre="105.0"},
	 new Fre{_ch="98 ",  _fre="111.0"},
	 new Fre{_ch="99 ",  _fre="117.0"},
	 new Fre{_ch="100 ",  _fre="651.0"},
	 new Fre{_ch="101 ",  _fre="657.0"},
	 new Fre{_ch="102 ",  _fre="663.0"},
	 new Fre{_ch="103 ",  _fre="669.0"},
	 new Fre{_ch="104 ",  _fre="675.0"},
	 new Fre{_ch="105 ",  _fre="681.0"},
	 new Fre{_ch="106 ",  _fre="687.0"},
	 new Fre{_ch="107 ",  _fre="693.0"},
	 new Fre{_ch="108 ",  _fre="699.0"},
	 new Fre{_ch="109 ",  _fre="705.0"},
	 new Fre{_ch="110 ",  _fre="711.0"},
	 new Fre{_ch="111 ",  _fre="717.0"},
	 new Fre{_ch="112 ",  _fre="723.0"},
	 new Fre{_ch="113 ",  _fre="729.0"},
	 new Fre{_ch="114 ",  _fre="735.0"},
	 new Fre{_ch="115 ",  _fre="741.0"},
	 new Fre{_ch="116 ",  _fre="747.0"},
	 new Fre{_ch="117 ",  _fre="753.0"},
	 new Fre{_ch="118 ",  _fre="759.0"},
	 new Fre{_ch="119 ",  _fre="765.0"},
	 new Fre{_ch="120 ",  _fre="771.0"},
	 new Fre{_ch="121 ",  _fre="777.0"},
	 new Fre{_ch="122 ",  _fre="783.0"},
	 new Fre{_ch="123 ",  _fre="789.0"},
	 new Fre{_ch="124 ",  _fre="795.0"},
	 new Fre{_ch="125 ",  _fre="801.0"},
	 new Fre{_ch="126 ",  _fre="807.0"},
	 new Fre{_ch="127 ",  _fre="813.0"},
	 new Fre{_ch="128 ",  _fre="819.0"},
	 new Fre{_ch="129 ",  _fre="825.0"},
	 new Fre{_ch="130 ",  _fre="831.0"},
	 new Fre{_ch="131 ",  _fre="837.0"},
	 new Fre{_ch="132 ",  _fre="843.0"},
	 new Fre{_ch="133 ",  _fre="849.0"},
	 new Fre{_ch="134 ",  _fre="855.0"},
	 new Fre{_ch="135 ",  _fre="861.0"},
	 new Fre{_ch="136 ",  _fre="867.0"},
	 new Fre{_ch="137 ",  _fre="873.0"},
	 new Fre{_ch="138 ",  _fre="879.0"},
	 new Fre{_ch="139 ",  _fre="885.0"},
	 new Fre{_ch="140 ",  _fre="891.0"},
	 new Fre{_ch="141 ",  _fre="897.0"},
	 new Fre{_ch="142 ",  _fre="903.0"},
	 new Fre{_ch="143 ",  _fre="909.0"},
	 new Fre{_ch="144 ",  _fre="915.0"},
	 new Fre{_ch="145 ",  _fre="921.0"},
	 new Fre{_ch="146 ",  _fre="927.0"},
	 new Fre{_ch="147 ",  _fre="933.0"},
	 new Fre{_ch="148 ",  _fre="939.0"},
	 new Fre{_ch="149 ",  _fre="945.0"},
	 new Fre{_ch="150 ",  _fre="951.0"},
	 new Fre{_ch="151 ",  _fre="957.0"},
	 new Fre{_ch="152 ",  _fre="963.0"},
	 new Fre{_ch="153 ",  _fre="969.0"},
	 new Fre{_ch="154 ",  _fre="975.0"},
	 new Fre{_ch="155 ",  _fre="981.0"},
	 new Fre{_ch="156 ",  _fre="987.0"},
	 new Fre{_ch="157 ",  _fre="993.0"},
	 new Fre{_ch="158 ",  _fre="999.0"},
};

int i = 0;
while (true)
{
	Console.WriteLine("点击回车切换频率");
	Console.WriteLine($"下一个频率：{database[i]._fre}");
	Console.ReadLine();
	string ch = database[i]._ch;
	string fre = database[i]._fre;
	i++;
	if (i >= database.Length)
	{
		i = 0;
	}
	HttpClient client = new HttpClient();
	//StringContent stringContent = new StringContent("country=ATSC_Cable&channel=134+%28855.0+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save");
	// country=ATSC_Cable&channel=2+%28+57.0+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save
	// country=ATSC_Cable&channel=9+%28189.0+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save
	double numFre = double.Parse(fre);
	StringContent stringContent;
	if (numFre < 100)
	{
		stringContent = new StringContent($"country=ATSC_Cable&channel={ch}+%28+{fre}+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save");
	}
	else
	{
		stringContent = new StringContent($"country=ATSC_Cable&channel={ch}+%28{fre}+MHz%29&major=66&minor=1&constell=64QAM&level=100+dBuV&send=Save");
	}
	HttpResponseMessage httpResponse = await client.PostAsync("http://192.168.1.15/RFSetup_ATSC_C.htm", stringContent);
	if (httpResponse.StatusCode == HttpStatusCode.OK)
	{
		string str = await httpResponse.Content.ReadAsStringAsync();
		Console.WriteLine(str);
		int index_start = str.IndexOf("<option selected>", 330);
		int index_end = str.IndexOf("</option>", index_start);
		string subStr = str.Substring(index_start, index_end - index_start);
		index_start = subStr.IndexOf("(");
		subStr = subStr.Substring(index_start, subStr.Length - index_start);
		subStr = _regex.Replace(subStr, string.Empty);
		Console.WriteLine(subStr);
		int iFre = int.Parse(subStr) / 10;
	}
}

internal class Fre
{
	public string _ch = string.Empty;
	public string _fre = string.Empty;
}