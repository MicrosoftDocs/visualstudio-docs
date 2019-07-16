---
title: "How to: Programmatically apply color to Excel ranges"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "formatting [Office development in Visual Studio]"
  - "color, Excel ranges"
  - "ranges, applying color"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically apply color to Excel ranges
  To apply a color to text within a range of cells, use a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use a NamedRange control
 This example is for document-level customizations.

### To apply color to a NamedRange control

1. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control at cell A1.

     [!code-csharp[Trin_VstcoreExcelAutomation#65](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#65)]
     [!code-vb[Trin_VstcoreExcelAutomation#65](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#65)]

2. Set the color of the text in the <xref:Microsoft.Office.Tools.Excel.NamedRange> control.

     [!code-csharp[Trin_VstcoreExcelAutomation#66](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#66)]
     [!code-vb[Trin_VstcoreExcelAutomation#66](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#66)]

## Use native Excel ranges

### To apply color to a native Excel range object

1. Create a range at cell A1 and then set the color of the text.

     [!code-csharp[Trin_VstcoreExcelAutomation#67](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#67)]
     [!code-vb[Trin_VstcoreExcelAutomation#67](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#67)]

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
