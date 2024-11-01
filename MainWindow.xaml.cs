using System;
using System.Windows;

namespace Glad_L3Z14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateSecond_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputN.Text, out int n) && n >= 1) // Убедитесь, что введено натуральное число
            {
                long result2 = CalculateSumOfIdenticalPowers(n);
                ResultText2.Text = result2.ToString();
            }
            else
            {
                ResultText2.Text = "Некорректный ввод.";
            }
        }

        private long CalculateSumOfIdenticalPowers(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (long)Math.Pow(i, i);
            }
            return sum;
        }
    }
}
