---
title: Options, Text Editor, C and C++, Advanced
description: Learn how to use the Advanced options for C and C++ to change the behavior related to IntelliSense and the browsing database.
ms.date: 01/15/2026
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
monikerRange: '>=vs-2022'
---
# Options, Text Editor, C/C++, Advanced

:::moniker range="<=vs-2022"

By changing these options, you can define the behavior related to IntelliSense and the browsing database when you're programming in C or C++.

You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **Text Editor** > **C/C++** > **Advanced** section. Most of the settings have a True/False value option. To enable a setting, set the value to **True**.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio IDE elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

:::moniker-end
:::moniker range="visualstudio"

The options under **Text Editor** > **C/C++** > **Advanced** moved to other locations in Visual Studio 2026:

| Visual Studio 2022 | Visual Studio 2026 |
|---|---|
| **Brace Completion** | Languages > C/C++ > Text Editor > **[Brace completion](../configure-languages-c-cpp-text-editor.md#brace-completion)** |
| **Browsing/Navigation** | Languages > C/C++ > IntelliSense > **[Browsing & navigation](../configure-languages-c-cpp-intellisense.md#browsing-and-navigation)** |
| **Browsing Database Fallback** | Languages > C/C++ > IntelliSense > Browsing & navigation > **[Location](../configure-languages-c-cpp-intellisense.md#location-for-the-browsing-database)** |
| **Code Analysis** | Languages > C/C++ > **[Code analysis](../configure-c-cpp-advanced-options.md#code-analysis)** |
| **Diagnostic Logging** | Languages > C/C++ > IntelliSense > **[Diagnostic logging](../configure-languages-c-cpp-intellisense.md#diagnostic-logging)** |
| **Error List** | Languages > C/C++ > **[Error list](../configure-c-cpp-advanced-options.md#error-list)** |
| **IntelliSense** | Languages > C/C++ > **[IntelliSense](../configure-languages-c-cpp-intellisense.md#general-options)** |
| **IntelliSense and Browsing for Non-Project Files** | Languages > C/C++ > IntelliSense > **[Non-project files](../configure-languages-c-cpp-intellisense.md#non-project-files)** |
| **References** | Languages > C/C++ > IntelliSense > **[References](../configure-languages-c-cpp-intellisense.md#references)** |
| **Text Editor** | Languages > C/C++ > **[Text editor](../configure-languages-c-cpp-text-editor.md#general-options)**|

:::moniker-end

:::moniker range="<=vs-2022"

## Brace Completion

The following options configure brace completion when programming with C and C++.

- **Add Semicolon for Types**: When enabled, Visual Studio automatically inserts a semicolon after the closing brace for a type definition. The default is **True**.

- **Complete Parentheses in Raw String Literals**: When enabled, if you type an open parenthesis in a raw string literal, Visual Studio automatically adds the closing parenthesis. The default is **True**.

- **Complete Multiline Comments**: When enabled, Visual Studio automatically adds the completion syntax for multiline comments (comments that start with `/*`). The default is **True**.

## Browsing Database Fallback

The following options configure the browsing database location when programming with C and C++.

The "Fallback Location" is where the SDF and IntelliSense support files (for example, iPCH) are put when the primary location (same directory as solution) isn't used. This situation might occur when the user doesn't have the permissions to write to the solution directory or the solution directory is on a slow device. The default fallback location is in the user's temporary directory.

- **Always Use Fallback Location**: When enabled, indicates that the code browsing database and IntelliSense files should always be stored in a directory that you specify as your "Fallback Location" and not next to the solution (`.sln`) file. The IDE never tries to put the SDF or iPCH files next to the solution directory and always uses the Fallback Location. By default, this setting is disabled.

- **Do Not Warn If Fallback Location Used**: When enabled, Visual Studio doesn't provide a notification when a Fallback Location directory is used. Normally, you receive a notification when the Fallback Location is in use.

- **Fallback Location**: The "Fallback Location" is used as a secondary location to store the code browsing database or IntelliSense files. By default, your temporary directory is your Fallback Location. When the default is in use, the option value is set to NULL (0). To specify a different value, enter the directory path into the option value box.

   The IDE creates a subdirectory under the specified path (or the temporary directory) that includes the name of the solution along with a hash of the full path to the solution, which avoids issues with solution names being identical.

## Browsing/Navigation

The following options configure browsing and navigation when programming with C and C++.

> [!IMPORTANT]
> By default, the following options are disabled (**False**). Only enable these options in the rare case where a solution is so large that the database activity consumes an unacceptable amount of system resources.

- **Disable Database**: When enabled, the code browsing database (SDF), all other Browsing/Navigation options, and all IntelliSense features (except for the **#include Auto Complete** option) are disabled.

- **Disable Database Updates**: When enabled, the database is opened in read-only mode and no updates are performed while files are being edited. Most features continue to work. However, as edits are made, the data gets out of date, which leads to incorrect results.

- **Disable Database Auto Updates**: When enabled, the code browsing database isn't automatically updated when source files are modified. However, if you open **Solution Explorer**, open the shortcut menu for the project, and select **Rescan Solution**, all out-of-date files are checked and the database is updated.

- **Disable Implicit Files**: A project contains source files and header files that are explicitly specified. These files can contain references to other files that are external to the project (for example, `afxwin.h`, `windows.h`, and `atlbase.h`). The external files are referred to as _implicit files_ or _dependencies_.

   When enabled, the code browsing database doesn't collect data for the implicit files. The system doesn't index the files and some features aren't available for the files. Also, the **Disable Implicit Cleanup** and **Disable External Dependencies Folders** options are implicitly enabled.

- **Disable Implicit Cleanup**: When enabled, the code browsing database doesn't clean up implicit files that are no longer referenced. This option prevents implicit files from being removed from the database when they're no longer used. For example, if you add an `#include` directive that references the `mapi.h` header to a source file, the `mapi.h` file is found and indexed. If you later remove the `#include` syntax, and the header file isn't referenced elsewhere, information about the header file isn't removed. It remains available for future references.

   > [!NOTE]
   > If you explicitly rescan the solution, your setting for this option is ignored. For more information, see the **[Rescan Solution Interval](#rescan-solution-interval)** option. 

- **Disable External Dependencies Folders**: In **Solution Explorer**, each project can contain an _External Dependencies_ folder, which contains the list of all implicit files for that project. When enabled, Visual Studio doesn't create or update the _External Dependencies_ folder for each project.

- **Hide External Dependencies Folders**: When enabled, the _External Dependencies_ folder for projects isn't visible in **Solution Explorer**.

- **Recreate Database**: When enabled, Visual Studio recreates the code browsing database when the solution loads. The next time you load the solution, the existing SDF database file is deleted, recreated, and all files reindexed.

<a name="rescan-solution-interval"></a>

- **Rescan Solution Interval**: This option provides the run interval for the 'Rescan Solution Now' job. The default value is 60 minutes. Specify an interval between 0 and 5,000 minutes.

   While Visual Studio is rescanning the solution, file timestamps are checked to determine whether a file was changed outside of the IDE. (Changes made in the IDE are automatically tracked and files are updated.) Implicitly included files are checked to confirm existing references.

- **Disable Browsing Up-To-Date Check**: When enabled, Visual Studio doesn't wait for the code browsing database to be up-to-date when executing browsing operations.

- **Disable Current Item Selection**: When enabled, Visual Studio doesn't show information for the selected code element in the **Properties** tool window and elsewhere.

- **Display Skipped Regions for External Files**: When enabled, skipped regions from external files are included when Visual Studio displays browsing database errors.

- **Disable Fuzzy Matching**: Fuzzy matching finds close, not exact, matches to a search query. Rather than returning only exact matches, fuzzy matching also returns similar strings or code snippets that might not exactly match the input. You might see results with variations like typos or different casing.

   When enabled, Visual Studio returns only exact matches for your search input. When you enable fuzzy parsing, Visual Studio returns exact matches and also strings or code that match approximately.
 
- **Disable Solution Explorer Fuzzy Matching**: When enabled, searches in Solution Explorer return exact matches for your search input. When you enable fuzzy parsing in Solution Explorer, the search results include exact matches and similar matches for items in your solution.

## Code Analysis

The following options configure with code analysis.

- **Disable Background Code Analysis**: When enabled, Visual Studio doesn't run C++ code analysis in the background when you open or save a file.

- **Disable Code Analysis Squiggles**: When enabled, Visual Studio doesn't show squiggles for C++ code analysis warnings in the editor. Errors continue to display in the Error List window. If you modify the setting on this option and have open windows, the new setting affects only windows you open after the change.

- **Enable Code Analysis Logging**: When enabled, Visual Studio supports debug logging for C++ background code analysis.

## Diagnostic Logging

The following options configure the collection of advanced information to help diagnose issues.

> [!NOTE]
> Unless you're requested to provide diagnostic logging data, the recommendation is to disable the options.

- **Enable Logging**: When enabled, Visual Studio sends diagnostic logging data to the output window.

- **Logging Level**: Use this option to set the logging verbosity, from 0 (most quiet) to 5 (most verbose - default).

- **Logging Filter**: Use this option to filter displayed event types by using a bitmask. Set the value by using a sum of any of the following event types:

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

The following option assists with the collection of advanced information to help diagnose issues.

- **Show problem details on double click**: When enabled (default), Visual Studio displays the **Problem Details** window when you double-click an issue to view associated details. The window is visible as you navigate from the Error List window to the location of the issue in your source code.

## IntelliSense

The following options configure various IntelliSense features.

- **Auto Quick Info**: When enabled (default), QuickInfo tooltips display when you move the mouse pointer over text.

- **Disable IntelliSense**: When enabled, all IntelliSense features are disabled. The IDE doesn't create `VCPkgSrv.exe` processes to service IntelliSense requests, and no IntelliSense features work (QuickInfo, Member List, Auto Complete, Param Help). Semantic colorization and reference highlighting are also disabled. This option doesn't disable browsing features that rely solely on the database (including the Navigation Bar, ClassView, and Property window).

<a name="disable-auto-updating"></a>

- **Disable Auto Updating**: When enabled, IntelliSense updating is delayed until an actual request for IntelliSense is made. This delay can result in a longer execution time for the first IntelliSense operation on a file, but it can be helpful on slow or resource-constrained machines. 

   When enabled, the following options are also enabled (**True**) by default:

   - **[Disable Error Reporting](#disable-error-reporting)**
   - **[Disable Squiggles](#disable-squiggles)**

<a name="disable-error-reporting"></a>

- **Disable Error Reporting**: When enabled, IntelliSense errors aren't indicated with squiggles and they aren't displayed in the Error List window.

   Considerations for this option:

   - When enabled, background parsing for error reporting is disabled.
   - When enabled, the **[Disable Squiggles](#disable-squiggles)** option is also enabled (**True**) by default.
   - When the **[Disable Auto Updating](#disable-auto-updating)** option is enabled (**True**), this option is also enabled and unavailable for manual selection.

<a name="disable-squiggles"></a>

- **Disable Squiggles**: When enabled, IntelliSense errors aren't indicated with red "squiggles" in the editor window, but the error displays in the Error List window.

   Considerations for this option:

   - When the **[Disable Error Reporting](#disable-error-reporting)** option is enabled (**True**), this option is also enabled and unavailable for manual selection.
   - When the **[Disable Auto Updating](#disable-auto-updating)** option is enabled (**True**), this option is also enabled and unavailable for manual selection.

- **Auto Tune Max Cached Translation Units**: When enabled (default), the **Max Cached Translation Units** value is automatically tuned based on available system RAM. This action automatically sets the maximum number of translation units to keep active at any one time for IntelliSense requests. If you prefer to specify the value manually, disable this option (**False**).

   For more information about translation units, see [Phases of translation](/cpp/preprocessor/phases-of-translation).

- **Max Cached Translation Units**: Use this option to specify the maximum number of translation units to keep active at any one time for IntelliSense requests. The value must be between 2 and 64.

   When the **Auto Tune Max Cached Translation Units** option is enabled (**True**), the value of this option is determined for you by the system and can't be changed manually. To change the value, first set the **Auto Tune Max Cached Translation Units** option to **False**.

- **Disable #include Auto Complete**: When enabled, IntelliSense doesn't provide an autocompletion list for `#include` statements.

- **Use Forward Slash in #include Auto Complete**: When enabled (default), IntelliSense autocompletes `#include` statements when you specify the forward slash `/`. The default delimiter is backslash `\`. The compiler can accept either character, so use this option to indicate whether to use the forward slash for your code base.

- **Disable Aggressive Member List**: When enabled, IntelliSense doesn't show the member list while you type the name of a type or variable. The list appears only after you enter one of the commit characters specified in the **[Member List Commit Characters](#member-list-commit-characters)** option.

- **Disable Member List Keywords**: When enabled, IntelliSense doesn't show language keywords such as `void`, `class`, `switch` in member list suggestions.

- **Disable Member List Code Snippets**: When enabled, IntelliSense doesn't show code snippets in member list suggestions.

- **Member List Filter Mode**: Use this option to set the type of matching algorithm for filtering the member list. Choose from the following options:

   - **Fuzzy** (default): Find the most possible matches by using an algorithm similar to a spell-checker, which finds both approximate and identical matches.
   - **Smart**: Match substrings even if they're not at the start of a word.
   - **Prefix**: Only match identical substrings that start at the beginning of the word.
   - **None**: Don't use filtering.

- **Disable Semantic Colorization**: When enabled, IntelliSense turns off all code colorization, except for language keywords, strings, and comments.

<a name="member-list-commit-characters"></a>

- **Member List Commit Characters**: Use this option to specify the characters you can enter to commit the highlighted member list suggestion. You can add or remove characters from this list: `{}[]().,:;+-*/%&|^!=<>?@#\`.

- **Smart Member List Commit**: When enabled, after you select **Enter** at the end of a fully typed word to complete a commit, IntelliSense adds a new line.

- **Member List Commit Aggressive**: When enabled, the set of commit characters specified in the **[Member List Commit Characters](#member-list-commit-characters)** option are available for an _aggressively invoked_ member list.

- **Use Aggressive Member List for Auto Member List**: When enabled, and the _Auto Member List_ is shown, typing one of the characters specified in the **[Member List Commit Characters](#member-list-commit-characters)** option doesn't complete the commit.

- **Use Tab to commit in Aggressive Member List**: When enabled (default) and the _Aggressive Member List_ is shown, you can complete the commit by selecting **Tab**.

- **Use Tab to Insert Snippet**: When enabled (default), IntelliSense inserts a snippet when you select **Tab**, regardless of whether the member list is shown. One exception for this behavior is when the shortcut key is assigned to the `Edit.InvokeSnippetFromShortcut` action.

- **Disable Modules**: When enabled, IntelliSense displays various IDE features for C++20 Modules, such as automatic building of required modules.

- **Member List Filter Inaccessible**: When enabled (default), IntelliSense doesn't display inaccessible items in member lists.

- **Disable IntelliSense for Inactive Platforms**: When enabled, IntelliSense features are disabled for inactive platforms in folders and shared assets projects.

- **Enable Member List Dot-To-Arrow**: When enabled (default), after IntelliSense commits an item, it replaces `.` with an arrow `->`.

- **Disable Automatic Precompiled Header**: When enabled, IntelliSense doesn't use an _Automatic Precompiled Header_. Precompiled headers might speed up some IntelliSense operations, but the size of the solution cache on the hard drive increases.

- **Automatic Precompiled Header Cache Quota**: Use this option to specify the maximum size of the per-solution cache in megabytes. The actual usage might fluctuate around the specified value.

- **IntelliSense Process Memory Limit**: Use this setting to specify the maximum total memory usage of an IntelliSense process in megabytes.

- **Inactive Platform IntelliSense Limit**: Use this setting to specify the maximum number of inactive platforms that are processed for IntelliSense. The value must be between 1 and 16.

- **Enable Template IntelliSense**: When enabled (default), if the cursor is active within a template body, IntelliSense displays a bar in the editor that you can use to configure the IntelliSense attributes for the template.

- **Enable Help Link on Quick Info**: When enabled (default), IntelliSense supports linking to online searches on the Quick Info tooltip.

- **Use Web Search on Quick Info Help Link**: When enabled (default), IntelliSense launches a web search with the specified search provider to support online searches in the Quick Info tooltip. If you disable (**False**) the option, IntelliSense supports **F1** Help.

- **Search Provider**: Use the option to specify the URL to target for online help on errors. By default, the value is set to `https://www.bing.com/search?q={0}`. When you access the link from the IDE, IntelliSense replaces the `{0}` portion of the link with the error to search.

## IntelliSense and Browsing for Non-Project Files

The following options configure IntelliSense features for nonproject files when programming with C and C++.

- **Enable Enhanced Single File**: When enabled (default), IntelliSense, browsing, and other features are enabled for standalone files that aren't part of an existing project. When this option is enabled (**True**), you can configure the following options:

   - **[Enable IntelliSense Squiggles](#enable-intellisense-squiggles)**
   - **[Show IntelliSense Errors In Error List](#show-intellisense-errors-in-error-list)**
   - **[Suspend New Files During Debugging](#suspend-new-files-during-debugging)**

<a name="enable-intellisense-squiggles"></a>

- **Enable IntelliSense Squiggles**: When enabled, IntelliSense squiggles display for standalone nonproject files. By default, this option is set to **False**. When the **Enable Enhanced Single File** option is disabled (**False**), this option is ignored and unavailable for manual selection.

<a name="show-intellisense-errors-in-error-list"></a>

- **Show IntelliSense Errors In Error List**: When enabled, IntelliSense errors from standalone nonproject files display in the Error List window. By default, this option is set to **False**. When the **Enable Enhanced Single File** option is disabled (**False**), this option is ignored and unavailable for manual selection.

<a name="suspend-new-files-during-debugging"></a>

- **Suspend New Files During Debugging**: When enabled, IntelliSense isn't enabled for newly opened files while you're debugging. By default, this option is set to **False**. When the **Enable Enhanced Single File** option is disabled (**False**), this option is ignored and unavailable for manual selection.

## References

The following options configure references when programming with C and C++.

- **Disable Reference Highlighting**: By default, when you select some text in the editor, including code and symbols, all instances of the same text are automatically highlighted in the current file. To disable automatic highlighting, set this option to **True**. The default value is **False**.

- **Auto Tune Max Find References Threads**: When enabled (default), the **Max Find References Threads** value is automatically tuned based on the number of CPU cores. If you prefer to specify the value manually, disable this option (**False**).

- **Max Find References Threads**: Use this option to specify the maximum number of concurrent threads the system can use for finding references. The value must be between 1 and 63.

   When the **Auto Tune Max Find References Threads** option is enabled (**True**), the value of this option is determined for you by the system and can't be changed manually. To change the value, first set the **Auto Tune Max Find References Threads** option to **False**.

## Text Editor

The following options configure automatic formatting actions in the code editor when programming with C and C++.

- **Auto Surround Mode**: Use this setting to control whether Visual Studio automatically surrounds (encloses) your selections as you work in the editor. You can surround selections enclosed in brackets (square `[]`) and quotes (double `""` or single `''`).

   For example, if you type an open quote or bracket, Visual Studio can automatically add the closing quote or bracket to enclose (surround) your selection. Choose from **Quotes only**, **Brackets Only**, **All** (default), or **Never**.

- **Format After Auto Surround**: When enabled, Visual Studio formats the code syntax within the enclosed section after the selection is automatically surrounded. The default is **True**.

- **Expand Selection for Surround Scopes**: When enabled, if you surround a selection that appears within a brace scope `{ ... }`, the surround expands to the whole line. The default is **True**.

   If your selection doesn't start and end on whole lines, Visual Studio automatically expands the selection to whole lines before inserting `{ ... }`. This approach avoids wrapping partial lines within the braces.

## Related content

- [Setting language-specific editor options](/previous-versions/visualstudio/visual-studio-2017/ide/reference/setting-language-specific-editor-options)

:::moniker-end