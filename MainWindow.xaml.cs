using System.Collections.ObjectModel;
using System.Windows;

namespace Glad_L3Z8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<SalaryData> Salaries { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Salaries = new ObservableCollection<SalaryData>();
            for (int i = 1; i <= 12; i++)
            {
                Salaries.Add(new SalaryData { Worker = i });
            }
            SalaryDataGrid.ItemsSource = Salaries;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double totalQuarterSalary = 0;
            double[] workerQuarterSalaries = new double[12];
            double[] monthlyTotalSalaries = new double[3];

            for (int i = 0; i < Salaries.Count; i++)
            {
                workerQuarterSalaries[i] = Salaries[i].Month1 + Salaries[i].Month2 + Salaries[i].Month3;
                totalQuarterSalary += workerQuarterSalaries[i];
                monthlyTotalSalaries[0] += Salaries[i].Month1;
                monthlyTotalSalaries[1] += Salaries[i].Month2;
                monthlyTotalSalaries[2] += Salaries[i].Month3;
            }

            TotalQuarterSalaryTextBlock.Text = $"Общая сумма за квартал: {totalQuarterSalary} руб.";
            WorkerQuarterSalaryTextBlock.Text = "Зарплата за квартал каждым работником: " + string.Join(", ", workerQuarterSalaries);
            MonthlyTotalSalaryTextBlock.Text = $"Общая зарплата за каждый месяц: Месяц 1: {monthlyTotalSalaries[0]}, Месяц 2: {monthlyTotalSalaries[1]}, Месяц 3: {monthlyTotalSalaries[2]}";
        }
    }

    public class SalaryData
    {
        public int Worker { get; set; }
        public double Month1 { get; set; }
        public double Month2 { get; set; }
        public double Month3 { get; set; }
    }
}
