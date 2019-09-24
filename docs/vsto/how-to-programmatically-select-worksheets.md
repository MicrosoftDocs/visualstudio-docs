---
title: "How to: Programmatically select worksheets"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, selecting"
  - "Excel projects, selecting worksheets"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically select worksheets
  The <xref:Microsoft.Office.Tools.Excel.Worksheet.Select%2A> method selects the specified object, which moves the user's selection to the new object. Use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Activate%2A> method if you want to bring focus to the object without changing the user's selection.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 If you want to select an existing worksheet in a VSTO Add-in or if the worksheet was created at run time in a document-level customization, you must access it by using the Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection of the Excel workbook; otherwise, you can access the <xref:Microsoft.Office.Tools.Excel.Worksheet> host item directly.

## Use the worksheet host item
 In a document-level customization, add the following code to *Sheet1.vb* or *Sheet1.cs*.

### To select the first worksheet in a workbook using a host item

1. Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.Select%2A> method of `Sheet1`.

     [!code-csharp[Trin_VstcoreExcelAutomation#19](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#19)]
     [!code-vb[Trin_VstcoreExcelAutomation#19](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#19)]

## Use the sheets collection of the Excel workbook
 Access the worksheet by using the Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection.

### To select the first worksheet in a workbook using the Sheets collection of the Excel workbook

1. Call the <xref:Microsoft.Office.Interop.Excel.Sheets.Select%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection to select the first worksheet of the active workbook.

     [!code-csharp[Trin_VstcoreExcelAutomation#20](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#20)]
     [!code-vb[Trin_VstcoreExcelAutomation#20](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#20)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically print worksheets](../vsto/how-to-programmatically-print-worksheets.md)
- [How to: Programmatically delete worksheets from workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)
- [How to: Programmatically hide worksheets](../vsto/how-to-programmatically-hide-worksheets.md)
- [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md)
- [Worksheet host item](../vsto/worksheet-host-item.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
