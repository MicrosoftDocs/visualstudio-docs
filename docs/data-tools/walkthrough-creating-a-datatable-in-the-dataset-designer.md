---
title: "Walkthrough: Creating a DataTable in the Dataset Designer | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "DataTable objects, creating"
  - "Dataset Designer, creating data tables"
  - "tables [Visual Studio], creating"
  - "data [Visual Studio], Dataset Designer"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# Walkthrough: Creating a DataTable in the Dataset Designer

This walkthrough explains how to create a <xref:System.Data.DataTable> (without a TableAdapter) using the **Dataset Designer**. For information on creating data tables that include TableAdapters, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).  

Tasks illustrated in this walkthrough include:  

-   Creating a new Windows Forms Application project  

-   Adding a new dataset to the application  

-   Adding a new data table to the dataset  

-   Adding columns to the data table  

-   Setting the primary key for the table  

## Creating a new Windows Forms application

### To create a new Windows Forms application project  
  
1. In Visual Studio, on the **File** menu, select **New**, **Project...**.  
  
2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Classic Desktop**.  

3. In the middle pane, select the **Windows Forms App** project type.  

4. Name the project **DataTableWalkthrough**, and then choose **OK**. 
  
     The **DataTableWalkthrough** project is created, and added to **Solution Explorer**.  

## Adding a new Dataset to the application

### To add a new dataset item to the project  
  
1.  On the **Project** menu, select **Add New Item...**.  
  
     The Add New Item dialog box appears.  
  
2.  In the left-hand pane, select **Data**, then select **DataSet** in the middle pane.  
  
3.  Choose **Add**.  
  
     Visual Studio adds a file called **DataSet1.xsd** to the project and opens it in the **Dataset Designer**.  

## Adding a new DataTable to the Dataset  

### To add a new data table to the dataset  
  
1.  Drag a **DataTable** from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
     A table named **DataTable1** is added to the dataset.  
   
2.  Click the title bar of **DataTable1** and rename it `Music`.  

## Adding columns to the DataTable

### To add columns to the DataTable  
  
1.  Right-click the **Music** table. Point to **Add**, and then click **Column**.  
  
2.  Name the column `SongID`.  
  
3.  In the **Properties** window, set the <xref:System.Data.DataColumn.DataType%2A> property to <xref:System.Int16?displayProperty=fullName>.  
  
4.  Repeat this process and add the following columns:  
  
     `SongTitle`: <xref:System.String?displayProperty=fullName>  
  
     `Artist`: <xref:System.String?displayProperty=fullName>  
  
     `Genre`: <xref:System.String?displayProperty=fullName>  
  
## Setting the Primary Key for the table

All data tables should have a primary key. A primary key uniquely identifies a specific record in a data table.  
  
### To set the primary key of the data table
  
-   Right-click the **SongID** column, and then click **Set Primary Key**.  
  
     A key icon appears next to the **SongID** column.  
  
## Saving Your Project  
  
### To save the DataTableWalkthrough project  
  
-   On the **File** menu, click **Save All**.  

## See also

[Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)  
[Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)  
[Validating Data](../data-tools/validate-data-in-datasets.md)  
[Saving Data](../data-tools/saving-data.md)