---
title: "How to: Programmatically Copy Data and Formatting across Worksheets | Microsoft Docs"
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
  - "worksheets, copying data"
  - "formatting [Office development in Visual Studio]"
  - "data [Office development in Visual Studio], copying across worksheets"
  - "copying data, Office development in Visual Studio"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Copy Data and Formatting across Worksheets
  You can copy data from a range on one sheet to all the other sheets in a workbook by using the <xref:Microsoft.Office.Interop.Excel.Worksheets.FillAcrossSheets%2A> method. Specify a range, and whether you want to copy data, formatting, or both.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Example  
 [!code-csharp[Trin_VstcoreExcelAutomation#44](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#44)]
 [!code-vb[Trin_VstcoreExcelAutomation#44](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#44)]  
  
## Compiling the Code  
 This example requires a range named `rangeData` in a worksheet.  
  
## See Also  
 [Working with Worksheets](../vsto/working-with-worksheets.md)   
 [How to: Programmatically Add New Worksheets to Workbooks](../vsto/how-to-programmatically-add-new-worksheets-to-workbooks.md)   
 [How to: Programmatically Change Formatting in Worksheet Rows Containing Selected Cells](../vsto/how-to-programmatically-change-formatting-in-worksheet-rows-containing-selected-cells.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  