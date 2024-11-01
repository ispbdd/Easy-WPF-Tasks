using System.Windows;

namespace Glad_L3Z2
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

        private void AnalyzeNumbers(object sender, RoutedEventArgs e)
        {
            string number = NumberInput.Text;
            char[] aChars = DigitAInput.Text.ToCharArray();
            char[] bChars = DigitBInput.Text.ToCharArray();

            if (aChars.Length != 1 || bChars.Length != 1 || !char.IsDigit(aChars[0]) || !char.IsDigit(bChars[0]))
            {
                MessageBox.Show("Введите корректные цифры a и b.");
                return;
            }

            char a = aChars[0];
            char b = bChars[0];

            int lastIndexOfA = number.LastIndexOf(a);
            int lastIndexOfB = number.LastIndexOf(b);

            if (lastIndexOfA == -1 && lastIndexOfB == -1)
            {
                ResultLabel.Content = "Цифры a и b отсутствуют в числе.";
            }
            else if (lastIndexOfA > lastIndexOfB)
            {
                ResultLabel.Content = $"Цифра {a} расположена правее.";
            }
            else if (lastIndexOfB > lastIndexOfA)
            {
                ResultLabel.Content = $"Цифра {b} расположена правее.";
            }
            else
            {
                ResultLabel.Content = "Цифры a и b находятся на одной позиции.";
            }
        }
    }
}
