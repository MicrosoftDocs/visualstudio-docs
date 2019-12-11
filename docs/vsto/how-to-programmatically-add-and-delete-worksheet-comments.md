---
title: "How to: Programmatically add and delete worksheet comments"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, comments"
  - "worksheets, comments"
  - "comments, worksheets"
author: John-Hart
ms.author: johnhart
manager: jillfra
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

     [!code-csharp[Trin_VstcoreExcelAutomation#30](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#30)]
     [!code-vb[Trin_VstcoreExcelAutomation#30](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#30)]

#### To delete a comment from a named range

1. Verify that a comment exists on the range and delete it. This code must be placed in the `Sheet1` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#29](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#29)]
     [!code-vb[Trin_VstcoreExcelAutomation#29](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#29)]

## Add and delete a comment in a VSTO Add-in project
 The following examples assume that there is a single-cell <xref:Microsoft.Office.Interop.Excel.Range> named `dateComment` on the active worksheet.

### To add a new comment to an Excel range

1. Call the <xref:Microsoft.Office.Interop.Excel.Range.AddComment%2A> method of the <xref:Microsoft.Office.Interop.Excel.Range> and supply the comment text.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#20](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#20)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#20](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#20)]

### To delete a comment from an Excel range

1. Verify that a comment exists on the range and delete it.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#19](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#19)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#19](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#19)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically display worksheet comments](../vsto/how-to-programmatically-display-worksheet-comments.md)
- [NamedRange control](../vsto/namedrange-control.md)
