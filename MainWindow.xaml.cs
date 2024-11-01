using System;
using System.Linq;
using System.Windows;

namespace Glad_L3Z4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DetermineRank(object sender, RoutedEventArgs e)
        {
            try
            {
                // Парсим список очков в массив
                var scores = ScoresInput.Text.Split(',')
                                             .Select(s => int.Parse(s.Trim()))
                                             .ToArray();

                // Парсим число N
                int n = int.Parse(NInput.Text.Trim());

                // Нахождение индекса (места) команды с очками N
                int rank = Array.IndexOf(scores, n) + 1;

                // Выводим результат
                ResultLabel.Content = $"Команда заняла место: {rank}";
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка во вводе данных. Пожалуйста, убедитесь в корректности введенных данных.");
            }
        }
    }
}
