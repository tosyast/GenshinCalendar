using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GenshinCalendar
{
    /// <summary>
    /// Логика взаимодействия для PageCHAR.xaml
    /// </summary>
    public partial class PageCHAR : Page
    {

        private DateTime _day;
     /*   private selecteddate model = new selecteddate();*/
        public PageCHAR(DateTime day)
        {
            InitializeComponent();
            _day = day;
            /*model.time = day;
*/

            calendar albedo = new calendar();
            Uri relative = new Uri("/image/Albedo 3.png", UriKind.Relative);
            albedo.img.Source = new BitmapImage(relative);
            albedo.nm.Text = "Альбедо";
            List<calendar> list = new List<calendar>() { albedo };
            Callendar.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show($"Добавил PeepoClap {_day}");
        }
    }
}
