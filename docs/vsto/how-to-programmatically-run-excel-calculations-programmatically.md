---
title: "Programmatically run Excel calculations"
description: Learn how you can use Visual Studio to programmatically run calculations in a Microsoft Excel workbook.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, running calculations"
  - "calculations, running in Excel"
  - "Excel [Office development in Visual Studio], running calculations programmatically"
  - "workbooks, running calculations"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically run Excel calculations

  You use a similar process to run calculations in a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Run calculations in a NamedRange control
 The following example creates a <xref:Microsoft.Office.Tools.Excel.NamedRange> at cell A1 and then calculates the cell. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

### To run calculations in a NamedRange control

1. Create the named range.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet75":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet75":::
     ---

2. Call the <xref:Microsoft.Office.Tools.Excel.NamedRange.Calculate%2A> method of the specified range.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet76":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet76":::
     ---

## Run calculations in a native Excel range

### To run calculations in a native Excel range

1. Create the named range.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet30":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet30":::
     ---

2. Call the <xref:Microsoft.Office.Interop.Excel.Range.Calculate%2A> method of the specified range.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet31":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet31":::
     ---

## Related content
- [Work with ranges](../vsto/working-with-ranges.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
