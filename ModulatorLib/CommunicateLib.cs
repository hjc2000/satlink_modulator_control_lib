
namespace ModulatorLib
{
	/// <summary>
	/// 用来模拟HTML表单。这里定义所有机型通用的html表单接口
	/// </summary>
	public interface IHtmlForm
	{
		/// <summary>
		/// 表单要发送到的的目标URL
		/// </summary>
		public string TargetUrl { get; set; }

		/// <summary>
		/// 获取表单的POST提交字符串
		/// </summary>
		/// <returns></returns>
		public string GetPostString();

		/// <summary>
		/// 解析html字符串,从而更新此类中储存的表单数据
		/// </summary>
		/// <param name="html"></param>
		/// <returns></returns>
		public string ParseHtmlString(string html);

		/// <summary>
		/// 向调制器发送表单数据
		/// </summary>
		/// <returns>成功则返回true</returns>
		public Task<bool> PostAsync();
	}

	/// <summary>
	/// Html解析器
	/// </summary>
	public class HtmlParser
	{
		/// <summary>
		/// 分析html字符串中的特定select标签,获取其具有selected属性的option子标签的内部文本
		/// </summary>
		/// <param name="name_attribute_value">
		///		select标签的name属性的值
		/// </param>
		/// <returns>
		///		option标签的内部文本
		/// </returns>
		public string ParseSelectTag(string name_attribute_value)
		{

		}

		public string ParseInputTag(string name_attribute_value)
		{

		}
	}
}
