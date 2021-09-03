---
title: "How to: Programmatically search within a specific folder"
description: Learn how you can use Visual Studio to programmatically search within a specific Microsoft Outlook folder.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Outlook folders [Office development in Visual Studio], searching"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically search within a specific folder
  This code example uses the `Find` and `FindNext` methods to search for text in the subject field of e-mail messages that are in the **Inbox**. This method uses a string filter to check for the letter T as the starting letter of the `Subject` text.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_SearchFolder/thisaddin.cs" id="Snippet1":::

## See also
- [Work with folders](../vsto/working-with-folders.md)
- [Outlook object model overview](../vsto/outlook-object-model-overview.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
