---
title: "How to: Programmatically print worksheets"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "printing [Office development in Visual Studio], worksheets"
  - "worksheets, printing"
  - "print preview, worksheets"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically print worksheets

You can print any worksheet in a workbook.

[!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Print a worksheet in a document-level customization

### To print a worksheet

1. Call the `PrintOut` method of `Sheet1`, request two copies, and preview the document before printing.

    [!code-csharp[Trin_VstcoreExcelAutomation#22](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#22)]
    [!code-vb[Trin_VstcoreExcelAutomation#22](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#22)]

   The <xref:Microsoft.Office.Tools.Excel.Worksheet.PrintPreview%2A> method enables you to display the specified object in the **Print Preview** window. The following code assumes you have a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item named `Sheet1`.

### To preview a page before printing

1. Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.PrintPreview%2A> method of the worksheet.

     [!code-csharp[Trin_VstcoreExcelAutomation#23](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#23)]
     [!code-vb[Trin_VstcoreExcelAutomation#23](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#23)]

## Print a worksheet in a VSTO Add-in

### To print a worksheet

1. Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.PrintOut%2A> method of the active worksheet, request two copies, and preview the document before printing.

    [!code-csharp[Trin_VstcoreExcelAutomationAddIn#14](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#14)]
    [!code-vb[Trin_VstcoreExcelAutomationAddIn#14](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#14)]

   The <xref:Microsoft.Office.Interop.Excel._Worksheet.PrintPreview%2A> method enables you to display the specified object in the **Print Preview** window.

### To preview a page before printing

1. Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.PrintPreview%2A> method of the active worksheet.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#15](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#15)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#15](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#15)]

## See also

- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically check spelling in worksheets](../vsto/how-to-programmatically-check-spelling-in-worksheets.md)
- [Worksheet host item](../vsto/worksheet-host-item.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
