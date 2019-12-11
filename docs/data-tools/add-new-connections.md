---
title: Add new connections
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Add new connections

You can test your connection to a database or service, and explore database contents and schemas, by using **Server Explorer**, **Cloud Explorer**, or **SQL Server Object Explorer**. The functionality of these windows overlaps to some extent. The basic differences are:

- Server Explorer

   Installed by default in Visual Studio. Can be used to test connections and view SQL Server databases, any other databases that have an ADO.NET provider installed, and some Azure services. Also shows low-level objects such as system performance counters, event logs, and message queues. If a data source has no ADO.NET provider, it won't show up here, but you can still use it from Visual Studio by connecting programmatically.

- Cloud Explorer

   Install this window manually as a Visual Studio extension from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.CloudExplorerForVS). Provides specialized functionality for exploring and connecting to Azure services.

- SQL Server Object Explorer

   Installed with SQL Server Data Tools and visible under the **View** menu. If you don't see it there, go to **Programs and Features** in Control Panel, find Visual Studio, and then select **Change** to re-run the installer after selecting the check box for SQL Server Data Tools. Use **SQL Server Object Explorer** to view SQL databases (if they have an ADO.NET provider), create new databases, modify schemas, create stored procedures, retrieve connection strings, view the data, and more. SQL databases that have no ADO.NET provider installed won't show up here, but you can still connect to them programmatically.

## Add a connection in Server Explorer

To create a connection to the database, click the **Add Connection** icon in **Server Explorer**, or right-click in **Server Explorer** on the **Data Connections** node and select **Add Connection**. From here, you can also connect to a database on another server, a SharePoint service, or an Azure service.

![Server Explorer New Connection icon](../data-tools/media/raddata-server-explorer-new-connection-icon.png)

This brings up the **Add Connection** dialog box. Here, we have entered the name of the SQL Server LocalDB instance.

![Add New Connection](../data-tools/media/raddata-add-new-connection-dialog.png)

## Change the provider

If the data source is not what you want, click the **Change** button to choose a new data source and/or a new ADO.NET data provider. The new provider might ask for your credentials, depending on how you configured it.

![Change AD0.NET Data Provider](../data-tools/media/raddata-change-ad0.net-data-provider.png)

## Test the connection

After you have chosen the data source, click **Test Connection**. If it doesn't succeed, you will need to troubleshoot based on the vendor's documentation.

![Test Connection](../data-tools/media/raddata-test-connection.png)

If the test succeeds, you are ready to create a *data source*, which is a Visual Studio term that really means a *data model* that is based on the underlying database or service.

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
