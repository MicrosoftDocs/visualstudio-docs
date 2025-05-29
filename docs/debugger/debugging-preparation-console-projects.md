---
title: "Prepare to debug console projects"
description: Get information about preparing to debug console projects (C#, C++, Visual Basic, F#) in Visual Studio.
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], console applications"
  - "debugging console applications"
  - "console applications, debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debugging Preparation: Console Projects (C#, C++, Visual Basic, F#)

Preparing to debug a Console project is similar to preparing to debug a Windows project, with some additional considerations such as setting command-line arguments and how to pause the app for debugging. Because of the similarity of all console applications, this topic covers the following project types:

- C#, Visual Basic, and F# Console Application

- C++ Console Application (.NET)

- C++ Console Application (Win32)

  A console application uses the **Console** window to accept input and to display output messages. To write to the **Console** window, your application must use the **Console** object instead of the Debug object. To write to the **Visual Studio Output** window, use the Debug object, as usual. Be sure that you know where your application is writing or you might be looking for messages in the wrong place. For more information, see [Console Class](/dotnet/api/system.console), [Debug Class](/dotnet/api/system.diagnostics.debug), and [Output Window](../ide/reference/output-window.md).

## Set command-line arguments

You might have to specify command-line arguments for your console application. For more information, see [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md), [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md), or [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md).

Like all project properties, these arguments persist between debug sessions and between  Visual Studio sessions. Therefore, if the console application is one that you have debugged previously, remember that there might be arguments from previous sessions entered in the **\<Project> Property Pages** dialog box.

## Start the application

 When some console applications start, they run to completion and then exit. This behavior might not give you enough time to break execution and debug. To be able to debug an application, use one of the following procedures to start the application:

- Set a breakpoint in your code and start your application.

- Start your application using **F10** (**Debug** > **Step Over**) or **F11** (**Debug** > **Step Into**), and then navigate through code using other options such as **Run to click**.

- In the code editor, right-click a line and select **Run to cursor**.

  When you debug a console application, you might want to start the application from the command prompt rather than from Visual Studio. In that case, you can start the application from the command prompt and attach the Visual Studio debugger to it. For more information, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

  When you start a console application from Visual Studio, the **Console** window sometimes appears behind the Visual Studio window. If you try to start your console application from Visual Studio and nothing seems to happen, try to move the Visual Studio window.

## See also
- [Debugging Native Code](../debugger/debugging-native-code.md)
- [Debugging Managed Code](/visualstudio/debugger/)
- [Prepare to debug C++ projects](../debugger/debugging-preparation-visual-cpp-project-types.md)
- [Managed debugging: Recommended project settings](../debugger/managed-debugging-recommended-property-settings.md)
- [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
- [Debugger Security](../debugger/debugger-security.md)