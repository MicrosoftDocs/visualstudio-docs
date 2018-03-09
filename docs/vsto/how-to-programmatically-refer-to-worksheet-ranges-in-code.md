---
title: "How to: Programmatically Refer to Worksheet Ranges in Code | Microsoft Docs"
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
  - "ranges, referring to"
  - "worksheets, referring to ranges"
  - "referring to worksheet ranges"
  - "Excel [Office development in Visual Studio], referring to worksheet ranges"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Refer to Worksheet Ranges in Code
  You use a similar process to refer to the contents of a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Using a NamedRange Control  
 The following example adds a <xref:Microsoft.Office.Tools.Excel.NamedRange> to a worksheet and then adds text to the cell in the range.  
  
#### To refer to a NamedRange control  
  
1.  Assign a string to the <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A> property of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control. This code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#46](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#46)]
     [!code-vb[Trin_VstcoreExcelAutomation#46](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#46)]  
  
## Using Native Excel Ranges  
 The following example adds a native Excel range to a worksheet and then adds text to the cell in the range.  
  
#### To refer to a native range object  
  
1.  Assign a string to the <xref:Microsoft.Office.Interop.Excel.Range.Value2%2A> property of the range.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#47](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#47)]
     [!code-vb[Trin_VstcoreExcelAutomation#47](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#47)]  
  
## See Also  
 [Working with Ranges](../vsto/working-with-ranges.md)   
 [How to: Programmatically Check Spelling in Worksheets](../vsto/how-to-programmatically-check-spelling-in-worksheets.md)   
 [How to: Programmatically Apply Styles to Ranges in Workbooks](../vsto/how-to-programmatically-apply-styles-to-ranges-in-workbooks.md)   
 [How to: Programmatically Automatically Fill Ranges with Incrementally Changing Data](../vsto/how-to-programmatically-automatically-fill-ranges-with-incrementally-changing-data.md)   
 [How to: Programmatically Search for Text in Worksheet Ranges](../vsto/how-to-programmatically-search-for-text-in-worksheet-ranges.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  