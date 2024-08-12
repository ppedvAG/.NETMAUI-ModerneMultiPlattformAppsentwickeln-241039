namespace M006;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		double fs = (double) this.Resources["GlobalFontSize"];
		this.Resources["GlobalFontSize"] = ++fs;
	}
}