---
title: "How to: Programmatically Close Workbooks | Microsoft Docs"
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
  - "workbooks, closing"
  - "Excel [Office development in Visual Studio], closing workbooks"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Close Workbooks
  You can close the active workbook or you can specify a workbook to close.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Closing the Active Workbook  
 There are two procedures for closing the active workbook: one for document-level customizations and one for VSTO Add-ins.  
  
#### To close the active workbook in a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Workbook.Close%2A> method to close the workbook associated with the customization. To use the following code example, run it in the `Sheet1` class in a document-level project for Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#3](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs#3)]
     [!code-vb[Trin_VstcoreExcelAutomation#3](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb#3)]  
  
#### To close the active workbook in a VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Workbook.Close%2A> method to close the active workbook. To use the following code example, run it in the `ThisAddIn` class in an VSTO Add-in project for Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#1](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#1)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#1](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#1)]  
  
## Closing a Workbook That You Specify By Name  
 The way that you close a workbook that you specify by name is the same for VSTO Add-ins and document-level customizations.  
  
#### To close a workbook that you specify by name  
  
1.  Specify the workbook name as an argument to the <xref:Microsoft.Office.Interop.Excel.Workbooks> collection. The following code example assumes that a workbook named **NewWorkbook** is open in Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#2](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#2)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#2](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#2)]  
  
## See Also  
 [Working with Workbooks](../vsto/working-with-workbooks.md)   
 [How to: Programmatically Save Workbooks](../vsto/how-to-programmatically-save-workbooks.md)   
 [How to: Programmatically Open Workbooks](../vsto/how-to-programmatically-open-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)  
  
  