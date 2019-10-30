using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Superheroes
{
    class VengadorBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if ((bool)value)
                    return "si";
                else
                    return "no";
            }
            return "Error en convertidor";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = value.ToString();
            if (valor == "si")
                return true;
            else
                return false;
        }
    }
}
