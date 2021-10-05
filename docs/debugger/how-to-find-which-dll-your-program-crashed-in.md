---
title: Find Which DLL Your Program Crashed In | Microsoft Docs
description: Use the Modules window to identify which external DLL was active when your application crashed. You can do this for a system DLL, or for someone else's code.   
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug.dll
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugger, DLL crashes
  - Module List dialog box
  - errors [debugger], DLL crashes
  - Modules window
  - debugging [Visual Studio], DLL crashes
  - DLLs, load order of
ms.assetid: ecf62568-8b65-4a41-b8a4-e962ff2dfb71
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Find Which DLL Your Program Crashed In (C#, C++, Visual Basic, F#)

 If your application crashes during a call to a system DLL or someone else's code, you need to find out which DLL was active when the crash occurred. If you experience a crash in a DLL outside your own program, you can identify the location using the **Modules** window.

### To find where a crash occurred using the Modules window

1. Note the address where the crash occurred.

    If the address is not shown in the error message, you may need to use alternative methods to identify the DLL. If you suspect a system DLL, you can [load symbols](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) from the Microsoft Symbol Servers when debugging. Otherwise, you may need to [create a dump file](../debugger/using-dump-files.md) with heap information instead. Various tools are available to create dump files.

2. On the **Debug** menu, choose **Windows**, and click **Modules**.

3. In the **Modules** window, find the **Address** column. You may need to use the scrollbar to see it.

4. Click the **Address** button at the top of the column to sort the DLLs by address.

5. Scan the sorted list to find the DLL whose address range contains the crash location.

6. Look at the **Name** and **Path** columns to see the DLL name and path.

## See also
- [Debugging DLL Projects](../debugger/debugging-dll-projects.md)
- [How to: Use the Modules Window](../debugger/how-to-use-the-modules-window.md)