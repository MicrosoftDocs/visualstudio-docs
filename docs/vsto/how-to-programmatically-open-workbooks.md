---
title: "How to: Programmatically Open Workbooks | Microsoft Docs"
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
  - "workbooks, opening"
  - "Excel [Office development in Visual Studio], opening workbooks"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Open Workbooks
  The <xref:Microsoft.Office.Interop.Excel.Workbooks> collection in Microsoft Office Excel makes it possible to work with all open workbooks and to open workbooks.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
### To open an existing workbook  
  
1.  Use the <xref:Microsoft.Office.Interop.Excel.Workbooks.Open%2A> method of the <xref:Microsoft.Office.Interop.Excel.Workbooks> collection, passing in the path to the workbook.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#2](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#2)]
     [!code-vb[Trin_VstcoreExcelAutomation#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#2)]  
  
## Compiling the Code  
 This code example requires the following:  
  
-   A workbook named `YourWorkbook.xls` must exist in a directory named `Test` on drive C.  
  
## See Also  
 [Working with Workbooks](../vsto/working-with-workbooks.md)   
 [How to: Programmatically Open Text Files as Workbooks](../vsto/how-to-programmatically-open-text-files-as-workbooks.md)   
 [How to: Programmatically Create New Workbooks](../vsto/how-to-programmatically-create-new-workbooks.md)   
 [How to: Programmatically Save Workbooks](../vsto/how-to-programmatically-save-workbooks.md)   
 [How to: Programmatically Close Workbooks](../vsto/how-to-programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)  
  
  