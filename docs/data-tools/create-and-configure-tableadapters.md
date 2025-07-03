---
title: Configure New TableAdapters in .NET Framework Apps
description: Create and configure an ADO.NET TableAdapter in .NET Framework applications with Visual Studio and enable communication between your apps and a database.
ms.date: 07/02/2025
ms.topic: how-to
helpviewer_keywords:
- table adapters, creating
- creating TableAdapters
- data [Visual Studio], creating data components
- data [Visual Studio], TableAdapters
- data [Visual Studio], creating table adapters
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
#customer intent: As a developer, I want to create an ADO.NET TableAdapter in my .NET Framework app, so I can enable communication between my app and a database.
---

# Create and configure TableAdapters in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

**TableAdapters** enable communication between your application and a database. They connect to the database, run queries or stored procedures, and either return a new data table or fill an existing <xref:System.Data.DataTable> class instance with the returned data. TableAdapters can also send updated data from your application back to the database.

TableAdapters are created when you perform one of the following actions:

- Drag database objects from **Server Explorer** into the **Dataset Designer**.
- Drag the `TableAdapter` object from the **Toolbox** to an empty region in the **Dataset Designer** surface, and then configure the data source.
- Run the **Data Source Configuration Wizard**, and select the **Database** or **Web Service** data source type:

   :::image type="content" source="./media/data-source-configuration-wizard.png" border="false" alt-text="Screenshot that shows how to select the data source type in the Data Source Configuration Wizard in Visual Studio.":::

For an introduction to TableAdapters, see [Fill datasets by using TableAdapters](fill-datasets-by-using-tableadapters.md).

## Prerequisites

To complete the procedures in this article, the following prerequisites must be satisfied:

- Visual Studio. [Download Visual Studio now](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

[!INCLUDE[note_settings_general](./includes/note_settings_general_md.md)]

## Access the TableAdapter Configuration Wizard

You can use the **TableAdapter Configuration Wizard** to create new TableAdapters or edit existing instances, and configure their associated data tables. 

- To configure an existing TableAdapter with the wizard, right-click the TableAdapter instance in the **Dataset Designer** and select **Configure**:

   :::image type="content" source="./media/table-adapter-configuration-wizard.png" alt-text="Screenshot that shows how to access the Table Adapter Configuration Wizard in Visual Studio." lightbox="./media/table-adapter-configuration-wizard.png":::

- To create a new TableAdapter with the wizard, drag the `TableAdapter` object from the **Toolbox** to an empty region in the **Dataset Designer** surface.

## Use the wizard

For TableAdapter configuration, the **TableAdapter Configuration Wizard** guides you through the following tasks:

1. Configure required settings for the TableAdapter.

   - Specify the data source type for the TableAdapter connection.

   - Identify the commands to use for communication with the database, either SQL statements or stored procedures. If the TableAdapter is already associated with a data source, you don't see this option in the wizard.

1. Create stored procedures, as needed.

   Create a new stored procedure in the underlying database, if you have the correct permissions for the database. If you don't have the necessary permissions, this option isn't available in the wizard.

1. Run existing stored procedures, as needed.

   Procedures are available for the **SELECT**, **INSERT**, **UPDATE**, and **DELETE** commands of the TableAdapter. For example, the stored procedure assigned to the **UPDATE** command runs when you call the `TableAdapter.Update()` method.

1. Map parameters from the selected stored procedure to the corresponding columns in the data table. For example, if your stored procedure accepts a parameter named `@CompanyName` that it passes to the `CompanyName` column in the data table, set the **Source Column** of the `@CompanyName` parameter to `CompanyName`.

   > [!NOTE]
   > For the **SELECT** command, the stored procedure runs when you call the TableAdapter `Fill` method, by default. You [specify a name for the Fill() method](#configure-the-tableadapterfill-method) in the subsequent page in the wizard. When you use the default method, the typical code to run the stored procedure for the **SELECT** command is `TableAdapter.Fill(<TableName>)`. You replace the `<TableName>` portion with the name of the data table.
   > 
   > If you change the default method name from `Fill`, you need to update the code for the procedure. Replace `Fill` with the new method name and use the actual name of the TableAdapter. For example, for a TableAdapter named `CustomersTableAdapter` and a data table named `CustomersTable`, if you change the `Fill` method name to `AddData`, update the code to `CustomersTableAdapter.AddData(CustomersTable)`.

   - Choose whether to enable the **Create methods to send updates directly to the database** option. When this option is enabled, it's equivalent to setting the `GenerateDBDirectMethods` property to true. The option isn't available when the original SQL statement doesn't provide enough information or the query isn't an updatable query. For example, when **JOIN** queries and other queries return a single (scalar) value.

1. Configure your preferences for the **Advanced Options**.

   - Generate **INSERT**, **UPDATE**, and **DELETE** commands based on the **SELECT** command defined on the **Generate SQL statements** page.

   - Use optimistic concurrency.

   - Refresh the data table after **INSERT** and **UPDATE** commands run.

## Configure the TableAdapter.Fill() method

In some scenarios, you might want to change the schema of the TableAdapter's data table. To complete the action, you modify the TableAdapter's primary `Fill` method. TableAdapters are created with a primary `Fill` method that defines the schema of the associated data table. The primary `Fill` method is based on the query or stored procedure you entered when you originally configured the TableAdapter. It's the first (topmost) method under the data table in the **Dataset Designer**.

:::image type="content" source="../data-tools/media/tableadapter.gif" border="false" alt-text="Diagram that illustrates how to use a TableAdapter with multiple queries.":::

Any changes that you make to the TableAdapter's main `Fill` method are reflected in the schema of the associated data table. For example, removing a column from the query in the main `Fill` method also removes the column from the associated data table. Additionally, removing the column from the main `Fill` method removes the column from any additional queries for that TableAdapter.

You can use the **TableAdapter Query Configuration Wizard** to create and edit additional queries for the TableAdapter. These additional queries must conform to the table schema, unless they return a scalar value. Each additional query has a name that you specify.

The following example shows how to call an additional query named `FillByCity`:

```Query
CustomersTableAdapter.FillByCity(NorthwindDataSet.Customers, "Seattle")
```

## Create a query with the wizard

You can create a new query with the **TableAdapter Query Configuration Wizard** by following these steps:

1. Open your dataset in the **Dataset Designer**.

1. Create a new query with one of the following actions:

   - In the **Dataset Designer**, right-click the TableAdapter and select **Add Query**.
   - Drag the `Query` object from the **DataSet** tab of the **Toolbox** onto a <xref:System.Data.DataTable> in the **Dataset Designer** surface.
   - Drag the `Query` object from the **Toolbox** to an empty region in the **Dataset Designer** surface, which creates a TableAdapter without an associated <xref:System.Data.DataTable>.
   
   These queries can return single (scalar) values only, or run **UPDATE**, **INSERT**, or **DELETE** commands against the database.

1. On the **Choose Your Data Connection** screen, select an existing connection or create a new connection for the query.

   > [!NOTE]
   > This screen appears only when the designer can't determine the connection to use, or when no connections are available.

1. On the **Choose a Command Type** screen, configure the command by selecting from the following methods that fetch data from the database:

   - **Use SQL statements**: You enter a SQL statement to select the data from your database.

   - **Create new stored procedure**: The wizard creates a new stored procedure (in the database) based on the specified **SELECT** command.
   
   - **Use existing stored procedures**: You execute an existing stored procedure when you run the query.

## Configure a query with the wizard

To edit an existing TableAdapter query with the **TableAdapter Query Configuration Wizard**, right-click the query, and select **Configure**. The right-click action produces a different result depending on which type of query you select:

- For the main query of a TableAdapter, both the TableAdapter and the <xref:System.Data.DataTable> schema are reconfigured.

- On an additional query on a TableAdapter, only the selected query is reconfigured.

The **TableAdapter Configuration Wizard** reconfigures the TableAdapter definition, while the **TableAdapter Query Configuration Wizard** reconfigures only the selected query.

## Add a global query to a TableAdapter

Global queries are SQL queries that return either a single (scalar) value or no value. Typically, global functions perform database operations like inserts, updates, and deletes. They also aggregate information, such as a count of customers in a table or the total charges for all items in a particular order.

1. Add a global query by dragging the `Query` object from the **DataSet** tab of the **Toolbox** to an empty region in the **Dataset Designer** surface.

1. Enter a query that performs a specific task, such as `SELECT COUNT(*) AS CustomerCount FROM Customers`.

   > [!NOTE]
   > Dragging a `Query` object directly onto the **Dataset Designer** surface creates a method that returns a scalar (single) value only.
   > While the query or stored procedure you select might return more than a single value, the method created by the wizard returns a single value only. For example, the query might return the first column of the first row of the returned data.

## Related content

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
- <xref:System.Data.DataTable> class
- <xref:System.Data.DataSet> class
