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
    /// Логика взаимодействия для PageCAL.xaml
    /// </summary>
    public partial class PageCAL : Page
    {
        public DateTime DateTimeNow { get; set; } = DateTime.Now;

        public PageCAL()
        {
            InitializeComponent();
            DataContext= this;
        }
        private void DataName_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int day = Convert.ToInt32(btn.Content);
            DateTime date = new DateTime(DateTimeNow.Year, DateTimeNow.Month, day);
            // Далее открываем страницу для выбора продуктов и т.д.
            PageCHAR page2 = new PageCHAR(date);
            NavigationService.Navigate(page2);
        }

        private void CalendarOn_Click(object sender, RoutedEventArgs e)
        {
            CalendarOf.Visibility = Visibility.Visible;
            CalendarOn.Visibility = Visibility.Hidden;
            Cal.Visibility = Visibility.Visible;
        }

        private void CalendarOf_Click(object sender, RoutedEventArgs e)
        {
            CalendarOn.Visibility = Visibility.Visible;
            CalendarOf.Visibility = Visibility.Hidden;
            Cal.Visibility = Visibility.Hidden;
        }

        private void left_Click(object sender, RoutedEventArgs e)
        {
            Callendar.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(-1);
            mounth.Text = DateTimeNow.ToString("MMMM yyyy");
            Data();
        }

        private void right_Click(object sender, RoutedEventArgs e)
        {
            Callendar.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(1);
            mounth.Text = DateTimeNow.ToString("MMMM yyyy");
            Data();
        }
        private void Data()
        {
            for (int i = 1; i < DateTime.DaysInMonth(DateTimeNow.Year, DateTimeNow.Month); i++)
            {
                caldate t = new caldate();
                t.date.Content = i.ToString();

                DateTime datetut = new DateTime(DateTimeNow.Year, DateTimeNow.Month, i);
                selecteddate item = globalglobal.List.FirstOrDefault(iteminlist => iteminlist.selectedDate == datetut);
                if (item != null)
                {
                    
                }

               t.date.Click += DataName_Click;
                Callendar.Children.Add(t);
            }
        }
    }
}
