---
title: "Walkthrough: My First WPF Desktop Application2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 3c460fa9-2ea1-413f-ae54-54a1f2a499d1
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: My First WPF Desktop Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

a name="introduction"></a> This walkthrough provides an introduction to Windows Presentation Foundation (WPF) development. You’ll create a basic application that includes the elements that are common to most WPF desktop applications: XAML markup, code-behind, application definitions, controls, layout, data binding, and styles.

## <a name="Create_The_Application_Code_Files"></a> Creating the Application Project
 In this section, you’ll create the application infrastructure, which includes the project and a main window or form.

#### To create the project

1. On the menu bar, choose **File**, **New**, **Project**.

2. In the **New Project** dialog, expand either the **Visual C#** or **Visual Basic** node and choose the **Windows** node, and then expand the **Windows** node and choose the **Classic Desktop** node.

3. In the template list, choose the **WPF Application** template.

4. In the **Name** textbox enter `ExpenseIt`, and then choose the **OK** button.

     The project is created and the project files are added to **Solution Explorer**, and the designer for the default application window named **MainWindow.xaml** is displayed.

#### To modify the main window

1. In the designer, choose the **MainWindow.xaml** tab if it isn’t already the active designer tab.

2. If you’re using C#, find the line `<Window x:Class="ExpenseIt.MainWindow"` and replace it with `<NavigationWindow x:Class="ExpenseIt.MainWindow"`.

     If you’re using Visual Basic, find the line `<Window x:Class=" MainWindow"` and replace it with `<NavigationWindow x:Class="MainWindow"`.

     Notice that when you change the `<Window` tag to `<NavigationWindow`, Intellisense automatically changes the closing tag to `</NavigationWindow>` as well.

    > [!NOTE]
    > After changing the tag, if the **Error List** window is open you may notice several errors. Don’t worry, the changes you make in the next few steps will make these go away.

3. Choose the `<Grid>` and `</Grid>` tags and delete them.

     A **NavigationWindow** can’t contain other UI elements such as a **Grid**.

4. In the **Properties** window, expand the **Common** category node and choose the **Title** property, and then enter `ExpenseIt` and press the **Enter** key.

     Notice that the **Title** element in the XAML window changes to match the new value. You can modify XAML properties in either the XAML window or the **Properties** window, and the changes are synchronized.

5. In the XAML window, set the value of the **Height** element to `375`, and set the value of the **Width** property to `500`.

     These elements correspond to the **Height** and **Width** properties, found in the **Layout** category in the **Properties** window.

     Your **MainWindow.xaml** file should now look like this in C#:

    ```xaml
    <NavigationWindow x:Class="ExpenseIt.MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
            xmlns:local="clr-namespace:ExpenseIt"
            mc:Ignorable="d"
            Title="ExpenseIt" Height="375" Width="500">

    </NavigationWindow>
    ```

     Or like this in Visual Basic:

    ```xaml
    <NavigationWindow x:Class="MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
            xmlns:local="clr-namespace:ExpenseIt"
            mc:Ignorable="d"
            Title="ExpenseIt" Height="375" Width="500">

    </NavigationWindow>
    ```

#### To modify the code-behind file (C#)

1. In **Solution Explorer**, expand the **MainWindow.xaml** node and open the **MainWindow.xaml.cs** file.

2. Find the line `public partial class MainWindow : Window` and replace it with `public partial class MainWindow : NavigationWindow`.

     This changes the `MainWindow` class to derive from `NavigationWindow`. In Visual Basic, this happens automatically when you change the window in XAML, so no code changes are necessary.

## <a name="add_files_to_the_application"></a> Adding Files to the Application
 In this section, you’ll add two pages and an image to the application.

#### To add a home screen

1. In **Solution Explorer**, open the shortcut menu for the **ExpenseIt** node and choose **Add**, **Page**.

2. In the **Add New Item** dialog, choose the **Name** text box and enter `ExpenseItHome`, and then choose the **Add** button.

     This page is the first window that is displayed when the application is launched.

3. In the designer, choose the **ExpenseItHome.xaml** tab if it isn’t already the active designer tab.

4. Choose the `<Title>` element and change the title to **ExpenseIt – Home**.

     Your **ExpenseItHome.xaml** file should now look like this in C#:

    ```xaml
    <Page x:Class="ExpenseIt.ExpenseItHome"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - Home">

        <Grid>

        </Grid>
    </Page>
    ```

     Or like this in Visual Basic:

    ```xaml
    <Page x:Class="ExpenseItHome"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - Home">
        <Grid>

        </Grid>
    </Page>
    ```

5. In the designer, choose the **MainWindow.xaml** tab.

6. Find the line `Title="ExpenseIt" Height="375" Width="500">` element and add a `Source="ExpenseItHome.xaml"` property.

     This sets **ExpenseItHome.xaml** to be the first page opened when the application starts. Your **MainWindow.xaml** file should now look like this in C#:

    ```xaml
    <NavigationWindow x:Class="ExpenseIt.MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
            xmlns:local="clr-namespace:ExpenseIt"
            mc:Ignorable="d"
            Title="ExpenseIt" Height="375" Width="500" Source="ExpenseItHome.xaml">

    </NavigationWindow>
    ```

     Or like this in Visual Basic:

    ```xaml
    <NavigationWindow x:Class="MainWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
            xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
            xmlns:local="clr-namespace:ExpenseIt"
            mc:Ignorable="d"
            Title="ExpenseIt" Height="375" Width="500" Source="ExpenseItHome.xaml">

    </NavigationWindow>
    ```

     As with the properties that you set earlier, you could have set the `Source` property in the **Miscellaneous** category of the **Properties** window.

#### To add a details window

1. In **Solution Explorer**, open the shortcut menu for the **ExpenseIt** node and choose **Add**, **Page**.

2. In the **Add New Item** dialog, choose the **Name** text box and enter `ExpenseReportPage`, and then choose the **Add** button.

     This window will display an individual expense report.

3. In the designer, choose the **ExpenseReportPage.xaml** tab if it isn’t already the active designer tab.

4. Choose the `<Title>` element and change the title to **ExpenseIt – View Expense**.

     Your ExpenseReportPage.xaml file should now look like this in C#:

    ```xaml
    <Page x:Class="ExpenseIt.ExpenseReportPage"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - View Expense">

        <Grid>

        </Grid>
    </Page>
    ```

     Or like this in Visual Basic:

    ```xaml
    <Page x:Class="ExpenseReportPage"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - View Expense">
        <Grid>

        </Grid>
    </Page>
    ```

5. On the menu bar, choose **Debug**, **Start Debugging** (or press F5) to run the application.

     The following illustration shows the application with the navigation window buttons.

     ![ExpenseIt sample screen shot](../designers/media/gettingstartedfigure1.png "GettingStartedFigure1")

6. Close the application to return to design mode.

## <a name="Add_Layout"></a> Creating the User Interface
 Layout provides an ordered way to place elements, and also manages the size and position of those elements when a form is resized. In this section, you’ll create a single-column grid with three rows. You’ll add controls to the two pages, add some code, and finally define reusable styles for the controls.

#### To create the layout

1. Open **ExpenseItHome.xaml** and choose the `<Grid>` element.

2. In the **Properties** window, expand the **Layout** category node and set the **Margin** values to `10`, `10`, `0`, and `10`, which corresponds to left, right, top and bottom margins.

     The element `Margin="10,0,10,10"` is added to the `<Grid>` element in the XAML. Once again, you could have entered these values directly in the XAML code instead of in the **Properties** window with the same result.

3. Add the following XAML code to the `Grid` element to create the row and column definitions:

    ```xaml
    <Grid.ColumnDefinitions>
        <ColumnDefinition />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto"/>
        <RowDefinition />
        <RowDefinition Height="Auto"/>
    </Grid.RowDefinitions>
    ```

#### To add controls

1. Open **ExpenseItHome.xaml**.

2. Add the following XAML code just above the `</Grid>` tag to create the `Border`, `ListBox` and `Button` controls.

    ```xaml
    <!-- People list -->
      <Border Grid.Column="0" Grid.Row="0" Height="35" Padding="5" Background="#4E87D4">
          <Label VerticalAlignment="Center" Foreground="White">Names</Label>
      </Border>
      <ListBox Name="peopleListBox" Grid.Column="0" Grid.Row="1">
          <ListBoxItem>Mike</ListBoxItem>
          <ListBoxItem>Lisa</ListBoxItem>
          <ListBoxItem>John</ListBoxItem>
          <ListBoxItem>Mary</ListBoxItem>
      </ListBox>

      <!-- View report button -->
      <Button Grid.Column="0" Grid.Row="2" Margin="0,10,0,0" Width="125"
    Height="25" HorizontalAlignment="Right">View</Button>

    ```

     Notice that the controls appear in the design window. You could also have created the controls by dragging them from the **Toolbox** window onto the design window and setting their properties in the **Properties** window.

3. Build and run the application. The following illustration shows the run time appearance of the controls that are created by the XAML in this procedure.

     ![ExpenseIt sample screen shot](../designers/media/gettingstartedfigure2.png "GettingStartedFigure2")

4. Close the application to return to design mode.

#### To add a background image

1. Choose the following image and save it as `watermark.png`.

     ![Watermark image for walkthrough](../designers/media/wpf-watermark.png "WPF_watermark")

    > [!NOTE]
    > Alternatively you can create your own image and save it as `watermark.png`.

2. In **Solution Explorer**, open the shortcut menu for the **ExpenseIt** node and choose **Add**, **Existing Item**.

3. In the **Add Existing Item** dialog, find the **watermark.png** image that you just added, choose it and then choose the **Add** button.

    > [!NOTE]
    > You may need to expand the **File Types** list and choose **Image Files**.

4. Open the **ExpenseItHome.xaml** file and add the following XAML code just above the `</Grid>` tag to create a background image:

    ```xaml
    <Grid.Background>
        <ImageBrush ImageSource="watermark.png"/>
    </Grid.Background>

    ```

#### To add a title

1. Open **ExpenseItHome.xaml**.

2. Find the line `<Grid.ColumnDefinitions>` and add the following just below it:

    ```xaml
    <ColumnDefinition Width="230" />

    ```

     This creates an additional column to the left of the other columns with a fixed width of 230 pixels.

3. Find the line `<Grid.RowDefinitions>` and add the following just below it:

    ```xaml
    <RowDefinition />

    ```

     This adds a row to the top of the grid.

4. Move the controls to the second column by setting the `Grid.Column` value to 1. Move each control down a row, by increasing each `Grid.Row` value by 1.

    1. Find the line `<Border Grid.Column="0" Grid.Row="0" Height="35" Padding="5" Background="#4E87D4">`. Change `Grid.Column="0"` to `Grid.Column="1"` and change `Grid.Row="0"` to `Grid.Row="1"`.

    2. Find the line `<ListBox Name="peopleListBox" Grid.Column="0" Grid.Row="1"`. Change `Grid.Column="0"` to `Grid.Column="1"` and change `Grid.Row="1"` to `Grid.Row="2"`.

    3. Find the line `<Button Grid.Column="0" Grid.Row="2" Margin="0,10,0,0" Width="125"`. Change `Grid.Column="0"` to `Grid.Column="1"` and change `Grid.Row="2"` to `Grid.Row="3"`.

5. Just before the `<Border` element add the following XAML code to display the title:

    ```xaml
    <Label Grid.Column="1" VerticalAlignment="Center" FontFamily="Trebuchet MS"
            FontWeight="Bold" FontSize="18" Foreground="#0066cc">
        View Expense Report
    </Label>

    ```

     The contents of **ExpenseItHome.xaml** should now look like this in C#:

    ```xaml
    <Page x:Class="ExpenseIt.ExpenseItHome"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - Home">
        <Grid Margin="10,0,10,10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="230" />
                <ColumnDefinition />
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                <RowDefinition />
                <RowDefinition Height="Auto"/>
                <RowDefinition />
                <RowDefinition Height="Auto"/>
            </Grid.RowDefinitions>
            <Border Grid.Column="1" Grid.Row="1" Height="35" Padding="5" Background="#4E87D4">
                <Label VerticalAlignment="Center" Foreground="White">Names</Label>
            </Border>
            <!-- People list -->
            <Label Grid.Column="1" VerticalAlignment="Center" FontFamily="Trebuchet MS"
            FontWeight="Bold" FontSize="18" Foreground="#0066cc">
                View Expense Report
            </Label>
            <ListBox Name="peopleListBox" Grid.Column="1" Grid.Row="2">
                <ListBoxItem>Mike</ListBoxItem>
                <ListBoxItem>Lisa</ListBoxItem>
                <ListBoxItem>John</ListBoxItem>
                <ListBoxItem>Mary</ListBoxItem>
            </ListBox>

            <!-- View report button -->
            <Button Grid.Column="1" Grid.Row="3" Margin="0,10,0,0" Width="125"
    Height="25" HorizontalAlignment="Right">View</Button>
            <Grid.Background>
                <ImageBrush ImageSource="watermark.png"/>
            </Grid.Background>
        </Grid>
    </Page>
    ```

     Or like this in Visual Basic:

    ```xaml
    <Page x:Class="ExpenseItHome"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
          xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
          xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
          xmlns:local="clr-namespace:ExpenseIt"
          mc:Ignorable="d"
          d:DesignHeight="300" d:DesignWidth="300"
          Title="ExpenseIt - Home" >
        <Grid Margin="10,0,10,10">
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="230" />
                <ColumnDefinition />
            </Grid.ColumnDefinitions>
            <Grid.RowDefinitions>
                <RowDefinition />
                <RowDefinition Height="Auto"/>
                <RowDefinition />
                <RowDefinition Height="Auto"/>
            </Grid.RowDefinitions>
            <Border Grid.Column="1" Grid.Row="1" Height="35" Padding="5" Background="#4E87D4">
                <Label VerticalAlignment="Center" Foreground="White">Names</Label>
            </Border>
            <!-- People list -->
            <Label Grid.Column="1" VerticalAlignment="Center" FontFamily="Trebuchet MS"
            FontWeight="Bold" FontSize="18" Foreground="#0066cc">
                View Expense Report
            </Label>
            <ListBox Name="peopleListBox" Grid.Column="1" Grid.Row="2">
                <ListBoxItem>Mike</ListBoxItem>
                <ListBoxItem>Lisa</ListBoxItem>
                <ListBoxItem>John</ListBoxItem>
                <ListBoxItem>Mary</ListBoxItem>
            </ListBox>

            <!-- View report button -->
            <Button Grid.Column="1" Grid.Row="3" Margin="0,10,0,0" Width="125"
    Height="25" HorizontalAlignment="Right">View</Button>
            <Grid.Background>
                <ImageBrush ImageSource="watermark.png"/>
            </Grid.Background>
        </Grid>
    </Page>
    ```

6. If you build and run the application at this point, it should look like the following illustration:

     ![ExpenseIt sample screen shot](../designers/media/gettingstartedfigure3.png "GettingStartedFigure3")

#### To add code to the button

1. Open **ExpenseItHome.xaml**.

2. Chose the `<Button` element and add the following XAML code immediately after the **HorizontalAlignment="Right"** element: `Click="Button_Click"`.

     This adds an event handler for the button’s `Click` event. The **<Button** element code should now look like this:

    ```
    <!-- View report button -->
      <Button Grid.Column="1" Grid.Row="3" Margin="0,10,0,0" Width="125"
    Height="25" HorizontalAlignment="Right" Click="Button_Click">View</Button>
    ```

3. Open the **ExpenseItHome.xaml.cs** or **ExpenseItHome.xaml.vb** file.

4. Add the following code to the `ExpenseItHome` class:

    ```csharp
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // View Expense Report
        ExpenseReportPage expenseReportPage = new ExpenseReportPage();
        this.NavigationService.Navigate(expenseReportPage);

    }
    ```

    ```vb
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' View Expense Report
        Dim expenseReportPage As New ExpenseReportPage()
    Me.NavigationService.Navigate(expenseReportPage)
    End Sub
    ```

     This event handler opens the Expense Report Page when the button is clicked.

#### To create the UI for the report page

1. Open **ExpenseReportPage.xaml**.

     This page will display the expense report for the person that is selected on the Home page.

2. Add the following XAML code between the `<Grid>` and `</Grid>` tags:

    ```xaml
    <Grid.Background>
        <ImageBrush ImageSource="watermark.png" />
    </Grid.Background>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="230" />
        <ColumnDefinition />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition />
    </Grid.RowDefinitions>

    <Label Grid.Column="1" VerticalAlignment="Center" FontFamily="Trebuchet MS"
    FontWeight="Bold" FontSize="18" Foreground="#0066cc">
        Expense Report For:
    </Label>
    <Grid Margin="10" Grid.Column="1" Grid.Row="1">

        <Grid.ColumnDefinitions>
            <ColumnDefinition />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="Auto" />
            <RowDefinition />
        </Grid.RowDefinitions>

        <!-- Name -->
        <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="0" Orientation="Horizontal">
            <Label Margin="0,0,0,5" FontWeight="Bold">Name:</Label>
            <Label Margin="0,0,0,5" FontWeight="Bold"></Label>
        </StackPanel>

        <!-- Department -->
        <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="1" Orientation="Horizontal">
            <Label Margin="0,0,0,5" FontWeight="Bold">Department:</Label>
            <Label Margin="0,0,0,5" FontWeight="Bold"></Label>
        </StackPanel>

        <Grid Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="2" VerticalAlignment="Top"
              HorizontalAlignment="Left">
            <!-- Expense type and Amount table -->
            <DataGrid  AutoGenerateColumns="False" RowHeaderWidth="0" >
                <DataGrid.ColumnHeaderStyle>
                    <Style TargetType="{x:Type DataGridColumnHeader}">
                        <Setter Property="Height" Value="35" />
                        <Setter Property="Padding" Value="5" />
                        <Setter Property="Background" Value="#4E87D4" />
                        <Setter Property="Foreground" Value="White" />
                    </Style>
                </DataGrid.ColumnHeaderStyle>
                <DataGrid.Columns>
                    <DataGridTextColumn Header="ExpenseType" />
                    <DataGridTextColumn Header="Amount"  />
                </DataGrid.Columns>
            </DataGrid>
        </Grid>
    </Grid>
    ```

     This UI is similar to the UI created for the home page, but the report data is displayed in a **DataGrid** control.

3. Build and run the application.

4. Choose the **View** button.

     The expense report page appears.

     The following illustration shows the Expense Report Page. Notice that the back navigation button is enabled.

     ![ExpenseIt sample screen shot](../designers/media/gettingstartedfigure4.png "GettingStartedFigure4")

#### To style controls

1. Open the **App.xaml** file (C#) or **Application.xaml** file (Visual Basic).

2. Add the following XAML between the `<Application.Resources>` and `</Application.Resources>` tags:

    ```xaml
    <!-- Header text style -->
    <Style x:Key="headerTextStyle">
        <Setter Property="Label.VerticalAlignment" Value="Center"></Setter>
        <Setter Property="Label.FontFamily" Value="Trebuchet MS"></Setter>
        <Setter Property="Label.FontWeight" Value="Bold"></Setter>
        <Setter Property="Label.FontSize" Value="18"></Setter>
        <Setter Property="Label.Foreground" Value="#0066cc"></Setter>
    </Style>

    <!-- Label style -->
    <Style x:Key="labelStyle" TargetType="{x:Type Label}">
        <Setter Property="VerticalAlignment" Value="Top" />
        <Setter Property="HorizontalAlignment" Value="Left" />
        <Setter Property="FontWeight" Value="Bold" />
        <Setter Property="Margin" Value="0,0,0,5" />
    </Style>

    <!-- DataGrid header style -->
    <Style x:Key="columnHeaderStyle" TargetType="{x:Type DataGridColumnHeader}">
        <Setter Property="Height" Value="35" />
        <Setter Property="Padding" Value="5" />
        <Setter Property="Background" Value="#4E87D4" />
        <Setter Property="Foreground" Value="White" />
    </Style>

    <!-- List header style -->
    <Style x:Key="listHeaderStyle" TargetType="{x:Type Border}">
        <Setter Property="Height" Value="35" />
        <Setter Property="Padding" Value="5" />
        <Setter Property="Background" Value="#4E87D4" />
    </Style>

    <!-- List header text style -->
    <Style x:Key="listHeaderTextStyle" TargetType="{x:Type Label}">
        <Setter Property="Foreground" Value="White" />
        <Setter Property="VerticalAlignment" Value="Center" />
        <Setter Property="HorizontalAlignment" Value="Left" />
    </Style>

    <!-- Button style -->
    <Style x:Key="buttonStyle" TargetType="{x:Type Button}">
        <Setter Property="Width" Value="125" />
        <Setter Property="Height" Value="25" />
        <Setter Property="Margin" Value="0,10,0,0" />
        <Setter Property="HorizontalAlignment" Value="Right" />
    </Style>
    ```

     This XAML adds the following styles:

    - `headerTextStyle`: To format the page title `Label`.

    - `labelStyle`: To format the `Label` controls.

    - `columnHeaderStyle`: To format the `DataGridColumnHeader`.

    - `listHeaderStyle`: To format the list header `Border` controls.

    - `listHeaderTextStyle`: To format the list header **Label**.

    - `buttonStyle`: To format the `Button` on the **ExpenseItHome.xaml** pppage.

3. Open **ExpenseItHome.xaml** and replace everything between the `<Grid>` and `</Grid>` elements with the following XAML

    ```xaml
    <Grid.ColumnDefinitions>
                <ColumnDefinition Width="230" />
                <ColumnDefinition />
            </Grid.ColumnDefinitions>

            <Grid.RowDefinitions>
                <RowDefinition/>
                <RowDefinition Height="Auto"/>
                <RowDefinition />
                <RowDefinition Height="Auto"/>
            </Grid.RowDefinitions>
            <Label Grid.Column="1" Style="{StaticResource headerTextStyle}" >
                View Expense Report
            </Label>
            <!-- People list -->
                  <Border Grid.Column="1" Grid.Row="1" Style="{StaticResource listHeaderStyle}">
                <Label Style="{StaticResource listHeaderTextStyle}">Names</Label>
            </Border>
            <ListBox Name="peopleListBox" Grid.Column="1" Grid.Row="2">
                <ListBoxItem>Mike</ListBoxItem>
                <ListBoxItem>Lisa</ListBoxItem>
                <ListBoxItem>John</ListBoxItem>
                <ListBoxItem>Mary</ListBoxItem>
            </ListBox>

            <!-- View report button -->
            <Button Grid.Column="1" Grid.Row="3" Click="Button_Click" Style="{StaticResource buttonStyle}">View</Button>
            <Grid.Background>
                <ImageBrush ImageSource="watermark.png"  />
            </Grid.Background>
    ```

     The properties such as `VerticalAlignment` and `FontFamily` that define the look of each control are removed and replaced by applying the styles.

4. Open **ExpenseReportPage.xaml** and replace everything between the `<Grid>` and final `</Grid>` elements with the following XAML

    ```xaml
    <Grid.Background>
        <ImageBrush ImageSource="watermark.png" />
    </Grid.Background>
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="230" />
        <ColumnDefinition />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition />
    </Grid.RowDefinitions>
    <Label Grid.Column="1" Style="{StaticResource headerTextStyle}">
        Expense Report For:
    </Label>
    <Grid Margin="10" Grid.Column="1" Grid.Row="1">
        <Grid.ColumnDefinitions>
            <ColumnDefinition />
            <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="Auto" />
            <RowDefinition />
        </Grid.RowDefinitions>

        <!-- Name -->
        <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="0" Orientation="Horizontal">
            <Label Style="{StaticResource labelStyle}">Name:</Label>
            <Label Style="{StaticResource labelStyle}"></Label>
        </StackPanel>

        <!-- Department -->
        <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="1"
    Orientation="Horizontal">
            <Label Style="{StaticResource labelStyle}">Department:</Label>
            <Label Style="{StaticResource labelStyle}"></Label>
        </StackPanel>

        <Grid Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="2" VerticalAlignment="Top"
              HorizontalAlignment="Left">
            <!-- Expense type and Amount table -->
            <DataGrid ColumnHeaderStyle="{StaticResource columnHeaderStyle}"
                      AutoGenerateColumns="False" RowHeaderWidth="0" >
                <DataGrid.Columns>
                    <DataGridTextColumn Header="ExpenseType" />
                    <DataGridTextColumn Header="Amount"  />
                </DataGrid.Columns>
            </DataGrid>
        </Grid>
    </Grid>

    ```

     This adds styles to the `<Label>` and `<Border>` elements.

## Connecting to Data
 In this section, you’ll create a data provider and a data template, and then connect the controls to display the data.

#### To bind data to a control

1. Open **ExpenseItHome.xaml** and choose the `<Grid>` element..

2. Add the following XAML code:

    ```xaml

    <Grid.Resources>
    <!-- Expense Report Data -->
    <XmlDataProvider x:Key="ExpenseDataSource" XPath="Expenses">
        <x:XData>
            <Expenses xmlns="">
                <Person Name="Mike" Department="Legal">
                    <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                    <Expense ExpenseType="Transportation" ExpenseAmount="50" />
                </Person>
                <Person Name="Lisa" Department="Marketing">
                    <Expense ExpenseType="Document printing"
          ExpenseAmount="50"/>
                    <Expense ExpenseType="Gift" ExpenseAmount="125" />
                </Person>
                <Person Name="John" Department="Engineering">
                    <Expense ExpenseType="Magazine subscription"
         ExpenseAmount="50"/>
                    <Expense ExpenseType="New machine" ExpenseAmount="600" />
                    <Expense ExpenseType="Software" ExpenseAmount="500" />
                </Person>
                <Person Name="Mary" Department="Finance">
                    <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                </Person>
            </Expenses>
        </x:XData>
    </XmlDataProvider>
    </Grid.Resources>
    ```

     This code creates an `XmlDataProvider` class that contains the data for each person. Normally this would be loaded as a file, but for simplicity the data is added inline.

3. Inside the `<Grid.Resources>` element, add the following XAML code:

    ```xaml
    <!-- Name item template -->
    <DataTemplate x:Key="nameItemTemplate">
        <Label Content="{Binding XPath=@Name}"/>
    </DataTemplate>
    ```

     This adds a `Data Template` which defines how to display the data in the **ListBox**.

4. Replace the existing `<ListBox>` element with the following XAML.

    ```xaml
    <ListBox Name="peopleListBox" Grid.Column="1" Grid.Row="2"
             ItemsSource="{Binding Source={StaticResource ExpenseDataSource}, XPath=Person}"
             ItemTemplate="{StaticResource nameItemTemplate}">
    </ListBox>
    ```

     This code binds the `ItemsSource` property of the `ListBox` to the data source and applies the data template as the `ItemTemplate`.

#### To connect data to controls

1. Open **ExpenseReportPage.xaml.vb** or **ExpenseReportPage.xaml.cs**.

2. In C#, add the following constructor to the **ExpenseReportPage** class, or in Visual Basic replace the existing class with the following:

    ```csharp
    // Custom constructor to pass expense report data
        public ExpenseReportPage(object data):this()
        {
            // Bind to expense report data.
            this.DataContext = data;
        }
    ```

    ```vb
    Partial Public Class ExpenseReportPage
    Inherits Page
    Public Sub New()
    InitializeComponent()
    End Sub

    ' Custom constructor to pass expense report data
    Public Sub New(ByVal data As Object)
    Me.New()
    ' Bind to expense report data.
    Me.DataContext = data
    End Sub

    End Class
    ```

     This constructor takes a data object as a parameter. In this case the data object will contain the name of the selected person.

3. Open **ExpenseItHome.xaml.vb** or **ExpenseItHome.xaml.cs**.

4. Replace the `Click` event handler code with the following:

    ```csharp
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // View Expense Report
        ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
        this.NavigationService.Navigate(expenseReportPage);

    }
    ```

    ```vb
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' View Expense Report
        Dim expenseReportPage As New ExpenseReportPage(Me.peopleListBox.SelectedItem)
        Me.NavigationService.Navigate(expenseReportPage)
    End Sub
    ```

     This code calls the new constructor.

#### To update the UI with data templates

1. Open **ExpenseReportPage.xaml**.

2. Replace the XAML code for the **Name** and **Department**`<StackPanel` elements with the following:

    ```xaml
    <!-- Name -->
    <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="0" Orientation="Horizontal">
        <Label Style="{StaticResource labelStyle}">Name:</Label>
        <Label Style="{StaticResource labelStyle}" Content="{Binding XPath=@Name}"></Label>
    </StackPanel>

    <!-- Department -->
    <StackPanel Grid.Column="0" Grid.ColumnSpan="2" Grid.Row="1" Orientation="Horizontal">
        <Label Style="{StaticResource labelStyle}">Department:</Label>
        <Label Style="{StaticResource labelStyle}" Content="{Binding XPath=@Department}"></Label>
    </StackPanel>

    ```

     This binds the **Label** controls to the appropriate data source properties.

3. Add the following XAML code inside the `<Grid>` element:

    ```xaml
    <!--Templates to display expense report data-->
    <Grid.Resources>
        <!-- Reason item template -->
        <DataTemplate x:Key="typeItemTemplate">
            <Label Content="{Binding XPath=@ExpenseType}"/>
        </DataTemplate>
        <!-- Amount item template -->
        <DataTemplate x:Key="amountItemTemplate">
            <Label Content="{Binding XPath=@ExpenseAmount}"/>
        </DataTemplate>
    </Grid.Resources>

    ```

     This defines how to display the expense report data.

4. Replace the `<DataGrid>` element with the following:

    ```xaml
    <!-- Expense type and Amount table -->
    <DataGrid ItemsSource="{Binding XPath=Expense}" ColumnHeaderStyle="{StaticResource columnHeaderStyle}" AutoGenerateColumns="False" RowHeaderWidth="0" >

        <DataGrid.Columns>
            <DataGridTextColumn Header="ExpenseType" Binding="{Binding XPath=@ExpenseType}"  />
            <DataGridTextColumn Header="Amount" Binding="{Binding XPath=@ExpenseAmount}" />
        </DataGrid.Columns>

    </DataGrid>
    ```

     This adds an **ItemSource** and defines the bindings for the expense items.

5. Build and run the application.

6. Choose a person and then choose the **View** button.

     The following illustration shows both pages of the ExpenseIt application with controls, layout, styles, data binding, and data templates applied.

     ![ExpenseIt sample screen shots](../designers/media/gettingstartedfigure5.png "GettingStartedFigure5")

## <a name="Best_Practices"></a> Best Practices
 This sample demonstrates the basics of WPF and, consequently, does not follow application development best practices. For comprehensive coverage of WPF and .NET Framework application development best practices, see the following topics as appropriate:

- Accessibility - [Accessibility Best Practices](https://msdn.microsoft.com/library/aa350483\(v=vs.100\).aspx)

- Security - [Windows Presentation Foundation Security](https://msdn.microsoft.com/library/aa970906\(v=vs.100\).aspx)

- Localization - [WPF Globalization and Localization Overview](https://msdn.microsoft.com/library/ms788718\(v=vs.100\).aspx)

- Performance - [Optimizing WPF Application Performance](https://msdn.microsoft.com/library/aa970683\(v=vs.100\).aspx)

## <a name="Whats_Next"></a> What's Next
 You now have a number of techniques at your disposal for creating a desktop application by using WPF. You should now have a basic understanding of the building blocks of a data-bound WPF application. This topic is by no means exhaustive, but hopefully you also now have a sense of some of the possibilities you might discover on your own beyond the techniques in this topic.

 For more information about the WPF architecture and programming models, see the following topics:

- [WPF Architecture](https://msdn.microsoft.com/library/ms750441\(v=vs.100\).aspx)

- [XAML Overview](https://msdn.microsoft.com/library/ms752059\(v=vs.100\).aspx)

- [Dependency Properties Overview](https://msdn.microsoft.com/library/ms752914\(v=vs.100\).aspx)

- [Layout System](https://msdn.microsoft.com/library/ms745058\(v=vs.100\).aspx)

- [Styles and Templates](https://msdn.microsoft.com/library/bb613570\(v=vs.100\).aspx)

  For more information about creating applications, see the following topics:

- [Application Development Overview](https://msdn.microsoft.com/library/bb613549\(v=vs.100\).aspx)

- [Controls Overview](https://msdn.microsoft.com/library/bb613551\(v=vs.100\).aspx)

- [Data Binding Overview](https://msdn.microsoft.com/library/ms752347\(v=vs.100\).aspx)

- [WPF Graphics, Animation, and Media Overview](https://msdn.microsoft.com/library/ms742562\(v=vs.100\).aspx)

- [Documents in WPF](https://msdn.microsoft.com/library/ms748388\(v=vs.100\).aspx)

## See Also
 [Walkthrough: Create a WPF Desktop Application connected to an Azure Mobile Service](../designers/walkthrough-create-a-wpf-desktop-application-connected-to-an-azure-mobile-service.md)
 [Create Modern Desktop Applications with Windows Presentation Foundation](../designers/create-modern-desktop-applications-with-windows-presentation-foundation.md)
