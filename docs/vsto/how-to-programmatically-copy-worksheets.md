---
title: "How to: Programmatically copy worksheets"
description: Learn how you can create a copy of a worksheet, and insert that worksheet before or after an existing worksheet in the workbook.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, copying"
  - "Excel [Office development in Visual Studio], copying worksheets"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically copy worksheets
  You can create a copy of a worksheet, and insert that worksheet before or after an existing worksheet in the workbook. If you do not specify where to insert the worksheet, Excel creates a new workbook to contain the new worksheet.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

> [!NOTE]
> Whether you copy the worksheet programmatically, or the end user copies the worksheet manually, there is no code behind the new worksheet and controls on the new worksheet do not function. This is because the newly copied worksheet is a <xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item. Windows Forms controls and host controls can only be added to host items. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).

## To add a copied worksheet to a workbook in a document-level customization

1. Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Copy%2A> method to copy the first worksheet in the current workbook and place the copy after the third sheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet16":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet16":::

## To add a copied worksheet to a workbook in a VSTO Add-in

1. Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Copy%2A> method to copy the first worksheet in the current workbook and place the copy after the third sheet.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet12":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet12":::

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [How to: Programmatically add new worksheets to workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)
- [How to: Programmatically delete worksheets from workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)
- [How to: Programmatically select worksheets](../vsto/how-to-programmatically-select-worksheets.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
