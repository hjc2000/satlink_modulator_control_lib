namespace ModulatorLib
{
	/// <summary>
	/// 用来模拟HTML表单
	/// </summary>
	internal interface IHtmlForm
	{
		/// <summary>
		/// 获取表单的POST提交字符串
		/// </summary>
		/// <returns></returns>
		public string GetPostString();
	}

	/// <summary>
	/// 与调制器的通信接口
	/// </summary>
	internal interface ICommunicate
	{
		/// <summary>
		/// 调制器的IP地址和端口号。例如 "192.168.1.15:80"
		/// </summary>
		public string IPAddressAndPort { get; set; }

		public HttpClient Http_Client { get; set; }
	}
}
