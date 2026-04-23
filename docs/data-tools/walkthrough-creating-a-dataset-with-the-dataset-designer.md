---
title: Build dataset in Dataset Designer (.NET Framework)
description: Create an ADO.NET dataset with the Dataset Designer in Visual Studio for .NET Framework applications and build a new project with a DataSet item.
ms.date: 11/01/2023
ms.topic: how-to
helpviewer_keywords:
- datasets [Visual Basic], walkthroughs
- XML schemas, creating datasets
- data [Visual Studio], Dataset Designer
- Dataset Designer, walkthroughs
- datasets [Visual Basic], creating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Walkthrough: Create a dataset for .NET Framework applications using the Dataset Designer

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

In this walkthrough you create a dataset using the **Dataset Designer**. The article takes you through the process of creating a new project and adding a new **DataSet** item to it. You'll learn how to create tables based on tables in a database without using a wizard.

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** workload and (for the **Data Sources** window) the **Data storage and processing** workload installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the Visual Studio Installer, SQL Server Express LocalDB can be installed as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes executing and the Northwind database is created.

## Create a New Windows Forms Application Project

1. In Visual Studio, create a new **Windows Forms App (.NET Framework)** project and name it **DatasetDesignerWalkthrough**.

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

## Save the dataset

The dataset that you just created is available in the **Data Sources** window. If you don't see the **Data Sources** window, check that you have the **Data storage and processing** workload installed as mentioned in the [Prerequisites](#prerequisites).

You can now perform any of the following tasks:

- Save the dataset.

- Select items in the **Data Sources** window and drag them onto a form. For more information, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md).

- Add more queries to the TableAdapters.

- Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> events of the data tables in the dataset. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).

## Related content

- [Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)
- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Validate data](../data-tools/validate-data-in-datasets.md)
