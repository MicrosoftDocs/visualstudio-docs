---
title: "How to: Programmatically move worksheets within workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, moving"
  - "workbooks, moving worksheets in"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically move worksheets within workbooks
  You can programmatically change the position of worksheets relative to other worksheets in a workbook. If you do not specify a location for the moved sheet, Excel creates a new workbook to contain it.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To move a worksheet in a document-level customization

1. Assign the total number of sheets in the workbook to a variable and then move the first worksheet so that it becomes the last one.

     [!code-csharp[Trin_VstcoreExcelAutomation#24](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#24)]
     [!code-vb[Trin_VstcoreExcelAutomation#24](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#24)]

## To move a worksheet in a VSTO Add-in

1. Assign the total number of sheets in the workbook to a variable and then move the first worksheet so that it becomes the last one.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#16](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#16)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#16](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#16)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically hide worksheets](../vsto/how-to-programmatically-hide-worksheets.md)
- [How to: Programmatically delete worksheets from workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)
- [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
