using Windows.Graphics.Display;

namespace M008;

public partial class OrientationService
{
	public partial Orientation GetOrientation()
	{
		DisplayOrientations o = DisplayInformation.GetForCurrentView().CurrentOrientation;
		return o == DisplayOrientations.Portrait || o == DisplayOrientations.PortraitFlipped ? Orientation.Portrait : Orientation.Landscape;
	}
}