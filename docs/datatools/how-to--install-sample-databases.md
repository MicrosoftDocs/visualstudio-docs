---
title: "How to: Install Sample Databases"
ms.custom: na
ms.date: "10/13/2016"
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
  - "sample databases, Adventure Works"
  - "data [Visual Studio], sample databases"
  - "sample databases, Northwind"
  - "Northwind sample database"
  - "Adventure Works sample database"
ms.assetid: ed1291f6-604c-4972-ae22-0345c6dea12e
caps.latest.revision: 56
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
# How to: Install Sample Databases
Many data examples require the ability to connect to the Northwind, Pubs, andAdventureWorks sample databases. You can install and connect to these databases by using the following procedures.  
  
 [!INCLUDE[note_settings_general](../datatools/includes/note_settings_general_md.md)]  
  
## Installing Databases  
 Many data examples require the availability of sample databases that can be downloaded from web sites. The sample databases include the AdventureWorks, Northwind, and Pubs databases.  
  
#### To install the Northwind and Pubs sample databases for SQL Server  
  
1.  Go to the [Northwind and Pubs Sample Databases](http://go.microsoft.com/fwlink?linkid=64296) web site.  
  
2.  Download and run the installer.  
  
     The installer adds a folder **SQL Server 2000 Sample Databases** to the root folder on your computer. (For example: **C:\SQL Server 2000 Sample Databases**).  
  
3.  Locate the SQL script for the database you want, Northwind or Pubs.  
  
    > [!WARNING]
    >  The .MDF database file cannot easily be converted to a format that you can use in current versions of SQL Server, so it's best to use the script to create the database.  
  
4.  In **Server Explorer**, create a connection to a SQL Server instance where you want to install the database. If you don't have a specific SQL Server that you want to use, you can use the database that's automatically installed with Visual Studio. To do that, specify `(localdb)\v11.0` as the server name.  
  
     To create the connection, follow these steps.  
  
    ###### To create a connection to an instance of SQL Server  
  
    1.  In **Server Explorer**, open the shortcut menu for the **Data Connections** node, and choose **Add Connection**.  
  
         The **Add Connection** dialog box appears.  
  
    2.  Enter the name of the SQL Server where you want to create the Northwind or Pubs database, or enter (localdb)\v11.0.  
  
    3.  Under **Select or enter a database name**, choose any database from the list, for example, tempdb.  
  
    4.  Choose the **Test Connection** button to verify that everything is working, and then choose the **OK** button.  
  
         A new connection node appears in **Server Explorer**.  
  
5.  On the shortcut menu for the connection node for your server, and then choose the **New Query** button.  
  
     An editor window opens and shows an empty .sql script file.  
  
6.  Paste the contents of instnwnd.sql or instpubs.sql into the editor window.  
  
7.  Choose the execute query button (the open green triangle icon at the top right of the query window).  
  
     If the query succeeds, the message **Command(s) completed successfully** appears. This means that the Northwind or pubs database has been created.  
  
     You still need to add a connection to the sample database. In **Server Explorer**, open the shortcut menu for the **Data Connections** node and choose **Add Connection**.  
  
8.  Choose the same database server that you chose before, but this time, under Select or enter a database name, choose the Northwind or pubs database, and choose the **OK** button.  
  
     A new node appears under Data Connections for the sample database.  
  
9. Close the editor window and confirm that you don't want to save the query file. It's not necessary to save the database creation script once you've created the database.  
  
#### To install the AdventureWorks sample databases  
  
-   Download the AdventureWorks sample databases from the [CodePlex Web site](http://go.microsoft.com/fwlink/?linkid=87843).  
  
#### To install the Northwind sample database for Microsoft Access  
  
1.  In Microsoft Access 2010 or later, search online templates for Northwind, and choose **Desktop Northwind 2007 sample database**.  
  
2.  In Microsoft Access, save the database file as Northwind.accdb.  
  
 The new extension for Access databases is .accdb. See [Data Programming with Microsoft Access 2010](http://msdn.microsoft.com/library/office/ff965871.aspx). To connect to the Northwind database by using Access, see [How to: Connect to the Northwind Database](../datatools/how-to--connect-to-the-northwind-database.md).  
  
## .NET Framework Security  
 The sample databases are for illustration only, and do not necessarily demonstrate the best security practices.  
  
## See Also  
 [How to determine the version and edition of SQL Server and its components](http://support.microsoft.com/kb/321185)   
 [Create a SQL database by using a designer](../datatools/create-a-sql-database-by-using-a-designer.md)   
 [How to: Connect to the Northwind Database](../datatools/how-to--connect-to-the-northwind-database.md)