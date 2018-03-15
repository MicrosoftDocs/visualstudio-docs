---
title: "Quickstart: Create your first Universal Windows Application in Visual Studio with C# | Microsoft Docs"
ms.custom: ""
ms.date: "03/19/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "quickstart"
ms.devlang: "CSharp"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - CSharp
ms.workload:
  - "multiple"
---
# Quickstart: Create your first Universal Windows Application in Visual Studio with C#
In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Universal Windows Application (UWP) in C#.

If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project
First, you'll create a Universal Windows Application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the left pane of the **New Project** dialog box, expand **Visual C#**, and then choose **Windows Universal**. In the middle pane, choose **Blank App (Universal Windows)**. Then, name the project *HelloWorld*.

   ![Windows Universal project template in the New Project dialog box in the Visual Studio IDE](../ide/media/new-project-csharp-uwp-helloworld.png)

     If you don't see the **<name>** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box.

   ![Click the Open Visual Studio Installer link from the New Project dialog box](../ide/media/vb-open-visual-studio-installer-hello-world.png)

     The Visual Studio Installer launches. Choose the **Universal Windows Platform development** workload, and then choose **Modify**.

     ![Universal Windows Platform development workload in the Visual Studio Installer](../ide/media/uwp-dev-workload.png)

## Create the application
After you select your Universal Windows Application project template and name your project, Visual Studio creates a simple "Hello World" application for you. It calls the <xref:System.Console.WriteLine%2A> method to display the literal string "Hello World!" in the console window.

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

## Next Steps
Congratulations on completing this Quickstart! We hope you learned a little bit about Universal Windows Application and the Visual Studio IDE. To learn more, continue with the following tutorial.

> [!div class="nextstepaction"]
> [Getting started with Universal Windows Application in Visual Studio](tutorial-visual-basic-console.md)
