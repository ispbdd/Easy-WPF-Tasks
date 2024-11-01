## 1. Технология разработки программного обеспечения
### 1.1 Задание: Гражданин 1 марта открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. Определить: а) за какой месяц величина ежемесячного увеличения вклада превысит 30 руб.; б) через сколько месяцев размер вклада превысит 1200 руб.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/7af60e73-0e3b-4712-b298-2804b75f5267)




## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z5.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">
    <Window.Resources>
        <!-- Стили аналогично предыдущему окну -->
    </Window.Resources>

    <Grid>
        <StackPanel Margin="20">
            <Label Content="Начальная сумма вклада:" HorizontalAlignment="Left" Margin="10,0,0,5" Foreground="White"/>
            <TextBox x:Name="InitialDepositTextBox" HorizontalAlignment="Left" Width="200" Margin="10"/>
            <Label Content="Увеличение превысит:" HorizontalAlignment="Left" Margin="10,0,0,5" Foreground="White"/>
            <TextBox x:Name="IncreaseThresholdTextBox" HorizontalAlignment="Left" Width="200" Margin="10"/>
            <Label Content="Вклад превысит:" HorizontalAlignment="Left" Margin="10,0,0,5" Foreground="White"/>
            <TextBox x:Name="TargetAmountTextBox" HorizontalAlignment="Left" Width="200" Margin="10"/>
            <Button Content="Рассчитать" HorizontalAlignment="Center" Margin="0,10,0,10" Width="150" Click="Calculate"/>
            <Label x:Name="ResultLabelGrowth" HorizontalAlignment="Left" Margin="10,0,0,5" Foreground="White"/>
            <Label x:Name="ResultLabelAmount" HorizontalAlignment="Left" Margin="10,0,0,5" Foreground="White"/>
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
