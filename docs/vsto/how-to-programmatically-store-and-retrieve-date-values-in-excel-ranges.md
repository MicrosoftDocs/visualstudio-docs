---
title: "Store & retrieve date values in Excel ranges programmatically"
description: Learn how you can use Visual Studio to programmatically store and retrieve date values in Microsoft Excel ranges.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
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
manager: jmartens
ms.technology: office-development
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

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet50":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet50":::

2. Set today's date as the value for `NamedRange1`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet51":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet51":::

### To retrieve a date value from a named range

1. Retrieve the date value from `NamedRange1`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet52":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet52":::

## Use native Excel ranges

### To store a date value in a native Excel range object

1. Create a <xref:Microsoft.Office.Interop.Excel.Range> that represents cell **A1**.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet25":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet25":::

2. Set today's date as the value for `rng`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet26":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet26":::

### To retrieve a date value from a native Excel range object

1. Retrieve the date value from `rng`.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet27":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet27":::

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [Excel object model overview](../vsto/excel-object-model-overview.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
