---
title: "How to: Hide Controls on Worksheets when Printing | Microsoft Docs"
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
  - "printing [Office development in Visual Studio], worksheets"
  - "controls [Office development in Visual Studio], hiding while printing"
  - "printing [Office development in Visual Studio], hiding controls"
  - "worksheets, hiding controls when printing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Hide Controls on Worksheets when Printing
  When you print a Microsoft Office Excel document that contains Windows Forms controls, the controls are visible on the printed worksheet. You can hide the controls when printing a worksheet.  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
> [!NOTE]  
>  If you hide controls that display data, such as a <xref:Microsoft.Office.Tools.Excel.Controls.TextBox>, the data in the control will not be visible on the printed worksheet.  
  
> [!NOTE]  
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).  
  
### To hide controls when a worksheet is printed  
  
1.  Create or open an Excel project in Visual Studio and verify that **Sheet1** is visible in the designer. For information about creating projects, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).  
  
2.  From the **Common Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Excel.Controls.Button> control to a cell on `Sheet1`.  
  
3.  In the **Properties** window, set the <xref:Microsoft.Office.Tools.Excel.Controls.Button.PrintObject%2A> property to **False**.  
  
## See Also  
 [Controls on Office Documents](../vsto/controls-on-office-documents.md)   
 [Windows Forms Controls on Office Documents Overview](../vsto/windows-forms-controls-on-office-documents-overview.md)   
 [How to: Add Windows Forms Controls to Office Documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)   
 [How to: Resize Controls Within Worksheet Cells](../vsto/how-to-resize-controls-within-worksheet-cells.md)  
  
  