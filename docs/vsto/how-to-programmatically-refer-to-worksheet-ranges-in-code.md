---
title: "How to: Programmatically refer to worksheet ranges in code"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, referring to"
  - "worksheets, referring to ranges"
  - "referring to worksheet ranges"
  - "Excel [Office development in Visual Studio], referring to worksheet ranges"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically refer to worksheet ranges in code
  You use a similar process to refer to the contents of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use a NamedRange control
 The following example adds a <xref:Microsoft.Office.Tools.Excel.NamedRange> to a worksheet and then adds text to the cell in the range.

### To refer to a NamedRange control

1. Assign a string to the <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#46](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#46)]
     [!code-vb[Trin_VstcoreExcelAutomation#46](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#46)]

## Use native Excel ranges
 The following example adds a native Excel range to a worksheet and then adds text to the cell in the range.

### To refer to a native range object

1. Assign a string to the <xref:Microsoft.Office.Interop.Excel.Range.Value2%2A> property of the range.

     [!code-csharp[Trin_VstcoreExcelAutomation#47](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#47)]
     [!code-vb[Trin_VstcoreExcelAutomation#47](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#47)]

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [How to: Programmatically check spelling in worksheets](../vsto/how-to-programmatically-check-spelling-in-worksheets.md)
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)
- [How to: Programmatically automatically fill ranges with incrementally changing data](../vsto/how-to-programmatically-automatically-fill-ranges-with-incrementally-changing-data.md)
- [How to: Programmatically search for text in worksheet ranges](../vsto/how-to-programmatically-search-for-text-in-worksheet-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
