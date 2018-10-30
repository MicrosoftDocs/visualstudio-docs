---
title: "Walkthrough: Creating a Dataset with the Dataset Designer | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
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
  - "datasets [Visual Basic], walkthroughs"
  - "XML schemas, creating datasets"
  - "data [Visual Studio], Dataset Designer"
  - "Dataset Designer, walkthroughs"
  - "datasets [Visual Basic], creating"
ms.assetid: 12360f54-db6c-45d2-a91f-fee43214b555
caps.latest.revision: 19
author: gewarren
ms.author: gewarren
manager: "ghogen"
robots: noindex,nofollow
---
# Walkthrough: Creating a Dataset with the Dataset Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough you will create a dataset using the **Dataset Designer**. It will take you through the process of creating a new project and adding a new **DataSet** item to it. You will learn how to create tables based on tables in a database without using a wizard.  
  
 Tasks illustrated in this walkthrough include:  
  
- Creating a new **Windows Application** project.  
  
- Adding an empty **DataSet** item to the project.  
  
- Creating and configuring a data source in your application by building a dataset with the **Dataset Designer**.  
  
- Creating a connection to the Northwind database in **Server Explorer**.  
  
- Creating tables with TableAdapters in the dataset based on tables in the database.  
  
  [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
## Prerequisites  
 In order to complete this walkthrough, you need:  
  
-   Access to the Northwind sample database (SQL Server or Access version). For more information, see [How to: Install Sample Databases](../data-tools/how-to-install-sample-databases.md).  
  
## Creating a New Windows Application Project  
  
#### To create a new Windows Application project  
  
1.  From the **File** menu, create a new project.  
  
2.  Choose a programming language in the **Project Types** pane.  
  
3.  Click **Windows Application** in the **Templates** pane.  
  
4.  Name the project `DatasetDesignerWalkthrough`, and then click **OK**.  
  
     [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will add the project to **Solution Explorer** and display a new form in the designer.  
  
## Adding a New Dataset to the Application  
  
#### To add a new dataset item to the project  
  
1.  On the **Project** menu, click **Add New Item**.  
  
     The **Add New Item** dialog box appears.  
  
2.  In the **Templates** box of the **Add New Item** dialog box, click **DataSet**.  
  
3.  Name the Dataset `NorthwindDataset`, and then click **Add**.  
  
     [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will add a file called **NorthwindDataset.xsd** to the project and open it in the **Dataset Designer**.  
  
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
  
-   Select items in the **Data Sources** window and drag them onto a form. For more information, see [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md).  
  
-   Add more queries to the TableAdapters. For more information, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md).  
  
-   Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> events of the data tables in the dataset. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).  
  
## See Also  
 [Data Walkthroughs](http://msdn.microsoft.com/library/15a88fb8-3bee-4962-914d-7a1f8bd40ec4)   
 [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](http://msdn.microsoft.com/library/c17bdb7e-c234-4f2f-9582-5e55c27356ad)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](http://msdn.microsoft.com/library/b3a9ee4e-5d4d-4411-9c56-c811f2b4ee7e)   
 [Saving Data](../data-tools/saving-data.md)