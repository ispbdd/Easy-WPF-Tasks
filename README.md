## 1. Технология разработки программного обеспечения
### 1.1 Задание: Раньше в соревнованиях по фигурному катанию спортсмены выступали в трех видах многоборья (обязательная, короткая и произвольная программы). Известны результаты (в баллах) каждого из 15 участников соревнований:
![image](https://github.com/user-attachments/assets/c4b1bd89-23d6-4ff6-91cf-ce6a9fd4cbb3)
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/aeb1fcc2-780d-40d5-bfa5-bef4027f6137)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z9.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">

    <Window.Resources>
        <Style TargetType="DataGrid">
            <Setter Property="Background" Value="#282828"/>
            <Setter Property="Foreground" Value="#FFFFFF"/>
            <Setter Property="GridLinesVisibility" Value="All"/>
            <Setter Property="HorizontalScrollBarVisibility" Value="Auto"/>
            <Setter Property="VerticalScrollBarVisibility" Value="Auto"/>

            <!-- Цвет выделения -->
            <Setter Property="SelectionMode" Value="Single"/>
            <Setter Property="SelectionUnit" Value="FullRow"/>
            <Setter Property="RowBackground" Value="#333333"/>
            <Setter Property="AlternatingRowBackground" Value="#2D2D30"/>
            <Setter Property="SelectedIndex" Value="{Binding SelectedRowIndex, Mode=TwoWay}"/>
        </Style>

        <Style TargetType="DataGridColumnHeader">
            <Setter Property="Background" Value="#333333"/>
            <Setter Property="Foreground" Value="#FFFFFF"/>
            <Setter Property="FontWeight" Value="Bold"/>
        </Style>

        <Style TargetType="DataGridCell">
            <Style.Triggers>
                <Trigger Property="DataGridCell.IsSelected" Value="True">
                    <Setter Property="Background" Value="#007ACC"/>
                    <Setter Property="Foreground" Value="#FFFFFF"/>
                </Trigger>
            </Style.Triggers>
        </Style>
    </Window.Resources>

    <Grid>
        <StackPanel Margin="20">
            <DataGrid x:Name="ScoresDataGrid" AutoGenerateColumns="False" HeadersVisibility="Column" Margin="10"
                      HorizontalScrollBarVisibility="Auto" VerticalScrollBarVisibility="Auto">
                <DataGrid.Columns>
                    <DataGridTextColumn Header="Спортсмен" Binding="{Binding Path=Athlete}" IsReadOnly="True"/>
                    <DataGridTextColumn Header="Обязательная" Binding="{Binding Path=Compulsory, UpdateSourceTrigger=PropertyChanged}"/>
                    <DataGridTextColumn Header="Короткая" Binding="{Binding Path=Short, UpdateSourceTrigger=PropertyChanged}"/>
                    <DataGridTextColumn Header="Произвольная" Binding="{Binding Path=Free, UpdateSourceTrigger=PropertyChanged}"/>
                </DataGrid.Columns>
            </DataGrid>

            <Button Content="Посчитать" Click="Calculate_Click" Width="150" Margin="10" HorizontalAlignment="Center"/>

            <TextBlock x:Name="AverageScoresPerAthleteTextBlock" Margin="10"/>
            <TextBlock x:Name="AverageScoresPerProgramTextBlock" Margin="10"/>
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
