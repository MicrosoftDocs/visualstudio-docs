---
title: "Code Snippet Picker | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.expansionpicker"
helpviewer_keywords: 
  - "Code Snippet Picker"
  - "IntelliSense code snippets, Code Snippet Picker"
  - "code snippets, Code Snippet Picker"
ms.assetid: f0862d48-fbbc-4cfe-b228-24492d5c89c4
caps.latest.revision: 25
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Code Snippet Picker
The [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Code Editor provides a **Code Snippet Picker** that allows you, in a few mouse clicks, to insert ready-made blocks of code into the active document.  
  
 The procedure to display the **Code Snippet Picker** varies according to the language you are using.  
  
-   [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] - Right-click at the desired location in the Code Editor to display the Shortcut menu, and select **Insert Snippet**.  
  
-   [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.  
  
-   [!INCLUDE[vcprvc](../../code-quality/includes/vcprvc_md.md)] - The **Code Snippet Picker** is not available.  
  
-   Visual F# - The **Code Snippet Picker** is not available.  
  
-   [!INCLUDE[jsprjscript](../../debugger/debug-interface-access/includes/jsprjscript_md.md)] -- Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.  
  
-   XML - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.  
  
-   HTML - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet** or **Surround With**.  
  
-   SQL - Right-click at the desired location in the Code Editor to display the Shortcut menu, and click **Insert Snippet**.  
  
 In most Visual Studio development languages, you can use the **Code Snippets Manager** to add folders to the **Folder List** that the **Code Snippet Picker** scans for XML snippet files. You can also create your own snippets to add to the list. For more information, see [Walkthrough: Creating a Code Snippet](../../ide/walkthrough-creating-a-code-snippet.md).  
  
## UIElement List  
 Item Name  
 An editable text field that displays the name of the item selected in the **Item List**. To perform an incremental search for the item you want, begin typing its name in this field. Continue adding letters until the desired item is selected in the **Item List**.  
  
 Item List  
 A list of code snippets available for insertion, or a list of folders containing code snippets. To insert a snippet or expand a folder, select the item you want and press Enter.  
  
## See Also  
 [Best Practices for Using Code Snippets](../../ide/best-practices-for-using-code-snippets.md)   
 [Visual Basic IntelliSense Code Snippets](/dotnet/visual-basic/developing-apps/using-ide/intellisense-code-snippets)   
 [Setting Bookmarks in Code](../../ide/setting-bookmarks-in-code.md)   
 [How to: Use Surround-with Code Snippets](../../ide/how-to-use-surround-with-code-snippets.md)