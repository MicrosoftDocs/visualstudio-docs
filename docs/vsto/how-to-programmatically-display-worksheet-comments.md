---
title: "How to: Programmatically display worksheet comments"
description: Learn how you can programmatically show and hide comments in a Microsoft Excel worksheet at the document level or the application level.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, comments"
  - "comments, worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically display worksheet comments
  You can programmatically show and hide comments in Microsoft Office Excel worksheets.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To display all comments on a worksheet in a document-level customization

1. Set the <xref:Microsoft.Office.Interop.Excel.Comment.Visible%2A> property to **true** if you want to show comments; otherwise **false**. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet31":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet31":::

## To display all comments on a worksheet in an application-level VSTO Add-in

1. Set the <xref:Microsoft.Office.Interop.Excel.Comment.Visible%2A> property to **true** if you want to show comments; otherwise **false**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet21":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet21":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically add and delete worksheet comments](../vsto/how-to-programmatically-add-and-delete-worksheet-comments.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
