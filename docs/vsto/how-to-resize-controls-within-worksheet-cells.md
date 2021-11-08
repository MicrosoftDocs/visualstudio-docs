---
title: "How to: Resize controls within worksheet cells"
description: Learn how you can use Visual Studio to resize controls within Microsoft Excel worksheet cells both at design time and at run time.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "controls [Office development in Visual Studio], resizing"
  - "managed controls, resizing"
  - "worksheets, resizing"
  - "Windows Forms controls [Office development in Visual Studio], resizing"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Resize controls within worksheet cells
  When you resize columns or rows on a worksheet, any host controls within the cells automatically resize to the height or width of the cell that was resized. Windows Forms controls do not resize automatically by default.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

 If you add the controls at design time, you must set positioning options for each control.

 If you add a Windows Forms control programmatically and supply a range argument, the control automatically resizes when a cell within the range is resized. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## Resize controls at design time

### To make controls resize with cells at design time

1. From the **Toolbox**, drag a Windows Forms control to a worksheet.

2. Right-click the control, and then click **Format Control**.

3. In the **Format Control** dialog box, click the **Properties** tab.

4. Under **Object Positioning**, select the **Move and size with cells** option, and then click **OK**.

     When you resize the cell that contains the control, the control resizes to fit the cell.

## Resize controls at run time
 If you add a Windows Forms control at run time and pass in a <xref:Microsoft.Office.Interop.Excel.Range> as the location for the control, the control will automatically resize when the worksheet cell that contains the range is resized.

### To make controls resize with cells at run time

1. Add a control to range A1.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb" id="Snippet5":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet5":::

     When you resize the cell that contains the control, the control resizes to fit the cell.

## Reset control placement
 You can reset the placement and resizing of the control by setting the `Placement` property to one of the following <xref:Microsoft.Office.Interop.Excel.XlPlacement> values:

- <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating>

- <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlMove>

- <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlMoveAndSize>

### To change the behavior of a control so that it does not resize or move with the cell

1. Call the placement property of the control and set the value to <xref:Microsoft.Office.Interop.Excel.XlPlacement.xlFreeFloating>.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/my excel chart/Sheet1.vb" id="Snippet6":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingControlsExcelCS/Sheet1.cs" id="Snippet6":::

## See also
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)
- [How to: Hide controls on worksheets when printing](../vsto/how-to-hide-controls-on-worksheets-when-printing.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Limitations of Windows Forms controls on Office documents](../vsto/limitations-of-windows-forms-controls-on-office-documents.md)
