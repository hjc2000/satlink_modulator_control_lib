using ModulatorLib;

HttpClient client = new HttpClient();
string requestUrl = @"http://localhost:8051/Modulator_files/MainInfo.html";
//string requestUrl = @"http://www.baidu.com/";
HttpResponseMessage responseMessage = await client.GetAsync(requestUrl);
if (responseMessage.IsSuccessStatusCode)
{
	HttpContent content = responseMessage.Content;
	string response = await content.ReadAsStringAsync();
	HtmlForm htmlForm = new HtmlForm();
	htmlForm.ParseHtml(response);
	SelectTag selectTag = (SelectTag)htmlForm["channel"];
	List<string> options = selectTag.Options;
	foreach (string option in options)
	{
		Console.WriteLine(option);
	}

	Console.WriteLine("----------------------------------------");
	Console.WriteLine(htmlForm.ToString());
}