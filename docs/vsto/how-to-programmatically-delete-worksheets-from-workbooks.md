---
title: "How to: Programmatically Delete Worksheets from Workbooks | Microsoft Docs"
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
  - "workbooks, deleting worksheets"
  - "worksheets, deleting"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Delete Worksheets from Workbooks
  You can delete any worksheet in a workbook. To delete a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Using the Worksheet Host Item  
 If the worksheet was added at design-time in a document-level customization, use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> method to delete a specified worksheet. The following code deletes a worksheet from a workbook by referencing the worksheet host item directly.  
  
> [!IMPORTANT]  
>  This code runs only in projects that you create by using any of the following project templates:  
>   
>  -   Excel 2013 Workbook  
> -   Excel 2013 Template  
> -   Excel 2010 Workbook  
> -   Excel 2010 Template  
>   
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### To delete a worksheet by using a worksheet host item  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Worksheet.Delete%2A> method of `Sheet1`.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#17](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#17)]
     [!code-vb[Trin_VstcoreExcelAutomation#17](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#17)]  
  
## Using the Sheets Collection of the Excel Workbook  
 Access worksheets through the Microsoft Office Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:  
  
-   You want to delete a worksheet in a VSTO Add-in.  
  
-   The worksheet that you want to delete was created at run time in a document-level customization.  
  
 The following code deletes a worksheet from a workbook by referencing the sheet through the index number of the **Sheets** collection. This code assumes that a new worksheet was created programmatically.  
  
> [!IMPORTANT]  
>  If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Excel** assembly, and then you must use classes from that assembly to open a workbook and delete a worksheet. For more information, see [How to: Target Office Applications Through Primary Interop Assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md) and [Excel 2010 Primary Interop Assembly Reference](http://go.microsoft.com/fwlink/?LinkId=189585).  
  
#### To delete a worksheet by using the Sheets collection of the Excel workbook  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Worksheet.Delete%2A> method of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#18](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#18)]
     [!code-vb[Trin_VstcoreExcelAutomation#18](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#18)]  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [How to: Programmatically Hide Worksheets](../vsto/how-to-programmatically-hide-worksheets.md)   
 [How to: Programmatically Move Worksheets Within Workbooks](../vsto/how-to-programmatically-move-worksheets-within-workbooks.md)   
 [How to: Programmatically Select Worksheets](../vsto/how-to-programmatically-select-worksheets.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)   
 [Worksheet Host Item](../vsto/worksheet-host-item.md)   
 [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)  
  
  