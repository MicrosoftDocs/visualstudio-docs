---
title: "Accessing Local and Remote Data in ClickOnce Applications"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: be5cbe12-6cb6-49c9-aa59-a1624e1eef3d
caps.latest.revision: 21
manager: wpickett
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Accessing Local and Remote Data in ClickOnce Applications
Most applications consume or produce data. ClickOnce gives you a variety of options for reading and writing data, both locally and remotely.  
  
## Local Data  
 With ClickOnce, you can load and store data locally by using any one of the following methods:  
  
-   ClickOnce Data Directory  
  
-   Isolated Storage  
  
-   Other Local Files  
  
### ClickOnce Data Directory  
 Every ClickOnce application installed on a local computer has a data directory, stored in the user's Documents and Settings folder. Any file included in a ClickOnce application and marked as a "data" file is copied to this directory when an application is installed. Data files can be of any file type, the most frequently used being text, XML, and database files such as Microsoft Access .mdb files.  
  
 The data directory is intended for application-managed data, which is data that the application explicitly stores and maintains. All static, nondependency files not marked as "data" in the application manifest will instead reside in the Application Directory. This directory is where the application's executable (.exe) files and assemblies reside.  
  
> [!NOTE]
>  When a ClickOnce application is uninstalled, its Data Directory is also removed. Never use the Data Directory to store end-user–managed data, such as documents.  
  
#### Marking Data Files in a ClickOnce Distribution  
 To put an existing file inside the Data Directory, you must mark the existing file as a data file in your ClickOnce application's application manifest file. For more information, see [How to: Include a Data File in a ClickOnce Application](../VS_IDE/How-to--Include-a-Data-File-in-a-ClickOnce-Application.md).  
  
#### Reading from and Writing to the Data Directory  
 Reading from the Data Directory requires that your ClickOnce application request Read permission; similarly, writing to the directory requires Write permission. Your application will automatically have this permission if it is configured to run with Full Trust. For more information about elevating permissions for your application by using either Permission Elevation or Trusted Application Deployment, see [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md).  
  
> [!NOTE]
>  If your organization does not use Trusted Application Deployment and has turned off Permission Elevation, asserting permissions will fail.  
  
 After your application has these permissions, it can access the Data Directory by using method calls on classes within the <xref:System.IO?qualifyHint=False>. You can obtain the path of the Data Directory within a Windows Forms ClickOnce application by using the <xref:System.Deployment.Application.ApplicationDeployment.DataDirectory?qualifyHint=False> property defined on the <xref:System.Deployment.Application.ApplicationDeployment.CurrentDeployment?qualifyHint=False> property of <xref:System.Deployment.Application.ApplicationDeployment?qualifyHint=False>. This is the most convenient and recommended way to access your data. The following code example demonstrates how to do this for a text file named CSV.txt that you have included in your deployment as a data file.  
  
 [!CODE [ClickOnce.OpenDataFile#1](../CodeSnippet/VS_Snippets_Winforms/ClickOnce.OpenDataFile#1)]  
  
 For more information on marking files in your deployment as data files, see [How to: Include a Data File in a ClickOnce Application](../VS_IDE/How-to--Include-a-Data-File-in-a-ClickOnce-Application.md).  
  
 You can also obtain the data directory path using the relevant variables on the <xref:System.Windows.Forms.Application?qualifyHint=False> class, such as <xref:System.Windows.Forms.Application.LocalUserAppDataPath?qualifyHint=False>.  
  
 Manipulating other types of files might require additional permissions. For example, if you want to use an Access database (.mdb) file, your application must assert full trust in order to use the relevant <xref:System.Data?qualifyHint=False> classes.  
  
#### Data Directory and Application Versions  
 Each version of an application has its own Data Directory, which is isolated from other versions. ClickOnce creates this directory regardless of whether any data files are included in the deployment so that the application has a location to create new data files at run time. When a new version of an application is installed, ClickOnce will copy all the existing data files from the previous version's Data Directory into the new version's Data Directory—whether they were included in the original deployment or created by the application.  
  
 ClickOnce will replace the older version of the file with the newer version of the server if a data file has a different hash value in the old version of the application as in the new version. Also, if the earlier version of the application created a new file that has the same name as a file included in the new version's deployment, ClickOnce will overwrite the old version's file with the new file. In both cases, the old files will be included in a subdirectory inside the data directory named `.pre`, so that the application can still access the old data for migration purposes.  
  
 If you need finer-grained migration of data, you can use the ClickOnce Deployment API to perform custom migration from the old Data Directory to the new Data Directory. You will have to test for an available download by using <xref:System.Deployment.Application.ApplicationDeployment.IsFirstRun?qualifyHint=False>, download the update using <xref:System.Deployment.Application.ApplicationDeployment.Update?qualifyHint=False> or <xref:System.Deployment.Application.ApplicationDeployment.UpdateAsync?qualifyHint=False>, and do any custom data migration work in your own after the update is finished.  
  
### Isolated Storage  
 Isolated Storage provides an API for creating and accessing files by using a simple API. The actual location of the stored files is hidden from both the developer and the user.  
  
 Isolated Storage works in all versions of the .NET Framework. Isolated Storage also works in partially trusted applications without the need for additional permission grants. You should use Isolated Storage if your application must run in partial trust, but must maintain application-specific data.  
  
 For more information, see [Isolated Storage](../Topic/Isolated%20Storage.md).  
  
### Other Local Files  
 If your application must work with or save end-user data such as reports, images, music, and so on, your application will require <xref:System.Security.Permissions.FileIOPermission?qualifyHint=False> to read and write data to the local file system.  
  
## Remote Data  
 At some point, your application will likely have to retrieve information from a remote Web site, such as customer data or market information. This section discusses the most common techniques for retrieving remote data.  
  
### Accessing Files by Using HTTP  
 You can access data from a Web server by using either the <xref:System.Net.WebClient?qualifyHint=False> or the <xref:System.Net.HttpWebRequest?qualifyHint=False> class in the <xref:System.Net?qualifyHint=False> namespace. The data can be either static files or ASP.NET applications that return raw text or XML data. If your data is in XML format, the fastest way to retrieve the data is by using the <xref:System.Xml.XmlDocument?qualifyHint=False> class, whose <xref:System.Xml.XmlDocument.Load?qualifyHint=False> method takes a URL as an argument. For an example, see [Reading an XML Document into the DOM](../Topic/Reading%20an%20XML%20Document%20into%20the%20DOM.md).  
  
 You have to consider security when your application accesses remote data over HTTP. By default, your ClickOnce application's access to network resources may be restricted, depending on how your application was deployed. These restrictions are applied to prevent malicious programs from gaining access to privileged remote data or from using a user's computer to attack other computers on the network.  
  
 The following table lists the deployment strategies you might use and their default Web permissions.  
  
|Deployment type|Default network permissions|  
|---------------------|---------------------------------|  
|Web Install|Can only access the Web server from which the application was installed|  
|File Share Install|Cannot access any Web servers|  
|CD-ROM Install|Can access any Web servers|  
  
 If your ClickOnce application cannot access a Web server because of security restrictions, the application must assert <xref:System.Net.WebPermission?qualifyHint=False> for that Web site. For more information about increasing security permissions for a ClickOnce application, see [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md).  
  
### Accessing Data through an XML Web Service  
 If you expose your data as an XML Web service, you can access the data by using an XML Web service proxy. The proxy is a .NET Framework class you create by using either Visual Studio. The operations of the XML Web service—such as retrieving customers, placing orders, and so on—are exposed as methods on the proxy. This makes Web services much easier to use than raw text or XML files.  
  
 If your XML Web service operates over HTTP, the service will be bound by the same security restrictions as the <xref:System.Net.WebClient?qualifyHint=False> and <xref:System.Net.HttpWebRequest?qualifyHint=False> classes.  
  
### Accessing a Database Directly  
 You can use the classes within the <xref:System.Data?qualifyHint=False> namespace to establish direct connections with a database server such as SQL Server on your network, but you must account for the security issues. Unlike HTTP requests, database connection requests are always forbidden by default under partial trust; you will only have such permission by default if you install your ClickOnce application from a CD-ROM. This gives your application full trust. To enable access to a specific SQL Server database, your application must request <xref:System.Data.SqlClient.SqlClientPermission?qualifyHint=False> to it; to enable access to a database other than SQL Server, it must request <xref:System.Data.OleDb.OleDbPermission?qualifyHint=False>.  
  
 Most of the time, you will not have to access the database directly, but will access it instead through a Web server application written in ASP.NET or an XML Web service. Accessing the database in this manner is frequently the best method if your ClickOnce application is deployed from a Web server. You can access the server in partial trust without elevating your application's permissions.  
  
## See Also  
 [How to: Include a Data File in a ClickOnce Application](../VS_IDE/How-to--Include-a-Data-File-in-a-ClickOnce-Application.md)