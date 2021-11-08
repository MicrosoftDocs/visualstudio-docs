---
title: "How to: Programmatically send email"
description: Use Visual Studio to programmatically send an email from Microsoft Outlook. This example sends an email message to contacts that have the domain name example.com.
ms.custom: SEO-VS-2020
ms.date: "08/14/2019"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "mail items [Office development in Visual Studio], sending e-mail"
  - "Outlook [Office development in Visual Studio], creating e-mail"
  - "Outlook [Office development in Visual Studio], sending e-mail"
  - "e-mail [Office development in Visual Studio], sending"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically send email
  This example sends an email message to contacts that have the domain name **example.com** in their email addresses.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_ProgramEMail/thisaddin.cs" id="Snippet1":::

## Compile the code
 This example requires:

- Contacts that have the domain name **example.com** in their email addresses.

## Robust programming
 Do not remove the filter code that searches for the domain name **example.com**. Your solution will send email messages to all of your contacts if you remove the filter.

## See also
- [Work with mail items](../vsto/working-with-mail-items.md)
- [How to: Programmatically create an email item](../vsto/how-to-programmatically-create-an-e-mail-item.md)
- [How to: Programmatically access Outlook contacts](../vsto/how-to-programmatically-access-outlook-contacts.md)
- [How to: Programmatically perform actions when an email message is received](../vsto/how-to-programmatically-perform-actions-when-an-e-mail-message-is-received.md)
