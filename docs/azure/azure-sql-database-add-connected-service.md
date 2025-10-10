---
title: Add a connection to Azure SQL Database
description: Connect Azure SQL Database to your application by using Connected Services in Visual Studio on Windows and add a connected service.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: conceptual
ms.date: 10/2/2025
ms.author: ghogen
monikerRange: ">= vs-2019"
ms.custom: sfi-image-nochange
---

# Add a connection to an Azure SQL Database

With Visual Studio Connected Services, you can connect to Azure SQL Database, a local emulator (for example, during development), or an on-premises SQL Server database. For on-premises SQL Server, see [Connect to a database](../data-tools/add-new-connections.md).

With Visual Studio, you can connect from any of the following project types by using the **Connected Services** feature:

- ASP.NET Core
- .NET Core (including console app, WPF, Windows Forms, class library)
- .NET Core Worker Role
- Azure Functions
- .NET Framework console app
- ASP.NET Model-View-Controller (MVC) (.NET Framework)
- Universal Windows Platform App

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Connect to Azure SQL Database using Connected Services

:::moniker range=">=vs-2022"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/vs-2022/add-connected-service-context-menu-2.png)

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. Choose **SQL Server Database**. The **Connect to dependency** page appears. You should see several options:

   - SQL Server Express LocalDB, the built-in SQL Database offering installed with Visual Studio
   - SQL Server Database on a local container on your machine
   - SQL Server Database, an on-premises SQL Server on the local network
   - Azure SQL Database, for the SQL Database running as an Azure service

   You can reduce cost and simplify early development by starting with a local database. You can migrate to the live service in Azure later by repeating these steps and choosing another option. If you create a database locally that you want to re-create in Azure, you can migrate your database to Azure at that time.

   ![Screenshot showing SQL Database choices.](./media/vs-2022/sql-database-choices-2.png)

   If you want to connect to the Azure service, continue to the next step, or if you aren't signed in already, sign in to your Azure account before continuing. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

1. In the **Configure Azure SQL Database** screen, select an existing Azure SQL Database, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot showing "Connect to existing Azure SQL Database component" screen.](./media/azure-sql-database-add-connected-service/created-azure-sql-database.png)

1. To create an Azure SQL database:

   1. Select **Create New** by the green plus sign.

   1. Fill out the **Azure SQL Database: Create new** screen, and select **Create**.

       ![Screenshot showing "New Azure SQL database" screen.](./media/azure-sql-database-add-connected-service/create-new-azure-sql-database.png)

   1. When the **Configure Azure SQL Database** screen is displayed, the new database appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection string name, or choose the default, and then choose **Additional Settings**.

   ![Screenshot showing "Specify connection string" screen.](./media/vs-2022/connect-to-azure-sql-database-light.png)

   > [!NOTE]
   > With Visual Studio 2022 version 17.12 and later, this procedure uses Microsoft Entra managed identity, a passwordless authentication method, to connect to the database. The warning on this screen means that you need to perform a manual step in the Azure Portal after completing this procedure in Visual Studio. See [Microsoft Entra authentication](#microsoft-entra-authentication).

1. Choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault), and then choose **Next**.

   ![Screenshot showing the options for where to store the Azure SQL Database connection string.](media/vs-2022/connect-to-azure-sql-database-options-light.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing "Summary of changes" section.](./media/vs-2022/connect-to-azure-sql-database-summary-light.png)

   If prompted to set a firewall rules, choose **Yes**.

   ![Screenshot showing firewall rules.](./media/azure-sql-database-add-connected-service/firewall-rules.png)

1. In Solution Explorer, double-click on the **Connected Services** node to open the **Connected Services** tab. The connection appears under the **Service Dependencies** section:

   ![Screenshot showing "Service Dependencies" section.](./media/azure-sql-database-add-connected-service/service-dependencies-after.png)

   If you click on the three dots next to the dependency you added, you can see various options such as **Connect** to reopen the wizard and change the connection. You can also click the three dots at the top right of the window to see options to start local dependencies, change settings, and more.

1. If you're using managed identity (Visual Studio 17.12 and later), see the next section to set up the managed identity user in your Azure SQL database.

## Microsoft Entra authentication

With Visual Studio 2022 version 17.12 and later, the connected services procedure uses Microsoft Entra authentication, which is the most secure method of authentication. However, Visual Studio doesn't create the Microsoft Entra admin user on the Azure SQL database for you automatically. If there isn't a Microsoft Entra admin user, the connection will fail to authenticate successfully.

You can use the Azure Portal, PowerShell, or the Azure CLI to create the Microsoft Entra admin user. For detailed instructions for each of these methods, see [Set the Microsoft Entra admin user](/azure/azure-sql/database/authentication-aad-configure?view=azuresql&preserve-view=true&tabs=azure-portal#azure-sql-database-and-azure-synapse-analytics).

After completing the Connected Services process, you'll need to create a SQL user that corresponds to the managed identity, and set permissions by executing SQL statements in the database. Sign in to the [query editor](/azure/azure-sql/database/connect-query-portal?view=azuresql&preserve-view=true) in the Azure Portal as your Microsoft Entra admin user, and execute statements like the following:

```tsql
CREATE USER [<identity-name>] FROM EXTERNAL PROVIDER;
ALTER ROLE db_datareader ADD MEMBER [<identity-name>];
ALTER ROLE db_datawriter ADD MEMBER [<identity-name>];
ALTER ROLE db_ddladmin ADD MEMBER [<identity-name>];

GO
```

The `<identity-name>` is the name of the managed identity in Microsoft Entra ID. If the identity is system-assigned, the name is always the same as the name of your App Service app. For a deployment slot, the name of its system-assigned identity is `<app-name>/slots/<slot-name>`. To grant permissions for a Microsoft Entra group, use the group's display name instead (for example, `myAzureSQLDBAccessGroup`). See [Managed Identity types](/entra/identity/managed-identities-azure-resources/overview#managed-identity-types) and [Managed identities in Microsoft Entra for Azure SQL](/azure/azure-sql/database/authentication-azure-ad-user-assigned-managed-identity?view=azuresql&preserve-view=true). The roles that you add depend on your use cases. See [ALTER ROLE](/sql/t-sql/statements/alter-role-transact-sql?view=azuresqldb-current&preserve-view=true).

If your code references `System.Data.SqlClient`, you'll need to upgrade to `Microsoft.Data.SqlClient`, since `System.Data.SqlClient` doesn't support Microsoft Entra authentication. To upgrade, add a reference the [Microsoft.Data.SqlClient NuGet package](https://www.nuget.org/packages/Microsoft.Data.SqlClient), and update any using directives that reference `System.Data.SqlClient` to reference the `Microsoft.Data.SqlClient` namespace. There are some behavior changes; see [Porting cheat sheet](https://github.com/dotnet/SqlClient/blob/main/porting-cheat-sheet.md).

:::moniker-end

:::moniker range="<=vs-2019"

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/vs-2022/add-connected-service-context-menu-2.png)

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. Choose **SQL Server Database**. The **Connect to dependency** page appears. You should see several options:

   - SQL Server Express LocalDB, the built-in SQL Database offering installed with Visual Studio
   - SQL Server Database on a local container on your machine
   - SQL Server Database, an on-premises SQL Server on the local network
   - Azure SQL Database, for the SQL Database running as an Azure service

   You can reduce cost and simplify early development by starting with a local database. You can migrate to the live service in Azure later by repeating these steps and choosing another option. If you create a database locally that you want to re-create in Azure, you can migrate your database to Azure at that time.

   ![Screenshot showing SQL Database choices.](./media/vs-2022/sql-database-choices-2.png)

   If you want to connect to the Azure service, continue to the next step, or if you aren't signed in already, sign in to your Azure account before continuing. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/pricing/purchase-options/azure-account?cid=msft_learn).

1. In the **Configure Azure SQL Database** screen, select an existing Azure SQL Database, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot showing "Connect to existing Azure SQL Database component" screen.](./media/azure-sql-database-add-connected-service/created-azure-sql-database.png)

1. To create an Azure SQL database:

   1. Select **Create New** by the green plus sign.

   1. Fill out the **Azure SQL Database: Create new** screen, and select **Create**.

       ![Screenshot showing "New Azure SQL database" screen.](./media/azure-sql-database-add-connected-service/create-new-azure-sql-database.png)

   1. When the **Configure Azure SQL Database** screen is displayed, the new database appears in the list. Select the new database in the list, and select **Next**.

1. Enter a connection string name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing "Specify connection string" screen.](./media/azure-sql-database-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing "Summary of changes" section.](./media/azure-sql-database-add-connected-service/summary-of-changes.png)

   If prompted to set a firewall rules, choose **Yes**.

   ![Screenshot showing firewall rules.](./media/azure-sql-database-add-connected-service/firewall-rules.png)

1. In Solution Explorer, double-click on the **Connected Services** node to open the **Connected Services** tab. The connection appears under the **Service Dependencies** section:

   ![Screenshot showing "Service Dependencies" section.](./media/azure-sql-database-add-connected-service/service-dependencies-after.png)

   If you click on the three dots next to the dependency you added, you can see various options such as **Connect** to reopen the wizard and change the connection. You can also click the three dots at the top right of the window to see options to start local dependencies, change settings, and more.

:::moniker-end

## Access the connection string

Learn how to store secrets safely by following [Safe storage of app secrets in development in ASP.NET Core](/aspnet/core/security/app-secrets?tabs=windows). In particular, to read the connection string from the secrets store, you can add code as in [Read the secret via the configuration API](/aspnet/core/security/app-secrets?tabs=windows#read-the-secret-via-the-configuration-api). See also [Dependency injection in ASP.NET Core](/aspnet/core/fundamentals/dependency-injection).

## Entity Framework migrations

It might be convenient to work with a local data store during early development, but with Entity Framework Core, when you're ready to move to the cloud, you can use Visual Studio's support for Entity Framework migration to move your database, or merge changes with a remote data store. See [Migrations overview](/ef/core/managing-schemas/migrations/?tabs=vs).

On the **Connected Services** tab, you can find the migration commands by clicking on the three dots, as shown in the screenshot:

![Screenshot showing migration commands.](./media/vs-2022/add-migration-light-theme.png)

Commands are available there to create new migrations, apply them directly, or generate SQL scripts that apply the migrations.

:::moniker range=">=vs-2022"

### Add migration

When a data model change is introduced, you can use Entity Framework Core tools to add a corresponding migration that describes in code the updates necessary to keep the database schema in sync. Entity Framework Core compares the current model against a snapshot of the old model to determine the differences, and generates migration source files. The files are added to your project, usually in a folder called *Migrations* and can be tracked in your project's source control like any other source file.

When you choose this option, you're asked to provide the context class name that represents the database schema you want to migrate.

![Screenshot showing adding an Entity Framework migration.](./media/vs-2022/entity-framework-migration-context.png)

### Update database

After a migration has been created, it can be applied to a database. Entity Framework updates your database and your schema with the changes specified in the migration code. When you choose this option, you're asked to provide the context class name that represents the database schema you want to migrate.

### Generate SQL script

The recommended way to deploy migrations to a production database is by generating SQL scripts. The advantages of this strategy include the following:

- SQL scripts can be reviewed for accuracy; this is important since applying schema changes to production databases is a potentially dangerous operation that could involve data loss.
- In some cases, the scripts can be tuned to fit the specific needs of a production database.
- SQL scripts can be used in conjunction with a deployment technology, and can even be generated as part of your CI process.
- SQL scripts can be provided to a DBA, and can be managed and archived separately.

When you use this option, you're asked the database context class and the location for the script file.

![Screenshot showing the Generate SQL script option.](./media/vs-2022/entity-framework-generate-sql-script.png)

### Open in SQL Server Object Explorer

For convenience, this command lets you jump to the SQL Server Object Explorer, so you can view tables and other database entities, and work directly with your data. See [Object explorer](/sql/ssms/object/object-explorer).

![Screenshot showing SQL Server Object Explorer.](./media/vs-2022/sql-server-object-explorer-2.png)

:::moniker-end

## Next steps

You can continue with the quickstarts for Azure SQL Database, but instead of starting from the beginning, you can start after the initial connection is set up. If you're using Entity Framework, you can start at [Add the code to connect to Azure SQL Database](/azure/azure-sql/database/azure-sql-dotnet-entity-framework-core-quickstart?view=azuresql&preserve-view=true&tabs=visual-studio%2Cservice-connector%2Cportal#add-the-code-to-connect-to-azure-sql-database). If you're using `SqlClient` or ADO.NET data classes, you can start at [Add the code to connect to Azure SQL Database](/azure/azure-sql/database/azure-sql-dotnet-quickstart?view=azuresql&preserve-view=true&tabs=visual-studio%2Cpasswordless%2Cservice-connector%2Cportal#add-the-code-to-connect-to-azure-sql-database).

Your code won't exactly match what is used in the quickstarts, which use a different way of getting the connection string. The connection strings are secrets and are securely stored as explained in [Safe storage of app secrets in development in ASP.NET Core](/aspnet/core/security/app-secrets?tabs=windows). In particular, to read the connection string from the secrets store, you can add code as in [Read the secret via the configuration API](/aspnet/core/security/app-secrets?tabs=windows#read-the-secret-via-the-configuration-api).

:::moniker range=">=vs-2022"
In ASP.NET Core projects, the connection setting or connection string created by Connected Services is available in a configuration object. You can access it by a property on the `WebApplicationBuilder` class (`builder` in many project templates), as in the following example:

```csharp
var connection = builder.Configuration["ConnectionStrings:DatabaseConnection"];
```

The string to provide to the Configuration property should match the key in *secrets.json* or in Azure Key Vault, which you provided in the Connected Services procedure. For example, with Visual Studio 2022 17.12 and later, the connection setting is stored in *secrets.json* as:

```json
{
  "ConnectionStrings:DatabaseConnection": "Server=tcp:webapplication16dbserver.database.windows.net;Authentication=Active Directory Default;Database=WebApplication16_db;",
}
:::moniker-end

:::moniker range="<=vs-2019"

In ASP.NET Core projects, the connection setting or connection string created by Connected Services is available in a configuration object. You can access it by a property on the `WebApplicationBuilder` class (`builder` in many project templates), as in the following example:

```csharp
var connection = builder.Configuration["ConnectionStrings:ConnectionString1"];
```

:::moniker-end

## Related content

- [Azure SQL Database product page](https://azure.microsoft.com/services/sql-database/)
- [Azure SQL Database documentation](/azure/azure-sql/database/)
