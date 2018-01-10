---
title: "How to: Programmatically List Recently Used Workbook Files | Microsoft Docs"
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
  - "workbooks, listing recently used"
  - "RecentFiles property"
  - "Excel [Office development in Visual Studio], recently used files listing"
  - "recent file list, Excel"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically List Recently Used Workbook Files
  The <xref:Microsoft.Office.Interop.Excel._Application.RecentFiles%2A> property returns a collection that contains the names of all the files that appear in the Microsoft Office Excel list of recently used files. The length of the list varies depending on the number of files the user has selected to retain. You can display the results in a range.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
### To list recently used workbooks in a range object  
  
1.  Loop through the list of recent files and display the names in cells relative to a <xref:Microsoft.Office.Interop.Excel.Range> object.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#9](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#9)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#9](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#9)]  
  
## See Also  
 [Working with Workbooks](../vsto/working-with-workbooks.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  