using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Glad_L3Z9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ScoreData> Scores { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Scores = new ObservableCollection<ScoreData>();
            for (int i = 1; i <= 15; i++)
            {
                Scores.Add(new ScoreData { Athlete = i });
            }
            ScoresDataGrid.ItemsSource = Scores;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double[] averageScoresPerAthlete = new double[15];
            double totalCompulsory = 0, totalShort = 0, totalFree = 0;

            for (int i = 0; i < Scores.Count; i++)
            {
                averageScoresPerAthlete[i] = (Scores[i].Compulsory + Scores[i].Short + Scores[i].Free) / 3.0;
                totalCompulsory += Scores[i].Compulsory;
                totalShort += Scores[i].Short;
                totalFree += Scores[i].Free;
            }

            double averageCompulsory = totalCompulsory / 15.0;
            double averageShort = totalShort / 15.0;
            double averageFree = totalFree / 15.0;

            AverageScoresPerAthleteTextBlock.Text = "Средние баллы по каждому спортсмену: " + string.Join(", ", averageScoresPerAthlete.Select(a => a.ToString("F2")));
            AverageScoresPerProgramTextBlock.Text = $"Средние баллы по программам: Обязательная: {averageCompulsory:F2}, Короткая: {averageShort:F2}, Произвольная: {averageFree:F2}";
        }
    }

    public class ScoreData
    {
        public int Athlete { get; set; }
        public double Compulsory { get; set; }
        public double Short { get; set; }
        public double Free { get; set; }
    }
}
