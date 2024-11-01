using System.Windows;

namespace Glad_L3Z1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int scoreTeam1 = 0;
        private int scoreTeam2 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPointToTeam1(object sender, RoutedEventArgs e)
        {
            scoreTeam1 += 1;
            UpdateScores();
        }

        private void AddPointToTeam2(object sender, RoutedEventArgs e)
        {
            scoreTeam2 += 1;
            UpdateScores();
        }

        private void AddTwoPointsToTeam1(object sender, RoutedEventArgs e)
        {
            scoreTeam1 += 2;
            UpdateScores();
        }

        private void AddTwoPointsToTeam2(object sender, RoutedEventArgs e)
        {
            scoreTeam2 += 2;
            UpdateScores();
        }

        private void AddThreePointsToTeam1(object sender, RoutedEventArgs e)
        {
            scoreTeam1 += 3;
            UpdateScores();
        }

        private void AddThreePointsToTeam2(object sender, RoutedEventArgs e)
        {
            scoreTeam2 += 3;
            UpdateScores();
        }

        private void UpdateScores()
        {
            ScoreTeam1Label.Content = scoreTeam1.ToString();
            ScoreTeam2Label.Content = scoreTeam2.ToString();
        }

        private void FinishGame(object sender, RoutedEventArgs e)
        {
            string result = "";
            if (scoreTeam1 > scoreTeam2)
            {
                result = "Команда 1 победила!";
            }
            else if (scoreTeam2 > scoreTeam1)
            {
                result = "Команда 2 победила!";
            }
            else
            {
                result = "Это ничья!";
            }

            MessageBox.Show(result, "Результат игры");
            scoreTeam1 = 0;
            scoreTeam2 = 0;
            UpdateScores();
        }
    }
}
