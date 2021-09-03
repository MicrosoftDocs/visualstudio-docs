---
title: Handle a concurrency exception
description: Handle a concurrency exception (System.Data.DBConcurrencyException), which is raised when two users try to change the same data in a database at the same time.
ms.custom: SEO-VS-2020
ms.date: 09/11/2017
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- concurrency control, exceptions
- datasets [Visual Basic], errors
- exception handling, concurrency issues
- data concurrency, walkthroughs
- updating datasets, errors
- concurrency control, walkthroughs
ms.assetid: 73ee9759-0a90-48a9-bf7b-9d6fc17bff93
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Handle a concurrency exception

Concurrency exceptions (<xref:System.Data.DBConcurrencyException?displayProperty=fullName>) are raised when two users attempt to change the same data in a database at the same time. In this walkthrough, you create a Windows application that illustrates how to catch a <xref:System.Data.DBConcurrencyException>, locate the row that caused the error, and learn a strategy for how to handle it.

This walkthrough takes you through the following process:

1. Create a new **Windows Forms Application** project.

2. Create a new dataset based on the Northwind Customers table.

3. Create a form with a <xref:System.Windows.Forms.DataGridView> to display the data.

4. Fill a dataset with data from the Customers table in the Northwind database.

5. Use the **Show Table Data** feature in **Server Explorer** to access the Customers-table's data and change a record.

6. Change the same record to a different value, update the dataset, and attempt to write the changes to the database, which results in a concurrency error being raised.

7. Catch the error, then display the different versions of the record, allowing the user to determine whether to continue and update the database, or cancel the update.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a new project

Begin by creating a new Windows Forms application:

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **ConcurrencyWalkthrough**, and then choose **OK**.

     The **ConcurrencyWalkthrough** project is created and added to **Solution Explorer**, and a new form opens in the designer.

## Create the Northwind dataset

Next, create a dataset named **NorthwindDataSet**:

1. On the **Data** menu, choose **Add New Data source**.

   The Data Source Configuration Wizard opens.

2. On the **Choose a Data Source Type** screen, select **Database**.

   ![Data Source Configuration Wizard in Visual Studio](media/data-source-configuration-wizard.png)

3. Select a connection to the Northwind sample database from the list of available connections. If the connection is not available in the list of connections, select **New Connection**.

    > [!NOTE]
    > If you're connecting to a local database file, select **No** when asked if you would you like to add the file to your project.

4. On the **Save connection string to the application configuration file** screen, select **Next**.

5. Expand the **Tables** node and select the **Customers** table. The default name for the dataset should be **NorthwindDataSet**.

6. Select **Finish** to add the dataset to the project.

## Create a data-bound DataGridView control

In this section, you create a <xref:System.Windows.Forms.DataGridView?displayProperty=nameWithType> by dragging the **Customers** item from the **Data Sources** window onto your Windows Form.

1. To open the **Data Sources** window, on the **Data** menu, choose **Show Data Sources**.

2. In the **Data Sources** window, expand the **NorthwindDataSet** node, and then select the **Customers** table.

3. Select the down arrow on the table node, and then select **DataGridView** in the drop-down list.

4. Drag the table onto an empty area of your form.

     A <xref:System.Windows.Forms.DataGridView> control named **CustomersDataGridView**, and a <xref:System.Windows.Forms.BindingNavigator> named **CustomersBindingNavigator**, are added to the form that's bound to the <xref:System.Windows.Forms.BindingSource>. This is, in turn, bound to the Customers table in the NorthwindDataSet.

## Test the form

You can now test the form to make sure it behaves as expected up to this point:

1. Select **F5** to run the application.

     The form appears with a <xref:System.Windows.Forms.DataGridView> control on it that's filled with data from the Customers table.

2. On the **Debug** menu, select **Stop Debugging**.

## Handle concurrency errors

How you handle errors depends on the specific business rules that govern your application. For this walkthrough, we use the following strategy as an example for how to handle the concurrency error.

The application presents the user with three versions of the record:

- The current record in the database

- The original record that's loaded into the dataset

- The proposed changes in the dataset

The user is then able to either overwrite the database with the proposed version, or cancel the update and refresh the dataset with the new values from the database.

### To enable the handling of concurrency errors

1. Create a custom error handler.

2. Display choices to the user.

3. Process the user's response.

4. Resend the update, or reset the data in the dataset.

### Add code to handle the concurrency exception

When you attempt to perform an update and an exception is raised, you generally want to do something with the information that's provided by the raised exception. In this section, you add code that attempts to update the database. You also handle any <xref:System.Data.DBConcurrencyException> that might be raised, as well as any other exceptions.

> [!NOTE]
> The `CreateMessage` and `ProcessDialogResults` methods are added later in the walkthrough.

1. Add the following code below the `Form1_Load` method:

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs" id="Snippet1":::
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb" id="Snippet1":::

2. Replace the `CustomersBindingNavigatorSaveItem_Click` method to call the `UpdateDatabase` method so it looks like the following:

   :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs" id="Snippet2":::
   :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb" id="Snippet2":::

### Display choices to the user

The code you just wrote calls the `CreateMessage` procedure to display error information to the user. For this walkthrough, you use a message box to display the different versions of the record to the user. This enables the user to choose whether to overwrite the record with the changes or cancel the edit. Once the user selects an option (clicks a button) on the message box, the response is passed to the `ProcessDialogResult` method.

Create the message by adding the following code to the **Code Editor**. Enter this code below the `UpdateDatabase` method:

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs" id="Snippet4":::
:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb" id="Snippet4":::

### Process the user's response

You also need code to process the user's response to the message box. The options are either to overwrite the current record in the database with the proposed change, or abandon the local changes and refresh the data table with the record that's currently in the database. If the user chooses **Yes**, the <xref:System.Data.DataTable.Merge%2A> method is called with the *preserveChanges* argument set to **true**. This causes the update attempt to be successful, because the original version of the record now matches the record in the database.

Add the following code below the code that was added in the previous section:

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataConcurrency/CS/Form1.cs" id="Snippet3":::
:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataConcurrency/VB/Form1.vb" id="Snippet3":::

## Test the form behavior

You can now test the form to make sure it behaves as expected. To simulate a concurrency violation, you change data in the database after filling the NorthwindDataSet.

1. Select **F5** to run the application.

2. After the form appears, leave it running and switch to the Visual Studio IDE.

3. On the **View** menu, choose **Server Explorer**.

4. In **Server Explorer**, expand the connection your application is using, and then expand the **Tables** node.

5. Right-click the **Customers** table, and then select **Show Table Data**.

6. In the first record (**ALFKI**), change **ContactName** to **Maria Anders2**.

    > [!NOTE]
    > Navigate to a different row to commit the change.

7. Switch to the ConcurrencyWalkthrough's running form.

8. In the first record on the form (**ALFKI**), change **ContactName** to **Maria Anders1**.

9. Select the **Save** button.

     The concurrency error is raised, and the message box appears.

   Selecting **No** cancels the update and updates the dataset with the values that are currently in the database. Selecting **Yes** writes the proposed value to the database.

## See also

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
