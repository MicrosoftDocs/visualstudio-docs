---
title: "Writing Code in the Code and Text Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.texteditor"
dev_langs:
  - "JScript"
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "code editor, word wrap"
  - "outlining"
  - "code, editing"
  - "squiggles"
  - "code editor, outlining"
  - "code editor, error and warning markers"
  - "word wrap"
  - "code editor, syntax coloring"
  - "code editor, go to definition"
  - "diff"
  - "code editor [Visual Studio]"
  - "code editor, diff"
  - "error and warning markers"
  - "code editor, navigation bar"
  - "code editor, customizing"
  - "comment selection"
  - "code editor, tabify"
  - "brace matching"
  - "code editor, line numbers"
  - "printing"
  - "code editor, brace matching"
  - "code editor, squiggles"
  - "code editor, features"
  - "line numbers"
  - "go to definition"
  - "syntax coloring"
  - "code editor, navigate to"
  - "code editor, comparing files"
  - "code editor, zoom"
  - "code editor"
  - "code files"
  - "go to line"
  - "tabify"
  - "zoom"
  - "navigate to"
  - "line break characters"
  - "code editor, virtual space"
  - "code editor, change tracking"
  - "code editor, comment selection"
  - "code editor, printing"
  - "virtual space"
  - "code editor, line break characters"
  - "code editor, go to line"
  - "code"
ms.assetid: cb53ab9a-5b76-4759-b9e8-7bf32298ecbe
caps.latest.revision: 46
author: jillre
ms.author: jillfra
manager: jillfra
---
# Writing Code in the Code and Text Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]
The Visual Studio editor provides many features that make it easier for you to write and manage your code. You can expand and collapse different blocks of code by using outlining. You can learn more about the code you are using by using IntelliSense, the **Object Browser**, and the Call Hierarchy. You can navigate inside your code by using features such as **Navigate To**, **Go To Definition**, and **Find All References**. You can insert blocks of code with code snippets, and you can generate code by using features such as **Generate From Usage**. If you have never used the Visual Studio 2015 editor before, see [Editing Your Code](https://www.visualstudio.com/features/ide-vs) for a quick overview.

 You can view your code in a number of different ways. To see a class view of your solution, you can open the **Class View** window or expand the nodes in the **Solution Explorer** under your class files.

 You can search and replace text for single or multiple files. For more information, see [Finding and Replacing Text](../ide/finding-and-replacing-text.md). If you use regular expressions, note that find and replace now use .NET regular expressions. For more information, see [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

 The different Visual Studio languages offer different sets of features, and in some cases the features behave differently in different languages. Many of these differences are specified in the descriptions of the features, but for more information you can see the sections on specific Visual Studio languages.

> [!IMPORTANT]
> The Visual Studio edition and the settings you are using may affect the features in the IDE. They might differ from those described in this topic.

## Editor Features

|||
|-|-|
|Syntax Coloring|Some syntax elements of code and markup files are colored differently to distinguish them. For example, keywords (such as `using` in C# and `Imports` in Visual Basic) are one color, but types (such as `Console` and `Uri`) are another color. Other syntax elements are also colorized, such as string literals and comments. C++ uses color to differentiate among types, enumerations, and macros, among other tokens.<br /><br /> You can see the default color for each type, and you can change the color for any specific syntax element in the [Fonts and Colors, Environment, Options Dialog Box](../ide/reference/fonts-and-colors-environment-options-dialog-box.md), which you can open from the **Tools** menu.|
|Error and Warning Marks|As you add code and build your solution, you may see (a) different-colored wavy underlines (known as squiggles) or (b) light bulbs appearing in your code. Red squiggles denote syntax errors, blue denotes compiler errors, green denotes warnings, and purple denotes other types of errors. [Light bulbs](../ide/perform-quick-actions-with-light-bulbs.md) suggest fixes for problems and make it easy to apply the fix.<br /><br /> You can see the default color for each error and warning squiggle in the **Tools/Options/Environment/Fonts and Colors** dialog box. Look for **Syntax Error**, **Compiler Error**, **Warning**, and **Other Error**.|
|Brace Matching|When the insertion point is placed on an open brace in a code file, both it and the closing brace are highlighted. This feature gives you immediate feedback on misplaced or missing braces. You can turn brace matching on or off with the **Automatic Delimiter Highlighting** setting (**Tools/Options/Text Editor**). You can change the highlight color in the **Fonts and Colors** setting (**Tools/Options/Environment**). Look for **Brace Matching (Highlight)** or **Brace Matching (Rectangle)**.|
|Line Numbers|Line numbers can be displayed in the left margin of the code window. They are not displayed by default. You can turn this option on in the **Text Editor All Languages** settings (**Tools/Options/Text Editor/All Languages**). You can display line numbers for individual programming languages by changing the settings for those languages (**Tools/Options/Text Editor/\<language>**). For line numbers to print, you must select Include line numbers in the **Print** dialog box.|
|Change Tracking|The color of the left margin allows you to keep track of the changes you have made in a file. Changes you have made since the file was opened but not saved are denoted by a yellow bar on the left margin (known as the selection margin). After you have saved the changes (but before closing the file), the bar turns green. If you undo a change after you have saved the file, the bar turns orange. To turn this feature off and on, change the **Track changes** option in the **Text Editor** settings (**Tools/Options/Text Editor**).|
|Selecting Code and Text|You can select text either in the standard continuous stream mode or in box mode, in which you select a rectangular portion of text instead of a set of lines. To make a selection in box mode, press ALT as you drag the mouse over the selection (or press ALT + SHIFT + \<arrow key>). The selection includes all of the characters within the rectangle defined by the first character and the last character in the selection. Anything typed or pasted into the selected area is inserted at the same point on each line.|
|Zoom|You can zoom in or out in any code window by pressing and holding the CTRL key and moving the scroll wheel on the mouse (or CTRL + SHIFT + . to increase and CTRL + SHIFT + , to decrease). You can also use the Zoom box in the lower left corner of the code window to set a specific zoom percentage. The zoom feature does not work in tool windows.|
|Virtual Space|By default, lines in Visual Studio editors end after the last character, so that the RIGHT ARROW key at the end of a line moves the cursor to the beginning of the next line. In some other editors a line does not end after the last character, and you can place your cursor anywhere on the line. You can enable virtual space in the editor in the **Tools/Options/Text Editor/All Languages** settings. Note that you can enable either **Virtual Space** or **Word Wrap**, but not both.|
|Printing|You can use the options in the **Print** dialog box to include line numbers or hide collapsed regions of code when you print a file. In the **Page Setup** dialog box, you can also choose to print the full path and the name of the file by choosing **Page header**.<br /><br /> You can set color printing options in the **Tools/Options/Environment/Fonts and Colors** dialog box. Choose **Printer** in the **Show settings for** list to customize color printing. You can specify different colors for printing a file than for editing a file.|
|Global Undo and Redo|The **Undo Last Global Action** and **Redo Last Global Action** commands on the **Edit** menu undo or redo global actions that affect multiple files. Global actions include renaming a class or namespace, performing a find-and-replace operation across a solution, refactoring a database, or any other action that changes multiple files. You can apply the global undo and redo commands to actions in the current Visual Studio session, even after you close the solution in which an action was applied.|

## Advanced Editing Features
 You can find a number of advanced features on the **Edit/Advanced** submenu. Not all these features are available for all types of code files.

|||
|-|-|
|Format Document|Sets the proper indentation of lines of code and moves curly braces to separate lines in the document.|
|Format Selection|Sets the proper indentation of lines of code and moves curly braces to separate lines in the selection.|
|Tabify Selected Lines|Changes leading spaces to tabs where appropriate.|
|Untabify Selected Lines|Changes leading tabs to spaces. If you want to convert all the spaces in your file to tabs (or all the tabs to spaces), you can use the `Edit.ConvertSpacesToTabs` and `Edit.ConvertTabsToSpaces` commands. These commands do not appear in Visual Studio menus, but you can call them from the Quick Access window or the command window.|
|Make Uppercase|Changes all characters in the selection to uppercase, or if there is no selection, changes the character at the insertion point to uppercase.|
|Make Lowercase|Changes all characters in the selection to lowercase, or if there is no selection, changes the character at the insertion point to lowercase.|
|Validate Document|Validates JScript code files.|
|Delete Horizontal White Space|Deletes tabs or spaces at the end of the current line.|
|View White Space|Displays spaces as raised dots, and tabs as arrows. The end of a file is displayed as a rectangular glyph. If **Tools/Options/Text Editor/All Languages/Word Wrap/Show visible glyphs for word wrap** is selected, that glyph is also displayed.|
|Word Wrap|Causes all the lines in a document to be visible in the code window. You can turn word wrap off and on in the Text Editor All Languages settings (**Tools/Options/ Text Editor/All Languages**).|
|Uncomment Selection|Adds comment characters to the selection or the current line.|
|Comment Selection|Removes comment characters from the selection or the current line.|
|Increase Line Indent|Adds a tab (or the equivalent spaces) to the selected lines or the current line.|
|Decrease Line Indent|Removes a tab (or the equivalent spaces) from the selected lines or the current line.|
|Select Tag|In a document that contains tags (for example, XML or HTML), selects the tag.|
|Select Tag Content|In a document that contains tags (for example, XML or HTML), selects the content.|

## Navigate in the Code Window
 You can move around in a document in several different ways. In addition to the standard operations, you can use the **Navigate Backward** (or CTRL + MINUS) and **Navigate Forward** (CTRL + SHIFT + MINUS) buttons on the toolbar to move the insertion point to previous locations or return to more recent locations in the active document. These buttons retain the last 20 locations of the insertion point.

 ![Forward and back navigation buttons](../ide/media/vs2015-nav-buttons.png "VS2015_Nav_buttons")

 You can also use the enhanced scroll bar in a code window to get a bird’s-eye view of your code. In map mode, you can see previews of the code when you move the cursor up and down the scroll bar, For more information, see [How to: Track Your Code by Customizing the Scrollbar](../ide/how-to-track-your-code-by-customizing-the-scrollbar.md).

 The following commands are code-specific navigation methods:

|||
|-|-|
|Go To \<line number>|(**Edit/Go To** or CTRL + G): Move to a specific line number in the active document.|
|Navigate To|(**Edit/Navigate To** or CTRL + ,): Finds a symbol or file in the active solution. It helps you pick a good set of matching results from a query. You can search for keywords that are contained in a symbol by using camel casing and underscore characters to divide the symbol into keywords.|
|Find All References|(context menu): Finds all the references to the selected element in the solution.|
|Go To Definition|(context menu or F12): Finds the definition of the selected element.|
|Peek Definition|(context menu or Alt+F12): Finds the definition of the selected element and displays it in a popup window. For more information, see [How to: View and Edit Code by Using Peek Definition (Alt+F12)](../ide/how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md).|
|Next Method, Previous Method|(**Edit/Next Method, Previous Method**) In Visual Basic code files, use these commands to move the insertion point to different methods.|
|Reference Highlighting|When you click a symbol in the source code, all instances of that symbol are highlighted in the document. The highlighted symbols may include declarations and references, and many other symbols that **Find All References** would return. These include the names of classes, objects, variables, methods, and properties. In Visual Basic code, keywords for many control structures are also highlighted. To move to the next or the previous highlighted symbol, press CTRL+SHIFT+DOWN ARROW or CTRL+SHIFT+UP ARROW. You can change the highlighting color in **Tools/Options/Environment/Fonts and Colors/Highlighted Reference.**|
|Find code-related info|You can find info about specific code, like changes and who made those changes, references, bugs, work items, code reviews, and unit test status when you use CodeLens in the code editor. CodeLens works like a heads-up display when you use Visual Studio Enterprise with Team Foundation Server. See [Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md).|

 You can also use the **navigation bar**, that is, the two dropdown boxes displayed at the top of the code window, to navigate in a code file. This bar allows you to navigate directly to a particular type or to one of the members within a type. The navigation bar appears with Visual Basic, C#, and C++ code files.

 To hide the navigation bar, change the **Navigation bar** option in the Text Editor All Languages settings (**Tools/Options/Text Editor/All Languages**, or you can change the settings for individual languages). You can navigate in the dropdown boxes as follows:

- To shift focus from the code window to the navigation bar, press the shortcut key combination CTRL+F2.

- To return focus from the navigation bar to the code window, press the ESC key.

- To shift focus from item to item on the navigation bar, press the TAB key.

- To select the Navigation bar item that has focus and return to the IDE, press the ENTER key

- To navigate to a class or type, click its name in the left dropdown.

- To navigate directly to a procedure in a class, click a procedure in the right dropdown.

  In a partial class, members defined outside the current code file may be grayed out.

## Find code using Navigate To
Visual Studio's "Navigate To" command does a focused search of your code to help you quickly find specified elements in code files, file paths and code symbols. Unlike other text searches such as Find or Find in Files, Navigate To limits its search to areas where actual code lives, such as files, forms and code modules. For example, if you search for a string in an ASP.NET web application using Find or Find in Files in the whole solution, you might get several hits, including instances of the string in code remarks. By using Navigate To, however, you might only get a single function, ignoring any instances of the string in code remarks.

### Navigate code using Navigate To

1. Open a solution or folder in Visual Studio.
1. On the main menu, choose **Edit**, **Navigate To**, or press **CTRL + ,**.

    A small text box appears in the upper corner of the code editor.
1. In the text box, enter the name of the code element you want to find.

    ![Navigate To window](../ide/media/vside-navigatetowindow.png "Navigate To window")

    As you type, the results appear in a dropdown list below the text box.
1. To go to an element, choose it in the list.

### Filter your search

To limit your search to only code symbols, preface your Navigate To query with an "\@" character. For example, if you search for `@application`, Navigate To displays, for example, only classes that have the word "application" in them.

If you use camel casing in your code, you can find code elements faster by entering only the capital letters of code element name. For example, if your code has a component called `ViewSwitcher`, you can find it by entering just the capital letters of the name (`"VS"`) in the Navigate To window.

![Navigate To window - searching with capitals](../ide/media/vside-capitalsearch.png "Navigate To window - searching with capitals")

This feature is particularly helpful if your code has long names.

## Customize the Editor
 **Import and Export Settings**: You can share settings with another developer, have your settings conform to a standard, or return to Visual Studio default settings by using the **Import and Export Settings Wizard** on the **Tools** menu. You can change general settings or language and project-specific settings.

 **Keyboard Mapping**: You can define new hotkeys or redefine existing ones in the Tools/Options/Environment/Keyboard settings. For more information about hotkeys, see [Default Keyboard Shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md).

 For information about language-specific editor options, see the following:

- [Visual Basic Settings](https://msdn.microsoft.com/library/2712b3b1-18f2-430c-ae91-28468bbf5f32)

- [Using the Visual Studio Development Environment for C#](../csharp-ide/using-the-visual-studio-development-environment-for-csharp.md)

- [Options, Text Editor, JavaScript, Formatting](../ide/reference/options-text-editor-javascript-formatting.md)

## In this section

- [Finding and Replacing Text](../ide/finding-and-replacing-text.md)

- [Encodings and Line Breaks](../ide/encodings-and-line-breaks.md)

- [Outlining](../ide/outlining.md)

- [Refactoring](../ide/refactoring-in-visual-studio.md)

- [Productivity Tips](../ide/productivity-tips-for-visual-studio.md)

- [Using IntelliSense](../ide/using-intellisense.md)

- [Customizing the Editor](../ide/customizing-the-editor.md)

- [How to: Track Your Code by Customizing the Scrollbar](../ide/how-to-track-your-code-by-customizing-the-scrollbar.md)

- [How to: View and Edit Code by Using Peek Definition (Alt+F12)](../ide/how-to-view-and-edit-code-by-using-peek-definition-alt-plus-f12.md)

- [Perform quick actions with light bulbs](../ide/perform-quick-actions-with-light-bulbs.md)

- [Code Snippets](../ide/code-snippets.md)

- [Using the Toolbox](../ide/using-the-toolbox.md)

- [Viewing the Structure of Code](../ide/viewing-the-structure-of-code.md)

- [Setting Bookmarks in Code](../ide/setting-bookmarks-in-code.md)

- [Using the Task List](../ide/using-the-task-list.md)

- [Find code changes and other history](../ide/find-code-changes-and-other-history-with-codelens.md)

## See Also
 [Visual Studio IDE](../ide/visual-studio-ide.md)
