## 1. Технология разработки программного обеспечения
### 1.1 Задание: Напечатать в возрастающем порядке все трехзначные числа, в десятичной записи которых нет одинаковых цифр. Операции деления, целочисленного деления и определения остатка не использовать.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/aea8c636-8a1a-44f6-a708-ad92b5c3795d)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z16.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:Glad_L3Z16"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800"
        Background="#FF333333">
    <Grid>
        <StackPanel Margin="10">
            <Button Content="Найти трехзначные числа с уникальными цифрами"
                    Width="300"
                    Background="#FF555555" 
                    Foreground="White"
                    FontWeight="Bold"
                    Margin="0,10" 
                    Click="FindUniqueDigitNumbers_Click"
                    Style="{DynamicResource {x:Static ToolBar.ButtonStyleKey}}"/>

            <TextBlock Text="Результат:"
                       Foreground="LightGray" 
                       FontSize="16" 
                       Margin="0,10,0,5"/>

            <TextBlock x:Name="ResultText" 
                       FontWeight="Bold" 
                       FontSize="14" 
                       TextWrapping="Wrap"
                       Foreground="White"/>
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
