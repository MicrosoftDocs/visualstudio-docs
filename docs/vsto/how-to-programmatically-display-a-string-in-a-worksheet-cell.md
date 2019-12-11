---
title: "How to: Programmatically display a string in a worksheet cell"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "text [Office development in Visual Studio], adding to worksheets"
  - "worksheets, displaying text in cells"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically display a string in a worksheet cell
  This example demonstrates how to display text in a cell programmatically. To display text in cell, use either a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Use a NamedRange control
 This example uses a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `message`. The control must be added to a document-level customization at design time. The following code must be placed in a sheet class, not in the `ThisWorkbook` class.

### To display text in a NamedRange control

1. Set the value of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control to **Hello World**.

     [!code-csharp[Trin_VstcoreExcelAutomation#68](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#68)]
     [!code-vb[Trin_VstcoreExcelAutomation#68](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#68)]

## Use a native Excel range
 The following code creates a new range programmatically and then assigns a value to it.

### To display text in an Excel range

1. Retrieve the range at cell **A1** on `Sheet1` and set the value to **Hello World**.

     [!code-csharp[Trin_VstcoreExcelAutomation#69](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#69)]
     [!code-vb[Trin_VstcoreExcelAutomation#69](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#69)]

## See also
- [Walkthrough: Collect data using a Windows form](../vsto/walkthrough-collecting-data-using-a-windows-form.md)
- [Troubleshoot Office solutions](../vsto/troubleshooting-office-solutions.md)
- [NamedRange control](../vsto/namedrange-control.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
