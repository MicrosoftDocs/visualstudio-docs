---
title: "Create your first console app with Visual Basic"
description: "Learn how to create a simple Hello World console app in Visual Studio with Visual Basic, step-by-step."
ms.custom: "seodec18"
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: quickstart
ms.devlang: vb
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - vb
ms.workload:
  - "multiple"
---
# Quickstart: Create your first console app in Visual Studio with Visual Basic

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Visual Basic application that runs on the console.

::: moniker range="vs-2017"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2017) page to install it for free.

::: moniker-end

::: moniker range="vs-2019"

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019+rc) page to install it for free.

::: moniker-end

## Create a project

First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the project *HelloWorld*.

   ![Console App (.NET Core) project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-vb-dotnetcore-helloworld-console-app.png)

     If you don't see the **Console App (.NET Core)** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/vb-open-visual-studio-installer-hello-world.png)

     The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, and then choose **Modify**.

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)

## Create the application

After you select your Visual Basic project template and name your project, Visual Studio creates a simple "Hello World" application for you. It calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.

![View the default Hello World code from the template](../ide/media/vb-console-helloworld-template.png)

If you click the **HelloWorld** button in the IDE, you can run the program in Debug mode.

  ![Click the Hello World button to run the program in Debug mode](../ide/media/vb-console-hello-world-button.png)

When you do this, the console window is visible for only a moment before it closes. This happens because the `Main` method terminates after its single statement executes, and so the application ends.

### Add some code

Let's add some code to pause the application and then ask for user input.

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine%2A> method:

   ```vb
   Console.Write("Press any key to continue...")
   Console.ReadKey(true)
   ```

    This pauses the program until you press a key.

2. On the menu bar, select **Build** > **Build Solution**.

   This compiles your program into an intermediate language (IL) that's converted into binary code by a just-in-time (JIT) compiler.

## Run the application

1. Click the **HelloWorld** button on the toolbar.

   ![Click the Hello World button to run the program from the toolbar](../ide/media/vb-console-hello-world-button.png)

2. Press any key to close the console window.

   ![Console window showing Hello World and Press any key to continue](../ide/media/vb-console-hello-world-press-any-key.png)

## Next steps

Congratulations on completing this Quickstart! We hope you learned a little bit about Visual Basic and the Visual Studio IDE. To learn more, continue with the following tutorial.

> [!div class="nextstepaction"]
> [Get started with Visual Basic in Visual Studio](../get-started/visual-basic/tutorial-console.md)
