---
title: "Walkthrough: Customizing the insert, update, and delete behavior of entity classes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
ms.assetid: 03ff1146-706e-4780-91cb-56a83df63eea
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Customizing the insert, update, and delete behavior of entity classes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md) provides a visual design surface for creating and editing [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] classes (entity classes) that are based on objects in a database. By using [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655), you can use LINQ technology to access SQL databases. For more information, see [LINQ (Language-Integrated Query)](https://msdn.microsoft.com/library/a73c4aec-5d15-4e98-b962-1274021ea93d).

 By default, the logic to perform updates is provided by the [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] runtime. The runtime creates default Insert, Update, and Delete statements based on the schema of the table (the column definitions and primary key information). When you do not want to use the default behavior, you can configure the update behavior and designate specific stored procedures for performing the necessary Inserts, Updates, and Deletes required to work with the data in the database. You can also do this when the default behavior is not generated, for example, when your entity classes map to views. Additionally, you can override the default update behavior when the database requires table access through stored procedures. For more information, see [Customizing Operations By Using Stored Procedures](https://msdn.microsoft.com/library/aedbecc1-c33c-4fb4-8861-fdf7e1dc6b8a).

> [!NOTE]
> This walkthrough requires the availability of the **InsertCustomer**, **UpdateCustomer**, and **DeleteCustomer** stored procedures for the Northwind database.

 This walkthrough provides the steps that you must follow to override the default LINQ to SQL runtime behavior for saving data back to a database by using stored procedures.

 During this walkthrough, you will learn how to perform the following tasks:

- Create a new Windows Forms application and add a [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] file to it.

- Create an entity class that is mapped to the Northwind Customers table.

- Create an object data source that references the LINQ to SQL Customer class.

- Create a Windows Form that contains a <xref:System.Windows.Forms.DataGridView> that is bound to the Customer class.

- Implement save functionality for the form.

- Create <xref:System.Data.Linq.DataContext> methods by adding stored procedures to the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

- Configure the Customer class to use stored procedures to perform Inserts, Updates, and Deletes.

## Prerequisites
 To complete this walkthrough, you need the following:

- Access to the SQL Server version of the Northwind sample database.

- The **InsertCustomer**, **UpdateCustomer**, and **DeleteCustomer** stored procedures for the Northwind database.

## Creating an Application and Adding LINQ to SQL Classes
 Because you will be working with [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] classes and displaying the data on a Windows Form, create a new Windows Forms application and add a LINQ to SQL Classes file.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To create a new Windows Application project that contains LINQ to SQL classes

1. From the **File** menu, create a new project.

2. Name the project **UpdatingwithSProcsWalkthrough**.

    > [!NOTE]
    > The [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] is supported in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] and C# projects. Therefore, create the new project in one of these languages.

3. Click the **Windows Forms Application** template and click **OK**. For more information, see [Client Applications](https://msdn.microsoft.com/library/2dfb50b7-5af2-4e12-9bbb-c5ade0e39a68).

     The UpdatingwithSProcsWalkthrough project is created and added to **Solution Explorer**.

4. On the **Project** menu, click **Add New Item**.

5. Click the **LINQ to SQL Classes** template and type **Northwind.dbml** in the **Name** box.

6. Click **Add**.

     An empty LINQ to SQL Classes file (Northwind.dbml) is added to the project, and the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] opens.

## Creating the Customer Entity Class and Object Data Source
 Create [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] classes that are mapped to database tables by dragging tables from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]. The result is LINQ to SQL entity classes that map to the tables in the database. After you create entity classes, they can be used as object data sources just like other classes that have public properties.

#### To create a Customer entity class and configure a data source with it

1. In **Server Explorer**/**Database Explorer**, locate the Customer table in the SQL Server version of the Northwind sample database.

2. Drag the **Customers** node from **Server Explorer**/**Database Explorer** onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)] surface.

     An entity class named **Customer** is created. It has properties that correspond to the columns in the Customers table. The entity class is named **Customer** (not **Customers**) because it represents a single customer from the Customers table.

    > [!NOTE]
    > This renaming behavior is called *pluralization*. It can be turned on or off in the [Options Dialog Box](../ide/reference/options-dialog-box-visual-studio.md). For more information, see [How to: Turn pluralization on and off (O/R Designer)](../data-tools/how-to-turn-pluralization-on-and-off-o-r-designer.md).

3. On the **Build** menu, click **Build UpdatingwithSProcsWalkthrough** to build the project.

4. On the **Data** menu, click **Show Data Sources**.

5. In the **Data Sources** window, click **Add New Data Source**.

6. Click **Object** on the **Choose a Data Source Type** page and then click **Next**.

7. Expand the **UpdatingwithSProcsWalkthrough** node and locate and select the **Customer** class.

    > [!NOTE]
    > If the **Customer** class is not available, cancel out of the wizard, build the project, and run the wizard again.

8. Click **Finish** to create the data source and add the **Customer** entity class to the **Data Sources** window.

## Creating a DataGridView to Display the Customer Data on a Windows Form
 Create controls that are bound to entity classes by dragging [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] data source items from the **Data Sources** window onto a Windows Form.

#### To add controls that are bound to the entity classes

1. Open Form1 in Design view.

2. From the **Data Sources** window, drag the **Customer** node onto Form1.

    > [!NOTE]
    > To display the **Data Sources** window, click **Show Data Sources** on the **Data** menu.

3. Open Form1 in the Code Editor.

4. Add the following code to the form, global to the form, outside any specific method, but inside the Form1 class:

    ```vb
    Private NorthwindDataContext1 As New NorthwindDataContext
    ```

    ```csharp
    private NorthwindDataContext northwindDataContext1
        = new NorthwindDataContext();

    ```

5. Create an event handler for the `Form_Load` event and add the following code to the handler:

    ```vb
    CustomerBindingSource.DataSource = NorthwindDataContext1.Customers
    ```

    ```csharp
    customerBindingSource.DataSource
        = northwindDataContext1.Customers;

    ```

## Implementing Save Functionality
 By default, the save button is not enabled and save functionality is not implemented. Also, code is not automatically added to save changed data to the database when data-bound controls are created for object data sources. This section explains how to enable the save button and implement save functionality for [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] objects.

#### To implement save functionality

1. Open Form1 in Design view.

2. Select the save button on the **CustomerBindingNavigator** (the button with the floppy disk icon).

3. In the **Properties** window, set the **Enabled** property to **True**.

4. Double-click the save button to create an event handler and switch to the Code Editor.

5. Add the following code into the save button event handler:

    ```vb
    NorthwindDataContext1.SubmitChanges()
    ```

    ```csharp
    northwindDataContext1.SubmitChanges();
    ```

## Overriding the Default Behavior for Performing Updates (Inserts, Updates, and Deletes)

#### To override the default update behavior

1. Open the LINQ to SQL file in the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)]. (Double-click the **Northwind.dbml** file in **Solution Explorer**.)

2. In **Server Explorer**/**Database Explorer**, expand the Northwind databases **Stored Procedures** node and locate the **InsertCustomers**, **UpdateCustomers**, and **DeleteCustomers** stored procedures.

3. Drag all three stored procedures onto the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

     The stored procedures are added to the methods pane as <xref:System.Data.Linq.DataContext> methods. For more information, see [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md).

4. Select the **Customer** entity class in the [!INCLUDE[vs_ordesigner_short](../includes/vs-ordesigner-short-md.md)].

5. In the **Properties** window, select the **Insert** property.

6. Click the ellipsis (...) next to **Use Runtime** to open the **Configure Behavior** dialog box.

7. Select **Customize**.

8. Select the **InsertCustomers** method in the **Customize** list.

9. Click **Apply** to save the configuration for the selected Class and Behavior.

    > [!NOTE]
    > You can continue to configure the behavior for each class/behavior combination as long as you click **Apply** after you make each change. If you change the class or behavior before you click **Apply**, a warning dialog box providing an opportunity to apply any changes will appear.

10. Select **Update** in the **Behavior** list.

11. Select **Customize**.

12. Select the **UpdateCustomers** method in the **Customize** list.

     Inspect the list of **Method Arguments** and **Class Properties** and notice that there are two **Method Arguments** and two **Class Properties** for some columns in the table. This makes it easier to track changes and create statements that check for concurrency violations.

13. Map the **Original_CustomerID** method argument to the **CustomerID (Original)** class property.

    > [!NOTE]
    > By default, method arguments will map to class properties when the names match. If property names are changed and no longer match between the table and the entity class, you might have to select the equivalent class property to map to if the O/R Designer cannot determine the correct mapping. Additionally, if method arguments do not have valid class properties to map to, you can set the **Class Properties** value to **(None)**.

14. Click **Apply** to save the configuration for the selected Class and Behavior.

15. Select **Delete** in the **Behavior** list.

16. Select **Customize**.

17. Select the **DeleteCustomers** method in the **Customize** list.

18. Map the **Original_CustomerID** method argument to the **CustomerID (Original)** class property.

19. Click **OK**.

> [!NOTE]
> Although it is not an issue for this particular walkthrough, it is worth noting that [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] handles database-generated values automatically for identity (auto-increment), rowguidcol (database-generated GUID), and timestamp columns during Inserts and Updates. Database-generated values in other column types will unexpectedly result in a null value. To return the database-generated values, you should manually set <xref:System.Data.Linq.Mapping.ColumnAttribute.IsDbGenerated%2A> to `true` and <xref:System.Data.Linq.Mapping.ColumnAttribute.AutoSync%2A> to one of the following: <xref:System.Data.Linq.Mapping.AutoSync>, <xref:System.Data.Linq.Mapping.AutoSync>, or <xref:System.Data.Linq.Mapping.AutoSync>.

## Testing the Application
 Run the application again to verify that the **UpdateCustomers** stored procedure correctly updates the customer record in the database.

#### To test the application

1. Press F5.

2. Modify a record in the grid to test the Update behavior.

3. Add a new record to test the Insert behavior.

4. Click the save button to save changes back to the database.

5. Close the form.

6. Press F5 and verify that the updated record and the newly inserted record persisted.

7. Delete the new record you created in step 3 to test the Delete behavior.

8. Click the save button to submit the changes and remove the deleted record from the database

9. Close the form.

10. Press F5 and verify that the deleted record was removed from the database.

    > [!NOTE]
    > If your application uses SQL Server Express Edition, depending on the value of the **Copy to Output Directory** property of the database file, the changes may not appear when you press F5 in step 10.

## Next Steps
 Depending on your application requirements, there are several steps that you may want to perform after you create [!INCLUDE[vbtecdlinq](../includes/vbtecdlinq-md.md)] entity classes. Some enhancements you could make to this application include the following:

- Implement concurrency checking during updates. For information, see [Optimistic Concurrency: Overview](https://msdn.microsoft.com/library/c2e38512-d0c8-4807-b30a-cb7e30338694).

- Add LINQ queries to filter data. For information, see [Introduction to LINQ Queries (C#)](https://msdn.microsoft.com/library/37895c02-268c-41d5-be39-f7d936fa88a8).

## See Also
 [LINQ to SQL Tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
 [LINQ to SQL](https://msdn.microsoft.com/library/73d13345-eece-471a-af40-4cc7a2f11655)
 [LINQ to SQL Queries](https://msdn.microsoft.com/library/f4897aaa-7f44-4c20-a471-b948c2971aae)
 [DataContext Methods (O/R Designer)](../data-tools/datacontext-methods-o-r-designer.md)
 [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md)
 [PAVE What's New for Data Application Development in Visual Studio 2012](https://msdn.microsoft.com/3d50d68f-5f44-4915-842f-6d42fce793f1)
