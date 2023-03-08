using ModulatorLib;

namespace ST7000.Pages
{
	public partial class Index
	{
		private ST7000Operator _st7000_operator = new ST7000Operator("localhost:8051");
		private double _fre_display = 0;
		private int _chanel_display = 0;

		#region 生命周期函数
		protected override async Task OnInitializedAsync()
		{
			await FlushData();
		}
		#endregion

		#region HTTP请求函数
		/// <summary>
		/// 从 ST7000 那重新获取设备信息
		/// </summary>
		/// <returns></returns>
		public async Task FlushData()
		{
			(bool avaliable, int chanel, int frequency) = await _st7000_operator.GetCurrentChannelAsync();

			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
		}
		#endregion

		#region 事件处理函数

		#endregion
	}
}
