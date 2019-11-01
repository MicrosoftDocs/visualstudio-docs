---
title: Find and replace text, and multi-caret selection
ms.date: 08/14/2018
ms.topic: conceptual
f1_keywords:
  - "vs.find"
  - "vs.findreplacecontrol"
  - "vs.findreplace.findsymbol"
  - "vs.findreplace.symbol"
  - "findresultswindow"
  - "vs.findreplace.quickreplace"
  - "vs.findsymbol"
  - "vs.findresults1"
  - "vs,findsymbolwindow"
  - "vs.findreplace.quickfind"
  - "vs.lookin"
  - "vs.replace"
helpviewer_keywords:
  - "text searches"
  - "Replace in Files dialog box"
  - "Find in Files dialog box"
  - "text searches, finding and replacing text"
  - "text, finding and replacing"
  - "find and replace"
  - "find text"
  - "replace text"
  - "multi-caret selection"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Find and replace text

You can find and replace text in the Visual Studio editor by using [Find and Replace](#find-and-replace-control) (**Ctrl**+**F** or **Ctrl**+**H**) or [Find/Replace in Files](#find-in-files-and-replace-in-files) (**Ctrl**+**Shift**+**F** or **Ctrl**+**Shift**+**H**). You can also find and replace only *some* instances of a pattern by using *[multi-caret selection](#multi-caret-selection)*.

> [!TIP]
> If you're renaming code symbols such as variables and methods, it's better to *[refactor](../ide/reference/rename.md)* them than to use find-and-replace. Refactoring is intelligent and understands scope, whereas find-and-replace blindly replaces all instances.

Find-and-replace functionality is available in the editor, in certain other text-based windows such as the **Find Results** windows, in designer windows such as the XAML designer and Windows Forms designer, and in tool windows.

You can scope searches to the current document, the current solution, or a custom set of folders. You can also specify a set of file name extensions for multi-file searches. Customize search syntax by using .NET [regular expressions](../ide/using-regular-expressions-in-visual-studio.md).

> [!TIP]
> The [Find/Command](../ide/find-command-box.md) box is available as a toolbar control, but isn't visible by default. To display the **Find/Command** box, select **Add or Remove Buttons** on the **Standard** toolbar, and then select **Find**.

## Find and Replace control

- Press **Ctrl**+**F** as a shortcut to *find* a string in the current file.
- Press **Ctrl**+**H** as a shortcut to *find and replace* a string in the current file.

The **Find and Replace** control appears in the upper right corner of the code editor window. It immediately highlights every occurrence of the given search string in the current document. You can navigate from one occurrence to another by choosing the **Find Next** button or the **Find Previous** button on the search control.

![Find and Replace in Visual Studio](media/find-and-replace-box.png)

You can access replacement options by choosing the button next to the **Find** text box. To make one replacement at a time, choose the **Replace Next** button next to the **Replace** text box. To replace all matches, choose the **Replace All** button.

To change the highlight color for matches, choose the **Tools** menu, select **Options**, and then choose **Environment**, and select **Fonts and Colors**. In the **Show settings for** list, select **Text Editor**, and then in the **Display items** list, select **Find Highlight (Extension)**.

### Search tool windows

You can use the **Find** control in code or text windows, such as **Output** windows and **Find Results** windows, by selecting **Edit** > **Find and Replace** or pressing **Ctrl+F**.

A version of the **Find** control is also available in some tool windows. For example, you can filter the list of controls in the **Toolbox** window by entering text in the search box. Other tool windows that allow you to search their contents include **Solution Explorer**, the **Properties** window, and **Team Explorer**.

## Find in Files and Replace in Files

- Press **Ctrl**+**Shift**+**F** as a shortcut to *find* a string in multiple files.
- Press **Ctrl**+**Shift**+**H** as a shortcut to *find and replace* a string in multiple files.

**Find/Replace in Files** works like the **Find and Replace** control, except that you can define a scope for your search. Not only can you search the current open file in the editor, but also all open documents, the entire solution, the current project, and selected folder sets. You can also search by file name extension. To access the **Find/Replace in Files** dialog box, select **Find and Replace** on the **Edit** menu (or press **Ctrl**+**Shift**+**F**).

![Find in Files in Visual Studio](media/find-in-files-box.png)

### Find Results

When you choose **Find All**, a **Find Results** window opens and lists the matches for your search. Selecting a result in the list displays the associated file and highlights the match. If the file is not already open for editing, it is opened in a preview tab in the right side of the tab well. You can use the **Find** control to search through the **Find Results** list.

### Create custom search folder sets

You can define a search scope by choosing the **Choose Search Folders** button (it looks like **...**) next to the **Look in** box. In the **Choose Search Folders** dialog box, you can specify a set of folders to search, and you can save the specification so that you can reuse it later.

> [!TIP]
> If you've mapped a remote machine's drive to your local machine, you can specify folders to search on the remote machine.

### Create custom component sets

You can define component sets as your search scope by choosing the **Edit Custom Component Set** button next to the **Look in** box. You can specify installed .NET or COM components, Visual Studio projects that are included in your solution, or any assembly or type library (*.dll*, *.tlb*, *.olb*, *.exe*, or *.ocx*). To search references, select the **Look in references** box.

## Multi-caret selection

> [!NOTE]
> This section applies to Visual Studio on Windows. For Visual Studio for Mac, see [Block selection](/visualstudio/mac/block-selection).

**Introduced in Visual Studio 2017 version 15.8**

Use *multi-caret selection* to make the same edit in two or more places at the same time. For example, you can insert the same text or modify existing text in multiple locations at the same time.

In the following screenshot, `-0000` is selected in three locations; if the user presses **Delete**, all three selections are deleted:

![Multi-caret selection in an XML file in Visual Studio](media/multi-caret-selection.png)

To select multiple carets, click or make first text selection as usual, and then press **Alt** while you click or select text in each additional location. You can also automatically add matching text as additional selections, or select a box of text to edit identically on each line.

> [!TIP]
> If you've selected **Alt** as the modifier key for mouse-click Go to Definition in **Tools** > **Options**, multi-caret select is disabled.

### Commands

Use the following keys and actions for multi-caret selection behaviors:

|Shortcut|Action|
|-|-|
|**Ctrl**+**Alt** + click|Add a secondary caret|
|**Ctrl**+**Alt** + double-click|Add a secondary word selection|
|**Ctrl**+**Alt** + click + drag|Add a secondary selection|
|**Shift**+**Alt**+**.**|Add the next matching text as a selection|
|**Ctrl**+**Shift**+**Alt**+**,**|Add all matching text as selections|
|**Shift**+**Alt**+**,**|Remove last selected occurrence|
|**Ctrl**+**Shift**+**Alt**+**.**|Skip next matching occurrence|
|**Alt** + click|Add a box selection|
|**Esc** or click|Clear all selections|

Some of the commands are also available on the **Edit** menu, under **Multiple Carets**:

![Multiple carets fly-out menu in Visual Studio](media/edit-menu-multiple-carets.png)

## See also

- [Use regular expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md)
- [Refactor code in Visual Studio](../ide/refactoring-in-visual-studio.md)
- [Block selection (Visual Studio for Mac)](/visualstudio/mac/block-selection)