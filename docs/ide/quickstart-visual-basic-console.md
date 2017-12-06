---
title: "Quickstart: Create a console app in Visual Studio with Visual Basic | Microsoft Docs"
ms.custom: ""
ms.date: "12/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "quickstart"
ms.devlang: "vb"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - vb
---
# Quickstart: Create a console app in Visual Studio with Visual Basic
In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Visual Basic application that runs on the console.

If you haven't already installed Visual Studio, go to the [Visual Studio Downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project
First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the file `HelloWorld`.  

     If you don't see the **Console App (.NET Core)** project template, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features...**. The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, then choose **Modify**.  

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)  

## Create the application
After you select your Visual Basic project template and name your file, Visual Studio creates a simple "Hello World" application for you. It calls the <xref:System.Console.WriteLine(System.String)?displayProperty=nameWithType> method to display the literal string "Hello World!" in the console window.

     ![View the default Hello World code from the template](../ide/media/vb-console-hello-world-code-from-template.png)

If you click the **HelloWorld** button, you can run the program in Debug mode.

     ![Click the Hello World button to run the program in Debug mode](../ide/media/vb-console-hello-world-button.png)

When you do this, the console window is visible for only a brief time before it closes. This happens because the `Main` method terminates and the application ends after the single statement in the `Main` method executes.

### Add some code
Let's add some code to pause the program in the console.

1. Add the following code immediately after the call to the <xref:System.Console.WriteLine(System.String)?displayProperty=nameWithType> method:

   ```vb
   Console.Write("Press any key to continue...")
   Console.ReadKey(true)
   ```
   This code prompts the user to press any key, which pauses program until a key is pressed.

2.

## Run the application
1. Click the **Start** button to run the application.

     ![Click Start to debug and run the app](../ide/media/vb-click-start-hello-world.png)

   Several things will happen. In the Visual Studio IDE, the Diagnostics Tools window will open, and an Output window will open, too. But outside of the IDE, a console window will appear ...

2.


Congratulations on completing this quickstart! We hope you learned a little bit about Visual Basic and the Visual Studio IDE. If you'd like to delve deeper, please continue with a tutorial in the **Tutorials** section of the table of contents.  

## See also   
* [Enhancing the Hello World application](https://docs.microsoft.com/en-us/dotnet/core/tutorials/vb-with-visual-studio#enhancing-the-hello-world-application)
* [Visual Basic IntelliSense](visual-basic-specific-intellisense.md)  
