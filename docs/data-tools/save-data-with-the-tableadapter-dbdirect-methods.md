---
title: Save data with the ADO.NET TableAdapter DBDirect methods (.NET Framework)
description: In this tutorial, run SQL statements directly against a database by using the DBDirect methods of a ADO.NET TableAdapter in a .NET Framework application.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- TableAdapters, tutorials
- data [Visual Studio], saving
- saving data, tutorials
- data [Visual Studio], TableAdapter
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Save data with the TableAdapter DBDirect methods in .NET Framework applications

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This tutorial provides detailed instructions for running SQL statements directly against a database by using the DBDirect methods of a TableAdapter. The DBDirect methods of a TableAdapter provide a fine level of control over your database updates. You can use them to run specific SQL statements and stored procedures by calling the individual `Insert`, `Update`, and `Delete` methods as needed by your application (as opposed to the overloaded `Update` method that performs the `UPDATE`, `INSERT`, and `DELETE` statements all in one call).

During this tutorial, you will learn how to:

- Create and configure a dataset with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).

- Select the control to be created on the form when dragging items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Create a data-bound form by dragging items from the **Data Sources** window onto the form.

- Add methods to directly access the database and perform inserts, updates, and deletes.

## Prerequisites

The steps in this tutorial work with .NET Framework Windows Forms Applications.

This tutorial uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create a Windows Forms application

The first step is to create a **Windows Forms App (.NET Framework)**. Create a project using the **Windows Forms App** project type, using C# or Visual Basic.

> [!NOTE]
> The code for this tutorial is available in C# and Visual Basic. To switch the code language on this page between C# and Visual Basic, use the code language switcher at the top of the page on the right side.

## Create a data source from your database

This step uses the **Data Source Configuration Wizard** to create a data source based on the `Region` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection. For information about setting up the Northwind sample database, see [How to: Install sample databases](../data-tools/installing-database-systems-tools-and-samples.md).

### To create the data source

1. On the **Data** menu, select **Show Data Sources**.

   The **Data Sources** window opens.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.

3. On the **Choose a Data Source Type** screen, select **Database**, and then select **Next**.

4. On the **Choose your Data Connection** screen, do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

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

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb" id="Snippet1":::
     ---

     > [!NOTE]
     > Depending on your Visual Studio version and the project templates you used, the variable names like `regionTableAdapter` or `regionTableAdapter1` used in this code might or might not have a trailing 1 in the generated code. Make any corrections in your code to ensure that the correct name is used everywhere. Visual Studio shows a red squiggle where the name is incorrect.

### To add code to update records in the database

1. Double-click the **UpdateButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `UpdateButton_Click` event handler with the following code:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs" id="Snippet2":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb" id="Snippet2":::
     ---

### To add code to delete records from the database

1. Select **DeleteButton** to create an event handler for the click event and open your form in the code editor.

2. Replace the `DeleteButton_Click` event handler with the following code:

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form1.cs" id="Snippet3":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form1.vb" id="Snippet3":::
     ---

## Run the application

- Select **F5** to run the application.

- Select the **Insert** button, and verify that the new record appears in the grid.

- Select the **Update** button, and verify that the record is updated in the grid.

- Select the **Delete** button, and verify that the record is removed from the grid.

## Next steps

Depending on your application requirements, there are several steps you might want to perform after creating a data-bound form. Some enhancements you could make to this tutorial include:

- Adding search functionality to the form.

- Adding additional tables to the dataset by selecting **Configure DataSet with Wizard** from within the **Data Sources** window. You can add controls that display related data by dragging the related nodes onto the form. For more information, see [Relationships in Datasets](relationships-in-datasets.md).

## Related content

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
