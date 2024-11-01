using System.Windows;

namespace Glad_L3Z6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Попытка прочитать значения, введенные пользователем
            if (!double.TryParse(InitialDistanceTextBox.Text, out double distance))
            {
                MessageBox.Show("Ошибка: неверное начальное расстояние.");
                return;
            }

            if (!double.TryParse(IncreasePercentageTextBox.Text, out double increasePercentage))
            {
                MessageBox.Show("Ошибка: неверный процент увеличения.");
                return;
            }

            // Преобразование процентов в коэффициент увеличения
            increasePercentage = 1 + (increasePercentage / 100.0);

            double totalDistance = 0.0;
            int dayOver20 = 0;
            int totalOver100 = 0;
            int day = 0;

            while (true)
            {
                day++;
                totalDistance += distance;

                if (distance > 20.0 && dayOver20 == 0)
                {
                    dayOver20 = day;
                }

                if (totalDistance > 100.0 && totalOver100 == 0)
                {
                    totalOver100 = day;
                }

                if (dayOver20 > 0 && totalOver100 > 0)
                {
                    break;
                }

                // Увеличение дистанции на процент
                distance *= increasePercentage;
            }

            DayOver20TextBlock.Text = $"День с >20km: {dayOver20}";
            TotalOver100TextBlock.Text = $"День с итогом >100km: {totalOver100}";
        }
    }
}
