using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Glad_L3Z11
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateRectangles_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AreaInput.Text, out int s))
            {
                var rectangles = FindRectangles(s);
                RectangleResults.Text = string.Join("\n", rectangles);
            }
            else
            {
                RectangleResults.Text = "Please enter a valid number.";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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

            return rectangles.Distinct().ToList();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateParallelepipeds_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(VolumeInput.Text, out int v))
            {
                var parallelepipeds = FindParallelepipeds(v);
                ParallelepipedResults.Text = string.Join("\n", parallelepipeds);
            }
            else
            {
                ParallelepipedResults.Text = "Please enter a valid number.";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private List<string> FindParallelepipeds(int v)
        {
            var parallelepipeds = new List<string>();

            for (int i = 1; i <= v; i++)
            {
                if (v % i == 0)
                {
                    int area = v / i;
                    for (int j = 1; j <= area; j++)
                    {
                        if (area % j == 0)
                        {
                            int k = area / j;
                            if (i <= j && j <= k)
                            {
                                parallelepipeds.Add($"({i}, {j}, {k})");
                            }
                            else
                            {
                                parallelepipeds.Add($"({i}, {j}, {k})");
                                parallelepipeds.Add($"({i}, {k}, {j})");
                                parallelepipeds.Add($"({j}, {i}, {k})");
                                parallelepipeds.Add($"({j}, {k}, {i})");
                                parallelepipeds.Add($"({k}, {i}, {j})");
                                parallelepipeds.Add($"({k}, {j}, {i})");
                            }
                        }
                    }
                }
            }

            return parallelepipeds.Distinct().ToList();
        }

    }
}
