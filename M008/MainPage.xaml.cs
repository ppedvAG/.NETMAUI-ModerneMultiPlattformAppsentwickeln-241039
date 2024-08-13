namespace M008;

public partial class MainPage : ContentPage
{
	public string CurrentDevice { get; set; }

	public MainPage()
	{
		CurrentDevice = DeviceInfo.Name;

		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		OrientationService orientation = new OrientationService();
		orientation.GetOrientation();

		//MAUI Essentials
		//Statische Klassen, welche die APIs wegabstrahieren
		//Microsoft.Maui.Devices
	}
}
