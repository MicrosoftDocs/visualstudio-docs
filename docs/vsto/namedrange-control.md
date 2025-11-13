---
title: "NamedRange control"
description: Learn how the NamedRange control is a range that has a unique name, exposes events, and can be bound to data.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VST.Toolbox.Range"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, named"
  - "NamedRange control, events"
  - "NamedRange control, data binding"
  - "NamedRange control"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# NamedRange control

  The <xref:Microsoft.Office.Tools.Excel.NamedRange> control is a range that has a unique name, exposes events, and can be bound to data. For more information, see [Excel object model overview](../vsto/excel-object-model-overview.md).

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Create the control
 You can add <xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a Microsoft Office Excel worksheet at design time or at run time in document-level projects.

 You can add <xref:Microsoft.Office.Tools.Excel.NamedRange> controls to a worksheet at run time in a VSTO Add-in. For more information, see [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md).

> [!NOTE]
> By default, dynamically created named ranges are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 <xref:Microsoft.Office.Tools.Excel.NamedRange> controls can only consist of ranges on specific sheets. <xref:Microsoft.Office.Tools.Excel.NamedRange> controls cannot have relative names that apply to all sheets, and they cannot consist of ranges that span two or more worksheets in a workbook (3-D ranges).

## Bind data to the control
 A named range would appear to be a good candidate for complex data binding since it can have many cells; however, a range is merely a collection of cells that cannot be easily mapped to a particular column from a dataset. Therefore, <xref:Microsoft.Office.Tools.Excel.NamedRange> controls only support simple data binding. The <xref:Microsoft.Office.Tools.Excel.ListObject> control can be used for complex data binding. For more information, see [ListObject control](../vsto/listobject-control.md).

 The <xref:Microsoft.Office.Tools.Excel.NamedRange> control can be bound to a data source using the <xref:System.Windows.Forms.Control.DataBindings%2A> properties. The default data binding property of the <xref:Microsoft.Office.Tools.Excel.NamedRange> control is <xref:Microsoft.Office.Tools.Excel.NamedRange.Value2%2A>.

 If the data in the bound dataset is updated through any mechanism, the <xref:Microsoft.Office.Tools.Excel.NamedRange> control reflects the changes.

## Formatting
 Formatting that can be applied to a <xref:Microsoft.Office.Interop.Excel.Range> can be applied to a <xref:Microsoft.Office.Tools.Excel.NamedRange> control. This includes borders, fonts, number formats, and styles.

## Rename the control
 When you add a <xref:Microsoft.Office.Tools.Excel.NamedRange> control to your worksheet from the **Toolbox**, Visual Studio automatically generates a name for the control. You can change the name in the **Properties** window.

## Events
 The following events are available for the <xref:Microsoft.Office.Tools.Excel.NamedRange> control:

- <xref:Microsoft.Office.Tools.Excel.NamedRange.BeforeDoubleClick>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.BeforeRightClick>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.Change>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.Deselected>

- <xref:System.ComponentModel.Component.Disposed>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.Selected>

- <xref:Microsoft.Office.Tools.Excel.NamedRange.SelectionChange>

## Related content
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [How to: Resize NamedRange controls](../vsto/how-to-resize-namedrange-controls.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Walkthrough: Program against events of a NamedRange control](../vsto/walkthrough-programming-against-events-of-a-namedrange-control.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
