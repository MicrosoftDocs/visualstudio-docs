---
title: Add new connections
description: Add a connection in Visual Studio to a DB or service, and explore DB contents and schemas, using Server Explorer, Cloud Explorer, or SQL Server Object Explorer.
ms.custom: SEO-VS-2020
ms.date: 03/21/2022
ms.topic: how-to
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Add new connections

You can test your connection to a database or service, and explore database contents and schemas, by using **Server Explorer**, **Cloud Explorer**, or **SQL Server Object Explorer**. The functionality of these windows overlaps to some extent. The basic differences are:

- Server Explorer

   Installed by default in Visual Studio. Can be used to test connections and view SQL Server databases, any other databases that have an ADO.NET provider installed, and some Azure services. Also shows low-level objects such as system performance counters, event logs, and message queues. If a data source has no ADO.NET provider, it won't show up here, but you can still use it from Visual Studio by connecting programmatically.

- Cloud Explorer

   Install this window manually as a Visual Studio extension from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.CloudExplorerForVS). Provides specialized functionality for exploring and connecting to Azure services.

- SQL Server Object Explorer

   Installed with SQL Server Data Tools and visible under the **View** menu. If you don't see it there, go to **Programs and Features** in Control Panel, find Visual Studio, and then select **Change** to re-run the installer after selecting the check box for SQL Server Data Tools. Use **SQL Server Object Explorer** to view SQL databases (if they have an ADO.NET provider), create new databases, modify schemas, create stored procedures, retrieve connection strings, view the data, and more. SQL databases that have no ADO.NET provider installed won't show up here, but you can still connect to them programmatically.


::: moniker range=">=vs-2022"
> [!Important]
> Cloud Explorer has been retired in Visual Studio 2022. Instead, you can use the following alternatives:
> - To debug Azure App Services or Azure Function apps, you can use the Connected Services or the Publish features available on all projects. 
>   -  If you rely on Visual Studio for publishing, you may access this feature under the "Additional Options" in the Hosting section. 
>   -  If you don’t use the publishing feature, the [Connected Services](overview-connected-services.md?view=vs-2022&preserve-view=true) node inside each Project in your Solution can help you configure access to Azure resources and invoke  various operations like remote debugging, remote profiling, starting/stopping the application, view streaming logs, and more.
> - Use [Microsoft Azure Storage Explorer](/azure/vs-azure-tools-storage-manage-with-storage-explorer) is a free, standalone app from Microsoft. You can use it to work visually with Azure Storage data on Windows, macOS, and Linux.
> - The [Kudu console](https://github.com/projectkudu/kudu/wiki/Kudu-console) gives you direct, elevated command-line access to the App Service server and its file system. This is both a valuable debugging tool and allows for CLI operations such as installing packages.
>
> If needed, you can use the Azure Portal or continue to use the Azure node of Server Explorer in previous versions of Visual Studio.
>
> For more information about Visual Studio 2022, see our [release notes](/visualstudio/releases/2022/release-notes/).

::: moniker-end

## Add a connection in Server Explorer

To create a connection to the database, click the **Add Connection** icon in **Server Explorer**, or right-click in **Server Explorer** on the **Data Connections** node and select **Add Connection**. From here, you can also connect to a database on another server, a SharePoint service, or an Azure service.

:::moniker range="<=vs-2019"
![Server Explorer New Connection icon.](../data-tools/media/raddata-server-explorer-new-connection-icon.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Server Explorer Connect to Database icon.](./media/vs-2022/connect-to-database-server-explorer.png)
:::moniker-end

This brings up the **Add Connection** dialog box. Here, we have entered the name of the SQL Server LocalDB instance.

:::moniker range="<=vs-2019"
![Add New Connection](../data-tools/media/raddata-add-new-connection-dialog.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Add New Connection dialog box.](./media/vs-2022/add-new-connection.png)
:::moniker-end

## Change the provider

If the data source is not what you want, click the **Change** button to choose a new data source and/or a new ADO.NET data provider. The new provider might ask for your credentials, depending on how you configured it.

::: moniker range=">=vs-2022"
> [!NOTE]
> If you're using Visual Studio 2022 to connect to OLEDB or ODBC data providers, you will need to be aware that Visual Studio 2022 is now a 64-bit process.
>
> This means some of the data tools in Visual Studio will not be able to connect to OLEDB or ODBC databases using 32-bit data providers. This includes the Microsoft Access 32-bit OLEDB data provider as well as other third-party 32-bit providers.
>
>If you need to maintain 32-bit applications that connect to OLEDB or ODBC, you will still be able to build and run the application with Visual Studio 2022. However, if you need to use any of the Visual Studio Data Tools such as Server Explorer, Data Source Wizard, or the DataSet Designer, you will need to use an earlier version of Visual Studio that is still a 32-bit process. The last version of Visual Studio that was a 32-bit process was Visual Studio 2019.
>
>If you plan on converting the project to be a 64-bit process you will need to update the OLEDB and ODBC data connections to use 64-bit data providers.
>
>If your application uses Microsoft Access databases, and can convert the project to 64-bit, it’s recommended that you use the 64-bit Microsoft Access Database Engine, also called Access Connectivity Engine (ACE). Please see [OLE DB Provider for Jet and ODBC driver are 32-bit versions only](/office/troubleshoot/access/jet-odbc-driver-available-32-bit-version) for more information.
>
>If you're using a third-party data provider, we recommend connecting with your vendor to see if they offer a 64-bit provider before converting the project to 64-bit.

::: moniker-end

:::moniker range="<=vs-2019"
![Change AD0.NET Data Provider.](../data-tools/media/raddata-change-ad0.net-data-provider.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Change AD0.NET Data Provider.](../data-tools/media/change-data-source.png)
:::moniker-end

## Test the connection

After you have chosen the data source, click **Test Connection**. If it doesn't succeed, you will need to troubleshoot based on the vendor's documentation.

:::moniker range="<=vs-2019"
![Test Connection succeeded.](../data-tools/media/raddata-test-connection.png)
:::moniker-end
:::moniker range=">=vs-2022"
![Test Connection succeeded.](./media/vs-2022/test-connection-succeeded.png)
:::moniker-end

If the test succeeds, you are ready to create a *data source*, which is a Visual Studio term that really means a *data model* that is based on the underlying database or service.

## See also

- [Visual Studio data tools for .NET](../data-tools/visual-studio-data-tools-for-dotnet.md)
