## 1. Технология разработки программного обеспечения
### 1.1 Задание: Найти размеры всех прямоугольников, площадь которых равна заданному натуральному числу s и стороны которых выражены натуральными числами. При этом решения, которые получаются перестановкой размеров сторон: а) считать разными; б) считать совпадающими.
### 1.2 Выполнил студент 4го курса: Бочкарев Данил Дмитриевич
### 1.3 Специальность: Информационные системы и программирование
### 1.4 Преподаватель: Гладкова Елена Михайловна

### Приложение A (Экранные формы)
![image](https://github.com/user-attachments/assets/1b6e5351-e3e1-4311-aa98-fd6e1131e25e)



## 2. Тестирование модуля
### 2.1 Функциональное тестирование
Для проведения функционального тестирования были разработаны таблицы, содержащие перечень сценариев тестирования программного продукта с подробным описанием шагов. Шаги сценария тестирования характеризуются действиями пользователя и ожидаемыми результатами – реакциями программы на эти действия.



#### Таблица 1 – Тестовый сценарий функции «Ввод и расчет позиции роста»


#### Таблица 2 – Тестовый сценарий функции «Обновление списка студентов»


#### Таблица 3 – Тестовый сценарий функции «Инициализация и отображение списка студентов»


#### Таблица 4 – Тестовый сценарий функции «Обработка ошибки ввода»


### Код для визуального отображения главного окна с использованием Visual Studio:
```xaml
<Window x:Class="Glad_L3Z10.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="MainWindow" Height="450" Width="800"
        Background="#1E1E1E" Foreground="#FFFFFF">

    <Window.Resources>
        <!-- Стиль для кнопок -->
        <Style TargetType="Button">
            <Setter Property="Background" Value="#333333"/>
            <Setter Property="Foreground" Value="#FFFFFF"/>
            <Setter Property="BorderBrush" Value="#555555"/>
            <Setter Property="BorderThickness" Value="1"/>
            <Setter Property="Padding" Value="10"/>
            <Setter Property="Margin" Value="5"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="Cursor" Value="Hand" />
            <Setter Property="Template">
                <Setter.Value>
                    <ControlTemplate TargetType="Button">
                        <Border Background="{TemplateBinding Background}" 
                                BorderBrush="{TemplateBinding BorderBrush}" 
                                BorderThickness="{TemplateBinding BorderThickness}"
                                CornerRadius="5">
                            <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                        </Border>
                    </ControlTemplate>
                </Setter.Value>
            </Setter>
            <Setter Property="Effect">
                <Setter.Value>
                    <DropShadowEffect Color="Black" BlurRadius="10" ShadowDepth="2"/>
                </Setter.Value>
            </Setter>
            <Setter Property="HorizontalAlignment" Value="Center"/>
            <Setter Property="VerticalAlignment" Value="Center"/>
        </Style>

        <!-- Стиль для TextBox -->
        <Style TargetType="TextBox">
            <Setter Property="Background" Value="#2D2D30"/>
            <Setter Property="Foreground" Value="#FFFFFF"/>
            <Setter Property="BorderBrush" Value="#555555"/>
            <Setter Property="BorderThickness" Value="1"/>
            <Setter Property="Padding" Value="5"/>
            <Setter Property="Margin" Value="5"/>
            <Setter Property="FontSize" Value="14"/>
        </Style>

        <!-- Стиль для TextBlock -->
        <Style TargetType="TextBlock">
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="Margin" Value="5"/>
        </Style>
    </Window.Resources>

    <Grid>
        <StackPanel Margin="20">
            <TextBlock Text="Введите в область (s):" Margin="0,0,0,5"/>
            <TextBox Name="AreaInput" Width="200" Margin="0,0,0,10"/>
            <Button Content="Посчитать" Width="200" Click="Calculate_Click"/>
            <TextBlock Name="Results" Margin="0,10,0,0"/>
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
