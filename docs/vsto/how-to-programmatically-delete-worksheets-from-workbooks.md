---
title: "How to: Programmatically delete worksheets from workbooks"
description: Learn how you can programmatically delete any worksheet in a Microsoft Excel workbook by using the worksheet host item, for example.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, deleting worksheets"
  - "worksheets, deleting"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically delete worksheets from workbooks
  You can delete any worksheet in a workbook. To delete a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.

 [!INCLUDE[appliesto_xlalldocapp](includes/appliesto-xlalldocapp-md.md)]

## Use the worksheet host item
 If the worksheet was added at design-time in a document-level customization, use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> method to delete a specified worksheet. The following code deletes a worksheet from a workbook by referencing the worksheet host item directly.

> [!IMPORTANT]
> This code runs only in projects that you create by using any of the following project templates:
>
> - Excel 2013 Workbook
> - Excel 2013 Template
> - Excel 2010 Workbook
> - Excel 2010 Template
>
>   If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office applications through primary interop assemblies](how-to-target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 primary interop assembly reference](office-primary-interop-assemblies.md).

### To delete a worksheet by using a worksheet host item

1. Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> method of `Sheet1`.

     :::code language="csharp" source="codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet17":::
     :::code language="vb" source="codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet17":::

## Use the Sheets collection of the Excel workbook
 Access worksheets through the Microsoft Office Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:

- You want to delete a worksheet in a VSTO Add-in.

- The worksheet that you want to delete was created at run time in a document-level customization.

  The following code deletes a worksheet from a workbook by referencing the sheet through the index number of the **Sheets** collection. This code assumes that a new worksheet was created programmatically.

> [!IMPORTANT]
> If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office applications through primary interop assemblies](how-to-target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 primary interop assembly reference](office-primary-interop-assemblies.md).

### To delete a worksheet by using the Sheets collection of the Excel workbook

1. Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.Delete%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.

     :::code language="csharp" source="codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet18":::
     :::code language="vb" source="codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet18":::

## See also
- [Work with worksheets](working-with-worksheets.md)
- [How to: Programmatically hide worksheets](how-to-programmatically-hide-worksheets.md)
- [How to: Programmatically move worksheets within workbooks](how-to-programmatically-move-worksheets-within-workbooks.md)
- [How to: Programmatically select worksheets](how-to-programmatically-select-worksheets.md)
- [How to: Programmatically add new worksheets to workbooks](how-to-programmatically-add-new-worksheets-to-workbooks.md)
- [Worksheet host item](worksheet-host-item.md)
- [Global access to objects in Office projects](global-access-to-objects-in-office-projects.md)
- [Programmatic limitations of host items and host controls](programmatic-limitations-of-host-items-and-host-controls.md)
