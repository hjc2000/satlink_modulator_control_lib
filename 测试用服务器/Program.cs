using Microsoft.AspNetCore.StaticFiles;

#region 设置服务器根路径
string _webRootPath = @"D:\my_files\workspace\我的网站\ESP32配网\wwwroot";
//if (args.Length > 0)
//{
//	_webRootPath = args[0];
//}
#endregion

#region 创建应用
var options = new WebApplicationOptions
{
	ContentRootPath = _webRootPath,
	WebRootPath = _webRootPath,
};
var builder = WebApplication.CreateBuilder(options);
var app = builder.Build();
#endregion

#region 设置服务器监听的URL
app.Urls.Clear();
app.Urls.Add("http://localhost:8051");
#endregion

app.UseRouting();//使用路由中间件
/// <summary>
/// 将非文件请求重定向到根路径，通过含有点号来判断是一个文件。注意，必须
/// 放到文件中间件前面，紧挨着，否则会让路由中间件失效
/// 为什么要重定向？因为web选择了一个路由的路径后刷新页面，会导致浏览器直接从
/// 路由路径向服务器请求，而这里没有任何东西，会导致返回404
/// </summary>
app.Use(async (context, next) =>
{
	if (!context.Request.Path.ToString().Contains('.'))
	{
		context.Request.Path = new PathString("/");
	}
	await next();
});

#region 设置静态文件服务
/// <summary>
/// 文件content-type提供者
/// </summary>
var provider = new FileExtensionContentTypeProvider();
/**添加mime表的内容。如果不添加，provider 的默认mime表内没有dll等文件的
 * content-type，会造成浏览器接收文件后以错误的方式处理
 */
provider.Mappings[".dll"] = "application/octet-stream";
provider.Mappings[".dat"] = "application/octet-stream";
provider.Mappings[".blat"] = "application/octet-stream";
/// <summary>
/// 使用默认文件中间件
/// </summary>
app.UseDefaultFiles();
/// <summary>
/// 使用静态文件中间件
/// </summary>
app.UseStaticFiles(new StaticFileOptions
{
	ContentTypeProvider = provider,//文件content-type提供者
	ServeUnknownFileTypes = true,//对未知类型的文件提供服务
	DefaultContentType = "application/octet-stream",//未知的文件类型的content-type
});
#endregion

app.Run();
