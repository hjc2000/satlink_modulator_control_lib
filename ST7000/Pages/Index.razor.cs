using ModulatorLib;
using System.Net;

namespace ST7000.Pages
{
	public partial class Index
	{
		double _fre_display = 0;
		int _chanel_display = 0;
		//private string _sys_info_url = "http://localhost:8051/SATLINK_Modulator_files/SystemInfo.html";

		#region 生命周期函数
		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if (firstRender)
			{
				await FlushData();
			}
		}
		#endregion

		#region HTTP请求函数
		/// <summary>
		/// 从 ST7000 那重新获取设备信息
		/// </summary>
		/// <returns></returns>
		public async Task FlushData()
		{
			ST7000Lib.ChFre ch_fre = await ST7000Lib.Get_Chanel_And_Fre_From_ST7000("192.168.1.15");
			if (ch_fre.Avaliable)
			{
				_chanel_display = ch_fre.Chanel;
				_fre_display = ch_fre.Fre;
			}
			StateHasChanged();
		}

		Dictionary<int, double>.Enumerator _enumerator = ST7000Lib.ChFreMap.GetEnumerator();

		private async Task SendHttpRequest(int database_index)
		{
			if (_enumerator.MoveNext())
			{
				_chanel_display = _enumerator.Current.Key;
				_fre_display = _enumerator.Current.Value;
			}
			else
			{
				_enumerator = ST7000Lib.ChFreMap.GetEnumerator();
			}

			string ch = ST7000Lib.ChFreMap[database_index]
			string fre = _database[database_index]._fre;
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
			var httpResponse = await _client.PostAsync("http://192.168.1.15/RFSetup_ATSC_C.htm", stringContent);
			if (httpResponse.StatusCode == HttpStatusCode.OK)
			{
				string str = await httpResponse.Content.ReadAsStringAsync();
				int index_start = str.IndexOf("<option selected>", 330);
				int index_end = str.IndexOf("</option>", index_start);

				string subStr = str.Substring(index_start, index_end - index_start);
				index_start = subStr.IndexOf("(");
				subStr = subStr.Substring(index_start, subStr.Length - index_start);
				subStr = _regex.Replace(subStr, string.Empty);
				int iFre = int.Parse(subStr) / 10;
				FreDisplay = iFre.ToString();
			}
		}
		#endregion

		#region 事件处理函数
		private async Task SetToLastFre()
		{

		}

		async Task SetToNextFre()
		{

		}

		#endregion
	}
}
