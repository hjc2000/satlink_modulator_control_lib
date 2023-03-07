using HtmlAgilityPack;
using ModulatorLib;
using System.Net;

namespace ST7000.Pages
{
	public partial class Index
	{
		private string DisplayText = string.Empty;
		private List<string> StringList = new List<string>() { string.Empty };
		private string _sys_info_url = "http://localhost:8051/SATLINK_Modulator_files/SystemInfo.html";

		#region 事件处理函数
		private async Task OnClick()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync(_sys_info_url);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				int chanel_out;
				double fre_out;
				string html_str = await response.Content.ReadAsStringAsync();
				if (ST7000Lib.GetChanel_And_Fre_FromHtml(html_str, out chanel_out, out fre_out))
				{
					DisplayText = $"信道：{chanel_out}，频率：{fre_out}";
				}
			}
		}
		#endregion
	}
}
