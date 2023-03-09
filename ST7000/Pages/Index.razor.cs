using ModulatorLib;

namespace ST7000.Pages
{
	public partial class Index
	{
		public Index()
		{
			_select_level = _st7000_operator.Database.LevelList[0];
		}

		private ST7000Operator _st7000_operator = new ST7000Operator("localhost:8051");
		//private ST7000Operator _st7000_operator = new ST7000Operator();

		#region 绑定属性
		private double _fre_display = 0;
		private int _chanel_display = 0;

		private string _select_level;
		private string SelectedLevel
		{
			get => _select_level;
			set => _select_level = value;
		}
		#endregion

		#region 生命周期函数
		protected override async Task OnInitializedAsync()
		{
			await GetCurrentChannel();
		}
		#endregion

		#region 事件处理函数
		public async Task NextChannel()
		{
			(bool avaliable, int chanel, int frequency) = await _st7000_operator.GoToNextChannelAsync();
			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
		}

		public async Task PreviousChannel()
		{
			(bool avaliable, int chanel, int frequency) = await _st7000_operator.GoToPreviousChannelAsync();
			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
		}

		/// <summary>
		/// 从 ST7000 那重新获取信道信息
		/// </summary>
		/// <returns></returns>
		public async Task GetCurrentChannel()
		{
			(bool avaliable, int chanel, int frequency) = await _st7000_operator.GetCurrentChannelAsync();
			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
		}

		/// <summary>
		/// 将信道重置为第一个信道
		/// </summary>
		/// <returns></returns>
		public async Task ResetChannel()
		{
			(bool avaliable, int chanel, int frequency) = await _st7000_operator.GoToTheFirstChannelAsync();
			if (avaliable)
			{
				_chanel_display = chanel;
				_fre_display = frequency;
			}
		}
		#endregion
	}
}
