using System.Collections.Generic;
using System.Windows;

namespace Glad_L3Z10
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
            if (int.TryParse(AreaInput.Text, out int s))
            {
                List<string> rectangles = FindRectangles(s);
                Results.Text = string.Join("\n", rectangles);
            }
            else
            {
                Results.Text = "Пожалуйста, введите действительный номер.";
            }
        }

        private List<string> FindRectangles(int s)
        {
            var rectangles = new List<string>();

            for (int i = 1; i <= s; i++)
            {
                if (s % i == 0)
                {
                    int j = s / i;
                    rectangles.Add($"({i}, {j})");
                    if (i != j)
                    {
                        rectangles.Add($"({j}, {i})");
                    }
                }
            }

            return rectangles;
        }

    }
}
