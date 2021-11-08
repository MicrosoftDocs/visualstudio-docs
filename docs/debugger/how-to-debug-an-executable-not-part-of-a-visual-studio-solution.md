---
title: Debug an app that isn't part of a Visual Studio solution
titleSuffix: 
description: Learn how to debug an app that isn't part of a Visual Studio solution. You may be able to attach the Visual Studio debugger.
ms.custom: SEO-VS-2020
ms.date: 02/21/2020
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - debugging [Visual Studio], executables
  - executable files, importing
  - executable files, debugging outside of projects
ms.assetid: 3ea176e8-1ce5-42c4-b7a2-abe3a2765033
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Debug an app that isn't part of a Visual Studio solution (C++, C#, Visual Basic, F#)

You may want to debug an app (*.exe* file) that isn't part of a Visual Studio solution. It may be an [open folder](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) project, or you or someone else may have created the app outside of Visual Studio, or you got the app from somewhere else.

- For an open folder project in Visual Studio (which has no project or solution file), see [Run and debug your code](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md#run-and-debug-your-code) or, for C++, [Configure debugging parameters with launch.vs.json](/cpp/build/open-folder-projects-cpp#configure-debugging-parameters-with-launchvsjson).

- For an app that doesn't exist in Visual Studio, the usual way to debug is to start the app outside of Visual Studio, and then attach to it using **Attach to Process** in the Visual Studio debugger. For more information, see [Attach to running processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

   Attaching to an app requires manual steps that take a few seconds. Because of this delay, attaching won't help debug a startup issue, or an app that doesn't wait for user input and finishes quickly.

   In these situations, you can create a Visual Studio EXE project for the app, or import it into an existing C#, Visual Basic, or C++ solution. Not all programming languages support EXE projects.

>[!IMPORTANT]
>Debugging features for an app that wasn't built in Visual Studio are limited, whether you attach to the app or add it to a Visual Studio solution.
>
>If you have the source code, the best approach is to import the code into a Visual Studio project. Then, run a debug build of the app.
>
>If you don't have the source code, and the app doesn't have [debug information](../debugger/how-to-set-debug-and-release-configurations.md) in a compatible format, available debugging features are very few.

### To create a new EXE project for an existing app

1. In Visual Studio, select **File** > **Open** > **Project**.

1. In the **Open Project** dialog box, select **All Project Files**, if not already selected, in the dropdown next to **File name**.

1. Navigate to the *.exe* file, select it, and select **Open**.

   The file appears in a new, temporary Visual Studio solution.

1. Start debugging the app by selecting an execution command, like **Start Debugging**, from the **Debug** menu.

### To import an app into an existing Visual Studio solution

1. With a C++, C#, or Visual Basic solution open in Visual Studio, select **File** > **Add** > **Existing Project**.

1. In the **Open Project** dialog box, select **All Project Files**, if not already selected, in the dropdown next to **File name**.

1. Navigate to the *.exe* file, select it, and select **Open**.

   The file appears as a new project under the current solution.

1. With the new file selected, start debugging the app by selecting an execution command, like **Start Debugging**, from the **Debug** menu.

### See also
- [Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)
- [Debugger security](../debugger/debugger-security.md)
- [DBG files](/previous-versions/visualstudio/visual-studio-2010/da528y14(v=vs.100))
