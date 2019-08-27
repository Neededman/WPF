using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TemplateDemo.Converters
{
    class ScoreConvertToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int score = (int)value;
            string strUri = "";
            if (score < 60)
            {
                strUri = @"../Images/error.jpg";
            }
            else
            {
                strUri = @"../Images/right.jpg";
            }
            Console.WriteLine(strUri);
            BitmapImage test = new BitmapImage(new Uri(strUri, UriKind.Relative));
            return test;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
