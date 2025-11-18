---
title: "Automate Excel by using extended objects"
description: Learn that when you develop Excel solutions in Visual Studio, you can use host items and host controls in your solutions.
ms.date: 02/02/2017
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel [Office development in Visual Studio], automating"
  - "automation [Office development in Visual Studio], Excel"
  - "host controls, Excel"
  - "Excel [Office development in Visual Studio], host controls"
  - "extended objects [Office development in Visual Studio], Excel"
  - "host controls [Office development in Visual Studio], Excel"
  - "automating Excel"
  - "host items [Office development in Visual Studio], Excel"
  - "controls [Office development in Visual Studio], Excel host controls"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Automate Excel by using extended objects

  When you develop Excel solutions in Visual Studio, you can use *host items* and *host control*s in your solutions. These are objects that extend certain commonly used objects in the Excel object model (that is, the object model that is exposed by the primary interop assembly for Excel), such as the <xref:Microsoft.Office.Interop.Excel.Worksheet> and <xref:Microsoft.Office.Interop.Excel.Range> objects. The extended objects behave like the Excel objects they are based on, but they add additional features such as new events and data binding capabilities to the objects.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

 Host items and host controls are available in both VSTO Add-in and document-level customizations, although the context in which these can be used is different for each type of solution. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

## Excel host items
 Excel projects give you access to several host items:

- <xref:Microsoft.Office.Tools.Excel.Worksheet>. This host item contains and represents a worksheet in your project. It also acts as a container for managed controls, including host controls and Windows Forms controls, and it maintains information about the controls on its surface. For more information, see [Worksheet host item](../vsto/worksheet-host-item.md).

- <xref:Microsoft.Office.Tools.Excel.Workbook>. This host item represents the workbook in your project, and acts as a container for components that are shared by all worksheets in the workbook. For more information, see [Workbook host item](../vsto/workbook-host-item.md).

- <xref:Microsoft.Office.Tools.Excel.ChartSheet>. This host item a worksheet in Excel that contains only a chart and exposes events.

     When you add a chart sheet at design time as a new sheet in your Microsoft Office Excel document-level customization project, Visual Studio automatically creates a <xref:Microsoft.Office.Tools.Excel.ChartSheet> host item.

     Although a <xref:Microsoft.Office.Tools.Excel.ChartSheet> host item is a worksheet in Excel, you cannot add any controls to the chart sheet. If you want to have other controls on a worksheet with a chart, do not use a chart sheet. Instead, you can place a chart as an embedded object on a worksheet by using the <xref:Microsoft.Office.Tools.Excel.Chart> host control. For more information, see [Chart control](../vsto/chart-control.md).

## Excel host controls
 There are several host controls for Excel that help you create, organize, and automate workbooks and worksheets. These host controls provide events and data-binding capabilities that their counterparts in the native Excel object model do not have.

 For more information about the host controls you can use in Excel projects, see the following topics:

- [Chart control](../vsto/chart-control.md)

- [ListObject control](../vsto/listobject-control.md)

- [NamedRange control](../vsto/namedrange-control.md)

- [XmlMappedRange control](../vsto/xmlmappedrange-control.md)

## Related content
- [How to: Fill ListObject controls with data](../vsto/how-to-fill-listobject-controls-with-data.md)
- [How to: Add Chart controls to worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)
- [How to: Add ListObject controls to worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)
- [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)
- [How to: Add XMLMappedRange controls to worksheets](../vsto/how-to-add-xmlmappedrange-controls-to-worksheets.md)
- [How to: Resize NamedRange controls](../vsto/how-to-resize-namedrange-controls.md)
- [How to: Resize ListObject controls](../vsto/how-to-resize-listobject-controls.md)
- [How to: Validate data when a new row is added to a ListObject control](../vsto/how-to-validate-data-when-a-new-row-is-added-to-a-listobject-control.md)
- [How to: Map ListObject columns to data](../vsto/how-to-map-listobject-columns-to-data.md)
- [Walkthrough: Program against events of a NamedRange control](../vsto/walkthrough-programming-against-events-of-a-namedrange-control.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
