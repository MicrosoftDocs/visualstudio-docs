---
title: "XmlMappedRange control"
description: Learn that the XmlMappedRange control is a range that is created only when a non-repeating schema element is mapped onto a cell in Microsoft Excel.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "XMLMappedRange control, data binding"
  - "XMLMappedRange control"
  - "XMLMappedRange control, events"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# XmlMappedRange control
  The <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control is a range that is created only when a non-repeating schema element is mapped onto a cell in Microsoft Office Excel. For example, when the `maxOccurs` attribute of a schema element equals 1. After Visual Studio creates the XML mapped range, you can program against it directly without having to traverse the Excel object model. You can only delete a <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control within Excel when the element mapping is removed.

 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

## Bind data to the control
 An <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control supports binding to a single data field (simple data binding). The <xref:Microsoft.Office.Tools.Excel.ListObject> control can supports complex data binding, and is automatically created when a repeating schema element is mapped onto a cell. For more information, see [ListObject control](../vsto/listobject-control.md).

 The <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control is bound to a data source using the <xref:System.Windows.Forms.Control.DataBindings%2A> property. When an <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is added to a worksheet cell, Visual Studio automatically generates a data set from the data in the mapped cells, and binds the control to that data set. The default data binding property of the <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> is <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Value2%2A>.

 If the data in the bound data set is updated through any mechanism, the <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control reflects the changes.

## Formatting
 You can apply the same formatting to an <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control that you can apply to a <xref:Microsoft.Office.Interop.Excel.Range>. This includes borders, fonts, number format, and styles.

## Events
 The events available for the <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> control are:

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BeforeDoubleClick>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BeforeRightClick>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Change>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Selected>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.Deselected>

- <xref:System.ComponentModel.Component.Disposed>

- <xref:Microsoft.Office.Tools.Excel.XmlMappedRange.SelectionChange>

## See also
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [How to: Add XMLMappedRange controls to worksheets](../vsto/how-to-add-xmlmappedrange-controls-to-worksheets.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [How to: Map schemas to worksheets inside Visual Studio](../vsto/how-to-map-schemas-to-worksheets-inside-visual-studio.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
