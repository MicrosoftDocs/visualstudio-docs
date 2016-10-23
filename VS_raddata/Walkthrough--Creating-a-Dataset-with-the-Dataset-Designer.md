---
title: "Walkthrough: Creating a Dataset with the Dataset Designer"
ms.custom: na
ms.date: 10/01/2016
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
ms.assetid: 12360f54-db6c-45d2-a91f-fee43214b555
caps.latest.revision: 19
manager: ghogen
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Walkthrough: Creating a Dataset with the Dataset Designer
In this walkthrough you will create a dataset using the **Dataset Designer**. It will take you through the process of creating a new project and adding a new **DataSet** item to it. You will learn how to create tables based on tables in a database without using a wizard.  
  
 Tasks illustrated in this walkthrough include:  
  
-   Creating a new **Windows Application** project.  
  
-   Adding an empty **DataSet** item to the project.  
  
-   Creating and configuring a data source in your application by building a dataset with the **Dataset Designer**.  
  
-   Creating a connection to the Northwind database in **Server Explorer**.  
  
-   Creating tables with TableAdapters in the dataset based on tables in the database.  
  
 > [!NOTE]
>  Your computer might show different names or locations for some of the Visual Studio user interface elements in the following instructions. The Visual Studio edition that you have and the settings that you use determine these elements. For more information, see [Personalizing the  IDE](../VS_IDE/Personalizing-the-Visual-Studio-IDE.md).  
  
## Prerequisites  
 In order to complete this walkthrough, you need:  
  
-   Access to the Northwind sample database (SQL Server or Access version). For more information, see [How to: Install Sample Databases](../VS_raddata/How-to--Install-Sample-Databases.md).  
  
## Creating a New Windows Application Project  
  
#### To create a new Windows Application project  
  
1.  From the **File** menu, create a new project.  
  
2.  Choose a programming language in the **Project Types** pane.  
  
3.  Click **Windows Application** in the **Templates** pane.  
  
4.  Name the project `DatasetDesignerWalkthrough`, and then click **OK**.  
  
     Visual Studio will add the project to **Solution Explorer** and display a new form in the designer.  
  
## Adding a New Dataset to the Application  
  
#### To add a new dataset item to the project  
  
1.  On the **Project** menu, click **Add New Item**.  
  
     The **Add New Item** dialog box appears.  
  
2.  In the **Templates** box of the **Add New Item** dialog box, click **DataSet**.  
  
3.  Name the Dataset `NorthwindDataset`, and then click **Add**.  
  
     Visual Studio will add a file called **NorthwindDataset.xsd** to the project and open it in the **Dataset Designer**.  
  
## Creating a Data Connection in Server Explorer  
  
#### To create a connection to the Northwind database  
  
1.  On the **View** menu, click **Server Explorer**.  
  
2.  In **Server Explorer**, click the **Connect to Database** button.  
  
3.  Create a connection to the Northwind sample database.  
  
    > [!NOTE]
    >  You can connect to the SQL Server or Access version of Northwind for this walkthrough.  
  
## Creating the Tables in the Dataset  
 This section will explain how to add tables to the dataset.  
  
#### To create the Customers table  
  
1.  Expand the data connection you created in **Server Explorer**, and then expand the **Tables** node.  
  
2.  Drag the **Customers** table from **Server Explorer** onto the **Dataset Designer**.  
  
     A **Customers** data table and **CustomersTableAdapter** are added to the dataset.  
  
#### To create the Orders table  
  
-   Drag the **Orders** table from **Server Explorer** onto the **Dataset Designer**.  
  
     An **Orders** data table, **OrdersTableAdapter**, and data relation between the **Customers** and **Orders** tables are added to the dataset.  
  
#### To create the OrderDetails table  
  
-   Drag the **Order Details** table from **Server Explorer** onto the **Dataset Designer**.  
  
     An **Order Details** data table, **Order DetailsTableAdapter**, and a data relation between the **Orders** and **Order Details** tables are added to the dataset.  
  
## Next Steps  
  
### To add functionality to your application  
  
-   Save the dataset.  
  
-   Select items in the **Data Sources** window and drag them onto a form. For more information, see [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md).  
  
-   Add more queries to the TableAdapters. For more information, see [How to: Create TableAdapter Queries](../VS_raddata/How-to--Create-TableAdapter-Queries.md).  
  
-   Add validation logic to the <xref:System.Data.DataTable.ColumnChanging?qualifyHint=False> or <xref:System.Data.DataTable.RowChanging?qualifyHint=False> events of the data tables in the dataset. For more information, see [Validate data in datasets](../VS_raddata/Validate-data-in-datasets.md).  
  
## See Also  
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Bind Windows Forms controls to data in Visual Studio](../VS_raddata/Bind-Windows-Forms-controls-to-data-in-Visual-Studio.md)   
 [Connecting to Data in Visual Studio](../VS_raddata/Connecting-to-Data-in-Visual-Studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../VS_raddata/Fetching-Data-into-Your-Application.md)   
 [Bind controls to data in Visual Studio](../VS_raddata/Bind-controls-to-data-in-Visual-Studio.md)   
 [Editing Data in Your Application](../VS_raddata/Editing-Data-in-Your-Application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../VS_raddata/Saving-Data.md)