---
title: "How to: Populate documents with data from objects"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], populating with data"
  - "data [Office development in Visual Studio], adding to documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Populate documents with data from objects

Accesing data in a data object works the same way in document-level projects for Microsoft Office Word as it does in Windows Forms projects. You use the same tools and code to bring the data from an object into your solution, and you can use Windows Forms controls to display the data. In addition, you can display data by using host controls. Host controls are native objects in Microsoft Office Word that have been enhanced with events and data binding capability. For more information, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

[!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

You must complete three basic steps to populate the document with data from an object:

- Add a control to the document that you can bind to data.

- Add a data object to the document.

- Connect the data object to the BindingSource.

## To add a data object

To add a data object, open the **Data Sources** window and create a data source from an object. For more information, see [Add new data sources](../data-tools/add-new-data-sources.md).

## Connect the data object to the BindingSource

In document-level projects, you add controls to your document and bind them to data at design time.

In VSTO Add-in projects, you create controls and bind them at run time.

### Document-level projects

To connect the data object to the BindingSource:

1. Drag the data field you want from the **Data Sources** window to your document. This automatically creates a control.

2. In your code, create an instance of the type of the object that you chose for the data source.

3. Assign the instance to the <xref:System.Windows.Forms.BindingSource.DataSource%2A> property of the <xref:System.Windows.Forms.BindingSource>.

### Application-level projects

To connect the data object to the BindingSource:

1. In your code, create an instance of the type of the object that is associated with the data source.

2. Create an instance of a <xref:System.Windows.Forms.BindingSource>.

3. Assign the data source instance to the <xref:System.Windows.Forms.BindingSource.DataSource%2A> property of the <xref:System.Windows.Forms.BindingSource>.

4. Add the data source as a databinding to the control.

## See also

- [Add new data sources](../data-tools/add-new-data-sources.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [How to: Populate documents with data from a database](../vsto/how-to-populate-documents-with-data-from-a-database.md)
- [How to: Update a data source with data from a host control](../vsto/how-to-update-a-data-source-with-data-from-a-host-control.md)
- [BindingSource component overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)