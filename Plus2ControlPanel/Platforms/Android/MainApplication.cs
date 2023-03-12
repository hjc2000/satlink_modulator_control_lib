using Android.App;
using Android.Runtime;

namespace Plus2ControlPanel
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}

		protected override MauiApp CreateMauiApp()
		{
			return MauiProgram.CreateMauiApp();
		}
	}
}