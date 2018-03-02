---
title: "How to: Programmatically Remove Protection from Worksheets | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "worksheets, unprotecting"
  - "documents [Office development in Visual Studio], document protection"
  - "document protection, removing from worksheets"
  - "Unprotect method"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Remove Protection from Worksheets
  You can programmatically remove protection from a Microsoft Office Excel worksheet.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 The following example uses the variable `getPasswordFromUser`, which contains a password obtained from the user.  
  
### To unprotect a worksheet in a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.Unprotect%2A> method of the worksheet and pass in the password, if required. This example assumes that you are working with a worksheet named `Sheet1`.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#28](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#28)]
     [!code-vb[Trin_VstcoreExcelAutomation#28](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#28)]  
  
### To unprotect a worksheet in an VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.Unprotect%2A> method of the active worksheet and pass in the password, if required.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#18](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#18)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#18](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#18)]  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [How to: Programmatically Protect Worksheets](../vsto/how-to-programmatically-protect-worksheets.md)   
 [How to: Programmatically Protect Workbooks](../vsto/how-to-programmatically-protect-workbooks.md)   
 [How to: Programmatically Hide Worksheets](../vsto/how-to-programmatically-hide-worksheets.md)   
 [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md)  
  
  