---
title: "Use Windows Forms controls on Excel worksheets"
description: Learn how you can add Windows Forms controls to your Microsoft Excel workbooks in the same manner that you add controls to Windows Forms.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Windows Forms controls [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], Windows Forms controls"
  - "controls [Office development in Visual Studio], Window Forms controls"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Use Windows Forms controls on Excel worksheets

  You can add Windows Forms controls to your Microsoft Office Excel workbooks in the same manner that you add controls to Windows Forms. For general information about working with controls on documents, see [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md).

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Control considerations for Excel
 There are a few considerations that are specific to Excel.

### Match control size to cell size
 You can set the control to be resized automatically when the size of the parent cell is changed. For more information, see [How to: Resize controls within Worksheet cells](../vsto/how-to-resize-controls-within-worksheet-cells.md).

### Add components that are shared by all worksheets
 You can add components that you want to share among all worksheets, such as a <xref:System.Data.DataSet>, to the Workbook Designer instead of to the worksheets. The component will appear on the component tray.

### Formula for embedding controls
 When you select a control in Excel, you will see **=EMBED("WinForms.Control.Host","")** in the **Formula Bar**. This text is necessary and should not be deleted.

## Related content
- [How to: Resize controls within worksheet cells](../vsto/how-to-resize-controls-within-worksheet-cells.md)
- [How to: Hide controls on worksheets when printing](../vsto/how-to-hide-controls-on-worksheets-when-printing.md)
- [Walkthrough: Display text in a text box in a worksheet using a button](../vsto/walkthrough-displaying-text-in-a-text-box-in-a-worksheet-using-a-button.md)
- [Walkthrough: Update a chart in a worksheet using radio buttons](../vsto/walkthrough-updating-a-chart-in-a-worksheet-using-radio-buttons.md)
