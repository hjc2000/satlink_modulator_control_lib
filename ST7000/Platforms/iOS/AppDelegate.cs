using Foundation;

namespace ST7000
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp()
		{
			return MauiProgram.CreateMauiApp();
		}
	}
}