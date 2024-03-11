---
title: "Programmatically access Outlook contacts"
description: Learn how you can programmatically access Outlook contacts. This example finds all contacts whose last names contain a specified search string.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "contacts [Office development in Visual Studio], searching"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically access Outlook contacts

  This example finds all contacts whose last names contain a specified search string.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_AccessContacts.trin_ol_accesscontacts/thisaddin.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_OL_AccessContacts/thisaddin.vb" id="Snippet1":::
 ---

## Compile the code
 This example requires:

- Contacts whose last names contain the string "**Na"** (for example, Tzipi Butnaru) in the **Contacts** folder.

## Related content
- [Work with contact items](/previous-versions/visualstudio/visual-studio-2017/vsto/working-with-contact-items)
- [How to: Programmatically add an entry to Outlook contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md)
- [How to: Programmatically search for a specific contact](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-programmatically-search-for-a-specific-contact)
- [How to: Programmatically search for an email address in contacts](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-programmatically-search-for-an-e-mail-address-in-contacts)
- [How to: Programmatically delete Outlook contacts](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-programmatically-delete-outlook-contacts)
