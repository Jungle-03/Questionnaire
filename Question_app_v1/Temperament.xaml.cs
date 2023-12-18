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
using static System.Formats.Asn1.AsnWriter;

namespace Question_app_v1
{
    /// <summary>
    /// Логика взаимодействия для Temperament.xaml
    /// </summary>
    public partial class Temperament : Window
    {
        public int score1;
        public int score2;
        public Temperament()
        {
            InitializeComponent();
        }

        private void CompleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            // Суммируем баллы из выбранных CheckBox'ов
            int totalPoints = GetTotalPoints();

            // Определяем темперамент и выводим результат
            string temperament = DetermineTemperament(totalPoints);
            resultTextBlock.Text = $"Ваш темперамент: {temperament}";
        }
        private int GetTotalPoints()
        {
            int totalPoints = 0;

            // Проходим по всем CheckBox'ам и суммируем баллы
            foreach (CheckBox checkBox in FindVisualChildren<CheckBox>(this))
            {
                if (checkBox.IsChecked == true)
                {
                    // Получаем баллы из Tag (присвойте нужные баллы в Tag каждому CheckBox'у)
                    if (int.TryParse(checkBox.Tag?.ToString(), out int points))
                    {
                        totalPoints += points;
                    }
                }
            }

            return totalPoints;
        }
        private string DetermineTemperament(int totalPoints)
        {
            if (totalPoints == 10)
            {
                return "Флегматик";
            }
            else if (totalPoints >= 11 && totalPoints <= 15)
            {
                return "Сангвиник";
            }
            else if (totalPoints >= 15 && totalPoints <= 19)
            {
                return "Флегматик";
            }
            else if (totalPoints >= 20)
            {
                return "Холерик";
            }

            return "Не удалось определить темперамент";
        }
        // Вспомогательная функция для поиска всех дочерних элементов заданного типа
        private static System.Collections.Generic.IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
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



