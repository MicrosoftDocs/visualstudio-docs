---
title: "Store & retrieve date values in Excel ranges programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel [Office development in Visual Studio], retrieving date values from ranges"
  - "ranges, retrieving data values"
  - "dates, retrieving from Excel ranges"
  - "Excel [Office development in Visual Studio], storing date values in ranges"
  - "date values, storing in Excel ranges"
  - "dates, storing in Excel ranges"
  - "ranges, storing date values"
  - "date values"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically store and retrieve date values in Excel ranges
  You can store and retrieve values in a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 If you store a date value that falls on or after 1/1/1900 in a range using Office development tools in Visual Studio, it is stored in OLE Automation (OA) format. You must use the <xref:System.DateTime.FromOADate%2A> method to retrieve the value of OLE Automation (OA) dates. If the date is earlier than 1/1/1900, it is stored as a string.

> [!NOTE]
> Excel dates differ from OLE Automation dates for the first two months of 1900. There are also differences if the **1904 date system** option is checked. The code examples below do not address these differences.

## Use a NamedRange control

- This example is for document-level customizations. The following code must be placed in a sheet class, not in the `ThisWorkbook` class.

### To store a date value in a named range

1. Create a <xref:Microsoft.Office.Tools.Excel.NamedRange> control at cell **A1**.

     [!code-csharp[Trin_VstcoreExcelAutomation#50](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#50)]
     [!code-vb[Trin_VstcoreExcelAutomation#50](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#50)]

2. Set today's date as the value for `NamedRange1`.

     [!code-csharp[Trin_VstcoreExcelAutomation#51](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#51)]
     [!code-vb[Trin_VstcoreExcelAutomation#51](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#51)]

### To retrieve a date value from a named range

1. Retrieve the date value from `NamedRange1`.

     [!code-csharp[Trin_VstcoreExcelAutomation#52](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#52)]
     [!code-vb[Trin_VstcoreExcelAutomation#52](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#52)]

## Use native Excel ranges

### To store a date value in a native Excel range object

1. Create a <xref:Microsoft.Office.Interop.Excel.Range> that represents cell **A1**.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#25](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#25)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#25](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#25)]

2. Set today's date as the value for `rng`.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#26](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#26)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#26](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#26)]

### To retrieve a date value from a native Excel range object

1. Retrieve the date value from `rng`.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#27](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#27)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#27](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#27)]

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [Excel object model overview](../vsto/excel-object-model-overview.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
