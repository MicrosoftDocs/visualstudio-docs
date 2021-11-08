---
title: "How to: Programmatically group rows in a worksheet"
description: Learn how you can programmatically group one or more whole rows in Microsoft Excel by using a NamedRange control or a native Excel range object.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, creating groups"
  - "groups, creating in worksheets"
  - "ranges, creating groups"
  - "worksheets, clearing groups"
  - "groups"
  - "groups [Office development in Visual Studio], clearing in worksheets"
  - "worksheets, ungrouping rows and columns"
  - "rows [Office development in Visual Studio], ungrouping"
  - "columns [Office development in Visual Studio], ungrouping"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically group rows in a worksheet
  You can group one or more whole rows. To create a group in a worksheet, use a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use a NamedRange control
 If you add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a document-level project at design time, you can use the control to programmatically create a group. The following example assumes that there are three <xref:Microsoft.Office.Tools.Excel.NamedRange> controls on the same worksheet: `data2001`, `data2002`, and `dataAll`. Each named range refers to a whole row in the worksheet.

### To create a group of NamedRange controls on a worksheet

1. Group three named ranges by calling the <xref:Microsoft.Office.Tools.Excel.NamedRange.Group%2A> method of each range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

     [!code-csharp[Trin_VstcoreExcelAutomation#32](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#32)]
     [!code-vb[Trin_VstcoreExcelAutomation#32](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#32)]

    > [!NOTE]
    > To ungroup rows, call the <xref:Microsoft.Office.Tools.Excel.NamedRange.Ungroup%2A> method.

## Use native Excel ranges
 The code assumes that you have three Excel ranges named `data2001`, `data2002`, and `dataAll` on a worksheet.

### To create a group of Excel ranges in a worksheet

1. Group three named ranges by calling the <xref:Microsoft.Office.Interop.Excel.Range.Group%2A> method of each range. The following example assumes that there are three <xref:Microsoft.Office.Interop.Excel.Range> controls named `data2001`, `data2002`, and `dataAll` on the same worksheet. Each named range refers to a whole row in the worksheet.

     [!code-csharp[Trin_VstcoreExcelAutomation#33](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#33)]
     [!code-vb[Trin_VstcoreExcelAutomation#33](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#33)]

    > [!NOTE]
    > To ungroup rows, call the <xref:Microsoft.Office.Interop.Excel.Range.Ungroup%2A> method.

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
