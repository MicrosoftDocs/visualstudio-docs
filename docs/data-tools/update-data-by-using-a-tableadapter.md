---
title: Update data with TableAdapter (.NET Framework)
description: Update data in a dataset with .NET Framework application development in Visual Studio and return data to the database with the ADO.NET TableAdapter.Update method.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- data [Visual Studio], saving
- data [Visual Studio], TableAdapters
- updating data, TableAdapters
- TableAdapters, updating data
- data [Visual Studio], updating
- saving data
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Update data by using a TableAdapter in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

After the data in your dataset has been modified and validated, you can send the updated data back to a database by calling the `Update` method of a [TableAdapter](../data-tools/create-and-configure-tableadapters.md). The `Update` method updates a single data table and runs the correct command (`INSERT`, `UPDATE`, or `DELETE`) based on the <xref:System.Data.DataRow.RowState%2A> of each data row in the table. When a dataset has related tables, Visual Studio generates a TableAdapterManager class that you use to do the updates. The TableAdapterManager class ensures that updates are made in the correct order based on the foreign-key constraints that are defined in the database. When you use data-bound controls, the databinding architecture creates a member variable of the TableAdapterManager class called tableAdapterManager.

> [!NOTE]
> When you try to update a data source with the contents of a dataset, you can get errors. To avoid errors, we recommend that you put the code that calls the adapter's `Update` method inside a `try`/`catch` block.

The exact procedure for updating a data source can vary depending on business needs, but includes the following steps:

1. Call the adapter's `Update` method in a `try`/`catch` block.

2. If an exception is caught, locate the data row that caused the error.

3. Reconcile the problem in the data row (programmatically if you can, or by presenting the invalid row to the user for modification), and then try the update again (<xref:System.Data.DataRow.HasErrors%2A>, <xref:System.Data.DataTable.GetErrors%2A>).

## Save data to a database

Call the `Update` method of a TableAdapter. Pass the name of the data table that contains the values to be written to the database.

### To update a database by using a TableAdapter

- Enclose the TableAdapter's `Update` method in a `try`/`catch` block. The following example shows how to update the contents of the `Customers` table in `NorthwindDataSet` from within a `try`/`catch` block.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs" id="Snippet9":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb" id="Snippet9":::
     ---

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
