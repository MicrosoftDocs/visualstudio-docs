---
title: "Code Snippet Picker | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vs.expansionpicker"
helpviewer_keywords:
  - "Code Snippet Picker"
  - "IntelliSense code snippets, Code Snippet Picker"
  - "code snippets, Code Snippet Picker"
ms.assetid: f0862d48-fbbc-4cfe-b228-24492d5c89c4
caps.latest.revision: 29
author: jillre
ms.author: jillfra
manager: jillfra
---
# Code Snippet Picker
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] Code Editor provides a **Code Snippet Picker** that allows you, in a few mouse clicks, to insert ready-made blocks of code into the active document.

 The procedure to display the **Code Snippet Picker** varies according to the language you are using.

- [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] - Right-click at the desired location in the Code Editor to display the Shortcut menu, and select **Insert Snippet**.

- [!INCLUDE[csprcs](../../includes/csprcs-md.md)] - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.

- [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] - The **Code Snippet Picker** is not available.

- Visual F# - The **Code Snippet Picker** is not available.

- [!INCLUDE[jsprjscript](../../includes/jsprjscript-md.md)] -- Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.

- XML - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.

- HTML - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.

- SQL - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet**.

  In most Visual Studio development languages, you can use the **Code Snippets Manager** to add folders to the **Folder List** that the **Code Snippet Picker** scans for XML snippet files. You can also create your own snippets to add to the list. For more information, see [Walkthrough: Creating a Code Snippet](../../ide/walkthrough-creating-a-code-snippet.md).

## UIElement List
 Item Name
 An editable text field that displays the name of the item selected in the **Item List**. To perform an incremental search for the item you want, begin typing its name in this field. Continue adding letters until the desired item is selected in the **Item List**.

 Item List
 A list of code snippets available for insertion, or a list of folders containing code snippets. To insert a snippet or expand a folder, select the item you want and press Enter.

## See Also
 [Best Practices for Using Code Snippets](../../ide/best-practices-for-using-code-snippets.md)
 [Visual Basic IntelliSense Code Snippets](https://msdn.microsoft.com/library/ffdde4c9-8141-4906-b09b-15181357a643)
 [Setting Bookmarks in Code](../../ide/setting-bookmarks-in-code.md)
 [How to: Use Surround-with Code Snippets](../../ide/how-to-use-surround-with-code-snippets.md)
