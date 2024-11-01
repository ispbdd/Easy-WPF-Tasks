## 1. Технология разработки программного обеспечения
### 1.1 Задание: Известна зарплата каждого из 12 работников фирмы за каждый месяц первого квартала:
![image](https://github.com/user-attachments/assets/5fc47477-bcb5-42b2-8eab-a7cda5c39cfa)

### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/7474a9ff-b970-404e-a502-51bd3187881e)




## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z8.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">
    <Window.Resources>
        <!-- Стили аналогично предыдущему окну -->
    </Window.Resources>

    <Grid>
        <StackPanel Margin="20">
            <DataGrid x:Name="SalaryDataGrid" AutoGenerateColumns="False" HeadersVisibility="Column" Margin="10">
                <DataGrid.Columns>
                    <DataGridTextColumn Header="Работник" Binding="{Binding Path=Worker}" IsReadOnly="True"/>
                    <DataGridTextColumn Header="Месяц 1" Binding="{Binding Path=Month1, UpdateSourceTrigger=PropertyChanged}"/>
                    <DataGridTextColumn Header="Месяц 2" Binding="{Binding Path=Month2, UpdateSourceTrigger=PropertyChanged}"/>
                    <DataGridTextColumn Header="Месяц 3" Binding="{Binding Path=Month3, UpdateSourceTrigger=PropertyChanged}"/>
                </DataGrid.Columns>
            </DataGrid>
            <Button Content="Посчитать" Click="Calculate_Click" Width="150" Margin="10" HorizontalAlignment="Center"/>
            <TextBlock x:Name="TotalQuarterSalaryTextBlock" Margin="10"/>
            <TextBlock x:Name="WorkerQuarterSalaryTextBlock" Margin="10"/>
            <TextBlock x:Name="MonthlyTotalSalaryTextBlock" Margin="10"/>
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
