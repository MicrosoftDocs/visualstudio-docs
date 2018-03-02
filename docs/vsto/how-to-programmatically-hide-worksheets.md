---
title: "How to: Programmatically Hide Worksheets | Microsoft Docs"
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
  - "hidden worksheets"
  - "worksheets, hiding"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Hide Worksheets
  You can show or hide any worksheet in a workbook. To hide a worksheet, use the worksheet host item or access the worksheet by using the sheets collection of the workbook.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Using the Worksheet Host Item  
 If the worksheet was added at design-time in a document-level customization, use the <xref:Microsoft.Office.Tools.Excel.Worksheet.Visible%2A> property to hide the specified worksheet.  
  
#### To hide a worksheet using a worksheet host item  
  
1.  Set the <xref:Microsoft.Office.Tools.Excel.Worksheet.Visible%2A> property of the `Sheet1` host item to the <xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#25](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#25)]
     [!code-vb[Trin_VstcoreExcelAutomation#25](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#25)]  
  
## Using the Sheets Collection of the Excel Workbook  
 Access worksheets through the Microsoft Office Excel <xref:Microsoft.Office.Interop.Excel.Sheets> collection in the following cases:  
  
-   You want to hide a worksheet in an VSTO Add-in.  
  
-   The worksheet that you want to hide was created at run time in a document-level customization.  
  
#### To hide a worksheet using the Sheets collection of the Excel workbook  
  
1.  Set the <xref:Microsoft.Office.Interop.Excel.Worksheets.Visible%2A> property of the worksheet to the <xref:Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetHidden> enumeration value.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#26](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#26)]
     [!code-vb[Trin_VstcoreExcelAutomation#26](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#26)]  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [How to: Programmatically Delete Worksheets from Workbooks](../vsto/how-to-programmatically-delete-worksheets-from-workbooks.md)   
 [How to: Programmatically Move Worksheets Within Workbooks](../vsto/how-to-programmatically-move-worksheets-within-workbooks.md)   
 [How to: Programmatically Protect Worksheets](../vsto/how-to-programmatically-protect-worksheets.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md)  
  