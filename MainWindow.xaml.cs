using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Glad_L3Z3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Список для хранения роста учеников
        private List<int> heights;

        public MainWindow()
        {
            InitializeComponent();

            // Инициализация списка
            heights = new List<int> { 190, 185, 180, 178, 175, 170, 168, 165, 162, 160, 158, 155, 150, 148, 145 };

            UpdateStudentList();
        }

        /// <summary>
        /// Отображение роста с индексами в ListBox
        /// </summary>
        private void UpdateStudentList()
        {
            StudentsList.ItemsSource = heights.Select((h, index) => $"#{index + 1}: Рост - {h} см");
        }

        /// <summary>
        /// Обработчик события нажатие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatePosition_Click(object sender, RoutedEventArgs e)
        {
            // Парсинг ввода роста
            int parsedHeight = int.TryParse(HeightInput.Text, out int newHeight) ? newHeight : -1;

            // Логика делегирования с обработкой исключений
            try
            {
                int position = parsedHeight > 0 ? CalculateWithoutCondition(parsedHeight) : throw new Exception("Пожалуйста, введите валидное число.");

                // Показать сообщение с результатами
                ShowPositionMessage(position, parsedHeight);
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        /// <summary>
        /// Проверка, находится ли рост в допустимом диапазоне с использованием логики вместо условий
        /// </summary>
        /// <param name="newHeight"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private int CalculateWithoutCondition(int newHeight)
        {
            int atStart = (newHeight > heights.First()).CompareTo(false);
            int atEnd = (newHeight < heights.Last()).CompareTo(false);
            int valid = atStart | atEnd;

            // Если рост не соответствует диапазону, выбрасывается исключение
            return valid == 0 ? GetPositionForNewHeight(heights, newHeight) : throw new Exception("Рост должен быть между самым высоким и самым низким учеником.");
        }

        /// <summary>
        /// Вычисление позиции без явных условий
        /// </summary>
        /// <param name="heights"></param>
        /// <param name="newHeight"></param>
        /// <returns></returns>
        private int GetPositionForNewHeight(List<int> heights, int newHeight)
        {
            // Подсчет количества учеников выше нового роста
            return heights.TakeWhile(h => h > newHeight).Count();
        }

        /// <summary>
        /// Показ сообщения с новой позицией
        /// </summary>
        /// <param name="position"></param>
        /// <param name="height"></param>
        private void ShowPositionMessage(int position, int height)
        {
            MessageBox.Show($"Новое место для ученика с ростом {height}: {position + 1}", "Результат");
        }
    }
}
