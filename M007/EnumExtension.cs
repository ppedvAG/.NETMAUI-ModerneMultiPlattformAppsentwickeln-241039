namespace M007;

public class EnumExtension : IMarkupExtension
{
	public Type EnumType { get; set; }

	/// <summary>
	/// Wenn die GUI bei einem Binding einen Wert benötigt, wird diese Methode aufgerufen
	/// 
	/// Aufgabe: Hier wird ein Enum Typ verlangt, dieser wird hier ausgepackt und an die GUI weitergegeben
	/// </summary>
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		if (EnumType == null)
			throw new ArgumentNullException(nameof(EnumType));

		if (!EnumType.IsEnum)
			throw new ArgumentException("Type muss ein Enum Typ sein");

		return Enum.GetValues(EnumType);
	}
}