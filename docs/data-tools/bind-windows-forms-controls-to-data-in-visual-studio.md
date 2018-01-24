---
title: "Bind Windows Forms controls to data in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/03/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "data [Windows Forms], data sources"
  - "Windows Forms, data binding"
  - "Windows Forms, displaying data"
  - "displaying data on forms"
  - "forms, displaying data"
  - "data sources, displaying data"
  - "displaying data, Windows Forms"
  - "data [Windows Forms], displaying"
ms.assetid: 243338ef-41af-4cc5-aff7-1e830236f0ec
caps.latest.revision: 37
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# Bind Windows Forms controls to data in Visual Studio
You can display data to users of your application by binding data to Windows Forms. To create these data-bound controls, you can drag items from the **Data Sources** window onto the Windows Forms Designer in Visual Studio.
  
![Data Source drag operation](../data-tools/media/raddata-data-source-drag-operation.png "raddata Data Source drag operation")

Before you drag items, you can set the type of control you want to bind to. Different values appear depending on whether you choose the table itself, or an individual column.  You can also set custom values. For a table, "Details" means that each column is bound to a separate control.  

![Bind data source to DataGridView](../data-tools/media/raddata-bind-data-source-to-datagridview.png "raddata Bind data source to DataGridView")  
  
## BindingSource and BindingNavigator Controls
The <xref:System.Windows.Forms.BindingSource> component serves two purposes. First, it provides a layer of abstraction when binding the controls to data. Controls on the form are bound to the <xref:System.Windows.Forms.BindingSource> component instead of directly to a data source. Second, it can manage a collection of objects. Adding a type to the <xref:System.Windows.Forms.BindingSource> creates a list of that type.  
  
For more information about the <xref:System.Windows.Forms.BindingSource> component, see:  
  
-   [BindingSource Component](/dotnet/framework/winforms/controls/bindingsource-component)  
  
-   [BindingSource Component Overview](/dotnet/framework/winforms/controls/bindingsource-component-overview)  
  
-   [BindingSource Component Architecture](/dotnet/framework/winforms/controls/bindingsource-component-architecture)  
  
The [BindingNavigator control](/dotnet/framework/winforms/controls/bindingnavigator-control-windows-forms) provides a user interface for navigating through data displayed by a Windows application.

## Bind to data in a DataGridView control  
For a [DataGridView control](/dotnet/framework/winforms/controls/datagridview-control-overview-windows-forms), the entire table is bound to that single control. When you drag a DataGridView to the form, a tool strip for navigating records (<xref:System.Windows.Forms.BindingNavigator>) also appears. A [DataSet](../data-tools/dataset-tools-in-visual-studio.md), [TableAdapter](../data-tools/create-and-configure-tableadapters.md), <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray. In the following illustration, a TableAdapterManager is also added because the Customers table has a relation to the Orders table. These variables are all declared in the auto-generated code as private members in the form class. The auto-generated code for filling the DataGridView is located in the form_load event handler. The code for saving the data to update the database is located in the Save event handler for the BindingNavigator. You can move or modify this code as needed.  
  
![GridView with BindingNavigator](../data-tools/media/raddata-gridview-with-bindingnavigator.png "raddata GridView with BindingNavigator")  
  
You can customize the behavior of the DataGridView and the BindingNavigator by clicking on the smart tag in the upper right corner of each:  
  
![DataGridView and Binding Navigator smart tags](../data-tools/media/raddata-datagridview-and-binding-navigator-smart-tags.png "raddata DataGridView and Binding Navigator smart tags")  
  
If the controls your application needs are not available from within the **Data Sources** window, you can add controls. For more information, see [Add custom controls to the Data Sources window](../data-tools/add-custom-controls-to-the-data-sources-window.md).  
  
You can also drag items from the **Data Sources** window onto controls already on a form to bind the control to data. A control that is already bound to data has its data bindings reset to the item most recently dragged onto it. To be valid drop targets, controls must be capable of displaying the underlying data type of the item dragged onto it from the **Data Sources** window. For example, it's not valid to drag an item that has a data type of <xref:System.DateTime> onto a <xref:System.Windows.Forms.CheckBox>, because the <xref:System.Windows.Forms.CheckBox> is not capable of displaying a date.  
  
## Bind to data in individual controls  
When you bind a data source to "Details," each column in the dataset is bound to a separate control.  
  
![Bind data source to details](../data-tools/media/raddata-bind-data-source-to-details.png "raddata Bind data source to details")  
  
> [!IMPORTANT]
> Note that in the previous illustration, you drag from the Orders property of the Customers table, not from the Orders table. By binding to the Customer.Orders property, navigation commands made in the DataGridView are reflected immediately in the details controls. If you dragged from the Orders table, the controls would still be bound to the dataset, but not they would not be synchronized with the DataGridView.  
  
The following illustration shows the default data-bound controls that are added to the form after the Orders property in the Customers table is bound to "Details" in the **Data Sources** window.  
  
![Orders table bound to details](../data-tools/media/raddata-orders-table-bound-to-details.png "raddata Orders table bound to details")  
  
Note also that each control has a smart tag. This tag enables customizations that apply to that control only.
  
## See also
[Binding controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)  
[Data binding in Windows Forms (.NET Framework)](/dotnet/framework/winforms/windows-forms-data-binding)