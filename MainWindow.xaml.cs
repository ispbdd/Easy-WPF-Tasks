using System;
using System.Windows;

namespace Glad_L3Z5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            try
            {
                // Чтение начальной суммы вклада и целевых значений из текстовых полей
                double initialDeposit = double.Parse(InitialDepositTextBox.Text);
                double increaseThreshold = double.Parse(IncreaseThresholdTextBox.Text);
                double targetAmount = double.Parse(TargetAmountTextBox.Text);

                double deposit = initialDeposit;
                double monthlyIncrease = 0;
                int month = 0;
                int monthWhenIncreaseExceedsThreshold = 0;
                int monthWhenDepositExceedsTarget = 0;

                while (true)
                {
                    month++;
                    monthlyIncrease = deposit * 0.02;
                    deposit += monthlyIncrease;

                    if (monthWhenIncreaseExceedsThreshold == 0 && monthlyIncrease > increaseThreshold)
                    {
                        monthWhenIncreaseExceedsThreshold = month;
                    }

                    if (monthWhenDepositExceedsTarget == 0 && deposit > targetAmount)
                    {
                        monthWhenDepositExceedsTarget = month;
                        break;
                    }
                }

                ResultLabelGrowth.Content = $"а) Месяц, когда увеличение превысит {increaseThreshold} руб.: {monthWhenIncreaseExceedsThreshold}";
                ResultLabelAmount.Content = $"б) Месяцев до вклада более {targetAmount} руб.: {monthWhenDepositExceedsTarget}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }
    }
}
