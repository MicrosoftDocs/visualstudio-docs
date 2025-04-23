---
title: Pass data between forms (.NET Framework)
description: Pass data between Windows Forms in .NET Framework application development with Visual Studio and create a TableAdapter query to fetch customer orders.
ms.date: 04/22/2025
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- walkthroughs [Windows Forms], data
- walkthroughs [Visual Studio], data
- data [Visual Studio], passing between forms
- forms, passing data between
- Windows Forms, walkthroughs
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools

#customer intent: I want to know how to pass dataset data between forms in a Windows Forms (.NET Framework) application so that I understand one way to pass data between forms.
---

# Pass data between forms

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This tutorial provides step-by-step instructions for passing data from one form to another. Using the Customers and Orders tables from the Northwind sample database, one form allows users to select a customer, and a second form displays the selected customer's orders. This tutorial shows how to create a method on the second form that receives data from the first form.

In this tutorial, you complete the following tasks:

- Create a new **Windows Forms App (.NET Framework)** project.
- Create and configure a dataset by using the **Data Source Configuration Wizard**.
- Select the control to create on the form when you drag items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).
- Create a data-bound control by dragging items from the **Data Sources** window onto a form.
- Create a second form with a grid to display data.
- Create a `TableAdapter` query to fetch orders for a specific customer.
- Pass data between forms.

>[!NOTE]
>This tutorial demonstrates only one way to pass data between forms. There are other options for passing data to a form, such as creating a second constructor to receive data, or creating a public property that can be set with data from the first form.

## Prerequisites

- The **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify**, or **More** > **Modify**, next to the version of Visual Studio you want to use. For more information, see [Modify Visual Studio](../install/modify-visual-studio.md).

- SQL Server Express 2019 LocalDB installed either from the [SQL Server downloads page](https://www.microsoft.com/sql-server/sql-server-downloads), or through the **Visual Studio Installer** as part of the **Data storage and processing** workload.

- The Northwind sample database, created by following these steps:

  1. In Visual Studio, open the **SQL Server Object Explorer** window by selecting it from the **View** menu. SQL Server Object Explorer is installed as part of the **Data storage and processing** workload.

  1. Expand the **SQL Server** node, right-click your LocalDB instance, and select **New Query** to open a query editor window.

  1. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database and populates it with data.

  1. Paste the T-SQL script into the query editor, and then select **Execute** at the top of the window to create the Northwind database.

## Create the Windows Forms app project

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

1. Select either **C#** or **Visual Basic** from the **All languages** dropdown list, **Windows** from the **All platforms** dropdown list, and **Desktop** from the **All project types** list.

1. Select **Windows Forms App (.NET Framework)** from the project templates list, and then select **Next**.

1. Name the project **PassingDataBetweenForms**, select **Next**, and then select **Create**.

The **PassingDataBetweenForms** project is created and added to **Solution Explorer**. The designer view of **Form1** appears in the editor.

## Create the data source

1. Open the **Data Sources** window by selecting **Project** > **Add New Data Source** on the Visual Studio menu.

1. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

1. On the **Choose a Data Source Type** page, select **Database**, and then select **Next**.

1. On the **Choose a Database Model** page, verify that **Dataset** is specified and select **Next**.

1. On the **Choose Your Data Connection** page, if a data connection to the Northwind sample database is already available, select it, and proceed to the **Choose your Database Objects** step. Otherwise, select **New Connection**.

1. On the **Choose Data Source** screen, select **Microsoft SQL Server Database File**, and then select **Continue**.

1. On the **Add Connection** screen, select **Browse**, browse to and select the *northwnd.mdf* file, and select **Open**.

1. Either select **Windows Authentication**, or select **SQL Server Authentication** and supply a user name and password to access the database.

1. Select **Test Connection** to test the connection. When the connection succeeds, select **OK**.

1. On the **Choose Your Data Connection** page, confirm that the database file appears and select **Next**.

1. Select **No** to the popup question **Would you like to copy the file to your project and modify the connection?**

1. On the **Save the Connection String to the Application Configuration file** page, select **Yes**. Name the connection *NorthwindConnectionString*, and then select **Next**.

1. On the **Choose your Database Objects** page, expand the **Tables** node, select the **Customers** and **Orders** tables, name the dataset *NorthwindDataSet*, and then select **Finish**.

The **NorthwindDataSet** is added to your project, and the **Customers** and **Orders** tables appear in the **Data Sources** window.

## Populate the first form

- To create a data-bound grid, drag the **Customers** node from the **Data Sources** window onto **Form1**.

  A <xref:System.Windows.Forms.DataGridView> control and a <xref:System.Windows.Forms.BindingNavigator> tool strip for navigating records appear on **Form1**. A [NorthwindDataSet](dataset-tools-in-visual-studio.md), `CustomersTableAdapter`, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

## Create the second form

Create a second form to pass data to.

1. From the **Project** menu, choose **Add Form (Windows Forms)**.

1. Leave the default name of **Form2**, and select **Add**.

1. Drag the main **Orders** node from the **Data Sources** window onto **Form2**.

   A <xref:System.Windows.Forms.DataGridView> and a <xref:System.Windows.Forms.BindingNavigator> tool strip for navigating records appear on **Form2**. A [NorthwindDataSet](dataset-tools-in-visual-studio.md), `CustomersTableAdapter`, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

1. Delete the **OrdersBindingNavigator** from the component tray. The **BindingNavigator** disappears from **Form2**.

## Add a TableAdapter query

Add a `TableAdapter` query to Form2 that loads orders for the customer selected on Form1.

1. Double-click the **NorthwindDataSet.xsd** file in **Solution Explorer**.

1. Right-click **OrdersTableAdapter** in the **Orders** table, and select **Add** > **Query**.

1. Leave the default option of **Use SQL statements** and select **Next**.

1. Leave the default option of **SELECT which returns rows** and select **Next**.

1. In **What data should the table load**, to return `Orders` based on the `CustomerID`, add a `WHERE` clause to the end of the query. The query should look similar to the following:

   ```sql
   SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry
   FROM Orders
   WHERE CustomerID = @CustomerID
   ```

   > [!NOTE]
   > Use the correct parameter syntax for your database. For example, in Microsoft Access, the `WHERE` clause would look like `WHERE CustomerID = ?`.

1. Select **Next**.

1. On the **Choose Methods to Generate** screen, select **Fill a DataTable** and enter *FillByCustomerID*.

1. Deselect the **Return a DataTable** option, and then select **Finish**.

## Create a method on Form2 to pass data to

1. Right-click in **Form2** and select **View Code** to open the **Form2** code in the editor.

1. In the **Form2** code, remove the contents of the `Form2_Load` method, and add the following code after the `Form2_Load` method:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form2.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form2.vb" id="Snippet1":::
---

## Create a method on Form1 to pass data and display Form2

1. In the Designer view of **Form1**, right-click the Customer data grid, and then select **Properties**.

1. In the **Properties** window, select the **Events** icon in the top toolbar.

1. Double-click the **DoubleClick** event to open the code editor.

1. In the code editor, update the method definition to match the following sample:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs" id="Snippet2":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb" id="Snippet2":::
---

## Run and test the app

1. Press **F5** to run the application.

1. In the application, double-click a customer record in **Form1** to open **Form2** with that customer's orders.

## Next steps

Depending on your application requirements, you can do several steps after passing data between forms. Some enhancements you could make to this tutorial include:

- Editing the dataset to add or remove database objects. For more information, see [Create and configure datasets](create-and-configure-datasets-in-visual-studio.md).

- Adding functionality to save data back to the database. For more information, see [Save data back to the database](save-data-back-to-the-database.md).

## Related content

- [Bind Windows Forms controls to data in Visual Studio](bind-windows-forms-controls-to-data-in-visual-studio.md)
