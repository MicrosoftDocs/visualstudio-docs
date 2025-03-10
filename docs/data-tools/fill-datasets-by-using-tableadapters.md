---
title: Fill datasets by using TableAdapters in .NET Framework applications
description: Fill datasets in .NET Framework applications with TableAdapters and data from queries or stored procedures by using ADO.NET in Visual Studio.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: concept-article
ms.date: 03/10/2025
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- datasets [Visual Basic]
- datasets [Visual Basic], loading data
- data retrieval
- retrieving data
- datasets [Visual Basic], filling
- data [Visual Studio], retrieving
- data [Visual Studio], datasets

# Customer intent: As a developer, I want to understand how to fill and update datasets by using TableAdapters based on queries and stored procedures so that can manipulate the data in my .NET Framework apps.
---

# Fill datasets by using TableAdapters in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

A TableAdapter component fills a dataset with data from the database, based on one or more queries or stored procedures that you specify. TableAdapters can also perform adds, updates, and deletes on the database to persist changes that you make to the dataset. In addition, you can issue global commands that are unrelated to any specific table.

> [!NOTE]
> Visual Studio designers generate TableAdapters. If you're creating datasets programmatically, use the `DataAdapter` .NET class.

For detailed information about TableAdapter operations, you can skip directly to one of these articles:

|Article|Description|
|-----------|-----------------|
|[Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md)|Learn how to use the designers to create and configure TableAdapters.|
|[Create parameterized TableAdapter queries](../data-tools/create-parameterized-tableadapter-queries.md)|Learn how to enable users to supply arguments to TableAdapter procedures or queries.|
|[Directly access the database with a TableAdapter](../data-tools/directly-access-the-database-with-a-tableadapter.md)|Learn how to use the `DbDirect` methods of TableAdapters.|
|[Turn off constraints while filling a dataset](../data-tools/turn-off-constraints-while-filling-a-dataset.md)|Learn how to work with foreign-key constraints when updating data.|
|[Extend the functionality of a TableAdapter](../data-tools/extend-the-functionality-of-a-tableadapter.md)|Learn how to add custom code to TableAdapters.|
|[Read XML data into a dataset](../data-tools/read-xml-data-into-a-dataset.md)|Learn how to work with XML data in a dataset.|

## TableAdapter overview

TableAdapters are designer-generated components that connect to a database, run queries or stored procedures, and fill their DataTable with the returned data. TableAdapters also send updated data from your application back to the database. You can run as many queries as you want on a TableAdapter as long as it returns data that conforms to the schema of its associated table. The following diagram shows how TableAdapters interact with databases and other objects in memory:

:::image type="content" source="../data-tools/media/clientdatadiagram.gif" alt-text="Diagram that shows the TableAdapter data flow in a client application.":::

Although TableAdapters are designed with the Dataset Designer, the `TableAdapter` classes aren't generated as nested classes of  <xref:System.Data.DataSet>. Instead, they're located in separate namespaces that are specific to each dataset. For example, if you have a dataset named `NorthwindDataSet`, the TableAdapters that are associated with <xref:System.Data.DataTable> objects in the `NorthwindDataSet` are in the `NorthwindDataSetTableAdapters` namespace. To access a particular TableAdapter programmatically, declare a new instance of the `TableAdapter` class. For example:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataTableAdapters/CS/Class1.cs" id="Snippet7":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataTableAdapters/VB/Class1.vb" id="Snippet7":::

---

## Associated DataTable schema

When you create a TableAdapter, you use the initial query or stored procedure to define the schema of the TableAdapter's associated <xref:System.Data.DataTable>. You run this initial query or stored procedure by calling the TableAdapter's `Fill` method, which fills the TableAdapter's associated <xref:System.Data.DataTable>. Any changes that you make to the TableAdapter's main query are reflected in the schema of the associated data table. For example, if you remove a column from the main query, the Dataset Designer also removes the column from the associated data table. If any additional queries on the TableAdapter use SQL statements that return columns that aren't in the main query, the Dataset Designer attempts to synchronize the column changes between the main query and the additional queries.

## TableAdapter update commands

The update functionality of a TableAdapter is dependent on how much information is available in the main query in the **TableAdapter Wizard**. For example, TableAdapters that are configured to fetch values from multiple tables (using a `JOIN`), scalar values, views, or the results of aggregate functions aren't initially created with the ability to send updates back to the underlying database. However, you can configure the **InsertCommand**, **UpdateCommand**, and **DeleteCommand** properties manually in the **Properties** window.

## TableAdapter queries

TableAdapters can contain multiple queries to fill their associated data tables. You can define as many queries for a TableAdapter as your application requires, as long as each query returns data that conforms to the same schema as its associated data table. This capability enables a TableAdapter to load different results based on differing criteria.

:::image type="content" source="../data-tools/media/tableadapter.gif" alt-text="Diagram that shows a TableAdapter with multiple queries.":::

For example, if your application contains a table with customer names, you can create a query that fills the table with every customer name that begins with a certain letter. You can create another query that fills the table with all customers that are located in the same state. To fill a `Customers` table with customers in a given state, create a `FillByState` query that takes a parameter for the state value as follows: `SELECT * FROM Customers WHERE State = @State`. Run the query by calling the `FillByState` method and passing in the parameter value, for example: `CustomerTableAdapter.FillByState("WA")`.

In addition to adding queries that return data of the same schema as the TableAdapter's data table, you can add queries that return scalar (single) values. For example, a query that returns a count of customers (`SELECT Count(*) From Customers`) is valid for a `CustomersTableAdapter`, even though the returned data doesn't conform to the table's schema.

## ClearBeforeFill property

By default, every time you run a query to fill a TableAdapter's data table, the existing data is cleared, and only the results of the query are loaded into the table. If you want to add or merge the data that a query returns to the existing data in a data table, set the TableAdapter's `ClearBeforeFill` property to `false`. Regardless of whether you clear the data, you must explicitly send updates back to the database if you want to persist them. Therefore, ensure you save any changes to the data in the table before you run another query that fills the table. For more information, see [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md).

## TableAdapter inheritance

TableAdapters extend the functionality of standard data adapters by encapsulating a configured <xref:System.Data.Common.DataAdapter> class. By default, the TableAdapter inherits from the <xref:System.ComponentModel.Component> class and can't be cast to the <xref:System.Data.Common.DataAdapter> class. Casting a TableAdapter to the <xref:System.Data.Common.DataAdapter> class results in an <xref:System.InvalidCastException> error. To change the base class of a TableAdapter, specify a class that derives from the <xref:System.ComponentModel.Component> class in the **Base Class** property of the TableAdapter in the Dataset Designer.

## TableAdapter methods and properties

The `TableAdapter` class isn't a .NET type, which means you can't look it up in the Object Browser or reference documentation. Visual Studio creates it at design time when you use one of the wizards described previously. The name that Visual Studio assigns to a TableAdapter you create is based on the name of the table you're working with. For example, when you create a TableAdapter based on a table in a database named `Orders`, the TableAdapter is named `OrdersTableAdapter`. To change the class name of the TableAdapter, use the **Name** property in the Dataset Designer's **Properties** window.

The commonly used methods and properties of a TableAdapter are as follows:

|Member|Description|
|------------|-----------------|
|`TableAdapter.Fill`|Populates the TableAdapter's associated data table with the results of the TableAdapter's `SELECT` command.|
|`TableAdapter.Update`|Sends changes back to the database and returns an integer that represents the number of rows affected by the update. For more information, see [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md).|
|`TableAdapter.GetData`|Returns a new <xref:System.Data.DataTable> filled with data.|
|`TableAdapter.Insert`|Creates a new row in the data table. For more information, see [Insert new records into a database](../data-tools/insert-new-records-into-a-database.md).|
|`TableAdapter.ClearBeforeFill`|Determines whether a data table is emptied before you call one of the `Fill` methods.|

## TableAdapter update method

TableAdapters use data commands to read to and write from the database. Use the TableAdapter's initial `Fill` (main) query as the basis for creating the schema of the associated data table, and the `InsertCommand`, `UpdateCommand`, and `DeleteCommand` commands that are associated with the `TableAdapter.Update` method. When you call a TableAdapter's `Update` method, it runs the statements that were created when the TableAdapter was originally configured, and not one of the extra queries that you added with the **TableAdapter Query Configuration Wizard**.

When you use a TableAdapter, it effectively performs the same operations with the commands that you typically perform. For example, when you call the adapter's `Fill` method, the adapter runs the data command in its `SelectCommand` property and uses a data reader (for example, <xref:System.Data.SqlClient.SqlDataReader>) to load the result set into the data table. Similarly, when you call the adapter's `Update` method, it runs the appropriate command (in the `UpdateCommand`, `InsertCommand`, and `DeleteCommand` properties) for each changed record in the data table.

> [!NOTE]
> If the main query contains enough information, the designer creates the `InsertCommand`, `UpdateCommand`, and `DeleteCommand` commands by default when the designer generates the TableAdapter. However, if the TableAdapter's main query is more than a single table `SELECT` statement, the designer might not be able to generate these commands. In such a case, you might receive an error when you run the `TableAdapter.Update` method.

## TableAdapter GenerateDbDirectMethods

In addition to `InsertCommand`, `UpdateCommand`, and `DeleteCommand`, TableAdapters are created with the following methods that you can run directly against the database: `TableAdapter.Insert`, `TableAdapter.Update`, and `TableAdapter.Delete`. You can call these methods directly to manipulate data in the database. Doing so means you can call these individual methods from your code instead of calling `TableAdapter.Update` to handle the inserts, updates, and deletes that are pending for the associated data table.

If you don't want to create these direct methods, set the TableAdapter's **GenerateDbDirectMethods** property to **False** in the **Properties** window. Extra queries that are added to the TableAdapter are standalone queries, which don't generate these methods.

## TableAdapter support for nullable types

TableAdapters support nullable types `Nullable<T>` and `T?`. For more information about nullable types in Visual Basic, see [Nullable value types (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/data-types/nullable-value-types). For more information about nullable types in C#, see [Nullable value types (C#)](/dotnet/csharp/programming-guide/nullable-types/using-nullable-types).

## TableAdapterManager reference

By default, Visual Studio generates a `TableAdapterManager` class when you create a dataset that contains related tables. To prevent the class from being generated, change the value of the `Hierarchical Update` property of the dataset to `false`. When you drag a table that has a relation onto the design surface of a Windows Form or WPF page, Visual Studio declares a member variable of the class. If you don't use databinding, you must manually declare the variable.

Because the `TableAdapterManager` class isn't a .NET type, it doesn't appear in the reference documentation. Visual Studio creates it at design time as part of the dataset creation process.

The following table lists frequently used methods and properties of the `TableAdapterManager` class:

|Member|Description|
|------------|-----------------|
|`UpdateAll` method|Saves all data from all data tables.|
|`BackUpDataSetBeforeUpdate` property|Determines whether to create a backup copy of the dataset before executing the `TableAdapterManager.UpdateAll` `method.Boolean`.|
|*tableName* `TableAdapter` property|Represents a TableAdapter. The generated TableAdapterManager contains a property for each `TableAdapter` it manages. For example, a dataset with a Customers and Orders table generates with a TableAdapterManager that contains `CustomersTableAdapter` and `OrdersTableAdapter` properties.|
|`UpdateOrder` property|Controls the order of the individual insert, update, and delete commands. Set this property to one of the values in the `TableAdapterManager.UpdateOrderOption` enumeration.<br /><br /> By default, the `UpdateOrder` is set to `InsertUpdateDelete`, which means that inserts, updates, and then deletes are performed for all tables in the dataset.|

## Security

When you use data commands with a `CommandType` property set to <xref:System.Data.CommandType.Text>, carefully check information sent from a client before passing it to your database. Malicious users might try to send (inject) modified or extra SQL statements to gain unauthorized access to the database. Before you transfer user input to a database, always verify that the information is valid. A best practice is to use parameterized queries or stored procedures when possible.

## Related content

- [Visual Studio dataset tools](../data-tools/dataset-tools-in-visual-studio.md)
