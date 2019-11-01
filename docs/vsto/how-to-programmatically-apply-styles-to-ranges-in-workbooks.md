---
title: "How to: Programmatically apply styles to ranges in workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, styles"
  - "styles, workbook ranges"
  - "workbooks, styles"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically apply styles to ranges in workbooks
  You can apply named styles to regions in workbooks. Excel supplies a number of predefined styles.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 The **Format Cells** dialog box displays all the options you can use to format cells, and each of these options is available from your code. To display this dialog box in Excel, click **Cells** on the **Format** menu.

## To apply a style to a named range in a document-level customization

1. Create a new style and set its attributes.

     [!code-csharp[Trin_VstcoreExcelAutomation#53](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#53)]
     [!code-vb[Trin_VstcoreExcelAutomation#53](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#53)]

2. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control, assign text to it, and then apply the new style. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#54](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#54)]
     [!code-vb[Trin_VstcoreExcelAutomation#54](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#54)]

## To clear a style from a named range in a document-level customization

1. Apply the Normal style to the range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#55](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#55)]
     [!code-vb[Trin_VstcoreExcelAutomation#55](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#55)]

## To apply a style to a named range in a VSTO Add-in

1. Create a new style and set its attributes.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#28](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#28)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#28](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#28)]

2. Create a <xref:Microsoft.Office.Interop.Excel.Range>, assign text to it, and then apply the new style.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#29](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#29)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#29](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#29)]

## To clear a style from a named range in a VSTO Add-in

1. Apply the Normal style to the range.

     [!code-csharp[Trin_VstcoreExcelAutomation#56](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#56)]
     [!code-vb[Trin_VstcoreExcelAutomation#56](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#56)]

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
