---
title: Python Options in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 6/2/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3c714867-7a64-4b1e-aca8-09d956192279
f1_keywords: 
  - "VS.ToolsOptionsPages.Python_Tools"
  - "VS.ToolsOptionsPages.Python_Tools.General"
  - "VS.ToolsOptionsPages.Python_Tools.Debugging"
  - "VS.ToolsOptionsPages.Python_Tools.Interactive_Windows"

author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Options for Python in Visual Studio

To view Python options, use the **Tools > Options** menu command, make sure **Show all settings** is selected, and then navigate to **Python Tools**:

![Python options dialog, General tab](media/options-general.png)

The specific options are described in the following sections:

- [General options](#general-options)
- [Debugging options](#debugging-options)
- [Interactive Windows options](#interactive-windows-options)

## General options

| Option | Default | Description |
| --- | --- | --- |
| Show the Output Window when creating virtual environments<br/>Show the Output Window when installing or removing packages | On<br/>On | Opens the output window in Visual Studio to show details of the process involved. Clear this option to prevent the window from appearing. |
| Always run pip as administrator | Off | Select this option if a package install fails due to permission or access errors. |
| Automatically generate completion DB on first use | On | For [IntelliSense completions](code-editing.md#intellisense) to work for a library, Visual Studio must generate a completion database for that library. This is done in the background when a library is installed, but may not be complete when you start writing code. With this option selected, Visual Studio prioritizes completion of the database for a library when you write code that uses it. |
| Ignore system-wide PYTHONPATH variables | On | PYTHONPATH is ignored by default because Visual Studio provides a more direct means to specify search paths in environments and projects. See [Python Environments - search paths](python-environments.md#search-paths) for details. |
| Update search paths when adding linked files | On | When set, adding a [linked file](python-projects.md#linked-files) to a project updates [search paths](python-environments.md#search-paths) so that IntelliSense can include the contents of the linked file's folder in its completion database. Clear this option to exclude such content from the completion database. |
| Warn when imported module cannot be found | On | Clear this option to suppress warnings when if you know an imported module isn't presently available but won't otherwise affect code operation. |
| Report inconsistent indentation as | Warnings | Because the Python interpreter depends heavily on proper indentation to determine scope, Visual Studio by default issues warnings when it detects inconsistent indentations that might indicate coding errors. Set to *Errors* to be even more strict, which causes the program to exit in such cases. To disable this behavior altogether, select *Don't*. |
| Check for survey/news | Once a week | Sets the frequency at which Visual Studio checks for items to display in <TODO: Where?>. Options are *Never*, *Once a day*, *Once a week*, and *Once a month*. |
| Reset all permanently hidden dialogs (button) | n/a | Different dialog boxes provide options such as **Don't show me this again**. Use this button to clear those options and cause the dialogs to reappear. |

![Python options dialog, General tab](media/options-general.png)

## Debugging options

| Option | Default | Description |
| --- | --- | --- |
| Prompt before running when errors are present | On | When set, prompts you to confirm that you want to run code that contains errors. Clear this option to disable that warning. |
| Wait for input when process exits abnormally<br/>Wait for input when process exits normally | On<br/> | A Python program started from Visual Studio runs in its own console window. By default, the window will wait for you to press a key before closing it. To remove that prompt and close the window automatically, clear either or both of these options. |
| Tee program output to Debug Output window | On | Displays program output in both a separate console window and the Visual Studio Output window. Clear this option to show output only in the separate console window. |
| Break on SystemExit exception with exit code of zero | Off | If set, stops the debugger on this exception. When clear, the debugger will exit without breaking. |
| Enable debugging of the Python standard library | Off | Makes it possible to step into the standard library source code while debugging, but increases the time it takes for the debugger to start.|


![Python options dialog, Debugging tab](media/options-debugging.png)

## Interactive Windows options

| Option | Default | Description |
| --- | --- | --- |
| Scripts | n/a | Specifies a general folder for startup scripts to apply to interactive windows for all environments. See [Startup scripts](python-environments.md#startup-scripts). Note, however, that this feature does not currently work. |
| Up/down arrows navigate history | On | Uses the arrow keys to navigate through history in the interactive window. Clear this setting to use the arrow keys to navigate within the interactive window's output instead. |
| Completion mode | Only evaluate expressions without function calls | <TODO> |
| Hide static analysis suggestions | Off | <TODO> |

![Python options dialog, Interactive Windows tab](media/options-interactive-windows.png)
