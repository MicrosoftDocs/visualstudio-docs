---
title: "How to: Programmatically associate a web page with an Outlook folder"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "folders [Office development in Visual Studio], Web pages and"
  - "Outlook [Office development in Visual Studio], Web pages attached to folders"
  - "Web pages [Office development in Visual Studio], Outlook folders"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically associate a web page with an Outlook folder
  This example checks for a folder named `HtmlView` in Microsoft Office Outlook. If the folder does not exist, the code creates the folder and assigns a Web page to it. If the folder exists, the code displays the folder contents.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 [!code-csharp[Trin_OL_HTMLFolder#1](../vsto/codesnippet/CSharp/Trin_OL_HTMLFolder/thisaddin.cs#1)]

## See also
- [Work with folders](../vsto/working-with-folders.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
- [How to: Programmatically create custom folder items](../vsto/how-to-programmatically-create-custom-folder-items.md)
