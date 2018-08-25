---
title: "Walkthrough: Creating a DataTable in the Dataset Designer | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "DataTable objects, creating"
  - "Dataset Designer, creating data tables"
  - "tables [Visual Studio], creating"
  - "data [Visual Studio], Dataset Designer"
ms.assetid: abf0a2b5-e4e5-422e-97ef-55a0e35a82df
caps.latest.revision: 10
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# Walkthrough: Creating a DataTable in the Dataset Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough explains how to create a <xref:System.Data.DataTable> (without a TableAdapter) using the **Dataset Designer**. For information on creating data tables that include TableAdapters, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).  
  
 Tasks illustrated in this walkthrough include:  
  
-   Creating a new Windows Application project  
  
-   Adding a new dataset to the application  
  
-   Adding a new data table to the dataset  
  
-   Adding columns to the data table  
  
-   Setting the primary key for the table  
  
## Creating a New Windows Application  
  
#### To create a new Windows Application project  
  
1.  From the **File** menu, create a new project.  
  
2.  Choose a programming language in the **Project Types** pane.  
  
3.  Click **Windows Application** in the **Templates** pane.  
  
4.  Name the project `DataTableWalkthrough`, and then click **OK**.  
  
     Visual Studio adds the project to **Solution Explorer** and displays **Form1** in the designer.  
  
## Adding a New Dataset to the Application  
  
#### To add a new dataset item to the project  
  
1.  On the **Project** menu, click **Add New Item**.  
  
     The Add New Item Dialog Box appears.  
  
2.  In the **Templates** box, select **DataSet**.  
  
3.  Click **Add**.  
  
     Visual Studio will add a file called **DataSet1.xsd** to the project and open it in the **Dataset Designer**.  
  
## Adding a New DataTable to the Dataset  
  
#### To add a new data table to the dataset  
  
1.  Drag a **DataTable** from the **DataSet** tab of the **Toolbox** onto the **Dataset Designer**.  
  
     A table named **DataTable1** is added to the dataset.  
  
    > [!NOTE]
    >  To create a data table that includes a TableAdapter, see [Walkthrough: Creating a TableAdapter with Multiple Queries](../data-tools/walkthrough-creating-a-tableadapter-with-multiple-queries.md).  
  
2.  Click the title bar of **DataTable1** and rename it `Music`.  
  
## Adding Columns to the Data Table  
  
#### To add columns to the data table  
  
1.  Right-click the **Music** table. Point to **Add**, and then click **Column**.  
  
2.  Name the column `SongID`.  
  
3.  In the **Properties** window, set the <xref:System.Data.DataColumn.DataType%2A> property to <xref:System.Int16?displayProperty=fullName>.  
  
4.  Repeat this process and add the following columns:  
  
     `SongTitle`: <xref:System.String?displayProperty=fullName>  
  
     `Artist`: <xref:System.String?displayProperty=fullName>  
  
     `Genre`: <xref:System.String?displayProperty=fullName>  
  
## Setting the Primary Key for the Table  
 All data tables should have a primary key. A primary key uniquely identifies a specific record in a data table.  
  
#### To set the primary key of the data table  
  
-   Right-click the **SongID** column, and then click **Set Primary Key**.  
  
     A key icon appears next to the **SongID** column.  
  
## Saving Your Project  
  
#### To save the DataTableWalkthrough project  
  
-   On the **File** menu, click **Save All**.  
  
## Next Steps  
 Now that you have created the table, you might want to perform one of the following actions:  
  
|To|See|  
|--------|---------|  
|Create a form to input data|[Walkthrough: Displaying Data on a Windows Form](../data-tools/walkthrough-displaying-data-on-a-windows-form.md).|  
|Add data to the table|[Adding Data to a DataTable](http://msdn.microsoft.com/library/d6aa8474-7bde-48f7-949d-20dc38a1625b).|  
|View data in a table|[Viewing Data in a DataTable](http://msdn.microsoft.com/library/1d26e0fb-f6e0-4afa-9a9c-b8d55b8f20dc).|  
|Edit data|[DataTable Edits](http://msdn.microsoft.com/library/f08008a9-042e-4de9-94f3-4f0e502b1eb5)|  
|Delete a row from a table|[DataRow Deletion](http://msdn.microsoft.com/library/c34f531d-4b9b-4071-b2d7-342c402aa586)|  
  
## See Also  
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)   
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)