---
title: "Connecting to Data in Windows Forms Applications | Microsoft Docs"
ms.custom: ""
ms.date: "11/02/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "System.Data.SqlClient.SqlConnection"
  - "System.Data.Odbc.OdbcConnection"
  - "System.Data.OleDb.OleDbConnection"
  - "System.Data.OracleClient.OracleConnection"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "connection objects, tools for working with"
  - "OleDbConnection class, ADO.NET connection objects"
  - "databases [Visual Studio], connecting to"
  - "data adapters, connections"
  - "connection pooling, ADO.NET connections"
  - "connection strings [Visual Studio], ADO.NET"
  - "connection objects, types of"
  - "dynamic properties, ADO.NET connections"
  - "connections, about connections"
  - "data [Visual Studio], connecting"
  - "design-time connections"
  - "connections, design-time"
  - "TableAdapters, connections"
  - "connection objects"
  - "SqlConnection class, ADO.NET connection objects"
  - "connecting to databases, ADO.NET connections"
  - "transactions, ADO.NET"
  - "database connections [Visual Studio], ADO.NET"
ms.assetid: 184cbd0d-3b26-418d-a11c-f9f8f004fbff
caps.latest.revision: 31
author: "mikeblome"
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
# Connecting to Data in Windows Forms Applications
[!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] provides tools to connect your application to data from many different sources, such as databases, web services, and objects. If you are using data design tools in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], you often do not need to explicitly create a connection object for your form or component. The connection object is typically created as a result of completing one of the data wizards or of dragging data objects onto your form. To connect your application to data in a database, web service, or object, run the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png) by selecting **Add New Data Source** from the [Data Sources Window](../Topic/Data%20Sources%20Window.md).  
  
 The following diagram shows the standard flow of operations when connecting to data by executing a TableAdapter query to fetch data and display it on a form in a Windows application.  
  
 ![Data flow in a client application](../data-tools/media/clientdatadiagram.gif "ClientDataDiagram")  
  
 In some situations, it’s convenient to create a connection object without the assistance of any data design tools. For information on creating connections programmatically, see [Connecting to a Data Source](../Topic/Connecting%20to%20a%20Data%20Source%20in%20ADO.NET.md).  
  
> [!NOTE]
>  For information on connecting web applications to data, see [ASP.NET Data Access Content Map](http://msdn.microsoft.com/en-us/f9219396-a0fa-481f-894d-e3d9c67d64f2).  
  
## Walkthroughs for Connecting Windows Forms Applications to Data  
 The following walkthroughs provide procedures related to connecting to data in Windows Forms applications:  
  
-   [Walkthrough: Connecting to Data in a Database (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20a%20Database%20\(Windows%20Forms\).md)  
  
-   [Walkthrough: Connecting to Data in a Local Database File (Windows Forms)](../data-tools/walkthrough-connecting-to-data-in-a-local-database-file-windows-forms.md)  
  
-   [Walkthrough: Connecting to Data in a Web Service (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20a%20Web%20Service%20\(Windows%20Forms\).md)  
  
-   [Walkthrough: Connecting to Data in Objects (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20Objects%20\(Windows%20Forms\).md)  
  
-   [Connect to data in an Access database (Windows Forms)](../data-tools/connect-to-data-in-an-access-database-windows-forms.md)  
  
## Creating Connections  
 In [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], connections are configured using the **Add/Modify Connection** dialog box. The **Add Connection** dialog box appears when you’re editing or creating connections within one of the data wizards or [Server Explorer/Database Explorer](../Topic/Server%20Explorer.md) or when you’re editing connection properties in the **Properties** window.  
  
 Data connections are automatically configured when you perform one of the following actions.  
  
|Action|Description|  
|------------|-----------------|  
|Run the [Data Source Configuration Wizard](../data-tools/media/data-source-configuration-wizard.png).|Connections are configured when the database path is chosen in the **Data Source Configuration Wizard**. For more information, see [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md).|  
|Run the [TableAdapter Configuration Wizard](../Topic/TableAdapter%20Configuration%20Wizard.md).|Connections are created within the **TableAdapter Configuration Wizard**. For more information, see [Create and configure TableAdapters](../data-tools/create-and-configure-tableadapters.md).|  
|Run the [Editing TableAdapters](../data-tools/editing-tableadapters.md).|Connections are created within the **TableAdapter Query Configuration Wizard**. For more information, see [How to: Create TableAdapter Queries](../data-tools/how-to-create-tableadapter-queries.md).|  
|Drag items from the [Data Sources Window](../Topic/Data%20Sources%20Window.md) onto a form or the [Component Designer](../Topic/Component%20Designer.md).|Connection objects are created when you drag items from the **Data Sources** window onto the **Windows Forms Designer** or **Component Designer**. For more information, see [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).|  
|Add new data connections to [Server Explorer/Database Explorer](../Topic/Server%20Explorer.md).|Data connections in **Server Explorer/Database Explorer** appear in the list of available connections within the data wizards|  
  
## Connection Strings  
 Connection strings can be stored within your compiled application or in the application configuration file. For more information, see [How to: Save and Edit Connection Strings](../Topic/How%20to:%20Save%20and%20Edit%20Connection%20Strings.md).  
  
## Connection Information and Security  
 Because opening a connection involves getting access to an important resource—a database—there are often security issues involved in configuring and working with a connection.  
  
 How you secure the application and its access to the data source depends on the architecture of your system. In a web-based application, for example, users typically get anonymous access to Internet Information Services (IIS) and therefore do not provide security credentials. In that case, your application maintains its own logon information and uses it, rather than any specific user information, to open the connection and access the database.  
  
> [!IMPORTANT]
>  Storing connection-string details such as a password can affect the security of your application. Using Windows integrated security is a more secure way to control access to a database. For more information, see [Protecting Connection Information](../Topic/Protecting%20Connection%20Information.md).  
  
 In intranet or multi-tier applications, you can take advantage of the integrated security option provided by Windows, IIS, and SQL Server. In that model, a user's authentication credentials for the local network are also used to access database resources, and no explicit user name or password is used in the connection string. Typically, permissions are established on the database server computer by means of groups, so that you do not need to establish individual permissions for every user who might access the database. In this model, you do not need to store logon information for the connection at all, and there are no extra steps required to protect connection string information.  
  
 For more information about security, see the following topics:  
  
-   [Securing ADO.NET Applications](../Topic/Securing%20ADO.NET%20Applications.md)  
  
-   [More Secure File and Data Access in Windows Forms](../Topic/More%20Secure%20File%20and%20Data%20Access%20in%20Windows%20Forms.md)  
  
## Design-Time Connections in Server Explorer/Database Explorer  
 **Server Explorer/Database Explorer** provides a way for you to create design-time connections to data sources. This permits you to browse available data sources; display information about the tables, columns, and other elements they contain; and edit and create database elements.  
  
 Your application does not directly use the connections available in **Server Explorer/Database Explorer**. These connections are used by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] for working with your database at design time. For more information, see [Visual Database Tools](http://msdn.microsoft.com/en-us/6b145922-2f00-47db-befc-bf351b4809a1).  
  
 For example, at design time you might use **Server Explorer/Database Explorer** to create a connection to a database. Later, when designing a form, you can browse the database, select columns from a table, and drag them onto the [Dataset Designer](../data-tools/creating-and-editing-typed-datasets.md). This creates a [TableAdapter](../data-tools/tableadapter-overview.md) in your dataset. It also creates a new connection object, which is part of the newly created TableAdapter.  
  
 Information about design-time connections is stored on your local computer independently of a specific project or solution. Therefore, once you have established a design-time connection while working in an application, it appears in **Server Explorer/Database Explorer** whenever you work in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], as long as the server to which the connection points is available. For more information, see [How to: Connect to a Database from Server Explorer](http://msdn.microsoft.com/en-us/7c1c3067-0d77-471b-872b-639f9f50db74).  
  
 [!INCLUDE[SQLObjectExplorer](../data-tools/includes/sqlobjectexplorer_md.md)]  
  
## See Also  
 [Connecting to Data in Visual Studio](../data-tools/connecting-to-data-in-visual-studio.md)   
 [How to: Connect to Data in a Database](../data-tools/how-to-connect-to-data-in-a-database.md)   
 [Walkthrough: Connecting to Data in a Database (Windows Forms)](../Topic/Walkthrough:%20Connecting%20to%20Data%20in%20a%20Database%20\(Windows%20Forms\).md)   
 [ASP.NET Data Access Content Map](http://msdn.microsoft.com/en-us/f9219396-a0fa-481f-894d-e3d9c67d64f2)   
 [Preparing Your Application to Receive Data](../Topic/Preparing%20Your%20Application%20to%20Receive%20Data.md)   
 [Fetching Data into Your Application](../data-tools/fetching-data-into-your-application.md)   
 [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)   
 [Editing Data in Your Application](../data-tools/editing-data-in-your-application.md)   
 [Validating Data](../Topic/Validating%20Data.md)   
 [Saving Data](../data-tools/saving-data.md)