---
title: "How to: Programmatically add and delete worksheet comments"
description: Learn how you can programmatically add and delete comments in Microsoft Office Excel worksheets. You can only add comments to single cells, not to multi-cell ranges.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, comments"
  - "worksheets, comments"
  - "comments, worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically add and delete worksheet comments
  You can programmatically add and delete comments in Microsoft Office Excel worksheets. Comments can be added only to single cells, not to multi-cell ranges.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Add and delete a comment in a document-level project
 The following examples assume that there is a single-cell <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `dateComment` on a worksheet named `Sheet1`.

### To add a new comment to a named range

1. Call the <xref:Microsoft.Office.Tools.Excel.NamedRange.AddComment%2A> method of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control and supply the comment text. This code must be placed in the `Sheet1` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet30":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet30":::

#### To delete a comment from a named range

1. Verify that a comment exists on the range and delete it. This code must be placed in the `Sheet1` class.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet29":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet29":::

## Add and delete a comment in a VSTO Add-in project
 The following examples assume that there is a single-cell <xref:Microsoft.Office.Interop.Excel.Range> named `dateComment` on the active worksheet.

### To add a new comment to an Excel range

1. Call the <xref:Microsoft.Office.Interop.Excel.Range.AddComment%2A> method of the <xref:Microsoft.Office.Interop.Excel.Range> and supply the comment text.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet20":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet20":::

### To delete a comment from an Excel range

1. Verify that a comment exists on the range and delete it.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet19":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet19":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically display worksheet comments](../vsto/how-to-programmatically-display-worksheet-comments.md)
- [NamedRange control](../vsto/namedrange-control.md)
