---
title: "Finding and Replacing Text | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.find"
  - "vs.findreplacecontrol"
  - "vs.findreplace.findsymbol"
  - "vs.findreplace.symbol"
  - "findresultswindow"
  - "vs.findreplace.quickreplace"
  - "vs.findsymbol"
  - "vs.findinfiles"
  - "vs.findresults1"
  - "vs,findsymbolwindow"
  - "vs.findreplace.quickfind"
  - "vs.lookin"
  - "vs.replace"
helpviewer_keywords:
  - "text searches"
  - "Replace in Files dialog box"
  - "find, text"
  - "Find in Files dialog box"
  - "find"
  - "text searches, finding and replacing text"
  - "Replace dialog box"
  - "text, finding and replacing"
  - "find, symbol"
  - "find and replace"
  - "replace"
  - "find text"
  - "replacing text"
ms.assetid: a62545c3-1570-4d12-99fb-a82607eb35a1
caps.latest.revision: 35
author: jillre
ms.author: jillfra
manager: jillfra
---
# Finding and Replacing Text
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can find and replace text in the Visual Studio code editor, and certain text-based output windows such as the **Find Results** windows, using the **Find and Replace** control or **Find/Replace in Files**. You can also search and replace in some designer windows, such as the XAML designer and the Windows Forms designer, and tool windows

 You can scope searches to the current document, the current solution, or a custom set of folders. You can also specify a set of file name extensions for multi-file searches. You can customize search syntax by using .NET regular expressions.

 To find and replace regular expressions, see [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md).

> [!TIP]
> The **Find/Command** box is still available as a toolbar control, but is no longer visible by default. You can display the **Find/Command** box by choosing **Add or Remove Buttons** on the **Standard** toolbar and then choosing **Find**. For more information, see [Find/Command Box](../ide/find-command-box.md).

## Find and Replace control
 The **Find and Replace** control appears in the upper right corner of the code editor window. The **Find and Replace** control immediately highlights every occurrence of the given search string in the current document. You can navigate from one occurrence to another by choosing the **Find Next** button or the **Find Previous** button on the search control.

 You can access replacement options by choosing the button next to the **Find** text box. To make one replacement at a time, choose the **Replace Next** button next to the **Replace** text box. To replace all matches, choose the **Replace All** button.

 To change the highlight color for matches, choose the **Tools** menu, select **Options**, and then choose **Environment**, and select **Fonts and Colors**. In the **Show settings for** list, select **Text Editor**, and then in the **Display items** list, select **Find Highlight (Extension)**.

### Searching Tool Windows
 You can use the **Find** control in code or text windows, such as **Output** windows, and **Find Results** windows, by choosing **Find and Replace** on the **Edit** menu or (CTRL+F).

 A version of the Find control is also available in some tool windows. For example, you can now filter the list of controls in the **Toolbox** window by entering text in the search box. Other tool windows that now allow you to search their contents include **Solution Explorer**, the **Properties** window, and **Team Explorer**, among others.

## Find/Replace in Files
 **Find/Replace in Files** works like the **Find and Replace** control, except that you can define a scope for your search. Not only can you search the current open file in the editor, but you can also search all open documents, the entire solution, the current project, and selected folder sets. You can also search by file name extension. To access the **Find/Replace in Files** dialog box, choose **Find and Replace** on the **Edit** menu (or CTRL+SHIFT+F).

 When you choose **Find All**, a **Find Results** window opens and lists the matches for your search. Selecting a result in the list displays the associated file and highlights the match. If the file is not already open for editing, it is opened in a preview tab in the right side of the tab well. You can use the **Find** control to search through the **Find Results** list.

### Creating Custom Search Folder Sets
 You can define a search scope by choosing the **Choose Search Folders** button (it looks like **…**) next to the **Look in** box. In the **Choose Search Folders** dialog box, you can specify a set of folders in which to search, and you can save the specification so that you can reuse it later. You can specify folders on a remote machine only if you have mapped its drive to the local machine.

### Creating Custom Component Sets
 You can define component sets as your search scope by choosing the **Edit Custom Component Set** button next to the **Look in** box. You can specify installed .NET or COM components, Visual Studio projects that are included in your solution, or any assembly or type library (.dll, .tlb, .olb, .exe, or .ocx). To search references, select the **Look in references** box.

## See Also
 [Using Regular Expressions in Visual Studio](../ide/using-regular-expressions-in-visual-studio.md)
