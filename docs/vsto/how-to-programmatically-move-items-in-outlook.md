---
title: "How to: Programmatically Move Items in Outlook | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Outlook folders [Office development in Visual Studio], moving items"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Move Items in Outlook
  This example moves unread e-mail messages from the **Inbox** to a folder named **Test**. The example only moves messages that have the word **Test** in the `Subject` field.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_MoveItems#1](../vsto/codesnippet/CSharp/Trin_OL_MoveItems/thisaddin.cs#1)]  
  
## Compiling the Code  
 This example requires:  
  
-   An Outlook mail folder named **Test**.  
  
-   An e-mail message that arrives with the word **Test** in the `Subject` field.  
  
## See Also  
 [Working with Folders](../vsto/working-with-folders.md)   
 [How to: Programmatically Retrieve a Folder by Name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)   
 [How to: Programmatically Search Within a Specific Folder](../vsto/how-to-programmatically-search-within-a-specific-folder.md)   
 [How to: Programmatically Perform Actions When an E-Mail Message Is Received](../vsto/how-to-programmatically-perform-actions-when-an-e-mail-message-is-received.md)  
  
  