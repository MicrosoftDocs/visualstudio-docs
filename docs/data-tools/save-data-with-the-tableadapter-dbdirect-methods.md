---
title: Save data with the TableAdapter DBDirect methods
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "TableAdapters, walkthroughs"
  - "data [Visual Studio], saving"
  - "saving data, walkthroughs"
  - "data [Visual Studio], TableAdapter"
ms.assetid: 74a6773b-37e1-4d96-a39c-63ee0abf49b1
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Save data with the TableAdapter DBDirect methods

This walkthrough provides detailed instructions for running SQL statements directly against a database by using the DBDirect methods of a TableAdapter. The DBDirect methods of a TableAdapter provide a fine level of control over your database updates. You can use them to run specific SQL statements and stored procedures by calling the individual `Insert`, `Update`, and `Delete` methods as needed by your application (as opposed to the overloaded `Update` method that performs the UPDATE, INSERT, and DELETE statements all in one call).

During this walkthrough, you will learn how to:

- Create a new **Windows Forms Application**.

- Create and configure a dataset with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).

- Select the control to be created on the form when dragging items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Create a data-bound form by dragging items from the **Data Sources** window onto the form.

- Add methods to directly access the database and perform inserts, updates, and deletes.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

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

4. Name the project **TableAdapterDbDirectMethodsWalkthrough**, and then choose **OK**.

     The **TableAdapterDbDirectMethodsWalkthrough** project is created and added to **Solution Explorer**.

## Create a data source from your database

This step uses the **Data Source Configuration Wizard** to create a data source based on the `Region` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection. For information about setting up the Northwind sample database, see [How to: Install sample databases](../data-tools/installing-database-systems-tools-and-samples.md).

### To create the data source

1. On the **Data** menu, select **Show Data Sources**.

   The **Data Sources** window opens.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type** screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** screen, do one of the following:

    - If a data connection to the Northwind sample database is available in the drop-down list, select it.

         -or-

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

5. If your database requires a password, select the option to include sensitive data, and then select **Next**.

6. On the **Save connection string to the Application Configuration file** screen, select **Next**.

7. On the **Choose your Database Objects** screen, expand the **Tables** node.

8. Select the `Region` table, and then select **Finish**.

     The **NorthwindDataSet** is added to your project and the `Region` table appears in the **Data Sources** window.

## Add controls to the form to display the data

Create the data-bound controls by dragging items from the **Data Sources** window onto your form.

To create data bound controls on the Windows form, drag the main **Region** node from the **Data Sources** window onto the form.

A <xref:System.Windows.Forms.DataGridView> control and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), `RegionTableAdapter`, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

### To add buttons that will call the individual TableAdapter DbDirect methods

1. Drag three <xref:System.Windows.Forms.Button> controls from the **Toolbox** onto **Form1** (below the **RegionDataGridView**).

2. Set the following **Name** and **Text** properties on each button.

    |Name|Text|
    |----------|----------|
    |`InsertButton`|**Insert**|
    |`UpdateButton`|**Update**|
    |`DeleteButton`|**Delete**|

### To add code to insert new records into the database

1. Select **InsertButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `InsertButton_Click` event handler with the following code:

     [!code-vb[VbRaddataSaving#1](../data-tools/codesnippet/VisualBasic/save-data-with-the-tableadapter-dbdirect-methods_1.vb)]
     [!code-csharp[VbRaddataSaving#1](../data-tools/codesnippet/CSharp/save-data-with-the-tableadapter-dbdirect-methods_1.cs)]

### To add code to update records in the database

1. Double-click the **UpdateButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `UpdateButton_Click` event handler with the following code:

     [!code-vb[VbRaddataSaving#2](../data-tools/codesnippet/VisualBasic/save-data-with-the-tableadapter-dbdirect-methods_2.vb)]
     [!code-csharp[VbRaddataSaving#2](../data-tools/codesnippet/CSharp/save-data-with-the-tableadapter-dbdirect-methods_2.cs)]

### To add code to delete records from the database

1. Select **DeleteButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `DeleteButton_Click` event handler with the following code:

     [!code-vb[VbRaddataSaving#3](../data-tools/codesnippet/VisualBasic/save-data-with-the-tableadapter-dbdirect-methods_3.vb)]
     [!code-csharp[VbRaddataSaving#3](../data-tools/codesnippet/CSharp/save-data-with-the-tableadapter-dbdirect-methods_3.cs)]

## Run the application

- Select **F5** to run the application.

- Select the **Insert** button, and verify that the new record appears in the grid.

- Select the **Update** button, and verify that the record is updated in the grid.

- Select the **Delete** button, and verify that the record is removed from the grid.

## Next steps

Depending on your application requirements, there are several steps you might want to perform after creating a data-bound form. Some enhancements you could make to this walkthrough include:

- Adding search functionality to the form.

- Adding additional tables to the dataset by selecting **Configure DataSet with Wizard** from within the **Data Sources** window. You can add controls that display related data by dragging the related nodes onto the form. For more information, see [Relationships in Datasets](relationships-in-datasets.md).

## See also

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)