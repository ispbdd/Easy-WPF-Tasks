using System.Text;
using System.Windows;

namespace Glad_L3Z15
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindThreeDigitNumbers_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputN.Text, out int n) && n <= 27)
            {
                var result3 = FindThreeDigitNumbers(n);
                ResultText3.Text = result3;
            }
            else
            {
                ResultText3.Text = "Некорректный ввод или превышено значение n.";
            }
        }

        private string FindThreeDigitNumbers(int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 100; i <= 999; i++)
            {
                int sumOfDigits = SumDigits(i);
                if (sumOfDigits == n)
                {
                    result.Append(i + " ");
                }
            }
            return result.ToString().Trim();
        }

        private int SumDigits(int number)
        {
            int sum = 0;
            foreach (char c in number.ToString())
            {
                sum += c - '0';
            }
            return sum;
        }
    }
}
