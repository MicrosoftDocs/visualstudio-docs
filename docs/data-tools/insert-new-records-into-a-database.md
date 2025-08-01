---
title: Insert records into database (.NET Framework)
description: Insert new records into a database with .NET Framework application development in Visual Studio, including the ADO.NET TableAdapter Update method.
ms.date: 08/01/2025
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- TableAdapters, inserting new records into
- data [Visual Studio], saving
- databases, inserting new records into
- records, inserting
- saving data
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools

#customer intent: As a developer, I want to develop .NET Framework applications in Visual Studio, so I can insert new records into a database with TableAdapters or command objects.
---

# Insert new records into a database in .NET Framework applications

To insert new records into a database with [ADO.NET](/dotnet/framework/data/adonet/) in a .NET Framework project, the common approach is to use [TableAdapter](../data-tools/create-and-configure-tableadapters.md) methods. TableAdapters enable communication between your application and database. They provide different ways to insert new records into a database, depending on the requirements of your application. You can use the `TableAdapter.Update` method or one of the TableAdapter [DBDirect](save-data-with-the-tableadapter-dbdirect-methods.md) methods (specifically, the `TableAdapter.Insert` method).

This article describes how to insert records into a database for an application built with ADO.NET and the .NET Framework by using Visual Basic (VB) or C#. If your application configuration uses Entity Framework 6, see [Adding a new entity to the context](/ef/ef6/saving/change-tracking/entity-state#adding-a-new-entity-to-the-context), or for Entity Framework Core, see [Adding data](/ef/core/saving/basic#adding-data).

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

## Prerequisites

- To work with TableAdapter methods, you need to have an available instance. For more information, see [Create and configure TableAdapters in .NET Framework applications](create-and-configure-tableadapters.md).

- **.NET security**: You must have access to the database you're trying to connect to, and permission to perform inserts into the desired table.

## Choose insertion method

There are different approaches for inserting records into a database based on your application scenario. The following table summarizes the options:

| Scenario | Approach | Notes |
| --- | --- | --- |
| App uses *datasets* to store data | Use the [TableAdapter.Update](#insert-new-records-with-tableadapterupdate-method) method to send all changes to the database | Changes include updates, insertions, and deletions. |
| App uses *objects* to store data  | Use the [TableAdapter.Insert](#insert-new-records-with-tableadapterinsert-method) method to insert new records into the database | This approach enables you to have finer control over creating new records. |
| App uses TableAdapters, `Insert` method not available | Set the TableAdapter `GenerateDBDirectMethods` property to `true` from within the **Dataset Designer** and save the dataset to regenerate the TableAdapter | If your TableAdapter doesn't have an `Insert` method, the TableAdapter is either configured to use stored procedures or the `GenerateDBDirectMethods` property is set to `false`. <br> If the `Insert` method remains unavailable after regenerating the TableAdapter, the table probably doesn't provide enough schema information to distinguish between individual rows (for example, there might be no primary key set on the table). |
| App doesn't use TableAdapters | Use [command objects](#insert-new-records-with-command-objects) to insert new records into the database | Example: <xref:System.Data.SqlClient.SqlCommand>  |

## Insert new records by using TableAdapters

If your application uses datasets to store data, you can add new records to the desired <xref:System.Data.DataTable> in the dataset, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method sends any changes in the <xref:System.Data.DataTable> to the database, including modified and deleted records.

### Insert new records with TableAdapter.Update method

The following procedure demonstrates how to insert new records into a database by using the `TableAdapter.Update` method:

1. Add new records to the desired <xref:System.Data.DataTable> by creating a new <xref:System.Data.DataRow> and adding it to the <xref:System.Data.DataTable.Rows%2A> collection.

1. After you add the new rows to the <xref:System.Data.DataTable>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing one of the following parameter values:

   - An entire <xref:System.Data.DataSet>
   - A <xref:System.Data.DataTable>
   - An array of <xref:System.Data.DataRow>s
   - A single <xref:System.Data.DataRow>

   The following code shows how to add a new record to a <xref:System.Data.DataTable> and then call the `TableAdapter.Update` method to save the new row to the database. This example uses the `Region` table in the Northwind database.

   ### [C#](#tab/csharp)

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form5.cs" id="Snippet14":::

   ### [VB](#tab/vb)

   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form5.vb" id="Snippet14":::

   ---

### Insert new records with TableAdapter.Insert method

If your application uses objects to store data, you can use the `TableAdapter.Insert` method to create new rows directly in the database. The `Insert` method accepts the individual values for each column as parameters. When you call the method, a new record is inserted into the database with the passed parameter values.

- Call the TableAdapter's `Insert` method, and pass the values for each column as parameters.

The following procedure demonstrates how to use the `TableAdapter.Insert` method to insert rows. This example inserts data into the `Region` table in the Northwind database.

> [!NOTE]
> If you don't have an instance available, instantiate the TableAdapter that you want to use.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet15":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet15":::

---

## Insert new records with command objects

You can insert new records directly into a database by using command objects.

- Create a new command object, and then set its `Connection`, `CommandType`, and `CommandText` properties.

The following procedure demonstrates how to insert records into a database by using command object. This example insert data into the `Region` table in the Northwind database.

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet16":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet16":::

---

## Related content

- [Save data back to the database](save-data-back-to-the-database.md)
- [Save data with the TableAdapter DBDirect methods in .NET Framework applications](save-data-with-the-tableadapter-dbdirect-methods.md)
