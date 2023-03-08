using ModulatorLib;

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
