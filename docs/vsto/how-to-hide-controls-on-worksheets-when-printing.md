---
title: "How to: Hide controls on worksheets when printing"
description: Learn that you can hide the controls when printing a Microsoft Office Excel worksheet that contains Windows Forms controls. 
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "printing [Office development in Visual Studio], worksheets"
  - "controls [Office development in Visual Studio], hiding while printing"
  - "printing [Office development in Visual Studio], hiding controls"
  - "worksheets, hiding controls when printing"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Hide controls on worksheets when printing
  When you print a Microsoft Office Excel document that contains Windows Forms controls, the controls are visible on the printed worksheet. You can hide the controls when printing a worksheet.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

> [!NOTE]
> If you hide controls that display data, such as a <xref:Microsoft.Office.Tools.Excel.Controls.TextBox>, the data in the control will not be visible on the printed worksheet.

> [!NOTE]
> Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalize the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).

## To hide controls when a worksheet is printed

1. Create or open an Excel project in Visual Studio and verify that **Sheet1** is visible in the designer. For information about creating projects, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

2. From the **Common Controls** tab of the **Toolbox**, drag a <xref:Microsoft.Office.Tools.Excel.Controls.Button> control to a cell on `Sheet1`.

3. In the **Properties** window, set the <xref:Microsoft.Office.Tools.Excel.Controls.Button.PrintObject%2A> property to **False**.

## See also
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
- [How to: Resize controls within worksheet cells](../vsto/how-to-resize-controls-within-worksheet-cells.md)
