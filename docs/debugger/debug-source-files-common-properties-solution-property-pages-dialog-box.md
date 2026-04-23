---
title: "Specify debug source files"
description: Access the Debug Source Files property page in Visual Studio by right-clicking your solution in Solution Explorer and selecting Properties > Common Properties.
ms.date: "1/12/2026"
ms.topic: article
f1_keywords:
  - "vs.debug.options.FindSource"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords:
  - "Debug Source Files property page"
  - "debugging [Visual Studio], specifying source and symbol files"
  - "source files, specifying in debugger"
  - "debugger, source files"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Specify debug source files

You can use the **Debug Source Files** property page to specify where the debugger will look for source files when debugging the solution.

To access the **Debug Source Files** property page, right-click on your Solution in **Solution Explorer** and select **Properties** from the shortcut menu. Expand the **Common Properties** folder, and click the **Debug Source Files** page.

**Directories containing source code**
Contains a list of directories in which the debugger searches for source files when debugging the solution. Subdirectories of the specified directories are also searched.

**Do not look for these source files**
Enter the names of any files that you don't want the debugger to read. If the debugger finds one of these files in one of the directories specified above, it will ignore it. If the **Find Source** dialog box comes up while you're debugging and , you click **Cancel**, the file you were searching for gets added to this list so that the debugger won't continue searching for that file.

## See also

- [Debugger Security](../debugger/debugger-security.md)
- [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)