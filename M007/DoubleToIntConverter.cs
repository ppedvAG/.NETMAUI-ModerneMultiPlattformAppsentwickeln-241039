using System.Globalization;

namespace M007;

public class DoubleToIntConverter : IValueConverter
{
	//Quelle -> Ziel
	//Slider -> Label
	//value: double, return: int
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		double d = (double) value;
		return (int) d;
	}

	//Ziel -> Quelle
	//Label -> Slider
	//Nicht möglich, da Label nicht angepasst werden kann
	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => 0;
}