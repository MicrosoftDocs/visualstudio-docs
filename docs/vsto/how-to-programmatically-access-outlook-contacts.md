---
title: "How to: Programmatically Access Outlook Contacts | Microsoft Docs"
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
  - "contacts [Office development in Visual Studio], searching"
ms.assetid: ea2297ea-6802-40e4-af1a-1e511a71ec75
caps.latest.revision: 23
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# How to: Programmatically Access Outlook Contacts
  This example finds all contacts whose last names contain a specified search string.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_AccessContacts#1](../vsto/codesnippet/CSharp/Trin_OL_AccessContacts.trin_ol_accesscontacts/thisaddin.cs#1)]
 [!code-csharp[Trin_OL_AccessContacts#1](../vsto/codesnippet/CSharp/Trin_OL_AccessContacts.trin_ol_accesscontacts/thisaddin.cs#1)]
 [!code-vb[Trin_OL_AccessContacts#1](../vsto/codesnippet/VisualBasic/Trin_OL_AccessContacts/thisaddin.vb#1)]  
  
## Compiling the Code  
 This example requires:  
  
-   Contacts whose last names contain the string "**Na"** (for example, Tzipi Butnaru) in the **Contacts** folder.  
  
## See Also  
 [Working with Contact Items](../vsto/working-with-contact-items.md)   
 [How to: Programmatically Add an Entry to Outlook Contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md)   
 [How to: Programmatically Search for a Specific Contact](../vsto/how-to-programmatically-search-for-a-specific-contact.md)   
 [How to: Programmatically Search for an E-Mail Address in Contacts](../vsto/how-to-programmatically-search-for-an-e-mail-address-in-contacts.md)   
 [How to: Programmatically Delete Outlook Contacts](../vsto/how-to-programmatically-delete-outlook-contacts.md)  
  
  