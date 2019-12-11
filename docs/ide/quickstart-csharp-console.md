---
title: "Use Visual Studio to create your first C# console app"
titleSuffix: ""
description: "Learn how to create a simple Hello World console app in Visual Studio with C#, step-by-step."
ms.custom: "seodec18"
ms.date: 03/23/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: quickstart
ms.devlang: vb
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "multiple"
---
# Quickstart: Use Visual Studio to create your first C# console app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple C# app that runs on the console.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.

::: moniker-end

## Create a project

First, you'll create a C# application project. The project type comes with all the template files you'll need, before you've even added anything!

::: moniker range="vs-2017"

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **C#**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *HelloWorld*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-dotnetcore-helloworld-console-app.png)

     If you don't see the **Console App (.NET Core)** project template, choose the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Choose the Open Visual Studio Installer link from the New Project dialog box](../ide/media/csharp-open-visual-studio-installer-hello-world.png)

     The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)

::: moniker-end

::: moniker range="vs-2019"

1. Open Visual Studio 2019.

1. On the start window, choose **Create a new project**.

   !['Create a new project' window](../get-started/media/vs-2019/create-new-project-dark-theme.png)

1. On the **Create a new project** window, enter or type *console* in the search box. Next, choose **C#** from the Language list, and then choose **Windows** from the Platform list. 

   After you apply the language and platform filters, choose the **Console App (.NET Core)** template, and then choose **Next**.

   ![Choose the C# template for the Console App (.NET Framework)](../get-started/csharp/media/vs-2019/csharp-create-new-project-search-console-net-core-filtered.png)

   > [!NOTE]
   > If you do not see the **Console App (.NET Core)** template, you can install it from the **Create a new project** window. In the **Not finding what you're looking for?** message, choose the **Install more tools and features** link.
   >
   > ![The 'Install more tools and features' link from the 'Not finding what you're looking for' message in the 'Create new project' window](../get-started/media/vs-2019/not-finding-what-looking-for.png) 
   > 
   > Then, in the Visual Studio Installer, choose the **.NET Core cross-platform development** workload.
   >
   > ![.NET Core cross-platform development workload in the Visual Studio Installer](./media/dot-net-core-xplat-dev-workload.png)
   >
   > After that, choose the **Modify** button in the Visual Studio Installer. You might be prompted to save your work; if so, do so. Next, choose **Continue** to install the workload. Then, return to step 2 in this "[Create a project](#create-a-project)" procedure.

1. In the **Configure your new project** window, type or enter *HelloWorld* in the **Project name** box. Then, choose **Create**.

   ![in the 'Configure your new project' window, name your project 'HelloWorld'](../get-started/csharp/media/vs-2019/csharp-name-your-helloworld-project.png)

   Visual Studio opens your new project.
   
::: moniker-end

## Create the application

::: moniker range="vs-2017"

After you select your C# project template and name your project, Visual Studio creates a simple "Hello World" application for you.

::: moniker-end

::: moniker range="vs-2019"

Visual Studio includes default "Hello World" code in your project.

::: moniker-end

(To do so, it calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.)

   ![View the default Hello World code from the template](../ide/media/csharp-console-helloworld-template.png)

If you press **F5**, you can run the program in Debug mode. However, the console window is visible only for a moment before it closes.

(This behavior happens because the `Main` method terminates after its single statement executes, and so the application ends.)

### Add some code

Let's add some code to pause the application so that the console window doesn't close until you press **ENTER**.

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine%2A> method:

   ```csharp
   Console.ReadLine();
   ```

1. Verify that it looks like this in the code editor:

   ![Add code to pause the Hello World app](../ide/media/csharp-console-helloworld-add-code.png)

## Run the application

1. Choose the **HelloWorld** button on the toolbar to run the application in Debug mode. (Or, you can press **F5**.)

   ![Choose the Hello World button to run the app from the toolbar](../ide/media/csharp-console-hello-world-button.png)

1. View your app in the console window.

   ![Console window showing Hello World!](../ide/media/csharp-console-hello-world.png)

### Close the application

1. Press **ENTER** to close the console window.

1. Close the **Output** pane in Visual Studio.

   ![Close the Output pane in Visual Studio](../ide/media/csharp-hello-world-close-output-pane.png)

1. Close Visual Studio.

## Next steps

Congratulations on completing this Quickstart! We hope you learned a little bit about C# and the Visual Studio IDE. To learn more, continue with the following tutorials.

> [!div class="nextstepaction"]
> [Get started with a C# console app in Visual Studio](../get-started/csharp/tutorial-console.md)
