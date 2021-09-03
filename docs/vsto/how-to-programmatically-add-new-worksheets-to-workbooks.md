---
title: "How to: Programmatically add new worksheets to workbooks"
description:  Learn how you can programmatically create a worksheet and then add the worksheet to the collection of worksheets in the workbook.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, adding worksheets"
  - "workbooks, creating worksheets"
  - "worksheets, creating"
  - "worksheets, adding to workbooks"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically add new worksheets to workbooks
  You can programmatically create a worksheet and then add the worksheet to the collection of worksheets in the workbook.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## To add a new worksheet to a workbook in a document-level customization

1. Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet15":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet15":::

     The new worksheet is a native <xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. If you want to add a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item, you should add the worksheet at design time.

## To add a new worksheet to a workbook in a VSTO Add-in

1. Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.

     :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs" id="Snippet11":::
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb" id="Snippet11":::

     The new worksheet is a native <xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. You can also generate a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item from the native <xref:Microsoft.Office.Interop.Excel.Worksheet> object. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [How to: Programmatically delete worksheets from workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)
- [How to: Programmatically select worksheets](../vsto/how-to-programmatically-select-worksheets.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
