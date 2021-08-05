---
title: "Autofill incrementally changing data ranges programmatically"
description:  Learn how the AutoFill method of the Range object enables you to fill a range in a worksheet with values automatically.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Autofill method [Excel]"
  - "filling ranges automatically"
  - "ranges, automatically filling"
  - "workbooks, filling ranges"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically automatically fill ranges with incrementally changing data
  The <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method of the <xref:Microsoft.Office.Interop.Excel.Range> object enables you to fill a range in a worksheet with values automatically. Most often, the <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method is used to store incrementally increasing or decreasing values in a range. You can specify the behavior by supplying an optional constant from the <xref:Microsoft.Office.Interop.Excel.XlAutoFillType> enumeration.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 You must specify two ranges when using <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A>:

- The range that calls the <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method, which specifies the starting point of the fill and contains an initial value.

- The range that you want to fill, passed as a parameter to the <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method. This destination range must include the range that contains the initial value.

    > [!NOTE]
    > You cannot pass a <xref:Microsoft.Office.Tools.Excel.NamedRange> control in place of the <xref:Microsoft.Office.Interop.Excel.Range>. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).

## Example
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet49":::
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet49":::

## Compile the code
 The first cell of the range that you want to fill must contain an initial value.

 The example requires that you fill three regions:

- Column B is to include five weekdays. For the initial value, type **Monday** in cell B1.

- Column C is to include five months. For the initial value, type **January** in cell C1.

- Column D is to include a series of numbers, incrementing by two for each row. For the initial values, type **4** in cell D1 and **6** in cell D2.

## See also
- [Work with ranges](../vsto/working-with-ranges.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)
- [How to: Programmatically run Excel calculations](../vsto/how-to-programmatically-run-excel-calculations-programmatically.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
