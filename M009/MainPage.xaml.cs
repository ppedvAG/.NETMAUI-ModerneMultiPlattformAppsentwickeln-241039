namespace M009;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		//Navigation zu einer anderen Page (mit Zurückbutton)
		//Navigation.PushAsync(new SecondaryPage());

		//Navigation zu einer anderen Page (ohne Zurückbutton)
		//Navigation.PushModalAsync(new SecondaryPage());

		//Navigation.PushAsync(new Tabs());

		string x = "Hallo_von_MainPage";
		await Shell.Current.GoToAsync($"//Page2?content1={x}");
	}
}
