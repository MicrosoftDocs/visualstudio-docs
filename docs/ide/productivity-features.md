---
title: Productivity tips
ms.date: 2/21/2019
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Productivity tips for Visual Studio

This articles discusses tips for Visual Studio features that help you write, navigate, and debug your code more quickly and efficiently.

For information about helpful keyboard shortcuts, see [Productivity shortcuts](../ide/productivity-shortcuts.md). For a complete list of command shortcuts, see [Default keyboard shortcuts](../ide/default-keyboard-shortcuts-in-visual-studio.md).

## Write code

Write code more quickly by using the following features.

- **Use convenience commands**. Visual Studio contains various commands to help you accomplish common editing tasks faster. For example, you can choose a command to easily duplicate a line of code without having to copy it, reposition the cursor, and then paste it. Choose **Edit** > **Duplicate** or press **Ctrl**+**E**,**V**. You can also quickly expand or contract a selection of text by choosing **Edit** > **Advanced** > **Expand Selection** or **Edit** > **Advanced** > **Contract Selection**, or by pressing **Shift**+**Alt**+**=** or **Shift**+**Alt**+**-**.

- **Use IntelliSense**. As you enter code in the editor, IntelliSense information, such as List Members, Parameter Info, Quick Info, Signature Help, and Complete Word, appears. These features support fuzzy matching of text; for example, the results lists for List Members includes not only entries that start with the characters that you have entered but also entries that contain the character combination anywhere in their names. For more information, see [Use IntelliSense](../ide/using-intellisense.md).

- **Change auto-insertion of IntelliSense options as you enter code**. By switching IntelliSense to suggestion mode, you can specify that IntelliSense options are inserted only if you explicitly choose them.

     To enable suggestion mode, choose the **Ctrl**+**Alt**+**Spacebar** keys, or, on the menu bar, choose **Edit** > **IntelliSense** > **Toggle Completion Mode**.

- **Use code snippets**. You can use built-in snippets, or create your own snippets.

     To insert a snippet, on the menu bar, choose **Edit** > **IntelliSense** > **Insert Snippet** or **Surround With**, or open the shortcut menu in a file and choose **Snippet** > **Insert Snippet** or **Surround With**. For more information, see [Code Snippets](../ide/code-snippets.md).

- **Fix code errors inline**. Quick Actions let you easily refactor, generate, or otherwise modify code with a single action. These actions can be applied using the screwdriver ![Screwdriver icon](media/screwdriver-icon.png) or light bulb ![Light bulb icon](media/light-bulb-icon.png) icons, or by pressing **Alt**+**Enter** or **Ctrl**+**.** when your cursor is on the appropriate line of code. See [Quick Actions](quick-actions.md) for more information.

- **Show and edit the definition of a code element**. You can quickly show and edit the module in which a code element, such as a member, a variable, or a local, is defined.

    To open a definition in a pop-up window, highlight the element and then choose the **Alt**+**F12** keys, or open the shortcut menu for the element and then choose **Peek Definition**. To open a definition in a separate code window, open the shortcut menu for the element, and then choose **Go to Definition**.

- **Use sample applications**. You can speed up application development by downloading and installing sample applications from [Microsoft Developer Network](https://code.msdn.microsoft.com/). You can also learn a particular technology or programming concept by downloading and exploring a Sample Pack for that area.

## Navigate within your code

You can use various techniques to find and move to specific locations in your code more quickly.

- **Bookmark lines of code**. You can use bookmarks to navigate quickly to specific lines of code in a file.

    To set a bookmark, on the menu bar, choose **Edit** > **Bookmarks** > **Toggle Bookmark**. You can view all of the bookmarks for a solution in the **Bookmarks** window. For more information, see [Set bookmarks in code](../ide/setting-bookmarks-in-code.md).

- **Search for symbol definitions in a file**. You can search within a solution to locate symbol definitions and file names, but search results don't include namespaces or local variables.

   To access this feature, on the menu bar, choose **Edit** > **Navigate To**.

- **Browse the overall structure of your code**. In **Solution Explorer**, you can search and browse classes and their types and members in your projects. You can also search for symbols, view a method's Call Hierarchy, find symbol references, and perform other tasks. If you choose a code element in **Solution Explorer**, the associated file opens in a **Preview** tab, and the cursor moves to the element in the file. For more information, see [View the structure of code](../ide/viewing-the-structure-of-code.md).

## Find items faster

You can search across the IDE for commands, files, and options, in addition to filtering the contents of tool windows to show only relevant information for your current task.

- **Filter the contents of tool windows**. You can search within the contents of many tool windows, such as the **Toolbox**, the **Properties** window, and **Solution Explorer**, but display only items whose names contain the characters that you specify.

- **Display only the errors you want to address**. If you choose the **Filter** button on the **Error List** toolbar, you can reduce the number of errors that appear in the **Error List** window. You can display only the errors in the files that are open in the editor, only the errors in the current file, or only the errors in the current project. You can also search within the **Error List** window to find specific errors.

- **Find dialog boxes, menu commands, options, and more**. In the search box, enter keywords or phrases for the items that you're trying to find. For example, the following options appear if you enter **new project**:

   ::: moniker range="vs-2017"

   ![Quick Launch Results for 'new project'](../ide/media/productivity_quicklaunch.png)

   **Quick Launch** displays links to create a new project, to add a new item to a project, and to the **Projects and Solutions** page in the **Options** dialog box, among others. Search results can also include project files and tool windows.

   ::: moniker-end

   ::: moniker range=">=vs-2019"

   ![Search results for 'new project'](../ide/media/vs-2019/productivity-quick-launch-new-project.png)

   ::: moniker-end

   Press **Ctrl**+**Q** to jump straight to the search box.

## Debug code

Debugging can consume a lot of time, but the following tips can help you speed up the process.

- **Test the same page, application, or site in different browsers**. As you debug your code, you can easily switch among the installed web browsers, including [Page Inspector (Visual Studio)](https://msdn.microsoft.com/Library/65880969-1ad2-47be-85b9-bb12c81bf209), without having to open the **Browse With** dialog box. You can use the **Debug Target** list, which is on the **Standard** toolbar next to the **Start Debugging** button, to quickly verify which browser you're using as you debug or view pages.

    ![Select web browser debug options](../ide/media/webbrowserdropdowntoolbar.png)

- **Set temporary breakpoints**. You can create a temporary breakpoint in the current line of code and start the debugger simultaneously. When you hit that line of code, the debugger enters break mode. For more information, see [Navigate through code with the debugger](../debugger/navigating-through-code-with-the-debugger.md).

    To use this feature, choose the **Ctrl**+**F10** keys, or open the shortcut menu for the line of code on which you want to break, and then choose **Run To Cursor**.

- **Move the execution point during debugging**. You can move the current execution point to a different section of code and then restart debugging from that point. This technique is useful if you want to debug a section of code without having to recreate all of the steps that are required to reach that section. For more information, see [Navigate through code with the debugger](../debugger/navigating-through-code-with-the-debugger.md).

     To move the execution point, drag the yellow arrowhead  to a location where you want to set the next statement in the same source file, and then choose the **F5** key to continue debugging.

- **Capture value information for variables**. You can add a DataTip to a variable in your code and pin it so that you can access the last known value for the variable after debugging has finished. For more information, see [View data values in Data Tips](../debugger/view-data-values-in-data-tips-in-the-code-editor.md).

     To add a DataTip, the debugger must be in break mode. Place the cursor on the variable, and then choose the pin button on the DataTip that appears. When debugging is stopped, a blue pin icon appears in the source file next to the line of code that contains the variable. If you point to the blue pin, the value of the variable from the most recent debugging session appears.

- **Clear the Immediate window**. You can erase the contents of the [Immediate window](../ide/reference/immediate-window.md) at design time by entering `>cls` or `>Edit.ClearAll`

     For more information about additional commands, see [Visual Studio command aliases](../ide/reference/visual-studio-command-aliases.md).

## Access Visual Studio tools

You can quickly access the Developer Command Prompt, or another Visual Studio tool, if you pin it to the Start menu or the taskbar.

::: moniker range="vs-2017"

1. In Windows Explorer, browse to *%ProgramData%\Microsoft\Windows\Start Menu\Programs\Visual Studio 2017\Visual Studio Tools*.

::: moniker-end

::: moniker range=">=vs-2019"

1. In Windows Explorer, browse to *%ProgramData%\Microsoft\Windows\Start Menu\Programs\Visual Studio 2019\Visual Studio Tools*.

::: moniker-end

2. Right-click or open the context menu for **Developer Command Prompt**, and then choose **Pin to Start** or **Pin to taskbar**.

## Manage files, toolbars, and windows

At any one time, you may be working in multiple code files and moving among several tool windows as you develop an application. You can keep organized by using the following tips:

- **Keep files that you frequently use visible in the editor**. You can pin files to the left side of the tab well so that they remain visible regardless of how many files are open in the editor.

   To pin a file, choose the file's tab, and then choose the **Toggle Pin Status** button.

- **Move documents and windows to other monitors**. If you use more than one monitor when you develop applications, you can work on portions of your application more easily by moving files that are open in the editor to another monitor. You can also move tool windows, such as debugger windows, to another monitor and tab dock document and tool windows together to create "rafts." For more information, see [Customize window layouts in Visual Studio](../ide/customizing-window-layouts-in-visual-studio.md).

   You can also manage files more easily by creating another instance of **Solution Explorer** and moving it to another monitor. To create another instance of **Solution Explorer**, open a shortcut menu in **Solution Explorer**, and then choose **New Solution Explorer View**.

- **Customize the fonts that appear in Visual Studio**. You can change the font face, size, and color that's used for text in the IDE. For example, you can customize the color of specific code elements in the editor and the font face in tool windows or throughout the IDE. For more information, see [How to: Change fonts and colors](../ide/how-to-change-fonts-and-colors-in-visual-studio.md) and [How to: Change fonts and colors in the editor](../ide/reference/how-to-change-fonts-and-colors-in-the-editor.md).

## See also

- [Visual Studio tips and tricks blog post](https://devblogs.microsoft.com/visualstudio/visual-studio-tips-and-tricks/)
- [Default keyboard shortcuts for frequently used commands](../ide/default-keyboard-shortcuts-for-frequently-used-commands-in-visual-studio.md)
- [How to: Customize menus and toolbars](../ide/how-to-customize-menus-and-toolbars-in-visual-studio.md)
- [Walkthrough: Create a simple application](../get-started/csharp/tutorial-wpf.md)
- [Accessibility tips and tricks](../ide/reference/accessibility-tips-and-tricks.md)
