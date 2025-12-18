---
title: Configure Advanced Language Options for C/C++
description: Configure advanced language settings for C/C++ in the Tools Options pane. Change the behavior related to IntelliSense and the browsing database.
ms.date: 12/19/2025
ms.topic: how-to
f1_keywords:
  - "VS.ToolsOptionsPages.Languages.C\\C++.Advanced"
  - "VS.ToolsOptionsPages.Languages.C%2FC%2B%2B.Advanced"
  - "VS.ToolsOptionsPages.Languages.C/C++.Advanced"
helpviewer_keywords:
  - "Languages Options, advanced"
ms.custom: "ide-ref"
author: GitHubber17
ms.author: twhitney
manager: coxford
monikerRange: 'visualstudio'
---
# Configure Languages > C/C++ > Advanced options

This article describes how to --- TBD ---. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Languages** > **C/C++** section.

<!-- LINKS to related topics --- To configure general **Environment** settings, see [Options dialog box: Environment > General](./general-environment-options-dialog-box.md). -->

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++.

## Brace completion

The **Brace completion** options are available in the **C/C++** > **Text Editor** section. 

> [!NOTE]
> Earlier versions of Visual Studio provide **Brace completion** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Insert a semicolon after completing braces for types** 

When selected (default), Visual Studio automatically inserts a semicolon after the closing brace for a type definition.

**Complete parentheses in raw string literals**

When selected (default), if you type an open parenthesis in a raw string literal, Visual Studio automatically adds the closing parenthesis.

**Complete multiline comments**

When selected (default), Visual Studio automatically adds the completion syntax for multiline comments (comments that start with `/*`).

## Browsing database location

Options to configure the browsing database location are available in the **C/C++** > **IntelliSense** > **Browsing & navigation** > **Location** section.

> [!NOTE]
> Earlier versions of Visual Studio provide similar options under the **Text Editor** > **C/C++** > **Advanced** section in the **Browsing Database Fallback** category.

By default, the primary location for the SDF and IntelliSense support files (for example, iPCH) is the solution directory folder. If this location isn't available, your temporary directory is used as the default secondary location. This scenario can occur if you don't have the permissions to write to the solution directory or the solution directory is on a slow device.

You can use the following settings to identify a custom secondary location, or specify a custom location to always use as the primary location. For the secondary location, the IDE creates a subdirectory under the custom location (or the temporary directory) that includes the name of the solution along with a hash of the full path to the solution, which avoids issues with solution names being identical.

**Always use the specified custom location for the browsing database**

When selected, Visual Studio always uses the secondary location specified in the **Custom location for browsing database files** option as the primary location for the browsing database. When this option isn't selected (default), it uses the default primary location, the solution directory folder.

**Custom location for browsing database files**

Use this option to specify a custom folder for Visual Studio to use as the secondary location for the browsing database location.

This folder is also used if the default primary location is currently unavailable. When no location is specified, Visual Studio uses the user's temporary directory as the default secondary location.

## Browsing and navigation

General options to configure browsing and navigation are available in the **C/C++** > **IntelliSense** > **Browsing & navigation** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Browsing/Navigation** options under the **Text Editor** > **C/C++** > **Advanced** section.

> [!IMPORTANT]
> The following options are disabled by default (False) and the recommendation is to leave them unchanged.
> In the rare case where a solution is so large that the database activity consumes an unacceptable amount of system resources, enable the necessary options only.

**Cache code browsing information**

When selected (default), the code browsing database (SDF), all browsing and navigation options, and all IntelliSense features are available.

If you clear this option, all use of the code browsing database and all IntelliSense features except for `#include Auto Complete` are disabled.

**Enable updates to the code browsing database**

When selected (default), the database is opened in read-write mode and updates can be performed while files are being edited.

If you clear this option, the database is opened in read-only mode and no updates are performed while files are being edited. Most features continue to work. However, as edits are made, the data becomes stale, and you experience incorrect results.

**Update code browsing information as you type**

When selected (default), the code browsing database is automatically updated when source files are modified.

If you clear this option, the code browsing database isn't automatically updated when source files change. However, if you open **Solution Explorer**, open the shortcut menu for the project, and select **Rescan Solution**, all out-of-date files are checked and the database is updated.

**Recreate the code browsing database the next time the solution is loaded**

When selected, Visual Studio recreates the code browsing database when the solution loads. The next time you load the solution, the existing SDF database file is deleted, recreated, and all files reindexed. By default, this option isn't selected.

<a name="rescan-solution-interval"></a>

**Interval to rescan solution (in minutes)**

This option provides the run interval for the 'Rescan Solution Now' job. The default value is 60 minutes. You must specify an interval between 0 and 5,000 minutes.

While Visual Studio is rescanning the solution, file timestamps are checked to determine whether a file was changed outside of the IDE. (Changes made in the IDE are automatically tracked and files are updated.) Implicitly included files are checked to confirm existing references.

**Wait for the browsing database to be up-to-date when executing browsing operations**

When selected, Visual Studio waits for the code browsing database to be up-to-date when executing browsing operations. By default, this option isn't selected.

**Show information for the selected code element in the properties window**

When selected, Visual Studio shows information for the selected code element in the **Properties** tool window and elsewhere. By default, this option isn't selected.

**Choose how to highlight macros that are inside regions skipped by the browsing database**

Use this option to specify how to highlight macros inside regions that are skipped by the browsing database. Choose from **Suggestion** (default), **Warning**, **Error**, or **None**. For more information about hint files, see [Hint files](/cpp/build/reference/hint-files?view=msvc-180&preserve-view=true).

**Include skipped regions from external files when displaying browsing database errors**

When selected, skipped regions from external files are included when Visual Studio displays browsing database errors. By default, this option isn't selected.

**Use fuzzy matching to provide search results**

Fuzzy matching helps locate approximate matches to search input. Rather than returning exact matches only, fuzzy matching also returns similar strings or code snippets that might not exactly match the input. You might see results with variations like typos or different casing.

When selected (default), Visual Studio returns both exact matches and approximate matches, including strings and code snippets. If you clear this option, only exact matches are returned.
 
**Enable fuzzy match results when searching in the solution explorer**

When selected (default), a search in Solution Explorer returns both exact matches and approximate matches for items in your solution. If you clear this option, the search returns only exact matches in your solution.

**Allow for fuzzy navigation to declarations or definitions after the signatures have changed**

Visual Studio 2026 offers a combination of ranked, tolerant matching with completion filtering to help reduce friction when navigating in the IDE. These enhancements make it possible to access current declarations or definitions from older references based on outdated signatures.

When selected (default), Visual Studio supports fuzzy navigation to current declarations and definitions. If you clear this option, you can't jump to a current declaration or definition from an older reference based on an outdated signature.

**Save code browsing information for external dependencies**

A project contains source files and header files that are explicitly specified. These files can contain references to other files that are external to the project (for example, _afxwin.h_, _windows.h_, and _atlbase.h_). The external files are referred to _dependencies_ or _implicit files_.  

When selected (default), the code browsing database collects data for the external dependencies that aren't specified in a project. The system finds these files and also indexes them for various browsing features (including Navigate To). 

If you clear this option, the external dependencies aren't indexed, and some features aren't available for the files, including:

- **[Periodically scan external dependencies and remove unused files from database](#scan-external-dependencies)**
- **[Evaluate external dependencies graph](#eval-external-dependencies)**
- **[Show external dependencies in solution explorer](#show-external-dependencies)**

<a name="scan-external-dependencies"></a>

**Periodically scan external dependencies and remove data for files that are no longer included from the code browsing database**

When selected (default), Visual Studio periodically scans the external dependencies and removes data for unused files from the code browsing database. This option ensures implicit files are removed from the database when they're no longer used. For example, if you add an `#include` directive that references the _mapi.h_ header to a source file, the _mapi.h_ file is found and indexed. If you later remove the `#include` syntax, and the header file isn't referenced elsewhere, Visual Studio detects the unused file and removes the related date from the database.

If you clear this option, Visual Studio doesn't complete the period scans or updates to the database.

> [!NOTE]
> If you explicitly rescan the solution, your setting for this option is ignored. For more information, see the **[Rescan Solution Interval](#rescan-solution-interval)** option. 

<a name="eval-external-dependencies"></a>

**Evaluate external dependencies graph**

In **Solution Explorer**, each project can contain an _External Dependencies_ folder, which contains the list of all implicit files for that project. When selected (default), Visual Studio identifies the external dependencies for the project and creates or updates the folder. If you clear this option, Visual Studio doesn't update the folder contents.

<a name="show-external-dependencies"></a>

**Show external dependencies in solution explorer**

When selected (default), the _External Dependencies_ folder for projects is visible in **Solution Explorer**. If you clear this option, the folder isn't visible.

## Code analysis

Options to support C/C++ code analysis are available in the **C/C++** > **Code analysis** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Code Analysis** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Run C++ code analysis in the background when files are opened or saved**

When selected (default), Visual Studio runs C++ code analysis in the background when you open or save a file.

**Show code analysis warnings in the editor**

When selected (default), Visual Studio shows squiggles for C++ code analysis warnings in the editor. If you modify the setting on this option and have open windows, the new setting affects only windows you open after the change.

**Enable diagnostic logging for C++ background code analysis**

When selected, Visual Studio supports diagnostic logging for C++ background code analysis. By default, this option isn't selected.

## Diagnostic logging

Options to support diagnostic logging for C/C++ are available in the **C/C++** > **IntelliSense** > **Diagnostic logging** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Diagnostic Logging** options under the **Text Editor** > **C/C++** > **Advanced** section.

> [!IMPORTANT]
> The following options are provided to assist with the collection of advanced information to help diagnose issues. 
> Unless you're requested to provide diagnostic logging data, the recommendation is to disable (clear) the options.

**Log diagnostic information to the output window**

When selected, Visual Studio sends diagnostic logging data to the output window.

**Logging level**

Use this option to set the logging verbosity, from 0 (most quiet) to 5 (most verbose - default).

**Logging filter**

Use this option to filter displayed event types by using a bitmask. Set the value by using a sum of any of the following event types:

| Value | Event type     |
|:-----:|----------------|
|   0   | None (Default) |
|   1   | General        |
|   2   | Idle           |
|   4   | WorkItem       |
|   8   | IntelliSense   |
|  16   | Assert         |
|  32   | Database       |
|  64   | Timing         |
| 128   | Statistics     |

Depending on the value, you might need to exit and restart Visual Studio.

## Error list

The following option supports the visibility of problem details. It's available in the **C/C++** > **Error list** section.

> [!NOTE]
> Earlier versions of Visual Studio provide the **Error List** option under the **Text Editor** > **C/C++** > **Advanced** section.

**Show the problem details window, if available, when navigating from the error list**

When selected (default), Visual Studio displays the **Problem Details** window when you double-click an issue to view associated details. The window is visible as you navigate from the Error List to the location of the issue in your source code.

## IntelliSense

<!-- In progress -->


## IntelliSense for nonproject files

Options to configure IntelliSense for standalone files when programming with C/C++ are available in the **C/C++** > **IntelliSense** > **Non-project files** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **IntelliSense and Browsing for Non-Project Files** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Enable IntelliSense for standalone files that aren't part of an existing project**

When selected (default), you can apply IntelliSense, browsing, and other features to standalone files that aren't part of an existing project. When this option is selected, you can configure the following options:

- **[Show IntelliSense errors in the editor](#show-intellisense-errors-in-the-editor)**
- **[Show IntelliSense errors in the error list](#show-intellisense-errors-in-the-error-list)**
- **[Suspend enabling IntelliSense for newly opened files while debugging](#suspend-enabing-intellisense-for-newly-opened-files-while-debugging)**

<a name="show-intellisense-errors-in-the-editor"></a>

**Show IntelliSense errors in the editor**

When selected, IntelliSense displays squiggles for errors in standalone nonproject files. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

<a name="show-intellisense-errors-in-the-error-list"></a>

**Show IntelliSense errors in the error list**

When selected, IntelliSense errors from standalone nonproject files display in the Error List. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

<a name="suspend-enabing-intellisense-for-newly-opened-files-while-debugging"></a>

**Suspend enabling IntelliSense for newly opened files while debugging**

When selected, IntelliSense isn't enabled for newly opened files while you're debugging. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

## References

Options to support references for C/C++ are available in the **C/C++** > **IntelliSense** > **References** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **References** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Highlight references to the symbol under the cursor**

When selected (default), Visual Studio highlights all references to the symbol that's currently under the cursor. The highlights are shown for content in the viewable space in the editor.

**Automatically determine the maximum number of find references threads to use based on system CPU cores count**

When selected, the **Maximum number of threads to use for finding references** value is automatically tuned based on the count of system CPU cores. If you prefer to specify the value manually, clear this option (default).

**Maximum number of threads to use for finding references** 

Use this option to specify the maximum number of concurrent threads the system can use for finding references. The value must be between 1 and 63.

When the **Automatically determine the maximum number of find references threads...** option is selected, the value of this option is determined for you by the system and can't be changed manually. To change the value, first clear the **Automatically determine the maximum number of find references threads...** option.

## Text editor

The **Text editor** options are available in the **C/C++** > **Text editor** section. 

> [!NOTE]
> Earlier versions of Visual Studio provide **Text Editor** options under the **Text Editor** > **C/C++** > **Advanced** section.

**Automatically surround selections when typing quotes or brackets**

Use this setting to control whether Visual Studio should automatically surround (enclose) your selections as you work in the editor. You can surround selections enclosed in brackets (square `[]`) or quotes (double `""` or single `''`), or all types.

For example, if you type an open quote or bracket, Visual Studio can automatically add the closing quote or bracket to enclose (surround) your selection. Choose from **Quotes only**, **Brackets Only**, **All** (default), or **Never**.

**Perform code formatting after surrounding the selection**

When selected (default), Visual Studio formats the code syntax within the enclosed section after it surrounds the selection.

**When surrounding the selection with a scope, expand to whole lines**

When selected (default), if you surround a selection within a scope (such as with parenthesis `()` or curly braces `{}`), the surround expands to contain the whole line.

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)
