---
title: "Create a Windows Forms app with C#"
description: Create a Windows Forms app in Visual Studio with C#, add button controls to the form, and run the code to test your application.
ms.custom: vs-acquisition
ms.date: 02/26/2025
ms.topic: tutorial
ms.devlang: csharp
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
dev_langs:
  - CSharp
#customer intent: As a developer, I want to create a simple C# program to understand how Visual Studio handles Forms.
---
# Tutorial: Create a Windows Forms app in Visual Studio with C\#

In this tutorial, you create a simple C# application that has a Windows-based user interface (UI). The app has a button that changes the text of a label. This simple app has all the components used for more complicated Windows Forms programs.

> [!div class="checklist"]
> - Create a C# project in Visual Studio
> - Create an application
> - Run your application

## Prerequisites

::: moniker range="=vs-2019"

- If you don't have Visual Studio, go to [Visual Studio downloads](https://visualstudio.microsoft.com/vs/) to install it for free.
- The **.NET desktop development** workload. To verify or install this workload in Visual Studio, select **Tools** > **Get Tools and Features**. For more information, see [Change workloads or individual components](../install/modify-visual-studio.md#change-workloads-or-individual-components).

::: moniker-end

::: moniker range=">=vs-2022"

- If you don't have Visual Studio, go to [Visual Studio 2022 downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-create-csharp-winform-app-page-cta) to install it for free.
- The **.NET desktop development** workload. To verify or install this workload in Visual Studio, select **Tools** > **Get Tools and Features**. For more information, see [Change workloads or individual components](../install/modify-visual-studio.md#change-workloads-or-individual-components).

::: moniker-end

## Create a project

First, create a C# application project. The project type comes with all the template files you need to create your application.

::: moniker range="=vs-2019"

1. Open Visual Studio, and select **Create a new project** in the start window.

   :::image type="content" source="../get-started/media/vs-2019/create-new-project-dark-theme.png" alt-text="Screenshot showing the Create a new project window.":::

1. In **Create a new project**, select the **Windows Forms App (.NET Framework)** template for C#.

   :::image type="content" source="../get-started/csharp/media/vs-2019/csharp-create-new-winforms-project-nonfiltered.png" alt-text="Screenshot showing the Windows Forms App (.NET Framework) for C#." lightbox="../get-started/csharp/media/vs-2019/csharp-create-new-winforms-project-nonfiltered.png":::

   You can refine your search to quickly get to the template you want. For example, enter *Windows Forms App* in the search box. Next, choose **C#** from the language list, and then choose **Windows** from the platform list.  

1. In **Configure your new project**, for **Project name**, enter *HelloWorld* and select **Create**.

   :::image type="content" source="../get-started/csharp/media/vs-2019/csharp-name-your-winform-project-helloworld.png" alt-text="Screenshot showing the Configure your new project window, where you name your project HelloWorld.":::

   Visual Studio opens your new project.

::: moniker-end

::: moniker range=">=vs-2022"

1. Open Visual Studio, and select **Create a new project** in the start window.

    :::image type="content" source="media/vs-2022/create-new-project-dark-theme.png" alt-text="Screenshot that shows the Create a new project option.":::

1. In **Create a new project**, select the **Windows Forms App (.NET Framework)** template for C#.

   You can refine your search to quickly get to the template you want. For example, type *Windows Forms App* in the search box. Next, select **C#** from the language list, and then select **Windows** from the platform list.

    :::image type="content" source="media/vs-2022/csharp-winform-create-a-new-project.png" alt-text="Screenshot that shows the C# template for the Windows Forms App (.NET Framework)." lightbox="media/vs-2022/csharp-winform-create-a-new-project.png":::

1. In the **Configure your new project** window, in **Project name**, enter *HelloWorld*, and select **Create**.

    :::image type="content" source="media/vs-2022/csharp-winform-configure-new-project.png" alt-text="Screenshot that shows the Configure your new project window for your project named HelloWorld.":::

   Visual Studio opens your new project.

::: moniker-end

## Create the application

::: moniker range="=vs-2019"

After you select your C# project template and name your project, Visual Studio opens a form for you. A form is a Windows user interface. Create a *Hello World* application by adding controls to the form. Then [run the app](#run-the-application).

### Add a button to the form

1. Select **Toolbox** to open the **Toolbox** flyout window.

   :::image type="content" source="../ide/media/csharp-toolbox-toolwindow.png" alt-text="Screenshot showing the Toolbox option to open the Toolbox window.":::

   If you don't see the **Toolbox** option, you can open it from the menu bar. Select **View** > **Toolbox** or **Ctrl**+**Alt**+**X**.

1. Select the **Pin** icon to dock the **Toolbox** window.

   :::image type="content" source="../ide/media/vb-pin-the-toolbox-window.png" alt-text="Screenshot showing the Pin icon that pins the Toolbox window to the IDE.":::

1. Select the **Button** control and then drag it onto the form.

   :::image type="content" source="../ide/media/csharp-add-button-form1.png" alt-text="Screenshot showing the form with a button.":::

1. In the **Properties** window, locate **Text**, change the name from **Button1** to `Click this`, and then select **Enter**.

   :::image type="content" source="../ide/media/vb-button-control-text.png" alt-text="Screenshot showing where to change text for the button on the form.":::

   If you don't see the **Properties** window, you can open it from the menu bar. Select **View** > **Properties Window** or **F4**.

1. In the **Design** section of the **Properties** window, change the name from **Button1** to `btnClickThis`, and then select **Enter**.

   :::image type="content" source="../ide/media/vb-button-control-function.png" alt-text="Screenshot showing the new name for the button.":::

   You can [dock or anchor](/dotnet/desktop/winforms/controls/how-to-dock-and-anchor.md) the controls on your form to help with automatic placement and sizing, when the form changes size.

   > [!NOTE]
   > If you alphabetized the list in the **Properties** window, **Button1** appears in the **(DataBindings)** section, instead.

### Add a label to the form

After you add a button control to create an action, add a label control to receive the text.

1. Select the **Label** control from the **Toolbox**. Then drag it onto the form and drop it beneath the **Click this** button.

1. In either the **Design** section or the **(DataBindings)** section of the **Properties** window, change the name of **Label1** to `lblHelloWorld`. Then select **Enter**.

### Add code to the form

1. In the **Form1.cs &#91;Design&#93;** window, double-click the **Click this** button to open the **Form1.cs** window.

   Alternatively, you can expand **Form1.cs** in **Solution Explorer**, and then choose **View Code** or select **F7** from the shortcut menu on **Form1.cs**.

1. In the **Form1.cs** window, after the **private void** line, type or enter `lblHelloWorld.Text = "Hello World!";` as shown in the following screenshot.

   :::image type="content" source="../get-started/csharp/media/csharp-winforms-add-code.png" alt-text="Screenshot showing the code window where you add code to the form.":::

::: moniker-end

::: moniker range=">=vs-2022"

After you select your C# project template and name your project, Visual Studio opens a form for you. A form is a Windows user interface. Create a *Hello World* application by adding controls to the form. Then [run the app](#run-the-application).

### Add a button to the form

1. Select **Toolbox** to open the **Toolbox** flyout window.

     :::image type="content" source="media/vs-2022/csharp-winform-hello-world-project-toolbox.png" alt-text="Screenshot that shows how to select the Toolbox to open the Toolbox window.":::

     If you don't see the **Toolbox** option, you can open it from the menu bar. Select **View** > **Toolbox** or **Ctrl**+**Alt**+**X**.

1. Expand **Common Controls** and select the **Pin** icon to dock the **Toolbox** window.

     :::image type="content" source="media/vs-2022/csharp-winform-toolbox-flyout-pin.png" alt-text="Screenshot that shows the Pin icon to pin the Toolbox window to the IDE.":::

1. Select the **Button** control and then drag it onto the form.

     :::image type="content" source="media/vs-2022/csharp-winform-add-button-on-form.png" alt-text="Screenshot that shows the form with a button just added.":::

1. In the **Properties** window, locate **Text**. Change the name from **button1** to `Click this`, and then select **Enter**.

     :::image type="content" source="media/vs-2022/csharp-winform-button-properties-text.png" alt-text="Screenshot that shows the Text field in the Properties window.":::

     If you don't see the **Properties** window, you can open it from the menu bar. Select **View** > **Properties Window** or **F4**.

1. In the **Design** section of the **Properties** window, change the name from **button1** to `btnClickThis`, and then select **Enter**.

     :::image type="content" source="media/vs-2022/csharp-winform-button-properties-design-name.png" alt-text="Screenshot that shows the new name for the button.":::

   > [!NOTE]
   > If you alphabetized the list in the **Properties** window, **button1** appears in the **(DataBindings)** section, instead.

### Add a label to the form

After you add a button control to create an action, add a label control to receive the text.

1. Select the **Label** control from the **Toolbox**. Then drag it onto the form and drop it beneath the **Click this** button.

1. In either the **Design** section or the **(DataBindings)** section of the **Properties** window, change the name of **label1** to `lblHelloWorld`. Then select **Enter**.

### Add code to the form

1. In the **Form1.cs &#91;Design&#93;** window, double-click the **Click this** button to open the **Form1.cs** window.

   Alternatively, you can expand **Form1.cs** in **Solution Explorer**, and then choose **Form1**.

1. In the **Form1.cs** window, after the **private void** line, type or enter `lblHelloWorld.Text = "Hello World!";` as shown in the following screenshot.

   :::image type="content" source="media/vs-2022/csharp-winform-button-click-code.png" alt-text="Screenshot that shows where to add code to the form.":::

::: moniker-end

## Run the application

::: moniker range="=vs-2019"
1. Select the **Start** button to run the application.

   :::image type="content" source="../ide/media/vb-click-start-hello-world.png" alt-text="Screenshot showing the Start button to debug and run the app.":::

   Several things happen. In the Visual Studio IDE, the **Diagnostics Tools** window opens, and an **Output** window opens, too. But outside of the IDE, a **Form1** dialog box appears. It includes your **Click this** button and text that says **Label1**.

1. Choose the **Click this** button in the **Form1** dialog box. Notice that the **Label1** text changes to **Hello World!**.

    :::image type="content" source="../ide/media/vb-form1-dialog-hello-world.png" alt-text="Screenshot showing your app, which is a Form1 dialog box that includes Label1 text.":::

1. Close the **Form1** dialog box to stop running the app.
::: moniker-end

::: moniker range=">=vs-2022"
1. Select the **Start** button to run the application.

   :::image type="content" source="media/vs-2022/csharp-winform-visual-studio-start-run-program.png" alt-text="Screenshot that shows the Start button to debug and run the app.":::

   Several things happen. In the Visual Studio IDE, the **Diagnostics Tools** window opens, and an **Output** window opens, too. But outside of the IDE, a **Form1** dialog box appears. It includes your **Click this** button and text that says **label1**.

1. Select the **Click this** button in the **Form1** dialog box. Notice that the **label1** text changes to **Hello World!**.

   :::image type="content" source="media/vs-2022/csharp-winform-form.png" alt-text="Screenshot that shows the Form1 dialog box that includes the button and a label.":::

1. Close the **Form1** dialog box to stop running the app.

::: moniker-end

## Related content

Congratulations on completing this tutorial. To learn more, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Tutorial: Create a picture viewer](tutorial-windows-forms-picture-viewer-layout.md)

Or try these other tutorials:

- [C# tutorials](../get-started/csharp/index.yml)
- [Visual Basic tutorials](../get-started/visual-basic/index.yml)
- [C++ tutorial](/cpp/get-started/tutorial-console-cpp)
