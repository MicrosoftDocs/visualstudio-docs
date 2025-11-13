---
title: Edit data in datasets using the .NET Framework
description: Edit data in datasets with the .NET Framework and Visual Studio and insert new rows into a dataset, identify changed rows, and find rows with errors.
ms.date: 04/24/2025
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- datasets [Visual Basic], editing data
- data [Visual Studio], editing in datasets
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
#customer intent: As a developer, I want to know how to edit data in .NET Framework datasets so that I have more understanding of .NET Framework dataset technologies.

---

# Edit data in datasets using the .NET Framework

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This article describes how to query and edit data in tables in .NET Framework datasets. You can edit data in data tables much like you edit the tables in any database. You can insert, update, and delete records in the table. In a data-bound form, you can specify which fields are user-editable.

In those cases, the data-binding infrastructure handles all the change tracking so that the changes can be sent back to the database. If you edit data programmatically and want to send the changes back to the database, you must use objects and methods that do the change tracking.

In addition to changing the actual data, you can also query a <xref:System.Data.DataTable> to return specific rows of data. For example, you can query for individual rows, original or proposed versions of rows, rows that changed, or rows that contain errors.

## Prerequisites

To use Visual Studio to query and edit data in .NET Framework datasets, you need:

- The **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. For more information, see [Modify Visual Studio](../install/modify-visual-studio.md).
- A C# or Visual Basic (VB) .NET Framework project created.
- A [dataset created](pass-data-between-forms.md#create-the-data-source) from a [SQL Server Express LocalDB](https://www.microsoft.com/sql-server/sql-server-downloads) database.

## Edit rows in a dataset

To edit an existing row in a <xref:System.Data.DataTable>, you need to locate the <xref:System.Data.DataRow> you want to edit, and then assign the updated values to the desired columns.

If you don't know the index of the row you want to edit, use the `FindBy` method to search by the primary key.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet3":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet3":::
---

Once you know the row index, you can use it to access and edit the row.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet5":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet5":::
---

## Insert new rows into a dataset

Applications that use data-bound controls typically add new records by using the **Add New** button on a [BindingNavigator control](/dotnet/framework/winforms/controls/bindingnavigator-control-windows-forms).

You can also add a new record to a dataset by calling the <xref:System.Data.DataTable.NewRow%2A> method on the `DataTable`. Then, add the row to the <xref:System.Data.DataRow> collection (<xref:System.Data.DataTable.Rows%2A>).
### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet1":::
---

## Delete records from a data table

You can delete a <xref:System.Data.DataRow> by calling the <xref:System.Data.DataRowCollection.Remove%2A> method of the <xref:System.Data.DataRowCollection>, or by calling the <xref:System.Data.DataRow.Delete%2A> method of the <xref:System.Data.DataRow> object.

The <xref:System.Data.DataRowCollection.Remove%2A> method removes the row from the collection. If your application doesn't need to send updates back to a data source, you can remove records by directly accessing the data row collection with <xref:System.Data.DataRowCollection.Remove%2A>.

Conversely, the <xref:System.Data.DataRow.Delete%2A> method doesn't actually remove the <xref:System.Data.DataRow>, but marks it for deletion. The actual removal occurs when you call <xref:System.Data.DataRow.AcceptChanges%2A> method. You can programmatically check which rows are marked for removal before actually deleting them.

To retain the information that the dataset needs to send updates to the data source, use the <xref:System.Data.DataRow.Delete%2A> method to remove the <xref:System.Data.DataRow> from the data table. If your application uses a `TableAdapter` or <xref:System.Data.Common.DataAdapter>, the `Update` method deletes rows that have a `RowState` of `Deleted`.

The following example shows how to call the <xref:System.Data.DataRow.Delete%2A> method to mark the first row in the `Customers` table as deleted:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet8":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet8":::
---

> [!NOTE]
> If you get the count property of a <xref:System.Data.DataRowCollection>, the resulting count includes records that are marked for deletion. To get an accurate count of records not marked for deletion, you can loop through the collection and look at the <xref:System.Data.DataRow.RowState%2A> property of each record. Records marked for deletion have a <xref:System.Data.DataRow.RowState%2A> of <xref:System.Data.DataRowState.Deleted>. Alternatively, you can create a data view of a dataset that filters based on row state and get the count property from it.

<a name='determine-if-there-are-changed-rows'></a>
## Determine whether there are changed rows

When you make changes to records in a dataset, information about those changes is stored until you commit them. You commit the changes when you call the `AcceptChanges` method of a dataset or data table, or when you call the `Update` method of a `TableAdapter` or data adapter.

Changes are tracked two ways in each data row:

- Each data row contains information related to its <xref:System.Data.DataRow.RowState%2A>, for example <xref:System.Data.DataRowState.Added>, <xref:System.Data.DataRowState.Modified>, <xref:System.Data.DataRowState.Deleted>, or <xref:System.Data.DataRowState.Unchanged>.

- Each changed data row contains multiple versions. The <xref:System.Data.DataRowVersion> includes the original version before changes and the current version after changes. While a change is pending and you can respond to the <xref:System.Data.DataTable.RowChanging> event, a third proposed version is also available.

To check for changed rows, call the <xref:System.Data.DataSet.HasChanges%2A> method of a dataset. The method returns `true` if changes were made in the dataset. After determining that changes exist, you can call the `GetChanges` method of a <xref:System.Data.DataSet> or <xref:System.Data.DataTable> to return a set of changed rows.

The following example shows how to check the return value from the <xref:System.Data.DataSet.HasChanges%2A> method to detect whether there are any changed rows in `NorthwindDataset1`.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet12":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet12":::
---

## Determine the type of changes

You can check to see what type of changes were made in a dataset by passing a value from the <xref:System.Data.DataRowState> enumeration to the <xref:System.Data.DataSet.HasChanges%2A> method.

The following example shows how to check the `NorthwindDataset1` dataset to determine whether any new rows were added.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet13":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet13":::
---

## Locate rows that have errors

When you work with individual columns and rows of data, you might encounter errors. You can check the `HasErrors` property to determine whether errors exist in a <xref:System.Data.DataSet>, <xref:System.Data.DataTable>, or <xref:System.Data.DataRow>.

If the `HasErrors` property for the dataset is `true`, iterate through the collections of tables, and then through the rows, to find the rows with the errors.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataEditing/CS/Form1.cs" id="Snippet23":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataEditing/VB/Form1.vb" id="Snippet23":::
---

## Related content

- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
