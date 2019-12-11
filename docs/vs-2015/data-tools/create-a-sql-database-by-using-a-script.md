---
title: "Create a SQL database by using a script | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
ms.assetid: 36f913c0-f5a7-4831-83a0-baba721ac95c
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create a SQL database by using a script
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this walkthrough, you use Visual Studio to create a small database that contains the sample code for [Create a simple data application by using ADO.NET](../data-tools/create-a-simple-data-application-by-using-adonet.md).

 **In this topic**

- [Create a script that contains a database schema](../data-tools/create-a-sql-database-by-using-a-script.md#CreateScript)

- [Create a database project and import a schema](../data-tools/create-a-sql-database-by-using-a-script.md#CreateProject)

- [Deploy the database](../data-tools/create-a-sql-database-by-using-a-script.md#DeployDatabase)

## Prerequisites
 To complete this walkthrough, you must have SQL Server Express LocalDB, or another SQL database, installed.

## <a name="CreateScript"></a> Create a script that contains a database schema

#### To create a script from which you can import a schema

1. In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], on the menu bar, select **File** > **New** > **File**.

     The **New File** dialog box appears.

2. In the **Categories** list, select **General**.

3. In the **Templates** list, select **Sql File**, and then select the **Open** button.

     The Transact-SQL editor opens.

4. Copy the following Transact-SQL code, and then paste it into the Transact-SQL editor.

    ```
    PRINT N'Creating Sales...';
    GO
    CREATE SCHEMA [Sales]
        AUTHORIZATION [dbo];
    GO
    PRINT N'Creating Sales.Customer...';
    GO
    CREATE TABLE [Sales].[Customer] (
        [CustomerID]   INT           IDENTITY (1, 1) NOT NULL,
        [CustomerName] NVARCHAR (40) NOT NULL,
        [YTDOrders]    INT           NOT NULL,
        [YTDSales]     INT           NOT NULL
    );
    GO
    PRINT N'Creating Sales.Orders...';
    GO
    CREATE TABLE [Sales].[Orders] (
        [CustomerID] INT      NOT NULL,
        [OrderID]    INT      IDENTITY (1, 1) NOT NULL,
        [OrderDate]  DATETIME NOT NULL,
        [FilledDate] DATETIME NULL,
        [Status]     CHAR (1) NOT NULL,
        [Amount]     INT      NOT NULL
    );
    GO
    PRINT N'Creating Sales.Def_Customer_YTDOrders...';
    GO
    ALTER TABLE [Sales].[Customer]
        ADD CONSTRAINT [Def_Customer_YTDOrders] DEFAULT 0 FOR [YTDOrders];
    GO
    PRINT N'Creating Sales.Def_Customer_YTDSales...';
    GO
    ALTER TABLE [Sales].[Customer]
        ADD CONSTRAINT [Def_Customer_YTDSales] DEFAULT 0 FOR [YTDSales];
    GO
    PRINT N'Creating Sales.Def_Orders_OrderDate...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [Def_Orders_OrderDate] DEFAULT GetDate() FOR [OrderDate];
    GO
    PRINT N'Creating Sales.Def_Orders_Status...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [Def_Orders_Status] DEFAULT 'O' FOR [Status];
    GO
    PRINT N'Creating Sales.PK_Customer_CustID...';
    GO
    ALTER TABLE [Sales].[Customer]
        ADD CONSTRAINT [PK_Customer_CustID] PRIMARY KEY CLUSTERED ([CustomerID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
    GO
    PRINT N'Creating Sales.PK_Orders_OrderID...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [PK_Orders_OrderID] PRIMARY KEY CLUSTERED ([OrderID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
    GO
    PRINT N'Creating Sales.FK_Orders_Customer_CustID...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [FK_Orders_Customer_CustID] FOREIGN KEY ([CustomerID]) REFERENCES [Sales].[Customer] ([CustomerID]) ON DELETE NO ACTION ON UPDATE NO ACTION;
    GO
    PRINT N'Creating Sales.CK_Orders_FilledDate...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [CK_Orders_FilledDate] CHECK ((FilledDate >= OrderDate) AND (FilledDate < '01/01/2020'));
    GO
    PRINT N'Creating Sales.CK_Orders_OrderDate...';
    GO
    ALTER TABLE [Sales].[Orders]
        ADD CONSTRAINT [CK_Orders_OrderDate] CHECK ((OrderDate > '01/01/2005') and (OrderDate < '01/01/2020'));
    GO
    PRINT N'Creating Sales.uspCancelOrder...';
    GO
    CREATE PROCEDURE [Sales].[uspCancelOrder]
    @OrderID INT
    AS
    BEGIN
    DECLARE @Delta INT, @CustomerID INT
    BEGIN TRANSACTION
        SELECT @Delta = [Amount], @CustomerID = [CustomerID]
         FROM [Sales].[Orders] WHERE [OrderID] = @OrderID;

    UPDATE [Sales].[Orders]
       SET [Status] = 'X'
    WHERE [OrderID] = @OrderID;

    UPDATE [Sales].[Customer]
       SET
       YTDOrders = YTDOrders - @Delta
        WHERE [CustomerID] = @CustomerID
    COMMIT TRANSACTION
    END
    GO
    PRINT N'Creating Sales.uspFillOrder...';
    GO
    CREATE PROCEDURE [Sales].[uspFillOrder]
    @OrderID INT, @FilledDate DATETIME
    AS
    BEGIN
    DECLARE @Delta INT, @CustomerID INT
    BEGIN TRANSACTION
        SELECT @Delta = [Amount], @CustomerID = [CustomerID]
         FROM [Sales].[Orders] WHERE [OrderID] = @OrderID;

    UPDATE [Sales].[Orders]
       SET [Status] = 'F',
           [FilledDate] = @FilledDate
    WHERE [OrderID] = @OrderID;

    UPDATE [Sales].[Customer]
       SET
       YTDSales = YTDSales + @Delta
        WHERE [CustomerID] = @CustomerID
    COMMIT TRANSACTION
    END
    GO
    PRINT N'Creating Sales.uspNewCustomer...';
    GO
    CREATE PROCEDURE [Sales].[uspNewCustomer]
    @CustomerName NVARCHAR (40),
    @CustomerID INT OUTPUT
    AS
    BEGIN
    INSERT INTO [Sales].[Customer] (CustomerName) VALUES (@CustomerName);
    SET @CustomerID = SCOPE_IDENTITY();
    RETURN @@ERROR
    END
    GO
    PRINT N'Creating Sales.uspPlaceNewOrder...';
    GO
    CREATE PROCEDURE [Sales].[uspPlaceNewOrder]
    @CustomerID INT, @Amount INT, @OrderDate DATETIME, @Status CHAR (1)='O'
    AS
    BEGIN
    DECLARE @RC INT
    BEGIN TRANSACTION
    INSERT INTO [Sales].[Orders] (CustomerID, OrderDate, FilledDate, Status, Amount)
         VALUES (@CustomerID, @OrderDate, NULL, @Status, @Amount)
    SELECT @RC = SCOPE_IDENTITY();
    UPDATE [Sales].[Customer]
       SET
       YTDOrders = YTDOrders + @Amount
        WHERE [CustomerID] = @CustomerID
    COMMIT TRANSACTION
    RETURN @RC
    END
    GO
    CREATE PROCEDURE [Sales].[uspShowOrderDetails]
    @CustomerID INT=0
    AS
    BEGIN
    SELECT [C].[CustomerName], CONVERT(date, [O].[OrderDate]), CONVERT(date, [O].[FilledDate]), [O].[Status], [O].[Amount]
      FROM [Sales].[Customer] AS C
      INNER JOIN [Sales].[Orders] AS O
         ON [O].[CustomerID] = [C].[CustomerID]
      WHERE [C].[CustomerID] = @CustomerID
    END
    GO
    ```

5. On the menu bar, select **File** > **Save SqlQuery_1.sql As**.

     The **Save File As** dialog box appears.

6. In the **File Name** box, enter `SampleImportScript.sql`, note the location where you'll save the file, and then select the **Save** button.

7. On the menu bar, select **File** > **Close Solution**.

     Next, create a database project, and then import the schema from the script that you've created.

## <a name="CreateProject"></a> Create a database project and import a schema

#### To create a database project

1. On the menu bar, select **File** > **New** > **Project**.

     The **New Project** dialog box appears.

2. Under **Installed**, expand the **Templates** node, expand the **Other Languages** node, select the **SQL Server** category, and then select the **SQL Server Database Project** template.

    > [!NOTE]
    > The **Other Languages** node doesn’t appear in all installations of Visual Studio.

3. In the **Name** box, enter `Small Database`.

4. Select the **Create directory for solution** check box if it isn't already selected.

5. Clear the **Add to source control** check box if it isn't already cleared, and then select the **OK** button.

     The database project is created and appears in **Solution Explorer**.

     Next, import the database schema from the script.

#### To import a database schema from a script

1. On the menu bar, select **Project** > **Import** > **Script**.

2. On the **Welcome** page, review the text, and then select the **Next** button.

3. Select the **Single File** option button, and then select the **Browse** button.

     The **Import SQL Script** dialog box appears.

4. Open the folder where you saved the SampleImportScript.sql file, select the file, and then select the **Open** button.

5. Select the **Finish** button to close the **Import SQL Script** dialog box.

     The script is imported, and the objects that the script defines are added to your database project.

6. Review the summary, and then click the **Finish** button to close the **Import SQL Script File** dialog box.

7. In **Solution Explorer**, expand the Sales, Scripts, and Security folders of your project, and verify that they contain .sql files.

8. In **SQL Server Object Explorer**, verify that the database appears under the **Projects** node.

     At this point, the database contains only system objects, such as tables and stored procedures. After you deploy the database, it will contain the user tables and stored procedures that the scripts define.

## <a name="DeployDatabase"></a> Deploy the database
 When you press the **F5** key, you deploy (or publish) the database to a LocalDB database by default. You can deploy the database to a different location by opening the properties page for the project, selecting the **Debug** tab, and then changing the connection string.
