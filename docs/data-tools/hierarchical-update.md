---
title: Hierarchical update in .NET Framework development
description: Review hierarchical updates, which involve saving updated data (from a dataset with 2+ related tables) back to a DB while keeping referential integrity rules.
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- saving data, changed data
- data [Visual Basic], hierarchical update
- saving updated data
- datasets [Visual Basic], hierarchical update
- hierarchical update
- saving data, hierarchical update
- modified data saving
- updated data saving
- related tables, saving
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Hierarchical update in .NET Framework development

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

*Hierarchical update* refers to the process of saving updated data (from a dataset with two or more related tables) back to a database while maintaining referential integrity rules. *Referential integrity* refers to the consistency rules provided by the constraints in a database that control the behavior of inserting, updating, and deleting related records. For example, it's referential integrity that enforces the creation of a customer record before allowing orders to be created for that customer. For more information about relationships in datasets, see [Relationships in datasets](../data-tools/relationships-in-datasets.md).

The hierarchical update feature uses a `TableAdapterManager` to manage the `TableAdapter`s in a typed dataset. The `TableAdapterManager` component is a Visual Studio-generated class, not a .NET type. When you drag a table from the **Data Sources** window to a Windows Form or WPF page, Visual Studio adds a variable of type TableAdapterManager to the form or page, and you see it in the designer in the component tray. For detailed information about the `TableAdapterManager` class, see the TableAdapterManager Reference section of [TableAdapters](../data-tools/create-and-configure-tableadapters.md).

By default, a dataset treats related tables as "relations only," which means that it doesn't enforce foreign key constraints. You can modify that setting at design time by using the **Dataset Designer**. Select the relation line between two tables to bring up the **Relation** dialog box. The changes you make here will determine how the `TableAdapterManager` behaves when it send the changes in the related tables back to the database.

## Enable hierarchical update in a dataset

By default, hierarchical update is enabled for all new datasets that are added or created in a project. Turn hierarchical update on or off by setting the **Hierarchical Update** property of a typed dataset in The dataset to **True** or **False**:

![Hierarchical update setting](../data-tools/media/hierarchical-update-setting.png)

## Create a new relation between tables

To create a new relation between two tables, in the Dataset Designer, select the title bar of each table, then right-click and select **Add relation**.

![Hierarchical update add relation menu](../data-tools/media/hierarchical-update-add-relation-menu.png)

## Understand foreign-key constraints, cascading updates, and deletes

It's important to understand how foreign-key constraints and cascading behavior in the database are created in the generated dataset code.

By default, the data tables in a dataset are generated with relationships (<xref:System.Data.DataRelation>) that match the relationships in the database. However, the relationship in the dataset is not generated as a foreign-key constraint. The <xref:System.Data.DataRelation> is configured as **Relation Only** without <xref:System.Data.ForeignKeyConstraint.UpdateRule%2A> or <xref:System.Data.ForeignKeyConstraint.DeleteRule%2A> in effect.

By default, cascading updates and cascading deletes are turned off even if the database relationship is set with cascading updates or cascading deletes turned on. For example, creating a new customer and a new order and then trying to save the data can cause a conflict with the foreign-key constraints that are defined in the database. For more information, see [Turn off constraints while filling a dataset](turn-off-constraints-while-filling-a-dataset.md).

## Set the order to perform updates

Setting the order to perform updates sets the order of the individual inserts, updates, and deletes that are required to save all the modified data in all tables of a dataset. When hierarchical update is enabled, inserts are performed first, then updates, and then deletes. The `TableAdapterManager` provides an `UpdateOrder` property that can be set to perform updates first, then inserts, and then deletes.

> [!NOTE]
> It's important to understand that the update order is all inclusive. That is, when updates are performed, inserts and then deletes are performed for all tables in the dataset.

To set the `UpdateOrder` property, after dragging items from the [Data Sources Window](add-new-data-sources.md#work-with-data-sources-and-windows-forms) onto a form, select the `TableAdapterManager` in the component tray, and then set the `UpdateOrder` property in the **Properties** window.

## Create a backup copy of a dataset before performing a hierarchical update

When you save data (by calling the `TableAdapterManager.UpdateAll()` method), the `TableAdapterManager` attempts to update the data for each table in a single transaction. If any part of the update for any table fails, the whole transaction is rolled back. In most situations, the rollback returns your application to its original state.

However, sometimes you might want to restore the dataset from the backup copy. One example of this might occur when you're using auto-increment values. For example, if a save operation is not successful, auto-increment values are not reset in the dataset, and the dataset continues to create auto-incrementing values. This leaves a gap in numbering that might not be acceptable in your application. In situations where this is an issue, the `TableAdapterManager` provides a `BackupDataSetBeforeUpdate` property that replaces the existing dataset with a backup copy if the transaction fails.

> [!NOTE]
> The backup copy is only in memory while the `TableAdapterManager.UpdateAll` method is running. Therefore, there is no programmatic access to this backup dataset because it either replaces the original dataset or goes out of scope as soon as the `TableAdapterManager.UpdateAll` method finishes running.

## Modify the generated save code to perform the hierarchical update

Save changes from the related data tables in the dataset to the database by calling the `TableAdapterManager.UpdateAll` method and passing in the name of the dataset that contains the related tables. For example, run the `TableAdapterManager.UpdateAll(NorthwindDataset)` method to send updates from all the tables in NorthwindDataset to the back-end database.

After you drop the items from the **Data Sources** window, code is automatically added to the `Form_Load` event to populate each table (the `TableAdapter.Fill` methods). Code is also added to the **Save** button click event of the <xref:System.Windows.Forms.BindingNavigator> to save data from the dataset back to the database (the `TableAdapterManager.UpdateAll` method).

The generated save code also contains a line of code that calls the `CustomersBindingSource.EndEdit` method. More specifically, it calls the <xref:System.Windows.Forms.BindingSource.EndEdit%2A> method of the first <xref:System.Windows.Forms.BindingSource>that's added to the form. In other words, this code is only generated for the first table that's dragged from the **Data Sources** window onto the form. The <xref:System.Windows.Forms.BindingSource.EndEdit%2A> call commits any changes that are in process in any data-bound controls that are currently being edited. Therefore, if a data-bound control still has focus and you click the **Save** button, all pending edits in that control are committed before the actual save (the `TableAdapterManager.UpdateAll` method).

> [!NOTE]
> The **Dataset Designer** only adds the `BindingSource.EndEdit` code for the first table that's dropped onto the form. Therefore, you have to add a line of code to call the `BindingSource.EndEdit` method for each related table on the form. For this walkthrough, this means you have to add a call to the `OrdersBindingSource.EndEdit` method.

### To update the code to commit changes to the related tables before saving

1. Double-click the **Save** button on the <xref:System.Windows.Forms.BindingNavigator> to open **Form1** in the Code Editor.

2. Add a line of code to call the `OrdersBindingSource.EndEdit` method after the line that calls the `CustomersBindingSource.EndEdit` method. The code in the **Save** button click event should resemble the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VSProDataOrcasHierarchicalUpdate/CS/Form1.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VSProDataOrcasHierarchicalUpdate/VB/Form1.vb" id="Snippet1":::
     ---

In addition to committing changes on a related child table before saving data to a database, you might also have to commit newly created parent records before adding new child records to a dataset. In other words, you might have to add the new parent record (`Customer`) to the dataset before foreign key constraints enable new child records (`Orders`) to be added to the dataset. To accomplish this, you can use the child `BindingSource.AddingNew` event.

> [!NOTE]
> Whether you have to commit new parent records depends on the type of control that's used to bind to your data source. In this walkthrough, you use individual controls to bind to the parent table. This requires the additional code to commit the new parent record. If the parent records were instead displayed in a complex binding control like the <xref:System.Windows.Forms.DataGridView>, this additional <xref:System.Windows.Forms.BindingSource.EndEdit%2A> call for the parent record would not be necessary. This is because the underlying data-binding functionality of the control handles the committing of the new records.

### To add code to commit parent records in the dataset before adding new child records

1. Create an event handler for the `OrdersBindingSource.AddingNew` event.

    - Open **Form1** in design view, select **OrdersBindingSource** in the component tray, select **Events** in the **Properties** window, and then double-click the **AddingNew** event.

2. Add a line of code to the event handler that calls the `CustomersBindingSource.EndEdit` method. The code in the `OrdersBindingSource_AddingNew` event handler should resemble the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VSProDataOrcasHierarchicalUpdate/CS/Form1.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VSProDataOrcasHierarchicalUpdate/VB/Form1.vb" id="Snippet2":::
     ---

## TableAdapterManager reference

By default, a `TableAdapterManager` class is generated when you create a dataset that contains related tables. To prevent the class from being generated, change the value of the `Hierarchical Update` property of the dataset to false. When you drag a table that has a relation onto the design surface of a Windows Form or WPF page, Visual Studio declares a member variable of the class. If you don't use databinding, you have to manually declare the variable.

The `TableAdapterManager` class is not a .NET type. Therefore, you can't look it up in the documentation. It's created at design time as part of the dataset creation process.

The following are the frequently used methods and properties of the `TableAdapterManager` class:

|Member|Description|
|------------|-----------------|
|`UpdateAll` method|Saves all data from all data tables.|
|`BackUpDataSetBeforeUpdate` property|Determines whether to create a backup copy of the dataset before executing the `TableAdapterManager.UpdateAll` method.Boolean.|
|*tableName* `TableAdapter` property|Represents a `TableAdapter`. The generated `TableAdapterManager` contains a property for each `TableAdapter` it manages. For example, a dataset with a Customers and Orders table is generated with a `TableAdapterManager` that contains `CustomersTableAdapter` and `OrdersTableAdapter` properties.|
|`UpdateOrder` property|Controls the order of the individual insert, update, and delete commands. Set this to one of the values in the `TableAdapterManager.UpdateOrderOption` enumeration.<br /><br /> By default, the `UpdateOrder` is set to **InsertUpdateDelete**. This means that inserts, then updates, and then deletes are performed for all tables in the dataset.|

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
