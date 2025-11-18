---
title: New DataTable in Dataset Designer (.NET Framework)
description: Create a DataTable (without a TableAdapter) with the Dataset Designer in Visual Studio for .NET Framework applications and build a Windows Forms app with a dataset.
ms.date: 11/01/2023
ms.topic: how-to
helpviewer_keywords:
- DataTable objects, creating
- Dataset Designer, creating data tables
- tables [Visual Studio], creating
- data [Visual Studio], Dataset Designer
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Walkthrough: Create a DataTable for .NET Framework applications using the Dataset Designer

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This walkthrough explains how to create a <xref:System.Data.DataTable> (without a TableAdapter) using the **Dataset Designer**. For information on creating data tables that include TableAdapters, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

## Create a new Windows Forms application

1. In Visual Studio, create a new **Windows Forms App (.NET Framework)** project and name it **DataTableWalkthrough**.

     The **DataTableWalkthrough** project is created and added to **Solution Explorer**.

## Add a new Dataset to the application

1. On the **Project** menu, select **Add New Item**.

     The **Add New Item** dialog box appears.

2. In the left-hand pane, select **Data**, then select **DataSet** in the middle pane.

3. Choose **Add**.

     Visual Studio adds a file called **DataSet1.xsd** to the project and opens it in the **Dataset Designer**.

## Add a new DataTable to the Dataset

1. Drag a **DataTable** from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.

     A table named **DataTable1** is added to the dataset.

2. Click the title bar of **DataTable1** and rename it `Music`.

## Add columns to the DataTable

1. Right-click the **Music** table. Point to **Add**, and then select **Column**.

2. Name the column `SongID`.

3. In the **Properties** window, set the <xref:System.Data.DataColumn.DataType%2A> property to <xref:System.Int16?displayProperty=fullName>.

4. Repeat this process and add the following columns:

     `SongTitle`: <xref:System.String?displayProperty=fullName>

     `Artist`: <xref:System.String?displayProperty=fullName>

     `Genre`: <xref:System.String?displayProperty=fullName>

## Set the Primary Key for the table

All data tables should have a primary key. A primary key uniquely identifies a specific record in a data table.

To set the primary key, right-click the **SongID** column, and then select **Set Primary Key**. A key icon appears next to the **SongID** column.

## Save Your Project

To save the **DataTableWalkthrough** project, on the **File** menu, select **Save All**.

## Related content

- [Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)
- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Validating data](../data-tools/validate-data-in-datasets.md)
