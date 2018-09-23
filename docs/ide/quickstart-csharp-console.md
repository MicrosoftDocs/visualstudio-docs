---
title: "Quickstart: Create your first console app in Visual Studio with C#"
description: "Learn how to create a simple Hello World console app in Visual Studio with C#, step-by-step."
ms.custom: ""
ms.date: 09/21/2018
ms.prod: visual-studio-dev15
ms.technology: vs-acquisition
ms.prod: visual-studio-dev15
ms.topic: quickstart
ms.devlang: vb
author: TerryGLee
ms.author: tglee
manager: douge
dev_langs:
  - CSharp
ms.workload:
  - "multiple"
---
# Quickstart: Create your first console app in Visual Studio with C#

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple C# application that runs on the console.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017) page to install it for free.

## Create a project

First, you'll create a C# application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **C#**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *HelloWorld*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-dotnetcore-helloworld-console-app.png)

     If you don't see the **Console App (.NET Core)** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/csharp-open-visual-studio-installer-hello-world.png)

     The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)

## Create the application

After you select your C# project template and name your project, Visual Studio creates a simple "Hello World" application for you. It calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.

![View the default Hello World code from the template](../ide/media/csharp-console-helloworld-template.png)

If you click the **HelloWorld** button from the toolbar, you can run the program in Debug mode.

  ![Click the Hello World button to run the program in Debug mode](../ide/media/csharp-console-hello-world-button.png)

When you do this, the console window is visible only for a moment before it closes. This happens because the `Main` method terminates after its single statement executes, and so the application ends.

### Add some code

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine%2A> method:

   ```csharp
   Console.ReadLine();
   ```

1. Verify that it looks like this in the code editor:

   ![Add code to pause the Hello World app](../ide/media/csharp-console-helloworld-add-code.png)

   This code pauses the application in the console window until you press the **ENTER** key.

## Run the application

1. Click the **HelloWorld** button on the toolbar. (Or, you can press **F5**.)

   ![Click the Hello World button to run the program from the toolbar](../ide/media/csharp-console-hello-world-button.png)

1. View the "Hello World!" message, and then press **ENTER** to close the console window.

   ![Console window showing Hello World!](../ide/media/csharp-console-hello-world.png)

1. Close the **Output** pane in Visual Studio.

   ![Close the Output pane in Visual Studio](../ide/media/csharp-hello-world-close-output-pane.png)

1. Close Visual Studio.

## Next steps

Congratulations on completing this Quickstart! We hope you learned a little bit about C# and the Visual Studio IDE. To learn more, continue with the following tutorials.

> [!div class="nextstepaction"]
> [C# Tutorials](/dotnet/csharp/tutorials/)
