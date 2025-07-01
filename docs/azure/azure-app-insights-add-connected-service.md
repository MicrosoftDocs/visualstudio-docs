---
title: Add Application Insights With Connected Services
description: Connect Application Insights to your application by using Connected Services in Visual Studio and add a connected service.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: how-to
ms.date: 07/01/2025
ms.author: ghogen
#customer intent: As a developer, I want to use Connected Services in Visual Studio, so I can connect Application Insights to my application.
---

# Add Application Insights with Visual Studio Connected Services

With Visual Studio, you can connect different types of services and applications to Application Insights by using the **Connected Services** feature. The functionality adds all the required references and connection code to your project, and modifies your configuration files appropriately. You can choose to connect to the live Application Insights service running in Azure or use a local emulator.

This article describes how to connect Application Insights to your application by using **Connected Services**.

## Prerequisites

To complete the procedures in this article, the following prerequisites must be satisfied:

- Visual Studio with the Azure workload installed. [Download Visual Studio now](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs).

- A project that implements a supported connection type to Application Insights, for example:

   - .NET Framework console app
   - ASP.NET Model-View-Controller (MVC) (.NET Framework)
   - ASP.NET Core
   - .NET Core (including console app, WPF, Windows Forms, class library)
   - Azure Functions
   - Universal Windows Platform App

- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

:::moniker range="vs-2019"

## Connect to Application Insights with Connected Services

Add Application Insights as a connected service to your application by following these steps:

1. Open a project in Visual Studio that supports a connection with Application Insights. For project examples, see the [Prerequisites](#prerequisites).

1. Add the Application Insights connected service. There are several ways you can start the process, for example:

   - Select **Project** > **Manage Connected Services** > **Add a service dependency** > **Azure Application Insights**.
   
   - In **Solution Explorer**, right-click the **Connected Services** node for the project, and select **Add** > **Azure Application Insights**.

1. In the **Connected Services** > **Service Dependencies** section, select **Add** (plus symbol):

   :::image type="content" source="./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png" border="false" alt-text="Screenshot showing the Add Service Dependency screen.":::

1. The **Add dependency** screen opens. You have two options for the connection: use a local emulator or access the live service in Azure. To reduce cost and simplify early development, you can start with the local emulator. Later, you can migrate to the live service by repeating the steps in this procedure. 

   :::image type="content" source="./media/azure-app-insights-add-connected-service/azure-app-insights.png" border="false" alt-text="Screenshot showing the Add Azure Application Insights screen.":::

   1. For this exercise, select **Azure Application Insights** to access the live service in Azure.

   1. As needed, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Application Insights** - **Select a service dependency** screen, choose whether to use an existing or new component for the connection:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/created-app-insights.png" border="false" alt-text="Screenshot showing the Connect to existing Application Insights component screen.":::

   - **Existing component**: To use an existing Application Insights component, select the component in the list, and select **Next**. Continue to [Step 6](#configure-connection-settings) and configure the connection settings.

   - **New component**: To create a new component for the connection:

      :::image type="content" source="./media/azure-app-insights-add-connected-service/create-new-app-insights.png" border="false" alt-text="Screenshot showing the New Azure App Insights component screen with highlights for the list of existing components and the option to create a new component.":::

      1. Select **Create a new Application Insights component**.

      1. In the **Application Insights - Create new** screen, confirm the field values, adjust as needed, then select **Create**.

      1. The **Configure Azure Application Insights** - **Select a service dependency** screen refreshes and the new component appears in the list. Select the new component, and select **Next**.

   <a name="configure-connection-settings"> </a>

1. In the **Configure Azure Application Insights** - **Provide connection string name** screen, check the connection settings:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/connection-string.png" border="false" alt-text="Screenshot showing the Provide connection string name screen.":::

   1. Accept the default connection values, or enter your preferred **Connection string** and **Instrumentation key name**.
   
   1. Choose whether you want to store the connection string in a local secrets file, and select **Next**.

   > [!CAUTION]
   > For improved security, in Visual Studio 2022 17.12 and later, Visual Studio creates only a *name* for the connection setting. In earlier versions, Visual Studio creates the connection string. Connection strings stored in the local filesystem can lead to a security risk, if they're inadvertently exposed.

1. The **Summary of changes** screen shows the planned modifications for your project. The changes include updates to the project code and properties, NuGet package references, application secrets, and the _appsettings.json_ file.

   :::image type="content" source="./media/azure-app-insights-add-connected-service/summary-of-changes.png" border="false" alt-text="Screenshot showing the Summary of changes screen to create the connection for the application in earlier versions of Visual Studio.":::

   Verify the project changes, and select **Finish** to complete the process.

   A message displays indicating a successful connection. Select **Close** to close the window.

1. In Solution Explorer, double-click the **Connected Services** node for the project to open the **Connected Services** tab. The new connection appears under the **Service Dependencies** section:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/service-dependencies-after.png" border="false" alt-text="Screenshot showing the new connection listed in the Service dependencies section for the project in earlier versions of Visual Studio.":::

:::moniker-end

:::moniker range=">=vs-2022"

## Connect to Application Insights with Connected Services

Add Application Insights as a connected service to your application by following these steps:

1. Open a project in Visual Studio that supports a connection with Application Insights. For project examples, see the [Prerequisites](#prerequisites).

   > [!NOTE]
   > For .NET Framework projects, the **Connected Services** UI in Visual Studio is different across versions. To see the differences, compare your current view of this page to the [Visual Studio 2019 version of the same page](./azure-app-insights-add-connected-service.md?view=vs-2019&preserve-view=true).

1. Add the Application Insights connected service. There are several ways you can start the process, for example:

   - Select **Project** > **Connected Services** > **Add** > **Azure Application Insights**.

   - Select **Project** > **Application Insights** > **Configure Application Insights**.

   - In **Solution Explorer**, right-click the **Connected Services** node for the project, and select **Add** > **Azure Application Insights**.

1. The **Connect to dependency** screen opens. You have two options for the connection: use a local emulator or access the live service in Azure. To reduce cost and simplify early development, you can start with the local emulator. Later, you can migrate to the live service by repeating the steps in this procedure. Select your connection preference and add the connection by following the listed steps.

   | Connection type | Description | Connection procedure |
   |-----------------|-------------|----------------------|
   | **Application Insights SDK (Local)** | Use a local emulator rather than connecting to an instance running in Azure. | <ol><li> Select the option, and then select **Next**. </li><li> Continue to [Step 6](#summary-of-changes) and review the summary of planned changes. </li></ol> |
   | **Azure Application Insights** | Connect to the live Application Insights service running in Azure. | <ol><li> As needed, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/). </li><li> Continue to the next step in this procedure. </li></ol> |

   :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/application-insights-choices-2.png" border="false" alt-text="Screenshot showing the two choices for connecting your application to Application Insights.":::

1. In the **Connect to Azure Application Insights** - **Select a service dependency** screen, choose whether to use an existing or new component for the connection:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/created-app-insights.png" alt-text="Screenshot showing the Connect to Azure Application Insights component screen, where you select a service dependency to add to your application.":::

   - **Existing component**: To use an existing Application Insights component, select the component in the list, and select **Next**. Continue to [Step 5](#configure-other-settings) and configure the connection settings.

   - **New component**: To create a new component for the connection:

      1. Select **+ Create new**.
      
      1. In the **Application Insights - Create new** screen, confirm the field values, adjust as needed, then select **Create**.

         :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/create-new-app-insights.png" border="false" alt-text="Screenshot showing the Application Insights - Create new component screen.":::

      1. The **Connect to Azure Application Insights** - **Select a service dependency** screen refreshes and the new component appears in the list. Select the new component, and select **Next**.

      1. In the **Connect to Azure Application Insights** - **Provide connection configuration settings** screen, check the connection settings. Accept the default values, or enter your preferred **Connection setting name** and **Instrumentation key**.

         :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/configure-connection-settings.png" border="false" alt-text="Screenshot showing the Connect to Azure Application Insights - Provide connection configuration settings screen.":::

      > [!NOTE]
      > For improved security, in Visual Studio 2022 17.12 and later, Visual Studio creates only a *name* for the connection setting. In earlier versions, Visual Studio creates the connection string. Connection strings stored in the local filesystem can lead to a security risk, if they're inadvertently exposed.

   <a name="configure-other-settings"> </a>

1. In the **Provide connection configuration settings** screen, select **Additional settings** at the bottom left.

   The **Connect to Azure Application Insights** - **Customize how connection information is stored** screen opens. Choose whether you want to store the connection string in a local secrets file, and select **Next**:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/configure-additional-settings.png" border="false" alt-text="Screenshot showing the Connect to Application Insights - Customize how connection information is stored screen.":::

   <a name="summary-of-changes"> </a>

1. The **Summary of changes** screen shows the planned modifications for your project.

   - For an **Azure Application Insights** connection, the changes include updates to the project code and properties, NuGet package references, application secrets, and the _appsettings.json_ file.

   - For an **Application Insights SDK (Local)** connection, the project changes include an added NuGet package reference and connection code for the local emulator. 

   :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/summary-of-changes.png" border="false" alt-text="Screenshot showing the Summary of changes screen to create the connection for the application.":::

   Verify the project changes, and select **Finish** to complete the process.

   A message displays indicating a successful connection. Select **Close** to close the window.

1. In Solution Explorer, double-click the **Connected Services** node for the project to open the **Connected Services** tab. The new connection appears under the **Service Dependencies** section:

   :::image type="content" source="./media/azure-app-insights-add-connected-service/vs-2022/service-dependencies-after.png" border="false" alt-text="Screenshot showing the new connection listed in the Service dependencies section for the project.":::

   - To see the available actions for a dependency, select **More options** (**...**) for the item. When the dependency isn't connected, you see the **Connect** option. When you can select this option, the **Connect to dependency** screen reopens where you can change the dependency configuration and reestablish the connection.
   
   - You can also select **More options** (**...**) at the top of the **Connected Services** tab for options to start local dependencies, change settings, and more.

1. In Solution Explorer, locate and open the *Program.cs* file that contains the startup code for the project. Notice the following statement, which is added to support the dependency connection:

   ```csharp
   // Add services to the container
   builder.Services.AddApplicationInsightsTelemetry();
   ```

:::moniker-end

## Related content

- Enable monitoring for your app with [Application Insights for ASP.NET Core applications](/azure/azure-monitor/app/asp-net-core?tabs=netcorenew%2Cnetcore6#run-your-application)
- [Configure Application Insights for your ASP.NET website](/azure/azure-monitor/app/asp-net#add-client-side-monitoring)
- Learn more about Application Insights in [Azure Monitor](https://azure.microsoft.com/services/monitor/)