using Android.Content;
using Android.Nfc;
using Android.Runtime;
using Android.Views;

namespace M008;

public partial class OrientationService
{
	public partial Orientation GetOrientation()
	{
		IWindowManager wm = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
		SurfaceOrientation o = wm.DefaultDisplay.Rotation;
		return o == SurfaceOrientation.Rotation0 || o == SurfaceOrientation.Rotation180 ? Orientation.Portrait : Orientation.Landscape;
	}
}