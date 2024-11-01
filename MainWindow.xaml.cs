using System;
using System.Windows;

namespace Glad_L3Z13
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

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Значения по умолчанию
            int m = 5;
            int n = 2;

            // Попытка получения введенных значений
            if (!int.TryParse(InputM.Text, out m))
            {
                m = 5; // Значение по умолчанию, если ввод неверный
            }
            if (!int.TryParse(InputN.Text, out n))
            {
                n = 2; // Значение по умолчанию, если ввод неверный
            }

            // Вычисление суммы
            long result = CalculateSumOfPowers(m, n);
            ResultText.Text = result.ToString();
        }

        private long CalculateSumOfPowers(int m, int n)
        {
            long sum = 0;
            for (int i = 1; i <= m; i++)
            {
                sum += (long)Math.Pow(i, n);
            }
            return sum;
        }
    }
}
