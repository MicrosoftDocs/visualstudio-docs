---
title: "How to: Connect to the Northwind Database"
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
  - "connections [Visual Studio], Northwind database"
  - "Northwind sample database"
ms.assetid: cc6cb79f-d035-41f8-b398-8d4a45922bfb
caps.latest.revision: 29
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
# How to: Connect to the Northwind Database
As you learn how to create database applications by using Visual Studio, you'll need to connect to the Northwind database to follow many of the examples in the documentation for that product. Depending on which example you're following, you'll connect to the database in either SQL Server or a database file, such as one for Microsoft Access or SQL Server.  
  
## Creating Data Connections to the Northwind Database  
 [!INCLUDE[note_settings_general](../datatools/includes/note_settings_general_md.md)]  
  
#### To create a data connection to the Northwind database (SQL Server)  
  
1.  On the **View** menu, choose **Server Explorer**/**Database Explorer**.  
  
2.  In **Server Explorer**/**Database Explorer**, open the shortcut menu for **Data Connections** and choose **Add Connection**.  
  
     After you choose **Add Connection**, either the **Choose Data Source** dialog box or the **Add Connection** dialog box will appear.  
  
3.  If the **Choose Data Source** dialog box appears, select **Microsoft SQL Server**, and then choose **OK**.  
  
     If the **Add Connection** dialog box appears and the **Data source** is not **Microsoft SQL Server (SqlClient)**, choose the **Change** button to open the **Change Data Source** dialog box, select **Microsoft SQL Server**, and then choose the **OK** button.  
  
4.  In the **Server name** list, specify the name of the server on which the Northwind database is located.  
  
5.  Depending on the requirements of your version of SQL Server and the Northwind database, either choose **Use Windows Authentication** or choose **Use SQL Server Authentication** and enter a user name and password to log on to the computer running SQL Server.  
  
6.  Choose the Northwind database in the **Select or enter a database name** list.  
  
7.  Choose **Test Connection** to verify connectivity to the Northwind database.  
  
8.  Choose **OK**.  
  
     A data connection to the Northwind database is added to **Server Explorer**/**Database Explorer**.  
  
 In addition to connecting to a remote instance of a SQL Server database, you can also connect directly to the actual files that contain the database. This enables you to add the database files directly into a project where they can be deployed as part of the application. The following local database files are currently supported: SQL Server Compact database files (.sdf), [!INCLUDE[ssNoVersion](../datatools/includes/ssnoversion_md.md)] and SQL Server Express database files (.mdf), and Microsoft Access database files (.mdb or .accdb).  
  
#### To create a data connection to the Northwind database—SQL Server database file (.mdf)  
  
1.  On the **View** menu, choose **Server Explorer**/**Database Explorer**.  
  
2.  In **Server Explorer**/**Database Explorer**, open the shortcut menu for **Data Connections** and choose **Add Connection**.  
  
     After you choose **Add Connection**, either the **Add Connection** dialog box or the **Choose Data Source** dialog box will appear.  
  
3.  If the **Choose Data Source** dialog box appears, select **Microsoft SQL Server Database File**, and then choose the **OK**.  
  
4.  If the **Add Connection** dialog box appears, verify that the **Data source** is set to **Microsoft SQL Server Database File (SqlClient)**. If it is not set to **Microsoft SQL Server Database File (SqlClient)**, choose **Change** to open the **Change Data Source** dialog box, choose **Microsoft SQL Server Database File**, and then choose the **OK** button.  
  
5.  Choose **Browse** to locate the .mdf file that contains the Northwind database.  
  
6.  Depending on the requirements of your version of the Northwind database, either choose **Use Windows Authentication** or choose **SQL Server Authentication** and enter a user name and password to log on to the computer running SQL Server.  
  
7.  Choose the **OK** button.  
  
     A data connection to the Northwind database is added to **Server Explorer**/**Database Explorer**.  
  
> [!NOTE]
>  [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)] has changes that apply to the Northwind database file (.mdf). For information, see [How to: Install Sample Databases](../datatools/how-to--install-sample-databases.md).  
  
#### To create a data connection to the Northwind database—Access database file (.mdb or .accdb)  
  
1.  On the **View** menu, choose **Server Explorer**/**Database Explorer**.  
  
2.  In **Server Explorer**/**Database Explorer**, open the shortcut menu for **Data Connections** and choose **Add Connection**.  
  
     After you choose **Add Connection**, either the **Add Connection** dialog box or the **Choose Data Source** dialog box will appear.  
  
3.  If the **Choose Data Source** dialog box appears, select **Microsoft Access Database File**, and then choose **OK**.  
  
4.  If the **Add Connection** dialog box appears, verify that the **Data source** is set to **Microsoft Access Database File**. If it is not set to **Microsoft Access Database File**, choose **Change** to open the **Change Data Source** dialog box, choose **Microsoft Access Database File**, and then choose the **OK** button.  
  
5.  Choose **Browse** to locate the .mdb or .accdb file that contains the Northwind database.  
  
6.  Enter a user name and password if it is required by your version of the Northwind database.  
  
7.  Choose **OK**.  
  
     A data connection to the Northwind database is added to **Server Explorer**/**Database Explorer**.  
  
## See Also  
 [How to: Install Sample Databases](../datatools/how-to--install-sample-databases.md)   
 [Data Programming with Microsoft Access 2010](http://msdn.microsoft.com/library/office/ff965871.aspx)   
 [Data Walkthroughs](../Topic/Data%20Walkthroughs.md)