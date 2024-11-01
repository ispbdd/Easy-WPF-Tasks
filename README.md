## 1. Технология разработки программного обеспечения
### 1.1 Задание: Дано натуральное число. Если в нем есть цифры a и b, то определить, какая из них расположена в числе правее. Если одна или обе эти цифры встречаются в числе несколько раз, то должны быть учтены самые правые из одинаковых цифр.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/10d791ba-d652-4cb4-aae0-dad79fa00ac3)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">
    <Window.Resources>
        <Style TargetType="Button">
            <Setter Property="Width" Value="150"/>
            <Setter Property="Background" Value="#333333"/>
            <Setter Property="Foreground" Value="#FFFFFF"/>
            <Setter Property="BorderBrush" Value="#555555"/>
            <Setter Property="BorderThickness" Value="1"/>
            <Setter Property="Padding" Value="10"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="Effect">
                <Setter.Value>
                    <DropShadowEffect Color="Black" BlurRadius="10" ShadowDepth="2"/>
                </Setter.Value>
            </Setter>
        </Style>

        <Style TargetType="Label">
            <Setter Property="FontSize" Value="16"/>
            <Setter Property="Margin" Value="5"/>
        </Style>
    </Window.Resources>

    <Grid Margin="10">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="Auto" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>

        <StackPanel Grid.Column="0" VerticalAlignment="Top">
            <Label Content="Команда 1" HorizontalAlignment="Center" Foreground="White"/>
            <Label x:Name="ScoreTeam1Label" Content="0" HorizontalAlignment="Center" Foreground="White"/>
            <Button Content="1 Очко Команда 1" Click="AddPointToTeam1" Margin="5"/>
            <Button Content="2 Очка Команда 1" Click="AddTwoPointsToTeam1" Margin="5"/>
            <Button Content="3 Очка Команда 1" Click="AddThreePointsToTeam1" Margin="5"/>
        </StackPanel>

        <StackPanel Grid.Column="2" VerticalAlignment="Top">
            <Label Content="Команда 2" HorizontalAlignment="Center" Foreground="White"/>
            <Label x:Name="ScoreTeam2Label" Content="0" HorizontalAlignment="Center" Foreground="White"/>
            <Button Content="1 Очко Команда 2" Click="AddPointToTeam2" Margin="5"/>
            <Button Content="2 Очка Команда 2" Click="AddTwoPointsToTeam2" Margin="5"/>
            <Button Content="3 Очка Команда 2" Click="AddThreePointsToTeam2" Margin="5"/>
        </StackPanel>

        <Button Content="Закончить игру" HorizontalAlignment="Center" VerticalAlignment="Center" Grid.ColumnSpan="3" Click="FinishGame"/>
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
