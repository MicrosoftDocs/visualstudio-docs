---
title: Insert new records into a database in .NET Framework applications
description: Insert new records into a database with .NET Framework application development in Visual Studio, including the ADO.NET TableAdapter.Update method.
ms.date: 06/01/2023
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
manager: jmartens
ms.technology: vs-data-tools
---
# Insert new records into a database in .NET Framework applications

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

To insert new records into a database with [ADO.NET](/dotnet/framework/data/adonet/) in a .NET Framework project, you can use the `TableAdapter.Update` method, or one of the TableAdapter's DBDirect methods (specifically the `TableAdapter.Insert` method). For more information, see [TableAdapter](../data-tools/create-and-configure-tableadapters.md).

If your application doesn't use TableAdapters, you can use command objects (for example,  <xref:System.Data.SqlClient.SqlCommand>) to  insert new records in your database.

If your application uses datasets to store data, use the `TableAdapter.Update` method. The `Update` method sends all changes (updates, inserts, and deletes) to the database.

If your application uses objects to store data, or if you want finer control over creating new records in the database, use the `TableAdapter.Insert` method.

If your TableAdapter doesn't have an `Insert` method, it means that either the TableAdapter is configured to use stored procedures, or its `GenerateDBDirectMethods` property is set to `false`. Try setting the TableAdapter's `GenerateDBDirectMethods` property to `true` from within the **Dataset Designer**, and then save the dataset. This action regenerates the TableAdapter. If the TableAdapter still doesn't have an `Insert` method, the table probably doesn't provide enough schema information to distinguish between individual rows (for example, there might be no primary key set on the table).

> [!NOTE]
> This article applies to ADO.NET and .NET Framework development. For the same task with Entity Framework 6, see [Adding a new entity to the context](/ef/ef6/saving/change-tracking/entity-state#adding-a-new-entity-to-the-context). For Entity Framework Core, see [Adding data](/ef/core/saving/basic#adding-data).

## Insert new records by using TableAdapters

TableAdapters provide different ways to insert new records into a database, depending on the requirements of your application.

If your application uses datasets to store data, you can add new records to the desired <xref:System.Data.DataTable> in the dataset, and then call the `TableAdapter.Update` method. The `TableAdapter.Update` method sends any changes in the <xref:System.Data.DataTable> to the database (including modified and deleted records).

### To insert new records into a database by using the TableAdapter.Update method

1. Add new records to the desired <xref:System.Data.DataTable> by creating a new <xref:System.Data.DataRow> and adding it to the <xref:System.Data.DataTable.Rows%2A> collection.

2. After the new rows are added to the <xref:System.Data.DataTable>, call the `TableAdapter.Update` method. You can control the amount of data to update by passing in either an entire <xref:System.Data.DataSet>, a <xref:System.Data.DataTable>, an array of <xref:System.Data.DataRow>s, or a single <xref:System.Data.DataRow>.

   The following code shows how to add a new record to a <xref:System.Data.DataTable> and then call the `TableAdapter.Update` method to save the new row to the database. (This example uses the `Region` table in the Northwind database.)

   ### [C#](#tab/csharp)
   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form5.cs" id="Snippet14":::

   ### [VB](#tab/vb)
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form5.vb" id="Snippet14":::
   ---

### To insert new records into a database by using the TableAdapter.Insert method

If your application uses objects to store  data, you can use the `TableAdapter.Insert` method to create new rows directly in the database. The `Insert` method accepts the individual values for each column as parameters. Calling the method inserts a new record into the database with the parameter values passed in.

- Call the TableAdapter's `Insert` method, passing in the values for each column as parameters.

The following procedure demonstrates using the `TableAdapter.Insert` method to insert rows. This example inserts data into the `Region` table in the Northwind database.

> [!NOTE]
> If you do not have an instance available, instantiate the TableAdapter you want to use.

### [C#](#tab/csharp)
:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet15":::

### [VB](#tab/vb)
:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet15":::
---

## Insert new records by using command objects

You can insert new records directly into a database using command objects.

### To insert new records into a database by using command objects

- Create a new command object, and then set its `Connection`, `CommandType`, and `CommandText` properties.

The following example demonstrates inserting records into a database using command object. It inserts data into the `Region` table in the Northwind database.

### [C#](#tab/csharp)
:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Class1.cs" id="Snippet16":::

### [VB](#tab/vb)
:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Class1.vb" id="Snippet16":::
---

## .NET security

You must have access to the database you're trying to connect to, and permission to perform inserts into the desired table.

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
