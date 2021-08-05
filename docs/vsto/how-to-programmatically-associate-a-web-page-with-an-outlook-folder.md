---
title: "Associate a web page with an Outlook folder"
description:  Learn how you can associate a web page with Microsoft Office Outlook folder. This example checks for a folder named HtmlView in Outlook.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "folders [Office development in Visual Studio], Web pages and"
  - "Outlook [Office development in Visual Studio], Web pages attached to folders"
  - "Web pages [Office development in Visual Studio], Outlook folders"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# Associate a web page with an Outlook folder

  This example checks for a folder named `HtmlView` in Microsoft Office Outlook. If the folder does not exist, the code creates the folder and assigns a Web page to it. If the folder exists, the code displays the folder contents.

 [!INCLUDE[appliesto_olkallapp](../vsto/includes/appliesto-olkallapp-md.md)]

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_OL_HTMLFolder/thisaddin.cs" id="Snippet1":::

## See also
- [Work with folders](../vsto/working-with-folders.md)
- [How to: Programmatically retrieve a folder by name](../vsto/how-to-programmatically-retrieve-a-folder-by-name.md)
- [How to: Programmatically create custom folder items](../vsto/how-to-programmatically-create-custom-folder-items.md)
