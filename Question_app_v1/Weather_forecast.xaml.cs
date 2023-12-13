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
using System.Windows.Shapes;

namespace Question_app_v1
{
    /// <summary>
    /// Логика взаимодействия для Weather_forecast.xaml
    /// </summary>
    public partial class Weather_forecast : Window
    {
        public Weather_forecast()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox.SelectedItem != null)
            {
                if (combobox.SelectedItem is TextBlock selectedTextBlock)
                {
                    // Получаем текст выбранного TextBlock и устанавливаем соответствующее значение в Weather_block
                    switch (selectedTextBlock.Text)
                    {
                        case "Понедельник":
                            Weather_block.Text = "-3";
                            break;
                        case "Вторник":
                            Weather_block.Text = "-2";
                            break;
                        case "Среда":
                            Weather_block.Text = "-5";
                            break;
                        case "Четверг":
                            Weather_block.Text = "-7";
                            break;
                        case "Пятница":
                            Weather_block.Text = "-4";
                            break;
                        case "Суббота":
                            Weather_block.Text = "-7";
                            break;
                        case "Воскресение":
                            Weather_block.Text = "-10";
                            break;
                        default:
                            Weather_block.Text = "Неизвестно";
                            break;
                    }
                }
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
