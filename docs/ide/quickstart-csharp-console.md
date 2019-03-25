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

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2017) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019+rc) page to install it for free.

::: moniker-end

## Create a project

First, you'll create a C# application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **C#**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *HelloWorld*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-dotnetcore-helloworld-console-app.png)

     If you don't see the **Console App (.NET Core)** project template, choose the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Choose the Open Visual Studio Installer link from the New Project dialog box](../ide/media/csharp-open-visual-studio-installer-hello-world.png)

     The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)

## Create the application

After you select your C# project template and name your project, Visual Studio creates a simple "Hello World" application for you.

(To do this, it calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.)

   ![View the default Hello World code from the template](../ide/media/csharp-console-helloworld-template.png)

If you press **F5**, you can run the program in Debug mode. However, the console window is visible only for a moment before it closes.

(This happens because the `Main` method terminates after its single statement executes, and so the application ends.)

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
