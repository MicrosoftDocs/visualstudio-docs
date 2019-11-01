---
title: "How to: Programmatically remove protection from worksheets"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets, unprotecting"
  - "documents [Office development in Visual Studio], document protection"
  - "document protection, removing from worksheets"
  - "Unprotect method"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically remove protection from worksheets
  You can programmatically remove protection from a Microsoft Office Excel worksheet.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 The following example uses the variable `getPasswordFromUser`, which contains a password obtained from the user.

## To unprotect a worksheet in a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.Unprotect%2A> method of the worksheet and pass in the password, if necessary. This example assumes that you are working with a worksheet named `Sheet1`.

     [!code-csharp[Trin_VstcoreExcelAutomation#28](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#28)]
     [!code-vb[Trin_VstcoreExcelAutomation#28](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#28)]

## To unprotect a worksheet in a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.Unprotect%2A> method of the active worksheet and pass in the password, if necessary.

     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#18](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#18)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#18](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#18)]

## See also
- [Work with worksheets](../vsto/working-with-worksheets.md)
- [How to: Programmatically protect worksheets](../vsto/how-to-programmatically-protect-worksheets.md)
- [How to: Programmatically protect workbooks](../vsto/how-to-programmatically-protect-workbooks.md)
- [How to: Programmatically hide worksheets](../vsto/how-to-programmatically-hide-worksheets.md)
- [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md)
