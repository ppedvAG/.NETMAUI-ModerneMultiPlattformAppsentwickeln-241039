namespace M003;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		//DisplayAlert: Dem Benutzer eine Frage stellen
		bool result = await DisplayAlert("Eingabe speichern?", "Möchtest du die Eingabe speichen?", "Ja", "Nein");
		if (result)
			Output.Text = Eingabe.Text;
	}
}
