using System.Collections.Generic;
using System.Windows;

namespace Glad_L3Z12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindSolutions_Click(object sender, RoutedEventArgs e)
        {
            if (TryParseRange(XRangeInput.Text, out int xStart, out int xEnd) &&
                TryParseRange(YRangeInput.Text, out int yStart, out int yEnd) &&
                TryParseRange(KRangeInput.Text, out int kStart, out int kEnd))
            {
                var solutions = FindNaturalSolutions(xStart, xEnd, yStart, yEnd, kStart, kEnd);
                SolutionResults.Text = string.Join("\n", solutions);
            }
            else
            {
                SolutionResults.Text = "Введите действительные диапазоны номеров (e.g., 1-30).";
            }
        }

        private bool TryParseRange(string rangeText, out int start, out int end)
        {
            start = 0;
            end = 0;
            var parts = rangeText.Split('-');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out start) &&
                int.TryParse(parts[1], out end) &&
                start <= end)
            {
                return true;
            }
            return false;
        }

        private List<string> FindNaturalSolutions(int xStart, int xEnd, int yStart, int yEnd, int kStart, int kEnd)
        {
            var solutions = new List<string>();

            for (int k = kStart; k <= kEnd; k++)
            {
                int kSquared = k * k;
                for (int x = xStart; x <= xEnd; x++)
                {
                    int xSquared = x * x;
                    for (int y = x; y <= yEnd; y++)
                    {
                        if (xSquared + y * y == kSquared)
                        {
                            solutions.Add($"(x: {x}, y: {y}, k: {k})");
                        }
                    }
                }
            }

            return solutions;
        }
    }
}
