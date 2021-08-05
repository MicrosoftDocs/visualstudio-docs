---
title: "How to: Populate documents with data from a database"
description: Learn how you can use the data from a database in your solution, and how you can use Windows Forms controls to display the data in a document.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents, populating with data"
  - "data, adding to documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Populate documents with data from a database

You can access data in document-level projects for Microsoft Office in the same way that you access data in Windows Forms projects. You use the same tools and code to bring the data from a database into your solution, and you can use Windows Forms controls to display the data.

In addition, you can display data by using host controls. Host controls are native objects in Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

[!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

The following example shows how to add data-bound controls in document-level projects using a designer. For an example of how to add data-bound controls in VSTO Add-in projects at run time, see [Walkthrough: Simple data binding in VSTO Add-in project](../vsto/walkthrough-simple-data-binding-in-vsto-add-in-project.md).

![link to video](../vsto/media/playvideo.gif "link to video") For a related video demonstration, see [Bind data to Word 2007 content controls Using Visual Studio Tools for the Office system (3.0)](/previous-versions/office/developer/office-2007/bb967663(v=office.12)).

## Add a control to a document at design time

### To populate a document with data from a database

1. Open a Word document-level project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], with the document open in the designer.

2. Open the **Data Sources** window and create a data source from a database. For more information, see [Add new connections](../data-tools/add-new-connections.md).

3. Drag the field you want from the **Data Sources** window to your document.

A content control is added to the document. The type of content control depends on the data type of the field you selected. For more information, see [Content controls](../vsto/content-controls.md).

You can add a different control by selecting the data field in the **Data Sources** window and then choosing a different control from the drop-down list.

## Objects in the project

In addition to the control, the following data-related objects are automatically added to your project:

- A typed dataset that encapsulates the data tables that you connected to in the database. For more information, see [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md).

- A <xref:System.Windows.Forms.BindingSource> that connects the control to the typed dataset. For more information, see [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview).

- A TableAdapter that connects the typed dataset to the database. For more information, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).

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
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)
- [Use local database files in Office solutions overview](../vsto/using-local-database-files-in-office-solutions-overview.md)
- [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)