---
title: "How to: Programmatically search for a specific contact"
description: Learn how you can use Visual Studio to programmatically search for a specific contact in Microsoft Outlook.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "contacts [Office development in Visual Studio], searching"
  - "searching contacts"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically search for a specific contact
  This example searches an Outlook contacts folder for a specific contact by first and last name. The example assumes that a contact named **John Evans** exists in the contacts folder.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-csharp[Trin_Outlook_RL_SearchForContact#1](../vsto/codesnippet/CSharp/trin_outlook_rl_searchforcontact/thisaddin.cs#1)]
 [!code-vb[Trin_Outlook_RL_SearchForContact#1](../vsto/codesnippet/VisualBasic/trin_outlook_rl_searchforcontact/thisaddin.vb#1)]

## See also
- [Work with contact items](../vsto/working-with-contact-items.md)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
