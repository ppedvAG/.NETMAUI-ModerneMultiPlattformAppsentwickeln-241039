using System.Collections.ObjectModel;

namespace M004;

public partial class MainPage : ContentPage
{
	public ObservableCollection<string> TestItems { get; set; } = new();

	public MainPage()
	{
		InitializeComponent();
		for (int i = 0; i < 10; i++)
		{
			TestItems.Add(i.ToString());
		}
	}

	private void SearchStarted(object sender, EventArgs e)
	{

	}

	private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{

	}

	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{

	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{

	}
}
