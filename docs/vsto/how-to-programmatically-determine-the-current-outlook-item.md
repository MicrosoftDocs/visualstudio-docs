---
title: "How to: Programmatically Determine the Current Outlook Item | Microsoft Docs"
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
  - "mail items [Office development in Visual Studio], current"
  - "e-mail [Office development in Visual Studio], current item"
  - "SelectionChange event"
  - "Outlook [Office development in Visual Studio], current item"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Determine the Current Outlook Item
  This example uses the Explorer.SelectionChange event to display the name of the current folder and some information about the selected item. The code then displays the selected item.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-vb[Trin_OL_CurrentItem#1](../vsto/codesnippet/VisualBasic/Trin_OL_CurrentItem/thisaddin.vb#1)]
 [!code-csharp[Trin_OL_CurrentItem#1](../vsto/codesnippet/CSharp/Trin_OL_CurrentItem/thisaddin.cs#1)]  
  
## Compiling the Code  
 This example requires:  
  
-   Appointment, contact, and e-mail items in Microsoft Office Outlook.  
  
## See Also  
 [Outlook Object Model Overview](../vsto/outlook-object-model-overview.md)   
 [How to: Programmatically Retrieve a Folder by Name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)   
 [How to: Programmatically Search for a Specific Contact](../vsto/how-to-programmatically-search-for-a-specific-contact.md)  
  
  