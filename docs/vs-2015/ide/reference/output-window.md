---
title: "Output Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vs.build.output"
  - "vs.debug.output"
  - "vs.output"
helpviewer_keywords:
  - "Output window, about Output window"
  - "Output window"
  - "Toolbox, removing controls"
ms.assetid: d8931d88-250e-4db4-963f-2c5b3e99b45f
caps.latest.revision: 35
author: jillre
ms.author: jillfra
manager: jillfra
---
# Output Window
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **Output** window can display status messages for various features in the integrated development environment (IDE). To open the **Output** window, on the menu bar, choose **View/Output** (or click CTRL + ALT + O).

> [!WARNING]
> The Output window does not appear on the View menu in Visual Studio Express editions. To bring it up, use the hotkey CTRL + ALT + O.

## Toolbar
 **Show output from**
 Displays one or more output panes to view. Several panes of information might be available, depending on which tools in the IDE have used the **Output** window to deliver messages to the user.

 **Find Message in Code**
 Moves the insertion point in the code editor to the line that contains the selected build error.

 **Go to Previous Message**
 Changes the focus in the **Output** window to the previous build error and moves the insertion point in the code editor to the line that contains that build error.

 **Go to Next Message**
 Changes the focus in the **Output** window to the next build error and moves the insertion point in the code editor to the line that contains that build error.

 **Clear all**
 Clears all text from the **Output** pane.

 **Toggle Word Wrap**
 Turns the Word Wrap feature on and off in the **Output** pane. When Word Wrap is on, text in longer entries that extends beyond the viewing area is displayed on the following line.

## Output Pane
 The **Output** pane selected in the **Show output from** list displays output from the source indicated.

## Routing Messages to the Output Window
 To display the **Output** window whenever you build a project, in the **General, Projects and Solutions, Options** dialog box, select **Show Output window when build starts**. Then, with a code file open for editing, choose the **Go to Next Message** and **Go To Previous Message** buttons on the **Output** window toolbar to select entries in the **Output** pane. As you do this, the insertion point in the code editor jumps to the line of code where the selected problem occurs.

 Certain IDE features and commands invoked in the [Command Window](../../ide/reference/command-window.md) deliver their output to the **Output** window. Output from external tools such as .bat and .com files, which is typically displayed in the Command Prompt window, is routed to an **Output** pane when you select the **Use Output Window** option in the [Managing External Tools](../../ide/managing-external-tools.md). Many other kinds of messages can be displayed in **Output** panes as well. For example, when Transact-SQL syntax in a stored procedure is checked against a target database, the results are displayed in the **Output** window.

 You can also program your own applications to write diagnostic messages at run time to an **Output** pane. To do this, use members of the <xref:System.Diagnostics.Debug> class or <xref:System.Diagnostics.Trace> class in the <xref:System.Diagnostics> namespace of the .NET Framework Class Library. Members of the <xref:System.Diagnostics.Debug> class display output when you build Debug configurations of your solution or project; members of the <xref:System.Diagnostics.Trace> class display output when you build either Debug or Release configurations. For more information, see [Diagnostic Messages in the Output Window](../../debugger/diagnostic-messages-in-the-output-window.md).

 In [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)], you can create custom build steps and build events whose warnings and errors are displayed and counted in the **Output** pane. By pressing F1 on a line of output, you can display an appropriate help topic. For more information, see [Formatting the Output of a Custom Build Step or Build Event](https://msdn.microsoft.com/library/92ad3e38-24d7-4b89-90e6-5a16f5f998da).

## Scrolling Behavior
 If you use autoscrolling in the Output window and then navigate by using the mouse or arrow keys, autoscrolling stops. To resume autoscrolling, press CTRL+END.

## See Also
 [Diagnostic Messages in the Output Window](../../debugger/diagnostic-messages-in-the-output-window.md)
 [How to: Control the Output Window](https://msdn.microsoft.com/library/91aebd15-8854-4a7a-9f7d-57376fb4e858)
 [Compiling and Building](../../ide/compiling-and-building-in-visual-studio.md)
 [Understanding Build Configurations](../../ide/understanding-build-configurations.md)
 [Class Library Overview](https://msdn.microsoft.com/library/7e4c5921-955d-4b06-8709-101873acf157)
