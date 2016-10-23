---
title: "Getting Started with C++ in Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: get-started-article
ms.assetid: 99c73344-86ba-4b08-9e15-f6111cc04185
caps.latest.revision: 18
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Getting Started with C++ in Visual Studio
By completing this walkthrough, you’ll become familiar with many of the tools and dialog boxes that you can use when you develop applications with Visual Studio. You’ll create a simple "Hello, World"-style application while you learn more about working in the integrated development environment (IDE).  
  
 This topic contains the following sections:  
  
 [Sign In to Visual Studio](../VS_IDE/Getting-Started-with-C---in-Visual-Studio.md#BKMK_Configure)  
  
 [Create a simple application](../VS_IDE/Getting-Started-with-C---in-Visual-Studio.md#BKMK_CreateApp)  
  
 [Add Code to the Application](../VS_IDE/Getting-Started-with-C---in-Visual-Studio.md#BKMK_AddCode)  
  
 [Debug and Test the application](../VS_IDE/Getting-Started-with-C---in-Visual-Studio.md#BKMK_DebugTest)  
  
 [Build a release version of the app](../VS_IDE/Getting-Started-with-C---in-Visual-Studio.md#BKMK_BuildRelease)  
  
##  <a name="BKMK_Configure"></a> Sign In to Visual Studio  
 When you start Visual Studio for the first time, you are given the chance to sign in using a Microsoft account such as Live or Outlook. Signing in allows your settings to be synchronized across all your devices. For more information, see [Signing in to Visual Studio](../VS_IDE/Signing-in-to-Visual-Studio.md)  
  
 Figure 1: Visual Studio IDE  
  
 ![IDE with Visual C&#43;&#43; settings applied](../VS_IDE/media/C--IDE_DefaultEnvironmentLayout.png "C++IDE_DefaultEnvironmentLayout")  
  
 After you open Visual Studio, you can see the three basic parts of the IDE: tool windows, menus and toolbars, and the main window space. Tool windows are docked on the left and right sides of the app window, with **Quick Launch**, the menu bar, and the standard toolbar at the top. The center of the application window contains the **Start Page**. When you open a solution or project, editors and designers appear in this space. When you develop an application, you’ll spend most of your time in this central area.  
  
##  <a name="BKMK_CreateApp"></a> Create a simple application  
 When you create an app in Visual Studio, you first create a project and a solution. For this example, you’ll create a Windows console application.  
  
#### To create a console app  
  
1.  On the menu bar, choose **File**, **New**, **Project**.  
  
     ![On the menu bar, choose File, New, Project](../VS_IDE/media/ExploreIDE-FileNewProject.png "ExploreIDE-FileNewProject")  
  
2.  In the **Visual C++** category, choose the **Win32 Console Application** template, and then name the project `GreetingsConsoleApp`.  
  
     ![Win32 Console application template](../VS_IDE/media/C--IDE_NewProjectDlg.png "C++IDE_NewProjectDlg")  
  
3.  When the Win32 Application Wizard appears, choose the **Finish** button.  
  
     ![Win32 Console application wizard](../VS_IDE/media/C--IDE_Win32ConsoleAppWizard.png "C++IDE_Win32ConsoleAppWizard")  
  
 The GreetingsConsoleApp project and solution, with the basic files for a Win32 console app, are created and automatically loaded into **Solution Explorer**. The GreetingsConsoleApp.cpp file is opened in the code editor. The following items appear in **Solution Explorer**:  
  
 Figure 4: Project items  
  
 ![Files for the solution in Solution Explorer](../VS_IDE/media/C--IDE_SolutionContents.png "C++IDE_SolutionContents")  
  
##  <a name="BKMK_AddCode"></a> Add Code to the Application  
 Next, you'll add code to display the word "Hello" in the console window.  
  
#### To display “Hello” in the console window  
  
1.  In the GreetingsConsoleApp.cpp file, enter a blank line before the line `return 0;` and then enter the following code:  
  
    ```  
    cout << "Hello\n";  
    ```  
  
     A red squiggly line appears under `cout`. An error message appears if you point to it.  
  
     ![Error text for cout](../VS_IDE/media/C--IDE_CoutError.png "C++IDE_CoutError")  
  
     The error message also appears in the **Error List** window. You can display the window by, on the menu bar, choosing **View**, **Error List**.  
  
     [cout](../Topic/cout.md) is included in the <iostream> header file.  
  
2.  To include the iostream header, enter the following code after `#include "stdafx.h"`:  
  
    ```  
    #include <iostream>  
    using namespace std;  
    ```  
  
     You probably noticed that a box appeared as you entered code, providing suggestions for the characters that you entered. This box is part of C++ IntelliSense, which provides coding prompts, including listing class or interface members and parameter information. You can also use code snippets, which are pre-defined blocks of code. For more information, see [Using IntelliSense](../VS_IDE/Using-IntelliSense.md) and [Code Snippets](../VS_IDE/Code-Snippets.md).  
  
     The red squiggly line under `cout` disappears when you fix the error.  
  
3.  Save the changes to the file.  
  
     ![Code that fixes cout error](../VS_IDE/media/C--IDE_CoutFix.png "C++IDE_CoutFix")  
  
##  <a name="BKMK_DebugTest"></a> Debug and Test the application  
 You can debug GreetingsConsoleApp to see whether the word "Hello" appears in the console window.  
  
#### To debug the application  
  
-   Start the debugger.  
  
     ![Start Debugging command on the Debug menu](../VS_IDE/media/ExploreIDE-StartDebugging.png "ExploreIDE-StartDebugging")  
  
     The debugger starts and runs the code. The console window (a separate window that looks like a command prompt) appears for a few seconds but closes quickly when the debugger stops running. To see the text, you need to set a breakpoint to stop program execution.  
  
#### To add a breakpoint  
  
1.  Add a breakpoint from the menu bar at the line `return 0;`. You can also just click in the left margin to set a breakpoint.  
  
     ![Toggle Breakpoint command on the Debug menu](../VS_IDE/media/ExploreIDE-ToggleBreakpoint.png "ExploreIDE-ToggleBreakpoint")  
  
     A red circle appears next to the line of code in the far left margin of the editor window.  
  
2.  Choose the F5 key to start debugging.  
  
     The debugger starts, and a console window appears showing the word **Hello**.  
  
     ![Hello text in the Windows Command Prompt window](../VS_IDE/media/C--IDE_HelloCommandWindow.png "C++IDE_HelloCommandWindow")  
  
3.  Press SHIFT + F5 to stop debugging.  
  
 For more information, see [Console Projects](../VS_debugger/Debugging-Preparation--Console-Projects.md).  
  
##  <a name="BKMK_BuildRelease"></a> Build a release version of the app  
 Now that you’ve verified that everything works, you can prepare a release build of the application.  
  
#### To clean the solution files and build a release version  
  
1.  From the menu bar, delete intermediate files and output files that were created during previous builds.  
  
     ![The Clean Solution command on the Build menu](../VS_IDE/media/ExploreIDE-CleanSolution.png "ExploreIDE-CleanSolution")  
  
2.  Change the build configuration for GreetingsConsoleApp from **Debug** to **Release**.  
  
     ![Build a release version of the application](../VS_IDE/media/C--IDE_ChangingBuildtoRelease.png "C++IDE_ChangingBuildtoRelease")  
  
3.  Build the solution.  
  
     ![Build Solution command on the Build menu](../VS_IDE/media/ExploreIDE-BuildSolution.png "ExploreIDE-BuildSolution")  
  
 Congratulations on completing this walkthrough! If you want to explore more examples, see [Visual Studio Samples](../VS_IDE/Visual-Studio-Samples.md).  
  
## See Also  
 [Walkthrough: Create a Simple Application](../VS_IDE/Walkthrough--Create-a-Simple-Application-with-Visual-C#-or-Visual-Basic.md)   
 [Productivity Tips](../VS_IDE/Productivity-Tips-for-Visual-Studio.md)   
 [Visual Studio Samples](../VS_IDE/Visual-Studio-Samples.md)   
 [Get Started Developing with Visual Studio](../VS_IDE/Get-Started-Developing-with-Visual-Studio.md)