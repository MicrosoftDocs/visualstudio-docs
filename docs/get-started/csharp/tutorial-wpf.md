---
title: "Hello World app with WPF in C#"
description: Create a simple Windows Desktop .NET app in C# with Visual Studio using the Windows Presentation Foundation (WPF) UI framework.
ms.custom: "seodec18, get-started"
ms.date: 08/09/2019
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: conceptual
dev_langs:
  - "CSharp"
ms.assetid: f84339c7-d617-4f56-bfcd-af2215c347ba
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "dotnet"
---
# Tutorial: Create a simple application with C\#

By completing this tutorial, you'll become familiar with many of the tools, dialog boxes, and designers that you can use when you develop applications with Visual Studio. You'll create a "Hello, World" application, design the UI, add code, and debug errors, while you learn about working in the integrated development environment ([IDE](visual-studio-ide.md)).

::: moniker range="vs-2017"
If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.
::: moniker-end
::: moniker range=">=vs-2019"
If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019) page to install it for free.
::: moniker-end

## Configure the IDE

::: moniker range="vs-2017"

When you open Visual Studio for the first time, you'll be prompted to sign in. This step is optional for this tutorial. Next you may be shown a dialog box that asks you to choose your development settings and color theme. Keep the defaults and choose **Start Visual Studio**.

![Choose settings dialog box](../media/exploreide-settings.png)

After Visual Studio launches, you'll see tool windows, the menus and toolbars, and the main window space. Tool windows are docked on the left and right sides of the application window, with **Quick Launch**, the menu bar, and the standard toolbar at the top. In the center of the application window is the **Start Page**. When you load a solution or project, editors and designers appear in the space where the **Start Page** is. When you develop an application, you'll spend most of your time in this central area.

![Visual Studio 2017 IDE with General Settings applied](../media/exploreide-idewithgeneralsettings.png "Screenshot of the Visual Studio 2017 IDE with General Settings applied")

::: moniker-end

::: moniker range=">=vs-2019"

When you launch Visual Studio, the start window opens first. Select **Continue without code** to open the development environment. You'll see tool windows, the menus and toolbars, and the main window space. Tool windows are docked on the left and right sides of the application window, with a search box, the menu bar, and the standard toolbar at the top. When you load a solution or project, editors and designers appear in the central space of the application window. When you develop an application, you'll spend most of your time in this central area.

::: moniker-end

## Create the project

When you create an application in Visual Studio, you first create a project and a solution. For this example, you'll create a Windows Presentation Foundation (WPF) project.

::: moniker range="vs-2017"

1. Create a new project. On the menu bar, select **File** > **New** > **Project**.

     ![On the menu bar, choose File, New, Project](../media/exploreide-filenewproject.png "Screenshot of the menu bar where you choose File, New, Project")

1. In the **New Project** dialog, select the **Installed** > **Visual C#** > **Windows Desktop** category, and then select the **WPF App (.NET Framework)** template. Name the project **HelloWPFApp**, and select **OK**.

     ![WPF app template in Visual Studio New Project dialog](media/exploreide-newprojectcsharp.png "Screenshot of the WPF app template in the New Project dialog")

::: moniker-end

::: moniker range="vs-2019"

1. Open Visual Studio 2019.

1. On the start window, choose **Create new project**.

   ![View the 'Create a new project' window](../../get-started/media/vs-2019/start-window-create-new-project.png "Screenshot of the 'Create a new project' window")

1. On the **Create a new project** screen, search for "WPF," choose **WPF App (.NET Framework)**, and then choose **Next**.

   ![WPF app template in 'Create a new project' dialog](media/vs-2019/exploreide-newprojectcsharp-vs2019.png "Screenshot of the WPF app template in 'Create a new project' dialog")

1. At the next screen, give the project a name, **HelloWPFApp**, and choose **Create**.

   ![Name your project 'HelloWPFApp'](./media/vs-2019/exploreide-nameproject.png "Screenshot of the window where you name your project")

::: moniker-end

Visual Studio creates the HelloWPFApp project and solution, and **Solution Explorer** shows the various files. The **WPF Designer** shows a design view and a XAML view of *MainWindow.xaml* in a split view. You can slide the splitter to show more or less of either view. You can choose to see only the visual view or only the XAML view.

![WPF project and solution in the IDE](media/exploreide-wpfproject-cs.png "Screenshot of the WPF project and solution in the IDE")

> [!NOTE]
> For more information about XAML (eXtensible Application Markup Language), see the [XAML overview for WPF](/dotnet/framework/wpf/advanced/xaml-overview-wpf) page.

After you create the project, you can customize it. To do so, choose **Properties Window** from the **View** menu, or press **F4**. Then, you can display and change options for project items, controls, and other items in an application.

   ![Properties window](../media/exploreide-hellowpfappfiles.png "Screenshot of the Properties window with WPF file app names")   

### Change the name of MainWindow.xaml

Let's give MainWindow a more specific name.

1. In **Solution Explorer**, select *MainWindow.xaml*. You should see the **Properties** window, but if you don't, choose the **View** menu and then the **Properties Window** item. (Or, press **F4**.)

1. Change the **File Name** property to `Greetings.xaml`.

     ![Properties window with File Name highlighted](../media/exploreide-filenameinpropertieswindow.png "Screenshot of the Properties window with the file name highlighted")

     **Solution Explorer** shows that the name of the file is now *Greetings.xaml*, and the nested code file is now named *Greetings.xaml.cs*. This code file is nested under the *.xaml* file node to show they're closely related to each other.

     ![Properties window and Solution Explorer window with Greetings file name](../media/exploreide-greetingsfilename.png "Screenshot of the Properties window and Solution Explorer window with Greetings file name")     

## Design the user interface (UI)

We'll add three types of controls to this application: a <xref:System.Windows.Controls.TextBlock> control, two <xref:System.Windows.Controls.RadioButton> controls, and a <xref:System.Windows.Controls.Button> control.

### Add a TextBlock control

1. Enter **Ctrl**+**Q** to activate the search box and type **Toolbox**. Choose **View > Toolbox** from the results list.

1. In the **Toolbox**, expand the **Common WPF Controls** node to see the TextBlock control.

     ![Toolbox with the TextBlock control highlighted](../media/exploreide-textblocktoolbox.png "Screenshot of the Toolbox window with the TextBlock control highlighted")

1. Add a TextBlock control to the design surface by choosing the **TextBlock** item and dragging it to the window on the design surface. Center the control near the top of the window.

    Your window should resemble the following illustration:

    ![TextBlock control on the Greetings form](../media/exploreide-greetingswithtextblockonly.png "Screenshot of the TextBlock control on the Greetings form")

   The XAML markup should look something like the following example:

    ```xaml
    <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="TextBlock" VerticalAlignment="Top"/>
    </Grid>
    ```

### Customize the text in the text block

1. In the XAML view, locate the markup for **TextBlock** and change the **Text** attribute from `TextBox` to `Select a message option and then choose the Display button.`

   The XAML markup should look something like the following example:

   ```xaml
   <Grid>
       <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
   </Grid>
   ```

1. Center the TextBlock again if you like, and then save your changes by pressing **Ctrl+S** or using the **File** menu item.

Next, you'll add two [RadioButton](/dotnet/framework/wpf/controls/radiobutton) controls to the form.

### Add radio buttons

1. In the **Toolbox**, find the **RadioButton** control.

     ![Toolbox window with RadioButton control selected](../media/exploreide-radiobuttontoolbox.png "Screenshot of the Toolbox window with the RadioButton control selected")

1. Add two RadioButton controls to the design surface by choosing the **RadioButton** item and dragging it to the window on the design surface. Move the buttons (by selecting them and using the arrow keys) so that the buttons appear side by side under the TextBlock control.

   Your window should look like this:

   ![Greetings form with TextBlock and two radio buttons](../media/exploreide-greetingswithradiobuttons.png "Screenshot of the Greetings form with TextBlock and two radio buttons")

1. In the **Properties** window for the left RadioButton control, change the **Name** property (the property at the top of the **Properties** window) to `HelloButton`.

    ![RadioButton properties window](../media/exploreide-buttonproperties.png "Screenshot of the RadioButton properties window")

1. In the **Properties** window for the right RadioButton control, change the **Name** property to `GoodbyeButton`, and then save your changes.

Next, you'll add display text for each RadioButton control. The following procedure updates the **Content** property for a RadioButton control.

### Add display text for each radio button

1. On the design surface, open the shortcut menu for HelloButton by pressing the right mouse button on HelloButton, choose **Edit Text**, and then enter `Hello`.

1. Open the shortcut menu for GoodbyeButton by pressing the right mouse button on GoodbyeButton, choose **Edit Text**, and then enter `Goodbye`.

   The XAML markup should now look similar to the following example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
   </Grid>
   ```

### Set a radio button to be checked by default

In this step, we'll set HelloButton to be checked by default so that one of the two radio buttons is always selected.

1. In the XAML view, locate the markup for HelloButton.

1. Add an **IsChecked** attribute and set it to **True**. Specifically, add `IsChecked="True"`.

   The XAML markup should now look similar to the following example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
   </Grid>
   ```

The final UI element that you'll add is a [Button](/dotnet/framework/wpf/controls/button) control.

### Add the button control

1. In the **Toolbox**, find the **Button** control, and then add it to the design surface under the RadioButton controls by dragging it to the form in the design view.

1. In the XAML view, change the value of **Content** for the Button control from `Content="Button"` to `Content="Display"`, and then save the changes.

     Your window should resemble the following illustration.

     ![Greetings form with control labels](media/exploreide-greetingswithcontrollabels-cs.png "Screenshot of the Greetings form with control labels")

   The XAML markup should now look similar to the following example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
        <Button Content="Display" HorizontalAlignment="Left" Margin="377,270,0,0" VerticalAlignment="Top" Width="75"/>
   </Grid>
   ```

### Add code to the display button

When this application runs, a message box appears after a user chooses a radio button and then chooses the **Display** button. One message box will appear for Hello, and another will appear for Goodbye. To create this behavior, you'll add code to the `Button_Click` event in *Greetings.xaml.cs*.

1. On the design surface, double-click the **Display** button.

     *Greetings.xaml.cs* opens, with the cursor in the `Button_Click` event.

    ```csharp
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {

    }
    ```

1. Enter the following code:

    ```csharp
    if (HelloButton.IsChecked)
    {
         MessageBox.Show("Hello.");
    }
    else if (GoodbyeButton.IsChecked)
    {
        MessageBox.Show("Goodbye.");
    }
    ```

1. Save the application.

## Debug and test the application

Next, you'll debug the application to look for errors and test that both message boxes appear correctly. The following instructions tell you how to build and launch the debugger, but later you might read [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf) and [Debug WPF](../../debugger/debugging-wpf.md) for more information.

### Find and fix errors

In this step, you'll find the error that we caused earlier by changing the name of the *MainWindow.xaml* file.

#### Start debugging and find the error

1. Start the debugger by pressing **F5** or selecting **Debug**, then **Start Debugging**.

   A **Break Mode** window appears, and the **Output** window indicates that an IOException has occurred: Cannot locate resource 'mainwindow.xaml'.

   ![IOException message](../media/exploreide-ioexception.png "Screenshot of IOException message")

1. Stop the debugger by choosing **Debug** > **Stop Debugging**.

We renamed *MainWindow.xaml* to *Greetings.xaml* at the start of this tutorial, but the code still refers to *MainWindow.xaml* as the startup URI for the application, so the project can't start.

#### Specify Greetings.xaml as the startup URI

1. In **Solution Explorer**, open the *App.xaml* file.

1. Change `StartupUri="MainWindow.xaml"` to `StartupUri="Greetings.xaml"`, and then save the changes.

Start the debugger again (press **F5**). You should see the **Greetings** window of the application. Now close the application window to stop debugging.

### Debug with breakpoints

You can test the code during debugging by adding some breakpoints. You can add breakpoints by choosing **Debug** > **Toggle Breakpoint**, by clicking in the left margin of the editor next to the line of code where you want the break to occur, or by pressing **F9**.

#### Add breakpoints

1. Open *Greetings.xaml.cs*, and select the following line: `MessageBox.Show("Hello.")`

1. Add a breakpoint from the menu by selecting **Debug**, then **Toggle Breakpoint**.

     A red circle appears next to the line of code in the far left margin of the editor window.

1. Select the following line: `MessageBox.Show("Goodbye.")`.

1. Press the **F9** key to add a breakpoint, and then press **F5** to start debugging.

1. In the **Greetings** window, choose the **Hello** radio button, and then choose the **Display** button.

    The line `MessageBox.Show("Hello.")` is highlighted in yellow. At the bottom of the IDE, the Autos, Locals, and Watch windows are docked together on the left side, and the Call Stack, Breakpoints, Exception Settings, Command, Immediate, and Output windows are docked together on the right side.

    ![Breakpoint in the debugger](media/exploreide-debugbreakpoint.png "Screenshot of breakpoint in the debugger")

1. On the menu bar, choose **Debug** > **Step Out**.

     The application resumes execution, and a message box with the word "Hello" appears.

1. Choose the **OK** button on the message box to close it.

1. In the **Greetings** window, choose the **Goodbye** radio button, and then choose the **Display** button.

     The line `MessageBox.Show("Goodbye.")` is highlighted in yellow.

1. Choose the **F5** key to continue debugging. When the message box appears, choose the **OK** button on the message box to close it.

1. Close the application window to stop debugging.

1. On the menu bar, choose **Debug** > **Disable All Breakpoints**.

### Build a release version of the application

Now that you've verified that everything works, you can prepare a release build of the application.

1. On the main menu, select **Build** > **Clean solution** to delete intermediate files and output files that were created during previous builds. This isn't necessary, but it cleans up the debug build outputs.

1. Change the build configuration for HelloWPFApp from **Debug** to **Release** by using the dropdown control on the toolbar (it says "Debug" currently).

1. Build the solution by choosing **Build** > **Build Solution**.

Congratulations on completing this tutorial! You can find the *.exe* you built under your solution and project directory (*...\HelloWPFApp\HelloWPFApp\bin\Release*).

## Next steps

Congratulations on completing this tutorial! To learn even more, continue with the following tutorials.

> [!div class="nextstepaction"]
> [Continue with more WPF tutorials](/dotnet/framework/wpf/getting-started/wpf-walkthroughs/)

## See also

- [Productivity tips](../../ide/productivity-features.md)
