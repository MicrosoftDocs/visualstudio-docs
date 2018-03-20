---
title: "How to: Resize Controls Within Worksheet Cells | Microsoft Docs"
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
  - "controls [Office development in Visual Studio], resizing"
  - "managed controls, resizing"
  - "worksheets, resizing"
  - "Windows Forms controls [Office development in Visual Studio], resizing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Resize Controls Within Worksheet Cells
  When you resize columns or rows on a worksheet, any host controls contained in the cells automatically resize to the height or width of the cell that was resized. Windows Forms controls do not resize automatically by default.  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
 If you add the controls at design time, you must set positioning options for each control.  
  
 If you add a Windows Forms control programmatically and supply a range argument, the control automatically resizes when a cell within the range is resized. For more information, see [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md).  
  
## Resizing Controls at Design Time  
  
#### To make controls resize with cells at design time  
  
1.  From the **Toolbox**, drag a Windows Forms control to a worksheet.  
  
2.  Right-click the control, and then click **Format Control**.  
  
3.  In the **Format Control** dialog box, click the **Properties** tab.  
  
4.  Under **Object Positioning**, select the **Move and size with cells** option, and then click **OK**.  
  
     When you resize the cell that contains the control, the control resizes to fit the cell.  
  
## Resizing Controls at Run Time  
 If you add a Windows Forms control at run time and pass in a <xref:Microsoft.Office.Interop.Excel.Range> as the location for the control, the control will automatically resize when the worksheet cell that contains the range is resized.  
  
#### To make controls resize with cells at run time  
  
1.  Add a control to range A1.  
  
     [!code-vb[Trin_VstcoreProgrammingControlsExcel#5](../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb#5)]
     [!code-csharp[Trin_VstcoreProgrammingControlsExcel#5](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs#5)]  
  
     When you resize the cell that contains the control, the control resizes to fit the cell.  
  
## Resetting Control Placement  
 You can reset the placement and resizing of the control by setting the `Placement` property to one of the following <xref:Microsoft.Office.Interop.Excel.XlPlacement> values:  
  
-   <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating>  
  
-   <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlMove>  
  
-   <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlMoveAndSize>  
  
#### To change the behavior of a control so that it does not resize or move with the cell  
  
1.  Call the placement property of the control and set the value to <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating>.  
  
     [!code-vb[Trin_VstcoreProgrammingControlsExcel#6](../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb#6)]
     [!code-csharp[Trin_VstcoreProgrammingControlsExcel#6](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs#6)]  
  
## See Also  
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)   
 [How to: Hide Controls on Worksheets when Printing](../vsto/how-to-hide-controls-on-worksheets-when-printing.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)   
 [Limitations of Windows Forms Controls on Office Documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md)  
  