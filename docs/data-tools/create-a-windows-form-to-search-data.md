---
title: Create .NET Framework Windows Form to search data
description: Create a .NET Framework Windows Form to search data with ADO.NET in Visual Studio by configuring the data source, controls, and search query function.
ms.date: 06/07/2021
ms.topic: conceptual
helpviewer_keywords:
- Windows Forms, searching data
- Windows Forms, displaying data
- parameters, displaying filtered data
- data [Visual Studio], parameterizing queries
- data [Visual Studio], searching
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Create a .NET Framework Windows Form to search data with ADO.NET

[!INCLUDE [Data access tech note](./includes/data-technology-note.md)]

A common application scenario is to display selected data on a form. For example, you might want to display the orders for a specific customer or the details of a specific order. In this scenario, a user enters information into a form, and then a query is executed with the user's input as a parameter; that is, the data is selected based on a parameterized query. The query returns only the data that satisfies the criteria entered by the user. This walkthrough shows how to create a query that returns customers in a specific city, and modify the user interface so that users can enter a city's name and press a button to execute the query.

Using parameterized queries helps make your application efficient by letting the database do the work it is best at — quickly filtering records. In contrast, if you request an entire database table, transfer it over the network, and then use application logic to find the records you want, your application can become slow and inefficient.

You can add parameterized queries to any TableAdapter (and controls to accept parameter values and execute the query), using the **Search Criteria Builder** dialog box. Open the dialog box by selecting the **Add Query** command on the **Data** menu (or on any TableAdapter smart tag).

Tasks illustrated in this walkthrough include:

- Creating and configuring the data source in your application with the **Data Source Configuration** wizard.

- Setting the drop type of the items in the **Data Sources** window.

- Creating controls that display data by dragging items from the **Data Sources** window onto a form.

- Adding controls to display the data on the form.

- Completing the **Search Criteria Builder** dialog box.

- Entering parameters into the form and executing the parameterized query.

> [!NOTE]
> The procedures in this article apply only to .NET Framework Windows Forms projects, not to .NET Core Windows Forms projects.

## Prerequisites

You must have the **Data storage and processing** workload installed. See [Modify Visual Studio](../install/modify-visual-studio.md).

This walkthrough uses SQL Server Express LocalDB and the Northwind sample database.

1. If you don't have SQL Server Express LocalDB, install it either from the [SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express), or through the **Visual Studio Installer**. In the **Visual Studio Installer**, you can install SQL Server Express LocalDB as part of the **Data storage and processing** workload, or as an individual component.

2. Install the Northwind sample database by following these steps:

    1. In Visual Studio, open the **SQL Server Object Explorer** window. (SQL Server Object Explorer is installed as part of the **Data storage and processing** workload in the **Visual Studio Installer**.) Expand the **SQL Server** node. Right-click on your LocalDB instance and select **New Query**.

       A query editor window opens.

    2. Copy the [Northwind Transact-SQL script](https://github.com/MicrosoftDocs/visualstudio-docs/blob/main/docs/data-tools/samples/northwind.sql?raw=true) to your clipboard. This T-SQL script creates the Northwind database from scratch and populates it with data.

    3. Paste the T-SQL script into the query editor, and then choose the **Execute** button.

       After a short time, the query finishes running and the Northwind database is created.

## Create the Windows Forms application

Create a new **Windows Forms App (.NET Framework)** project for either C# or Visual Basic. Name the project **WindowsSearchForm**.

## Create the data source

This step creates a data source from a database using the **Data Source Configuration** wizard:

1. To open the **Data Sources** window, use quick search (**Ctrl**+**Q**), and search for **Data Sources**.

1. In the **Data Sources** window, select **Add New Data Source** to start the **Data Source Configuration** wizard.

1. Select **Database** on the **Choose a Data Source Type** page, and then select **Next**.

1. On the **Choose a Database Model** screen, choose **Dataset**, and then select **Next**.

1. On the **Choose your Data Connection** page do one of the following:

    - If a data connection to the Northwind sample database is available in the dropdown list, select it.

    - Select **New Connection** to launch the **Add/Modify Connection** dialog box.

1. On the **Save connection string to the Application Configuration file** page, click **Next**.

1. On the **Choose your Database Objects** page, expand the **Tables** node.

1. Select the **Customers** table, and then select **Finish**.

     The **NorthwindDataSet** is added to your project, and the **Customers** table appears in the **Data Sources** window.

## Create the form

You can create the data-bound controls by dragging items from the **Data Sources** window onto your form:

1. Make sure the Windows Forms designer has the active focus and the **Data Sources** window is open and pinned.

1. Expand the **Customers** node in the **Data Sources** window.

1. Drag the **Customers** node from the **Data Sources** window to your form.

     A <xref:System.Windows.Forms.DataGridView> and a tool strip (<xref:System.Windows.Forms.BindingNavigator>) for navigating records appear on the form. A [NorthwindDataSet](../data-tools/dataset-tools-in-visual-studio.md), CustomersTableAdapter, <xref:System.Windows.Forms.BindingSource>, and <xref:System.Windows.Forms.BindingNavigator> appear in the component tray.

## Add parameterization (search functionality) to the query

You can add a `WHERE` clause to the original query using the **Search Criteria Builder** dialog box:

1. Just below the design surface for your form, select the **customersTableAdapter** button, and then in the **Properties** window, choose **Add Query...**.

2. Type **FillByCity** in the **New query name** area on the **Search Criteria Builder** dialog box.

3. Add `WHERE City = @City` to the query in the **Query Text** area.

     The query should be similar to the following:

     ```sql
     SELECT CustomerID, CompanyName, ContactName, ContactTitle,
          Address, City, Region, PostalCode, Country, Phone, Fax
     FROM Customers
     WHERE City = @City
     ```

    > [!NOTE]
    > Access and OLE DB data sources use the question mark ('?') to denote parameters, so the `WHERE` clause would look like this: `WHERE City = ?`.

4. Click **OK** to close the **Search Criteria Builder** dialog box.

     A **FillByCityToolStrip** is added to the form.

## Test the application

Running the application opens your form and makes it ready to take the parameter as input:

1. Press **F5** to run the application.

2. Type **London** into the **City** text box, and then select **FillByCity**.

     The data grid is populated with customers that meet the criteria. In this example, the data grid only displays customers that have a value of **London** in their **City** column.

## Next steps

Depending on your application requirements, there are several steps you might want to perform after creating a parameterized form. Some enhancements you could make to this walkthrough include:

- Adding controls that display related data. For more information, see [Relationships in Datasets](relationships-in-datasets.md).

- Editing the dataset to add or remove database objects. For more information, see [Create and configure datasets](../data-tools/create-and-configure-datasets-in-visual-studio.md).

## Related content

- [Bind Windows Forms controls to data in Visual Studio](../data-tools/bind-windows-forms-controls-to-data-in-visual-studio.md)
