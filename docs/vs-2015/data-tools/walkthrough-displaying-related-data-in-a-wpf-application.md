---
title: "Walkthrough: Displaying Related Data in a WPF Application | Microsoft Docs"
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
  - "WPF, data binding in Visual Studio"
  - "WPF data binding [Visual Studio], walkthroughs"
  - "WPF Designer, data binding"
ms.assetid: 5c48f188-e9c4-40a6-97d9-67cdb2f90127
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
robots: noindex,nofollow
---
# Walkthrough: Displaying Related Data in a WPF Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you will create a WPF application that displays data from database tables that have a parent/child relationship. The data is encapsulated in entities in an Entity Data Model. The parent entity contains overview information for a set of orders. Each property of this entity is bound to a different control in the application. The child entity contains details for each order. This set of data is bound to a <xref:System.Windows.Controls.DataGrid> control.

 This walkthrough illustrates the following tasks:

- Creating a WPF application and an Entity Data Model that is generated from data in the AdventureWorksLT sample database.

- Creating a set of data-bound controls that display overview information for a set of orders. You create the controls by dragging a parent entity from the **Data Sources** window to **the WPF Designer**.

- Creating a <xref:System.Windows.Controls.DataGrid> control that displays related details for each selected order. You create the controls by dragging a child entity from the **Data Sources** window to a window in **the WPF designer**.

   [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

- Access to a running instance of SQL Server or SQL Server Express that has the AdventureWorksLT sample database attached to it. You can download the AdventureWorksLT database from the [CodePlex Web site](https://go.microsoft.com/fwlink/?linkid=87843).

  Prior knowledge of the following concepts is also helpful, but not required to complete the walkthrough:

- Entity Data Models and the ADO.NET Entity Framework. For more information, see [Entity Framework Overview](https://msdn.microsoft.com/library/a2166b3d-d8ba-4a0a-8552-6ba1e3eaaee0).

- Working with the WPF Designer. For more information, see [WPF and Silverlight Designer Overview](https://msdn.microsoft.com/570b7a5c-0c86-4326-a371-c9b63378fc62).

- WPF data binding. For more information, see [Data Binding Overview](https://msdn.microsoft.com/library/c707c95f-7811-401d-956e-2fffd019a211).

## Creating the Project
 Create a new WPF project to display the order records.

#### To create a new WPF project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then click **Project**.

3. Expand **Visual C#** or **Visual Basic**, and then select **Windows**.

4. Make sure that **.NET Framework 4** is selected in the combo box at the top of the dialog box. The <xref:System.Windows.Controls.DataGrid> control that you use in this walkthrough is available only in the .NET Framework 4.

5. Select the **WPF Application** project template.

6. In the **Name** box, type `AdventureWorksOrdersViewer`.

7. Click **OK**.

     Visual Studio creates the `AdventureWorksOrdersViewer` project.

## Creating an Entity Data Model for the Application
 Before you can create data-bound controls, you must define a data model for your application and add it to the **Data Sources** window. In this walkthrough, the data model is an Entity Data Model.

#### To create an Entity Data Model

1. On the **Data** menu, click **Add New Data Source** to open the **Data Source Configuration Wizard**.

2. On the **Choose a Data Source Type** page, click **Database**, and then click **Next**.

3. On the **Choose a Database Model** page, click **Entity Data Model**, and then click **Next**.

4. On the **Choose Model Contents** page, click **Generate from database**, and then click **Next**.

5. On the **Choose Your Data Connection** page, do one of the following:

   - If a data connection to the AdventureWorksLT sample database is available in the drop-down list, select it.

      -or-

   - Click **New Connection** and create a connection to the AdventureWorksLT database.

     Make sure that the **Save entity connection settings in App.Config as** option is selected, and then click **Next**.

6. On the **Choose Your Database Objects** page, expand **Tables**, and then select the following tables:

   - **SalesOrderDetail**

   - **SalesOrderHeader**

7. Click **Finish**.

8. Build the project.

## Creating Data-Bound Controls that Display the Orders
 Create controls that display order records by dragging the `SalesOrderHeaders` entity from the **Data Sources** window to the WPF designer.

#### To create data-bound controls that display the order records

1. In **Solution Explorer**, double-click MainWindow.xaml.

    The window opens in the WPF designer.

2. Edit the XAML so the **Height** and **Width** properties are set to 800

3. In the **Data Sources** window, click the drop-down menu for the **SalesOrderHeaders** node and select **Details**.

4. Expand the **SalesOrderHeaders** node.

5. Click the drop-down menu next to **SalesOrderID** and select **ComboBox**.

6. For each of the following child nodes of the **SalesOrderHeaders** node, click the drop-down menu next the node and select **None**:

   - **RevisionNumber**

   - **OnlineOrderFlag**

   - **ShipToAddressID**

   - **BillToAddressID**

   - **CreditCardApprovalCode**

   - **SubTotal**

   - **TaxAmt**

   - **Freight**

   - **rowguid**

   - **ModifiedDate**

     This action prevents Visual Studio from creating data-bound controls for these nodes in the next step. For this walkthrough, it is assumed that the end user does not need to see this data.

7. From the **Data Sources** window, drag the **SalesOrderHeaders** node to the window in **the WPF Designer**.

    Visual Studio generates XAML that creates a set of controls that are bound to data in the **SalesOrderHeaders** entity, and code that loads the data. For more information about the generated XAML and code, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

8. In the designer, click the combo box next to the **Sales Order ID** label.

9. In the **Properties** window, select the check box next to the **IsReadOnly** property.

## Creating a DataGrid that Displays the Order Details
 Create a <xref:System.Windows.Controls.DataGrid> control that displays order details by dragging the `SalesOrderDetails` entity from the **Data Sources** window to the WPF designer.

#### To create a DataGrid that displays the order details

1. In the **Data Sources** window, locate the **SalesOrderDetails** node that is a child of the **SalesOrderHeaders** node.

   > [!NOTE]
   > There is also a **SalesOrderDetails** node that is a peer of the **SalesOrderHeaders** node. Make sure that you select the child node of the **SalesOrderHeaders** node.

2. Expand the child **SalesOrderDetails** node.

3. For each of the following child nodes of the **SalesOrderDetails** node, click the drop-down menu next the node and select **None**:

   - **SalesOrderID**

   - **SalesOrderDetailID**

   - **rowguid**

   - **ModifiedDate**

     This action prevents Visual Studio from including this data in the <xref:System.Windows.Controls.DataGrid> control you create in the next step. For this walkthrough, it is assumed that the end user does not need to see this data.

4. From the **Data Sources** window, drag the child **SalesOrderDetails** node to the window in **the WPF Designer**.

    Visual Studio generates XAML to define a new data-bound <xref:System.Windows.Controls.DataGrid> control, and the control appears in the designer. Visual Studio also updates the generated `GetSalesOrderHeadersQuery` method in the code-behind file to include the data in the **SalesOrderDetails** entity.

## Testing the Application
 Build and run the application to verify that it displays the order records.

#### To test the application

1. Press **F5**.

     The application builds and runs. Verify the following:

    - The **Sales Order ID** combo box displays **71774**. This is the first order ID in the entity.

    - For each order you select in the **Sales Order ID** combo box, detailed order information is displayed in the <xref:System.Windows.Controls.DataGrid>.

2. Close the application.

## Next Steps
 After completing this walkthrough, learn how to use the **Data Sources** window in Visual Studio to bind WPF controls to other types of data sources. For more information, see [Bind WPF controls to a WCF data service](../data-tools/bind-wpf-controls-to-a-wcf-data-service.md) and [Bind WPF controls to a dataset](../data-tools/bind-wpf-controls-to-a-dataset.md).

## See Also
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md)
 [Display related data in WPF applications](../data-tools/display-related-data-in-wpf-applications.md)