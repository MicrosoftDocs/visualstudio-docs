---
title: "How to: Programmatically search within a specific folder"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Outlook folders [Office development in Visual Studio], searching"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically search within a specific folder
  This code example uses the `Find` and `FindNext` methods to search for text in the subject field of e-mail messages that are in the **Inbox**. This method uses a string filter to check for the letter T as the starting letter of the `Subject` text.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-csharp[Trin_OL_SearchFolder#1](../vsto/codesnippet/CSharp/Trin_OL_SearchFolder/thisaddin.cs#1)]

## See also
- [Work with folders](../vsto/working-with-folders.md)
- [Outlook object model overview](../vsto/outlook-object-model-overview.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
