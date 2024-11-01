## 1. Технология разработки программного обеспечения
### 1.1 Задание: Найти размеры всех прямоугольных параллелепипедов, объем которых равен заданному натуральному числу v и стороны которых выражены натуральными числами. При этом решения, которые получаются перестановкой размеров ребер параллелепипеда: а) считать разными; б) считать совпадающими.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/56ed16ce-da1a-49b5-b26d-e091fb7c1504)




## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z11.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Glad_L3Z11"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800" Background="#FF2D2D30">
    <Grid>
        <StackPanel Margin="20" VerticalAlignment="Center">
            <TextBlock Text="Введите область (s):" Margin="0,0,0,5" Foreground="White" FontSize="16"/>
            <TextBox Name="AreaInput" Width="200" Margin="0,0,0,10" Background="#FF3C3C3C" Foreground="White" BorderBrush="#FFAAAAAA"/>

            <Button Content="Вычислить прямоугольники" Width="200" Margin="0,0,0,10" 
                    Background="#FF007ACC" Foreground="White" FontWeight="Bold" 
                    Click="CalculateRectangles_Click" ToolTip="Click to calculate rectangles"/>
            <TextBlock Name="RectangleResults" Margin="0,10,0,20" Foreground="White" FontSize="14" TextWrapping="Wrap"/>

            <TextBlock Text="Введите объем (v):" Margin="0,0,0,5" Foreground="White" FontSize="16"/>
            <TextBox Name="VolumeInput" Width="200" Margin="0,0,0,10" Background="#FF3C3C3C" Foreground="White" BorderBrush="#FFAAAAAA"/>

            <Button Content="Вычислить параллелепипеды" Width="200" Margin="0,0,0,10" 
                    Background="#FF007ACC" Foreground="White" FontWeight="Bold"
                    Click="CalculateParallelepipeds_Click" ToolTip="Click to calculate parallelepipeds"/>
            <TextBlock Name="ParallelepipedResults" Margin="0,10,0,0" Foreground="White" FontSize="14" TextWrapping="Wrap"/>
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
