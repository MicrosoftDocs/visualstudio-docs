---
title: "How to: Programmatically Send E-Mail | Microsoft Docs"
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
  - "mail items [Office development in Visual Studio], sending e-mail"
  - "Outlook [Office development in Visual Studio], creating e-mail"
  - "Outlook [Office development in Visual Studio], sending e-mail"
  - "e-mail [Office development in Visual Studio], sending"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Send E-Mail  
  This example sends an e-mail message to contacts that have the domain name **example.com** in their e-mail addresses.  
  
 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_OL_ProgramEmail#1](../vsto/codesnippet/CSharp/Trin_OL_ProgramEMail/thisaddin.cs#1)]  
  
## Compiling the Code  
 This example requires:  
  
-   Contacts that have the domain name **example.com** in their e-mail addresses.  
  
## Robust Programming  
 Do not remove the filter code that searches for the domain name **example.com**. Your solution will send e-mail messages to all of your contacts if you remove the filter.  
  
## See Also  
 [Working with Mail Items](../vsto/working-with-mail-items.md)   
 [How to: Programmatically Create an E-Mail Item](../vsto/how-to-programmatically-create-an-e-mail-item.md)   
 [How to: Programmatically Access Outlook Contacts](../vsto/how-to-programmatically-access-outlook-contacts.md)   
 [How to: Programmatically Perform Actions When an E-Mail Message Is Received](../vsto/how-to-programmatically-perform-actions-when-an-e-mail-message-is-received.md)  
  
  