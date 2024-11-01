using System.Windows;

namespace Glad_L3Z7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Получение введенных значений и базовая валидация
            if (!double.TryParse(InitialAreaTextBox.Text, out double area))
            {
                MessageBox.Show("Ошибка: неверная начальная площадь.");
                return;
            }

            if (!double.TryParse(InitialYieldTextBox.Text, out double yield))
            {
                MessageBox.Show("Ошибка: неверная начальная урожайность.");
                return;
            }

            if (!double.TryParse(AreaIncreaseTextBox.Text, out double areaIncrease))
            {
                MessageBox.Show("Ошибка: неверный процент увеличения площади.");
                return;
            }

            if (!double.TryParse(YieldIncreaseTextBox.Text, out double yieldIncrease))
            {
                MessageBox.Show("Ошибка: неверный процент увеличения урожайности.");
                return;
            }

            areaIncrease = 1 + (areaIncrease / 100.0);
            yieldIncrease = 1 + (yieldIncrease / 100.0);

            double totalYield = 0.0;
            // Начинаем с первого условного года
            int year = 1;

            int yearYieldOver22 = 0;
            int yearAreaOver120 = 0;
            int yearTotalYieldOver800 = 0;

            while (true)
            {
                // Общий урожай за текущий год
                totalYield += area * yield;

                if (yield > 22.0 && yearYieldOver22 == 0)
                {
                    yearYieldOver22 = year;
                }

                if (area > 120.0 && yearAreaOver120 == 0)
                {
                    yearAreaOver120 = year;
                }

                if (totalYield > 800.0 && yearTotalYieldOver800 == 0)
                {
                    yearTotalYieldOver800 = year;
                }

                if (yearYieldOver22 > 0 && yearAreaOver120 > 0 && yearTotalYieldOver800 > 0)
                {
                    break;
                }

                // Увеличиваем площадь и урожайность на проценты
                area *= areaIncrease;
                yield *= yieldIncrease;

                year++;
            }

            YieldOver22TextBlock.Text = $"Год с урожайностью >22: {yearYieldOver22}";
            AreaOver120TextBlock.Text = $"Год с площадью >120: {yearAreaOver120}";
            TotalYieldOver800TextBlock.Text = $"Год с общим доходом >800: {yearTotalYieldOver800}";
        }
    }
}
