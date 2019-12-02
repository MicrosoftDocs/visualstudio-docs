---
title: "Accessing data"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
f1_keywords:
  - "80025080"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data [Visual Studio]"
  - "data access [Visual Studio]"
  - "data [C#]"
  - "ADO.NET, data access"
ms.assetid: 9812a6d5-23d2-4427-8b98-70a2abfec3bc
caps.latest.revision: 103
author: jillre
ms.author: jillfra
manager: jillfra
robots: noindex,nofollow
---
# Accessing data in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can create applications that connect to data in virtually any database product or service, in any format, anywhere—on a local machine, on a local area network, or in a public, private, or hybrid cloud.

 For applications in JavaScript, Python, PHP, Ruby, or C++, you connect to data like you do anything else, by obtaining libraries and writing code. For .NET applications, Visual Studio provides tools that you can use to explore data sources,  create object models to store and manipulate data in memory, and bind data to the user interface.     Microsoft Azure provides SDKs for .NET, Java, Node.js, PHP, Python, Ruby, and mobile apps, and tools in Visual Studio for connecting to Azure Storage.

 The following lists show just a few of the many database and storage systems that can be used from Visual Studio. The [Microsoft Azure](https://azure.microsoft.com/) offerings are data services that include all provisioning and administration of the  underlying data store.  [Azure Tools for Visual Studio](https://www.visualstudio.com/features/azure-tools-vs.aspx) is an optional component that enables you to work with Azure data stores directly from Visual Studio. Most of the other SQL and NoSQL database products that are listed here can be hosted on a local machine, on a local network, or in Microsoft Azure on a virtual machine. In this scenario, you are responsible for managing the database itself.

 **Microsoft Azure**

||||
|-|-|-|
|SQL Database|DocumentDB|Storage (blobs, tables, queues, files)|
|SQL Data Warehouse|SQL Server Stretch Database|StorSimple|

 And more...

 **SQL**

||||
|-|-|-|
|SQL Server 2005–2016, including Express and LocalDB|Firebird|MariaDB|
|MySQL|Oracle|PostgreSQL|
|SQLite|||

 And more...

 **NoSQL**

||||
|-|-|-|
|Apache Cassandra|CouchDB|MongoDB|
|NDatabase|OrientDB|RavenDB|
|VelocityDB|||

 And more...

 Many database vendors and third parties support Visual Studio integration by NuGet packages. You can explore the offerings on nuget.org or through the NuGet Package Manager in Visual Studio (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**). Other database products integrate with Visual Studio as an extension.   You can browse these offerings in the Visual Studio Gallery by navigating to **Tools** > **Extensions and Updates** and then selecting **Online** in the left pane of the dialog box.  For more information, see [Installing database systems, tools, and samples](../data-tools/installing-database-systems-tools-and-samples.md).

> [!NOTE]
> Extended support for SQL Server 2005 ended on April 12, 2016.   There is no guarantee that data tools in Visual Studio 2015 and later will continue to work with SQL Server 2005 after this date. For more information, see the [end-of-support announcement for SQL Server 2005](https://www.microsoft.com/sql-server/sql-server-2005).

### .NET languages
 All .NET data access, including in .NET Core,  is based on ADO.NET, a set of classes that defines an interface for accessing any kind of data source, both relational and non-relational. Visual Studio has several tools and designers that work with ADO.NET to help you connect to databases, manipulate the data, and present the data to the user. The documentation in this section describes how to use those tools. You can also program directly against the ADO.NET command objects. For more information about calling the ADO.NET APIs directly, see [ADO.NET](https://msdn.microsoft.com/library/e80y5yhx\(v=vs.110\).aspx) in the MSDN Library.

 For data-access documentation specifically related to ASP.NET, see  [Working with Data](https://docs.microsoft.com/aspnet/web-forms/overview/presenting-and-managing-data/) on the ASP.NET site. For a tutorial on using Entity Framework with ASP.NET MVC, see [Getting Started with Entity Framework 6 Code First using MVC 5](https://docs.microsoft.com/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application).

 Universal Windows Platform (UWP) apps in C# or Visual Basic can use the      Microsoft Azure SDK for .NET to access Azure Storage and other Azure services. The Windows.Web.HttpClient class enables communication with any RESTful service. For more information, see [How to connect to an HTTP server using Windows.Web.Http](https://msdn.microsoft.com/library/windows/apps/dn469430.aspx).

 For data storage on the local machine, the recommended approach is to use SQLite, which runs in the same process as the app. If an object-relational mapping (ORM) layer is required, you can use Entity Framework. For more information, see [Data access](https://msdn.microsoft.com/windows/uwp/data-access/index) in the Windows Developer Center.

 If you are connecting to Azure services, be sure to download the latest [Azure SDK tools](https://azure.microsoft.com/downloads/).

#### Data providers
 For a database to be consumable in ADO.NET, it must have a custom *ADO.NET data provider* or else must expose an ODBC or OLE DB interface. Microsoft provides a [list of ADO.NET data providers](https://msdn.microsoft.com/data/dd363565) for SQL Server products as well as ODBC and OLE DB providers.

#### Data modeling
 In .NET, you have three choices for modeling and manipulating data in memory after you have retrieved it from a data source:

 Entity Framework
 The preferred Microsoft ORM technology. You can use it to program against relational data as first-class .NET objects. For new applications, it should be the default first choice when a model is required. It requires custom support from the underlying ADO.NET provider.

 LINQ to SQL
 An earlier-generation object-relational mapper. It works well for less complex scenarios but is no longer in active development.

 Datasets
 The oldest of the three modeling technologies. It is designed primarily for rapid development of "forms over data" applications in which you are not processing huge amounts of data or performing complex queries or transformations. A DataSet object consists of DataTable and  DataRow objects that logically resemble SQL database objects much more than .NET objects. For  relatively simple applications based on SQL data sources, datasets might still be a good choice.

 There is no requirement to use any of these technologies. In some scenarios, especially where performance is critical, you can simply use a DataReader object to read from the database and copy the values that you need into a collection object such as List\<T>.

### Native C++
 C++ applications that connect to SQL Server should use the [SQL Server Native Client](https://msdn.microsoft.com/sqlserver/aa937733.aspx). You can access other databases by  using [ODBC](https://msdn.microsoft.com/library/ms710252\(v=vs.85\).aspx) or OLE DB drivers directly. ODBC is the current standard database interface, but most database systems provide custom functionality that can't be accessed through the ODBC interface.  OLE DB is a legacy COM data-access technology that is still supported but not recommended for new applications.  For more information, see [Data Access](https://msdn.microsoft.com/library/a9455752-39c4-4457-b14e-197772d3df0b).

 C++ programs that consume REST services can use the [C++ REST SDK](https://github.com/Microsoft/cpprestsdk).

 C++ programs that work with Microsoft Azure Storage can use the [Microsoft Azure Storage Client](https://www.nuget.org/packages/wastorage).

#### Data modeling
 Visual Studio  does not provide an ORM layer for C++.  [ODB](https://www.codesynthesis.com/products/odb/) is a popular open-source ORM for C++.

 For more information about legacy Visual C++ data-access technologies, see  [Data Access](https://msdn.microsoft.com/library/a9455752-39c4-4457-b14e-197772d3df0b)

### JavaScript
 [JavaScript in Visual Studio](https://msdn.microsoft.com/library/hh334522.aspx) is a first-class language for building cross-platform apps, UWP apps, cloud services, websites, and web apps. You can use Bower, Grunt, Gulp, npm, and NuGet  from within Visual Studio to install your favorite JavaScript libraries and database products. Connect to Azure storage and services by downloading SDKs from the [Azure website](https://azure.microsoft.com/).  Edge.js is a library that connects server-side JavaScript (Node.js) to ADO.NET data sources.

### Python
 Install  [Python Tools for Visual Studio](http://microsoft.github.io/PTVS/) along with your favorite Python framework to create CPython or IronPython (.NET)  applications.  The Python Tools for Visual Studio website has several tutorials on connecting to data, including [Django and SQL Database on Azure](https://github.com/Microsoft/PTVS/wiki/Django-and-SQL-Database-on-Azure), [Django and MySQL on Azure](https://github.com/Microsoft/PTVS/wiki/Django-and-MySQL-on-Azure) and [Bottle and MongoDB on Azure](https://github.com/Microsoft/PTVS/wiki/Bottle-and-MongoDB-on-Azure).

## In this section
 [Installing database systems, tools, and samples](../data-tools/installing-database-systems-tools-and-samples.md)
 Discusses how to obtain database products and the Visual Studio extensions or drivers that support them, and where to find sample databases for experimentation and learning purposes.

 [Visual Studio data tools for .NET](https://msdn.microsoft.com/6b145922-2f00-47db-befc-bf351b4809a1)
 Describes how to use Visual Studio tool windows to connect to data sources, create datasets or Entity Framework models, and bind the data to user interface controls.

## Related topics
 [Data, Devices, and Analytics](https://msdn.microsoft.com/data-and-devices)
 Provides an introduction to the Microsoft intelligent cloud, including Cortana Analytics Suite and support for Internet of Things.

 [Microsoft Azure Storage](/azure/storage/)
 Describes Azure Storage, and how to create applications by  using Azure blobs, tables, queues, and files.

 [Azure SQL Database](https://azure.microsoft.com/documentation/services/sql-database/)
 Describes how to connect to Azure SQL Database, a relational database as a service.

 [SQL Server Data Tools](https://msdn.microsoft.com/library/hh272686\(v=vs.103\).aspx)
 Describes the tools that simplify design, exploration, testing, and deploying of data-connected applications and databases.

 [ADO.NET](https://msdn.microsoft.com/library/5b96ed06-9759-4966-a797-a1d5f6ee50ca)
 Describes the ADO.NET architecture and how to use the ADO.NET classes to manage application data and interact with data sources and XML.

 [ADO.NET Entity Framework](https://msdn.microsoft.com/data/ef)
 Describes how to create data applications that allow developers to program against a conceptual model instead of directly against a relational database.

 [WCF Data Services 4.5](https://msdn.microsoft.com/library/73d2bec3-7c92-4110-b905-11bb0462357a)
 Describes how to use [!INCLUDE[ssAstoria](../includes/ssastoria-md.md)] to deploy data services on the web or an intranet that implement the [Open Data Protocol (OData)](https://go.microsoft.com/fwlink/?LinkID=182204).

 [Data in Office Solutions](https://msdn.microsoft.com/library/8478c095-864b-4ed3-8a70-1fc19b411c6a)
 Contains links to topics that explain how data works in Office solutions. This includes information about schema-oriented programming, data caching, and server-side data access.

 [LINQ (Language-Integrated Query)](https://msdn.microsoft.com/library/a73c4aec-5d15-4e98-b962-1274021ea93d)
 Describes the query capabilities built into C# and Visual Basic, and the common model for querying relational databases, XML documents, datasets, and in-memory collections.

 [XML Tools in Visual Studio](../xml-tools/xml-tools-in-visual-studio.md)
 Discusses working with XML data, debugging XSLT, .NET Framework XML features, and the architecture of XML Query.

 [XML Documents and Data](https://msdn.microsoft.com/library/e695047f-3c0f-4045-8708-5baea91cc380)
 Provides an overview to a comprehensive and integrated set of classes that work with XML documents and data in the .NET Framework.
