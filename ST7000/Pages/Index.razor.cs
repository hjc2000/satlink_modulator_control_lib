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
			(bool avaliable, int chanel, int frequency) = await ST7000Lib.Get_Chanel_And_Fre_From_ST7000();

			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
			StateHasChanged();
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
