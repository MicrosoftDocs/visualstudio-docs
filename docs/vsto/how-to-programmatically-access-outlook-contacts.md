---
title: "How to: Programmatically access Outlook contacts"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "contacts [Office development in Visual Studio], searching"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically access Outlook contacts
  This example finds all contacts whose last names contain a specified search string.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-csharp[Trin_OL_AccessContacts#1](../vsto/codesnippet/CSharp/Trin_OL_AccessContacts.trin_ol_accesscontacts/thisaddin.cs#1)]
 [!code-csharp[Trin_OL_AccessContacts#1](../vsto/codesnippet/CSharp/Trin_OL_AccessContacts.trin_ol_accesscontacts/thisaddin.cs#1)]
 [!code-vb[Trin_OL_AccessContacts#1](../vsto/codesnippet/VisualBasic/Trin_OL_AccessContacts/thisaddin.vb#1)]

## Compile the code
 This example requires:

- Contacts whose last names contain the string "**Na"** (for example, Tzipi Butnaru) in the **Contacts** folder.

## See also
- [Work with contact items](../vsto/working-with-contact-items.md)
- [How to: Programmatically add an entry to Outlook contacts](../vsto/how-to-programmatically-add-an-entry-to-outlook-contacts.md)
- [How to: Programmatically search for a specific contact](../vsto/how-to-programmatically-search-for-a-specific-contact.md)
- [How to: Programmatically search for an email address in contacts](../vsto/how-to-programmatically-search-for-an-e-mail-address-in-contacts.md)
- [How to: Programmatically delete Outlook contacts](../vsto/how-to-programmatically-delete-outlook-contacts.md)
