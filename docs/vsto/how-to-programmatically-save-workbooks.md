---
title: "How to: Programmatically Save Workbooks | Microsoft Docs"
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
  - "workbooks, saving in XML format"
  - "workbooks, saving"
  - "workbooks, saving backup copies"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Save Workbooks
  There are several ways to save a workbook. You can save a workbook without changing the path. If the workbook has not been saved before, you should save the workbook by specifying a path. Without an explicit path, Microsoft Office Excel saves the file in the current folder with the name it was given when it was created. You can also save a copy of the workbook without modifying the open workbook in memory.  
  
 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]  
  
## Saving a Workbook Without Changing the Path  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Workbook.Save%2A> method of the ThisWorkbook class.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#4](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs#4)]
     [!code-vb[Trin_VstcoreExcelAutomation#4](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb#4)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Workbook.Save%2A> method to save the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#3](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#3)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#3](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#3)]  
  
## Saving a Workbook with a New Path  
 You can save the specified workbook to a new location or with a new name, optionally specifying a file format, a password, an access mode, and more.  
  
> [!NOTE]  
>  You might want to set the <xref:Microsoft.Office.Interop.Excel._Application.DisplayAlerts%2A> property to **False** before saving the workbook with a new path because saving in some formats requires interaction. Setting this property to **False** causes Excel to use all defaults.  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs%2A> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#5](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs#5)]
     [!code-vb[Trin_VstcoreExcelAutomation#5](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb#5)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Workbook.SaveAs%2A> method to save the active workbook to a new path. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#4](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#4)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#4](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#4)]  
  
## Saving a Copy of the Workbook  
 You can save a copy of the workbook to a file without modifying the open workbook in memory. This is useful when you want to create a backup copy without modifying the location of the workbook.  
  
#### To save a workbook associated with a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveCopyAs%2A> method of the `ThisWorkbook` class. To use the following code example, run it in the `ThisWorkbook` class.  
  
     [!code-csharp[Trin_VstcoreExcelAutomation#6](../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/ThisWorkbook.cs#6)]
     [!code-vb[Trin_VstcoreExcelAutomation#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/ThisWorkbook.vb#6)]  
  
#### To save the active workbook in a VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Excel._Workbook.SaveCopyAs%2A> method to save a copy of the active workbook. To use the following code example, run it in the `ThisAddIn` class in a VSTO Add-in project for Excel.  
  
     [!code-csharp[Trin_VstcoreExcelAutomationAddIn#5](../vsto/codesnippet/CSharp/trin_vstcoreexcelautomationaddin/ThisAddIn.cs#5)]
     [!code-vb[Trin_VstcoreExcelAutomationAddIn#5](../vsto/codesnippet/VisualBasic/trin_vstcoreexcelautomationaddin/ThisAddIn.vb#5)]  
  
## Robust Programming  
 Interactively canceling any of the methods that save or copy the workbook raises a run-time error in your code. For example, if your procedure calls the <xref:Microsoft.Office.Tools.Excel.Workbook.SaveAs%2A> method but does not disable prompts from Excel, and your user clicks **Cancel** when prompted, Excel raises a run-time error.  
  
## See Also  
 [Working with Workbooks](../vsto/working-with-workbooks.md)   
 [Workbook Host Item](../vsto/workbook-host-item.md)   
 [How to: Programmatically Close Workbooks](../vsto/how-to-programmatically-close-workbooks.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)  
  
  