---
title: "How to: Programmatically Search for an E-Mail Address in Contacts | Microsoft Docs"
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
  - "e-mail [Office development in Visual Studio], searching"
  - "contacts [Office development in Visual Studio], searching"
  - "searching contacts"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Search for an E-Mail Address in Contacts
  This example searches a contact folder for contacts that have the domain name **example.com** in their e-mail addresses.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_SearchEmail#1](../vsto/codesnippet/CSharp/Trin_OL_SearchEmail/thisaddin.cs#1)]  
  
## Compiling the Code  
 This example requires:  
  
-   Contacts that have the domain name **example.com** in their e-mail addresses (for example, `somebody@example.com`), and that have first names and last names.  
  
## See Also  
 [Working with Contact Items](../vsto/working-with-contact-items.md)   
 [How to: Programmatically Send E-Mail](../vsto/how-to-programmatically-send-e-mail-programmatically.md)   
 [How to: Programmatically Access Outlook Contacts](../vsto/how-to-programmatically-access-outlook-contacts.md)   
 [How to: Programmatically Add an Entry to Outlook Contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md)  
  
  