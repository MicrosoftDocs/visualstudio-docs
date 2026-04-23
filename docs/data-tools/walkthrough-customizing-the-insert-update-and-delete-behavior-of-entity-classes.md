---
title: Customize insert/update/delete behavior
description: In this walkthrough, customize the insert, update, and delete behavior of entity classes using the LINQ to SQL tools in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Walkthrough: Customize the insert, update, and delete behavior of entity classes

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

The [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md) provides a visual design surface for creating and editing LINQ to SQL classes (entity classes) that are based on objects in a database. By using [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index), you can use LINQ technology to access SQL databases. For more information, see [LINQ (Language Integrated Query)](/dotnet/csharp/linq/).

By default, the logic to perform updates is provided by the LINQ to SQL runtime. The runtime creates default `Insert`, `Update`, and `Delete` statements based on the schema of the table (the column definitions and primary key information). When you do not want to use the default behavior, you can configure the update behavior and designate specific stored procedures for performing the necessary inserts, updates, and deletes required to work with the data in the database. You can also do this when the default behavior is not generated, for example, when your entity classes map to views. Additionally, you can override the default update behavior when the database requires table access through stored procedures. For more information, see [Customizing operations by using stored procedures](/dotnet/framework/data/adonet/sql/linq/customizing-operations-by-using-stored-procedures).

> [!NOTE]
> This walkthrough requires the availability of the **InsertCustomer**, **UpdateCustomer**, and **DeleteCustomer** stored procedures for the Northwind database.

This walkthrough provides the steps that you must follow to override the default LINQ to SQL run-time behavior for saving data back to a database by using stored procedures.

During this walkthrough, you learn how to perform the following tasks:

- Create a new Windows Forms application and add a LINQ to SQL file to it.

- Create an entity class that is mapped to the Northwind `Customers` table.

- Create an object data source that references the LINQ to SQL `Customer` class.

- Create a Windows Form that contains a <xref:System.Windows.Forms.DataGridView> that is bound to the `Customer` class.

- Implement save functionality for the form.

- Create <xref:System.Data.Linq.DataContext> methods by adding stored procedures to the **O/R Designer**.

- Configure the `Customer` class to use stored procedures to perform inserts, updates, and deletes.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (**SQL Server Object Explorer** installs as part of the **Data storage and processing** workload in the **Visual Studio Installer**.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Creating an application and adding LINQ to SQL classes

Because you are working with LINQ to SQL classes and displaying the data on a Windows Form, create a new Windows Forms application and add a LINQ to SQL Classes file.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

### To create a new Windows Forms Application project that contains LINQ to SQL classes

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **UpdatingWithSProcsWalkthrough**, and then choose **OK**.

     The **UpdatingWithSProcsWalkthrough** project is created, and added to **Solution Explorer**.

4. On the **Project** menu, click **Add New Item**.

5. Click the **LINQ to SQL Classes** template and type **Northwind.dbml** in the **Name** box.

6. Click **Add**.

     An empty LINQ to SQL Classes file (**Northwind.dbml**) is added to the project, and the **O/R Designer** opens.

## Create the Customer entity class and object data source

Create LINQ to SQL classes that are mapped to database tables by dragging tables from **Server Explorer** or **Database Explorer** onto the **O/R Designer**. The result is LINQ to SQL entity classes that map to the tables in the database. After you create entity classes, they can be used as object data sources just like other classes that have public properties.

### To create a Customer entity class and configure a data source with it

1. In **Server Explorer** or **Database Explorer**, locate the **Customer** table in the SQL Server version of the Northwind sample database.

2. Drag the **Customers** node from **Server Explorer** or **Database Explorer** onto the **O/R Designer* surface.

     An entity class named **Customer** is created. It has properties that correspond to the columns in the Customers table. The entity class is named **Customer** (not **Customers**) because it represents a single customer from the Customers table.

    > [!NOTE]
    > This renaming behavior is called *pluralization*. It can be turned on or off in the [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md). For more information, see [How to: Turn pluralization on and off (O/R Designer)](../data-tools/how-to-turn-pluralization-on-and-off-o-r-designer.md).

3. On the **Build** menu, click **Build UpdatingwithSProcsWalkthrough** to build the project.

4. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

5. In the **Data Sources** window, click **Add New Data Source**.

6. Click **Object** on the **Choose a Data Source Type** page, and then select **Next**.

7. Expand the **UpdatingwithSProcsWalkthrough** node and locate and select the **Customer** class.

    > [!NOTE]
    > If the **Customer** class is not available, cancel out of the wizard, build the project, and run the wizard again.
8. Click **Finish** to create the data source and add the **Customer** entity class to the **Data Sources** window.

## Create a DataGridView to display the customer data on a Windows Form

Create controls that are bound to entity classes by dragging LINQ to SQL data source items from the **Data Sources** window onto a Windows Form.

### To add controls that are bound to the entity classes

1. Open **Form1** in Design view.

2. From the **Data Sources** window, drag the **Customer** node onto **Form1**.

    > [!NOTE]
    > To display the **Data Sources** window, click **Show Data Sources** on the **Data** menu.

3. Open **Form1** in the Code Editor.

4. Add the following code to the form, global to the form, outside any specific method, but inside the `Form1` class:

    ### [C#](#tab/csharp)

    ```csharp
    private NorthwindDataContext northwindDataContext1
        = new NorthwindDataContext();
    ```

    ### [VB](#tab/vb)

    ```vb
    Private NorthwindDataContext1 As New NorthwindDataContext
    ```

    ---

5. Create an event handler for the `Form_Load` event and add the following code to the handler:

    ### [C#](#tab/csharp)

    ```csharp
    customerBindingSource.DataSource
        = northwindDataContext1.Customers;
    ```

    ### [VB](#tab/vb)

    ```vb
    CustomerBindingSource.DataSource = NorthwindDataContext1.Customers
    ```

    ---

## Implement save functionality

By default, the save button is not enabled and save functionality is not implemented. Also, code is not automatically added to save changed data to the database when data-bound controls are created for object data sources. This section explains how to enable the save button and implement save functionality for LINQ to SQL objects.

### To implement save functionality

1. Open **Form1** in Design view.

2. Select the save button on the **CustomerBindingNavigator** (the button with the floppy disk icon).

3. In the **Properties** window, set the **Enabled** property to **True**.

4. Double-click the save button to create an event handler and switch to the Code Editor.

5. Add the following code into the save button event handler:

    ### [C#](#tab/csharp)

    ```csharp
    northwindDataContext1.SubmitChanges();
    ```

    ### [VB](#tab/vb)

    ```vb
    NorthwindDataContext1.SubmitChanges()
    ```

    ---

## Override the default behavior for performing updates (inserts, updates, and deletes)

### To override the default update behavior

1. Open the LINQ to SQL file in the **O/R Designer**. (Double-click the **Northwind.dbml** file in **Solution Explorer**.)

2. In **Server Explorer** or **Database Explorer**, expand the Northwind databases **Stored Procedures** node and locate the **InsertCustomers**, **UpdateCustomers**, and **DeleteCustomers** stored procedures.

3. Drag all three stored procedures onto the **O/R Designer**.

     The stored procedures are added to the methods pane as <xref:System.Data.Linq.DataContext> methods. For more information, see [DataContext methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md).

4. Select the **Customer** entity class in the **O/R Designer**.

5. In the **Properties** window, select the **Insert** property.

6. Click the ellipsis (**...**) next to **Use Runtime** to open the **Configure Behavior** dialog box.

7. Select **Customize**.

8. Select the **InsertCustomers** method in the **Customize** list.

9. Click **Apply** to save the configuration for the selected Class and Behavior.

    > [!NOTE]
    > You can continue to configure the behavior for each class/behavior combination as long as you click **Apply** after you make each change. If you change the class or behavior before you click **Apply**, a warning dialog box providing an opportunity to apply any changes appears.

10. Select **Update** in the **Behavior** list.

11. Select **Customize**.

12. Select the **UpdateCustomers** method in the **Customize** list.

     Inspect the list of **Method Arguments** and **Class Properties** and notice that there are two **Method Arguments** and two **Class Properties** for some columns in the table. This makes it easier to track changes and create statements that check for concurrency violations.

13. Map the **Original_CustomerID** method argument to the **CustomerID (Original)** class property.

    > [!NOTE]
    > By default, method arguments will map to class properties when the names match. If property names are changed and no longer match between the table and the entity class, you might have to select the equivalent class property to map to if the **O/R Designer** cannot determine the correct mapping. Additionally, if method arguments do not have valid class properties to map to, you can set the **Class Properties** value to **(None)**.

14. Click **Apply** to save the configuration for the selected Class and Behavior.

15. Select **Delete** in the **Behavior** list.

16. Select **Customize**.

17. Select the **DeleteCustomers** method in the **Customize** list.

18. Map the **Original_CustomerID** method argument to the **CustomerID (Original)** class property.

19. Click **OK**.

> [!NOTE]
> Although it is not an issue for this particular walkthrough, it is worth noting that LINQ to SQL handles database-generated values automatically for identity (auto-increment), rowguidcol (database-generated globally unique identifier (GUID)), and timestamp columns during inserts and updates. Database-generated values in other column types will unexpectedly result in a null value. To return the database-generated values, you should manually set <xref:System.Data.Linq.Mapping.ColumnAttribute.IsDbGenerated%2A> to `true` and <xref:System.Data.Linq.Mapping.ColumnAttribute.AutoSync%2A> to one of the following: [AutoSync.Always](<xref:System.Data.Linq.Mapping.AutoSync.Always>), [AutoSync.OnInsert](<xref:System.Data.Linq.Mapping.AutoSync.OnInsert>), or [AutoSync.OnUpdate](<xref:System.Data.Linq.Mapping.AutoSync.OnUpdate>).

## Test the application

Run the application again to verify that the **UpdateCustomers** stored procedure correctly updates the customer record in the database.

1. Press **F5**.

2. Modify a record in the grid to test the update behavior.

3. Add a new record to test the insert behavior.

4. Click the save button to save changes back to the database.

5. Close the form.

6. Press **F5** and verify that the updated record and the newly inserted record persisted.

7. Delete the new record you created in step 3 to test the delete behavior.

8. Click the save button to submit the changes and remove the deleted record from the database.

9. Close the form.

10. Press **F5** and verify that the deleted record was removed from the database.

    > [!NOTE]
    > If your application uses SQL Server Express Edition, depending on the value of the **Copy to Output Directory** property of the database file, the changes might not appear when you press **F5** in step 10.

## Next steps

Depending on your application requirements, there are several steps that you might want to perform after you create LINQ to SQL entity classes. Some enhancements you could make to this application include the following:

- Implement concurrency checking during updates. For information, see [Optimistic Concurrency: overview](/dotnet/framework/data/adonet/sql/linq/optimistic-concurrency-overview).

- Add LINQ queries to filter data. For information, see [Introduction to LINQ queries (C#)](/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries).

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [DataContext methods](../data-tools/datacontext-methods-o-r-designer.md)
- [How to: Assign stored procedures to perform updates, inserts, and deletes](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [LINQ to SQL queries](/dotnet/framework/data/adonet/sql/linq/linq-to-sql-queries)
