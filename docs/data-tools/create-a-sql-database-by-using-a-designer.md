---
title: Create a database file and use table designer
description: Tutorial that describes how to add tables and foreign keys to a database by using Table Designer in Visual Studio. It also shows how to add data through the graphical interface.
ms.date: 11/03/2017
ms.topic: conceptual
helpviewer_keywords:
  - "database tables, creating"
  - "database files, creating"
  - "table designer"
ms.assetid: 99c2b06f-47aa-414e-8057-a3453712fd23
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "data-storage"
---
# Create a database and add tables in Visual Studio

You can use Visual Studio to create and update a local database file in SQL Server Express LocalDB. You can also create a database by executing Transact-SQL statements in the **SQL Server Object Explorer** tool window in Visual Studio. In this topic, we'll create an *.mdf* file and add tables and keys by using the Table Designer.

## Prerequisites

To complete this walkthrough, you must have the optional **Data storage and processing** workload installed in Visual Studio. To install it, open **Visual Studio Installer** and choose the **Workloads** tab. Under **Web & Cloud**, choose **Data storage and processing**. Choose the **Modify** button to add the workload to Visual Studio.

## Create a project and a local database file

1. Create a Windows Forms project that's named **SampleDatabaseWalkthrough**.

2. On the menu bar, select **Project** > **Add New Item**.

3. In the list of item templates, scroll down and select **Service-based Database**.

     ![Item Templates dialog box](../data-tools/media/raddata-vsitemtemplates.png)

4. Name the database **SampleDatabase**, and then select the **Add** button.

### Add a data source

1. If the **Data Sources** window isn't open, open it by pressing **Shift**+**Alt**+**D** or selecting **View** > **Other Windows** > **Data Sources** on the menu bar.

1. In the **Data Sources** window, select the **Add New Data Source** link.

   The **Data Source Configuration Wizard** opens.

1. On the **Choose a Data Source Type** page, choose **Database** and then choose **Next**.

1. On the **Choose a Database Model** page, choose **Next** to accept the default (Dataset).

1. On the **Choose Your Data Connection** page, select the **SampleDatabase.mdf** file in the drop-down list, and then choose **Next**.

1. On the **Save the Connection String to the Application Configuration File** page, choose **Next**.

1. One the **Choose your Database Objects** page, you'll see a message that says the database doesn't contain any objects. Choose **Finish**.

### View properties of the data connection

You can view the connection string for the *SampleDatabase.mdf* file by opening the properties window of the data connection:

- In Visual Studio, select **View** > **SQL Server Object Explorer** if that window isn't already open. Open the properties window by expanding the **Data Connections** node, opening the shortcut menu for *SampleDatabase.mdf*, and then selecting **Properties**.

- Alternatively, you can select **View** > **Server Explorer**, if that window isn't already open. Open the properties window by expanding the **Data Connections** node. Open the shortcut menu for *SampleDatabase.mdf*, and then select **Properties**.

## Create tables and keys by using Table Designer

In this section, you'll create two tables, a primary key in each table, and a few rows of sample data. You'll also create a foreign key to specify how records in one table correspond to records in the other table.

### Create the Customers table

1. In **Server Explorer** or **SQL Server Object Explorer**, expand the **Data Connections** node, and then expand the **SampleDatabase.mdf** node.

2. Open the shortcut menu for **Tables**, and then select **Add New Table**.

     The **Table Designer** opens and shows a grid with one default row, which represents a single column in the table that you're creating. By adding rows to the grid, you'll add columns in the table.

3. In the grid, add a row for each of the following entries:

    |Column name|Data type|Allow nulls|
    |-----------------|---------------|-----------------|
    |`CustomerID`|`nchar(5)`|False (cleared)|
    |`CompanyName`|`nvarchar(50)`|False (cleared)|
    |`ContactName`|`nvarchar (50)`|True (selected)|
    |`Phone`|`nvarchar (24)`|True (selected)|

4. Open the shortcut menu for the `CustomerID` row, and then select **Set Primary Key**.

5. Open the shortcut menu for the default row, and then select **Delete**.

6. Name the Customers table by updating the first line in the script pane to match the following sample:

    ```sql
    CREATE TABLE [dbo].[Customers]
    ```

    You should see something like this:

    ![Table Designer](../data-tools/media/raddata-table-designer.png)

7. In the upper-left corner of the **Table Designer**, select the **Update** button.

8. In the **Preview Database Updates** dialog box, select the **Update Database** button.

    Your changes are saved to the local database file.

### Create the Orders table

1. Add another table, and then add a row for each entry in the following table:

    |Column name|Data type|Allow nulls|
    |-----------------|---------------|-----------------|
    |`OrderID`|`int`|False (cleared)|
    |`CustomerID`|`nchar(5)`|False (cleared)|
    |`OrderDate`|`datetime`|True (selected)|
    |`OrderQuantity`|`int`|True (selected)|

2. Set **OrderID** as the primary key, and then delete the default row.

3. Name the Orders table by updating the first line in the script pane to match the following sample:

    ```sql
    CREATE TABLE [dbo].[Orders]
    ```

4. In the upper-left corner of the **Table Designer**, select the **Update** button.

5. In the **Preview Database Updates** dialog box, select the **Update Database** button.

    Your changes are saved to the local database file.

### Create a foreign key

1. In the context pane on the right side of the grid, open the shortcut menu for **Foreign Keys**, and then select **Add New Foreign Key**, as the following illustration shows.

     ![Adding a foreign key in Table Designer](../data-tools/media/foreignkey.png)

2. In the text box that appears, replace **ToTable** with **Customers**.

3. In the T-SQL pane, update the last line to match the following sample:

    ```sql
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerID]) REFERENCES [Customers]([CustomerID])
    ```

4. In the upper-left corner of the **Table Designer**, select the **Update** button.

5. In the **Preview Database Updates** dialog box, select the **Update Database** button.

    Your changes are saved to the local database file.

## Populate the tables with data

1. In **Server Explorer** or **SQL Server Object Explorer**, expand the node for the sample database.

2. Open the shortcut menu for the **Tables** node, select **Refresh**, and then expand the **Tables** node.

3. Open the shortcut menu for the Customers table, and then select **Show Table Data**.

4. Add whatever data you want for some customers.

    You can specify any five characters you want as the customer IDs, but choose at least one that you can remember for use later in this procedure.

5. Open the shortcut menu for the Orders table, and then select **Show Table Data**.

6. Add data for some orders.

    > [!IMPORTANT]
    > Make sure that all order IDs and order quantities are integers and that each customer ID matches a value that you specified in the **CustomerID** column of the Customers table.

7. On the menu bar, select **File** > **Save All**.

## See also

- [Accessing data in Visual Studio](accessing-data-in-visual-studio.md)