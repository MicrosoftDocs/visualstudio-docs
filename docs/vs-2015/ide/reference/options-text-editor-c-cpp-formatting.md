---
title: "Options, Text Editor, C-C++, Formatting | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Formatting.General"
  - "VS.ToolsOptionsPages.Text_Editor.C%2fC%2b%2b.Formatting.General"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "Text Editor Options dialog box, formatting"
ms.assetid: cb6f1cbb-5305-48da-a8e8-33fd70775d46
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, C/C++, Formatting
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Lets you change the default behavior of the Code Editor when you are programming in C or C++.

 To access this page, in the **Options** dialog box, in the left pane, expand **Text Editor**, expand **C/C++**, and then click **Formatting**.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## C/C++ Options
 **Enable automatic Quick Info ToolTips**
 Enables or disables the Quick Info IntelliSense feature.

## Inactive Code
 **Show Inactive Code Blocks**
 Code that is inactive due to `#ifdef` declarations are colorized differently to help you identify it.

 **Disable Inactive Code Opacity**
 Inactive code can be identified by using color instead of transparency.

 **Inactive Code Opacity Percent**
 The degree of opacity for inactive code blocks can be customized.

## Indentation
 **Indent Braces**
 You can configure how braces are aligned when you press ENTER after you begin a code block, for example, a function or a `for` loop. The braces can either be aligned with the first character of the code block or indented.

 **Automatic Indentation On Tab**
 You can configure what happens on the current code line when you press TAB. Either the line is indented or a tab is inserted.

## Miscellaneous
 **Enumerate the comments in the Task List window**
 The editor can scan open source files for preset words in the comments. It creates an entry in the **Task List** window for any keywords that it finds.

 **Highlight Matching Tokens**
 When the cursor is next to a brace, the editor can highlight the matching brace so that you can more easily see the contained code.

## Outlining
 **Enter outlining mode when files open**
 When you bring a file into the text editor, you can enable the outlining feature. For more information, see [Outlining](../../ide/outlining.md). When this option is selected, the outlining feature is enabled when you open a file.

 **Automatic outlining of #pragma region blocks**
 When this option is selected, automatic outlining for [pragma directives](https://msdn.microsoft.com/library/9867b438-ac64-4e10-973f-c3955209873f) is enabled. This lets you expand or collapse pragma region blocks in outlining mode.

 **Automatic outlining of statement blocks**
 When this option is selected, automatic outlining is enabled for the following statement constructs:

- [if-else](https://msdn.microsoft.com/library/d9a1d562-8cf5-4bd4-9ba7-8ad970cd25b2)

- [switch Statement (C++)](https://msdn.microsoft.com/library/6c3f3ed3-5593-463c-8f4b-b33742b455c6)

- [while Statement (C++)](https://msdn.microsoft.com/library/358dbe76-5e5e-4af5-b575-c2293c636899)

## See Also
 [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
 [Using IntelliSense](../../ide/using-intellisense.md)
