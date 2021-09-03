---
title: "How to: Programmatically hide worksheets"
description: Learn how you can programmatically show or hide any worksheet in a Microsoft Excel workbook by using the worksheet host item.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "hidden worksheets"
  - "worksheets, hiding"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically hide worksheets
  You can show or hide any worksheet in a workbook. To hide a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use the worksheet host item
 If the worksheet was added at design-time in a document-level customization, use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Visible%2A> property to hide the specified worksheet.

### To hide a worksheet using a worksheet host item

1. Set the <xref:Microsoft.Office.Tools.Excel.Worksheet.Visible%2A> property of the `Sheet1` host item to the <xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet25":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet25":::

## Use the Sheets collection of the Excel workbook
 Access worksheets through the Microsoft Office Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:

- You want to hide a worksheet in a VSTO Add-in.

- The worksheet that you want to hide was created at run time in a document-level customization.

### To hide a worksheet using the Sheets collection of the Excel workbook

1. Set the <xref:Microsoft.Office.Interop.Excel.Worksheets.Visible%2A> property of the worksheet to the <xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet26":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet26":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically delete worksheets from workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)
- [How to: Programmatically move worksheets Within workbooks](../vsto/how-to-programmatically-move-worksheets-within-workbooks.md)
- [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
