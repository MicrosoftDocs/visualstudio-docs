---
title: Code editor features
description: Learn about the features that the code editor in Visual Studio provides to make it easier for you to write and manage your code and text.
ms.custom: SEO-VS-2020
ms.date: 02/23/2018
ms.topic: conceptual
helpviewer_keywords:
- code, editing [Visual Studio]
- code editor [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Features of the code editor

The Visual Studio editor provides many features that make it easier for you to write and manage your code and text. You can expand and collapse different blocks of code by using outlining. You can learn more about the code by using IntelliSense, the **Object Browser**, and the Call Hierarchy. You can find code by using features such as **Go To**, **Go To Definition**, and **Find All References**. You can insert blocks of code with code snippets, and you can generate code by using features such as **Generate From Usage**. If you have never used the Visual Studio editor before, see [Learn to use the code editor](../get-started/tutorial-editor.md).

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Source editor (Visual Studio for Mac)](/visualstudio/mac/source-editor).

You can view your code in a number of different ways. By default, **Solution Explorer** shows your code organized by files. You can click on the **Class View** tab at the bottom of the window to view your code organized by classes.

You can search and replace text in single or multiple files. For more information, see [Find and replace text](../ide/finding-and-replacing-text.md). You can use regular expressions to find and replace text. For more information, see [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

The different Visual Studio languages offer different sets of features, and in some cases the features behave differently in different languages. Many of these differences are specified in the descriptions of the features, but for more information you can see the sections on specific Visual Studio languages.

## Editor features

|Feature|Description|
|-|-|
|Syntax Coloring|Some syntax elements of code and markup files are colored differently to distinguish them. For example, keywords (such as `using` in C# and `Imports` in Visual Basic) are one color, but types (such as `Console` and `Uri`) are another color. Other syntax elements are also colorized, such as string literals and comments. C++ uses color to differentiate among types, enumerations, and macros, among other tokens.<br /><br /> You can see the default color for each type, and you can change the color for any specific syntax element in the [Fonts and Colors, Environment, Options dialog box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md), which you can open from the **Tools** menu.|
|Error and Warning Marks|As you add code and build your solution, you may see (a) different-colored wavy underlines (known as squiggles) or (b) light bulbs appearing in your code. Red squiggles denote syntax errors, blue denotes compiler errors, green denotes warnings, and purple denotes other types of errors. [Quick Actions](../ide/quick-actions.md) suggest fixes for problems and make it easy to apply the fix.<br /><br /> You can see the default color for each error and warning squiggle in the **Tools** > **Options** > **Environment** > **Fonts and Colors** dialog box. Look for **Syntax Error**, **Compiler Error**, **Warning**, and **Other Error**.|
|Brace Matching|When the insertion point is placed on an open brace in a code file, both it and the closing brace are highlighted. This feature gives you immediate feedback on misplaced or missing braces. You can turn brace matching on or off with the **Automatic Delimiter Highlighting** setting (**Tools** > **Options** > **Text Editor**). You can change the highlight color in the **Fonts and Colors** setting (**Tools** > **Options** > **Environment**). Look for **Brace Matching (Highlight)** or **Brace Matching (Rectangle)**.|
|Structure Visualizer|Dotted lines connect matching braces in code files, making it easier to see opening and closing brace pairs. This can help you find code in your codebase more quickly. You can turn these lines on or off with the **Show structure guidelines** in the **Display** section of the **Tools** > **Options** > **Text Editor** > **General** page.|
|Line Numbers|Line numbers can be displayed in the left margin of the code window. They are not displayed by default. You can turn this option on in the **Text Editor All Languages** settings (**Tools** > **Options** > **Text Editor** > **All Languages**). You can display line numbers for individual programming languages by changing the settings for those languages (**Tools** > **Options** > **Text Editor** > **\<language>**). For line numbers to print, you must select **Include line numbers** in the **Print** dialog box.|
|Change Tracking|The color of the left margin allows you to keep track of the changes you have made in a file. Changes you have made since the file was opened but not saved are denoted by a yellow bar on the left margin (known as the selection margin). After you have saved the changes (but before closing the file), the bar turns green. If you undo a change after you have saved the file, the bar turns orange. To turn this feature off and on, change the **Track changes** option in the **Text Editor** settings (**Tools** > **Options** > **Text Editor**).|
|Selecting Code and Text|You can select text either in the standard continuous stream mode or in box mode, in which you select a rectangular portion of text instead of a set of lines. To make a selection in box mode, press **Alt** as you drag the mouse over the selection (or press **Alt**+**Shift**+**\<arrow key>**). The selection includes all of the characters within the rectangle defined by the first character and the last character in the selection. Anything typed or pasted into the selected area is inserted at the same point on each line.|
|Zoom|You can zoom in or out in any code window by pressing and holding the **Ctrl** key and moving the scroll wheel on the mouse (or **Ctrl**+**Shift**+**.** to increase and **Ctrl**+**Shift**+**,** to decrease). You can also use the **Zoom** box in the lower left corner of the code window to set a specific zoom percentage. The zoom feature does not work in tool windows.|
|Virtual Space|By default, lines in Visual Studio editors end after the last character, so that the **Right Arrow** key at the end of a line moves the cursor to the beginning of the next line. In some other editors a line does not end after the last character, and you can place your cursor anywhere on the line. You can enable virtual space in the editor in the **Tools** > **Options** > **Text Editor** > **All Languages** settings. Note that you can enable either **Virtual Space** or **Word Wrap**, but not both.|
|Printing|You can use the options in the **Print** dialog box to include line numbers or hide collapsed regions of code when you print a file. In the **Page Setup** dialog box, you can also choose to print the full path and the name of the file by choosing **Page header**.<br /><br /> You can set color printing options in the **Tools** > **Options** > **Environment** > **Fonts and Colors** dialog box. Choose **Printer** in the **Show settings for** list to customize color printing. You can specify different colors for printing a file than for editing a file.|
|Global Undo and Redo|The **Undo Last Global Action** and **Redo Last Global Action** commands on the **Edit** menu undo or redo global actions that affect multiple files. Global actions include renaming a class or namespace, performing a find-and-replace operation across a solution, refactoring a database, or any other action that changes multiple files. You can apply the global undo and redo commands to actions in the current Visual Studio session, even after you close the solution in which an action was applied.|

## Advanced editing features

You can find a number of advanced features on the **Edit** > **Advanced** menu on the toolbar. Not all of these features are available for all types of code files.

|Feature|Description|
|-|-|
|Format Document|Sets the proper indentation of lines of code and moves curly braces to separate lines in the document.|
|Format Selection|Sets the proper indentation of lines of code and moves curly braces to separate lines in the selection.|
|Tabify Selected Lines|Changes leading spaces to tabs where appropriate.|
|Untabify Selected Lines|Changes leading tabs to spaces. If you want to convert all the spaces in your file to tabs (or all the tabs to spaces), you can use the `Edit.ConvertSpacesToTabs` and `Edit.ConvertTabsToSpaces` commands. These commands do not appear in Visual Studio menus, but you can call them from the **Quick Access** window or the command window.|
|Make Uppercase|Changes all characters in the selection to uppercase, or if there is no selection, changes the character at the insertion point to uppercase. Shortcut: **Ctrl**+**Shift**+**U**.|
|Make Lowercase|Changes all characters in the selection to lowercase, or if there is no selection, changes the character at the insertion point to lowercase. Shortcut: **Ctrl**+**U**.|
|Move selected Lines Up|Moves the selected line up one line. Shortcut: **Alt**+**Up Arrow**.|
|Move Selected Lines Down|Moves the selected line down one line. Shortcut: **Alt**+**Down Arrow**.|
|Delete Horizontal White Space|Deletes tabs or spaces at the end of the current line. Shortcut: **Ctrl**+**K**, **Ctrl**+**\\**|
|View White Space|Displays spaces as raised dots, and tabs as arrows. The end of a file is displayed as a rectangular glyph. If **Tools** > **Options** > **Text Editor** > **All Languages** > **Word Wrap** > **Show visible glyphs for word wrap** is selected, that glyph is also displayed.|
|Word Wrap|Causes all the lines in a document to be visible in the code window. You can turn word wrap off and on in the **Text Editor All Languages** settings (**Tools** > **Options** > **Text Editor** > **All Languages**).|
|Comment Selection|Adds comment characters to the selection or the current line. Shortcut: **Ctrl**+**K**, **Ctrl**+**C**|
|Uncomment Selection|Removes comment characters from the selection or the current line. Shortcut: **Ctrl**+**K**, **Ctrl**+**U**|
|Increase Line Indent|Adds a tab (or the equivalent spaces) to the selected lines or the current line.|
|Decrease Line Indent|Removes a tab (or the equivalent spaces) from the selected lines or the current line.|
|Select Tag|In a document that contains tags (for example, XML or HTML), selects the tag.|
|Select Tag Content|In a document that contains tags (for example, XML or HTML), selects the content.|

## Navigate and find code

You can move around in the code editor in several different ways, including navigating backwards and forwards to previous insertion points, viewing the definition of a type or member, and jumping to a specific method using the navigation bar. For more information see [Navigate code](navigating-code.md).

## Find references in your code base

To find where particular code elements are referenced throughout your codebase, you can use the **Find All References** command or press **Shift**+**F12**. Also, when you click on a type or member, the **reference highlighting** feature automatically highlights all references to that type or member. For more information, see [Find references in your code](finding-references.md).

## Customize the editor

You can share your Visual Studio settings with another developer, have your settings conform to a standard, or return to Visual Studio default settings by using the **Import and Export Settings Wizard** command on the **Tools** menu. In the **Import and Export Settings Wizard**, you can change selected general settings or language and project-specific settings.

To define new hotkeys or redefine existing hotkeys, go to **Tools** > **Options** > **Environment** > **Keyboard**. For more information about hotkeys, see [Default keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md).

For JavaScript-specific editor options, see [JavaScript editor options](../ide/reference/options-text-editor-javascript-formatting.md).

## See also

- [Source editor (Visual Studio for Mac)](/visualstudio/mac/source-editor)
- [Visual Studio IDE](../get-started/visual-studio-ide.md)
- [Get started with C++ in Visual Studio](/cpp/get-started/tutorial-console-cpp)
- [Get started with C# and ASP.NET in Visual Studio](../get-started/csharp/tutorial-aspnet-core.md)
- [Get started with Python in Visual Studio](../ide/quickstart-python.md)
