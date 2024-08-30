---
title: Save data to a database (multiple tables) in .NET Framework applications
description: In this walkthrough, save data from multiple tables to a database using ADO.NET DataSet tools in .NET Framework application development in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- updating datasets, walkthroughs
- data [Visual Studio], saving
- saving data, walkthroughs
- data [Visual Studio], updating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Save data to a database (multiple tables) in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

One of the most common scenarios in application development is to display data on a form in a Windows application, edit the data, and send the updated data back to the database. This walkthrough creates a form that displays data from two related tables and shows how to edit records and save changes back to the database. This example uses the `Customers` and `Orders` tables from the Northwind sample database.

You can save data in your application back to the database by calling the `Update` method of a TableAdapter. When you drag tables from the **Data Sources** window onto a form, the code that's required to save data is automatically added. Any additional tables that are added to a form require the manual addition of this code. This walkthrough shows how to add code to save updates from more than one table.

Tasks illustrated in this walkthrough include:

- Creating and configuring a data source in your application with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).

- Setting the controls of the items in the [Data Sources window](add-new-data-sources.md#work-with-data-sources-and-windows-forms). For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Creating data-bound controls by dragging items from the **Data Sources** window onto your form.

- Modifying a few records in each table in the dataset.

- Modifying the code to send the updated data in the dataset back to the database.

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create the Windows Forms application

Create a new **Windows Forms App** project for either C# or Visual Basic. Name the project **UpdateMultipleTablesWalkthrough**.

## Create the data source

This step creates a data source from the Northwind database using the **Data Source Configuration Wizard**. You must have access to the Northwind sample database to create the connection. For information about setting up the Northwind sample database, see [How to: Install sample databases](../data-tools/installing-database-systems-tools-and-samples.md).

1. On the **Data** menu, select **Show Data Sources**.

   The **Data Sources** window opens.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type** screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** screen, do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

      -or-

    - Select **New Connection** to open the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file**, select **Next**.

7. On the **Choose your Database Objects** screen, expand the **Tables** node.

8. Select the **Customers** and **Orders** tables, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the tables appear in the **Data Sources** window.

## Set the controls to be created

For this walkthrough, the data in the `Customers` table is in a **Details** layout where data is displayed in individual controls. The data from the `Orders` table is in a **Grid** layout that's displayed in a <xref:System.Windows.Forms.DataGridView> control.

### To set the drop type for the items in the Data Sources window

1. In the **Data Sources** window, expand the **Customers** node.

2. On the **Customers** node, select **Details** from the control list to change the control of the **Customers** table to individual controls. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

## Create the data-bound form

You can create the data-bound controls by dragging items from the **Data Sources** window onto your form.

1. Drag the main **Customers** node from the **Data Sources** window onto **Form1**.

     Data-bound controls with descriptive labels appear on the form, along with a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), `CustomersTableAdapter`, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

2. Drag the related **Orders** node from the **Data Sources** window onto **Form1**.

    > [!NOTE]
    > The related **Orders** node is located below the **Fax** column and is a child node of the **Customers** node.

     A <xref:System.Windows.Forms.DataGridView> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. An `OrdersTableAdapter` and <xref:System.Windows.Forms.BindingSource> appear in the component tray.

## Add code to update the database

You can update the database by calling the `Update` methods of the **Customers** and **Orders** TableAdapters. By default, an event handler for the **Save** button of the<xref:System.Windows.Forms.BindingNavigator> is added to the form's code to send updates to the database. This procedure modifies the code to send updates in the correct order.This eliminates the possibility of raising referential integrity errors. The code also implements error handling by wrapping the update call in a try-catch block. You can modify the code to suit the needs of your application.

> [!NOTE]
> For clarity, this walkthrough does not use a transaction. However, if you're updating two or more related tables, include all the update logic within a transaction. A transaction is a process that assures that all related changes to a database are successful before any changes are committed. For more information, see [Transactions and Concurrency](/dotnet/framework/data/adonet/transactions-and-concurrency).

### To add update logic to the application

1. Select the **Save** button on the <xref:System.Windows.Forms.BindingNavigator>. This opens the Code Editor to the `bindingNavigatorSaveItem_Click` event handler.

2. Replace the code in the event handler to call the `Update` methods of the related TableAdapters. The following code first creates three temporary data tables to hold the updated information for each <xref:System.Data.DataRowState> (<xref:System.Data.DataRowState.Deleted>, <xref:System.Data.DataRowState.Added>, and <xref:System.Data.DataRowState.Modified>). The updates are run in the correct order. The code should look like the following:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form4.cs" id="Snippet10":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form4.vb" id="Snippet10":::
     ---

## Test the application

1. Press **F5**.

2. Make some changes to the data of one or more records in each table.

3. Select the **Save** button.

4. Check the values in the database to verify that the changes were saved.

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
