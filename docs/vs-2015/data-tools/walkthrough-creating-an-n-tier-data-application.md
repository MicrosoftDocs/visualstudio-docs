---
title: "Walkthrough: Creating an N-Tier Data Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "n-tier applications, creating"
  - "n-tier applications, walkthroughs"
ms.assetid: d15e4d31-2839-48d9-9e0e-2e73404d82a2
caps.latest.revision: 51
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Creating an N-Tier Data Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

N-tier* data applications are applications that access data and are separated into multiple logical layers, or *tiers*. Separating application components into discrete tiers increases the maintainability and scalability of the application. It does this by enabling easier adoption of new technologies that can be applied to a single tier without requiring you to redesign the whole solution. N-tier architecture includes a presentation tier, a middle-tier, and a data tier. The middle tier typically includes a data access layer, a business logic layer, and shared components such as authentication and validation. The data tier includes a relational database. N-tier applications usually store sensitive information in the data access layer of the middle-tier to maintain isolation from end users who access the presentation tier. For more information, see [N-Tier Data Applications Overview](../data-tools/n-tier-data-applications-overview.md).

 One way to separate the various tiers in an n-tier application is to create discrete projects for each tier that you want to include in your application. Typed datasets contain a `DataSet Project` property that determines which projects the generated dataset and `TableAdapter` code should go into.

 This walkthrough demonstrates how to separate dataset and `TableAdapter` code into discrete class library projects by using the **Dataset Designer**. After you separate the dataset and TableAdapter code, you will create a [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md) service to call into the data access tier. Finally, you will create a Windows Forms application as the presentation tier. This tier accesses data from the data service.

 During this walkthrough, you will perform the following steps:

- Create a new n-tier solution that will contain multiple projects.

- Add two class library projects to the n-tier solution.

- Create a typed dataset by using the **Data Source Configuration Wizard**.

- Separate the generated [TableAdapters](https://msdn.microsoft.com/library/09416de9-134c-4dc7-8262-6c8d81e3f364) and dataset code into discrete projects.

- Create a Windows Communication Foundation (WCF) service to call into the data access tier.

- Create functions in the service to retrieve data from the data access tier.

- Create a Windows Forms application to serve as the presentation tier.

- Create Windows Forms controls that are bound to the data source.

- Write code to populate the data tables.

  ![link to video](../data-tools/media/playvideo.gif "PlayVideo") For a video version of this topic, see [Video How to: Creating an N-Tier Data Application](https://go.microsoft.com/fwlink/?LinkId=115188).

## Prerequisites
 To complete this walkthrough, you need:

- Access to the Northwind sample database.

## Creating the N-Tier Solution and Class Library to Hold the Dataset (DataEntityTier)
 The first step of this walkthrough is to create a solution and two class library projects. The first class library will hold the dataset (the generated typed DataSet class and DataTables that will hold the application's data). This project is used as the data entity layer of the application and is typically located in the middle tier. The Dataset Designer is used to create the initial dataset and automatically separate the code into the two class libraries.

> [!NOTE]
> Be sure to name the project and solution correctly before you click **OK**. Doing so will make it easier for you to complete this walkthrough.

#### To create the n-tier solution and DataEntityTier class library

1. From the **File** menu, create a new project.

    > [!NOTE]
    > The **Dataset Designer** is supported in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] and C# projects. Create the new project in one of these languages.

2. In the **New Project** dialog box, in the **Project types** pane, click **Windows**.

3. Click the **Class Library** template.

4. Name the project **DataEntityTier**.

5. Name the solution **NTierWalkthrough**.

6. Click **OK**.

     An NTierWalkthrough solution that contains the DataEntityTier project is created and added to **Solution Explorer**.

## Creating the Class Library to Hold the TableAdapters (DataAccessTier)
 The next step after you create the DataEntityTier project is to create another class library project. This project will hold the generated `TableAdapter`s and is called the *data access tier* of the application. The data access tier contains the information that is required to connect to the database and is typically located in the middle tier.

#### To create the new class library for the TableAdapters

1. From the **File** menu, add a new project to the NTierWalkthrough solution.

2. In the **New Project** dialog box, in the **Templates** pane, click **Class Library**.

3. Name the project **DataAccessTier** and click **OK**.

     The DataAccessTier project is created and added to the NTierWalkthrough solution.

## Creating the Dataset
 The next step is to create a typed dataset. Typed datasets are created with both the dataset class (including DataTables classes) and the `TableAdapter` classes in a single project. (All classes are generated into a single file.) When you separate the dataset and `TableAdapter`s into different projects, it is the dataset class that is moved to the other project, leaving the `TableAdapter` classes in the original project. Therefore, create the dataset in the project that will ultimately contain the `TableAdapter`s (the DataAccessTier project). You will create the dataset by using the **Data Source Configuration Wizard**.

> [!NOTE]
> You must have access to the Northwind sample database to create the connection.

#### To create the dataset

1. Click DataAccessTier in **Solution Explorer**.

2. On the **Data** menu, click **Show Data Sources**.

3. In the **Data Sources** window, click **Add New Data Source** to start the **Data Source Configuration Wizard**.

4. On the **Choose a Data Source Type** page, click **Database** and then click **Next**.

5. On the **Choose Your Data Connection** page, perform one of the following actions:

     If a data connection to the Northwind sample database is available in the drop-down list, click it.

     -or-

     Click **New Connection** to open the **Add Connection** dialog box.

6. If the database requires a password, select the option to include sensitive data, and then click **Next**.

    > [!NOTE]
    > If you selected a local database file (instead of connecting to SQL Server) you might be asked if you want to add the file to the project. Click **Yes** to add the database file to the project.

7. Click **Next** on the **Save the Connection String to the Application Configuration File** page.

8. Expand the **Tables** node on the **Choose Your Database Objects** page.

9. Click the check boxes for the **Customers** and **Orders** tables, and then click **Finish**.

     NorthwindDataSet is added to the DataAccessTier project and appears in the **Data Sources** window.

## Separating the TableAdapters from the Dataset
 After you create the dataset, separate the generated dataset class from the TableAdapters. You do this by setting the **DataSet Project** property to the name of the project in which to store the separated out dataset class.

#### To separate the TableAdapters from the Dataset

1. Double-click **NorthwindDataSet.xsd** in **Solution Explorer** to open the dataset in the **Dataset Designer**.

2. Click an empty area on the designer.

3. Locate the **DataSet Project** node in the **Properties** window.

4. In the **DataSet Project** list, click **DataEntityTier**.

5. On the **Build** menu, click **Build Solution**.

   The dataset and TableAdapters are separated into the two class library projects. The project that originally contained the whole dataset (DataAccessTier) now contains only the TableAdapters. The project designated in the **DataSet Project** property (DataEntityTier) contains the typed dataset: NorthwindDataSet.Dataset.Designer.vb (or NorthwindDataSet.Dataset.Designer.cs).

> [!NOTE]
> When you separate datasets and TableAdapters (by setting the **DataSet Project** property), existing partial dataset classes in the project will not be moved automatically. Existing dataset partial classes must be manually moved to the dataset project.

## Creating a New Service Application
 Because this walkthrough demonstrates how to access the data access tier by using a WCF service, create a new WCF service application.

#### To create a new WCF Service application

1. From the **File** menu, add a new project to the NTierWalkthrough solution.

2. In the **New Project** dialog box, in the **Project types** pane, click **WCF**. In the **Templates** pane, click **WCF Service Library**.

3. Name the project **DataService** and click **OK**.

     The DataService project is created and added to the NTierWalkthrough solution.

## Creating Methods in the Data Access Tier to Return the Customers and Orders Data
 The data service has to call two methods in the data access tier: GetCustomers and GetOrders. These methods will return the Northwind Customers and Orders tables. Create the GetCustomers and GetOrders methods in the DataAccessTier project.

#### To create a method in the data access tier that returns the Customers table

1. In **Solution Explorer**, double-click NorthwindDataset.xsd to open the dataset in the Dataset Designer.

2. Right-click CustomersTableAdapter and click **Add Query** to edit the Tableadapter.

3. On the **Choose a Command Type** page, leave the default value of **Use SQL statements** and click **Next**.

4. On the **Choose a Query Type** page, leave the default value of **SELECT which returns rows** and click **Next**.

5. On the **Specify a SQL SELECT statement** page, leave the default query and click **Next**.

6. On the **Choose Methods to Generate** page, type **GetCustomers** for the **Method name** in the **Return a DataTable** section.

7. Click **Finish**.

#### To create a method in the data access tier that returns the Orders table

1. Right-click OrdersTableAdapter and click **Add Query**.

2. On the **Choose a Command Type** page, leave the default value of **Use SQL statements** and click **Next**.

3. On the **Choose a Query Type** page, leave the default value of **SELECT which returns rows** and click **Next**.

4. On the **Specify a SQL SELECT statement** page, leave the default query and click **Next**.

5. On the **Choose Methods to Generate** page, type **GetOrders** for the **Method name** in the **Return a DataTable** section.

6. Click **Finish**.

7. On the **Build** menu, click **Build Solution**.

## Adding a Reference to the Data Entity and Data Access Tiers to the Data Service
 Because the data service requires information from the dataset and TableAdapters, add references to the DataEntityTier and DataAccessTier projects.

#### To add references to the data service

1. Right-click DataService in **Solution Explorer** and click **Add Reference**.

2. Click the **Projects** tab in the **Add Reference** dialog box.

3. Select both the **DataAccessTier** and **DataEntityTier** projects.

4. Click **OK**.

## Adding Functions to the Service to Call the GetCustomers and GetOrders Methods in the Data Access Tier
 Now that the data access tier contains the methods to return data, create methods in the data service to call the methods in the data access tier.

> [!NOTE]
> For C# projects, you must add a reference to the `System.Data.DataSetExtensions` assembly for the following code to compile.

#### To create the GetCustomers and GetOrders functions in the data service

1. In the **DataService** project, double-click IService1.vb or IService1.cs.

2. Add the following code under the **Add your service operations here** comment:

    ```vb
    <OperationContract()> _
    Function GetCustomers() As DataEntityTier.NorthwindDataSet.CustomersDataTable

    <OperationContract()> _
    Function GetOrders() As DataEntityTier.NorthwindDataSet.OrdersDataTable
    ```

    ```csharp
    [OperationContract]
    DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers();

    [OperationContract]
    DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders();

    ```

3. In the DataService project, double-click Service1.vb (or Service1.cs).

4. Add the following code to the Service1 class:

    ```vb
    Public Function GetCustomers() As DataEntityTier.NorthwindDataSet.CustomersDataTable Implements IService1.GetCustomers
        Dim CustomersTableAdapter1 As New DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter
        Return CustomersTableAdapter1.GetCustomers()
    End Function

    Public Function GetOrders() As DataEntityTier.NorthwindDataSet.OrdersDataTable Implements IService1.GetOrders
        Dim OrdersTableAdapter1 As New DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter
        Return OrdersTableAdapter1.GetOrders()
    End Function
    ```

    ```csharp
    public DataEntityTier.NorthwindDataSet.CustomersDataTable GetCustomers()
    {
        DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter
             CustomersTableAdapter1
            = new DataAccessTier.NorthwindDataSetTableAdapters.CustomersTableAdapter();
        return CustomersTableAdapter1.GetCustomers();

    }
    public DataEntityTier.NorthwindDataSet.OrdersDataTable GetOrders()
    {
        DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter
             OrdersTableAdapter1
            = new DataAccessTier.NorthwindDataSetTableAdapters.OrdersTableAdapter();
        return OrdersTableAdapter1.GetOrders();

    }
    ```

5. On the **Build** menu, click **Build Solution**.

## Creating a Presentation Tier to Display Data from the Data Service
 Now that the solution contains the data service that has methods that call into the data access tier, create another project that will call into the data service and present the data to users. For this walkthrough, create a Windows Forms application; this is the presentation tier of the n-tier application.

#### To create the presentation tier project

1. From the **File** menu, add a new project to the NTierWalkthrough solution.

2. In the **New Project** dialog box, in the **Project types** pane, click **Windows**. In the **Templates** pane, click **Windows Forms Application**.

3. Name the project **PresentationTier** and click **OK**.

4. The PresentationTier project is created and added to the NTierWalkthrough solution.

## Setting the PresentationTier Project as the Startup Project
 Because the presentation tier is the actual client application that is used to present and interact with the data, you must set the PresentationTier project to be the Startup project.

#### To set the new presentation tier project as the Startup project

- In **Solution Explorer**, right-click **PresentationTier** and click **Set as StartUp Project**.

## Adding References to the Presentation Tier
 The client application PresentationTier requires a service reference to the data service in order to access the methods in the service. In addition, a reference to the dataset is required to enable type sharing by the WCF service. Until you enable type sharing through the data service, code added to the partial dataset class will not be available to the presentation tier. Because you typically add code such as validation to the row and column changing events of a data table, it is likely that you will want to access this code from the client.

#### To add a reference to the presentation tier

1. In **Solution Explorer**, right-click PresentationTier and click **Add Reference**.

2. In the **Add Reference** dialog box, click the **Projects** tab.

3. Select **DataEntityTier** and click **OK**.

#### To add a service reference to the presentation tier

1. In **Solution Explorer**, right-click PresentationTier and click **Add Service Reference**.

2. In the **Add Service Reference** dialog box, click **Discover**.

3. Select **Service1** and click **OK**.

    > [!NOTE]
    > If you have multiple services on the current computer, select the service that you created previously in this walkthrough (the service that contains the GetCustomers and GetOrders methods).

## Adding DataGridViews to the Form to Display the Data Returned by the Data Service
 After you add the service reference to the data service, the **Data Sources** window is automatically populated with the data that is returned by the service.

#### To add two data bound DataGridViews to the form

1. In **Solution Explorer**, select the PresentationTier project.

2. In the **Data Sources** window, expand **NorthwindDataSet** and locate the **Customers** node.

3. Drag the **Customers** node onto Form1.

4. In the **Data Sources** window, expand the **Customers** node and locate the related **Orders** node (the **Orders** node nested in the **Customers** node).

5. Drag the related **Orders** node onto Form1.

6. Create a `Form1_Load` event handler by double-clicking an empty area of the form.

7. Add the following code to the `Form1_Load` event handler.

    ```vb
    Dim DataSvc As New ServiceReference1.Service1Client
    NorthwindDataSet.Customers.Merge(DataSvc.GetCustomers)
    NorthwindDataSet.Orders.Merge(DataSvc.GetOrders)
    ```

    ```csharp
    ServiceReference1.Service1Client DataSvc =
        new ServiceReference1.Service1Client();
    northwindDataSet.Customers.Merge(DataSvc.GetCustomers());
    northwindDataSet.Orders.Merge(DataSvc.GetOrders());

    ```

## Increasing the Maximum Message Size Allowed by the Service
 Because the service returns data from the Customers and Orders tables, the default value for maxReceivedMessageSize is not large enough to hold the data and must be increased. For this walkthrough, you will change the value to 6553600. You will change the value on the client, and this will automatically update the service reference.

> [!NOTE]
> The lower default size is intended to limit exposure to denial of service (DoS) attacks. For more information, see <xref:System.ServiceModel.WSHttpBindingBase.MaxReceivedMessageSize%2A>.

#### To increase the maxReceivedMessageSize value

1. In **Solution Explorer**, double-click the app.config file in the PresentationTier project.

2. Locate the **maxReceivedMessage** size attribute and change the value to `6553600`.

## Testing the Application
 Run the application. The data is retrieved from the data service and displayed on the form.

#### To test the application

1. Press F5.

2. The data from the Customers and Orders tables is retrieved from the data service and displayed on the form.

## Next Steps
 Depending on your application requirements, there are several steps that you may want to perform after you save related data in the Windows-based application. For example, you could make the following enhancements to this application:

- Add validation to the dataset. For information, see [Walkthrough: Adding Validation to an N-Tier Data Application](https://msdn.microsoft.com/library/b35d072c-31f0-49ba-a225-69177592c265).

- Add additional methods to the service for updating data back to the database.

## See Also
 [Work with datasets in n-tier applications](../data-tools/work-with-datasets-in-n-tier-applications.md)
 [Hierarchical update](../data-tools/hierarchical-update.md)
 [Accessing data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
