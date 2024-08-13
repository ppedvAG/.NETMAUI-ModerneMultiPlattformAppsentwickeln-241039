using System.ComponentModel;

namespace M007;

public class Person : INotifyPropertyChanged
{
	private string _vorname;

	public string Vorname
	{
		get => _vorname;
		set
		{
			_vorname = value;
			Notify(nameof(Vorname));
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

	//public void Notify([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}