namespace M008;

public partial class OrientationService
{
	/// <summary>
	/// Hier wird eine Partielle Klasse + Methode angelegt, welche pro Plattform eine Implementation benötigt
	/// 
	/// D.h. in jeder Platform (Android, iOS, Mac, Tizen, Windows) wird nun eine Implementation benötigt
	/// WICHTIG: Die partiellen Klassen in den Plattformen müssen den selben Namespace haben wie diese Klasse hier
	/// </summary>
	public partial Orientation GetOrientation();
}