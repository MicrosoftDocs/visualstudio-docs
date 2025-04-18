---
title: Output Window
description: Learn about the Output window and how it displays status messages for various features in the IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vs.build.output
- vs.debug.output
helpviewer_keywords:
- Output window, about Output window
- Output window
- Toolbox, removing controls
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Output window

The **Output** window displays status messages for various features in the integrated development environment (IDE). To open the **Output** window, on the menu bar, choose **View** > **Output**, or press **Ctrl**+**Alt**+**O**.

## Toolbar

The following controls are shown in the toolbar of the **Output** window.

### Show output from

Displays one or more output panes to view. Several panes of information might be available, depending on which tools in the IDE have used the **Output** window to deliver messages to the user.

### Find Message in Code

Moves the insertion point in the code editor to the line that contains the selected build error.

### Go to Previous Message

Changes the focus in the **Output** window to the previous build error and moves the insertion point in the code editor to the line that contains that build error.

### Go to Next Message

Changes the focus in the **Output** window to the next build error and moves the insertion point in the code editor to the line that contains that build error.

### Clear all

Clears all text from the **Output** pane.

### Toggle Word Wrap

Turns the Word Wrap feature on and off in the **Output** pane. When Word Wrap is on, text in longer entries that extends beyond the viewing area is displayed on the following line.

## Output pane

The **Output** pane selected in the **Show output from** list displays output from the source indicated.

## Route messages to the Output window

To display the **Output** window whenever you build a project, in the **Options** dialog box, on the **Projects and Solutions** > **General** page, select **Show Output window when build starts**. Then, with a code file open for editing, choose **Go to Next Message** and **Go To Previous Message** on the **Output** window toolbar to select entries in the **Output** pane. As you do this, the insertion point in the code editor jumps to the line of code where the selected problem occurs.

Certain IDE features and commands invoked in the [Command window](../../ide/reference/command-window.md) deliver their output to the **Output** window. Output from external tools such as *.bat* and *.com* files, which is typically displayed in the command window, is routed to an **Output** pane when you select the **Use Output Window** option in [Manage external tools](../../ide/managing-external-tools.md). Many other kinds of messages can be displayed in **Output** panes as well. For example, when Transact-SQL syntax in a stored procedure is checked against a target database, the results are displayed in the **Output** window.

You can also program your own applications to write diagnostic messages at run time to an **Output** pane. To do this, use members of the <xref:System.Diagnostics.Debug> class or <xref:System.Diagnostics.Trace> class in the <xref:System.Diagnostics> namespace of the .NET API. Members of the <xref:System.Diagnostics.Debug> class display output when you build Debug configurations of your solution or project; members of the <xref:System.Diagnostics.Trace> class display output when you build either Debug or Release configurations. For more information, see [Diagnostic messages in the Output window](../../debugger/diagnostic-messages-in-the-output-window.md).

In C++, you can create custom build steps and build events whose warnings and errors are displayed and counted in the **Output** pane. By pressing **F1** on a line of output, you can display an appropriate help topic. For more information, see [Format the output of a custom build step](/cpp/build/formatting-the-output-of-a-custom-build-step-or-build-event).

## Scroll behavior

If you use autoscrolling in the **Output** window and then navigate by using the mouse or arrow keys, autoscrolling stops. To resume autoscrolling, press **Ctrl**+**End**.

## Structured Diagnostics

C++ MSBuild projects might emit structured diagnostics. The level of indentation of a diagnostic in the **Output** window represents the nested structure of the information. Enable or disable indentation with the **Project** > **Properties** > **Advanced** > **Enable MSVC Structured Output** option. You can affect several projects by creating a [Directory.Build.props](/visualstudio/msbuild/customize-by-directory) file with the **UseStructuredOutput** property defined to true or false.

## See also

- [Diagnostic messages in the Output window](../../debugger/diagnostic-messages-in-the-output-window.md)
- [How to: Control the Output window](/previous-versions/ht6z4e28(v=vs.140))
- [Compile and build](../../ide/compiling-and-building-in-visual-studio.md)
- [Understand build configurations](../../ide/understanding-build-configurations.md)
- [Class library overview](/dotnet/standard/class-library-overview)