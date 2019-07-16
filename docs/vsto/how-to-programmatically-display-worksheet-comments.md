---
title: "How to: Programmatically display worksheet comments"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, comments"
  - "comments, worksheets"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically display worksheet comments
  You can programmatically show and hide comments in Microsoft Office Excel worksheets.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To display all comments on a worksheet in a document-level customization

1. Set the <xref:Microsoft.Office.Interop.Excel.Comment.Visible%2A> property to **true** if you want to show comments; otherwise **false**. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#31](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#31)]
     [!code-vb[Trin_VstcoreExcelAutomation#31](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#31)]

## To display all comments on a worksheet in an application-level VSTO Add-in

1. Set the <xref:Microsoft.Office.Interop.Excel.Comment.Visible%2A> property to **true** if you want to show comments; otherwise **false**.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#21](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#21)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#21](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#21)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically add and delete worksheet comments](../vsto/how-to-programmatically-add-and-delete-worksheet-comments.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
