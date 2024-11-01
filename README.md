## 1. Технология разработки программного обеспечения
### 1.1 Задание: Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить: а) в какой день он пробежит больше 20 км; б) в какой день суммарный пробег за все дни превысит 100 км.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/613d3686-6f4a-4205-a16e-9613df725170)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z6.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">
    <Window.Resources>
        <!-- Стили аналогично предыдущему окну -->
    </Window.Resources>

    <Grid>
        <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center" Margin="20">
            <TextBlock Text="Начальная дистанция (км):" Margin="0,0,0,5"/>
            <TextBox x:Name="InitialDistanceTextBox" Text="10" Width="200" Margin="0,0,0,10"/>
            <TextBlock Text="Процент увеличения (%):" Margin="0,0,0,5"/>
            <TextBox x:Name="IncreasePercentageTextBox" Text="10" Width="200" Margin="0,0,0,10"/>
            <Button Content="Посчитать" Click="Calculate_Click" Width="150" Margin="0,0,0,10" HorizontalAlignment="Center"/>
            <TextBlock x:Name="DayOver20TextBlock" Text="День с >20км: " Margin="0,0,0,5"/>
            <TextBlock x:Name="TotalOver100TextBlock" Text="День с итогом >100км: " Margin="0,0,0,5"/>
        </StackPanel>
    </Grid>
</Window>
```

## Deploy и CI/CD
JetBrains Rider, Visual Studio, Windows 11, Visual Studio Code, 
[еще...](https://learn.microsoft.com/dotnet/desktop/winforms/get-started/create-app-visual-studio?view=netdesktop-8.0)

## Contributing
Для улучшения кода рекомендуется обращаться через социальные сети.

### Для чего
Данный проект был разработан в рамках технологит разработкок программного обеспечения.
