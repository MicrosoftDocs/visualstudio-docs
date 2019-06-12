---
title: "How to: Programmatically list all worksheets in a workbook"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, listing worksheets"
  - "worksheets, listing"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically list all worksheets in a workbook
  The <xref:Microsoft.Office.Interop.Excel.Workbook> class provides a <xref:Microsoft.Office.Interop.Excel.Worksheets> object. This object contains a collection of all the <xref:Microsoft.Office.Interop.Excel.Worksheet> objects in the workbook.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To list all existing worksheets in a workbook in a document-level customization

1. Iterate through the <xref:Microsoft.Office.Interop.Excel.Worksheets> collection and send the name of each sheet to a cell offset from a <xref:Microsoft.Office.Tools.Excel.NamedRange> control.

     [!code-csharp[Trin_VstcoreExcelAutomation#21](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#21)]
     [!code-vb[Trin_VstcoreExcelAutomation#21](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#21)]

## To list all existing worksheets in a workbook in a VSTO Add-in

1. Iterate through the <xref:Microsoft.Office.Interop.Excel.Worksheets> collection and send the name of each sheet to a cell offset from a <xref:Microsoft.Office.Interop.Excel.Range> object.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#13](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#13)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#13](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#13)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically add new worksheets to workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)
- [How to: Programmatically move worksheets within workbooks](../vsto/how-to-programmatically-move-worksheets-within-workbooks.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
