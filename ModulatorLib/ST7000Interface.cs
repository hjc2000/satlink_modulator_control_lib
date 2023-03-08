namespace ModulatorLib
{
	/// <summary>
	/// 调制器操作者<br></br>
	/// 所有不同的调制器的操作类都要继承该接口
	/// </summary>
	public interface IModulatorOperator
	{
		/// <summary>
		/// 预置的信道数据库，key为信道号，value为频率
		/// </summary>
		public Dictionary<int, int> ChannelDictionary { get; set; }

		/// <summary>
		/// 调制器的IP地址
		/// </summary>
		public string IPAddress { get; set; }

		/// <summary>
		///		设置信道		<br/>
		///		RF线使用频分复用来得到几个信道。通过设置信道号，将调制器当前频率设置为
		///		预置数据库中的值
		/// </summary>
		/// <param name="channel">
		///		信道号
		/// </param>
		/// <returns>
		///		success: 是否设置成功。成功时另外两个参数才有效
		///		channel: 信道号
		///		frequency: 频率
		/// </returns>
		public Task<(bool success, int channel, int frequency)> SetCurrentChannelAsync(int channel);

		/// <summary>
		///		获取当前的信道
		/// </summary>
		/// <returns>
		///		返回元组<br></br>
		///		success=true时表示获取成功，此时channel的值有效
		/// </returns>
		public Task<(bool success, int channel, int frequency)> GetCurrentChannelAsync();
	}
}
