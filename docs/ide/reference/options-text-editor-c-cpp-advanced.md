---
title: Options, Text Editor, C/C++, Advanced
description: Learn how to use the Advanced page in the C/C++ section to change the behavior related to IntelliSense and the browsing database.
ms.date: 10/08/2021
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
---
# Options, Text Editor, C/C++, Advanced

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++.

To access this page, in the **Options** dialog box, in the left pane, expand **Text Editor**, expand **C/C++**, and then choose **Advanced**.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md).

## Brace Completion

**Add Semicolon for Types**

Semicolons will be inserted after closing braces for types.

**Complete Parentheses in Raw String Literals**

If an open parenthesis is typed in a raw string literal, it will be completed with a closing parenthesis.

**Complete Multiline Comments**

Multiline comments (comments that start with `/*`) will be completed.

## Browsing Database Fallback

The fallback location is where the SDF and IntelliSense support files (for example, iPCH) are put when the primary location (same directory as solution) isn't used. This situation could occur the user doesn't have the permissions to write to the solution directory or the solution directory is on a slow device. The default fallback location is in the user's temp directory.

**Always Use Fallback Location**

Indicates that the code browsing database and IntelliSense files should always be stored in a folder that you specify as your "Fallback Location", not next to the .sln file. The IDE will never try to put the SDF or iPCH files next to the solution directory and will always use the fallback location.

**Do Not Warn If Fallback Location Used**

You aren't informed or prompted if a 'Fallback Location' is used. Normally, the IDE will tell you if it had to use the fallback location. This option turns off that warning.

**Fallback Location**

This value is used as a secondary location to store the code browsing database or IntelliSense files. By default, your temporary directory is your fallback location. The IDE will create a subdirectory under the specified path (or the temp directory) that includes the name of the solution along with a hash of the full path to the solution, which avoids issues with solution names being identical.

## Browsing/Navigation

You should never choose these options except in the rare case where a solution is so large that the database activity consumes an unacceptable amount of system resources.

**Disable Database**

All use of the code browsing database (SDF), all other Browsing/Navigation options, and all IntelliSense features except for #include Auto Complete are disabled.

**Disable Database Updates**

The database will be opened read-only, and no updates will be performed as files are edited. Most features will still work. However, as edits are made, the data will become stale, and you'll get incorrect results.

**Disable Database Auto Updates**

The code browsing database won't be automatically updated when source files are modified. However, if you open **Solution Explorer**, open the shortcut menu for the project, and then choose **Rescan Solution**, all out-of-date files will be checked, and the database will be updated.

**Disable Implicit Files**

The code browsing database doesn't collect data for files that aren't specified in a project. A project contains source files and header files that are explicitly specified. Implicit files are included by explicit files (for example, afxwin.h, windows.h, and atlbase.h). Normally, the system finds these files and also indexes them for various browsing features (including Navigate To). If you choose this option, those files aren't indexed, and some features aren't available for them. If you choose this option, "Disable Implicit Cleanup" and "Disable External Dependencies" are also implicitly chosen.

**Disable Implicit Cleanup**

The code browsing database doesn't clean up implicit files that are no longer referenced. This option prevents implicit files from being removed from the database when they're no longer used. For example, if you add an `#include` directive that references mapi.h to one of your source files, mapi.h will be found and indexed. If you then remove the #include and the file isn't referenced elsewhere, information about it will eventually be removed unless you choose this option. (See the **Rescan Solution Interval** option.) This option is ignored when you  explicitly rescan the solution.

**Disable External Dependencies Folders**

The External Dependencies folder for each project isn't created or updated. In **Solution Explorer**, each project contains an External Dependencies folder, which contains all implicit files for that project. If you choose this option, that folder doesn't appear.

**Recreate Database**

Recreate the code browsing database from nothing the next time that the solution loads. If you choose this option, the SDF database file is deleted the next time you load the solution, thus causing the database to be recreated and all files indexed.

**Rescan Solution Interval**

A 'Rescan Solution Now' job is scheduled for the interval that you specify. You must specify between 0 and 5000 minutes. The default value is 60 minutes. While the solution is rescanned, file timestamps are checked to determine whether a file was changed outside of the IDE. (Changes that are made in the IDE are automatically tracked, and files are updated.) Implicitly included files are checked to determine whether they're all still referenced.

**Disable Browsing Up-To-Date Check**

Disables waiting for the code browsing database to be up-to-date when executing browsing operations.

**Disable Current Item Selection**

Disables visualization of the selected code element in the Properties tool window and elsewhere.

**Display Skipped Regions for External Files**

Include skipped regions from external files when displaying browsing database errors.

## Code Analysis

**Disable C++ Code Analysis Experience**

Disable the C++ Code Analysis experience, which provides support for code analysis squiggles, background code analysis, and other features for C++ files.

**Disable Background Code Analysis**

Disable running C++ Code Analysis in the background when files are opened or saved.

**Disable Code Analysis Squiggles**

Disable squiggles for C++ Code Analysis warnings. Errors will continue to be shown in the error list. Only affects newly opened windows.

## Diagnostic Logging

These options are provided in case Microsoft asks you to collect advanced information to diagnose an issue. The logging information isn't useful for users, and we recommend that you leave it disabled.

**Enable Logging**

Enables diagnostic logging to the output window.

**Logging Level**

Set the log verbosity, from 0 to 5.

**Logging Filter**

Filters displayed event types by using a bitmask.

Set by using a sum of any of the following options:

- 0 - None

- 1 - General

- 2 - Idle

- 4 - WorkItem

- 8 - IntelliSense

- 16 - ACPerf

- 32 - ClassView

## IntelliSense

**Auto Quick Info**

Enables QuickInfo tooltips when you move the pointer over text.

**Disable IntelliSense**

Disables all IntelliSense features. The IDE does not create VCPkgSrv.exe processes to service IntelliSense requests, and no IntelliSense features will work (QuickInfo, Member List, Auto Complete, Param Help). Semantic colorization and reference highlighting are also disabled. This option doesn't disable browsing features that rely solely on the database (including Navigation Bar, ClassView, and Property window).

**Disable Auto Updating**

IntelliSense updating is delayed until an actual request for IntelliSense is made. This delay can result in a longer execution time of the first IntelliSense operation on a file, but it may be helpful to set this option on very slow or resource-constrained machines. If you choose this option, you also implicitly choose the "Disable Error Reporting" and "Disable Squiggles" options.

**Disable Error Reporting**

Disables reporting of IntelliSense errors through squiggles and the Error List window. Also disables the background parsing that's associated with error reporting. If you choose this option, you also implicitly choose the "Disable Squiggles" option.

**Disable Squiggles**

Disables IntelliSense error squiggles. The red "squiggles" don't show in the editor window, but the error will still appear in the Error List window.

**Auto Tune Max Cached Translation Units**

Enables the maximum number of translation units that will be kept active at any one time for IntelliSense requests, based on available system RAM.

For more information about translation units, see [Phases of Translation](/cpp/preprocessor/phases-of-translation).

**Disable #include Auto Complete**

Disables auto-completion of `#include` statements.

**Use Forward Slash in #include Auto Complete**

Triggers auto-completion of `#include` statements when "/" is used. The default delimiter is backslash '\'. The compiler can accept either, so use this option to specify what your code base uses.

**Disable Aggressive Member List**

The member list doesn't appear while you type the name of a type or variable. The list appears only after you type one of the commit characters, as defined in the **Member List Commit Characters** option.

**Disable Member List Keywords**

Language keywords such as `void`, `class`, `switch` don't appear in member list suggestions.

**Disable Member List Code Snippets**

Code snippets don't appear in member list suggestions.

**Member List Filter Mode**

Sets the type of matching algorithm. **Fuzzy** finds the most possible matches because it uses an algorithm that's similar to a spell-checker to find matches that are similar but not identical. **Smart filtering** matches substrings even if they're not at the start of a word. **Prefix** only matches on identical substrings that start at the beginning of the word.

**Disable Semantic Colorization**

Turns off all code colorization except for language keywords, strings, and comments.

**Member List Commit Characters**

Specifies the characters that cause the currently highlighted Member List suggestion to be committed. You can add or remove characters from this list.

**Smart Member List Commit**

Adds a line when you choose the Enter key at the end of a fully typed word.

**Member List Commit Aggressive**

'Member List Commit Characters' are active during 'aggressively invoked' Member List.

**Use Aggressive Member List for Auto Member List**

When enabled and Auto Member List is shown, do not complete using Member List Commit characters.

**Use Tab to commit in Aggressive Member List**

When enabled and Aggressive Member List is shown, treat Tab key as Member List Commit character.

**Use Tab to Insert Snippet**

When enabled, snippet keyword is expanded when tab is pressed (unless shortcut key is assigned to `Edit.InvokeSnippetFromShortcut`) regardless of whether member list is shown.

**Disable Modules**

Disable various C++20 Modules IDE features such as automatic building of needed modules for IntelliSense.

**Member List Filter Inaccessible**

Don't display inaccessible items in Member Lists.

**Disable IntelliSense for Inactive Platforms**

Disable all IntelliSense features for inactive platforms in folders and Shared Assets Projects.

**Enable Member List Dot-To-Arrow**

Replaces '.' with '->' when applicable for Member List.

**Disable HLSL IntelliSense**

Disable all HLSL IntelliSense features.

**Disable Automatic Precompiled Header**

Automatic Precompiled Header may speed up some IntelliSense operations at expense of a per-solution hard drive cache.

**Automatic Precompiled Header Cache Quota**

The maximum size of the per-solution cache in megabytes; the actual usage may fluctuate around this value.

**Inactive Platform IntelliSense Limit**

Maximum number of inactive platforms that will be processed for IntelliSense.  The value must be between 1 and 16.

**Enable Template IntelliSense**

When the cursor is active within a template body, display a bar in the editor to configure the template's IntelliSense.

**Enable Help Link on Quick Info**

Enables link to online searches on the Quick Info tooltip.

**Use Web Search on Quick Info Help Link**

Launches a web search with the specified search provider as the action for online searches in the Quick Info tooltip. When disabled it uses F1 Help.

**Enable Help Link on IntelliSense Error Tooltips**

Enables link to online searches on IntelliSense error tooltips.

**Search Provider**

URL used to find online help on errors, {0} is replaced with error

## IntelliSense and Browsing for Non-Project Files

**Enable Enhanced Single File**

Enables IntelliSense, Browsing and other features for standalone files that are not part of an existing project.

**Enable IntelliSense Squiggles**

Enables squiggles for standalone files in Enhanced Single File mode.

**Show IntelliSense Errors In Error List**

Controls whether IntelliSense errors from standalone files are displayed in the Error List.

**Suspend New Files During Debugging**

Suspend enabling IntelliSense for newly opened files while debugging.

## Refactoring

**Disable Create Declaration/Definition Light Bulbs**

Do not offer suggestions to create a missing function declaration or definition.

## References

**Disable Resolving**

For performance reasons, 'Find All References'  displays raw textual search results by default instead of using IntelliSense to verify each candidate. You can clear this check box for more accurate results on all find operations. To filter on a per-search basis, open the shortcut menu for  the result list, and then choose "Resolve Results."

**Hide Unconfirmed**

Hide unconfirmed items in the 'Find All References' results. If you unset the "Disable Resolving" option, you can use this option to hide unconfirmed items in the results.

**Disable Reference Highlighting**

By default, when you select some text, all instances of the same text are automatically highlighted in the current document. You can disable this feature by setting **Disable Reference Highlighting** to **True**.

## Text Editor

**Enable Surround with Braces**

If enabled, you can surround selected text with curly braces by typing '{' into the text editor.

**Enable Surround with Parentheses**

If enabled, you can surround selected text with parentheses by typing '(' into the text editor.

## See also

- [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)
