## 1. Технология разработки программного обеспечения
### 1.1 Задание: В некотором году (назовем его условно первым) на участке в 100 гектаров средняя урожайность ячменя составила 20 центнеров с гектара. После этого каждый год площадь участка увеличивалась на 5%, а средняя урожайность на 2%. Определить: а) в каком году урожайность превысит 22 центнера с гектара; б) в каком году площадь участка станет больше 120 гектаров; в) в каком году общий урожай, собранный за все время, начиная с первого года, превысит 800 центнеров.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/ae3d8a74-bf70-4b59-9b84-28189d470821)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z7.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="500" Width="400"
        Background="#1E1E1E" Foreground="#FFFFFF">
    <Window.Resources>
        <!-- Стили аналогично предыдущему окну -->
    </Window.Resources>

    <Grid>
        <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center" Margin="20">
            <TextBlock Text="Начальная площадь (га):" Margin="0,0,0,5"/>
            <TextBox x:Name="InitialAreaTextBox" Text="100" Width="200" Margin="0,0,0,10"/>
            <TextBlock Text="Начальная урожайность (цент./га):" Margin="0,0,0,5"/>
            <TextBox x:Name="InitialYieldTextBox" Text="20" Width="200" Margin="0,0,0,10"/>
            <TextBlock Text="Процент увеличения площади:" Margin="0,0,0,5"/>
            <TextBox x:Name="AreaIncreaseTextBox" Text="5" Width="200" Margin="0,0,0,10"/>
            <TextBlock Text="Процент увеличения урожайности:" Margin="0,0,0,5"/>
            <TextBox x:Name="YieldIncreaseTextBox" Text="2" Width="200" Margin="0,0,0,10"/>
            <Button Content="Посчитать" Click="Calculate_Click" Width="150" Margin="0,0,0,10" HorizontalAlignment="Center"/>
            <TextBlock x:Name="YieldOver22TextBlock" Text="Год с урожайностью >22: " Margin="0,0,0,5"/>
            <TextBlock x:Name="AreaOver120TextBlock" Text="Год с площадью >120: " Margin="0,0,0,5"/>
            <TextBlock x:Name="TotalYieldOver800TextBlock" Text="Год с общим доходом >800: " Margin="0,0,0,5"/>
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
