---
title: "Creating and managing databases and data-tier applications in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "managing change, databases"
  - "database features of Visual Studio, managing change"
  - "databases, managing change"
  - "managing change, database servers"
ms.assetid: 40b51f5a-d52c-44ac-8f84-037a0917af33
caps.latest.revision: 37
author: "mikeblome"
ms.author: "mblome"
manager: "ghogen"
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
# Creating and managing databases and data-tier applications in Visual Studio
> [!IMPORTANT]
>  The database projects that were included in earlier versions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] are now provided in [!INCLUDE[sql_Denali_long](../data-tools/includes/sql_denali_long_md.md)] tools. For more information, see [SQL Server Developer Tools](http://go.microsoft.com/fwlink/?LinkId=228126).  
  
 You can use database projects to create new databases, new data-tier applications (DACs), and to update existing databases and data-tier applications. Both database projects and DAC projects enable you to apply version control and project management techniques to your database development efforts in much the same way that you apply those techniques to managed or native code. You can help your development team manage changes to databases and database servers by creating a *DAC project*, *database project*, or a *server project* and putting it under version control. Members of your team can then check out files to make, build, and test changes in an *isolated development environment*, or sandbox, before sharing them with the team. To help ensure code quality, your team can finish and test all changes for a particular release of the database in a staging environment before you deploy the changes into production.  
  
 For a list of the database features that are supported by Data-tier Applications, see [Features Supported in Data-tier Applications](http://go.microsoft.com/fwlink/?LinkId=164239) on the Microsoft web site. If you use features in your database that are not supported by Data-tier Applications, you should instead use a database project to manage changes to your database.  
  
## Common High-Level Tasks  
  
|High-Level Task|Supporting Content|  
|----------------------|------------------------|  
|**Start development of a data-tier application:** A DAC is a new concept introduced with [!INCLUDE[sskatmai_r2](../data-tools/includes/sskatmai_r2_md.md)] that contains the definition for a [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database and the supporting instance objects that are used by a client-server or 3-tier application. A DAC includes database objects, such as tables and views, together with instance entities such as logins. You can use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to create a DAC project, build a DAC package file, and send that DAC package file to a database administrator for deployment onto an instance of the [!INCLUDE[ssNoVersion](../data-tools/includes/ssnoversion_md.md)] database engine.|-   [Creating and Managing Data-tier Applications](http://go.microsoft.com/fwlink/?LinkId=160741) (Microsoft web site)<br />-   [SQL Server Management Studio](http://go.microsoft.com/fwlink/?LinkId=227328)|  
|**Performing iterative database development:** If you are a developer or a tester, you check out parts of the project and then update them in an isolated development environment. By using this type of environment, you can test  your changes without affecting other members of the team. After the changes are complete, you check the files back into version control, where other team members can obtain your changes and build and deploy them to a test server.|-   [Query and Text Editors (SQL Server Management Studio)](http://go.microsoft.com/fwlink/?LinkId=227327) (Microsoft web site)<br />-   [Transact-SQL Debugger](http://go.microsoft.com/fwlink/?LinkId=227324) (Microsoft web site)|  
|**Prototyping, verifying test results, and modifying database scripts and objects:** You can use the [!INCLUDE[tsql](../data-tools/includes/tsql_md.md)] editor to perform any one of these common tasks.|-   [Query and Text Editors (SQL Server Management Studio)](http://go.microsoft.com/fwlink/?LinkId=227327) (Microsoft web site)|  
  
## See Also  
 [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)