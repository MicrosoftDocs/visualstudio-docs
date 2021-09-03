---
title: "Find an email address in contacts programmatically"
description: Learn how you can use Visual Studio to programmatically find an email address in your Microsoft Outlook contacts.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "e-mail [Office development in Visual Studio], searching"
  - "contacts [Office development in Visual Studio], searching"
  - "searching contacts"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically search for an email address in contacts
  This example searches a contact folder for contacts that have the domain name **example.com** in their e-mail addresses.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_SearchEmail/thisaddin.cs" id="Snippet1":::

## Compile the code
 This example requires:

- Contacts that have the domain name **example.com** in their e-mail addresses (for example, `somebody@example.com`), and that have first names and last names.

## See also
- [Work with contact items](../vsto/working-with-contact-items.md)
- [How to: Programmatically send email](../vsto/how-to-programmatically-send-e-mail-programmatically.md)
- [How to: Programmatically access Outlook contacts](../vsto/how-to-programmatically-access-outlook-contacts.md)
- [How to: Programmatically add an entry to Outlook contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md)
