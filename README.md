## 1. Технология разработки программного обеспечения
### 1.1 Задание: Составить программу для нахождения всех натуральных решений (x и y) уравнения x2 + y2 = k2, где x, y и k лежат в интервале от 1 до 30. Решения, которые получаются перестановкой x и y, считать совпадающими.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/4c126113-efe1-4a96-8a28-cee849c30cde)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z12.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Уравнения" Height="500" Width="300" Background="#FF2D2D30">
    <Grid>
        <StackPanel Margin="20">
            <TextBlock Text="Уравнение: x² + y² = k²" FontSize="16" FontWeight="Bold" Margin="0,0,0,20" Foreground="White"/>

            <TextBlock Text="Диапазон для x:" Margin="0,5,0,5" Foreground="White"/>
            <TextBox Name="XRangeInput" Text="1-30" Width="120" Background="#FF3C3C3C" Foreground="White" BorderBrush="#FFAAAAAA"/>

            <TextBlock Text="Диапазон для y:" Margin="0,5,0,5" Foreground="White"/>
            <TextBox Name="YRangeInput" Text="1-30" Width="120" Background="#FF3C3C3C" Foreground="White" BorderBrush="#FFAAAAAA"/>

            <TextBlock Text="Диапазон для k:" Margin="0,5,0,5" Foreground="White"/>
            <TextBox Name="KRangeInput" Text="1-30" Width="120" Background="#FF3C3C3C" Foreground="White" BorderBrush="#FFAAAAAA"/>

            <Button Content="Найти решение" Width="150" Margin="0,20,0,0"
                    Background="#FF007ACC" Foreground="White" FontWeight="Bold"
                    Click="FindSolutions_Click" ToolTip="Click to find solutions"/>

            <TextBlock Name="SolutionResults" Margin="0,20,0,0" TextWrapping="Wrap" Foreground="White"/>
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
