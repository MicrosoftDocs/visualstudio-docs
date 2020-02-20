---
title: Work with data in Visual Studio
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- data [Visual Studio]
- data access [Visual Studio]
- data [C#]
- ADO.NET, data access
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- data-storage
---
# Work with data in Visual Studio

In Visual Studio, you can create applications that connect to data in virtually any database product or service, in any format, anywhere—on a local machine, on a local area network, or in a public, private, or hybrid cloud.

For applications in JavaScript, Python, PHP, Ruby, or C++, you connect to data like you do anything else, by obtaining libraries and writing code. For .NET applications, Visual Studio provides tools that you can use to explore data sources, create object models to store and manipulate data in memory, and bind data to the user interface. Microsoft Azure provides SDKs for .NET, Java, Node.js, PHP, Python, Ruby, and mobile apps, and tools in Visual Studio for connecting to Azure Storage.

::: moniker range="vs-2017"
The following lists show just a few of the many database and storage systems that can be used from Visual Studio. The [Microsoft Azure](https://azure.microsoft.com/) offerings are data services that include all provisioning and administration of the underlying data store. The **Azure development** workload in [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) enables you to work with Azure data stores directly from Visual Studio.
::: moniker-end
::: moniker range=">=vs-2019"
The following lists show just a few of the many database and storage systems that can be used from Visual Studio. The [Microsoft Azure](https://azure.microsoft.com/) offerings are data services that include all provisioning and administration of the underlying data store. The **Azure development** workload in [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) enables you to work with Azure data stores directly from Visual Studio.
::: moniker-end

![Azure development workload](media/azure-development-workload.png)

Most of the other SQL and NoSQL database products that are listed here can be hosted on a local machine, on a local network, or in Microsoft Azure on a virtual machine. If you host the database in a Microsoft Azure virtual machine, you're responsible for managing the database itself.

**Microsoft Azure**

- SQL Database
- Azure Cosmos DB
- Storage (blobs, tables, queues, files)
- SQL Data Warehouse
- SQL Server Stretch Database
- StorSimple
- And more...

**SQL**

- SQL Server 2005-2016 (includes Express and LocalDB)
- Firebird
- MariaDB
- MySQL
- Oracle
- PostgreSQL
- SQLite
- And more...

**NoSQL**

- Apache Cassandra
- CouchDB
- MongoDB
- NDatabase
- OrientDB|
- RavenDB
- VelocityDB
- And more...

::: moniker range="vs-2017"

Many database vendors and third parties support Visual Studio integration by NuGet packages. You can explore the offerings on nuget.org or through the NuGet Package Manager in Visual Studio (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**). Other database products integrate with Visual Studio as an extension. You can browse these offerings in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or by navigating to **Tools** > **Extensions and Updates** and then selecting **Online** in the left pane of the dialog box. For more information, see [Compatible database systems for Visual Studio](../data-tools/installing-database-systems-tools-and-samples.md).

::: moniker-end

::: moniker range=">=vs-2019"

Many database vendors and third parties support Visual Studio integration by NuGet packages. You can explore the offerings on nuget.org or through the NuGet Package Manager in Visual Studio (**Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**). Other database products integrate with Visual Studio as an extension. You can browse these offerings in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) or by navigating to **Extensions** > **Manage Extensions** and then selecting **Online** in the left pane of the dialog box. For more information, see [Compatible database systems for Visual Studio](../data-tools/installing-database-systems-tools-and-samples.md).

::: moniker-end

> [!NOTE]
> Extended support for SQL Server 2005 ended on April 12, 2016. There is no guarantee that data tools in Visual Studio 2015 and later will continue to work with SQL Server 2005. For more information, see the [end-of-support announcement for SQL Server 2005](https://www.microsoft.com/sql-server/sql-server-2005).

## .NET languages

All .NET data access, including in .NET Core, is based on ADO.NET, a set of classes that defines an interface for accessing any kind of data source, both relational and non-relational. Visual Studio has several tools and designers that work with ADO.NET to help you connect to databases, manipulate the data, and present the data to the user. The documentation in this section describes how to use those tools. You can also program directly against the ADO.NET command objects. For more information about calling the ADO.NET APIs directly, see [ADO.NET](/dotnet/framework/data/adonet/index).

For data-access documentation related to ASP.NET, see [Working with Data](https://www.asp.net/web-forms/overview/presenting-and-managing-data) on the ASP.NET site. For a tutorial on using Entity Framework with ASP.NET MVC, see [Getting Started with Entity Framework 6 Code First using MVC 5](/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application).

Universal Windows Platform (UWP) apps in C# or Visual Basic can use the Microsoft Azure SDK for .NET to access Azure Storage and other Azure services. The Windows.Web.HttpClient class enables communication with any RESTful service. For more information, see [How to connect to an HTTP server using Windows.Web.Http](https://msdn.microsoft.com/library/windows/apps/dn469430.aspx).

For data storage on the local machine, the recommended approach is to use SQLite, which runs in the same process as the app. If an object-relational mapping (ORM) layer is required, you can use Entity Framework. For more information, see [Data access](/windows/uwp/data-access/index) in the Windows Developer Center.

If you are connecting to Azure services, be sure to download the latest [Azure SDK tools](https://azure.microsoft.com/downloads/).

### Data providers

For a database to be consumable in ADO.NET, it must have a custom *ADO.NET data provider* or else must expose an ODBC or OLE DB interface. Microsoft provides a [list of ADO.NET data providers](/dotnet/framework/data/adonet/ado-net-overview) for SQL Server products, as well as ODBC and OLE DB providers.

### Data modeling

In .NET, you have three choices for modeling and manipulating data in memory after you have retrieved it from a data source:

[Entity Framework](../data-tools/entity-data-model-tools-in-visual-studio.md)
The preferred Microsoft ORM technology. You can use it to program against relational data as first-class .NET objects. For new applications, it should be the default first choice when a model is required. It requires custom support from the underlying ADO.NET provider.

[LINQ to SQL](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
An earlier-generation object-relational mapper. It works well for less complex scenarios but is no longer in active development.

[Datasets](../data-tools/dataset-tools-in-visual-studio.md)
The oldest of the three modeling technologies. It is designed primarily for rapid development of "forms over data" applications in which you are not processing huge amounts of data or performing complex queries or transformations. A DataSet object consists of DataTable and DataRow objects that logically resemble SQL database objects much more than .NET objects. For relatively simple applications based on SQL data sources, datasets might still be a good choice.

There is no requirement to use any of these technologies. In some scenarios, especially where performance is critical, you can simply use a DataReader object to read from the database and copy the values that you need into a collection object such as List\<T>.

## Native C++

C++ applications that connect to SQL Server should use the [Microsoft® ODBC Driver 13.1 for SQL Server](https://www.microsoft.com/download/details.aspx?id=53339) in most cases. If the servers are linked, then OLE DB is necessary and for that you use the [SQL Server Native Client](/sql/relational-databases/native-client/sql-server-native-client). You can access other databases by using [ODBC](/sql/odbc/microsoft-open-database-connectivity-odbc?view=sql-server-2017) or OLE DB drivers directly. ODBC is the current standard database interface, but most database systems provide custom functionality that can't be accessed through the ODBC interface. OLE DB is a legacy COM data-access technology that is still supported but not recommended for new applications. For more information, see [Data Access in Visual C++](/cpp/data/data-access-in-cpp).

C++ programs that consume REST services can use the [C++ REST SDK](https://github.com/Microsoft/cpprestsdk).

C++ programs that work with Microsoft Azure Storage can use the [Microsoft Azure Storage Client](https://www.nuget.org/packages/Microsoft.Azure.Storage.CPP).

Data modeling&mdash;Visual Studio does not provide an ORM layer for C++. [ODB](https://www.codesynthesis.com/products/odb/) is a popular open-source ORM for C++.

To learn more about connecting to databases from C++ apps, see [Visual Studio data tools for C++](../data-tools/visual-studio-data-tools-for-cpp.md). For more information about legacy Visual C++ data-access technologies, see [Data Access](/cpp/data/data-access-in-cpp).

## JavaScript

[JavaScript in Visual Studio](/scripting/javascript/javascript-language-reference) is a first-class language for building cross-platform apps, UWP apps, cloud services, websites, and web apps. You can use Bower, Grunt, Gulp, npm, and NuGet from within Visual Studio to install your favorite JavaScript libraries and database products. Connect to Azure storage and services by downloading SDKs from the [Azure website](https://azure.microsoft.com/). Edge.js is a library that connects server-side JavaScript (Node.js) to ADO.NET data sources.

## Python

Install [Python support in Visual Studio](../python/overview-of-python-tools-for-visual-studio.md) to create Python applications. The Azure documentation has several tutorials on connecting to data, including the following:

- [Django and SQL Database on Azure](/azure/app-service/app-service-web-get-started-python)
- [Django and MySQL on Azure](/azure/app-service-web/web-sites-python-ptvs-django-mysql)
- Work with [blobs](/azure/storage/blobs/storage-quickstart-blobs-python), [files](/azure/storage/files/storage-python-how-to-use-file-storage), [queues](/azure/storage/queues/storage-python-how-to-use-queue-storage), and [tables (Cosmo DB)](/azure/cosmos-db/table-storage-how-to-use-python).

## Related topics

[Microsoft AI platform](https://azure.microsoft.com/overview/ai-platform/?v=17.42w)&mdash;Provides an introduction to the Microsoft intelligent cloud, including Cortana Analytics Suite and support for Internet of Things.

[Microsoft Azure Storage](/azure/storage/)&mdash;Describes Azure Storage, and how to create applications by using Azure blobs, tables, queues, and files.

[Azure SQL Database](/azure/sql-database/)&mdash;Describes how to connect to Azure SQL Database, a relational database as a service.

[SQL Server Data Tools](/sql/ssdt/download-sql-server-data-tools-ssdt)&mdash;Describes the tools that simplify design, exploration, testing, and deploying of data-connected applications and databases.

[ADO.NET](/dotnet/framework/data/adonet/index)&mdash;Describes the ADO.NET architecture and how to use the ADO.NET classes to manage application data and interact with data sources and XML.

[ADO.NET Entity Framework](/ef/ef6/)&mdash;Describes how to create data applications that allow developers to program against a conceptual model instead of directly against a relational database.

[WCF Data Services 4.5](/dotnet/framework/data/wcf/index)&mdash;Describes how to use [!INCLUDE[ssAstoria](../data-tools/includes/ssastoria_md.md)] to deploy data services on the web or an intranet that implement the [Open Data Protocol (OData)](https://www.odata.org/).

[Data in Office Solutions](../vsto/data-in-office-solutions.md)&mdash;Contains links to topics that explain how data works in Office solutions. This includes information about schema-oriented programming, data caching, and server-side data access.

[LINQ (Language-Integrated Query)](/dotnet/csharp/linq/)&mdash;Describes the query capabilities built into C# and Visual Basic, and the common model for querying relational databases, XML documents, datasets, and in-memory collections.

[XML Tools in Visual Studio](../xml-tools/xml-tools-in-visual-studio.md)&mdash;Discusses working with XML data, debugging XSLT, .NET XML features, and the architecture of XML Query.

[XML Documents and Data](/dotnet/standard/data/xml/index)&mdash;Provides an overview to a comprehensive and integrated set of classes that work with XML documents and data in .NET.
