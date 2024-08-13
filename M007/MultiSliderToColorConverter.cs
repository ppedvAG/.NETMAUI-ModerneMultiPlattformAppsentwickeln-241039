using System.Globalization;

namespace M007;

public class MultiSliderToColorConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		double[] zahlen = values.OfType<double>().ToArray();
		return Color.FromRgb((byte) zahlen[0], (byte) zahlen[1], (byte) zahlen[2]);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}