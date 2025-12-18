---
title: Options, Text Editor, C/C++, Advanced
description: Learn how to use the Advanced page in the C/C++ section to change the behavior related to IntelliSense and the browsing database.
ms.date: 12/19/2025
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.Advanced"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Advanced"
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Advanced"
helpviewer_keywords:
  - "Text Editor Options dialog box, advanced"
ms.custom: "ide-ref"
author: tylermsft
ms.author: twhitney
manager: coxford
monikerRange: 'vs-2022'
---
# Options, Text Editor, C/C++, Advanced

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++.

You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **Text Editor** > **C/C++** > **Advanced** section. Most of the settings have a True/False value option. To enable a setting, set the value to True.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio IDE elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Brace Completion

The following options are available for configuring brace completion when programming with C/C++.

**Add Semicolon for Types**

When enabled, Visual Studio automatically inserts a semicolon after the closing brace for a type definition. The default is True.

**Complete Parentheses in Raw String Literals**

When enabled, if you type an open parenthesis in a raw string literal, Visual Studio automatically adds the closing parenthesis. The default is True.

**Complete Multiline Comments**

When enabled, Visual Studio automatically adds the completion syntax for multiline comments (comments that start with `/*`). The default is True.

## Browsing Database Fallback

The following options are available for configuring the browsing database location when programming with C/C++.

The fallback location is where the SDF and IntelliSense support files (for example, iPCH) are put when the primary location (same directory as solution) isn't used. This situation might occur when the user doesn't have the permissions to write to the solution directory or the solution directory is on a slow device. The default fallback location is in the user's temporary directory.

**Always Use Fallback Location**

When enabled, indicates that the code browsing database and IntelliSense files should always be stored in a directory that you specify as your 'Fallback Location' and not next to the solution (_.sln_) file. The IDE never tries to put the SDF or iPCH files next to the solution directory and always uses the Fallback Location. By default, this setting is disabled.

**Do Not Warn If Fallback Location Used**

When enabled, Visual Studio doesn't provide a notification when a 'Fallback Location' directory is used. Normally, you receive a notification when the Fallback Location is in use.

**Fallback Location**

The 'Fallback Location' is used as a secondary location to store the code browsing database or IntelliSense files. By default, your temporary directory is your Fallback Location. When the default is in use, the option value is set to NULL (0). To specify a different value, enter the directory path into the option value box.

The IDE creates a subdirectory under the specified path (or the temporary directory) that includes the name of the solution along with a hash of the full path to the solution, which avoids issues with solution names being identical.

## Browsing/Navigation

The following options are available for configuring browsing and navigation when programming with C/C++.

> [!IMPORTANT]
> By default, the following options are disabled (False). You should never enable these options except in the rare case where a solution is so large that the database activity consumes an unacceptable amount of system resources.

**Disable Database**

When enabled, all use of the code browsing database (SDF), all other Browsing/Navigation options, and all IntelliSense features except for `#include Auto Complete` are disabled.

**Disable Database Updates**

When enabled, the database is opened in read-only mode and no updates are performed while files are being edited. Most features continue to work. However, as edits are made, the data becomes stale, and you experience incorrect results.

**Disable Database Auto Updates**

When enabled, the code browsing database isn't automatically updated when source files are modified. However, if you open **Solution Explorer**, open the shortcut menu for the project, and select **Rescan Solution**, all out-of-date files are checked and the database is updated.

**Disable Implicit Files**

A project contains source files and header files that are explicitly specified. These files can contain references to other files that are external to the project (for example, _afxwin.h_, _windows.h_, and _atlbase.h_). The external files are referred to as _implicit files_ or _dependencies_.

When enabled, the code browsing database doesn't collect data for the implicit files. The system doesn't index the files and some features aren't available for the files. Also, the **Disable Implicit Cleanup** and **Disable External Dependencies Folders** options are implicitly enabled.

**Disable Implicit Cleanup**

When enabled, the code browsing database doesn't clean up implicit files that are no longer referenced. This option prevents implicit files from being removed from the database when they're no longer used. For example, if you add an `#include` directive that references the _mapi.h_ header to a source file, the _mapi.h_ file is found and indexed. If you later remove the `#include` syntax, and the header file isn't referenced elsewhere, information about the header file isn't removed. It remains available for future references.

> [!NOTE]
> If you explicitly rescan the solution, your setting for this option is ignored. For more information, see the **[Rescan Solution Interval](#rescan-solution-interval)** option. 

**Disable External Dependencies Folders**

In **Solution Explorer**, each project can contain an _External Dependencies_ folder, which contains the list of all implicit files for that project. When enabled, Visual Studio doesn't create or update the _External Dependencies_ folder for each project.

**Hide External Dependencies Folders**

When enabled, the _External Dependencies_ folder for projects isn't visible in **Solution Explorer**.

**Recreate Database**

When enabled, Visual Studio recreates the code browsing database when the solution loads. The next time you load the solution, the existing SDF database file is deleted, recreated, and all files reindexed.

<a name="rescan-solution-interval"></a>

**Rescan Solution Interval**

This option provides the run interval for the 'Rescan Solution Now' job. The default value is 60 minutes. You must specify an interval between 0 and 5,000 minutes.

While Visual Studio is rescanning the solution, file timestamps are checked to determine whether a file was changed outside of the IDE. (Changes made in the IDE are automatically tracked and files are updated.) Implicitly included files are checked to confirm existing references.

**Disable Browsing Up-To-Date Check**

When enabled, Visual Studio doesn't wait for the code browsing database to be up-to-date when executing browsing operations.

**Disable Current Item Selection**

When enabled, Visual Studio doesn't show information for the selected code element in the **Properties** tool window and elsewhere.

**Display Skipped Regions for External Files**

When enabled, skipped regions from external files are included when Visual Studio displays browsing database errors.

**Disable Fuzzy Matching**

Fuzzy matching helps locate approximate matches to search input. Rather than returning exact matches only, fuzzy matching also returns similar strings or code snippets that might not exactly match the input. You might see results with variations like typos or different casing.

When enabled, Visual Studio returns only exact matches for your search input. When you enable fuzzy parsing, Visual Studio returns exact matches and also strings or code that match approximately.
 
**Disable Solution Explorer Fuzzy Matching**

When enabled, searches in Solution Explorer return exact matches for your search input. When you enable fuzzy parsing in Solution Explorer, the search results include exact matches and similar matches for items in your solution.

## Code Analysis

**Disable Background Code Analysis**

When enabled, Visual Studio doesn't run C++ code analysis in the background when you open or save a file.

**Disable Code Analysis Squiggles**

When enabled, Visual Studio doesn't show squiggles for C++ code analysis warnings in the editor. Errors continue to display in the error list. If you modify the setting on this option and have open windows, the new setting affects only windows you open after the change.

**Enable Code Analysis Logging**

When enabled, Visual Studio supports debug logging for C++ background code analysis.

## Diagnostic Logging

The following options are provided to assist with the collection of advanced information to help diagnose issues.

> [!NOTE]
> Unless you're requested to provide diagnostic logging data, the recommendation is to disable the options.

**Enable Logging**

When enabled, Visual Studio sends diagnostic logging data to the output window.

**Logging Level**

Use this option to set the logging verbosity, from 0 (most quiet) to 5 (most verbose - default).

**Logging Filter**

Use this option to filter displayed event types by using a bitmask. Set the value by using a sum of any of the following event types:

| Value | Event type     |
|:-----:|----------------|
|  0    | None (Default) |
|  1    | General        |
|  2    | Idle           |
|  4    | WorkItem       |
|  8    | IntelliSense   |
| 16    | ACPerf         |
| 32    | ClassView      |

Depending on the value, you might need to exit and restart Visual Studio.

## Error List

The following option is provided to assist with the collection of advanced information to help diagnose issues.

**Show problem details on double click**

When enabled (default), Visual Studio displays the **Problem Details** window when you double-click an issue to view associated details. The window is visible as you navigate from the Error List to the location of the issue in your source code.

## IntelliSense

<!-- In progress -->


## IntelliSense and Browsing for Non-Project Files

The following options are available for configuring IntelliSense features for nonproject files when programming with C/C++.

**Enable Enhanced Single File**

When enabled (default), you can apply IntelliSense, browsing, and other features to standalone files that aren't part of an existing project. When this option is enabled (True), you can configure the following options:

- **[Enable IntelliSense Squiggles](#enable-intellisense-squiggles)**
- **[Show IntelliSense Errors In Error List](#show-intellisense-errors-in-error-list)**
- **[Suspend New Files During Debugging](#suspend-new-files-during-debugging)**

<a name="enable-intellisense-squiggles"></a>

**Enable IntelliSense Squiggles**

When enabled, IntelliSense squiggles display for standalone nonproject files. By default, this option is set to False. When the **Enable Enhanced Single File** option is disabled (False), this option is ignored and unavailable for manual selection.

<a name="show-intellisense-errors-in-error-list"></a>

**Show IntelliSense Errors In Error List**

When enabled, IntelliSense errors from standalone nonproject files display in the Error List. By default, this option is set to False. When the **Enable Enhanced Single File** option is disabled (False), this option is ignored and unavailable for manual selection.

<a name="suspend-new-files-during-debugging"></a>

**Suspend New Files During Debugging**

When enabled, IntelliSense isn't enabled for newly opened files while you're debugging. By default, this option is set to False. When the **Enable Enhanced Single File** option is disabled (False), this option is ignored and unavailable for manual selection.

## References

The following options are available for configuring references when programming with C/C++.

**Disable Reference Highlighting**

By default, when you select some text in the editor, including code and symbols, all instances of the same text are automatically highlighted in the current file. To disable automatic highlighting, set this option to True. The default value is False.

**Auto Tune Max Find References Threads**

When enabled (default), the **Max Find References Threads** value is automatically tuned based on the count of system CPU cores. If you prefer to specify the value manually, disable this option (False).

**Max Find References Threads**

Use this option to specify the maximum number of concurrent threads the system can use for finding references. The value must be between 1 and 63.

When the **Auto Tune Max Find References Threads** option is enabled (True), the value of this option is determined for you by the system and can't be changed manually. To change the value, first set the **Auto Tune Max Find References Threads** option to False.

## Text Editor

The following options are available for configuring automatic formatting actions in the code editor when programming with C/C++.

**Auto Surround Mode**

Use this setting to control whether Visual Studio should automatically surround (enclose) your selections as you work in the editor. You can surround selections enclosed in brackets (square `[]`) or quotes (double `""` or single `''`), or all types.

For example, if you type an open quote or bracket, Visual Studio can automatically add the closing quote or bracket to enclose (surround) your selection. Choose from **Quotes only**, **Brackets Only**, **All** (default), or **Never**.

**Format After Auto Surround**

When enabled, Visual Studio formats the code syntax within the enclosed section after the selection is automatically surrounded. The default is True.

**Expand Selection for Surround Scopes**

When enabled, if you surround a selection within a scope (such as with parenthesis `()` or curly braces `{}`), the surround expands to contain the whole line. The default is True.

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
