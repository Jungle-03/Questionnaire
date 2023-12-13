using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace Question_app_v1
{
    /// <summary>
    /// Логика взаимодействия для Year_forecast.xaml
    /// </summary>
    public partial class Year_forecast : Window
    {
        public Year_forecast()
        {
            InitializeComponent();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myCalendar.SelectedDate.HasValue)
            {
                DateTime selectedDate = myCalendar.SelectedDate.Value;
                DateTime currentDate = DateTime.Now;

                // Рассчитываем разницу в днях
                int daysDifference = (int)(selectedDate - currentDate).TotalDays;

                // Выводим информацию в TextBlock
                daysDifferenceTextBlock.Text = $"Дней до выбранной даты: {daysDifference}";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
