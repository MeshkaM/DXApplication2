using DataGridBindingExampleCore.Models;
using DevExpress.Data.Filtering;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Markup;

namespace DataGridBindingExampleCore.Converters
{
    public class ConvProvinceID : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CriteriaOperator.Parse("[CountryName] == ?", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
        //public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        //{
        //    int i = 0;

        //    if (values[0] != DependencyProperty.UnsetValue)
        //    {
        //        i = (int)values[0];
        //    }

        //    IList<ProvincesModel> l = (IList<ProvincesModel>)values[1];
        //    return i > 0 && (l.Count > 0) ? l[i - 1].ProvinceName : string.Empty;
        //}
        //public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}

    }


    public class ConvProvinceID2 : MarkupExtension, IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)values[2]
                ? ((ObservableCollection<PlacesOfInterest>)values[0]).Where(item => item.CountryName.Equals((string)values[1])).ToList()
                : values[0];
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }

    public class ProvinceFilterConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is ObservableCollection<ProvincesModel> provinces && values[1] is string countryName)
            {
                return provinces.Where(p => p.CountryName == countryName);
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}


