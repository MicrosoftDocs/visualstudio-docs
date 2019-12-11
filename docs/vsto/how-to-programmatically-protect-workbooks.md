---
title: "How to: Programmatically protect workbooks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "workbooks, passwords"
  - "documents [Office development in Visual Studio], document protection"
  - "workbooks, unprotecting"
  - "document protection, removing from workbooks"
  - "document protection, adding to workbooks"
  - "workbooks, protecting"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically protect workbooks
  You can protect a Microsoft Office Excel workbook so that users cannot add or delete worksheets, and also unprotect the workbook programmatically. You can optionally specify a password, indicate whether you want the structure protected (so users cannot move sheets around), and indicate whether you want the workbook's windows protected.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 Protecting a workbook does not stop users from editing cells. To protect the data, you must protect the worksheets. For more information, see [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md).

 The following code examples use a variable to contain a password that is obtained from the user.

## Protect a workbook that is part of a document-level customization

### To protect a workbook

1. Call the <xref:Microsoft.Office.Tools.Excel.Workbook.Protect%2A> method of the workbook and include a password. To use the following code example, run it in the `ThisWorkbook` class, not in a sheet class.

     [!code-csharp[Trin_VstcoreExcelAutomation#10](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs#10)]
     [!code-vb[Trin_VstcoreExcelAutomation#10](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb#10)]

### To unprotect a workbook

1. Call the <xref:Microsoft.Office.Tools.Excel.Workbook.Unprotect%2A> method, passing a password if it is required. To use the following code example, run it in the `ThisWorkbook` class, not in a sheet class.

     [!code-csharp[Trin_VstcoreExcelAutomation#11](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs#11)]
     [!code-vb[Trin_VstcoreExcelAutomation#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb#11)]

## Protect a workbook by using an application-level Add-in

### To protect a workbook

1. Call the <xref:Microsoft.Office.Interop.Excel._Workbook.Protect%2A> method of the workbook and include a password. This code example uses the active workbook. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#6](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#6)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#6](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#6)]

### To unprotect a workbook

1. Call the <xref:Microsoft.Office.Interop.Excel._Workbook.Unprotect%2A> method of the active workbook, passing a password if it is required. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#7](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#7)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#7](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#7)]

## See also
- [Work with workbooks](../vsto/working-with-workbooks.md)
- [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md)
- [How to: Programmatically hide worksheets](../vsto/how-to-programmatically-hide-worksheets.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
