---
title: "Hello World app with WPF in C#"
description: In this tutorial, create a Windows Desktop .NET application in C# with Visual Studio by using the Windows Presentation Foundation (WPF) UI framework.
ms.date: 12/03/2024
ms.subservice: general-ide
ms.topic: tutorial
dev_langs:
  - "CSharp"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.custom:
  - vs-acquisition
  - sfi-image-nochange
#customer intent: As a developer, I want to create a straight-forward project using Visual Studio to learn how the product works and practice essential elements of the design process.
---

# Tutorial: Create a WPF application with C\#

In this tutorial, you become familiar with many of the tools, dialog boxes, and designers that you can use when you develop applications with Visual Studio. You create a "Hello, World" application, design the user interface, add code, and debug errors. At the same time, learn about working in the Visual Studio integrated development environment ([IDE](visual-studio-ide.md)).

> [!div class="checklist"]
> - Configure the IDE
> - Create a project
> - Design the user interface
> - Debug and test the application

## Prerequisites

- If you don't have Visual Studio, go to [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) to install it for free.
- Make sure the **.NET desktop development** workload is installed. You can verify this configuration in Visual Studio Installer.
- You can use either .NET Framework or .NET Core for this tutorial. .NET Core is the newer, more modern framework. .NET Core requires Visual Studio 2019 version 16.3 or later.

## What is Windows Presentation Foundation?

Windows Presentation Foundation (WPF) is a user interface (UI) framework that creates desktop client applications. The WPF development platform supports a broad set of application development features, including an application model, resources, controls, graphics, layout, data binding, documents, and security.

WPF is part of .NET. If you previously built applications with .NET using ASP.NET or Windows Forms, the programming experience should be familiar. WPF uses the [Extensible Application Markup Language](../../xaml-tools/xaml-overview.md) (XAML) to provide a declarative model for application programming. For more information, see [Desktop Guide (WPF .NET)](/dotnet/desktop/wpf/overview/?view=netdesktop-6.0&preserve-view=true).

## Configure the IDE

When you launch Visual Studio, the start window opens. Select **Continue without code** to open the development environment. You see tool windows, the menus and toolbars, and the main window space. Tool windows are docked on the sides of the application window. The search box, menu bar, and the standard toolbar are located at the top. When you load a solution or project, editors and designers appear in the central space of the application window. When you develop an application, you spend most of your time in this central area.

## Create the project

When you create an application in Visual Studio, you first create a project and a solution. For this example, you create a Windows Presentation Foundation (WPF) project.

::: moniker range="vs-2019"

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

   :::image type="content" source="../../get-started/media/vs-2019/start-window-create-new-project.png" alt-text="Screenshot of the start window in Visual Studio 2019 with the 'Create a new project' option highlighted." lightbox="../../get-started/media/vs-2019/start-window-create-new-project.png":::

1. On the **Create a new project** screen, search for *WPF*. Choose **WPF Application**, and then choose **Next**.

   :::image type="content" source="media/vs-2019/explore-ide-new-project-csharp-vs-2019.png" alt-text="Screenshot of the 'Create a new project' dialog with 'WPF' entered in the search box, and the 'WPF Application' project template highlighted." lightbox="media/vs-2019/explore-ide-new-project-csharp-vs-2019.png":::

1. At the next screen, give the project a name, *HelloWPFApp*, and choose **Next**.

   :::image type="content" source="./media/vs-2019/explore-ide-name-project.png" alt-text="Screenshot of the 'Configure your new project' dialog in Visual Studio with 'HelloWPFApp' entered in the Project name field." lightbox="./media/vs-2019/explore-ide-name-project.png":::

1. In the **Additional information** window, **.NET Core 3.1** should already be selected for your target framework. If not, select **.NET Core 3.1**. Then, choose **Create**.

   :::image type="content" source="./media/vs-2019/wpf-target-framework.png" alt-text="Screenshot that shows the Additional information window in Visual Studio with .NET Core 3.1 selected for the new project." lightbox="./media/vs-2019/wpf-target-framework.png":::

Visual Studio creates the HelloWPFApp project and solution. **Solution Explorer** shows the various files. The **WPF Designer** shows a design view and a XAML view of `MainWindow.xaml` in a split view. You can slide the splitter to show more or less of either view. You can choose to see only the visual view or only the XAML view.

:::image type="content" source="media/exploreide-wpfproject-cs.png " alt-text="Screenshot of the project and solution showing Solution Explorer and the XAML and designer views of MainWindow.xaml.":::

> [!NOTE]
> For more information about XAML, see the [XAML overview for WPF](/dotnet/framework/wpf/advanced/xaml-overview-wpf) page.

After you create the project, you can customize it. To do so, choose **Properties Window** from the **View** menu, or press **F4**. You can display and change options for project items, controls, and other items in an application.

:::image type="content" source="../media/exploreide-hellowpfappfiles.png" alt-text="Screenshot of the Solution Explorer window showing the Properties, References, and files in the HelloWPF app.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio.

1. On the start window, choose **Create a new project**.

   :::image type="content" source="media/vs-2022/start-window-create-new-project.png" alt-text="Screenshot of the start window in Visual Studio 2022 with the 'Create a new project' option highlighted." lightbox="media/vs-2022/start-window-create-new-project.png":::

1. On the **Create a new project** screen, search for *WPF*. Choose **WPF Application**, and then choose **Next**.

   :::image type="content" source="media/vs-2022/explore-ide-new-project-csharp-wpf-vs-2022.png" alt-text="Screenshot of the 'Create a new project' dialog with 'WPF' in the search box, and the 'WPF Application' template highlighted." lightbox="media/vs-2022/explore-ide-new-project-csharp-wpf-vs-2022.png":::

1. At the next screen, give the project a name, *HelloWPFApp*, and choose **Next**.

   :::image type="content" source="media/vs-2022/explore-ide-name-project.png" alt-text="Screenshot that shows the 'Configure your new project' dialog in with 'HelloWPFApp' entered in the Project name field." lightbox="media/vs-2022/explore-ide-name-project.png":::

1. In the **Additional information** window, verify that **.NET 8.0** is selected for your target framework. Then, choose **Create**.

   :::image type="content" source="media/vs-2022/wpf-target-framework.png" alt-text="Screenshot that shows the Additional information window with .NET 8.0 selected as the target framework for the new project." lightbox="media/vs-2022/wpf-target-framework.png":::

Visual Studio creates the HelloWPFApp project and solution. **Solution Explorer** shows the various files. The **WPF Designer** shows a design view and a XAML view of `MainWindow.xaml` in a split view. You can slide the splitter to show more or less of either view. You can choose to see only the visual view or only the XAML view.

:::image type="content" source="media/vs-2022/explore-ide-wpf-project-cs.png" alt-text="Screenshot of the project and solution in Solution Explorer, and the XAML and designer views of 'MainWindow.xaml' open." lightbox="media/vs-2022/explore-ide-wpf-project-cs.png":::

> [!NOTE]
> For more information the Extensible Application Markup Language (XAML)), see [XAML overview for WPF](/dotnet/framework/wpf/advanced/xaml-overview-wpf).

After you create the project, you can customize it. To do so, choose **Properties Window** from the **View** menu, or press **F4**. Then, you can display and change options for project items, controls, and other items in an application.

:::image type="content" source="media/vs-2022/explore-ide-hello-wpf-properties.png" alt-text="Screenshot of the Properties window showing the Misc section of the Solution Properties for the HelloWPFApp project.":::

::: moniker-end

## Design the user interface

If the designer isn't open, select `MainWindow.xaml` and select **Shift**+**F7** to open the designer.

In this tutorial, you add three types of controls to this application: a <xref:System.Windows.Controls.TextBlock> control, two <xref:System.Windows.Controls.RadioButton> controls, and a <xref:System.Windows.Controls.Button> control.

### Add a TextBlock control

Follow these steps to add a TextBlock.

::: moniker range="<=vs-2019"

1. Select **Ctrl**+**Q** to activate the search box and type **Toolbox**. Choose **View > Toolbox** from the results list.

1. In the **Toolbox**, expand the **Common WPF Controls** node to see the TextBlock control.

   :::image type="content" source="../media/exploreide-textblocktoolbox.png" alt-text="Screenshot of the Toolbox window with the TextBlock control selected in the list of Common WPF Controls.":::

1. Add a TextBlock control to the design surface. Choose the **TextBlock** item and drag it to the window on the design surface. Center the control near the top of the window. In Visual Studio 2019 and later, you can use the guidelines to center the control.

   Your window should resemble this illustration:

   :::image type="content" source="media/explore-ide-window-with-textblock-only.png" alt-text="Screenshot of the TextBlock control on the design surface of the MainWindow form.":::

   The XAML markup should look like this example:

   ```xaml
   <Grid>
       <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="TextBlock" VerticalAlignment="Top"/>
   </Grid>
   ```

::: moniker-end

::: moniker range=">=vs-2022"

1. Select **Ctrl**+**Q** to activate the search box and type **Toolbox**. Choose **View > Toolbox** from the results list.

1. In the **Toolbox**, expand the **Common WPF Controls** node to see the TextBlock control.

   :::image type="content" source="media/vs-2022/explore-ide-textblock-toolbox.png" alt-text="Screenshot of the Toolbox window with the TextBlock control selected in the list of Common WPF Controls.":::

1. Add a TextBlock control to the design surface. Choose the **TextBlock** item and drag it to the window on the design surface. Center the control near the top of the window. You can use the guidelines to center the control.

   Your window should resemble this image:

   :::image type="content" source="media/vs-2022/explore-ide-greetings-with-textblock-only.png" alt-text="Screenshot of the TextBlock control on the design surface. Guidelines are shown for positioning and resizing the control.":::

   The XAML markup should look like this example:

   ```xaml
   <Grid>
       <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="TextBlock" VerticalAlignment="Top"/>
   </Grid>
   ```

::: moniker-end

### Customize the text in the text block

You can change what text the TextBlock displays.

1. In the XAML view, locate the markup for **TextBlock** and change the **Text** attribute from `TextBlock` to `Select a message option and then choose the Display button.`

   The XAML markup should look like this example:

   ```xaml
   <Grid>
       <TextBlock HorizontalAlignment="Left" Margin="387,60,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
   </Grid>
   ```

1. Center the TextBlock again, and then save your changes by selecting **Ctrl**+**S** or using the **File** menu item.

### Add radio buttons

Next, add two [RadioButton](/dotnet/framework/wpf/controls/radiobutton) controls to the form.

::: moniker range="<=vs-2019"

1. In the **Toolbox**, find the **RadioButton** control.

   :::image type="content" source="../media/exploreide-radiobuttontoolbox.png" alt-text="Screenshot of the Toolbox window with the RadioButton control selected in the list of Common WPF Controls.":::

1. Add two RadioButton controls to the design surface. Choose the **RadioButton** item and drag it to the window on the design surface. Move the buttons by selecting them and using the arrow keys. Arrange them so that the buttons appear side by side under the TextBlock control. Use the guidelines to align the controls.

   Your window should look like this:

   :::image type="content" source="media/explore-ide-window-with-radio-buttons.png" alt-text="Screenshot of the Design window for MainWindow.xaml, showing a TextBlock and two RadioButton controls on the design surface.":::

1. In the **Properties** window for the left RadioButton control, at the top, change the **Name** property to `HelloButton`.

   :::image type="content" source="../media/exploreide-buttonproperties.png" alt-text="Screenshot of the Properties window for a RadioButton control with the value of the Name property changed to HelloButton.":::

1. In the **Properties** window for the right RadioButton control, change the **Name** property to `GoodbyeButton`, and then save your changes.

::: moniker-end

::: moniker range=">=vs-2022"

1. In the **Toolbox**, find the **RadioButton** control.

   :::image type="content" source="media/vs-2022/explore-ide-radiobutton-toolbox.png" alt-text="Screenshot of the Toolbox window with the RadioButton control selected in the list of Common WPF Controls.":::

1. Add two RadioButton controls to the design surface. Choose the **RadioButton** item and drag it to the window on the design surface. Move the buttons by selecting them and using the arrow keys. Arrange them so that the buttons appear side by side under the TextBlock control. You can use the guidelines to align the controls.

   Your window should look like this:

   :::image type="content" source="media/vs-2022/explore-ide-greetings-with-radiobuttons.png" alt-text="Screenshot of the Design window for Greetings.xaml with a TextBlock and two RadioButton controls on the design surface.":::

1. In the **Properties** window for the left RadioButton control, at the top, change the **Name** property to `HelloButton`.

   :::image type="content" source="media/vs-2022/explore-ide-button-properties.png" alt-text="Screenshot of the Properties window for a RadioButton control with the value of the Name property changed to HelloButton.":::

1. In the **Properties** window for the right RadioButton control, change the **Name** property to `GoodbyeButton`, and then save your changes.

::: moniker-end

### Add display text for each radio button

Next, add display text for each RadioButton control. The following procedure updates the **Content** property for a RadioButton control.

- Update the **Content** attribute for the two radio buttons `HelloButton` and `GoodbyeButton` to `"Hello"` and `"Goodbye"` in the XAML. The XAML markup should now look similar to this example:

  ```xaml
  <Grid>
       <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
       <RadioButton x:Name="HelloButton" Content="Hello" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
       <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
  </Grid>
  ```

### Set a radio button to be checked by default

In this step, set HelloButton to be checked by default so that one of the two radio buttons is always selected.

1. In the XAML view, locate the markup for HelloButton.

1. Add an **IsChecked** attribute and set it to **True**. Specifically, add `IsChecked="True"`.

   The XAML markup should now look similar to this example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
   </Grid>
   ```

### Add the button control

The final UI element that you add is a [Button](/dotnet/framework/wpf/controls/button) control.

::: moniker range="<=vs-2019"

1. In the **Toolbox**, find the **Button** control. Add it to the design surface under the RadioButton controls by dragging it to the form in the design view. A guideline helps you center the control.

1. In the XAML view, change the value of **Content** for the Button control from `Content="Button"` to `Content="Display"`, and then save the changes.

   Your window should resemble this illustration.

   :::image type="content" source="media/explore-ide-window-with-control-labels-cs.png" alt-text="Screenshot of the Design window with a TextBlock, Hello and Goodbye RadioButton controls, and a Display button.":::

   The XAML markup should now look similar to this example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
        <Button Content="Display" HorizontalAlignment="Left" Margin="377,270,0,0" VerticalAlignment="Top" Width="75"/>
   </Grid>
   ```

::: moniker-end

::: moniker range=">=vs-2022"

1. In the **Toolbox**, find the **Button** control. Add it to the design surface under the RadioButton controls by dragging it to the form in the design view. The guidelines can help you center the control.

1. In the XAML view, change the value of **Content** for the Button control from `Content="Button"` to `Content="Display"`, and then save the changes.

   Your window should resemble this screenshot:

   :::image type="content" source="media/vs-2022/explore-ide-greetings-with-control-labels-cs.png" alt-text="Screenshot of the Design window with a TextBlock, Hello and Goodbye RadioButton controls, and a button labeled Display." lightbox="media/vs-2022/explore-ide-greetings-with-control-labels-cs.png":::

   The XAML markup should now look similar to this example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
        <Button Content="Display" HorizontalAlignment="Left" Margin="377,270,0,0" VerticalAlignment="Top" Width="75"/>
   </Grid>
   ```

::: moniker-end

### Add code to the display button

::: moniker range="<=vs-2019"

When this application runs, a message box appears after a user chooses a radio button and then chooses the **Display** button. One message box appears for Hello, and another appears for Goodbye. To create this behavior, you add code to the `Button_Click` event in *MainWindow.xaml.cs*.

1. On the design surface, double-click the **Display** button.

   *MainWindow.xaml.cs* opens, with the cursor in the `Button_Click` event.

   ```csharp
   private void Button_Click(object sender, RoutedEventArgs e)
   {

   }
   ```

1. Inside the braces, add the following code:

   ```csharp
   if (HelloButton.IsChecked == true)
   {
        MessageBox.Show("Hello.");
   }
   else if (GoodbyeButton.IsChecked == true)
   {
       MessageBox.Show("Goodbye.");
   }
   ```

1. Save the application.

::: moniker-end

::: moniker range=">=vs-2022"

When this application runs, a message box appears after a user chooses a radio button and then chooses the **Display** button. One message box appears for Hello, and another appears for Goodbye. To create this behavior, you add code to the `Button_Click` event in *MainWindow.xaml.cs*.

1. On the design surface, double-click the **Display** button.

   *MainWindow.xaml.cs* opens, with the cursor in the `Button_Click` event.

   ```csharp
   private void Button_Click(object sender, RoutedEventArgs e)
   {

   }
   ```

   When you double-click the **Display** button, `Click="Button_Click"` is added to the XAML.

   The XAML markup should now look similar to this example:

   ```xaml
   <Grid>
        <TextBlock HorizontalAlignment="Left" Margin="252,47,0,0" TextWrapping="Wrap" Text="Select a message option and then choose the Display button." VerticalAlignment="Top"/>
        <RadioButton x:Name="HelloButton" Content="Hello" IsChecked="True" HorizontalAlignment="Left" Margin="297,161,0,0" VerticalAlignment="Top"/>
        <RadioButton x:Name="GoodbyeButton" Content="Goodbye" HorizontalAlignment="Left" Margin="488,161,0,0" VerticalAlignment="Top"/>
        <Button Content="Display" HorizontalAlignment="Left" Margin="377,270,0,0" VerticalAlignment="Top" Width="75" Click="Button_Click"/>
   </Grid>
   ```

1. Inside the `Button_Click` braces, add the following code:

   ```csharp
   if (HelloButton.IsChecked == true)
   {
        MessageBox.Show("Hello.");
   }
   else if (GoodbyeButton.IsChecked == true)
   {
       MessageBox.Show("Goodbye.");
   }
   ```

1. Save the application.

::: moniker-end

## Debug and test the application

Next, debug the application to look for errors and test that both message boxes appear correctly. The following instructions tell you how to build and launch the debugger. For more information, see [Build a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf) and [Debug WPF](../../debugger/debugging-wpf.md).

### Change the name of MainWindow.xaml

Give MainWindow a more specific name. In **Solution Explorer**, right-click `MainWindow.xaml` and choose **Rename**. Rename the file to *Greetings.xaml*. In this example, this change creates an error used later to demonstrate debugging.

### Find and fix errors

In this step, you find the error that was caused earlier by changing the name of the `MainWindow.xaml` file.

#### Start debugging and find the error

::: moniker range="<=vs-2019"

1. Start the debugger by selecting **F5** or selecting **Debug**, then **Start Debugging**.

   A **Break Mode** window appears. The **Output** window indicates that an IOException occurred: *Cannot locate resource mainwindow.xaml*.

   :::image type="content" source="../media/exploreide-ioexception.png" alt-text="Screenshot of the Output window showing a System.IO.IOException with the message, Cannot locate resource mainwindow.xaml.":::

1. Stop the debugger by choosing **Debug** > **Stop Debugging**.

You renamed `MainWindow.xaml` to *Greetings.xaml*, but the code still refers to `MainWindow.xaml` as the startup URI for the application, so the project can't start.

::: moniker-end

::: moniker range=">=vs-2022"

1. Start the debugger by selecting **F5** or selecting **Debug**, then **Start Debugging**.

   A **Break Mode** window appears, and the **Output** window indicates that an IOException occurred: *Cannot locate resource mainwindow.xaml*.

   :::image type="content" source="media/vs-2022/explore-ide-ioexception.png" alt-text="Screenshot of the Output window showing a System.IO.IOException with the message, Cannot locate resource mainwindow.xaml.":::

1. Stop the debugger by choosing **Debug** > **Stop Debugging**.

You renamed `MainWindow.xaml` to `Greetings.xaml`, but the code still refers to `MainWindow.xaml` as the startup URI for the application, so the project can't start.

::: moniker-end

#### Specify Greetings.xaml as the startup URI

1. In **Solution Explorer**, open the `App.xaml` file.

1. Change `StartupUri="MainWindow.xaml"` to `StartupUri="Greetings.xaml"`, and save the changes.

As an optional step, it avoids confusion to change the title of your application window to match this new name.

1. In **Solution Explorer**, open the `Greetings.xaml` file that you just renamed.

1. Change the value of the  **Window.Title** property from `Title="MainWindow"` to `Title="Greetings"`, and save the changes.

Start the debugger again (press **F5**). You should now see the **Greetings** window of your application.

::: moniker range="vs-2019"
:::image type="content" source="media/vs-2019/exploreide-wpf-running-app.png" alt-text="Screenshot of the Greetings window with the TextBlock, RadioButtons, and Button controls visible and 'Hello' selected." lightbox="media/vs-2019/exploreide-wpf-running-app.png":::
::: moniker-end
::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/explore-ide-wpf-running-app.png" alt-text="Screenshot of the Greetings window with the TextBlock, RadioButtons, and Button controls visible and 'Hello' selected.":::

::: moniker-end

 To stop debugging, close the application window

### Debug with breakpoints

You can test the code during debugging by adding some breakpoints. You can add breakpoints by choosing **Debug** > **Toggle Breakpoint**, by clicking in the left margin of the editor next to the line of code where you want the break to occur, or by pressing **F9**.

#### Add breakpoints

::: moniker range="vs-2019"

1. Open *Greetings.xaml.cs*, and select this line: `MessageBox.Show("Hello.")`

1. Add a breakpoint from the menu by selecting **Debug**, then **Toggle Breakpoint**.

   A red circle appears next to the line of code in the far left margin of the editor window.

1. Select this line: `MessageBox.Show("Goodbye.")`.

1. Press the **F9** key to add a breakpoint, and then select **F5** to start debugging.

1. In the **Greetings** window, choose the **Hello** radio button, and then choose the **Display** button.

   The line `MessageBox.Show("Hello.")` is highlighted in yellow. At the bottom of the IDE, the Autos, Locals, and Watch windows are docked together on the left side. The **Call Stack**, **Breakpoints**, **Exception Settings**, **Command**, **Immediate**, and **Output** windows are docked together on the right side.

   :::image type="content" source="media/exploreide-debugbreakpoint.png" alt-text="Screenshot of a debug session, with the code window showing execution stopped at a breakpoint highlighted in yellow." lightbox="media/exploreide-debugbreakpoint.png":::

1. On the menu bar, choose **Debug** > **Step Out**.

   The application resumes execution, and a message box with the word "Hello" appears.

1. Choose **OK** on the message box to close it.

1. In the **Greetings** window, choose the **Goodbye** radio button, and then choose the **Display** button.

   The line `MessageBox.Show("Goodbye.")` is highlighted in yellow.

1. Choose the **F5** key to continue debugging. When the message box appears, choose **OK** on the message box to close it.

1. To stop debugging, close the application window.

1. On the menu bar, choose **Debug** > **Disable All Breakpoints**.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open *Greetings.xaml.cs*, and select this line: `MessageBox.Show("Hello.")`

1. Add a breakpoint from the menu by selecting **Debug**, then **Toggle Breakpoint**.

   A red circle appears next to the line of code in the far left margin of the editor window.

1. Select this line: `MessageBox.Show("Goodbye.")`.

1. Press the **F9** key to add a breakpoint, and then select **F5** to start debugging.

1. In the **Greetings** window, choose the **Hello** radio button, and then choose the **Display** button.

   The line `MessageBox.Show("Hello.")` is highlighted in yellow. At the bottom of the IDE, the Autos, Locals, and Watch windows are docked together on the left side. The **Call Stack**, **Breakpoints**, **Exception Settings**, **Command**, **Immediate**, and **Output** windows are docked together on the right side.

   :::image type="content" source="media/vs-2022/explore-ide-debug-breakpoint.png" alt-text="Screenshot of a debug session, with the code window showing execution stopped at a breakpoint highlighted in yellow." lightbox="media/vs-2022/explore-ide-debug-breakpoint.png":::

1. On the menu bar, choose **Debug** > **Step Out**.

   The application resumes execution, and a message box with the word "Hello" appears.

1. Choose **OK** on the message box to close it.

1. In the **Greetings** window, choose the **Goodbye** radio button, and then choose the **Display** button.

   The line `MessageBox.Show("Goodbye.")` is highlighted in yellow.

1. Choose the **F5** key to continue debugging. When the message box appears, choose **OK** on the message box to close it.

1. To stop debugging, close the application window.

1. On the menu bar, choose **Debug** > **Disable All Breakpoints**.

::: moniker-end

### View a representation of the UI elements

In the running app, you should see a widget that appears at the top of your window. The widget is a runtime helper that provides quick access to some helpful debugging features. Select the first button, **Go to Live Visual Tree**. You should see a window with a tree that contains all the visual elements of your page. Expand the nodes to find the buttons you added.

::: moniker range="vs-2019"
:::image type="content" source="media/vs-2019/exploreide-live-visual-tree.png" alt-text="Screenshot of the Live Visual Tree window, showing the tree of visual elements in the page while it's running.":::
::: moniker-end
::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/explore-ide-live-visual-tree.png" alt-text="Screenshot of the Live Visual Tree window, showing the tree of visual elements in HelloWPFApp.exe while it's running.":::

::: moniker-end
### Build a release version of the application

After you verify that everything works, you can prepare a release build of the application.

1. On the main menu, select **Build** > **Clean solution** to delete intermediate files and output files that were created during previous builds. This step isn't required, but it cleans up the debug build outputs.

1. Change the build configuration for HelloWPFApp from **Debug** to **Release** by using the dropdown control on the toolbar. It says **Debug** currently.

1. Build the solution by choosing **Build** > **Build Solution**.

Congratulations on completing this tutorial! You can find the `.exe` you built under your solution and project directory (*...\HelloWPFApp\HelloWPFApp\bin\Release*).

## Related content

- [Productivity tips](../../ide/productivity-features.md)

## Next step

Congratulations on completing this tutorial! To learn even more, continue with the following tutorials.

> [!div class="nextstepaction"]
> [Continue with more WPF tutorials](/dotnet/framework/wpf/getting-started/wpf-walkthroughs/)
