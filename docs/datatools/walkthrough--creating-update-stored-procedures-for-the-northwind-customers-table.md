---
title: "Walkthrough: Creating Update Stored Procedures for the Northwind Customers Table"
ms.custom: na
ms.date: "10/10/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "Northwind sample database"
  - "stored procedures [Visual Studio]"
  - "O/R Designer, stored procedures"
ms.assetid: 6fd9e7e0-6862-44d3-9710-acc5a72d4ffd
caps.latest.revision: 18
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
# Walkthrough: Creating Update Stored Procedures for the Northwind Customers Table
Some Help topics in the [!INCLUDE[vs_current_short](../codequality/includes/vs_current_short_md.md)] documentation require additional stored procedures in the Northwind sample database for performing updates (Inserts, Updates, and Deletes) of data in the Customers table.  
  
 This walkthrough provides directions for creating these additional stored procedures in the Northwind sample databases for [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)].  
  
 The Next Steps section later in this topic provides links to topics that demonstrate how to work with these additional stored procedures.  
  
 During this walkthrough, you will learn how to perform the following tasks:  
  
-   Create a data connection to the Northwind sample database.  
  
-   Create the stored procedures.  
  
## Prerequisites  
 To complete this walkthrough, you need:  
  
-   Access to the SQL Server version of the Northwind sample database. For more information, see [How to: Install Sample Databases](../datatools/how-to--install-sample-databases.md).  
  
## Connecting to the Northwind Database  
 This walkthrough requires a connection to the SQL Server version of the Northwind database. The following procedure provides directions for creating the data connection.  
  
> [!NOTE]
>  If you already have a data connection to the Northwind database, you can go to the next section, Creating the Stored Procedures.  
  
#### To create a data connection to the Northwind SQL Server database  
  
1.  On the **View** menu, click **Server Explorer**/**Database Explorer**.  
  
2.  Right-click **Data Connections** and click **Add Connection**.  
  
3.  In the **Choose Data Source** dialog box, click **Microsoft SQL Server**, and then click **OK**.  
  
     If the **Add Connection** dialog box opens, and the **Data source** is not **Microsoft SQL Server (SqlClient)**, click **Change** to open the **Choose/Change Data Source** dialog box, click **Microsoft SQL Server**, and then click **OK**.  
  
4.  Click a **Server name** in the drop-down list, or type the name of the server on which the Northwind database is located.  
  
5.  Based on the requirements of the database or application, either click **Use Windows Authentication** or use a specific user name and password to log on to the computer running SQL Server (**SQL Server Authentication**).  
  
6.  Click the Northwind database in the **Select or enter a database name** list.  
  
7.  Click **OK**.  
  
     The data connection is added to **Server Explorer**/**Database Explorer**.  
  
## Creating the Stored Procedures  
 Create the stored procedures by running the provided SQL script against the Northwind database by using the [Visual Database Tools](assetId:///6b145922-2f00-47db-befc-bf351b4809a1) available in **Server Explorer**/**Database Explorer**.  
  
#### To create the stored procedures by using a SQL script  
  
1.  Expand the Northwind database in **Server Explorer**/**Database Explorer**.  
  
2.  Right-click the **Stored Procedures** node and click **Add New Stored Procedure**.  
  
3.  Paste the following code into the Code Editor, replacing the `CREATE PROCEDURE` template:  
  
    ```  
    IF EXISTS (SELECT * FROM sysobjects WHERE name = 'SelectCustomers' AND user_name(uid) = 'dbo')  
        DROP PROCEDURE dbo.[SelectCustomers]  
    GO  
  
    CREATE PROCEDURE dbo.[SelectCustomers]  
    AS  
        SET NOCOUNT ON;  
    SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM dbo.Customers  
    GO  
  
    IF EXISTS (SELECT * FROM sysobjects WHERE name = 'InsertCustomers' AND user_name(uid) = 'dbo')  
        DROP PROCEDURE dbo.InsertCustomers  
    GO  
  
    CREATE PROCEDURE dbo.InsertCustomers  
    (  
        @CustomerID nchar(5),  
        @CompanyName nvarchar(40),  
        @ContactName nvarchar(30),  
        @ContactTitle nvarchar(30),  
        @Address nvarchar(60),  
        @City nvarchar(15),  
        @Region nvarchar(15),  
        @PostalCode nvarchar(10),  
        @Country nvarchar(15),  
        @Phone nvarchar(24),  
        @Fax nvarchar(24)  
    )  
    AS  
        SET NOCOUNT OFF;  
    INSERT INTO [dbo].[Customers] ([CustomerID], [CompanyName], [ContactName], [ContactTitle], [Address], [City], [Region], [PostalCode], [Country], [Phone], [Fax]) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax);  
  
    SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)  
    GO  
  
    IF EXISTS (SELECT * FROM sysobjects WHERE name = 'UpdateCustomers' AND user_name(uid) = 'dbo')  
        DROP PROCEDURE dbo.UpdateCustomers  
    GO  
  
    CREATE PROCEDURE dbo.UpdateCustomers  
    (  
        @CustomerID nchar(5),  
        @CompanyName nvarchar(40),  
        @ContactName nvarchar(30),  
        @ContactTitle nvarchar(30),  
        @Address nvarchar(60),  
        @City nvarchar(15),  
        @Region nvarchar(15),  
        @PostalCode nvarchar(10),  
        @Country nvarchar(15),  
        @Phone nvarchar(24),  
        @Fax nvarchar(24),  
        @Original_CustomerID nchar(5)  
    )  
    AS  
        SET NOCOUNT OFF;  
    UPDATE [dbo].[Customers] SET [CustomerID] = @CustomerID, [CompanyName] = @CompanyName, [ContactName] = @ContactName, [ContactTitle] = @ContactTitle, [Address] = @Address, [City] = @City, [Region] = @Region, [PostalCode] = @PostalCode, [Country] = @Country, [Phone] = @Phone, [Fax] = @Fax WHERE (([CustomerID] = @Original_CustomerID));  
  
    SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)  
    GO  
  
    IF EXISTS (SELECT * FROM sysobjects WHERE name = 'DeleteCustomers' AND user_name(uid) = 'dbo')  
        DROP PROCEDURE dbo.DeleteCustomers  
    GO  
  
    CREATE PROCEDURE dbo.DeleteCustomers  
    (  
        @Original_CustomerID nchar(5)  
    )  
    AS  
        SET NOCOUNT OFF;  
    DELETE FROM [dbo].[Customers] WHERE (([CustomerID] = @Original_CustomerID))  
    GO  
    ```  
  
4.  Select all the text in the Code Editor, right-click the selected text, and click **Run Selection**.  
  
     The SelectCustomers, InsertCustomers, UpdateCustomers, and DeleteCustomers stored procedures are created for the Northwind database.  
  
## Next Steps  
 Now that you have created the stored procedures, try the following walkthroughs that demonstrate how to work with them:  
  
 [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../datatools/how-to--assign-stored-procedures-to-perform-updates--inserts--and-deletes--o-r-designer-.md)  
  
 [Walkthrough: Creating LINQ to SQL Classes (O-R Designer)](../Topic/Walkthrough:%20Creating%20LINQ%20to%20SQL%20Classes%20\(O-R%20Designer\).md)  
  
 [Walkthrough: Customizing the insert, update, and delete behavior of entity classes](../datatools/walkthrough--customizing-the-insert--update--and-delete-behavior-of-entity-classes.md)  
  
## See Also  
 [LINQ to SQL Tools in Visual Studio](../datatools/linq-to-sql-tools-in-visual-studio2.md)   
 [LINQ to SQL](../Topic/LINQ%20to%20SQL.md)   
 [Accessing data in Visual Studio](../datatools/accessing-data-in-visual-studio.md)