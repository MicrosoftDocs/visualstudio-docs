---
title: Configure IntelliSense Options for C and C++
description: Configure IntelliSense language settings for C and C++ in the Tools Options pane. Change options for tooltips, browsing and navigation, references, refactoring diagnostic logging, nonproject files, and more.
ms.date: 01/09/2026
ms.topic: how-to
helpviewer_keywords:
  - "Languages Options, IntelliSense"
ms.custom: "ide-ref"
author: GitHubber17
ms.author: twhitney
manager: coxfordf
monikerRange: 'visualstudio'
---
# Configure Languages > C/C++ > IntelliSense options

This article describes how to modify IntelliSense settings for C and C++. You can access the settings by selecting **Tools** > **Options** from the Visual Studio menu bar and expanding the **All Settings** > **Languages** > **C/C++** > **IntelliSense** section.

These options let you define the IntelliSense behavior for C and C++. Configure tooltips, browsing and navigation, references, refactoring, diagnostic logging, nonproject files, and more.

## General options

The following options are available in the **C/C++** > **IntelliSense** section.

> [!NOTE]
> Earlier versions of Visual Studio provide similar options under the **Text Editor** > **C/C++** > **Advanced** > **IntelliSense** section.

- **Enable IntelliSense**: When selected (default), IntelliSense features are available to support C and C++ programming. This option must be enabled to configure the other settings in this section. <!-- VS 22 = Disable IntelliSense -->

   If you clear this option, all IntelliSense features are disabled and no IntelliSense features work (QuickInfo, Member List, Auto Complete, Param Help). Semantic colorization and reference highlighting are also disabled. This option doesn't disable browsing features that rely solely on the database (including the Navigation Bar, ClassView, and Property window).

- **Use 64-bit IntelliSense engine**: When selected, Visual Studio runs the 64-bit IntelliSense engine rather than the 32-bit engine, which is helpful for large projects and projects that include large SDKs. By default, this option is cleared.

- **Automatically update IntelliSense as you type**: When selected (default), IntelliSense continuously parses and analyzes your code in real-time as you type. If you clear this option, IntelliSense only updates when you explicitly request it. An explicit request might be desirable in very large code bases where the system becomes sluggish while you type. The delay can result in a longer execution time for the first IntelliSense operation on a file, but it can be helpful on slow or resource-constrained machines. <!-- VS 22 = Disable Auto Updating, Disable Error Reporting, Disable Squiggles -->

   Other consequences of disabling the feature include:

   - Background parsing for error reporting is disabled.
   - IntelliSense errors aren't indicated with squiggles.
   - IntelliSense errors aren't displayed in the Error List window.

- **Automatically determine the maximum number of translation units to cache based upon available system memory**: When selected (default), IntelliSense automatically tunes the **Maximum number of translation units that will be kept active at a time for IntelliSense requests** value based on available system RAM. This action automatically sets the maximum number of translation units to keep active at any one time for IntelliSense requests. If you prefer to specify the value manually, clear this option. <!-- VS 22 = Auto Tune Max Cached Translation Units -->

   For more information about translation units, see [Phases of translation](/cpp/preprocessor/phases-of-translation).

- **Maximum number of translation units that will be kept active at a time for IntelliSense requests**: Use this option to specify the maximum number of translation units to keep active at any one time for IntelliSense requests. The value must be between 2 and 64. <!-- VS 22 = Max Cached Translation Units -->

   When the **Automatically determine the maximum number of translation units to cache based upon available system memory** option is enabled, the value of this option is determined for you by the system and can't be changed manually. To change the value, first clear the **Automatically determine the maximum number of translation units ...** option.

- **Show completion list for #include statements**: When selected (default), IntelliSense provides an autocompletion list for `#include` statements. <!-- VS 22 = Disable #include Auto Complete -->

- **Use forward slash as the folder delimiter for #include completion statements**: When selected (default), IntelliSense autocompletes `#include` statements when you specify the forward slash `/`. The default delimiter is backslash `\`. The compiler can accept either character, so use this option to indicate whether to use the forward slash for your code base. <!-- VS 22 = Use Forward Slash in #include Auto Complete -->

   When the **Show completion list for #include statements** option isn't selected, this option isn't available.

- **Colorize tokens based on IntelliSense classifications**: When selected (default), IntelliSense uses token colorization based on standard classifications, including language keywords, strings, and comments. <!-- VS 22 = Disable Semantic Colorization -->

- **Expand snippets when tab is pressed**: When selected (default), IntelliSense expands a snippet when you select **Tab**, regardless of whether the member list is shown. One exception for this behavior is when the shortcut key is assigned to the `Edit.InvokeSnippetFromShortcut` action. <!-- VS 22 = Use Tab to Insert Snippet -->

- **Enable IntelliSense for C++20 modules**: When selected (default), IntelliSense displays various IDE features for C++20 Modules, such as automatic building of required modules. <!-- VS 22 = Disable Modules -->

- **Enable IntelliSense for inactive platforms in folders and shared assets projects**: When selected (default), IntelliSense features are enabled for inactive platforms in folders and shared assets projects. <!-- VS 22 = Disable IntelliSense for Inactive Platforms -->

- **Maximum number of inactive platforms that will be processed for IntelliSense**: Use this setting to specify the maximum number of inactive platforms that are processed for IntelliSense. The value must be between 1 and 16. <!-- VS 22 = Inactive Platform IntelliSense Limit -->

   When the **Enable IntelliSense for inactive platforms in folders and shared assets projects** option isn't selected, this option isn't available.

- **Automatically generate precompiled headers for IntelliSense**: When selected (default), IntelliSense uses the _Automatic Precompiled Header_. Although the use of the header can speed up some IntelliSense operations, the faster action can increase expenses for a per-solution hard drive cache. <!-- VS 22 = Disable Automatic Precompiled Header -->

- **Maximum size of the per-solution precompiled header cache in megabytes**: Use this option to specify the maximum size of the per-solution cache in megabytes. The actual usage might fluctuate around the specified value. <!-- VS 22 = Automatic Precompiled Header Cache Quota -->

   When the **Automatically generate precompiled headers for IntelliSense** option isn't selected, this option isn't available.

- **Maximum total memory usage of an IntelliSense process in megabytes**: Use this setting to specify the maximum total memory usage of an IntelliSense process in megabytes. <!-- VS 22 = IntelliSense Process Memory Limit -->

- **Display a bar in the editor to configure IntelliSense inside templates**: When selected (default), if the cursor is active within a template body, IntelliSense displays a bar in the editor that you can use to configure the IntelliSense attributes for the template. <!-- VS 22 = Enable Template IntelliSense -->

- **Style for #include suggestions**: Use this option to specify the style for IntelliSense to use when providing suggestions for `#include` statements. Choose from **Core Guidelines** (default), **Quotes**, or **Angle brackets**.

## Quick info

The following options are available in the **C/C++** > **IntelliSense** > **Quick info** section.

> [!NOTE]
> Earlier versions of Visual Studio provide similar options under the **Text Editor** > **C/C++** > **Advanced** > **IntelliSense** section.

- **Show data structure's size and alignment in tooltips**: When selected (default), IntelliSense shows the size and alignment of a data structure in tooltips. If you clear this option, the **Show size and alignment for variables** option isn't available. <!-- VS 22 = Auto Quick Info -->

- **Show size and alignment for variables**: When selected, IntelliSense shows the size and alignment for variables in tooltips. By default, this option is cleared. If the **Show data structure's size and alignment in tooltips** option isn't selected, this option isn't available.

- **Show help link**: When selected (default), IntelliSense supports linking to online searches on the Quick Info tooltip. <!-- VS 22 = Enable Help Link on Quick Info -->

- **Use web search for help link**: When selected (default), IntelliSense launches a web search with the specified search provider to support online searches in the Quick Info tooltip. If you disable (**False**) the option, IntelliSense supports **F1** Help. <!-- VS 22 = Use Web Search on Quick Info Help Link -->

- **URL used for web searches**: Use the option to specify the URL to target for online help on errors. By default, the value is set to `https://www.bing.com/search?q={0}`. When you access the link from the IDE, IntelliSense replaces the `{0}` portion of the link with the token or error string from the tooltip. <!-- VS 22 = Search Provider -->

- **Doxygen tags to display on Quick Info tooltips**: Use this option to identify the set of [Doxygen command tags](https://www.doxygen.nl/manual/commands.html) that IntelliSense can use when displaying Quick Info tooltips. By default, the set includes the `param`, `tparam`, `returns`, `deprecated`, and `exception` tags, in this order. Use the **Add**, **Remove**, and **Move Up/Down** actions to modify the list as needed.

## Completion list

The following options are available in the **C/C++** > **IntelliSense** > **Completion list** section.

- **Automatically select matches after typing a scope or invoking the completion list**: When selected (default), IntelliSense automatically selects matches after you type a scope or invoke the completion list. 

- **Show suggestions as you type**: When selected (default), IntelliSense shows suggestions as you type, and the suggestions don't automatically select matches in the current context. 

- **Commit the item by pressing one of the commit characters**: When selected, you can apply a suggestion by using any character specified in the **[Characters that will commit the selected suggestion](#commit-characters)** option. By default, this option is cleared. 

   When the **Show suggestions as you type** option isn't enabled, this option isn't available. 

- **When an item is highlighted but not selected commit the item by pressing Tab**: When selected (default), you can select **Tab** to commit a highlighted item that isn't also selected. <!-- VS 22 = Use Tab to commit in Aggressive Member List -->

<a name="commit-characters"></a>

- **Characters that will commit the selected suggestion**: Use this option to specify the characters you can enter to commit the highlighted suggestion. You can add or remove characters from this list: `{}[]().,:;+-*/%&|^!=<>?@#\`. <!-- VS 22 = Member List Commit Characters -->

- **Type of filtering**: Use this option to set the type of matching algorithm for filtering. Choose from the following options: <!-- VS 22 = Member List Filter Mode -->

   - **Fuzzy** (default): Find the most possible matches by using an algorithm similar to a spell-checker, which finds both approximate and identical matches.
   - **Smart**: Match substrings even if they're not at the start of a word.
   - **Prefix**: Only match identical substrings that start at the beginning of the word.
   - **None**: Don't use filtering.

- **Show language keywords**: When selected (default), IntelliSense shows language keywords like `void`, `class`, `switch` in suggestions. <!-- VS 22 = Disable Member List Keywords -->

- **Show code snippets**: When selected (default), IntelliSense shows code snippets in suggestions. <!-- VS 22 = Disable Member List Code Snippets -->

- **Show inaccessible items**: When selected, IntelliSense displays inaccessible items. By default, this option is cleared. <!-- VS 22 = Member List Filter Inaccessible -->

- **Replace '.' with '->' when applicable after committing an item**: When selected (default), after IntelliSense commits an item, it replaces any period `.` character with an arrow `->` (dash and angle bracket). <!-- VS 22 = Enable Member List Dot-To-Arrow -->

- **Add a new line when pressing Enter to commit a fully typed word**: When selected, after you select **Enter** at the end of a fully typed word to complete a commit, IntelliSense adds a new line. By default, this option is cleared. <!-- VS 22 = Smart Member List Commit -->

- **Provide context-aware list of suggestions**: When selected (default), IntelliSense shows a context-aware list of suggestions as you type. A maximum of 10 suggestions can be shown at a time. The suggestions change if they match what you type. 

- **Provide extended context-aware list of suggestions for enum types**: When selected (default), IntelliSense shows an extended list of context-aware suggestions as you type to support `enum` types. These suggestions are for completing cases like `switch case` labels, `return` statements, and comparison operations between `enum` types. 

   When the **Provide context-aware list of suggestions** option isn't enabled, this option isn't available. 

## Browsing and navigation

General options to configure browsing and navigation are available in the **C/C++** > **IntelliSense** > **Browsing & navigation** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Browsing/Navigation** options under the **Text Editor** > **C/C++** > **Advanced** section.

> [!IMPORTANT]
> The following options are disabled by default (**False**) and the recommendation is to leave them unchanged.
> In the rare case where a solution is so large that the database activity consumes an unacceptable amount of system resources, enable the necessary options only.

- **Cache code browsing information**: When selected (default), the code browsing database (SDF), all browsing and navigation options, and all IntelliSense features are available.

   If you clear this option, all use of the code browsing database and all IntelliSense features except for `#include Auto Complete` are disabled.

- **Enable updates to the code browsing database**: When selected (default), the database is opened in read-write mode and updates can be performed while files are being edited.

   If you clear this option, the database is opened in read-only mode and no updates are performed while files are being edited. Most features continue to work. However, as edits are made, the data becomes stale, and you experience incorrect results.

- **Update code browsing information as you type**: When selected (default), the code browsing database is automatically updated when source files are modified.

   If you clear this option, the code browsing database isn't automatically updated when source files change. However, if you open **Solution Explorer**, open the shortcut menu for the project, and select **Rescan Solution**, all out-of-date files are checked and the database is updated.

- **Recreate the code browsing database the next time the solution is loaded**: When selected, Visual Studio recreates the code browsing database when the solution loads. The next time you load the solution, the existing SDF database file is deleted, recreated, and all files reindexed. By default, this option isn't selected.

<a name="rescan-solution-interval"></a>

- **Interval to rescan solution (in minutes)**: This option provides the run interval for the 'Rescan Solution Now' job. The default value is 60 minutes. You must specify an interval between 0 and 5,000 minutes.

   While Visual Studio is rescanning the solution, file timestamps are checked to determine whether a file was changed outside of the IDE. (Changes made in the IDE are automatically tracked and files are updated.) Implicitly included files are checked to confirm existing references.

- **Wait for the browsing database to be up-to-date when executing browsing operations**: When selected, Visual Studio waits for the code browsing database to be up-to-date when executing browsing operations. By default, this option isn't selected.

- **Show information for the selected code element in the properties window**: When selected, Visual Studio shows information for the selected code element in the **Properties** tool window and elsewhere. By default, this option isn't selected.

<a name="highlight-macros-inside-skipped-regions"></a>

- **Choose how to highlight macros that are inside regions skipped by the browsing database**: Use this option to specify how to highlight macros inside regions that the browsing database skips. Choose from **Suggestion** (default), **Warning**, **Error**, or **None**. For more information about hint files, see [Hint files](/cpp/build/reference/hint-files?view=msvc-180&preserve-view=true).

- **Include skipped regions from external files when displaying browsing database errors**: When selected, skipped regions from external files are included when Visual Studio displays browsing database errors. By default, this option isn't selected.

- **Use fuzzy matching to provide search results**: Fuzzy matching helps locate approximate matches to search input. Rather than returning exact matches only, fuzzy matching also returns similar strings or code snippets that might not exactly match the input. You might see results with variations like typos or different casing.

   When selected (default), Visual Studio returns both exact matches and approximate matches, including strings and code snippets. If you clear this option, only exact matches are returned.
 
- **Enable fuzzy match results when searching in the solution explorer**: When selected (default), a search in Solution Explorer returns both exact matches and approximate matches for items in your solution. If you clear this option, the search returns only exact matches in your solution.

- **Allow for fuzzy navigation to declarations or definitions after the signatures have changed**: Visual Studio 2026 offers a combination of ranked, tolerant matching with completion filtering to help reduce friction when navigating in the IDE. These enhancements make it possible to access current declarations or definitions from older references based on outdated signatures.

   When selected (default), Visual Studio supports fuzzy navigation to current declarations and definitions. If you clear this option, you can't jump to a current declaration or definition from an older reference based on an outdated signature.

- **Save code browsing information for external dependencies**: A project contains source files and header files that are explicitly specified. These files can contain references to other files that are external to the project (for example, `afxwin.h`, `windows.h`, and `atlbase.h`). The external files are referred to _dependencies_ or _implicit files_.  

   When selected (default), the code browsing database collects data for the external dependencies that aren't specified in a project. The system finds these files and also indexes them for various browsing features (including Navigate To). 

   If you clear this option, the external dependencies aren't indexed, and some features aren't available for the files, including:

   - **[Periodically scan external dependencies and remove unused files from database](#scan-external-dependencies)**
   - **[Evaluate external dependencies graph](#eval-external-dependencies)**
   - **[Show external dependencies in solution explorer](#show-external-dependencies)**

<a name="scan-external-dependencies"></a>

- **Periodically scan external dependencies and remove data for files that are no longer included from the code browsing database**: When selected (default), Visual Studio periodically scans the external dependencies and removes data for unused files from the code browsing database. This option ensures implicit files are removed from the database when they're no longer used. For example, if you add an `#include` directive that references the `mapi.h` header to a source file, the `mapi.h` file is found and indexed. If you later remove the `#include` syntax, and the header file isn't referenced elsewhere, Visual Studio detects the unused file and removes the related date from the database.

   If you clear this option, Visual Studio doesn't complete the period scans or updates to the database.

   > [!NOTE]
   > If you explicitly rescan the solution, your setting for this option is ignored. For more information, see the **[Rescan Solution Interval](#rescan-solution-interval)** option. 

<a name="eval-external-dependencies"></a>

- **Evaluate external dependencies graph**: In **Solution Explorer**, each project can contain an _External Dependencies_ folder, which contains the list of all implicit files for that project. When selected (default), Visual Studio identifies the external dependencies for the project and creates or updates the folder. If you clear this option, Visual Studio doesn't update the folder contents.

<a name="show-external-dependencies"></a>

- **Show external dependencies in solution explorer**: When selected (default), the _External Dependencies_ folder for projects is visible in **Solution Explorer**. If you clear this option, the folder isn't visible.

### Location for the browsing database

Options to configure the browsing database location are available in the **C/C++** > **IntelliSense** > **Browsing & navigation** > **Location** section.

> [!NOTE]
> Earlier versions of Visual Studio provide similar options under the **Text Editor** > **C/C++** > **Advanced** section in the **Browsing Database Fallback** category.

By default, the primary location for the SDF and IntelliSense support files (for example, iPCH) is the solution directory folder. If this location isn't available, your temporary directory is used as the default secondary location. This scenario can occur if you don't have the permissions to write to the solution directory or the solution directory is on a slow device.

You can use the following settings to identify a custom secondary location, or specify a custom location to always use as the primary location. For the secondary location, the IDE creates a subdirectory under the custom location (or the temporary directory). The secondary location includes the name of the solution along with a hash of the full path to the solution, which avoids issues with solution names being identical.

- **Always use the specified custom location for the browsing database**: When selected, Visual Studio always uses the secondary location specified in the **Custom location for browsing database files** option as the primary location for the browsing database. When this option isn't selected (default), it uses the default primary location, the solution directory folder.

- **Custom location for browsing database files**: Use this option to specify a custom folder for Visual Studio to use as the secondary location for the browsing database location.

   This folder is also used if the default primary location is currently unavailable. When no location is specified, Visual Studio uses the user's temporary directory as the default secondary location.

## Errors

These options are available in the **C/C++** > **IntelliSense** > **Errors** section.

- **Show IntelliSense errors in the error list window**: When selected (default), Visual Studio shows IntelliSense errors in the Error List window.

- **Show IntelliSense errors in the editor**: When selected (default), Visual Studio shows IntelliSense errors in the editor directly.

- **Suggest fixes for IntelliSense errors**: When selected (default), Visual Studio suggests fixes for IntelliSense errors.

- **Maximum number of threads to use for looking up suggestions**: Use this option to specify the maximum number of threads for IntelliSense to use when looking up suggestions. The value must be between 1 and 16.

- **Maximum number of errors to lookup fixes for**: Use this option to specify the maximum number of errors for which IntelliSense should lookup fixes. The value must be between 1 and 1,000.

## Refactoring

These options are available in the **C/C++** > **IntelliSense** > **Refactoring** section.

- **Offer suggestions to create missing function declarations or definitions**: When selected (default), IntelliSense provides suggestions for how to create function declarations or definitions that are missing.

- **Choose how to highlight functions that can have their declaration or definition generated**: Use this option to specify how IntelliSense should highlight functions that can a missing declaration or definition generated by the system. Choose from **Suggestion** (default), **Warning**, **Error**, or **Refactoring only**. When the **Offer suggestions to create missing function declarations or definitions** option isn't selected, this option isn't available for selection.

- **Navigation action for the generated code after a refactoring operation**: Use this option to specify the next action for IntelliSence after generating code for a refactor operation. Choose from **Open document** (default), **Peek document**, or **None**.

- **Choose how to highlight types that can have member functions generated**: Use this option to specify how IntelliSence should highlight types that can have member functions generated. Choose from **Suggestion**, **Warning**, **Error**, or **Refactoring only** (default).

- **Choose how to highlight global functions that can be made static**: Use this option to specify how IntelliSence should highlight global functions that can be made static. Choose from **Suggestion** (default), **Warning**, **Error**, or **None**.

<a name="highlight-macros-convert-constexpr"></a>

- **Choose how to highlight macro definitions that are able to be converted to equivalent constexpr definitions**: Use this option to specify how IntelliSence should highlight macro definitions that can be converted to equivalent `constexpr` definitions. Choose from **Suggestion** (default), **Warning**, **Error**, or **None**.

## Inlay hints

The following options are available in the **C/C++** > **IntelliSense** > **Inlay hints** section.

- **Enable background processing of inlay hints information**: When selected (default), inlay hints provide more context about call sites and deduced types directly in the source code. When you enable this option, the other options in the section are made available for configuration.

- **Display inlay hints in the editor**: When selected, IntelliSense displays the inlay hints in the editor. By default, this option is cleared. When the **Enable background processing of inlay hints information** option isn't selected, this option isn't available for selection.

- **Press Ctrl twice to toggle inlay hints**: When selected, you can select **Ctrl** twice to toggle visibility of the inlay hints. By default, this option is cleared. When the **Enable background processing of inlay hints information** option isn't selected, this option isn't available for selection.

- **Show the deduced type when 'auto' is used in a declaration**: When selected (default), IntelliSense shows the deduced type for a declaration when it uses the `auto` keyword. By default, this option is enabled. When the **Enable background processing of inlay hints information** option isn't selected, this option isn't available for selection.

- **Type hints will cover the 'auto' keyword instead of being shown next to it**: When selected, IntelliSense shows the hint for the deduced type in place of the `auto` keyword rather than next to the keyword. By default, this option is cleared. When the **Enable background processing of inlay hints information** option isn't selected, this option isn't available for selection.

- **Show parameter name inline at call sites**: When selected (default), IntelliSense shows the parameter name inline at the source code location where the call is made to the parameter. When the **Enable background processing of inlay hints information** option isn't selected, this option isn't available for selection.

- **Add '&' to hints to indicate when a parameter is passed by non-const reference**: When selected (default), IntelliSense adds the ampersand `&` to hints when a reference passes a parameter without the `const` keyword. When the **Show parameter name inline at call sites** option isn't selected, this option isn't available for selection.

- **Don't show a hint when the argument text (including inline comments) contains the parameter name**: When selected (default), IntelliSense doesn't show a hint when the argument text contains the parameter name, including when the text appears within inline comments. When the **Show parameter name inline at call sites** option isn't selected, this option isn't available for selection.

## Non-project files

Options to configure IntelliSense for standalone, nonproject files are available in the **C/C++** > **IntelliSense** > **Non-project files** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **IntelliSense and Browsing for Non-Project Files** options under the **Text Editor** > **C/C++** > **Advanced** section.

- **Enable IntelliSense for standalone files that aren't part of an existing project**: When selected (default), you can apply IntelliSense, browsing, and other features to standalone files that aren't part of an existing project. When this option is selected, you can configure the following options:

   - **[Show IntelliSense errors in the editor](#show-intellisense-errors-in-the-editor)**
   - **[Show IntelliSense errors in the error list](#show-intellisense-errors-in-the-error-list)**
   - **[Suspend enabling IntelliSense for newly opened files while debugging](#suspend-enabing-intellisense-for-newly-opened-files-while-debugging)**

<a name="show-intellisense-errors-in-the-editor"></a>

- **Show IntelliSense errors in the editor**: When selected, IntelliSense displays squiggles for errors in standalone nonproject files. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

<a name="show-intellisense-errors-in-the-error-list"></a>

- **Show IntelliSense errors in the error list**: When selected, IntelliSense errors from standalone nonproject files display in the Error List window. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

<a name="suspend-enabing-intellisense-for-newly-opened-files-while-debugging"></a>

- **Suspend enabling IntelliSense for newly opened files while debugging**: When selected, IntelliSense isn't enabled for newly opened files while you're debugging. By default, this option is cleared. When the **Enable IntelliSense for standalone files that aren't part of an existing project** option is cleared, this option is ignored and unavailable for manual selection.

## References

Options to support references for C and C++ projects are available in the **C/C++** > **IntelliSense** > **References** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **References** options under the **Text Editor** > **C/C++** > **Advanced** section.

- **Highlight references to the symbol under the cursor**: When selected (default), Visual Studio highlights all references to the symbol that's currently under the cursor. The highlights are shown for content in the viewable space in the editor.

- **Automatically determine the maximum number of find references threads to use based on system CPU cores count**: When selected, the **Maximum number of threads to use for finding references** value is automatically tuned based on the count of system CPU cores. If you prefer to specify the value manually, clear this option (default).

- **Maximum number of threads to use for finding references**: Use this option to specify the maximum number of concurrent threads the system can use for finding references. The value must be between 1 and 63.

   When the **Automatically determine the maximum number of find references threads...** option is selected, the value of this option is determined for you by the system and can't be changed manually. To change the value, first clear the **Automatically determine the maximum number of find references threads...** option.

## Diagnostic logging

Options to support diagnostic logging for C and C++ are available in the **C/C++** > **IntelliSense** > **Diagnostic logging** section.

> [!NOTE]
> Earlier versions of Visual Studio provide **Diagnostic Logging** options under the **Text Editor** > **C/C++** > **Advanced** section.

> [!IMPORTANT]
> The following options are provided to assist with the collection of advanced information to help diagnose issues. 
> Unless you're requested to provide diagnostic logging data, the recommendation is to disable (clear) the options.

- **Log diagnostic information to the output window**: When selected, Visual Studio sends diagnostic logging data to the output window.

- **Logging level**: Use this option to set the logging verbosity, from 0 (most quiet) to 5 (most verbose - default).

- **Logging filter**: Use this option to filter displayed event types by using a bitmask. Set the value by using a sum of any of the following event types:

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

## Related content

- [Using IntelliSense](using-intellisense.md)
