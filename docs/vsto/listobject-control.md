---
title: "ListObject control"
description: The ListObject control is a list that exposes events and can be bound to data. Also, you can add ListObject controls to a worksheet at design time or at run time.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VST.Toolbox.List"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "lists, events"
  - "ListObject control"
  - "ListObject control, events"
  - "ListObject control, data binding"
  - "ListObject control, improving performance when bound to data"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# ListObject control
  The <xref:Microsoft.Office.Tools.Excel.ListObject> control is a list that exposes events and can be bound to data. When you add a list to a worksheet, Visual Studio creates a <xref:Microsoft.Office.Tools.Excel.ListObject> control that you can program against directly without having to traverse the Microsoft Office Excel object model.

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

## Create the control
 In document-level projects, you can add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to a worksheet at design time or at run time. In VSTO Add-in projects, you can add <xref:Microsoft.Office.Tools.Excel.ListObject> controls to worksheets only at run time. For more information, see [How to: Add ListObject controls to worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md).

> [!NOTE]
> By default, dynamically created list objects are not persisted in the worksheet as host controls when the worksheet is closed. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

## Bind data to the control
 A <xref:Microsoft.Office.Tools.Excel.ListObject> control supports simple and complex data binding. The <xref:Microsoft.Office.Tools.Excel.ListObject> control can be bound to a data source using the <xref:Microsoft.Office.Tools.Excel.ListObject.DataSource%2A> and <xref:Microsoft.Office.Tools.Excel.ListObject.DataMember%2A> properties at design time or the <xref:Microsoft.Office.Tools.Excel.ListObject.SetDataBinding%2A> method at run time.

> [!NOTE]
> The <xref:Microsoft.Office.Tools.Excel.ListObject> is updated automatically when it is bound to a data source, such as a <xref:System.Data.DataTable>, that raises events when the data changes. If you bind the <xref:Microsoft.Office.Tools.Excel.ListObject> to a data source that does not raise events when the data changes, you must call the <xref:Microsoft.Office.Tools.Excel.ListObject.RefreshDataRow%2A> or <xref:Microsoft.Office.Tools.Excel.ListObject.RefreshDataRows%2A> method to update the <xref:Microsoft.Office.Tools.Excel.ListObject>.

 When you add a <xref:Microsoft.Office.Tools.Excel.ListObject> to a worksheet cell by mapping a repeating schema element to that cell, Visual Studio automatically maps the <xref:Microsoft.Office.Tools.Excel.ListObject> to the generated dataset. However, the <xref:Microsoft.Office.Tools.Excel.ListObject> is not automatically bound to the data. You can take steps to bind the <xref:Microsoft.Office.Tools.Excel.ListObject> to the dataset at design time or at run time in a document-level project. You can programmatically bind the <xref:Microsoft.Office.Tools.Excel.ListObject> to the dataset at run time in a VSTO Add-in.

 Because the data is separate from the <xref:Microsoft.Office.Tools.Excel.ListObject>, you should add and remove data through the bound dataset, and not directly through the <xref:Microsoft.Office.Tools.Excel.ListObject>. If the data in the bound dataset is updated through any mechanism, the <xref:Microsoft.Office.Tools.Excel.ListObject> control automatically reflects the changes. For more information, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

 You can quickly fill a <xref:Microsoft.Office.Tools.Excel.ListObject> control by binding the <xref:Microsoft.Office.Tools.Excel.ListObject> to a data source. If you edit the data in a data-bound <xref:Microsoft.Office.Tools.Excel.ListObject>, the changes are automatically made in the data source as well. If you want to fill a <xref:Microsoft.Office.Tools.Excel.ListObject> and then enable the user to change the data in the <xref:Microsoft.Office.Tools.Excel.ListObject> without modifying the data source, you can use the <xref:Microsoft.Office.Tools.Excel.ListObject.Disconnect%2A> method to detach the <xref:Microsoft.Office.Tools.Excel.ListObject> from the data source. For more information, see [How to: Fill ListObject controls with data](../vsto/how-to-fill-listobject-controls-with-data.md).

> [!NOTE]
> Data binding is not supported on overlapping <xref:Microsoft.Office.Tools.Excel.ListObject> controls.

### Improve performance in ListObject controls
 Reading an XML file into a data-bound <xref:Microsoft.Office.Tools.Excel.ListObject> control tends to be slower if you bind the control first, and then call <xref:System.Data.DataSet.ReadXml%2A> to fill the dataset. To improve performance, call <xref:System.Data.DataSet.ReadXml%2A> before you bind the control.

### Disconnect ListObject controls from the data source
 After you fill a <xref:Microsoft.Office.Tools.Excel.ListObject> control with data by binding it to a data source, you can disconnect it so that modifications made to the data in the list object do not affect the data source. For more information, see [How to: Fill ListObject controls with data](../vsto/how-to-fill-listobject-controls-with-data.md).

### Restore column and row order
 When you bind data to a <xref:Microsoft.Office.Tools.Excel.ListObject> control that was added to a document at design time, Visual Studio keeps track of the column and row order whenever the workbook is saved. If a user moves the <xref:Microsoft.Office.Tools.Excel.ListObject> columns or rows during run time, the new order is preserved the next time the workbook is opened and the <xref:Microsoft.Office.Tools.Excel.ListObject> control binds to the data source again.

 If you want to restore the <xref:Microsoft.Office.Tools.Excel.ListObject> to its original column and row order, you can call the <xref:Microsoft.Office.Tools.Excel.ListObject.ResetPersistedBindingInformation%2A> method. This method removes the custom document properties related to the column and row order of specified <xref:Microsoft.Office.Tools.Excel.ListObject>. Call this method from the <xref:Microsoft.Office.Tools.Excel.Workbook.Shutdown> event of the Workbook if you do not want to preserve the column and row order of the <xref:Microsoft.Office.Tools.Excel.ListObject>.

## Format
 Formatting that can be applied to a <xref:Microsoft.Office.Interop.Excel.ListObject> can be applied to a <xref:Microsoft.Office.Tools.Excel.ListObject> control. This includes borders, fonts, number format, and styles. End users can rearrange columns in a data-bound <xref:Microsoft.Office.Tools.Excel.ListObject>, and these changes will be persisted with the document, provided the <xref:Microsoft.Office.Tools.Excel.ListObject> was added to the document at design time. The next time the document is opened, the list object will be bound to the same data source, but the column order will reflect the users' changes.

## Add and remove columns at run time
 You cannot manually add or remove columns in a data-bound <xref:Microsoft.Office.Tools.Excel.ListObject> control at run time. If an end user tries to delete a column, it will immediately be restored and any columns added will be removed. Therefore, it is important to write code to explain to users why they cannot perform these actions on a <xref:Microsoft.Office.Tools.Excel.ListObject> that is bound to data. Visual Studio provides several events on a <xref:Microsoft.Office.Tools.Excel.ListObject> related to data binding. For example, you can use the <xref:Microsoft.Office.Tools.Excel.ListObject.OriginalDataRestored> event to warn users that the data they have attempted to delete cannot be deleted and has been restored.

## Add and remove rows at run time
 You can manually add and remove rows in a data-bound <xref:Microsoft.Office.Tools.Excel.ListObject> control, provided the data source allows the addition of new rows and is not read-only. You can write code against events such as the <xref:Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataBoundRow> to validate the data. For more information, see [How to: Validate data when a new row is added to a ListObject control](../vsto/how-to-validate-data-when-a-new-row-is-added-to-a-listobject-control.md).

 Sometimes the relationship of the list object to the data source causes routine errors. For example, you can map which columns you want to appear in the <xref:Microsoft.Office.Tools.Excel.ListObject>, so if you omit columns that have restrictions, such as a field that cannot accept null values, errors are raised every time a row is created. You can write code to add the missing values in an event handler for the <xref:Microsoft.Office.Tools.Excel.ListObject.ErrorAddDataBoundRow> event.

## Rename ListObject controls in Excel
 Excel enables users to change the name of Excel tables at run time by using the **Design** tab. However, the <xref:Microsoft.Office.Tools.Excel.ListObject> control does not support this feature. If a user tries to rename an Excel table that corresponds to a <xref:Microsoft.Office.Tools.Excel.ListObject>, the name of the Excel table will automatically revert to the original name when the workbook is saved.

## Events
 The following events are available for the <xref:Microsoft.Office.Tools.Excel.ListObject> control:

- <xref:Microsoft.Office.Tools.Excel.ListObject.BeforeAddDataBoundRow>

- <xref:Microsoft.Office.Tools.Excel.ListObject.BeforeDoubleClick>

- <xref:Microsoft.Office.Tools.Excel.ListObject.BeforeRightClick>

- <xref:Microsoft.Office.Tools.Excel.ListObject.BindingContextChanged>

- <xref:Microsoft.Office.Tools.Excel.ListObject.Change>

- <xref:Microsoft.Office.Tools.Excel.ListObject.DataBindingFailure>

- <xref:Microsoft.Office.Tools.Excel.ListObject.DataMemberChanged>

- <xref:Microsoft.Office.Tools.Excel.ListObject.DataSourceChanged>

- <xref:Microsoft.Office.Tools.Excel.ListObject.Deselected>

- <xref:Microsoft.Office.Tools.Excel.ListObject.ErrorAddDataBoundRow>

- <xref:Microsoft.Office.Tools.Excel.ListObject.OriginalDataRestored>

- <xref:Microsoft.Office.Tools.Excel.ListObject.Selected>

- <xref:Microsoft.Office.Tools.Excel.ListObject.SelectedIndexChanged>

- <xref:Microsoft.Office.Tools.Excel.ListObject.SelectionChange>

## See also
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [How to: Add ListObject controls to worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)
- [How to: Resize ListObject controls](../vsto/how-to-resize-listobject-controls.md)
- [How to: Validate data when a new row is added to a ListObject control](../vsto/how-to-validate-data-when-a-new-row-is-added-to-a-listobject-control.md)
- [How to: Map ListObject columns to data](../vsto/how-to-map-listobject-columns-to-data.md)
- [How to: Fill ListObject controls with data](../vsto/how-to-fill-listobject-controls-with-data.md)
- [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md)
- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md)
- [Controls on Office documents](../vsto/controls-on-office-documents.md)
- [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md)
- [How to: Populate worksheets with data from a database](../vsto/how-to-populate-worksheets-with-data-from-a-database.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
