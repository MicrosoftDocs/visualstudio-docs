---
title: "Tutorial: Create Windows App SDK Apps with Visual Studio & C#"
description: Create a Windows App SDK application in Visual Studio by using the Extensible Application Markup Language (XAML) and C#.
titleSuffix: ""
ms.custom: vs-acquisition
ms.date: 02/25/2026
ms.subservice: general-ide
ms.topic: tutorial
ms.devlang: csharp
author: MikeJo5000
ms.author: mikejo
manager: mijacobs
dev_langs:
  - CSharp

#customer intent: As a C# developer working with Visual Studio, I need know how to add a button and edit the event handler for the button. 
---

# Tutorial: Create your first Windows App SDK application in Visual Studio with XAML and C&#35;

In this introduction to the Visual Studio integrated development environment (IDE), you create a "Hello World" app that runs on any Windows 10 or later device. To do so, you use a Windows App SDK (WinUI 3) project template, Extensible Application Markup Language (XAML), and the C# programming language.

> [!NOTE]
> WinUI 3 is the native UI platform component that ships with the [Windows App SDK](/windows/apps/windows-app-sdk/). It's completely decoupled from [Windows SDKs](/windows/apps/windows-app-sdk/). For more information, see [WinUI 3](/windows/apps/winui/winui3/).


## Prerequisites

- You need Visual Studio 2026 or the latest version of Visual Studio 2022 to complete this tutorial. For a free version, see [Visual Studio downloads](https://visualstudio.microsoft.com/vs/).
- Workloads and components required for developing with WinUI and the Windows App SDK. To verify or install a workload in Visual Studio, select **Tools** > **Get Tools and Features**. For more information, see [Change workloads or individual components](../../install/modify-visual-studio.md#change-workloads-or-individual-components).
    
On the **Workloads** tab of the Visual Studio Installer, select the following:

::: moniker range=">=visualstudio"
    
For **C#** app development using the Windows App SDK, select **WinUI application development**.
    
::: moniker-end

::: moniker range="vs-2022"

For **C#** app development using the Windows App SDK, select **WinUI application development**.
    
> [!NOTE]
> _In Visual Studio 17.10 - 17.12, this workload is called **Windows application development**._

::: moniker-end

For details, see [Install tools for the Windows App SDK](/windows/apps/windows-app-sdk/set-up-your-development-environment).

## Create a project

First, create a WinUI 3 project. The project type comes with all the template files you need, before you even add anything!

::: moniker range=">=visualstudio"

1. Open Visual Studio, and on the start window, choose **Create a new project**.

1. On the **Create a new project** screen, enter *WinUI* in the search box, choose the C# template for **WinUI Blank App (Packaged)**, and then choose **Next**.

   :::image type="content" source="media/visualstudio/winui-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog with 'WinUI' entered in the search box, and the WinUI Blank App (Packaged) project template highlighted.":::

1. Give the project a name, *HelloWorld*, and choose **Create**.

   :::image type="content" source="media/visualstudio/winui-configure-your-project.png" alt-text="Screenshot of the 'Configure your new project' dialog with 'HelloWorld' entered in the Project name field.":::

::: moniker-end

::: moniker range="vs-2022"

1. Open Visual Studio, and on the start window, choose **Create a new project**.

1. On the **Create a new project** screen, enter *winui* in the search box, choose the C# template for **C# template for Blank App, Packaged (WinUI 3 in Desktop)**, and then choose **Next**.

   :::image type="content" source="media/vs-2022/winui-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog in Visual Studio 2022 with 'WinUI' entered in the search box, and the WinUI Blank App (Packaged) project template highlighted.":::

1. Give the project a name, *HelloWorld*, and choose **Create**.

   :::image type="content" source="media/vs-2022/winui-configure-your-project.png" alt-text="Screenshot of the 'Configure your new project' dialog in Visual Studio 2022 with 'HelloWorld' entered in the Project name field.":::

::: moniker-end

   > [!NOTE]
   > If this article is the first time you use Visual Studio to create a Windows App SDK app, a **Settings** dialog might appear. Choose **Developer mode**, and then choose **Yes**.
   >
   > :::image type="content" source="media/enable-developer-mode.png" alt-text="Screenshot showing the Settings dialog with the option for enabling Developer Mode.":::
   >
   > Visual Studio installs another Developer Mode package for you. When the package installation is complete, close the **Settings** dialog.

## Create the application

It's time to start developing. Here you add a button control, add an action to the button, and then run the **Hello World** app to see what it looks like.

### Add a button to the Design canvas

::: moniker range=">=visualstudio"

1. In the **Solution Explorer**, double-click *MainWindow.xaml* to open the XAML markup editor.

   :::image type="content" source="media/vs-2022/winui-solution-explorer-mainwindow-xaml.png" alt-text="Screenshot of the Solution Explorer window showing the properties, references, assets, and files in the HelloWorld project, with the file MainWindow.xaml selected.":::  

   The **XAML Editor** is where you can add or change markup. Unlike UWP projects, WinUI 3 doesn't have a **Design** view.

   :::image type="content" source="media/visualstudio/winui-editor.png" alt-text="Screenshot showing MainWindow.xaml open in the Visual Studio IDE. The XAML Editor pane shows the XAML markup for the window.":::

1. Inside the `<Grid>` item, start typing `<Button`. Intellisense offers you a button option. Press **Tab** to accept.

   :::image type="content" source="media/visualstudio/winui-button-control.png" alt-text="Screenshot showing 'Button' highlighted in the XAML editor.":::

::: moniker-end

::: moniker range="vs-2022"

1. In the **Solution Explorer**, double-click *MainWindow.xaml* to open the XAML markup editor.

   :::image type="content" source="media/vs-2022/winui-solution-explorer-mainwindow-xaml.png" alt-text="Screenshot of the Solution Explorer window in Visual Studio 2022 showing the properties, references, assets, and files in the HelloWorld project, with the file MainWindow.xaml selected.":::  

   The **XAML Editor** is where you can add or change markup. Unlike UWP projects, WinUI 3 doesn't have a **Design** view.

   :::image type="content" source="media/vs-2022/winui-xaml-editor.png" alt-text="Screenshot showing MainWindow.xaml open in the Visual Studio 2022 IDE. The XAML Editor pane shows the XAML markup for the window.":::

1. Review the **Button** control nested within the **StackPanel** at the root of the **Window**.

   :::image type="content" source="media/vs-2022/winui-button-control.png" alt-text="Screenshot showing 'Button' highlighted in the XAML editor.":::

::: moniker-end

### Change the label on the button

::: moniker range=">=visualstudio"

1. In the **XAML Editor**, change Button Content value from its current value to "Hello World!".

   :::image type="content" source="media/visualstudio/winui-change-button-text.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor, with the value of the Content property changed to Hello World!":::

1. Place your cursor in the `<Button>` element's start tag (after the existing attributes, such as `Content`) and start typing *Click*. Intellisense offers a new event handler called **Button_Click**. You work with that code in the next section.

   :::image type="content" source="media/visualstudio/winui-button-click-event-highlighted.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor with the click event of the button highlighted.":::

::: moniker-end

::: moniker range="vs-2022"

1. In the **XAML Editor**, change Button Content value from its current value to "Hello World!".

   :::image type="content" source="media/vs-2022/winui-change-button-text-in-xaml-code-window.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor in Visual Studio 2022, with the value of the Content property changed to Hello World!":::

1. Notice that the button has a **Click** event handler named *myButton_Click* specified, too. You work with that in the next step.

   :::image type="content" source="media/vs-2022/winui-button-click-event-highlighted.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor in Visual Studio 2022 with the click event of the button highlighted.":::

::: moniker-end

### Modify the event handler

An *event handler* sounds complicated, but it's just another name for code that is called when an event happens. In this case, it adds an action triggered by the Hello World! button.

::: moniker range=">=visualstudio"

1. In **Solution Explorer**, double-click *MainWindow.xaml.cs*, the code-behind page.

1. Edit the event handler code in the C# editor window that opens.

   Here's where things get interesting. The default event handler looks like this:

   :::image type="content" source="media/visualstudio/winui-button-click-code.png" alt-text="Screenshot showing the C# code for the default Button_Click event handler.":::

   Let's change it, so it looks like this:

   :::image type="content" source="media/visualstudio/winui-add-hello-world-code.png" alt-text="Screenshot showing the C# code for the new async myButton_Click event handler.":::

   Here's the code to copy and paste:

   ```csharp
   private async void Button_Click(object sender, RoutedEventArgs e)
   {
       var welcomeDialog = new ContentDialog()
       {
           Title = "Hello from HelloWorld",
           Content = "Welcome to your first Windows App SDK app.",
           CloseButtonText = "Ok",
           XamlRoot = ((FrameworkElement)sender).XamlRoot
       };
       await welcomeDialog.ShowAsync();
   }
   ```

::: moniker-end

::: moniker range="vs-2022"

1. In **Solution Explorer**, double-click *MainWindow.xaml.cs*, the code-behind page.

1. Edit the event handler code in the C# editor window that opens.

   Here's where things get interesting. The default event handler looks like this:

   :::image type="content" source="media/vs-2022/winui-button-click-code.png" alt-text="Screenshot showing the C# code for the default Button_Click event handler in Visual Studio 2022.":::

   Let's change it, so it looks like this:

   :::image type="content" source="media/vs-2022/winui-add-hello-world-async-code.png" alt-text="Screenshot showing the C# code for the new async myButton_Click event handler in Visual Studio 2022.":::

   Here's the code to copy and paste:

   ```csharp
   private async void myButton_Click(object sender, RoutedEventArgs e)
   {
       var welcomeDialog = new ContentDialog()
       {
           Title = "Hello from HelloWorld",
           Content = "Welcome to your first Windows App SDK app.",
           CloseButtonText = "Ok",
           XamlRoot = myButton.XamlRoot
       };
       await welcomeDialog.ShowAsync();
   }
   ```

::: moniker-end

#### What did we just do?

The code uses the **ContentDialog** control to display a welcome message in a modal popup control within the current window. For more information on using `Microsoft.UI.Xaml.Controls.ContentDialog`, see [ContentDialog Class](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.contentdialog).

## Run the application

It's time to build, deploy, and launch the Hello World Windows App SDK app to see what it looks like. Here's how.

1. Use the Play button to start the application on the local machine. It has the text **HelloWorld (Package)**.

   :::image type="content" source="media/vs-2022/winui-start-or-debug.png" alt-text="Screenshot showing the dropdown box open next to the Play button with 'HelloWorld (Package)' selected.":::

   Alternatively, you can choose **Debug** > **Start Debugging** from the menu bar or press **F5** to start your app.

1. View your app, which appears soon after a splash screen disappears. The app should look similar to this image:

   :::image type="content" source="media/vs-2022/winui-hello-world-app.png" alt-text="Screenshot showing the running Windows App SDK 'Hello World' application.":::

1. Select the **Hello World** button.

   Your Windows 10 or later device displays a message that says "Welcome to your first Windows App SDK app" with the title "Hello from HelloWorld." Select **Ok** to dismiss the message.

   :::image type="content" source="media/vs-2022/winui-hello-from-hello-world-app.png" alt-text="Screenshot showing the running 'Hello World' application with a popup titled 'Hello from HelloWorld'.":::

1. To close the app, select the **Stop Debugging** button in the toolbar. Alternatively, choose **Debug** > **Stop debugging** from the menu bar, or press **Shift+F5**.

## Related content

Congratulations on completing this tutorial! We hope you learned some basics about Windows App SDK, WinUI 3, and the Visual Studio IDE. To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Tutorial: Create a simple photo viewer with WinUI 3](/windows/apps/get-started/simple-photo-viewer-winui3)

These resources might also be useful:

- [Writing apps for Windows: Selecting a development technology](/windows/apps/get-started/)
- [Windows App SDK overview](/windows/apps/windows-app-sdk/)
- [Windows App SDK / WinUI 3 samples](/windows/apps/get-started/samples#windows-app-sdk--winui-3-samples)
