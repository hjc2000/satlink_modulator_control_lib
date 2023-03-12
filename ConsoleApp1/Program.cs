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
	foreach (string option in selectTag.Options)
	{
		Console.WriteLine(option);
	}

	Separator();
	Console.WriteLine(htmlForm.ToString());
	Separator();
	Console.WriteLine(selectTag.Type);
}

void Separator()
{
	Console.WriteLine("----------------------------------------");
}