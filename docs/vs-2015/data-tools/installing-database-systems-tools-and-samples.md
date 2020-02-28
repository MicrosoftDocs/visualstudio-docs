---
title: "Installing database systems, tools, and samples | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "sample databases"
  - "databases, samples"
ms.assetid: 821de34b-eaa9-40af-b9aa-b8305de16899
caps.latest.revision: 31
author: jillre
ms.author: jillfra
manager: jillfra
---
# Installing database systems, tools, and samples
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio itself does not include any database systems other than those it uses internally. To develop a data-connected application in Visual Studio, you typically install the database system on your local development machine, and then deploy the application and database to a production environment when they are ready. For the database system to be accessible from .NET applications and to be visible in Visual Studio data tools windows, it must have an ADO.NET data provider. A provider must specifically support Entity Framework if you plan to use Entity data models in your .NET application.     Many providers are offered through the NuGet Package Manager or through the Visual Studio Gallery.

 For SQL development, ensure that you have SQL Server Data Tools installed in Visual Studio. Click the **View** menu. If you don't see SQL Server Object Explorer, go to Control Panel and change Visual Studio. In the installer, select **Microsoft SQL Server Data Tools**.

 If you are using Azure Storage APIs,   install the Azure storage emulators on your local machine during development in order to avoid charges until you are ready to deploy to production. For more information, see [Use the Azure Storage Emulator for Development and Testing](https://azure.microsoft.com/documentation/articles/storage-use-emulator/).

 The following list includes some of the more popular database systems that can be used in Visual Studio projects. The list is not exhaustive. For a list of third-party vendors that offer ADO.NET data providers that enable deep integration with Visual Studio tooling, see [ADO.NET Data Providers](https://msdn.microsoft.com/library/dd363565.aspx).

### Microsoft SQL Server
 SQL Server is the Microsoft flagship database offering. SQL Server 2016 delivers breakthrough performance, advanced security, and rich, integrated reporting and analytics. It ships in various editions that are designed for different uses: from highly scalable, high-performance business analytics, to use on a single computer. SQL Server Express is a full-featured edition of SQL Server that is tailored for redistribution and embedding.  LocalDB is a simplified edition of SQL Server Express that requires no configuration and runs in your application's process. You can download either or both products from [the SQL Server Express download page](https://www.microsoft.com/sql-server/sql-server-editions-express). Many of the SQL examples in this section use SQL Server LocalDB. SQL Server Management Studio (SSMS) is a stand-alone database management application that has more functionality than what is provided in Visual Studio SQL Server Object Explorer. You can get SSMS from the previous link.

### Oracle
 You can download a paid or free edition of the Oracle database from the [Oracle Technology Network](http://www.oracle.com/technetwork/database/enterprise-edition/downloads/index-092322.html) page. For design-time support for Entity Framework and TableAdapters, you will need the [Oracle Developer Tools for Visual Studio](https://www.oracle.com/database/technologies/developer-tools/visual-studio/). Other official Oracle products, including the Oracle Instant Client, are available through the NuGet Package Manager.  You can download Oracle sample schemas by following the instructions in the [Oracle Online Documentation](https://docs.oracle.com/cd/E11882_01/server.112/e10831/toc.htm).

### MySQL
 MySQL is a popular open-source database system that is widely used in enterprises and websites. Downloads for MySQL, MySQL for Visual Studio, and related products are at [MySQL on Windows](https://www.mysql.com/why-mysql/windows/).  Third parties offer various Visual Studio extensions and stand-alone management applications for MySQL. You can browse the offerings in the NuGet Package Manager (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**).

### PostgreSQL
 PostgreSQL is a free, open-source object relational database system. To install it on Windows, you can download it from the [PostgreSQL download page](http://www.postgresql.org/download/windows/).  You can also build PostgreSQL from the source code.  The PostgreSQL core system includes a C language interface. Many third parties provide NuGet packages for using PostgreSQL from .NET applications.  You can browse the offerings in the NuGet Package Manager (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**). Perhaps the most popular package is provided by [npgsql.org](http://www.npgsql.org/).

### SQLite
 SQLite is an embedded SQL database engine that runs in the application's own process. You can download it from the [SQLite download page](http://www.sqlite.org/download.html). Many third-party NuGet packages for SQLite are also available. You can browse the offerings in the NuGet Package Manager (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**).

### Firebird
 Firebird is an open-source SQL database system. You can download it from the [Firebird download page](http://firebirdsql.org/en/downloads/). An ADO.NET data provider is available through the NuGet Package Manager.

## See Also
 [How to determine the version and edition of SQL Server and its components](https://support.microsoft.com/help/321185/how-to-determine-the-version-edition-and-update-level-of-sql-server-an)
