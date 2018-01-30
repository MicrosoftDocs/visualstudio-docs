---
title: "How to: Programmatically Check Spelling in Worksheets | Microsoft Docs"
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
  - "spellchecking"
  - "spelling checker, worksheets"
  - "worksheets, checking spelling"
  - "spelling, checking in worksheets"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Check Spelling in Worksheets
  You can programmatically check the spelling of words in a worksheet. The **Spelling** dialog box automatically appears if there are any incorrectly spelled words in the worksheet.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
### To check spelling in a worksheet in a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.CheckSpelling%2A> method of the worksheet.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#45](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#45)]
     [!code-vb[Trin_VstcoreExcelAutomation#45](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#45)]  
  
### To check spelling in a worksheet in an VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.CheckSpelling%2A> method of the active worksheet.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#22](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#22)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#22](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#22)]  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [How to: Programmatically Run Excel Calculations](../vsto/how-to-programmatically-run-excel-calculations-programmatically.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  