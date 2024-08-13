namespace M009;

[QueryProperty(nameof(DeliveredContent), "content1")]
public partial class SecondaryPage : ContentPage
{
	private string x;

	public string DeliveredContent { set => x = value; }

	public SecondaryPage()
	{
		InitializeComponent();
	}
}