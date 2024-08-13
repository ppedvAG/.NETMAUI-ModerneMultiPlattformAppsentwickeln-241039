using System.Collections.ObjectModel;

namespace M007;

public partial class MainPage : ContentPage
{
	public string Eingabe { get; set; } = "Hallo";

	public Person person { get; set; } = new();

	public ObservableCollection<int> Zahlen { get; set; } = new();

	public ObservableCollection<Person> Personen { get; set; } = new();

	public List<DayOfWeek> Wochentage { get; set; } = Enum.GetValues<DayOfWeek>().ToList();

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await DisplayAlert("Neue Person", person.Vorname, "OK");
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		person.Vorname = Random.Shared.Next().ToString();
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		Zahlen.Add(Random.Shared.Next());
	}

	private void Button_Clicked_3(object sender, EventArgs e)
	{
		Personen.Add(new Person() { Vorname = "Max " + Random.Shared.Next() });
	}
}
