---
title: Add chart controls to your worksheet
description: Add chart controls to your worksheet to use a chart object created by Visual Studio that you can program against directly.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VST.ProjectItem.ExcelChart"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Chart control [Office development in Visual Studio], events"
  - "Chart control [Office development in Visual Studio]"
  - "Chart control [Office development in Visual Studio], data binding"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Chart control

  The <xref:Microsoft.Office.Tools.Excel.Chart> control is a chart object that exposes events. When you add a chart to a worksheet, Visual Studio creates a <xref:Microsoft.Office.Tools.Excel.Chart> object that you can program against directly without having to traverse the Microsoft Office Excel object model.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Create the control
 You can add <xref:Microsoft.Office.Tools.Excel.Chart> controls to a Microsoft Office Excel worksheet at design time or at run time in a document-level project.

 You can add <xref:Microsoft.Office.Tools.Excel.Chart> controls to a worksheet at run time in a VSTO Add-in. For more information, see [How to: Add Chart controls to worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md).

> [!NOTE]
> Dynamically created chart objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## Formatting
 All formatting that can be applied to a <xref:Microsoft.Office.Interop.Excel.Chart> can also be applied to a <xref:Microsoft.Office.Tools.Excel.Chart> control. This includes borders, fonts, chart type, gridlines, legend, and data labels.

## Events
 The following events are available for the <xref:Microsoft.Office.Tools.Excel.Chart> control:

- <xref:Microsoft.Office.Tools.Excel.Chart.ActivateEvent>

- <xref:Microsoft.Office.Tools.Excel.Chart.BeforeDoubleClick>

- <xref:Microsoft.Office.Tools.Excel.Chart.BeforeRightClick>

- <xref:Microsoft.Office.Tools.Excel.Chart.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Excel.Chart.Calculate>

- <xref:Microsoft.Office.Tools.Excel.Chart.Deactivate>

- <xref:System.ComponentModel.Component.Disposed>

- <xref:Microsoft.Office.Tools.Excel.Chart.DragOver>

- <xref:Microsoft.Office.Tools.Excel.Chart.DragPlot>

- <xref:Microsoft.Office.Tools.Excel.Chart.MouseDown>

- <xref:Microsoft.Office.Tools.Excel.Chart.MouseMove>

- <xref:Microsoft.Office.Tools.Excel.Chart.MouseUp>

- <xref:Microsoft.Office.Tools.Excel.Chart.Resize>

- <xref:Microsoft.Office.Tools.Excel.Chart.SelectEvent>

- <xref:Microsoft.Office.Tools.Excel.Chart.SeriesChange>

## Related content
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [How to: Add Chart controls to worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
