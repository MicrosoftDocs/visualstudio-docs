---
title: "Getting started with Visual Basic in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "12/15/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "tutorial"
ms.devlang: "vb"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - vb
---

>[!IMPORTANT]
>This tutorial is not yet complete; it's here as a placeholder only.

# Getting started with Visual Basic in Visual Studio
In this tutorial for Visual Basic development using Visual Studio, you'll create a few different Visual Basic console apps, add code to them, explore some features of the Visual Studio integrated development environment (IDE), and run the apps.

If you haven't already installed Visual Studio, go to the [Visual Studio Downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project
First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!

1. Open Visual Studio 2017.

2. From the top menu bar, choose **File** > **New** > **Project...**.

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **.NET Core**. In the middle pane, choose **Console App (.NET Core)**. Then name the file *WhatsYourName*.  

     If you don't see the **Console App (.NET Core)** project template, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features...**. The Visual Studio Installer launches. Choose the **.NET Core cross-platform development** workload, then choose **Modify**.  

     ![.NET Core cross-platform development workload in the Visual Studio Installer](../ide/media/dot-net-core-xplat-dev-workload.png)  

## Create a "What's Your Name" application
We're going to create an app that prompts you for your name and then displays it along with the date and time. Here's how:

1. Enter the following Visual Basic code immediately after the opening bracket that follows the `Sub Main(args As String())` line and before the first closing bracket:



   This code replaces the existing "", and "" statements.



   This code displays "What is your name?" in the console window and waits until the user enters a string followed by the Enter key. It stores this string into a variable named `name`. It also retrieves the value of the <xref:System.DateTime.Now?displayProperty=nameWithType> property, which contains the current local time, and assigns it to a variable named `currentDate`. Finally, it uses an [interpolated string]() to display these values in the console window.

1. Compile the program by choosing **Build** > **Build Solution**.

1. Run the program in Debug mode in Visual Studio by selecting the green arrow on the toolbar, pressing F5, or choosing the **Debug** > **Start Debugging** menu item. Respond to the prompt by entering a name and pressing the Enter key.

   

1. Press any key to close the console window.

## Create a My Calculator application
After you select your Visual Basic project template and name your file, Visual Studio creates a simple "Hello World" application for you. It calls the [Console.WriteLine(System.String)](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.7.1#System_Console_WriteLine_System_String) method to display the literal string "Hello World!" in the console window.

![View the default Hello World code from the template](../ide/media/vb-console-helloworld-template.png)

We're going to replace the literal string "Hello World!" and then add some code to create our calculator app.

### Add some code


1. Replace the replace the literal string "Hello World!" with "My calculator".

   ```vb
  Console.Writeline("My Calculator")
   ```
   This code prompts the user to press any key, which pauses program until a key is pressed.



## Run the application
1. Click the **Start** button to run the application.

     ![Click Start to debug and run the app](../ide/media/vb-click-start-hello-world.png)




Congratulations on completing this tutorial!

## See also   
*
* [Learn more about Visual Basic IntelliSense](visual-basic-specific-intellisense.md)  
