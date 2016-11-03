---
title: "Local Data Overview | Microsoft Docs"
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
  - "SQL Server Express"
  - "local data"
  - "SQL Server LocalDB"
  - "LocalDB"
  - "SQLEXPRESS"
  - "SQL Server, local data"
  - "SQL Express"
  - "SQL Server Compact"
  - "data access [Visual Studio], troubleshooting"
  - "Access, .mdb files in Visual Studio"
  - "data [Visual Studio], local"
ms.assetid: d6afa5ac-2bb8-49f2-a50e-f71f611ed506
caps.latest.revision: 71
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Local Data Overview
When developing data applications, it is usually best to use a local copy of a database, so that you do not introduce errors into production data. Even sharing a test database with other developers creates potential problems if two developers introduce errors that interact in hard-to-detect ways. You can avoid all these pitfalls by using your own test  data on your own local computer. Most if not all database systems enable you to create local data files. For .NET projects, Visual Studio provides special support for local SQL Server database files (.mdf) and Microsoft Access database files (.mdb).  
  
 Visual Studio supports these scenarios:  
  
1.  
  
2.  
  
-  
  
-  
  
-   Create a SQL Server database project by clicking on the solution node in Solution Explorer and choosing **Add &#124; New Project**.  In the left pane, choose **SQL Server &#124; Database** project and click OK. In Solution Explorer, right click on the database project node to import a local database file, then develop the application that connects to the database produced by the project. Good when you are developing and modifying the database schema at the same time that you are developing the application.  
  
     ![Import Database into Database project](../data-tools/media/raddata-import-database-into-database-project.png "raddata Import Database into Database project")  
  
-   If you are creating a new database, first add a **Service-based database file** to your project (**Project &#124; Add New Item)**. This creates a new .mdf file that is attached to the default SQL Server instance on the local machine, which by default is (localdb)\MSSQLocalDB. The database should appear in Server Explorer. Expand the node, and right-click on the nodes to add new database objects such as tables, views, functions, and so on.  
  
 For more information about SQL Server Express LocalDB, see [Introducing LocalDB, an Improved SQL Express](http://go.microsoft.com/fwlink/?LinkId=234375) and [LocalDB: Where is My Database?](http://go.microsoft.com/fwlink/?LinkId=234376) on the Microsoft website.  
  
 The following table provides links to topics that describe how to connect your application to local data:  
  
|Topic|Description|  
|-----------|-----------------|  
|[Create a SQL database by using a designer](../data-tools/create-a-sql-database-by-using-a-designer.md)|Provides step-by-step instructions for creating a local database file that you can use to test data features and build applications.|  
|[Walkthrough: Connecting to Data in a Local Database File (Windows Forms)](../data-tools/walkthrough-connecting-to-data-in-a-local-database-file-windows-forms.md)|Provides step-by-step instructions for connecting to a SQL Server Express LocalDB database while you create a simple Windows application.|  
|[Connect to data in an Access database (Windows Forms)](../data-tools/connect-to-data-in-an-access-database-windows-forms.md)|Provides step-by-step instructions for connecting to a Microsoft Access database.|  
|[How to: Connect to the Northwind Database](../data-tools/how-to-connect-to-the-northwind-database.md)|Provides instructions for connecting to the Northwind sample database in [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)], SQL Server Compact, SQL Server Express, and Access.|  
  
## Use the connection string  
 This is the simplest approach and is a good choice when your application only reads from the database, and when using third-party databases. The database file can be located anywhere on the local machine that your application has permission to access, and that the database system supports.  
  
1.  (Optional) Create a new connection as described in [Add new connections](../data-tools/add-new-connections.md). For third party databases, and .mdf files for which you already know the connection string and will not be doing databinding or using a data source such as Entity Framework classes or datasets, this step is not necessary. Just use the connection string to connect to the local file. For .mdf files, see [Upgrade .mdf files](../data-tools/upgrade-dot-mdf-files.md) and [Establishing the Connection](https://msdn.microsoft.com/en-us/library/ms254507.aspx).  
  
2.  (Optional) If you are using datasets, Entity Framework or LINQ to SQL, then create the data source by using the Data Source Configuration Wizard. For more information, see [Add new data sources](../data-tools/add-new-data-sources.md).  
  
## Add an existing .mdf to your project  
 If your application will be inserting, deleting or updating data and you want to keep a copy of the original file available, then consider adding the file to your project. When you do that, you can set the item property on it to **Copy to Output Directory** to **Copy always** or **Copy if newer**, and develop the application. Each time you build the application, the original database is copied to the output folder and your application's changes are performed on the copy. That way you always have a clean copy of the original data.  
  
1.  Use **Windows File Explorer** to drag and drop the .mdf file from its current location onto the project node in Solution Explorer in Visual Studio.  If the file is already attached to a localDB instance, you must detach it first. After you drop it into the project, Visual Studio will automatically reattach it to the default localDB instance.  
  
2.  Right-click on the new database node  and choose Properties. Select the copy behavior, either **Copy Always** or **Copy if newer**.  
  
## Create a SQL Server database project and import your database  
 This is a good option when you will be developing the database itself, perhaps adding columns or tables, or changing datatypes.  
  
## Each Project Contains Two Copies of the Database  
 When you build a project, the database file might be copied from the root project folder into the output, **bin**, folder. This behavior depends on the **Copy to Output Directory** property of the file, and the default value of that property depends on the type of database file that you’re using.  
  
 To view the **bin** folder in **Solution Explorer**, choose the **Show All Files** button on the toolbar.  
  
> [!NOTE]
>  The **Copy to Output Directory** property doesn’t apply to web or C++ projects.  
  
 The database file in your root project folder is changed only when you edit the database schema or data by using **Server Explorer**/**Database Explorer** or other [Visual Database Tools](http://msdn.microsoft.com/en-us/6b145922-2f00-47db-befc-bf351b4809a1).  
  
 As you change data during application development, you’re changing the database in the **bin** folder. For example, when you choose the F5 key to debug your application, you’re connected to the database in that folder.  
  
|Value of **Copy to Output Directory** property|Behavior|  
|----------------------------------------------------|--------------|  
|**Copy if newer** (default value for .sdf files)|The database file is copied from the project directory to the **bin** directory the first time that you build the project. The **Date Modified** property of the files is then compared every time that you build the project again. If the file in the project folder is newer, it’s copied to the **bin** folder, replacing the previous file. Otherwise, no files are copied. **Caution:**  We don’t recommend this value for .mdb or .mdf files. The database file can change even if the data doesn’t change. The file can be marked as newer if you simply open a connection (for example, expand the **Tables** node in **Server Explorer**).|  
|**Copy always** (default value for .mdf and .mdb files)|The database file is copied from the project directory to the **bin** directory every time that you build your application. Any changes made to the data file in the output folder are overwritten the next time that you run the application.|  
|**Do not copy**|The system never overwrites the file in the **bin** directory. Your application creates a dynamic connection string that points to the database file in the output directory. Therefore, you must manually copy the file to the output directory if you want the data in the output directory to match the data in the project directory.|  
  
## Common Issues with Local Data  
 The following table explains common issues that you might encounter as you work with local data files.  
  
|Issue|Explanation|  
|-----------|-----------------|  
|Every time I test my application and modify data, my changes are gone the next time I run my application.|The value of the **Copy to Output Directory** property is **Copy if newer** or **Copy always**. The database in your output folder (the database that’s being modified when you test your application) is overwritten every time that you build your project. For more information, see [How to: Manage Local Data Files in Your Project](../data-tools/how-to-manage-local-data-files-in-your-project.md).|  
|A message appears, saying that the data file is locked.|Access (.mdb files): Verify that the file isn’t open in another program, such as Access.<br /><br /> SQL Server Express (.mdf files): SQL Express locks the data file if you try to copy, move, or rename it outside the Visual Studio IDE.|  
|Access is denied when more than one user tries to access the same database at the same time.|Visual Studio takes advantage of *user instances*, which is a feature of SQL Server Express that creates a separate instance of SQL Server for each user. After one user accesses the file, any subsequent users can’t connect. This issue can occur if, for example, you try to run a web application in ASP.NET Development Server and Internet Information Services (IIS) at the same time, because IIS typically runs under a different account.|  
  
## See Also  
 [Walkthrough: Connecting to Data in a Local Database File (Windows Forms)](../data-tools/walkthrough-connecting-to-data-in-a-local-database-file-windows-forms.md)   
 [Connect to data in an Access database (Windows Forms)](../data-tools/connect-to-data-in-an-access-database-windows-forms.md)