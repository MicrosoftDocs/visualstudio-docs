---
title: Pass data between forms controls (.NET Framework)
description: Pass data between Windows Forms controls in .NET Framework application development with Visual Studio and create a TableAdapter query to fetch customer orders.
ms.date: 12/15/2023
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
---

# Pass data between forms

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

This tutorial provides step-by-step instructions for passing data from one form to another. Using the customers and orders tables from Northwind, one form allows users to select a customer, and a second form displays the selected customer's orders. This tutorial shows how to create a method on the second form that receives data from the first form.

> [!NOTE]
> This tutorial demonstrates only one way to pass data between forms. There are other options for passing data to a form, including creating a second constructor to receive data, or creating a public property that can be set with data from the first form.

Tasks illustrated in this tutorial include:

- Creating a new **Windows Forms App (.NET Framework)** project.

- Creating and configuring a dataset with the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).

- Selecting the control to be created on the form when dragging items from the **Data Sources** window. For more information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

- Creating a data-bound control by dragging items from the **Data Sources** window onto a form.

- Creating a second form with a grid to display data.

- Creating a TableAdapter query to fetch orders for a specific customer.

- Passing data between forms.

## Prerequisites

To complete this tutorial, you need the **.NET desktop development** and **Data storage and processing** workloads installed in Visual Studio. To install them, open **Visual Studio Installer** and choose **Modify** (or **More** > **Modify**) next to the version of Visual Studio you want to modify. See [Modify Visual Studio](../install/modify-visual-studio.md).

This tutorial uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the Visual Studio Installer, SQL Server Express LocalDB can be installed as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the Visual Studio Installer.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create the Windows Forms app project

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **PassingDataBetweenForms**, and then choose **OK**.

     The **PassingDataBetweenForms** project is created, and added to **Solution Explorer**.

## Create the data source

1. To open the **Data Sources** window, on the **Data** menu, click **Show Data Sources**.

2. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

3. Select **Database** on the **Choose a Data Source Type** page, and then select **Next**.

4. On the **Choose a database model** page, verify that **Dataset** is specified, and then select **Next**.

5. On the **Choose your Data Connection** page, do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

6. If your database requires a password and if the option to include sensitive data is enabled, select the option, and then select **Next**.

7. On the **Save connection string to the Application Configuration file** page, click **Next**.

8. On the **Choose your Database Objects** page, expand the **Tables** node.

9. Select the **Customers** and **Orders** tables, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the **Customers** and **Orders** tables appear in the **Data Sources** window.

## Create the first form (Form1)

You can create a data-bound grid (a <xref:System.Windows.Forms.DataGridView> control), by dragging the **Customers** node from the **Data Sources** window onto the form.

### To create a data-bound grid on the form

- Drag the main **Customers** node from the **Data Sources** window onto **Form1**.

     A <xref:System.Windows.Forms.DataGridView> and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on **Form1**. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

## Create the second form

Create a second form to pass data to.

1. From the **Project** menu, choose **Add Windows Form**.

2. Leave the default name of **Form2**, and click **Add**.

3. Drag the main **Orders** node from the **Data Sources** window onto **Form2**.

     A <xref:System.Windows.Forms.DataGridView> and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on **Form2**. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

4. Delete the **OrdersBindingNavigator** from the component tray.

     The **OrdersBindingNavigator** disappears from **Form2**.

## Add a TableAdapter query

Add a TableAdapter query to Form2 to load orders for the selected customer on Form1.

1. Double-click the **NorthwindDataSet.xsd** file in **Solution Explorer**.

2. Right-click the **OrdersTableAdapter**, and select **Add Query**.

3. Leave the default option of **Use SQL statements**, and then select **Next**.

4. Leave the default option of **SELECT which returns rows**, and then select **Next**.

5. Add a `WHERE` clause to the query, to return `Orders` based on the `CustomerID`. The query should be similar to the following:

    ```sql
    SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry
    FROM Orders
    WHERE CustomerID = @CustomerID
    ```

    > [!NOTE]
    > Verify the correct parameter syntax for your database. For example, in Microsoft Access, the `WHERE` clause would look like: `WHERE CustomerID = ?`.

6. Click **Next**.

7. For the **Fill a DataTableMethod Name**, type `FillByCustomerID`.

8. Clear the **Return a DataTable** option, and then select **Next**.

9. Click **Finish**.

## Create a method on Form2 to pass data to

1. Right-click **Form2**, and select **View Code** to open **Form2** in the **Code Editor**.

2. Add the following code to **Form2** after the `Form2_Load` method:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form2.cs" id="Snippet1":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form2.vb" id="Snippet1":::
---

## Create a method on Form1 to pass data and display Form2

1. In **Form1**, right-click the Customer data grid, and then select **Properties**.

2. In the **Properties** window, click **Events**.

3. Double-click the **CellDoubleClick** event.

     The code editor appears.

4. Update the method definition to match the following sample:

### [C#](#tab/csharp)

:::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataDisplaying/CS/Form1.cs" id="Snippet2":::

### [VB](#tab/vb)

:::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataDisplaying/VB/Form1.vb" id="Snippet2":::
---

## Run the app

- Press **F5** to run the application.

- Double-click a customer record in **Form1** to open **Form2** with that customer's orders.

## Next steps

Depending on your application requirements, there are several steps you might want to perform after passing data between forms. Some enhancements you could make to this tutorial include:

- Editing the dataset to add or remove database objects. For more information, see [Create and configure datasets](../data-tools/create-and-configure-datasets-in-visual-studio.md).

- Adding functionality to save data back to the database. For more information, see [Save data back to the database](../data-tools/save-data-back-to-the-database.md).

## Related content

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
