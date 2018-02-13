---
title: "How to: Programmatically Display a String in a Worksheet Cell | Microsoft Docs"
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
  - "text [Office development in Visual Studio], adding to worksheets"
  - "worksheets, displaying text in cells"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Display a String in a Worksheet Cell
  This example demonstrates how to display text in a cell programmatically. To display text in cell, use either a <xref:Microsoft.Office.Tools.Excel.NamedRange> control or a native Excel range object.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Using a NamedRange Control  
 This example uses a <xref:Microsoft.Office.Tools.Excel.NamedRange> control named `message`. The control must be added to a document-level customization at design time. The following code must be placed in a sheet class, not in the `ThisWorkbook` class.  
  
#### To display text in a NamedRange control  
  
1.  Set the value of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control to **Hello World**.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#68](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#68)]
     [!code-vb[Trin_VstcoreExcelAutomation#68](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#68)]  
  
## Using a Native Excel Range  
 The following code creates a new range programmatically and then assigns a value to it.  
  
#### To display text in an Excel range  
  
1.  Retrieve the range at cell **A1** on `Sheet1` and set the value to **Hello World**.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#69](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#69)]
     [!code-vb[Trin_VstcoreExcelAutomation#69](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#69)]  
  
## See Also  
 [Walkthrough: Collecting Data Using a Windows Form](../vsto/walkthrough-collecting-data-using-a-windows-form.md)   
 [Troubleshooting Office Solutions](../vsto/troubleshooting-office-solutions.md)   
 [NamedRange Control](../vsto/namedrange-control.md)   
 [Global Access to Objects in Office Projects](../vsto/global-access-to-objects-in-office-projects.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  