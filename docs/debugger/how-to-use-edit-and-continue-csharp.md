---
title: Use Edit and Continue (C#) | Microsoft Docs
description: Use Edit and Continue to make and apply changes to your code in break mode while debugging, without stopping and restarting the debug session in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 10/04/2018
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - Edit and Continue [C#], about Edit and Continue
ms.assetid: 40e136d8-a08c-43bd-b313-fb821c55eb3c
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - dotnet
---
# How to: Use Edit and Continue (C#)
With Edit and Continue, you can make and apply changes to your code in break mode while debugging, without having to stop and restart the debugging session.

Edit and Continue for C# happens automatically when you make code changes in break mode, then continue debugging by using **Continue**, **Step**, or **Set Next Statement**, or evaluate a function in a debugger window.

For more information, see [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md).

>[!NOTE]
>Edit and Continue is not supported for optimized, mixed, or SQL Server common language runtime (CLR) integration code. For information on other unsupported scenarios, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md). If you try to Edit and Continue with one of these scenarios, a message box appears stating that Edit and Continue is not supported.

**To enable or disable Edit and Continue:**

1. If you're in a debugging session, stop debugging (**Debug** > **Stop Debugging** or **Shift**+**F5**).

1. In **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**, select or clear the **Enable Edit and Continue** check box.

The setting takes effect when you start or restart the debugging session.

**To use Edit and Continue:**

1. While debugging, in break mode, make a change to your source code.

1. From the **Debug** menu, click **Continue**, **Step**, or **Set Next Statement**, or evaluate a function in a debugger window.

   Debugging continues with the new, compiled code.

Some types of code changes are not supported by Edit and Continue. For more information, see [Supported code changes (C# and Visual Basic)](../debugger/supported-code-changes-csharp.md).
