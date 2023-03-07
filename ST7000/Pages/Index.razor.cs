using HtmlAgilityPack;
using System.Net;

namespace ST7000.Pages
{
	public partial class Index
	{
		private string DisplayText = string.Empty;
		private List<string> StringList = new List<string>() { string.Empty };
		private HtmlWeb _html_web = new HtmlWeb();
		private string _sys_info_url = "http://localhost:8051/SATLINK_Modulator_files/SystemInfo.html";

		#region 事件处理函数
		private async Task OnClick()
		{
			HttpClient client = new HttpClient();
			HttpResponseMessage response = await client.GetAsync(_sys_info_url);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				string str = await response.Content.ReadAsStringAsync();
				HtmlDocument doc = new HtmlDocument();
				doc.LoadHtml(str);
				HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//select");
				foreach (HtmlNode node in nodes)
				{
					StringList.Add(node?.Attributes["name"]?.Value);
				}
			}
		}
		#endregion
	}
}
