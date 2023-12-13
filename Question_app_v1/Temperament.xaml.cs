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
        private int score1;
        private int score2;
        public Temperament()
        {
            InitializeComponent();
        }

        private void CompleteQuiz_Click(object sender, RoutedEventArgs e)
        {
            CalculateScores();

            // Определяем тип темперамента
            string temperamentType = "";
            if (score1 < 5 && score2 < 5)
                temperamentType = "Флегматик";
            else if (score1 < 5 && score2 >= 5)
                temperamentType = "Меланхолик";
            else if (score1 >= 5 && score2 < 5)
                temperamentType = "Сангвиник";
            else
                temperamentType = "Холерик";

            resultTextBlock.Text = $"Ваш тип темперамента: {temperamentType}";
        }

        private void CalculateScores()
        {
            score1 = CalculateQuestionScore(CheckBox1_1, CheckBox1_2, CheckBox1_3);
            score2 = CalculateQuestionScore(CheckBox2_1, CheckBox2_2, CheckBox2_3);
        }

        private int CalculateQuestionScore(params CheckBox[] checkBoxes)
        {
            return checkBoxes.Count(checkBox => checkBox.IsChecked == true);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}


