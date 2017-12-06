---
title: "Getting Started with C++ in Visual Studio | Microsoft Docs"
ms.custom: "mvc"
ms.date: "12/04/2017"
ms.technology: "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
ms.assetid: 99c73344-86ba-4b08-9e15-f6111cc04185
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
---
# Get Started with C++ in Visual Studio

Read this topic and follow along in Visual Studio to become familiar with many of the tools and dialog boxes that you can use when you develop applications in C++ with Visual Studio. You'll create a simple "Hello, World"-style console application while you learn more about working in the integrated development environment (IDE).

## Prerequisites

This topic assumes you're familiar enough with Windows apps to follow our directions to open windows and menus and fill in dialog boxes. You don't need to be familiar with C++ in particular, but we do assume you're familiar with some programming concepts. Our documentation doesn't teach you how to program in C++, so you'll need to find another source for that information. A good resource is the [Get Started](https://isocpp.org/get-started) page on the ISO C++ website.

To make the best use of this topic, you'll need a copy of Visual Studio 2017 version 15.3 or later, with the **Desktop development with C++** workload installed. For a fast guide to installation, use the C++ Tutorial [Step 0 - Install C++ support in Visual Studio](/cpp/build/vscpp-step-0-installation).

## Create a simple application

If it's not running yet, start Visual Studio.

![IDE with Visual C&#43;&#43; settings applied](../ide/media/get-started-cpp-ide-layout.png "IDE with Visual C&#43;&#43; settings applied")

After you open Visual Studio, you can see the three basic parts of the IDE: tool windows, menus and toolbars, and the main window space. Tool windows are docked on the left and right sides of the app window, with the **Quick Launch** box, the menu bar, and the standard toolbar at the top. The center of the application window contains the **Start Page**. When you open a solution or project, editors and designers appear in this space. When you develop an application, you'll spend most of your time in this central area.

Visual Studio uses *projects* to organize the code for an app, and *solutions* to organize your projects. A project contains all the options, configurations, and rules used to build your apps, and manages the relationship between all the project's files and any external files. To create your app, first, you'll create a new project and solution.

### To create a console app

1. On the menu bar, choose **File > New > Project** to open the **New Project** dialog box.

   ![On the menu bar, choose File, New, Project](../ide/media/get-started-cpp-file-new-project-menu.png "On the menu bar, choose File, New, Project")

1. In the **New Project** dialog, select **Installed > Visual C++** if it isn't selected already. Select the **Windows Console Application** template. In the **Name** edit box, enter *HelloApp*. Choose the **OK** button to create your app project and solution.

   ![Use the New Project dialog to create your app project](../ide/media/get-started-cpp-new-project-dialog.png "Use the New Project dialog to create your app project")

   Your dialog box may have different choices, depending on what you've installed. If you don't see Visual C++ project templates, you need to run the Visual Studio installer again and install the **Desktop development with C++** workload. Choose the **Open Visual Studio Installer** link on the dialog to launch the installer directly.

The HelloApp project and solution, with the basic files for a Win32 console app, are created and automatically loaded into **Solution Explorer**. The HelloApp.cpp file is opened in the code editor. These items appear in **Solution Explorer**:

![Files for the solution in Solution Explorer](../ide/media/get-started-cpp-solution-explorer.png "Files for the solution in Solution Explorer")

## Add code to the app

Next, you'll add code to display the word "Hello" in the console window.

### To edit code in the editor

1. In the HelloApp.cpp file, enter a blank line before the line `return 0;` and then enter this code:

   ```cpp
   cout << "Hello\n";
   ```

   A red squiggly line appears under `cout`. An error message appears if you hover the pointer over it.

   ![Error text for cout](../ide/media/get-started-cpp-intellisense-error.png "Error text for cout")

   The error message also appears in the **Error List** window. You can display this window by choosing **View > Error List** on the menu bar.

   ![Error in Error List window](../ide/media/get-started-cpp-error-list.png "Error in Error List window")

   [cout](/cpp/standard-library/iostream) is included in the \<iostream> header file.

1. To include the iostream header, enter this code after `#include "stdafx.h"`:

   ```cpp
   #include <iostream>
   using namespace std;
   ```

   You probably noticed that a box appeared as you entered code, providing suggestions for the characters that you entered. This box is part of C++ IntelliSense, which provides coding prompts, including listing class or interface members and parameter information. You can also use code snippets, which are pre-defined blocks of code. For more information, see [Using IntelliSense](../ide/using-intellisense.md) and [Code Snippets](../ide/code-snippets.md).

   ![The fixed code in the editor](../ide/media/get-started-cpp-cout-fix.png "The fixed code in the editor")

   The red squiggly line under `cout` disappears when you fix the error.

1. Press **Ctrl+S** to save the changes to the file.

## Build the app

It's easy to build your code. On the menu bar, choose **Build > Build Solution**. Visual Studio builds the HelloApp solution, and reports progress in the **Output** window.

   ![Build the HelloApp solution](../ide/media/get-started-cpp-build-solution.gif "Build the HelloApp solution")

## Debug and test the app

You can debug HelloApp to see whether the word "Hello" appears in the console window.

### To debug the app

1. To start the debugger, choose **Debug > Start Debugging** on the menu bar.

   ![Start Debugging command on the Debug menu](../ide/media/get-started-cpp-start-debugging-menu.png "Start Debugging command on the Debug menu")

   The debugger starts and runs the code. The console window (a separate window that looks like a command prompt) appears for a few seconds but closes quickly when the debugger stops running. To see the text, you need to set a breakpoint to stop program execution.

### To add a breakpoint

1. In the editor, put the cursor on the line `return 0;`. On the menu bar, choose **Debug > Toggle Breakpoint**. You can also click in the left margin to set a breakpoint.

     ![Toggle Breakpoint command on the Debug menu](../ide/media/get-started-cpp-toggle-breakpoint-menu.png "Toggle Breakpoint command on the Debug menu")

     A red circle appears next to the line of code in the far left margin of the editor window.

     ![Breakpoint indicated in window margin](../ide/media/get-started-cpp-breakpoint-set.png "Breakpoint indicated in window margin")

1. Press **F5** to start debugging.

   The debugger starts, and a console window appears showing the word **Hello**.

   ![Hello text in the console window](../ide/media/get-started-cpp-helloapp-window.png "Hello text in the console window")

1. Press **Shift+F5** to stop debugging.

For more information about console project debugging, see [Console Projects](../debugger/debugging-preparation-console-projects.md).

## Build a release version of the app

Now that you've verified that everything works, you can prepare a release build of the application. Release builds leave out the debugging information, and use compiler optimization options to create smaller, faster code.

### To clean the solution files and build a release version

1. On the menu bar, choose **Build > Clean Solution** to delete intermediate files and output files that were created during previous builds.

   ![The Clean Solution command on the Build menu](../ide/media/get-started-cpp-clean-solution-menu.png "ExploreIDE-CleanSolution")

1. To change the solution configuration for HelloApp from **Debug** to **Release**, in the toolbar, select the dropdown on the Solution Configurations control and then choose **Release**.

   ![Build a release version of the application](../ide/media/get-started-cpp-set-release-configuration.png "C++IDE_ChangingBuildtoRelease")

1. Build the solution. On the menu bar, choose **Build > Build Solution**.

When this build completes, you've created an app that you can copy and run in any command prompt window. It may not do much, but it's the gateway to greater things.

Congratulations on completing this quick start! If you want to explore more examples, see [Visual Studio Samples](../ide/visual-studio-samples.md).

## See also

[Using the Visual Studio IDE for C++ Desktop Development](/cpp/ide/using-the-visual-studio-ide-for-cpp-desktop-development)  
[Walkthrough: Create a Simple Application with Visual C# or Visual Basic](../ide/walkthrough-create-a-simple-application-with-visual-csharp-or-visual-basic.md)  
[Productivity Tips for Visual Studio](../ide/productivity-tips-for-visual-studio.md)  
[Visual Studio Samples](../ide/visual-studio-samples.md)  
[Get Started Developing with Visual Studio](../ide/get-started-developing-with-visual-studio.md)
