---
title: "Tutorial: Create Windows Forms app (Visual Basic)"
description: Create a Windows Forms app in Visual Studio with Visual Basic, add a button to the form, add a label and code, and run the application.
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
ms.topic: tutorial
dev_langs:
  - VB
ms.date: 01/24/2025
ms.custom: vs-acquisition
#customer intent: As a developer, I want to create a simple Visual Basic program to understand how Visual Studio handles Forms.
---
# Tutorial: Create a WinForms app with Visual Basic

In this tutorial, you create a Visual Basic application that has a Windows Forms user interface.
The Visual Studio integrated development environment (IDE) includes all the tools you need to create a Windows Forms app.

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Create a project
> - Add a button to the form
> - Add a label and code
> - Run the application

## Prerequisites

::: moniker range="vs-2019"
- You need Visual Studio to complete this tutorial. Visit [Visual Studio downloads](https://visualstudio.microsoft.com/vs/) for a free version.
- The **.NET desktop development** workload. To verify or install this workload in Visual Studio, select **Tools** > **Get Tools and Features**. For more information, see [Change workloads or individual components](../install/modify-visual-studio.md#change-workloads-or-individual-components).
::: moniker-end
::: moniker range=">=vs-2022"
- You need Visual Studio to complete this tutorial. Visit [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) for a free version.
- The **.NET desktop development** workload. To verify or install this workload in Visual Studio, select **Tools** > **Get Tools and Features**. For more information, see [Change workloads or individual components](../install/modify-visual-studio.md#change-workloads-or-individual-components).
::: moniker-end

## Create a project

Create a Visual Basic application project.
The project type comes with all the template files that you need.

::: moniker range="vs-2019"
1. Open Visual Studio, then select **Create a new project** on the start window.

   :::image type="content" source="../get-started/media/vs-2019/create-new-project-dark-theme.png" alt-text="Screenshot showing the Visual Studio 2019 start window with Create a new project selected.":::

1. On the **Create a new project** window, select the **Windows Forms App (.NET Framework)** template for Visual Basic.

   You can refine your search to quickly get to the template you want.
   For example, enter *Windows Forms App* in the search box.
   Next, select **Visual Basic** from the languages list, and then **Windows** from the platform list.  

   :::image type="content" source="../get-started/visual-basic/media/vs-2019/vb-create-new-project-search-winforms-filtered.png" alt-text="Screenshot showing the Create a new project window with Windows Forms App (.NET Framework) selected." lightbox="../get-started/visual-basic/media/vs-2019/vb-create-new-project-search-winforms-filtered.png":::

1. In the **Configure your new project** window, enter *HelloWorld* as the **Project name**. Then, select **Create**.

   :::image type="content" source="../get-started/visual-basic/media/vs-2019/vb-name-your-winform-project-helloworld.png" alt-text="Screenshot shows the Configure your new project window with the name HelloWorld entered.":::

   Visual Studio opens your new project.

::: moniker-end

::: moniker range=">=vs-2022"
1. Open Visual Studio, then select **Create a new project** on the start window.

   :::image type="content" source="../get-started/media/vs-2022/create-new-project.png" alt-text="Screenshot that shows the Visual Studio 2022 start window with Create a new project selected.":::

1. On the **Create a new project** window, select the **Windows Forms App (.NET Framework)** template for Visual Basic.

   You can refine your search to quickly get to the template you want.
   For example, enter *Windows Forms App* in the search box.
   Next, select **Visual Basic** from the language list, and then **Windows** from the platform list.  

   :::image type="content" source="../get-started/visual-basic/media/vs-2022/vb-create-new-project-search-winforms-filtered.png" alt-text="Screenshot that shows the Create a new project window with Windows Forms App (.NET Framework) selected." lightbox="../get-started/visual-basic/media/vs-2022/vb-create-new-project-search-winforms-filtered.png":::

1. In the **Configure your new project** window, enter *HelloWorld* as the **Project name**. Then, select **Create**.

   :::image type="content" source="../get-started/visual-basic/media/vs-2022/vb-name-your-winform-project-helloworld.png" alt-text="Screenshot shows the Configure your new project window with the name HelloWorld entered.":::

   Visual Studio opens your new project.

::: moniker-end

## Add a button to the form

After you select your Visual Basic project template and name your file, Visual Studio opens a form for you.
A form is a Windows user interface.
You create a *Hello World* application by adding controls to the form.

1. On the left side of the Visual Studio IDE, select the **Toolbox** tab.
   If you don't see it, select **View** > **Toolbox** from the menu bar or **Ctrl**+**Alt**+**X**.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/toolbox-tab.png" alt-text="Screenshot shows the Toolbox tab that opens Toolbox window.":::

   If you want, select the **Pin** icon to dock the **Toolbox** window.

1. In the **Common Controls** section, select the **Button** control and then drag it onto the form.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/toolbox-button-form.png" alt-text="Screenshot shows the Button control added to the form.":::

1. In the **Appearance** section of the **Properties** window, for **Text**, type *Click this*, and then select **Enter**.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/button-text-property.png" alt-text="Screenshot shows the Text property with the value Click this.":::

   If you don't see the **Properties** window, you can open it from the menu bar. Select **View** > **Properties Window** or **F4**.

1. In the **Design** section of the **Properties** window, change the name from **Button1** to *btnClickThis*, and then select **Enter**.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/button-name-property.png" alt-text="Screenshot shows the Name property with a value of btnClickThis.":::

   > [!NOTE]
   > If you've alphabetized the list in the **Properties** window, **Button1** appears in the **(DataBindings)** section, instead.

## Add a label and code

After you add a button control to create an action, add a label control to receive the text.

1. Select the **Label** control in the **Toolbox** window, and then drag it onto the form.
   Place it beneath the **Click this** button.

1. In either the **Design** section or the **(DataBindings)** section of the **Properties** window, change the name **Label1** to *lblHelloWorld*, and then press **Enter**.

1. In the **Form1.vb &#91;Design&#93;** window, double-click the **Click this** button to open the **Form1.vb** window.

   Another option is to expand **Form1.vb** in **Solution Explorer**. Then select **Form1**.

1. In the **Form1.vb** window, between the `Private Sub` and `End Sub` lines, enter *lblHelloWorld.Text = "Hello World!"* as shown in the following screenshot:

     :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/click-handle-code-visual-basic.png" alt-text="Screenshot shows a class in the Form1.vs tab where you can add Visual Basic code.":::

## Run the application

Your application is ready to build and run.

1. Select **Start** to run the application.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/visual-studio-start-debug.png" alt-text="Screenshot shows the Start button that runs your app.":::

   Several things happen.
   In the Visual Studio IDE, the **Diagnostics Tools** window opens, and an **Output** window opens.
   Outside of the IDE, a **Form1** dialog box appears.
   It includes your **Click this** button and text that says **Label1**.

1. Select the **Click this** button in the **Form1** dialog box.

   :::image type="content" source="media/create-a-visual-basic-winform-in-visual-studio/visual-studio-dialog-hello-world.png" alt-text="Screenshot shows dialog box titled Form 1 that displays the text Hello World!":::

   The **Label1** text changes to **Hello World!**.

1. Close the **Form1** dialog box to stop running the app.

## Related content

To learn more about Windows Forms, continue with the following tutorial:

> [!div class="nextstepaction"]
> [Tutorial: Create a picture viewer](/visualstudio/get-started/csharp/tutorial-windows-forms-picture-viewer-layout)

Or try these other tutorials:

- [Visual Basic tutorials](../get-started/visual-basic/index.yml)
- [C# tutorials](../get-started/csharp/index.yml)
- [C++ tutorial](/cpp/get-started/tutorial-console-cpp)
