---
title: "How to: Programmatically move items in Outlook"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Outlook folders [Office development in Visual Studio], moving items"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically move items in Outlook
  This example moves unread e-mail messages from the **Inbox** to a folder named **Test**. The example only moves messages that have the word **Test** in the `Subject` field.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-csharp[Trin_OL_MoveItems#1](../vsto/codesnippet/CSharp/Trin_OL_MoveItems/thisaddin.cs#1)]

## Compile the code
 This example requires:

- An Outlook mail folder named **Test**.

- An email message that arrives with the word **Test** in the `Subject` field.

## See also
- [Work with folders](../vsto/working-with-folders.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
- [How to: Programmatically search within a specific folder](../vsto/how-to-programmatically-search-within-a-specific-folder.md)
- [How to: Programmatically perform actions when an email message is received](../vsto/how-to-programmatically-perform-actions-when-an-e-mail-message-is-received.md)
