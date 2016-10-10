---
title: "Walkthrough: Creating a DataTable in the Dataset Designer"
ms.custom: na
ms.date: 09/17/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: abf0a2b5-e4e5-422e-97ef-55a0e35a82df
caps.latest.revision: 10
manager: ghogen
robots: noindex,nofollow
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Walkthrough: Creating a DataTable in the Dataset Designer
This walkthrough explains how to create a <xref:System.Data.DataTable?qualifyHint=False> (without a TableAdapter) using the **Dataset Designer**. For information on creating data tables that include TableAdapters, see [Create and configure TableAdapters](../VS_raddata/Create-and-configure-TableAdapters.md).  
  
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
    >  To create a data table that includes a TableAdapter, see [Walkthrough: Creating a TableAdapter with Multiple Queries](../VS_raddata/Walkthrough--Creating-a-TableAdapter-with-Multiple-Queries.md).  
  
2.  Click the title bar of **DataTable1** and rename it `Music`.  
  
## Adding Columns to the Data Table  
  
#### To add columns to the data table  
  
1.  Right-click the **Music** table. Point to **Add**, and then click **Column**.  
  
2.  Name the column `SongID`.  
  
3.  In the **Properties** window, set the <xref:System.Data.DataColumn.DataType?qualifyHint=False> property to <xref:System.Int16?qualifyHint=True>.  
  
4.  Repeat this process and add the following columns:  
  
     `SongTitle`: <xref:System.String?qualifyHint=True>  
  
     `Artist`: <xref:System.String?qualifyHint=True>  
  
     `Genre`: <xref:System.String?qualifyHint=True>  
  
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
|Create a form to input data|[Walkthrough: Displaying Data on a Windows Form](../VS_raddata/Walkthrough--Displaying-Data-on-a-Windows-Form.md).|  
|Add data to the table|[Adding Data to a DataTable](../Topic/Adding%20Data%20to%20a%20DataTable.md).|  
|View data in a table|[Viewing Data in a DataTable](../Topic/Viewing%20Data%20in%20a%20DataTable.md).|  
|Edit data|[DataTable Edits](../Topic/DataTable%20Edits.md)|  
|Delete a row from a table|[DataRow Deletion](../Topic/DataRow%20Deletion.md)|  
  
## See Also  
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)