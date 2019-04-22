---
title: "How to: Programmatically determine the current Outlook item"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "mail items [Office development in Visual Studio], current"
  - "e-mail [Office development in Visual Studio], current item"
  - "SelectionChange event"
  - "Outlook [Office development in Visual Studio], current item"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically determine the current Outlook item
  This example uses the `Explorer.SelectionChange` event to display the name of the current folder and some information about the selected item. The code then displays the selected item.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-vb[Trin_OL_CurrentItem#1](../vsto/codesnippet/VisualBasic/Trin_OL_CurrentItem/thisaddin.vb#1)]
 [!code-csharp[Trin_OL_CurrentItem#1](../vsto/codesnippet/CSharp/Trin_OL_CurrentItem/thisaddin.cs#1)]

## Compile the code
 This example requires:

- Appointment, contact, and e-mail items in Microsoft Office Outlook.

## See also
- [Outlook object model overview](../vsto/outlook-object-model-overview.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
- [How to: Programmatically search for a specific contact](../vsto/how-to-programmatically-search-for-a-specific-contact.md)
