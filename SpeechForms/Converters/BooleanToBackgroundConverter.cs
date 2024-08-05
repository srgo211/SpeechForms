using System.Globalization;
using System.Reflection;
using System.Windows.Data;
using System.Windows.Media;

namespace SpeechForms.Converters
{
    public class BooleanToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
                return Brushes.White;

            // Получаем имя свойства из параметра
            string propertyName = parameter.ToString();

            // Используем отражение для получения значения свойства
            PropertyInfo property = value.GetType().GetProperty(propertyName);
            if (property != null && property.PropertyType == typeof(bool))
            {
                bool propertyValue = (bool)property.GetValue(value);
                return propertyValue ? Brushes.Yellow : Brushes.White;
            }

            return Brushes.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
