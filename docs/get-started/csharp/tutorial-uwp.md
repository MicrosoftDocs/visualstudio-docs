---
title: "Tutorial: Create UWP Apps with Visual Studio & C#"
description: Create a Universal Windows Platform (UWP) app in Visual Studio by using the Extensible Application Markup Language (XAML) and C#.
titleSuffix: ""
ms.custom: vs-acquisition
ms.date: 04/25/2025
ms.subservice: general-ide
ms.topic: tutorial
ms.devlang: csharp
author: anandmeg
ms.author: meghaanand
manager: mijacobs
dev_langs:
  - CSharp
#customer intent: As a developer, I want to create a simple but complete application with XAML and C# in Visual Studio to understand the parts of such a project.
---
# Tutorial: Create your first Universal Windows Platform application in Visual Studio with XAML and C&#35;

In this tutorial, as an introduction to the Visual Studio integrated development environment (IDE), you create a "Hello World" app that runs on any Windows 10 or later device. To do so, you use a Universal Windows Platform (UWP) project template, Extensible Application Markup Language (XAML), and the C# programming language.

> [!NOTE]
> If you're happy with your current functionality in the Universal Windows Platform (UWP), then there's no need to migrate your project type to Windows App SDK. WinUI 2.x, and the Windows SDK, support UWP project types. If you would like to get started with WinUI 3 and Windows App SDK, then you can follow the steps in the [Windows App SDK tutorial](tutorial-wasdk.md).

In this tutorial, you:

> [!div class="checklist"]
> - Create a project
> - Create an application
> - Run the application

::: moniker range=">=vs-2022"
## Prerequisites

You need:

- Visual Studio. Visit the [Visual Studio downloads page](https://visualstudio.microsoft.com/vs/) for a free version.
- Workloads and components required for developing a UWP app. To verify or install a workload in Visual Studio, select **Tools** > **Get Tools and Features**, or in the **Create a new project** window, select the **Install more tools and features** link. For more information, see [Change workloads or individual components](../../install/modify-visual-studio.md#change-workloads-or-individual-components).
    
    On the **Workloads** tab of the Visual Studio Installer, select the following workloads and components:

    ### [Visual Studio 2022 version 17.10 and later](#tab/vs-2022-17-10)
    
    * For app development using UWP, select the **WinUI application development** workload. Then, in the **Installation details** pane, under the **WinUI application development** node, select the UWP option you need (this will also select any additional required components.):

    * For C#, select **Universal Windows Platform tools**.

    * This tutorial requires the **UWP Blank App** project template.
    
    ### [Visual Studio 2022 version 17.1 - 17.9](#tab/vs-2022-17-1)
    
    * For **C#** app development using UWP, select the **Universal Windows Platform development** workload.

    * This tutorial requires the **Blank App (Universal Windows)** project template.
    
    ---

   > [!NOTE]
   > _In Visual Studio 17.10 - 17.12, this workload is called **Windows application development**._

::: moniker-end

::: moniker range="=vs-2019"

You need Visual Studio to complete this tutorial. Visit the [Visual Studio downloads page](https://visualstudio.microsoft.com/vs/) for a free version.

> [!NOTE]
> This tutorial requires the **Blank App (Universal Windows)** project template. During installation, select the **Universal Windows Platform development** workload:
>
> :::image type="content" source="media/uwp-dev-workload.png" alt-text="Screenshot of the Visual Studio Installer showing the Universal Windows Platform development workload.":::
>
> If you already have Visual Studio installed and need to add it, from the menu, select **Tools** > **Get Tools and Features**, or in the **Create a new project** window, select the **Install more tools and features** link.
>
> :::image type="content" source="media/vs-2019/uwp-not-finding.png" alt-text="Screenshot of the Create a new project window showing the 'Install more tools and features' link.":::

## Create a project

First, create a Universal Windows Platform project. The project type comes with all the template files you need, before you even add anything!

::: moniker range="vs-2019"

1. Open Visual Studio, and on the start window, choose **Create a new project**.

1. On the **Create a new project** screen, enter *Universal Windows* in the search box, choose the C# template for **Blank App (Universal Windows)** or **UWP Blank App** in Visual Studio 2022 17.10 or later, and then choose **Next**.

   :::image type="content" source="media/vs-2019/uwp-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog box with 'universal windows' entered in the search box, and the 'Blank App (Universal Windows)' project template highlighted.":::

1. Give the project a name, *HelloWorld*, and choose **Create**.

   :::image type="content" source="media/vs-2019/uwp-configure-your-project.png" alt-text="Screenshot of the 'Configure your new project' dialog box with 'HelloWorld' entered in the Project name field.":::

1. Accept the default **Target version** and **Minimum version** settings in the **New Universal Windows Platform Project** dialog box.

   :::image type="content" source="media/vs-2019/new-uwp-project-target-minver-dialog.png" alt-text="Screenshot of the New Universal Windows Platform Project dialog box showing the default Target version and Minimum version settings.":::

   > [!NOTE]
   > If this is the first time you have used Visual Studio to create a UWP app, a **Settings** dialog box might appear. Choose **Developer mode**, and then choose **Yes**.
   >
   > :::image type="content" source="media/enable-developer-mode.png" alt-text="Screenshot showing the UWP Settings dialog box with the option for enabling Developer Mode.":::
   >
   > Visual Studio installs an additional Developer Mode package for you. When the package installation is complete, close the **Settings** dialog box.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio, and on the start window, choose **Create a new project**.

1. On the **Create a new project** screen, enter *Universal Windows* in the search box, choose the C# template for **Blank App (Universal Windows)**, and then choose **Next**.

   :::image type="content" source="media/vs-2022/uwp-create-new-project.png" alt-text="Screenshot of the 'Create a new project' dialog box with 'Universal Windows' entered in the search box, and the 'Blank App (Universal Windows)' project template highlighted.":::

1. Give the project a name, *HelloWorld*, and choose **Create**.

   :::image type="content" source="media/vs-2022/uwp-configure-your-project.png" alt-text="Screenshot of the 'Configure your new project' dialog box with 'HelloWorld' entered in the Project name field.":::

1. Accept the default **Target version** and **Minimum version** settings in the **New Universal Windows Platform Project** dialog box.

   :::image type="content" source="media/vs-2022/new-uwp-project-target-minver-dialog.png" alt-text="Screenshot of the New Universal Windows Platform Project dialog box showing the default Target version and Minimum version settings.":::

   > [!NOTE]
   > If this is the first time you have used Visual Studio to create a UWP app, the **Enable Developer Mode for Windows** dialog box appears. Select **settings for developers** to open **Settings**. Turn on **Developer mode**, and then choose **Yes**.
   >
   > :::image type="content" source="media/vs-2022/enable-developer-mode-settings.png" alt-text="Screenshot showing the UWP Settings dialog box with the option for enabling Developer Mode.":::
   >
   > Visual Studio installs an additional Developer Mode package for you. When the package installation is complete, close the **Settings** dialog box.

::: moniker-end

## Create the application

It's time to start developing. Add a button control, add an action to the button, and then start the "Hello World" app to see what it looks like.

### Add a button to the Design canvas

::: moniker range="vs-2019"

1. In the **Solution Explorer**, double-click `MainPage.xaml` to open a split view.

   :::image type="content" source="media/vs-2019/uwp-solution-explorer-mainpage-xaml.png" alt-text="Screenshot of the Solution Explorer window showing the properties, references, assets, and files in the HelloWorld project with the file MainPage.xaml selected.":::

   There are two panes: The **XAML Designer**, which includes a design canvas, and the **XAML Editor**, where you can add or change code.

   :::image type="content" source="media/uwp-xaml-editor.png" alt-text="Screenshot showing MainPage.xaml open in the Visual Studio IDE and the XAML Designer pane shows a blank design surface and the XAML Editor pane shows some of the XAML code.":::

1. Choose **Toolbox** to open the Toolbox fly-out window.

   :::image type="content" source="media/uwp-toolbox.png" alt-text="Screenshot showing the tab for the 'Toolbox' fly-out window highlighted on the left side of the XAML Designer Pane.":::

   If you don't see the **Toolbox** option, you can open it from the menu bar. To do so, choose **View** > **Toolbar**. Or, press **Ctrl**+**Alt**+**X**.

1. Select the **Pin** icon to dock the Toolbox window.

   :::image type="content" source="media/uwp-toolbox-autohide.png" alt-text="Screenshot showing the Pin icon highlighted in the top bar of the Toolbox window.":::

1. Select the **Button** control and then drag it onto the design canvas.

   :::image type="content" source="media/uwp-toolbox-add-button-control.png" alt-text="Screenshot showing 'Button' highlighted in the Toolbox window and a Button control on the design canvas.":::

   If you look at the code in the **XAML Editor**, you see that the **Button** appears there, too:

   :::image type="content" source="media/uwp-xaml-control-code-window.png" alt-text="Screenshot showing the code for the newly added Button highlighted in the XAML editor.":::

::: moniker-end

::: moniker range=">=vs-2022"

1. In the **Solution Explorer**, double-click `MainPage.xaml` to open a split view.

   :::image type="content" source="media/vs-2022/uwp-solution-explorer-mainpage-xaml.png" alt-text="Screenshot of the Solution Explorer window showing the properties, references, assets, and files in the HelloWorld project. The file MainPage.xaml is selected.":::  

   There are two panes: The **XAML Designer**, which includes a design canvas, and the **XAML Editor**, where you can add or change code.

   :::image type="content" source="media/vs-2022/uwp-xaml-editor.png" alt-text="Screenshot showing MainPage.xaml open in the Visual Studio IDE. The XAML Designer pane shows a blank design surface and the XAML Editor pane shows some of the XAML code.":::

1. Choose **Toolbox** to open the Toolbox fly-out window.

   :::image type="content" source="media/vs-2022/uwp-toolbox.png" alt-text="Screenshot showing the tab for the 'Toolbox' fly-out window highlighted on the left side of the XAML Designer Pane.":::

   If you don't see the **Toolbox** option, you can open it from the menu bar. To do so, choose **View** > **Toolbar**. Or, press **Ctrl**+**Alt**+**X**.

1. Select the **Pin** icon to dock the Toolbox window.

   :::image type="content" source="media/vs-2022/uwp-toolbox-autohide.png" alt-text="Screenshot showing the Pin icon highlighted in the top bar of the Toolbox window.":::

1. Select the **Button** control and then drag it onto the design canvas.

   :::image type="content" source="media/vs-2022/uwp-toolbox-add-button-control.png" alt-text="Screenshot showing 'Button' highlighted in the Toolbox window and a Button control on the design canvas.":::

   If you look at the code in the **XAML Editor**, you see that the Button appears there, too:

   :::image type="content" source="media/vs-2022/uwp-xaml-control-code-window.png" alt-text="Screenshot showing the code for the newly added Button highlighted in the XAML editor.":::

::: moniker-end

### Add a label to the button

::: moniker range="<=vs-2019"

1. In the **XAML Editor**, change `Button Content` value from *Button* to *Hello World!*

   :::image type="content" source="media/uwp-change-button-text-in-xaml-code-window.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor, with the Content property changed to Hello World!":::

1. Notice that the button in the **XAML Designer** changes, too.

   :::image type="content" source="media/uwp-button-text-change-in-design-canvas.png" alt-text="Screenshot showing the Button control on the canvas of the XAML Designer with the label of the button changed to Hello World!":::

::: moniker-end

::: moniker range=">=vs-2022"

1. In the **XAML Editor**, change `Button Content` value from *Button* to *Hello World!*

   :::image type="content" source="media/vs-2022/uwp-change-button-text-in-xaml-code-window.png" alt-text="Screenshot showing the XAML code for the Button in the XAML editor with the value of the Content property changed to 'Hello World!'.":::

1. Notice that the button in the **XAML Designer** changes, too.

   :::image type="content" source="media/vs-2022/uwp-button-text-change-in-design-canvas.png" alt-text="Screenshot showing the Button control on the canvas of the XAML Designer with the label of the button changed to Hello World!":::

::: moniker-end

### Add an event handler

An *event handler* sounds complicated, but it's just another name for code that is called when an event happens. In this case, it adds an action to the **Hello World!** button.

::: moniker range="vs-2019"

1. Double-click the button control on the design canvas.

1. Edit the event handler code in *MainPage.xaml.cs*, the code-behind page.

   Here's where things get interesting. The default event handler looks like this:

   :::image type="content" source="media/uwp-button-click-code.png" alt-text="Screenshot showing the C# code for the default Button_Click event handler.":::

   Change it, so it looks like this:

   :::image type="content" source="media/uwp-add-hello-world-async-code.png" alt-text="Screenshot showing the C# code for the new async Button_Click event handler.":::

   Here's the code to copy and paste:

   ```csharp
   private async void Button_Click(object sender, RoutedEventArgs e)
   {
      MediaElement mediaElement = new MediaElement();
      var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
      Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
      mediaElement.SetSource(stream, stream.ContentType);
      mediaElement.Play();
   }
   ```

::: moniker-end

::: moniker range=">=vs-2022"

1. Double-click the button control on the design canvas.

1. Edit the event handler code in *MainPage.xaml.cs*, the code-behind page.

   Here's where things get interesting. The default event handler looks like this:

   :::image type="content" source="media/vs-2022/uwp-button-click-code.png" alt-text="Screenshot showing the C# code for the default Button_Click event handler.":::

   Change it, so it looks like this:

   :::image type="content" source="media/vs-2022/uwp-add-hello-world-async-code.png" alt-text="Screenshot showing the C# code for the new async Button_Click event handler.":::

   Here's the code to copy and paste:

   ```csharp
   private async void Button_Click(object sender, RoutedEventArgs e)
   {
      MediaElement mediaElement = new MediaElement();
      var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
      Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
      mediaElement.SetSource(stream, stream.ContentType);
      mediaElement.Play();
   }
   ```

::: moniker-end

#### What did we just do?

The code uses some Windows APIs to create a speech synthesis object and then gives it some text to say. For more information on using `SpeechSynthesis`, see  <xref:System.Speech.Synthesis>.

## Run the application

::: moniker range="vs-2019"
It's time to build, deploy, and launch the "Hello World" UWP app to see what it looks and sounds like. Here's how.

1. Use the Play button to start the application on the local machine. It has the text **Local Machine**.

   :::image type="content" source="media/uwp-start-or-debug.png" alt-text="Screenshot showing the drop-down box open next to the Play button with 'Local Machine' selected.":::

   Alternatively, you can choose **Debug** > **Start Debugging** from the menu bar or press **F5** to start your app.

1. View your app, which appears soon after a splash screen disappears. The app should look similar to this figure:

   :::image type="content" source="media/vs-2019/uwp-hello-world-app.png" alt-text="Screenshot showing the running UWP 'Hello World' application.":::

1. Select the **Hello World** button.

   Your Windows 10 or later device literally says, "Hello, World!"

1. To close the app, select the **Stop Debugging** button in the toolbar. Alternatively, choose **Debug** > **Stop debugging** from the menu bar, or press **Shift**+**F5**.

::: moniker-end

::: moniker range=">=vs-2022"

It's time to build, deploy, and launch the "Hello World" UWP app to see what it looks and sounds like. Here's how.

1. Use the Play button (it has the text **Local Machine**) to start the application on the local machine.

   :::image type="content" source="media/vs-2022/uwp-start-or-debug.png" alt-text="Screenshot showing the drop-down box open next to the Play button with 'Local Machine' selected.":::

   Alternatively, you can choose **Debug** > **Start Debugging** from the menu bar or press **F5** to start your app.

1. View your app, which appears soon after a splash screen disappears. The app should look similar to this image:

   :::image type="content" source="media/vs-2022/uwp-hello-world-app.png" alt-text="Screenshot showing the running UWP 'Hello World' application.":::

1. Select the **Hello World** button.

   Your Windows 10 or later device literally says, "Hello, World!"

1. To close the app, select the **Stop Debugging** button in the toolbar. Alternatively, choose **Debug** > **Stop debugging** from the menu bar, or press **Shift**+**F5**.

::: moniker-end

## Related content

- [UWP overview](/windows/uwp/get-started/universal-application-platform-guide)
- [Get UWP app samples](/windows/uwp/get-started/get-uwp-app-samples)

## Next step

Congratulations on completing this tutorial! We hope you learned some basics about UWP and the Visual Studio IDE. To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Create a user interface](../../xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio.md)
