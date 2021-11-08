---
title: "Executable for Debugging Session Dialog Box | Microsoft Docs"
description: To debug a DLL you must specify an executable to call the DLL. Learn about the dialog box that appears when no executable is specified.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
f1_keywords:
  - "vs.debug.exefordebug"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "executable files, specifying when debugging"
  - "DLLs, debugging"
  - "debugger, Executable for Debugging Session dialog box"
  - "Executable for Debugging Session dialog box"
ms.assetid: c0ddbe32-b99f-4425-acf1-f48842804f56
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Executable for Debugging Session Dialog Box

This dialog box appears when you try to debug a DLL for which no executable is specified. Visual Studio can't launch a DLL directly. Instead, Visual Studio launches the specified executable. You can debug the DLL when it's called by the executable.

 **Executable file name**
 Enter the path name to an executable that calls the DLL you are debugging.

 **URL where the project can be accessed (ATL Server only)**
 If you are debugging an ATL Server DLL, enter the URL where the project can be found.

 Once entered, these settings are stored in the project Property Pages, so you won't need to enter them again for subsequent debugging sessions. If you need to change the settings, you can open the Property Pages and change the values. For more information on specifying an executable for the debugging session, see [Debugging DLLs](../debugger/how-to-debug-from-a-dll-project.md).

## See also

- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)