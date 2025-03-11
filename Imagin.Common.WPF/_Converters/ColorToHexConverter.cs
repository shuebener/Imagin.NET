using Imagin.Common.Linq;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Imagin.Common.Converters
{
	/// <summary>
	/// 
	/// </summary>
	[ValueConversion(typeof(Color), typeof(Hexadecimal))]
	public class ColorToHexConverter : IValueConverter
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var _value = value.As<Color>();
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
			if (_value != null)
			{
				var result = (Hexadecimal)_value;

				var _parameter = parameter.ToString().ToLower();
				if (_parameter == null || _parameter == "withalpha" || _parameter == "1")
				{
					return result.ToString(true);
				}
				else if (_parameter == "withoutAlpha" || _parameter == "0")
				{
					return result.ToString(false);
				}
				else throw new ArgumentOutOfRangeException(nameof(parameter));
			}
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
			return string.Empty;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var _value = value.As<string>();
			if (_value != null)
			{
				var result = (Hexadecimal)_value;

				var _parameter = parameter.ToString().ToLower();
				if (_parameter == null || _parameter == "withalpha" || _parameter == "1")
				{
					return (Color)result;
				}
				else if (_parameter == "withoutAlpha" || _parameter == "0")
				{
					var _result = (Color)result;
					return Color.FromArgb(255, _result.R, _result.G, _result.B);
				}
				else throw new ArgumentOutOfRangeException(nameof(parameter));
			}
			return DependencyProperty.UnsetValue;
		}
	}
}