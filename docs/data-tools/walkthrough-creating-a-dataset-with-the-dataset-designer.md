---
title: "Walkthrough: Creating a Dataset with the Dataset Designer | Microsoft Docs"
ms.custom: ""
ms.date: "09/11/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "datasets [Visual Basic], walkthroughs"
  - "XML schemas, creating datasets"
  - "data [Visual Studio], Dataset Designer"
  - "Dataset Designer, walkthroughs"
  - "datasets [Visual Basic], creating"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.technology: "vs-data-tools"
ms.workload: 
  - "data-storage"
---
# Walkthrough: Creating a Dataset with the Dataset Designer

In this walkthrough you will create a dataset using the **Dataset Designer**. It will take you through the process of creating a new project and adding a new **DataSet** item to it. You will learn how to create tables based on tables in a database without using a wizard.  

Tasks illustrated in this walkthrough include:  

-   Creating a new **Windows Forms Application** project.  

-   Adding an empty **DataSet** item to the project.  

-   Creating and configuring a data source in your application by building a dataset with the **Dataset Designer**.  
 
-   Creating a connection to the Northwind database in **Server Explorer**.  

-   Creating tables with TableAdapters in the dataset based on tables in the database.  

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]  
  
## Prerequisites  
This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.  
  
1.  If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the Visual Studio Installer, SQL Server Express LocalDB can be installed as part of the **Data storage and processing** workload, or as an individual component.  
  
2.  Install the Northwind sample database by following these steps:  

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query...**.  

       A query editor window opens.  

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/master/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.  

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.  

       After a short time, the query finishes executing and the Northwind database is created.  
  
## Creating a New Windows Forms Application Project  
  
#### To create a new Windows Forms Application project  
  
1. In Visual Studio, on the **File** menu, select **New**, **Project...**.  
  
2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Classic Desktop**.  

3. In the middle pane, select the **Windows Forms App** project type.  

4. Name the project **DatasetDesignerWalkthrough**, and then choose **OK**.  
  
     Visual Studio adds the project to **Solution Explorer** and display a new form in the designer.  
  
## Adding a New Dataset to the Application  
  
#### To add a new dataset item to the project  
  
1.  On the **Project** menu, select **Add New Item...**.  
  
     The **Add New Item** dialog box appears.  
  
2.  In the left-hand pane, select **Data**, then select **DataSet** in the middle pane.  
  
3.  Name the Dataset **NorthwindDataset**, and then choose **Add**.  
  
     Visual Studio adds a file called **NorthwindDataset.xsd** to the project and opens it in the **Dataset Designer**.  
  
## Creating a Data Connection in Server Explorer  
  
#### To create a connection to the Northwind database  
  
1.  On the **View** menu, click **Server Explorer**.  
  
2.  In **Server Explorer**, click the **Connect to Database** button.  
  
3.  Create a connection to the Northwind sample database.  
  
## Creating the Tables in the Dataset  
This section explains how to add tables to the dataset.  
  
#### To create the Customers table  
  
1.  Expand the data connection you created in **Server Explorer**, and then expand the **Tables** node.  
  
2.  Drag the **Customers** table from **Server Explorer** onto the **Dataset Designer**.  
  
     A **Customers** data table and **CustomersTableAdapter** are added to the dataset.  
  
#### To create the Orders table  
  
-   Drag the **Orders** table from **Server Explorer** onto the **Dataset Designer**.  
  
     An **Orders** data table, **OrdersTableAdapter**, and data relation between the **Customers** and **Orders** tables are added to the dataset.  
  
#### To create the OrderDetails table  
  
-   Drag the **Order Details** table from **Server Explorer** onto the **Dataset Designer**.  
  
     An **Order Details** data table, **OrderDetailsTableAdapter**, and a data relation between the **Orders** and **OrderDetails** tables are added to the dataset.  
  
## Next Steps  
  
### To add functionality to your application  
  
-   Save the dataset.  
  
-   Select items in the **Data Sources** window and drag them onto a form. For more information, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md).  
  
-   Add more queries to the TableAdapters. 
  
-   Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> events of the data tables in the dataset. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).  
  
## See also
[Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)  
[Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
[Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
[Validating Data](../data-tools/validate-data-in-datasets.md)   
[Saving Data](../data-tools/saving-data.md)