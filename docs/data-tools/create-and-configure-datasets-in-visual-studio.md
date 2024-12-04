---
title: Create and configure datasets in .NET Framework apps
description: Create and configure datasets in .NET Framework applications with ADO.NET in Visual Studio and the Data Source Configuration Wizard.
ms.date: 12/15/2023
ms.topic: how-to
helpviewer_keywords:
- typed datasets, creating
- datasets, creating
- datasets, configuring
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create and configure datasets in the .NET Framework using Visual Studio

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

A dataset is a set of objects that store data from a database in memory and support change tracking to enable create, read, update, and delete (CRUD) operations on that data without the need to be always connected to the database. Datasets were designed for simple *forms over data* business applications. For new applications, consider using Entity Framework to store and model data in memory. To work with datasets, you should have a basic knowledge of database concepts.

You can create a typed <xref:System.Data.DataSet> class in Visual Studio at design time by using the **Data Source Configuration Wizard**. For information on creating datasets programmatically, see [Creating a dataset (ADO.NET)](/dotnet/framework/data/adonet/dataset-datatable-dataview/creating-a-dataset).

## Prerequisites

- a .NET Framework project (not .NET Core or .NET 5 or later)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **.NET desktop development** and **Data storage and processing** workloads installed. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify.

- SQL Server Express LocalDB. If you don't have SQL Server Express LocalDB, you can install it from the [SQL Server download page](https://www.microsoft.com/sql-server/sql-server-downloads).

## Create a new dataset by using the Data Source Configuration Wizard

1. Open your project in Visual Studio, and then choose **Project** > **Add New Data Source** to start the **Data Source Configuration Wizard**.

1. Choose the type of data source to which you'll be connecting.

     ![Screenshot showing Data Source Configuration Wizard.](../data-tools/media/vs-2022/data-source-configuration-wizard.png)

1. Choose `DataSet` from the list of options.

     ![Screenshot showing choosing DataSet as the database model.](./media/vs-2022/data-source-configuration-wizard-2.png)

1. Choose the database or databases that will be the data source for your dataset.

     ![Screenshot showing how to choose a connection.](../data-tools/media/data-source-choose-a-connection.png)

1. Choose whether to save the connection string in *app.config*.

     ![Screenshot showing option to save connection string to the application configuration file.](./media/vs-2022/save-connection-string-to-app-config.png)

1. Choose the tables (or individual columns), stored procedures, functions, and views from the database that you want to be represented in the dataset.

     ![Screenshot showing how to choose your database objects.](../data-tools/media/vs-2022/choose-your-database-objects.png)

1. Click **Finish**.

   The dataset appears as a node in **Solution Explorer**.

   ![Screenshot showing DataSet in Solution Explorer.](../data-tools/media/vs-2022/dataset-in-solution-explorer.png)

1. Click the dataset node in **Solution Explorer** to open the dataset in the **DataSet Designer**. Each table in the dataset has an associated `TableAdapter` object, which is represented at the bottom. The table adapter is used to populate the dataset and optionally to send commands to the database.

   ![Screenshot showing data tables in DataSet Designer.](../data-tools/media/vs-2022/dataset-in-dataset-designer.png)

1. The relation lines that connect the tables represent table relationships, as defined in the database. By default, foreign-key constraints in a database are represented as a relation only, with the update and delete rules set to none. Typically, that is what you want. However, you can click the lines to bring up the **Relation** dialog, where you can change the behavior of hierarchical updates. For more information, see [Relationships in datasets](../data-tools/relationships-in-datasets.md) and [Hierarchical update](../data-tools/hierarchical-update.md).

     ![Dataset Relation dialog](../data-tools/media/vs-2022/dataset-relation-dialog.png)

1. Click a table, table adapter, or column name in a table to see its properties in the **Properties** window. You can modify some of the values here. Just remember that you are modifying the dataset, not the source database.

     ![Screenshot showing DataSet column properties.](../data-tools/media/vs-2022/data-column-properties.png)

1. You can add new tables or table adapters to the dataset, or add new queries for existing table adapters, or specify new relations between tables by dragging those items from the **Toolbox** tab. This tab appears when the **DataSet Designer** is in focus.

     ![Screenshot showing Dataset Toolbox.](../data-tools/media/vs-2022/dataset-designer-toolbox.png)

Next, you might want to specify how to populate the dataset with data. For that, you use the **TableAdapter Configuration Wizard**. For more information, see [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md).

## Add a database table or other object to an existing dataset

This procedure shows how to add a table from the same database that you used to first create the dataset.

1. Click the dataset node in **Solution Explorer** to bring the **DataSet Designer** into focus.

1. Click the **Data Sources** tab in the left margin of Visual Studio, or type **data sources** in the search box.

1. Right-click the dataset node and select **Configure Data Source with Wizard**.

     ![Screenshot showing Data Source context menu.](../data-tools/media/vs-2022/configure-data-source-with-wizard-context-menu.png)

1. Use the wizard to specify which additional tables, stored procedures, or other database objects to add to the dataset.

## Add a stand-alone data table to a dataset

1. Open your dataset in the **Dataset Designer**.

1. Drag a <xref:System.Data.DataTable> class from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.

1. Add columns to define your data table. Right-click on the table and choose **Add** > **Column**. Use the **Properties** window to set the data type of the column and a key if necessary.

Stand-alone tables need to implement `Fill` logic so that you can fill them with data. For information on filling data tables, see [Populating a DataSet from a DataAdapter](/dotnet/framework/data/adonet/populating-a-dataset-from-a-dataadapter).

## Related content

- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
- [Relationships in datasets](../data-tools/relationships-in-datasets.md)
- [Hierarchical update](../data-tools/hierarchical-update.md)
- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
