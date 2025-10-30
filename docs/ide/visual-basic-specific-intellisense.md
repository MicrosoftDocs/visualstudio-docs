---
title: Visual Basic IntelliSense
description: Learn how to use the IntelliSense features offered by the Visual Basic source code editor.
ms.date: 11/04/2016
ms.topic: article
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.Basic.IntelliSense
helpviewer_keywords:
- IntelliSense [Visual Basic]
- IntelliSense [Visual Studio], Visual Basic
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# IntelliSense for Visual Basic code files

The Visual Basic source code editor offers the following IntelliSense features:

## Syntax tips

Syntax tips display the syntax of the statement that you are typing. This is useful for statements such as [Declare](/dotnet/visual-basic/language-reference/statements/declare-statement).

## Automatic completion

- Completion on various keywords

     For example, if you type `goto` and a space, IntelliSense displays a list of the defined labels in a drop-down menu. Other supported keywords include `Exit`, `Implements`, `Option`, and `Declare`.

- Completion on `Enum` and `Boolean`

    When a statement will refer to a member of an enumeration, IntelliSense displays a list of the members of the `Enum`. When a statement will refer to a `Boolean`, IntelliSense displays a true-false drop-down menu.

Completion can be turned off by default by deselecting **Auto list members** from the **General** property page in the **Visual Basic** folder.

You can manually invoke completion by invoking List Members, Complete Word, or **Alt**+**Right Arrow**. For more information, see [Use IntelliSense](../ide/using-intellisense.md).

## IntelliSense in Zone

IntelliSense in Zone assists Visual Basic developers who need to deploy applications through ClickOnce and are constrained to partial trust settings. This feature:

- Enables you to choose the permissions the application will run with.

- Display APIs in the chosen Zone as available in List Members, and display APIs that require additional permissions as unavailable.

For more information, see [Code access security for ClickOnce applications](../deployment/code-access-security-for-clickonce-applications.md).

## Filtered completion lists

In Visual Basic, IntelliSense completion lists have two tab controls located near the bottom of the lists. The **Common** tab, which is selected by default, displays items that are most often used to complete the statement that you are writing. The **All** tab displays all items that are available for automatic completion, including those that are also on the **Common** tab.

## Related content

- [Use IntelliSense](../ide/using-intellisense.md)
