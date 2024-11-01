using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Glad_L3Z16
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindUniqueDigitNumbers_Click(object sender, RoutedEventArgs e)
        {
            var result = FindUniqueDigitNumbers();
            ResultText.Text = result;
        }

        private string FindUniqueDigitNumbers()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 100; i <= 999; i++)
            {
                string strNum = i.ToString();
                if (HasUniqueDigits(strNum))
                {
                    result.Append(strNum + " ");
                }
            }
            return result.ToString().Trim();
        }

        private bool HasUniqueDigits(string number)
        {
            var digits = new HashSet<char>();
            foreach (char c in number)
            {
                if (digits.Contains(c))
                {
                    return false;
                }
                digits.Add(c);
            }
            return true;
        }
    }
}
