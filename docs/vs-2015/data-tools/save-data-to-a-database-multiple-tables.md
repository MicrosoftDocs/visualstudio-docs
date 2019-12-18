---
title: "Save data to a database (multiple tables) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "updating datasets, walkthroughs"
  - "data [Visual Studio], saving"
  - "saving data, walkthroughs"
  - "data [Visual Studio], updating"
ms.assetid: 7ebe03da-ce8c-4cbc-bac0-a2fde4ae4d07
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Save data to a database (multiple tables)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

One of the most common scenarios in application development is to display data on a form in a Windows application, edit the data, and send the updated data back to the database. This walkthrough creates a form that displays data from two related tables and shows how to edit records and save changes back to the database. This example uses the `Customers` and `Orders` tables from the Northwind sample database.

 You can save data in your application back to the database by calling the `Update` method of a TableAdapter. When you drag tables from the **Data Sources** window onto a form, the code that's required to save data is automatically added.Any additional tables that are added to a form require the manual addition of this code. This walkthrough shows how to add code to save updates from more than one table.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or the edition that you're using. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).

 Tasks illustrated in this walkthrough include:

- Creating a new **Windows Application** project.

- Creating and configuring a data source in your application with the [Data Source Configuration Wizard](https://msdn.microsoft.com/library/c4df7de5-5da0-4064-940c-761dd6d9e28f).

- Setting the controls of the items in the [Data Sources Window](https://msdn.microsoft.com/library/0d20f699-cc95-45b3-8ecb-c7edf1f67992). For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Creating data-bound controls by dragging items from the **Data Sources** window onto your form.

- Modifying a few records in each table in the dataset.

- Modifying the code to send the updated data in the dataset back to the database.

## Prerequisites
 In order to complete this walkthrough, you will need:

- Access to the Northwind sample database.

## Create the Windows application
 The first step is to create a **Windows Application**. Assigning a name to the project is optional during this step, but we'll give it a name because we're planning on saving it later.

#### To create the new Windows application project

1. On the **File** menu, create a new project.

2. Name the project `UpdateMultipleTablesWalkthrough`.

3. Select **Windows Application**, and then select **OK**. For more information, see [Client Applications](https://msdn.microsoft.com/library/2dfb50b7-5af2-4e12-9bbb-c5ade0e39a68).

     The **UpdateMultipleTablesWalkthrough** project is created and added to **Solution Explorer**.

## Create the data source
 This step creates a data source from the Northwind database using the **Data Source Configuration Wizard**. You must have access to the Northwind sample database to create the connection.

#### To create the data source

1. On the **Data** menu, select**Show Data Sources**.

2. In the **Data Sources** window, select**Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type**screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection**screen do one of the following:

    - If a data connection to the Northwind sample database is available in the drop-down list, select it.

         -or-

    - Select **New Connection** to open the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file**, select **Next**.

7. On the **Choose your Database Objects**screen, expand the **Tables** node .

8. Select the **Customers** and **Orders** tables, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the tables appear in the **Data Sources** window.

## Set the controls to be created
 For this walkthrough, the data in the `Customers` table is in a **Details** layout where data is displayed in individual controls. The data from the `Orders` table is in a **Grid** layout that's displayed in a <xref:System.Windows.Forms.DataGridView> control.

#### To set the drop type for the items in the Data Sources window

1. In the **Data Sources** window, expand the **Customers** node.

2. On the **Customers** node, select **Details** from the control list to change the control of the **Customers** table to individual controls. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

## Create the data-bound form
 You can create the data-bound controls by dragging items from the **Data Sources** window onto your form.

#### To create data-bound controls on the form

1. Drag the main **Customers** node from the **Data Sources** window onto **Form1**.

     Data-bound controls with descriptive labels appear on the form, along with a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

2. Drag the related **Orders** node from the **Data Sources** window onto **Form1**.

    > [!NOTE]
    > The related **Orders** node is located below the **Fax** column and is a child node of the **Customers** node.

     A <xref:System.Windows.Forms.DataGridView> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. An OrdersTableAdapter and <xref:System.Windows.Forms.BindingSource> appear in the component tray.

## Addcode to update the database
 You can update the database by calling the `Update` methods of the **Customers** and **Orders** TableAdapters. By default, an event handler for the **Save** button of the<xref:System.Windows.Forms.BindingNavigator> is added to the form's code to send updates to the database. This procedure modifies the code to send updates in the correct order.This eliminates the possibility of raising referential integrity errors. The code also implements error handling by wrapping the update call in a try-catch block. You can modify the code to suit the needs of your application.

> [!NOTE]
> For clarity, this walkthrough does not use a transaction.However, if you're updating two or more related tables, include all the update logic within a transaction. A transaction is a process that assures that all related changes to a database are successful before any changes are committed. For more information, see [Transactions and Concurrency](https://msdn.microsoft.com/library/f46570de-9e50-4fe6-8710-a8c31fa8569b).

#### To add update logic to the application

1. Select the **Save** button on the <xref:System.Windows.Forms.BindingNavigator>.This opens the Code Editor to the `bindingNavigatorSaveItem_Click` event handler.

2. Replace the code in the event handler to call the `Update` methods of the related TableAdapters. The following code first creates three temporary data tables to hold the updated information for each <xref:System.Data.DataRowState> (<xref:System.Data.DataRowState>, <xref:System.Data.DataRowState>, and <xref:System.Data.DataRowState>). Then updates are run in the correct order. The code should look like the following:

     [!code-csharp[VbRaddataSaving#10](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form4.cs#10)]
     [!code-vb[VbRaddataSaving#10](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form4.vb#10)]

## Test the application

#### To test the application

1. Select **F5**.

2. Make some changes to the data of one or more records in each table.

3. Select the **Save** button.

4. Check the values in the database to verify that the changes were saved.

## Next Steps
 Depending on your application requirements, there are several steps you might want to perform after creating a data-bound form in your Windows application. Some enhancements you could make to this walkthrough include:

- Adding search functionality to the form. For more information, see [How to: Add a Parameterized Query to a Windows Forms Application](https://msdn.microsoft.com/library/13db4ad3-56b9-4a0b-b3a5-6a4ff84d4416).

- Editing the data source to add or remove database objects. For more information, see [How to: Edit a Dataset](https://msdn.microsoft.com/library/f2dade5f-9c7a-4ddb-96a8-e0a39e50bfd3).

## See Also
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
