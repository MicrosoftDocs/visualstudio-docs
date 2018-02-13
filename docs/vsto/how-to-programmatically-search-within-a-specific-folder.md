---
title: "How to: Programmatically Search Within a Specific Folder | Microsoft Docs"
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
  - "Outlook folders [Office development in Visual Studio], searching"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Search Within a Specific Folder
  This code example uses the `Find` and `FindNext` methods to search for text in the subject field of e-mail messages that are in the **Inbox**. This method uses a string filter to check for the letter T as the starting letter of the `Subject` text.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_SearchFolder#1](../vsto/codesnippet/CSharp/Trin_OL_SearchFolder/thisaddin.cs#1)]  
  
## See Also  
 [Working with Folders](../vsto/working-with-folders.md)   
 [Outlook Object Model Overview](../vsto/outlook-object-model-overview.md)   
 [How to: Programmatically Retrieve a Folder by Name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)  
  
  