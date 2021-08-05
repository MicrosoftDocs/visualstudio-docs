---
title: "Save attachments from Outlook email items programmatically"
description: Learn how you can use Visual Studio to programmatically save attachments from Microsoft Outlook email items.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "Outlook [Office development in Visual Studio], attachments"
  - "e-mail [Office development in Visual Studio], attachments"
  - "saving e-mail attachments"
  - "mail items [Office development in Visual Studio], attachments"
  - "attachments [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically save attachments from Outlook email items

This example saves e-mail attachments to a specified folder when the mail is received in the inbox.

> [!IMPORTANT]
> This example works only if you add a folder named **TestFileSave** at the root of the C directory.

[!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example

:::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_SaveAttachments/thisaddin.cs" id="Snippet1":::

## See also

- [Work with mail items](../vsto/working-with-mail-items.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
- [How to: Programmatically perform actions when an email message is received](../vsto/how-to-programmatically-perform-actions-when-an-e-mail-message-is-received.md)
- [How to: Programmatically search within a specific folder](../vsto/how-to-programmatically-search-within-a-specific-folder.md)
