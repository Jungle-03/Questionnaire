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

namespace Question_app_v1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Weather_forecast_clik(object sender, RoutedEventArgs e)
        {
            Weather_forecast weather_window= new Weather_forecast();
            weather_window.Show();
            this.Close();

        }

        private void Forecast_for_the_year_click(object sender, RoutedEventArgs e)
        {
            Year_forecast year_Forecast = new Year_forecast();
            year_Forecast.Show();
            this.Close();
        }

        private void Temperament_type_click(object sender, RoutedEventArgs e)
        {
            Temperament t= new Temperament();
            t.Show();
            this.Close();
        }
    }
}
