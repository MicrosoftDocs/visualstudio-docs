---
title: "Walkthrough: Creating a TableAdapter with Multiple Queries | Microsoft Docs"
ms.custom: ""
ms.date: "11/02/2016"
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
  - "TableAdapter queries, creating"
  - "data [Visual Studio], TableAdapters"
  - "TableAdapters, creating"
  - "data [Visual Studio], walkthroughs"
  - "queries [Visual Studio], TableAdapters"
ms.assetid: f784dc4d-d514-4ade-8226-f8271c5b1ed8
caps.latest.revision: 18
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Walkthrough: Creating a TableAdapter with Multiple Queries
In this walkthrough, you will create a TableAdapter in a dataset using the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png). The walkthrough takes you through the process of creating a second query in the [TableAdapter](../data-tools/tableadapter-overview.md) using the [Editing TableAdapters](../data-tools/editing-tableadapters.md) within the [Dataset Designer](../data-tools/creating-and-editing-typed-datasets.md).  
  
 Tasks illustrated in this walkthrough include:  
  
-   Creating a new **Windows Application** project.  
  
-   Creating and configure a data source in your application by building a dataset with the **Data Source Configuration Wizard**.  
  
-   Opening the new dataset in the **Dataset Designer**.  
  
-   Adding queries to the TableAdapter with the **TableAdapter Query Configuration Wizard**.  
  
## Prerequisites  
 In order to complete this walkthrough, you need:  
  
-   Access to the Northwind sample database (SQL Server or Access version). For more information, see [How to: Install Sample Databases](../data-tools/how-to-install-sample-databases.md).  
  
## Creating a New Windows Application  
 The first step is to create a Windows application.  
  
#### To create a new Windows Application project  
  
1.  In [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], from the **File** menu, create a new project.  
  
2.  Choose a programming language in the **Project Types** pane.  
  
3.  Click **Windows Application** in the **Templates** pane.  
  
4.  Name the project `TableAdapterQueriesWalkthrough`, and then click **OK**.  
  
     Visual Studio adds the project to **Solution Explorer** and displays a new form in the designer.  
  
## Creating a Database Data Source with a TableAdapter  
 This step creates a data source using the **Data Source Configuration Wizard** based on the `Customers` table in the Northwind sample database. You must have access to the Northwind sample database to create the connection. For information on setting up the Northwind sample database, see [How to: Install Sample Databases](../data-tools/how-to-install-sample-databases.md).  
  
#### To create the data source  
  
1.  On the **Data** menu, click **Show Data Sources**.  
  
2.  In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration Wizard**.  
  
3.  Select **Database** on the **Choose a Data Source Type** page, and then click **Next**.  
  
4.  On the **Choose your Data Connection** page do one of the following:  
  
    -   If a data connection to the Northwind sample database is available in the drop-down list, select it.  
  
         -or-  
  
    -   Select **New Connection** to launch the **Add/Modify Connection** dialog box.  
  
5.  If your database requires a password, select the option to include sensitive data, and then click **Next**.  
  
6.  Click **Next** on the **Save connection string to the Application Configuration file** page.  
  
7.  Expand the **Tables** node on the **Choose your Database Objects** page.  
  
8.  Select the **Customers** table, and then click **Finish**.  
  
     The **NorthwindDataSet** is added to your project and the **Customers** table appears in the **Data Sources** window.  
  
## Opening the Dataset in the Dataset Designer  
  
#### To open the dataset in the Dataset Designer  
  
1.  Right-click **NorthwindDataset** in the **Data Sources** window.  
  
2.  On the shortcut menu, choose **Edit DataSet with Designer**.  
  
     The NorthwindDataset opens in the **Dataset Designer**.  
  
## Adding a Second Query to the CustomersTableAdapter  
 The wizard created the dataset with a **Customers** data table and **CustomersTableAdapter**. This section of the walkthrough adds a second query to the **CustomersTableAdapter**.  
  
#### To add a query to the CustomersTableAdapter  
  
1.  Drag a **Query** from the **DataSet** tab of the **Toolbox** onto the **Customers** table.  
  
     The [Editing TableAdapters](../data-tools/editing-tableadapters.md) opens.  
  
2.  Select **Use SQL statements**, and then click **Next**.  
  
3.  Select **SELECT which returns rows**, and then click **Next**.  
  
4.  Add a WHERE clause to the query so that it reads:  
  
    ```  
    SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax   
    FROM Customers   
    WHERE City = @City  
    ```  
  
    > [!NOTE]
    >  If you are using the Access version of Northwind, replace the @City parameter with a question mark. (`SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE City = ?`)  
  
5.  On the **Choose Methods to Generate** page, name the **Fill a DataTable** method `FillByCity`.  
  
    > [!NOTE]
    >  The method to **Return a DataTable** is not used in this walkthrough, so you can clear the check box or leave the default name.  
  
6.  Click **Next** and finish the wizard.  
  
     The **FillByCity** query is added to the **CustomersTableAdapter**.  
  
## Adding Code To Execute the Additional Query on the Form  
  
#### To execute the query  
  
1.  Select **Form1** in **Solution Explorer**, and click **View Designer**.  
  
2.  Drag the **Customers** node from the **Data Sources** window to **Form1**.  
  
3.  Change to code view by selecting **Code** from the **View** menu.  
  
4.  Replace the code in the `Form1_Load` event handler with the following to run the `FillByCity` query.  
  
     [!code-vb[VbRaddataTableAdapters#1](../data-tools/codesnippet/VisualBasic/walkthrough-creating-a-tableadapter-with-multiple-queries_1.vb)]
     [!code-cs[VbRaddataTableAdapters#1](../data-tools/codesnippet/CSharp/walkthrough-creating-a-tableadapter-with-multiple-queries_1.cs)]  
  
## Running the Application  
  
#### To run the application  
  
-   Press F5.  
  
-   The grid is filled with customers with a `City` value of `Seattle`.  
  
## Next Steps  
  
### To add functionality to your application  
  
-   Add a <xref:System.Windows.Forms.TextBox> control and <xref:System.Windows.Forms.Button> control and pass the value in the text box to the query. (`CustomersTableAdapter.FillByCity(NorthwindDataSet.Customers, TextBox1.Text)`).  
  
-   Add validation logic to the <xref:System.Data.DataTable.ColumnChanging> or <xref:System.Data.DataTable.RowChanging> event of the data tables in the dataset. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).  
  
## See Also  
 [TableAdapter Overview](../data-tools/tableadapter-overview.md)   
 [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md)   
 [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)   
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)