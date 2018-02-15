---
title: "Productivity tips for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Productivity tips for Visual Studio

This topic contains various tips to help you write, navigate, and debug your code more quickly and efficiently.

For information about common keyboard shortcuts, see [Keyboard tips](../ide/tips-and-tricks-for-visual-studio.md). Or, for a complete list of keyboard shortcuts, see [Identifying and customizing keyboard shortcuts](../ide/identifying-and-customizing-keyboard-shortcuts-in-visual-studio.md) and [Default keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md).

## Writing code

Write code more quickly by using the following features.

- **Use convenience commands**. Visual Studio contains various commands to help you accomplish common editing tasks faster. For example, in **Visual Studio 2017 version 15.6 preview 2** and later, you can choose a command to easily duplicate a line of code without having to copy it, reposition the cursor, and then paste it. Choose **Edit** > **Duplicate** or press **Ctrl**+**E**,**V**. You can also quickly expand or contract a selection of text by choosing **Edit** > **Advanced** > **Expand Selection** and **Contract Selection**, or by pressing **Ctrl**+**W** and **Ctrl**+**Shift**+**W** (available in **Visual Studio 2017 version 15.5** and later).

- **Use IntelliSense**. As you enter code in the editor, IntelliSense information, such as List Members, Parameter Info, Quick Info, Signature Help, and Complete Word, appears. These features support fuzzy matching of text; for example, the results lists for List Members includes not only entries that start with the characters that you have entered but also entries that contain the character combination anywhere in their names. For more information, see [Using IntelliSense](../ide/using-intellisense.md).

- **Change auto-insertion of IntelliSense options as you enter code**. By switching IntelliSense to suggestion mode, you can specify that IntelliSense options are inserted only if you explicitly choose them.

     To enable suggestion mode, choose the **Ctrl**+**Alt**+**Spacebar** keys, or, on the menu bar, choose **Edit** > **IntelliSense** > **Toggle Completion Mode**.

- **Use code snippets**. You can use built-in snippets, or create your own snippets.

     To insert a snippet, on the menu bar, choose **Edit** > **IntelliSense** > **Insert Snippet** or **Surround With**, or open the shortcut menu in a file and choose **Snippet** > **Insert Snippet** or **Surround With**. For more information, see [Code Snippets](../ide/code-snippets.md).

- **Fix code errors inline**. Quick Actions let you easily refactor, generate, or otherwise modify code with a single action. These actions can be applied using the Light Bulb icon ![Small Light Bulb Icon](media/vs2015_lightbulbsmall.png "VS2017_LightBulbSmall"), or by pressing **Alt**+**Enter** or **Ctrl**+**.** when your cursor is on the appropriate line of code. See [Quick Actions](quick-actions.md) for more information.

- **Show and edit the definition of a code element**. You can quickly show and edit the module in which a code element, such as a member, a variable, or a local, is defined.

    To open a definition in a pop-up window, highlight the element and then choose the **Alt**+**F12** keys, or open the shortcut menu for the element and then choose **Peek Definition**. To open a definition in a separate code window, open the shortcut menu for the element, and then choose **Go to Definition**.

- **Use sample applications**. You can speed up application development by downloading and installing sample applications from [Microsoft Developer Network](https://code.msdn.microsoft.com/). You can also learn a particular technology or programming concept by downloading and exploring a Sample Pack for that area.

## Navigating within your code

 You can use various techniques to find and move to specific locations in your code more quickly.

- **Bookmark lines of code**. You can use bookmarks to navigate quickly to specific lines of code in a file.

    To set a bookmark, on the menu bar, choose **Edit** > **Bookmarks** > **Toggle Bookmark**. You can view all of the bookmarks for a solution in the **Bookmarks** window. For more information, see [Setting Bookmarks in Code](../ide/setting-bookmarks-in-code.md).

- **Search for symbol definitions in a file**. You can search within a solution to locate symbol definitions and file names, but search results don't include namespaces or local variables.

   To access this feature, on the menu bar, choose **Edit** > **Navigate To**.

- **Browse the overall structure of your code**. In **Solution Explorer**, you can search and browse classes and their types and members in your projects. You can also search for symbols, view a method's Call Hierarchy, find symbol references, and perform other tasks. If you choose a code element in **Solution Explorer**, the associated file opens in a **Preview** tab, and the cursor moves to the element in the file. For more information, see [Viewing the Structure of Code](../ide/viewing-the-structure-of-code.md).

## Finding items faster

You can search across the IDE for commands, files, and options, in addition to filtering the contents of tool windows to show only relevant information for your current task.

- **Filter the contents of tool windows**. You can search within the contents of many tool windows, such as the **Toolbox**, the **Properties** window, and **Solution Explorer**, but display only items whose names contain the characters that you specify.

- **Display only the errors you want to address**. If you choose the **Filter** button on the **Error List** toolbar, you can reduce the number of errors that appear in the **Error List** window. You can display only the errors in the files that are open in the editor, only the errors in the current file, or only the errors in the current project. You can also search within the Error List window to find specific errors.

- **Find dialog boxes, menu commands, and options**. In the [Quick Launch](../ide/reference/quick-launch-environment-options-dialog-box.md) box, enter keywords or phrases for the items that you're trying to find. For example, the following options appear if you enter `new project`:

    ![Quick Launch Results for 'new project'](../ide/media/productivity_quicklaunch.png "Productivity_QuickLaunch")

    **Quick Launch** displays links to the **New Project** dialog box, the **Add New Item** dialog box, and the Projects and Solutions page in the **Options** dialog box, among others. Quick Launch results can also include project files and tool windows.

## Debugging code

Debugging can consume a lot of time, but the following tips can help you speed up the process.

- **Test the same page, application, or site in different browsers**. As you debug your code, you can easily switch among the installed web browsers, including [Page Inspector (Visual Studio)](http://msdn.microsoft.com/Library/65880969-1ad2-47be-85b9-bb12c81bf209), without having to open the **Browse With** dialog box. You can use the **Debug Target** list, which is on the **Standard** toolbar next to the **Start Debugging** button, to quickly verify which browser you're using as you debug or view pages.

    ![Select Web browser debug options](../ide/media/webbrowserdropdowntoolbar.png "WebBrowserDropDownToolbar")

- **Set temporary breakpoints**. You can create a temporary breakpoint in the current line of code and start the debugger simultaneously. When you hit that line of code, the debugger enters break mode. For more information, see [Navigating through Code with the Debugger](../debugger/navigating-through-code-with-the-debugger.md).

    To use this feature, choose the **Ctrl**+**F10** keys, or open the shortcut menu for the line of code on which you want to break, and then choose **Run To Cursor**.

- **Move the execution point during debugging**. You can move the current execution point to a different section of code and then restart debugging from that point. This technique is useful if you want to debug a section of code without having to recreate all of the steps that are required to reach that section. For more information, see [Navigating through Code with the Debugger](../debugger/navigating-through-code-with-the-debugger.md).

     To move the execution point, drag the yellow arrowhead  to a location where you want to set the next statement in the same source file, and then choose the **F5** key to continue debugging.

- **Capture value information for variables**. You can add a DataTip to a variable in your code and pin it so that you can access the last known value for the variable after debugging has finished. For more information, see [View data values in Data Tips](../debugger/view-data-values-in-data-tips-in-the-code-editor.md).

     To add a DataTip, the debugger must be in break mode. Place the cursor on the variable, and then choose the pin button on the DataTip that appears. When debugging is stopped, a blue pin icon appears in the source file next to the line of code that contains the variable. If you point to the blue pin, the value of the variable from the most recent debugging session appears.

- **Clear the Immediate window**. You can erase the contents of the [Immediate Window](../ide/reference/immediate-window.md) at design time by entering `>cls` or `>Edit.ClearAll`

     For more information about additional commands, see [Visual Studio Command Aliases](../ide/reference/visual-studio-command-aliases.md).

## Accessing Visual Studio tools

You can quickly access the Developer Command Prompt, or another Visual Studio tool, if you pin it to the Start menu or the taskbar.

1. In Windows Explorer, browse to `%ProgramData%\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017\Visual Studio Tools`.

1. Right-click or open the context menu for **Developer Command Prompt**, and then choose **Pin to Start** or **Pin to taskbar**.

## Managing files, toolbars, and windows

At any one time, you may be working in multiple code files and moving among several tool windows as you develop an application. You can keep organized by using the following tips.

- **Keep files that you frequently use visible in the editor**. You can pin files to the left side of the tab well so that they remain visible regardless of how many files are open in the editor.

     To pin a file, choose the file's tab, and then choose the **Toggle Pin Status** button.

- **Move documents and windows to other monitors**. If you use more than one monitor when you develop applications, you can work on portions of your application more easily by moving files that are open in the editor to another monitor. You can also move tool windows, such as debugger windows, to another monitor and tab dock document and tool windows together to create "rafts." For more information, see [Customize window layouts in Visual Studio](../ide/customizing-window-layouts-in-visual-studio.md).

     You can also manage files more easily by creating another instance of **Solution Explorer** and moving it to another monitor. To create another instance of **Solution Explorer**, open a shortcut menu in **Solution Explorer**, and then choose **New Solution Explorer View**.

- **Customize the fonts that appear in Visual Studio**. You can change the font face, size, and color that's used for text in the IDE. For example, you can customize the color of specific code elements in the editor and the font face in tool windows or throughout the IDE. For more information, see [How to: Change Fonts and Colors](../ide/how-to-change-fonts-and-colors-in-visual-studio.md) and [How to: Change Fonts and Colors in the Editor](../ide/reference/how-to-change-fonts-and-colors-in-the-editor.md).

## See also

[Default Keyboard Shortcuts for Frequently Used Commands](../ide/default-keyboard-shortcuts-for-frequently-used-commands-in-visual-studio.md)  
[How to: Customize Menus and Toolbars](../ide/how-to-customize-menus-and-toolbars-in-visual-studio.md)  
[Walkthrough: Create a Simple Application](../ide/walkthrough-create-a-simple-application-with-visual-csharp-or-visual-basic.md)  
[Accessibility Tips and Tricks](../ide/reference/accessibility-tips-and-tricks.md)