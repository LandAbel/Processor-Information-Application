using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ProcessorInfo.WPFClient
{
    public class ImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string imageUrl && !string.IsNullOrEmpty(imageUrl))
            {
                try
                {
                    return new BitmapImage(new Uri(imageUrl));
                }
                catch (Exception)
                {
                    // Handle invalid URLs or other exceptions here
                    return GetDefaultImage();
                }
            }

            // Return a default image or null if preferred
            return GetDefaultImage();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private ImageSource GetDefaultImage()
        {
            // Return the URI of your default image
            //return new BitmapImage(new Uri("C:\\Users\\Ábel\\Desktop\\Egyetem_round_five\\szerveroldali\\ProcessorInfoApplication\\ProcessorInfoApplication\\ProcessorInfo.WPFClient\\AppIcon.png"));
            return null;
        }

    }
}
