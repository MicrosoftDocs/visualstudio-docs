---
title: "How to: Programmatically Group Rows in a Worksheet | Microsoft Docs"
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
  - "worksheets, creating groups"
  - "groups, creating in worksheets"
  - "ranges, creating groups"
  - "worksheets, clearing groups"
  - "groups"
  - "groups [Office development in Visual Studio], clearing in worksheets"
  - "worksheets, ungrouping rows and columns"
  - "rows [Office development in Visual Studio], ungrouping"
  - "columns [Office development in Visual Studio], ungrouping"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Group Rows in a Worksheet
  You can group one or more whole rows. To create a group in a worksheet, use a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Using a NamedRange Control  
 If you add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to a document-level project at design time, you can use the control to programmatically create a group. The following example assumes that there are three <xref:Microsoft.Office.Tools.Excel.NamedRange> controls on the same worksheet: `data2001`, `data2002`, and `dataAll`. Each named range refers to a whole row in the worksheet.  
  
#### To create a group of NamedRange controls on a worksheet  
  
1.  Group three named ranges by calling the <xref:Microsoft.Office.Tools.Excel.NamedRange.Group%2A> method of each range. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#32](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#32)]
     [!code-vb[Trin_VstcoreExcelAutomation#32](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#32)]  
  
    > [!NOTE]  
    >  To ungroup rows, call the <xref:Microsoft.Office.Tools.Excel.NamedRange.Ungroup%2A> method.  
  
## Using Native Excel Ranges  
 The code assumes that you have three Excel ranges named `data2001`, `data2002`, and `dataAll` on a worksheet.  
  
#### To create a group of Excel ranges in a worksheet  
  
1.  Group three named ranges by calling the <xref:Microsoft.Office.Interop.Excel.Range.Group%2A> method of each range. The following example assumes that there are three <xref:Microsoft.Office.Interop.Excel.Range> controls named `data2001`, `data2002`, and `dataAll` on the same worksheet. Each named range refers to a whole row in the worksheet.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#33](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#33)]
     [!code-vb[Trin_VstcoreExcelAutomation#33](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#33)]  
  
    > [!NOTE]  
    >  To ungroup rows, call the <xref:Microsoft.Office.Interop.Excel.Range.Ungroup%2A> method.  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [How to: Add NamedRange Controls to Worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  