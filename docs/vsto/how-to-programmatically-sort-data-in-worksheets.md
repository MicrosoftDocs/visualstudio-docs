---
title: "How to: Programmatically sort data in worksheets"
description: Learn how you can use Visual Studio to programmatically sort data that is contained in worksheet ranges and lists at run time.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "data sorting, worksheets"
  - "data [Office development in Visual Studio], sorting in worksheets"
  - "worksheets, sorting data"
  - "sorting data, in worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically sort data in worksheets
  You can sort data that is contained in worksheet ranges and lists at run time. The following code sorts a multi-column range named `Fruits` by the data in the first column, and then by the data in the second column.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Sort data in a document-level customization

### To sort data in a NamedRange control

1. Call the <xref:Microsoft.Office.Tools.Excel.NamedRange.Sort%2A> method of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control. The following example requires a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `Fruits` on a worksheet. This code must be placed in a sheet class, not in the `ThisWorkbook` class.

    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet78":::
    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet78":::

   Place the following code in *Sheet1.vb* or *Sheet1.cs* to sort data in a <xref:Microsoft.Office.Tools.Excel.ListObject> control. The code assumes that you have a <xref:Microsoft.Office.Tools.Excel.ListObject> control named `fruitList` in a worksheet named `Sheet1`.

### To sort data in a ListObject control

1. Call the <xref:Microsoft.Office.Interop.Excel.Range.Sort%2A> method of the <xref:Microsoft.Office.Tools.Excel.ListObject.Range%2A> property of the <xref:Microsoft.Office.Tools.Excel.ListObject> host control.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet79":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet79":::

## Sort data in a VSTO Add-in

### To sort data in a native range

1. Call the <xref:Microsoft.Office.Interop.Excel.Range.Sort%2A> method of the native Excel <xref:Microsoft.Office.Interop.Excel.Range> control. The following example requires a native Excel control named `Fruits` on a worksheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet23":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet23":::

### To sort data in a ListObject control

1. Call the <xref:Microsoft.Office.Interop.Excel.Range.Sort%2A> method of the <xref:Microsoft.Office.Tools.Excel.ListObject.Range%2A> property of the native Excel <xref:Microsoft.Office.Interop.Excel.ListObject> control. The following example assumes that you have a native Excel <xref:Microsoft.Office.Interop.Excel.ListObject> control named `fruitList` in the active worksheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet24":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet24":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically automatically fill ranges with incrementally changing data](../vsto/how-to-programmatically-automatically-fill-ranges-with-incrementally-changing-data.md)
- [How to: Programmatically refer to worksheet ranges in code](../vsto/how-to-programmatically-refer-to-worksheet-ranges-in-code.md)
- [How to: Programmatically apply styles to ranges in workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [ListObject control](../vsto/listobject-control.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
