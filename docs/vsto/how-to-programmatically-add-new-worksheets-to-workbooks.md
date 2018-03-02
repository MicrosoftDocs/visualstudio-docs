---
title: "How to: Programmatically Add New Worksheets to Workbooks | Microsoft Docs"
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
  - "workbooks, adding worksheets"
  - "workbooks, creating worksheets"
  - "worksheets, creating"
  - "worksheets, adding to workbooks"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Add New Worksheets to Workbooks
  You can programmatically create a worksheet and then add the worksheet to the collection of worksheets in the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
### To add a new worksheet to a workbook in a document-level customization  
  
1.  Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#15](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#15)]
     [!code-vb[Trin_VstcoreExcelAutomation#15](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#15)]  
  
     The new worksheet is a native <xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. If you want to add a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item, you should add the worksheet at design time.  
  
### To add a new worksheet to a workbook in a VSTO Add-in  
  
1.  Use the <xref:Microsoft.Office.Interop.Excel.Worksheets.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#11](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#11)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#11](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#11)]  
  
     The new worksheet is a native <xref:Microsoft.Office.Interop.Excel.Worksheet> object and not a host item. You can also generate a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item from the native <xref:Microsoft.Office.Interop.Excel.Worksheet> object. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Select Worksheets](../vsto/how-to-programmatically-select-worksheets.md)   
 [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)   
 [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  