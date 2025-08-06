---
title: Create and configure datasets in .NET Framework apps
description: Create and configure datasets in .NET Framework applications with ADO.NET in Visual Studio and the Data Source Configuration Wizard.
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
ms.topic: how-to
ms.date: 03/04/2025
ms.custom: sfi-image-nochange
helpviewer_keywords:
- typed datasets, creating
- datasets, creating
- datasets, configuring

# Customer intent: As a developer, I want to understand how to configure datasets in .NET Framework apps so that my apps will support database operations without needing to be always connected to the database.
---

# Create and configure datasets in the .NET Framework using Visual Studio

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

A dataset is a set of objects that store data from a database in memory and support change tracking to enable create, read, update, and delete (CRUD) operations on that data without the need to be always connected to the database. To work with datasets, you should have a basic knowledge of database concepts.

You can create a typed <xref:System.Data.DataSet> class in Visual Studio at design time by using the **Data Source Configuration Wizard**. For information on creating datasets programmatically, see [Create a dataset](/dotnet/framework/data/adonet/dataset-datatable-dataview/creating-a-dataset).

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) with the **.NET desktop development** and **Data storage and processing** workloads installed. To install them, open **Visual Studio Installer** and choose **Modify** next to the version of Visual Studio you want to modify.

- A .NET Framework project. Don't use .NET Core or .NET 5 or later.

- SQL Server Express LocalDB. If you don't have SQL Server Express LocalDB, you can install it from the [SQL Server download page](https://www.microsoft.com/sql-server/sql-server-downloads).

## Create a new dataset by using the Data Source Configuration Wizard

1. Open your project in Visual Studio, and then choose **Project** > **Add New Data Source** to start the **Data Source Configuration Wizard**.

1. Select **Database** as the type of data source, and then select **Next**.

     :::image type="content" source="../data-tools/media/vs-2022/data-source-configuration-wizard.png" alt-text="Screenshot that shows the Data Source Configuration Wizard.":::

1. Choose **DataSet**, and then select **Next**.

     :::image type="content" source="./media/vs-2022/data-source-configuration-wizard-2.png" alt-text="Screenshot that shows how to choose DataSet as the database model.":::

1. Choose one or more databases as the data connection for your dataset, and then select **Next**.

     :::image type="content" source="../data-tools/media/data-source-choose-a-connection.png" alt-text="Screenshot that shows how to select a database as a data source.":::

1. Choose the tables (or individual columns), views, stored procedures, and functions from the database that you want to be represented in the dataset.

     :::image type="content" source="../data-tools/media/vs-2022/choose-your-database-objects.png" alt-text="Screenshot that shows how to choose your database objects.":::

1. Select **Finish**.

   The dataset appears as a node in **Solution Explorer**.

   :::image type="content" source="../data-tools/media/vs-2022/dataset-in-solution-explorer.png" alt-text="Screenshot that shows how the dataSet appears in Solution Explorer.":::

1. Double-click the dataset node in **Solution Explorer**.

   The dataset opens in the Dataset Designer.

   Each table in the dataset has an associated `TableAdapter` object, which is represented at the bottom of the table diagram. The table adapter is used to populate the dataset and optionally to send commands to the database.

   :::image type="content" source="../data-tools/media/vs-2022/dataset-in-dataset-designer.png" alt-text="Screenshot that shows the data tables in the Dataset Designer.":::

1. If you want to change the behavior of hierarchical updates, you can double-click a relation line between two tables to display the **Relation** dialog.

   The relation lines that connect the tables represent table relationships, as defined in the database. By default, foreign-key constraints in a database are represented as a relation only, with the update and delete rules set to none, which is typically what you want. For more information, see [Create relationships between datasets](../data-tools/relationships-in-datasets.md) and [Hierarchical update](../data-tools/hierarchical-update.md).

     :::image type="content" source="../data-tools/media/vs-2022/dataset-relation-dialog.png" alt-text="Screenshot that shows the Relation dialog where you can edit the dataset relation.":::

1. In the Dataset Designer, select a table, table adapter, or column name to see its properties in the **Properties** window. Although you can modify some of the values in the window, remember that you're modifying the dataset, not the source database.

     :::image type="content" source="../data-tools/media/vs-2022/data-column-properties.png" alt-text="Screenshot that shows DataSet column properties.":::

1. You can add new tables or table adapters to the dataset, add new queries for existing table adapters, or specify new relations between tables by dragging those items from the left **Toolbox** tab. This tab appears when the Dataset Designer is in focus.

     :::image type="content" source="../data-tools/media/vs-2022/dataset-designer-toolbox.png" alt-text="Screenshot that shows the Dataset Toolbox.":::

1. Optionally, you might want to specify how to populate the dataset with data. To do so, use the **TableAdapter Configuration Wizard**. For more information, see [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md).

## Add a database table or other object to an existing dataset

This procedure shows how to add a table from the same database that you used to first create the dataset:

1. Double-click the dataset node in **Solution Explorer**.

   The dataset opens in the Dataset Designer.

1. Select the **Data Sources** tab in the left margin of Visual Studio, or enter **data sources** in the search box.

1. Right-click the dataset node and select **Configure Data Source with Wizard**.

     :::image type="content" source="../data-tools/media/vs-2022/configure-data-source-with-wizard-context-menu.png" alt-text="Screenshot that shows the Data Source context menu.":::

1. Use the **Data Source Configuration Wizard** to specify which additional tables, stored procedures, or other database objects to add to the dataset.

## Add a stand-alone data table to a dataset

1. Open your dataset in the Dataset Designer.

1. Drag a <xref:System.Data.DataTable> class from the **DataSet** tab of the **Toolbox** onto the Dataset Designer.

1. Add columns to define your data table. Right-click the table and choose **Add** > **Column**. In the **Properties** window, set the data type of the column. If necessary, add a key by selecting **Add** > **Key**.

Stand-alone tables need to implement `Fill` logic so that you can fill them with data. For information about filling data tables, see [Populate a DataSet from a DataAdapter](/dotnet/framework/data/adonet/populating-a-dataset-from-a-dataadapter).

## Related content

- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
- [Create relationships between datasets](../data-tools/relationships-in-datasets.md)
- [Hierarchical update](../data-tools/hierarchical-update.md)
- [Fill datasets by using TableAdapters](../data-tools/fill-datasets-by-using-tableadapters.md)
