---
title: Add a connection to Azure SQL Database | Microsoft Docs
description: Add Azure SQL Database connection to your app by using the Visual Studio Connected Services
author: AngelosP
manager: jmartens
ms.technology: vs-azure
ms.workload: azure-vs
ms.topic: conceptual
ms.date: 08/17/2020
ms.author: angelpe
monikerRange: ">= vs-2019"
---
# Add a connection to Azure SQL Database

With Visual Studio, you can connect any of the following to Azure SQL Database by using the **Connected Services** feature:

- .NET Framework console app
- ASP.NET MVC (.NET Framework) 
- ASP.NET Core
- .NET Core (including console app, WPF, Windows Forms, class library)
- .NET Core Worker Role
- Azure Functions
- Universal Windows Platform App
- Xamarin
- Cordova

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Connected services in Visual Studio for Mac](/visualstudio/mac/connected-services).
## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types

## Connect to Azure SQL Database using Connected Services

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Add Service Dependency](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure SQL Database**.

    ![Add Azure SQL Database Service](./media/azure-sql-database-add-connected-service/azure-sql-database.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure SQL Database** screen, select an existing Azure SQL Database, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Connect to existing Azure SQL Database component](./media/azure-sql-database-add-connected-service/created-azure-sql-database.png)

1. To create an Azure SQL Database:

   1. Select **Create a SQL Database** at the bottom of the screen.

   1. Fill out the **Azure SQL Database: Create new** screen, and select **Create**.

       ![New Azure SQL Database](./media/azure-sql-database-add-connected-service/create-new-azure-sql-database.png)

   1. When the **Configure Azure SQL Database** screen is displayed, the new database appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection string name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Specify connection string](./media/azure-sql-database-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Summary of changes](./media/azure-sql-database-add-connected-service/summary-of-changes.png)

   If prompted to set a firewall rules, choose **Yes**.

   ![Firewall rules](./media/azure-sql-database-add-connected-service/firewall-rules.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Service dependencies](./media/azure-sql-database-add-connected-service/service-dependencies-after.png)

## See also

- [Azure SQL Database product page](https://azure.microsoft.com/services/sql-database/)
- [Azure SQL Database documentation](/azure/azure-sql/database/)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)
