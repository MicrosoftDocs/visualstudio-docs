---
title: "How to: Programmatically Create New Workbooks | Microsoft Docs"
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
  - "Excel [Office development in Visual Studio], creating workbooks"
  - "workbooks, creating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Create New Workbooks
  When you create a workbook programmatically, it is a native <xref:Microsoft.Office.Interop.Excel.Workbook> object, not a <xref:Microsoft.Office.Tools.Excel.Workbook> host item.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
 You can generate a <xref:Microsoft.Office.Tools.Excel.Workbook> host item for a <xref:Microsoft.Office.Interop.Excel.Workbook> object in VSTO Add-in project. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### To create a new workbook  
  
1.  Use the <xref:Microsoft.Office.Interop.Excel.Workbooks.Add%2A> method of the <xref:Microsoft.Office.Interop.Excel.Workbooks> collection.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#1](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#1)]
     [!code-vb[Trin_VstcoreExcelAutomation#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#1)]  
  
    > [!NOTE]  
    >  You can create a workbook based on a template other than the default template: pass the template you want to use as a parameter to the <xref:Microsoft.Office.Interop.Excel.Workbooks.Add%2A> method.  
  
## See Also  
 [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Working with Workbooks](../vsto/working-with-workbooks.md)   
 [How to: Programmatically Open Workbooks](../vsto/how-to-programmatically-open-workbooks.md)   
 [How to: Programmatically Save Workbooks](../vsto/how-to-programmatically-save-workbooks.md)   
 [How to: Programmatically Close Workbooks](../vsto/how-to-programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)  
  
  