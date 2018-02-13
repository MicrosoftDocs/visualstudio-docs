---
title: "How to: Programmatically Associate a Web Page with an Outlook Folder | Microsoft Docs"
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
  - "folders [Office development in Visual Studio], Web pages and"
  - "Outlook [Office development in Visual Studio], Web pages attached to folders"
  - "Web pages [Office development in Visual Studio], Outlook folders"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Associate a Web Page with an Outlook Folder
  This example checks for a folder named `HtmlView` in Microsoft Office Outlook. If the folder does not exist, the code creates the folder and assigns a Web page to it. If the folder exists, the code displays the folder contents.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_HTMLFolder#1](../vsto/codesnippet/CSharp/Trin_OL_HTMLFolder/thisaddin.cs#1)]  
  
## See Also  
 [Working with Folders](../vsto/working-with-folders.md)   
 [How to: Programmatically Retrieve a Folder by Name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)   
 [How to: Programmatically Create Custom Folder Items](../vsto/how-to-programmatically-create-custom-folder-items.md)  
  
  