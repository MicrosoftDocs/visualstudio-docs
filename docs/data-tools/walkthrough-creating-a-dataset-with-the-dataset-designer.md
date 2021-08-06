---
title: Create a Dataset with the Dataset Designer
description: In this walkthrough, create a dataset using the Dataset Designer. Understand the process of creating a new project and adding a new DataSet item to it.
ms.custom: SEO-VS-2020
ms.date: 09/11/2017
ms.topic: conceptual
helpviewer_keywords:
- datasets [Visual Basic], walkthroughs
- XML schemas, creating datasets
- data [Visual Studio], Dataset Designer
- Dataset Designer, walkthroughs
- datasets [Visual Basic], creating
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Walkthrough: Create a Dataset with the Dataset Designer

In this walkthrough you create a dataset using the **Dataset Designer**. The article takes you through the process of creating a new project and adding a new **DataSet** item to it. You'll learn how to create tables based on tables in a database without using a wizard.

## Prerequisites

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the Visual Studio Installer, SQL Server Express LocalDB can be installed as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes executing and the Northwind database is created.

## Create a New Windows Forms Application Project

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **DatasetDesignerWalkthrough**, and then choose **OK**.

     Visual Studio adds the project to **Solution Explorer** and display a new form in the designer.

## Add a New Dataset to the Application

1. On the **Project** menu, select **Add New Item**.

     The **Add New Item** dialog box appears.

2. In the left-hand pane, select **Data**, then select **DataSet** in the middle pane.

3. Name the Dataset **NorthwindDataset**, and then choose **Add**.

     Visual Studio adds a file called **NorthwindDataset.xsd** to the project and opens it in the **Dataset Designer**.

## Create a Data Connection in Server Explorer

1. On the **View** menu, click **Server Explorer**.

2. In **Server Explorer**, click the **Connect to Database** button.

3. Create a connection to the Northwind sample database.

## Create the Tables in the Dataset

This section explains how to add tables to the dataset.

### To create the Customers table

1. Expand the data connection you created in **Server Explorer**, and then expand the **Tables** node.

2. Drag the **Customers** table from **Server Explorer** onto the **Dataset Designer**.

     A **Customers** data table and **CustomersTableAdapter** are added to the dataset.

### To create the Orders table

- Drag the **Orders** table from **Server Explorer** onto the **Dataset Designer**.

     An **Orders** data table, **OrdersTableAdapter**, and data relation between the **Customers** and **Orders** tables are added to the dataset.

### To create the OrderDetails table

- Drag the **Order Details** table from **Server Explorer** onto the **Dataset Designer**.

     An **Order Details** data table, **OrderDetailsTableAdapter**, and a data relation between the **Orders** and **OrderDetails** tables are added to the dataset.

## Next Steps

- Save the dataset.

- Select items in the **Data Sources** window and drag them onto a form. For more information, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md).

- Add more queries to the TableAdapters.

- Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> events of the data tables in the dataset. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).

## See also

- [Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Validate data](../data-tools/validate-data-in-datasets.md)
