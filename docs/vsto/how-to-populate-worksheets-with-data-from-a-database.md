---
title: "How to: Populate worksheets with data from a database"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "worksheets [Office development in Visual Studio], populating"
  - "databases [Office development in Visual Studio], populating worksheets"
  - "data [Office development in Visual Studio], adding to worksheets"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Populate worksheets with data from a database

You can access data in document-level Office projects in the same way that you access data in Windows Forms projects. You use the same tools and code to bring the data into your solution, and you can even use Windows Forms controls to display the data. In addition, you can take advantage of controls called host controls, which are native objects in Microsoft Office Excel that have been enhanced with events and data-binding capability. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

[!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]

The following example shows how to add data-bound controls in document-level projects using a designer. For an example of how to add data-bound controls in application-level projects at run time, see [Walkthrough: Complex data binding in VSTO Add-in project](../vsto/walkthrough-complex-data-binding-in-vsto-add-in-project.md).

## Add a data-bound control to a worksheet at design time

### To populate a worksheet with data from a database

1. Open an Excel document-level project in Visual Studio, with the worksheet open in the designer.

2. Open the **Data Sources** window and create a data source for your project. For more information, see [Add new connections](../data-tools/add-new-connections.md).

3. Drag the field or table you want from the **Data Sources** window to your worksheet.

One of the following controls is created on the worksheet:

- If you drag a field, a <xref:Microsoft.Office.Tools.Excel.NamedRange> control is created on the worksheet. For more information, see [NamedRange control](../vsto/namedrange-control.md).

- If you drag a table, a <xref:Microsoft.Office.Tools.Excel.ListObject> control is created on the worksheet. For more information, see [ListObject control](../vsto/listobject-control.md).

You can add a different control by selecting the table or field in the **Data Sources** window and then choosing a different control from the drop-down list.

## Objects in the project

In addition to the control, the following data-related objects are automatically added to your project:

- A typed dataset that encapsulates the data tables that you connected to in the database. For more information, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md).

- A <xref:System.Windows.Forms.BindingSource> that connects the control to the typed dataset. For more information, see [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview).

- A TableAdapter that connects the typed dataset to the database. For more information, see [TableAdapter overview](../data-tools/fill-datasets-by-using-tableadapters.md#tableadapter-overview).

- A TableAdapterManager, which is used to coordinate table adapters in the dataset to enable hierarchical updates. For more information, see [Hierarchical update](../data-tools/hierarchical-update.md) and [TableAdapterManager reference](../data-tools/fill-datasets-by-using-tableadapters.md#tableadaptermanager-reference).

When you run the project, the control displays the first record in the data source. You can use the <xref:System.Windows.Forms.BindingSource> to enable users to scroll through the records.

### To scroll through the records

- Use <xref:System.Windows.Forms.BindingSource> methods such as <xref:System.Windows.Forms.BindingSource.MoveNext%2A> and <xref:System.Windows.Forms.BindingSource.MovePrevious%2A>.

For information about how to send updates to the typed dataset and the database, see [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md).

## See also

- [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md)
- [Add new data sources](../data-tools/add-new-data-sources.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [How to: Populate documents with data from objects](../vsto/how-to-populate-documents-with-data-from-objects.md)
- [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md)
- [How to: Populate documents with data from services](../vsto/how-to-populate-documents-with-data-from-services.md)
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)