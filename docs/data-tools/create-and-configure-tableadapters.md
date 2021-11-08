---
title: Create and configure TableAdapters
description: Review how to create and configure a TableAdapter in Visual Studio. TableAdapters provide communication between your application and a database.
ms.custom: SEO-VS-2020
ms.date: 09/01/2017
ms.topic: how-to
helpviewer_keywords:
- table adapters, creating
- creating TableAdapters
- data [Visual Studio], creating data components
- data [Visual Studio], TableAdapters
- data [Visual Studio], creating table adapters
ms.assetid: 08630d69-0d6c-4e8f-b42d-2922f45f8415
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Create and configure TableAdapters

TableAdapters provide communication between your application and a database. They connect to the database, run queries or stored procedures, and either return a new data table or fill an existing <xref:System.Data.DataTable> with the returned data. TableAdapters can also send updated data from your application back to the database.

TableAdapters are created for you when you perform one of the following actions:

- Drag database objects from **Server Explorer** into the **Dataset Designer**.

- Run the Data Source Configuration Wizard, and select either the **Database** or **Web Service** data source type.

   ![Data Source Configuration Wizard in Visual Studio](media/data-source-configuration-wizard.png)

You can also create a new TableAdapter and configure it with a data source by dragging a TableAdapter from the **Toolbox** to an empty region in the **Dataset Designer** surface.

For an introduction to TableAdapters, see [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md).

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

## Use the TableAdapter Configuration Wizard

Run the **TableAdapter Configuration Wizard** to create or edit TableAdapters and their associated DataTables. You can configure an existing TableAdapter by right-clicking on it in the **Dataset Designer**.

![raddata Table Adapter Configuration Wizard](../data-tools/media/raddata-table-adapter-configuration-wizard.png)

If you drag a new TableAdapter from the Toolbox when the **Dataset Designer** is in focus, the wizard starts and prompts you to specify which data source the TableAdapter should connect to. On the next page, the wizard asks what kind of commands it should use to communicate with the database, either SQL statements or stored procedures. (You won't see this if you are configuring a TableAdapter that is already associated with a data source.)

- You have the option to create a new stored procedure in the underlying database if you have the correct permissions for the database. If you don't have these permissions, this won't be an option.

- You can also  choose to run existing stored procedures for the **SELECT**, **INSERT**, **UPDATE**, and **DELETE** commands of the TableAdapter. The stored procedure that's assigned to the **Update** command, for example, is run when the `TableAdapter.Update()` method is called.

Map parameters from the selected stored procedure to the corresponding columns in the data table. For example, if your stored procedure accepts a parameter named `@CompanyName` that it passes to the `CompanyName` column in the table, set the **Source Column** of the `@CompanyName` parameter to `CompanyName`.

> [!NOTE]
> The stored procedure that's assigned to the SELECT command is run by calling the method of the TableAdapter that you name in the next step of the wizard. The default method is `Fill`, so the code that's typically used to run the SELECT procedure is `TableAdapter.Fill(tableName)`. If you change the default name from `Fill`, substitute `Fill` with the name you assign, and replace "TableAdapter" with the actual name of the TableAdapter (for example, `CustomersTableAdapter`).

- Selecting the **Create methods to send updates directly to the database** option is equivalent to setting the `GenerateDBDirectMethods` property to true. The option is unavailable when the original SQL statement does not provide enough information or the query is not an updateable query. This situation can occur, for example, in **JOIN** queries and queries that return a single (scalar) value.

The **Advanced Options** in the wizard enable you to:

- Generate INSERT, UPDATE, and DELETE statements based on the SELECT statement that's defined on the **Generate SQL statements** page
- Use optimistic concurrency
- Specify whether to refresh the data table after INSERT and UPDATE statements are run

## Configure a TableAdapter's Fill method

Sometimes you might want to change the schema of the TableAdapter's table. To do this, you modify the  TableAdapter's primary `Fill` method. TableAdapters are created with a primary `Fill` method that defines the schema of the associated data table. The primary `Fill` method is based on the query or stored procedure you entered when you originally configured the TableAdapter. It's the first (topmost) method under the data table in the DataSet Designer.

![TableAdapter with multiple queries](../data-tools/media/tableadapter.gif)

Any changes that you make to the TableAdapter's main `Fill` method are reflected in the schema of the associated data table. For example, removing a column from the query in the main `Fill` method also removes the column from the associated data table. Additionally, removing the column from the main `Fill` method removes the column from any additional queries for that TableAdapter.

You can use the TableAdapter Query Configuration Wizard to create and edit additional queries for the TableAdapter. These additional queries must conform to the table schema, unless they return a scalar value.  Each additional query has a name that you specify.

The following example shows you how to call an additional query named `FillByCity`:

`CustomersTableAdapter.FillByCity(NorthwindDataSet.Customers, "Seattle")`

### To start the TableAdapter Query Configuration Wizard with a new query

1. Open your dataset in the **Dataset Designer**.

2. If you are creating a new query, drag a **Query** object from the **DataSet** tab of the **Toolbox** onto a <xref:System.Data.DataTable>, or select **Add Query** from the TableAdapter's shortcut menu. You can also drag a **Query** object onto an empty area of the **Dataset Designer**, which creates a TableAdapter without an associated <xref:System.Data.DataTable>. These queries can only return single (scalar) values, or run UPDATE, INSERT, or DELETE commands against the database.

3. On the **Choose Your Data Connection** screen, select or create the connection that the query will use.

    > [!NOTE]
    > This screen only appears when the designer can't determine the proper connection to use, or when no connections are available.

4. On the **Choose a Command Type** screen, select from the following methods of fetching data from the database:

    - **Use SQL statements** enables you to type a SQL statement to select the data from your database.

    - **Create new stored procedure** enables you to have the wizard create a new stored procedure (in the database) based on the specified SELECT statement.

    - **Use existing stored procedures** enables you to run an existing stored procedure when running the query.

### To start the TableAdapter Query Configuration wizard on an existing query

- If you are editing an existing TableAdapter query, right-click the query, and then choose **Configure** from the shortcut menu.

    > [!NOTE]
    > Right-clicking the main query of a TableAdapter reconfigures the TableAdapter and <xref:System.Data.DataTable> schema. Right-clicking an additional query on a TableAdapter, however,  configures the selected query only. The **TableAdapter Configuration Wizard** reconfigures the TableAdapter definition, while the **TableAdapter Query Configuration Wizard** reconfigures the selected query only.

### To add a global query to a TableAdapter

- Global queries are SQL queries that return either a single (scalar) value or no value. Typically, global functions perform database operations such as inserts, updates, and deletes. They also aggregate information,  such as a count of customers in a table or the total charges for all items in a particular order.

     You add global queries by dragging a **Query** object from the **DataSet** tab of the **Toolbox** onto an empty area of the **Dataset Designer**.

- Provide a query that performs the desired task, for example, `SELECT COUNT(*) AS CustomerCount FROM Customers`.

    > [!NOTE]
    > Dragging a **Query** object directly onto the **Dataset Designer** creates a method that returns only a scalar (single) value. While the query or stored procedure you select might return more than a single value, the method that's created by the wizard  only returns a single value. For example, the query might return the first column of the first row of the returned data.

## See also

- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
