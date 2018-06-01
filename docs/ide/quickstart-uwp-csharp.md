---
title: "Quickstart: Create your first Universal Windows Platform application in Visual Studio with XAML and C# | Microsoft Docs"
ms.custom: ""
ms.date: "04/04/2018"
ms.prod: visual-studio-dev15
ms.technology:
  - "vs-acquisition"
ms.topic: "quickstart"
ms.devlang: "CSharp"
author: "TerryGLee"
ms.author: "tglee"
manager: douge
dev_langs:
  - CSharp
ms.workload:
  - "multiple"
---
# Quickstart: Create your first Universal Windows Platform application in Visual Studio with XAML and C&#35;

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a "Hello World" app that runs on any Windows 10 device. To do so, you'll use a Universal Windows Platform (UWP) project template, Extensible Application Markup Language (XAML), and the C# programming language.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project

First, create a Universal Windows Platform project. The project type comes with all the template files you need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the left pane of the **New Project** dialog box, expand **Visual C#**, and then choose **Windows Universal**. In the middle pane, choose **Blank App (Universal Windows)**. Then, name the project *HelloWorld* and choose **OK**.

   ![Windows Universal project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-uwp-helloworld.png)

   > [!NOTE]
   > If you don't see the **Blank App (Universal Windows)** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.<br><br>![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/vb-open-visual-studio-installer-hello-world.png)<br><br>The Visual Studio Installer launches. Choose the **Universal Windows Platform development** workload, and then choose **Modify**.<br><br>![Universal Windows Platform development workload in the Visual Studio Installer](../ide/media/uwp-dev-workload.png)

4. When the **New Universal Windows Platform Project** dialog box appears, choose **OK**.

   ![Accept the default Target version and Minimum version settings in the New Universal Windows Platform Project dialog box](../ide/media/new-uwp-project-target-minver-dialog.png)

  > [!NOTE]
  > If this is the first time you have used Visual Studio to create a UWP app, a **Settings** dialog box might appear. Choose **Developer mode**, and then choose **Yes**.<br><br>
 ![Enable the Developer Mode in the UWP Settings dialog box](../ide/media/enable-developer-mode.png)<br><br>Visual Studio installs an additional Developer Mode package for you. When the package installation is complete, close the **Settings** dialog box.

## Create the application

It's time to start developing. You'll add a button control, add an action to the button, and then start the "Hello World" app to see what it looks like.

### Add a button to the Design canvas

1. In the **Solution Explorer**, double-click *MainPage.xaml* to open a split view.

  ![Open MainPage.xaml from the Solution Explorer ](../ide/media/uwp-solution-explorer-MainPage-xaml.png)

  There are two panes: The **XAML Designer**, which includes a design canvas, and the **XAML Editor**, where you can add or change code.    

  ![The XAML Designer pane in the XAML editor](../ide/media/uwp-xaml-editor.png)

2. Choose **Toolbox** to open the Toolbox fly-out window.

  ![Click Toolbox to open the Toolbox fly-out window](../ide/media/uwp-toolbox.png)

  (If you don't see the **Toolbox** option, you can open it from the menu bar. To do so, choose **View** > **Toolbar**. Or, press **Ctrl**+**Alt**+**X**.)

3. Click the **Pin** icon to dock the Toolbox window.

  ![Click the Pin icon to dock the Toolbox window](../ide/media/uwp-toolbox-autohide.png)

4. Click the **Button** control and then drag it onto the design canvas.

   ![Click the Button control and drag it onto the Design canvas](../ide/media/uwp-toolbox-add-button-control.png)

  If you look at the code in the **XAML Editor**, you'll see that the Button has been added there, too:

  ![Click the Button control and drag it onto the Design canvas](../ide/media/uwp-xaml-control-code-window.png)

### Add a label to the button

1. In the **XAML Editor**, change Button Content value from "Button" to "Hello World!"

   ![Change the Button content value to Hello World](../ide/media/uwp-change-button-text-in-xaml-code-window.png)

2. Notice that the button in the **XAML Designer** changes, too.

   ![The button changes to Hello World on the design canvas](../ide/media/uwp-button-text-change-in-design-canvas.png)

### Add an event handler

An "event handler" sounds complicated, but it's just another name for code that is called when an event happens. In this case, it adds an action to the "Hello World!" button.

1. Double-click the button control on the design canvas.

2. Edit the event handler code in *MainPage.xaml.cs*, the code-behind page.

 This is where things get interesting. The default event handler looks like this:

   ![The default Button_Click event handler ](../ide/media/uwp-button-click-code.png)

 Let's change it, so it looks like this:

    ![The new async Button_Click event handler ](../ide/media/uwp-add-hello-world-async-code.png)

  Here's the code to copy and paste:

  ```C#
  private async void Button_Click(object sender, RoutedEventArgs e)
         {
             MediaElement mediaElement = new MediaElement();
             var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
             Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello, World!");
             mediaElement.SetSource(stream, stream.ContentType);
             mediaElement.Play();
         }
  ```

#### What did we just do?

The code uses some Windows APIs to create a speech synthesis object and then gives it some text to say. (For more information on using `SpeechSynthesis`, see  <xref:System.Speech.Synthesis>.)

## Run the application

It's time to build, deploy, and launch the "Hello World" UWP app to see what it looks and sounds like. Here's how.

1. Choose **Local Machine** to start the application.

   ![Click Local Machine to start and debug your UWP app](../ide/media/uwp-start-or-debug.png "Click Local Machine to start and debug your UWP app")

   (Alternatively, you can choose **Debug** > **Start Debugging** from the menu bar or press **F5** to start your app.)

2. View your app, which appears soon after a splash screen disappears. The app should look similar to this:

   ![A UWP "Hello World" app](../ide/media/uwp-hello-world-app.png)

3. Click the **Hello World** button.

 Your Windows 10 device will literally say, "Hello, World!"

4. To close the app, click the **Stop Debugging** button in the toolbar. (Alternatively, choose **Debug** > **Stop debugging** from the menu bar, or press **Shift**+**F5**.)

## Next steps

Congratulations on completing this Quickstart! We hope you learned some basics about UWP and the Visual Studio IDE. To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Create a user interface](/windows/uwp/design/basics/xaml-basics-ui)
