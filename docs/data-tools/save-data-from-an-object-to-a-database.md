---
title: Save object data to a database (.NET Framework)
description: Save data from an object to a database with ADO.NET DataSet tools in Visual Studio and save new records, update existing records, or delete existing records.
ms.date: 11/01/2023
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- data [Visual Studio], saving
- data access [Visual Studio], objects
- saving data
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Save data from an object to a database in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

You can save data in objects to a database by passing the values from your object to one of the TableAdapter's DBDirect methods (for example, `TableAdapter.Insert`). For more information, see [TableAdapter](../data-tools/create-and-configure-tableadapters.md).

To save data from a collection of objects, loop through the collection of objects (for example, a for-next loop), and send the values for each object to the database by using one of the TableAdapter's `DBDirect` methods.

By default, `DBDirect` methods are created on a TableAdapter that can be run directly against the database. These methods can be called directly and don't require <xref:System.Data.DataSet> or <xref:System.Data.DataTable> objects to reconcile changes in order to send updates to a database.

> [!NOTE]
> When you're configuring a TableAdapter, the main query must provide enough information for the `DBDirect` methods to be created. For example, if a TableAdapter is configured to query data from a table that does not have a primary key column defined, it does not generate `DBDirect` methods.

|TableAdapter DBDirect method|Description|
| - |-----------------|
|`TableAdapter.Insert`|Adds new records to a database and enables you to pass in individual column values as method parameters.|
|`TableAdapter.Update`|Updates existing records in a database. The `Update` method takes original and new column values as method parameters. The original values are used to locate the original record, and the new values are used to update that record.<br /><br /> The `TableAdapter.Update` method is also used to reconcile changes in a dataset back to the database by taking a <xref:System.Data.DataSet>, <xref:System.Data.DataTable>, <xref:System.Data.DataRow>, or an array of <xref:System.Data.DataRow>s as method parameters.|
|`TableAdapter.Delete`|Deletes existing records from the database based on the original column values passed in as method parameters.|

## To save new records from an object to a database

- Create the records by passing the values to the `TableAdapter.Insert` method.

     The following example creates a new customer record in the `Customers` table by passing the values in the `currentCustomer` object to the `TableAdapter.Insert` method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs" id="Snippet23":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb" id="Snippet23":::
     ---

## To update existing records from an object to a database

- Modify the records by calling the `TableAdapter.Update` method, passing in the new values to update the record, and passing in the original values to locate the record.

    > [!NOTE]
    > Your object needs to maintain the original values in order to pass them to the `Update` method. This example uses properties with an `orig` prefix to store the original values.

     The following example updates an existing record in the `Customers` table by passing the new and original values in the `Customer` object to the `TableAdapter.Update` method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs" id="Snippet24":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb" id="Snippet24":::
     ---

## To delete existing records from a database

- Delete the records by calling the `TableAdapter.Delete` method and passing in the original values to locate the record.

    > [!NOTE]
    > Your object needs to maintain the original values in order to pass them to the `Delete` method. This example uses properties with an `orig` prefix to store the original values.

     The following example deletes a record from the `Customers` table by passing the original values in the `Customer` object to the `TableAdapter.Delete` method.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form3.cs" id="Snippet25":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form3.vb" id="Snippet25":::
     ---

## .NET security

You must have permission to perform the selected `INSERT`, `UPDATE`, or `DELETE` on the table in the database.

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
