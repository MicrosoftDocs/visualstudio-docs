---
title: 'Walkthrough: Save data in a transaction'
description: In this walkthrough, see how to save data in a transaction by using the System.Transactions namespace in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 09/08/2017
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- System.Transactions namespace
- data [Visual Studio], saving in a transaction
- transactions, saving data
- Transactions namespace
- saving data
ms.assetid: 80260118-08bc-4b37-bfe5-9422ee7a1e4e
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Walkthrough: Save data in a transaction

This walkthrough demonstrates how to save data in a transaction by using the <xref:System.Transactions> namespace. In this walkthrough, you'll create a Windows Forms application. You'll use the Data Source Configuration Wizard to create a dataset for two tables in the Northwind sample database. You'll add data bound controls to a Windows form, and you'll modify the code for the BindingNavigator's save button to update the database inside a TransactionScope.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the Visual Studio Installer, SQL Server Express LocalDB can be installed as part of the **.NET desktop development** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a Windows Forms application

The first step is to create a **Windows Forms Application**.

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **SavingDataInATransactionWalkthrough**, and then choose **OK**.

     The **SavingDataInATransactionWalkthrough** project is created and added to **Solution Explorer**.

## Create a database data source

This step uses the **Data Source Configuration Wizard** to create a data source based on the `Customers` and `Orders` tables in the Northwind sample database.

1. To open the **Data Sources** window, on the **Data** menu, select **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type** screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** screen do one of the following:

    - If a data connection to the Northwind sample database is available in the drop-down list, select it.

         -or-

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box and create a connection to the Northwind database.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file** screen, select **Next**.

7. On the **Choose your Database Objects** screen, expand the **Tables** node.

8. Select the `Customers` and `Orders` tables, and then select **Finish**.

     The **NorthwindDataSet** is added to your project and the `Customers` and `Orders` tables appear in the **Data Sources** window.

## Add controls to the form

You can create the data-bound controls by dragging items from the **Data Sources** window onto your form.

1. In the **Data Sources** window, expand the **Customers** node.

2. Drag the main **Customers** node from the **Data Sources** window onto **Form1**.

   A <xref:System.Windows.Forms.DataGridView> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), `CustomersTableAdapter`, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

3. Drag the related **Orders** node (not the main **Orders** node, but the related child-table node below the **Fax** column) onto the form below the **CustomersDataGridView**.

   A <xref:System.Windows.Forms.DataGridView> appears on the form. An `OrdersTableAdapter` and <xref:System.Windows.Forms.BindingSource> appear in the component tray.

## Add a reference to the System.Transactions assembly

Transactions use the <xref:System.Transactions> namespace. A project reference to the system.transactions assembly is not added by default, so you need to manually add it.

### To add a reference to the System.Transactions DLL file

1. On the **Project** menu, select **Add Reference**.

2. Select **System.Transactions** (on the **.NET** tab), and then select **OK**.

     A reference to **System.Transactions** is added to the project.

## Modify the code in the BindingNavigator's SaveItem button

For the first table dropped onto your form, code is added by default to the `click` event of the save button on the <xref:System.Windows.Forms.BindingNavigator>. You need to manually add code to update any additional tables. For this walkthrough, we refactor the existing save code out of the save button's click event handler. We also create a few more methods to provide specific update functionality based on whether the row needs to be added or deleted.

### To modify the auto-generated save code

1. Select the **Save** button on the **CustomersBindingNavigator** (the button with the floppy disk icon).

2. Replace the `CustomersBindingNavigatorSaveItem_Click` method with the following code:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet4":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet4":::

The order for reconciling changes to related data is as follows:

- Delete child records. (In this case, delete records from the `Orders` table.)

- Delete parent records. (In this case, delete records from the `Customers` table.)

- Insert parent records. (In this case, insert records in the `Customers` table.)

- Insert child records. (In this case, insert records in the `Orders` table.)

### To delete existing orders

- Add the following `DeleteOrders` method to **Form1**:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet5":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet5":::

### To delete existing customers

- Add the following `DeleteCustomers` method to **Form1**:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet6":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet6":::

### To add new customers

- Add the following `AddNewCustomers` method to **Form1**:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet7":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet7":::

### To add new orders

- Add the following `AddNewOrders` method to **Form1**:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet8":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet8":::

## Run the application

Press **F5** to run the application.

## See also

- [How to: save data by using a transaction](../data-tools/save-data-by-using-a-transaction.md)
- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
