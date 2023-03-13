using ModulatorLib;

namespace Plus2ControlPanel.Pages
{
	public partial class Index
	{
#nullable enable
		private HtmlForm _form = new();
		private HttpClient _client = new();

		//string _requestUrl = @"http://localhost:8051/Modulator_files/MainInfo.html";
		private string _requestUrl = @"http://192.168.1.15/ChannelSetup.htm";
		private SelectTag? _channelSelectTag = null;
		private int _channelIndex = 0;

		private void ParseHtml(string response)
		{
			_form.ParseHtml(response);
			_form.Items.Remove("send");
			_form.Items.Remove("freq");

			_channelSelectTag = (SelectTag)_form["channel"];
			_channelIndex = _channelSelectTag.Options.FindIndex((str) =>
			{
				if (str == _channelSelectTag.Value)
				{
					return true;
				}

				return false;
			});
		}

		private async void OnSubmitButtonClick()
		{
			string postStr = _form.ToString();
			StringContent stringContent = new StringContent(postStr);
			HttpResponseMessage message = await _client.PostAsync(_requestUrl, stringContent);
			string response = await message.Content.ReadAsStringAsync();
			ParseHtml(response);
			StateHasChanged();
		}

		private void OnNextFreq()
		{
			if (_channelSelectTag != null)
			{
				_channelIndex++;
				if (_channelIndex >= _channelSelectTag.Options.Count)
				{
					_channelIndex = 0;
				}

				_channelSelectTag.Value = _channelSelectTag.Options[_channelIndex];
				OnSubmitButtonClick();
			}
		}

		private async Task OnFlush()
		{
			HttpResponseMessage responseMessage = await _client.GetAsync(_requestUrl);
			if (responseMessage.IsSuccessStatusCode)
			{
				HttpContent content = responseMessage.Content;
				string response = await content.ReadAsStringAsync();
				ParseHtml(response);
			}
		}
	}
}
