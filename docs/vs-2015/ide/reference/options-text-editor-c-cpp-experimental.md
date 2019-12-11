---
title: "Options, Text Editor, C-C++, Experimental | Microsoft Docs"
ms.date: 11/15/2016
ms.topic: reference
f1_keywords:
  - "VS.ToolsOptionsPages.Text_Editor.C/C++.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C%2FC%2B%2B.Experimental"
  - "VS.ToolsOptionsPages.Text_Editor.C\\C++.Experimental"
ms.assetid: b9e9dda2-350c-460d-b368-37d6c5342eee
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options, Text Editor, C/C++, Experimental
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

By changing these options, you can change the behavior related to IntelliSense and the browsing database when you're programming in C or C++.

 To access this page, in the **Options** dialog box, in the left pane, expand **Text Editor**, expand **C/C++**, and then choose **Experimental**.

 These features are available in a Visual Studio 2015 Update 1 RC installation.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. See [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

## Browsing/Navigation
 **Enable New Database Engine**
 This should automatically speed up database population and make all database operations faster (with no loss in accuracy) for operations such as **Go To Definition** and **Find All References**. (Just close and reopen your solution to apply the changes; you do not have to restart Visual Studio.)

## IntelliSense
 **Member List Dot-To-Arrow**
 Replaces '.' with '->' when applicable for Member List.

## Refactoring
 **Enable Extract Function**
 Extract selected code to its own function and replace code with a call to the new function. To access this feature, right-click on the selected code and select **Quick Actions**, or simply press the default shortcut Ctrl+Dot [Ctrl+.].

 **Enable Change Signature**
 Add, reorder, and delete parameters of a function and propagate the changes to all call sites. To access this feature, right-click on any usage of the function and select **Quick Actions**, or simply press the default shortcut Ctrl+Dot [Ctrl+.].

## Text Editor
 **Enable Expand Scopes**
 If enabled, you can surround selected text with curly braces by typing '{' into the text editor.

 **Enable Expand Precedence**
 If enabled, you can surround selected text with parentheses by typing '(' into the text editor.

 For additional text editor features on the Visual Studio Gallery, see the list [here](https://go.microsoft.com/fwlink/?LinkId=692016). An example is [C++ Quick Fixes](https://visualstudiogallery.msdn.microsoft.com/be91feef-8dc3-4f7a-ac9f-f34e7ca5918f), which supports the following:

- **Add missing #include** - Suggests relevant #include's for unknown symbols in your code

- **Add using namespace/Fully qualify symbol** - Like the previous item, but for namespaces

- **Add missing semicolon**

- **MSDN Help** - Search MSDN for your error messages

  You can either hover over a squiggle to get a light bulb, or use the default keyboard shortcut Ctrl+Dot (Ctrl+.). Note that for the keyboard shortcut, your caret doesn't need to be positioned on the specific error or token; you can simply be on the same line as the error to invoke suggestions for anything on that line.

## See Also
 [Setting Language-Specific Editor Options](../../ide/reference/setting-language-specific-editor-options.md)
 [Refactoring in C++ (VC Blog)](https://devblogs.microsoft.com/cppblog/all-about-c-refactoring-in-visual-studio-2015-preview/)
