---
title: "Visual Basic IntelliSense | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IntelliSense [Visual Basic]"
  - "IntelliSense [Visual Studio], Visual Basic"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
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

You can manually invoke completion by invoking List Members, Complete Word, or ALT+RIGHT ARROW. For more information, see [Using IntelliSense](../ide/using-intellisense.md).

## IntelliSense in Zone

IntelliSense in Zone assists Visual Basic developers who need to deploy applications through [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] and are constrained to partial trust settings. This feature:

- Enables you to choose the permissions the application will run with.

- Display APIs in the chosen Zone as available in List Members, and display APIs that require additional permissions as unavailable.

For more information, see [Code Access Security for ClickOnce Applications](../deployment/code-access-security-for-clickonce-applications.md).

## Filtered completion lists

In Visual Basic, IntelliSense completion lists have two tab controls located near the bottom of the lists. The **Common** tab, which is selected by default, displays items that are most often used to complete the statement that you are writing. The **All** tab displays all items that are available for automatic completion, including those that are also on the **Common** tab.

## See also

[Using IntelliSense](../ide/using-intellisense.md)