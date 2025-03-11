---
title: Add Application Insights with Connected Services
description: Connect Azure Application Insights to your application by using Connected Services in Visual Studio on Windows and add a connected service.
author: AngelosP
manager: mijacobs
ms.subservice: azure-development
ms.topic: conceptual
ms.date: 05/03/2023
ms.author: angelpe
---

# Add Azure Application Insights by using Visual Studio Connected Services

With Visual Studio, you can connect any of the following to Azure Application Insights by using the **Connected Services** feature:

- .NET Framework console app
- ASP.NET Model-View-Controller (MVC) (.NET Framework)
- ASP.NET Core
- .NET Core (including console app, WPF, Windows Forms, class library)
- .NET Core Worker Role
- Azure Functions
- Universal Windows Platform App
- Cordova

The connected service functionality adds all the needed references and connection code to your project, and modifies your configuration files appropriately.

## Prerequisites

- Visual Studio with the Azure workload installed.
- A project of one of the supported types
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

:::moniker range="vs-2019"

## Connect to Azure Application Insights using Connected Services

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Screenshot showing "Add Service Dependency" screen.](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. In the **Add Dependency** page, select **Azure Application Insights**.

    ![Screenshot showing "Add Azure Application Insights" screen.](./media/azure-app-insights-add-connected-service/azure-app-insights.png)

    If you aren't signed in already, sign in to your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Application Insights** screen, select an existing Azure Application Insights component, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot showing "Connect to existing Application Insights component" screen.](./media/azure-app-insights-add-connected-service/created-app-insights.png)

1. To create an Application Insights component:

   1. Select **Create a new Application Insights component** at the bottom of the screen.

   1. Fill out the **Application Insights: Create new** screen, and select **Create**.

       ![Screenshot showing "New Azure App Insights component" screen.](./media/azure-app-insights-add-connected-service/create-new-app-insights.png)

   1. When the **Configure Azure Application Insights** screen is displayed, the new component appears in the list. Select the new component in the list, and select **Next**.

1. Enter an instrumentation key name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing "Specify connection string" screen.](./media/azure-app-insights-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing "Summary of changes" screen.](./media/azure-app-insights-add-connected-service/summary-of-changes.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Screenshot showing "Service dependencies" screen.](./media/azure-app-insights-add-connected-service/service-dependencies-after.png)
:::moniker-end

:::moniker range=">=vs-2022"

## Connect to Azure Application Insights using Connected Services

> [!NOTE]
> For .NET Framework projects, Connected Services UI is slightly different. To see the differences, compare to the [Visual Studio 2019 version of this page](./azure-app-insights-add-connected-service.md?view=vs-2019&preserve-view=true).

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/azure-app-insights-add-connected-service/vs-2022/add-connected-service-context-menu-2.png)

   If you don't see the **Connected Services** node, choose **Project** > **Connected Services** > **Add**.

1. Choose **Azure Application Insights**. The **Connect to dependency** page appears. You should see two options, one for a local emulator, **Application Insights Sdk (Local)**, and one for connecting to the live Azure Application Insights service. You can reduce cost and simplify early development by starting with the local emulator. You can migrate to the live service later by repeating these steps and choosing the other option.

   ![Screenshot showing Application Insights choices.](./media/azure-app-insights-add-connected-service/vs-2022/application-insights-choices-2.png)

   If you choose to use the Application Insights SDK locally, click **Next** to see the **Summary of changes** screen, which shows how your project is being modified. A NuGet package reference is added to your project and the connection code for the local emulator is added to your project.

   If you want to connect to the Azure service, continue to the next step, or if you aren't signed in already, sign in to your Azure account before continuing. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Application Insights** screen, select an existing Azure Application Insights component, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Screenshot showing "Connect to existing Application Insights component" screen.](./media/azure-app-insights-add-connected-service/created-app-insights.png)

1. To create an Application Insights component:

   1. Select **Create a new Application Insights component** at the bottom of the screen.

   1. Fill out the **Application Insights: Create new** screen, and select **Create**.

       ![Screenshot showing "New Azure App Insights component" screen.](./media/azure-app-insights-add-connected-service/create-new-app-insights.png)

   1. When the **Configure Azure Application Insights** screen is displayed, the new component appears in the list. Select the new component in the list, and select **Next**.

1. Enter a name for the connection setting, and an instrumentation key name, or accept the defaults.

   ![Screenshot showing "Provide connection configuration settings" screen.](./media/vs-2022/connect-to-application-insights-connection-setting.png)

   > [!NOTE]
   > For improved security, in Visual Studio 17.12 and later, this step creates a connection setting name; previous versions create a connection string. Connection strings stored in the local filesystem can lead to a security risk, if they're inadvertently exposed.

1. Click **Additional settings**, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Screenshot showing Connect to Application Insights - additional settings screen.](./media/vs-2022/connect-to-application-insights-additional-settings.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Screenshot showing "Summary of changes" screen.](./media/azure-app-insights-add-connected-service/summary-of-changes.png)

1. In Solution Explorer, double-click on the **Connected Services** node to open the **Connected Services** tab. The connection appears under the **Service Dependencies** section:

   ![Screenshot showing "Service dependencies" section.](./media/azure-app-insights-add-connected-service/service-dependencies-after.png)

   If you click on the three dots next to the dependency you added, you can see various options such as **Connect** to reopen the wizard and change the connection. You can also click the three dots at the top right of the window to see options to start local dependencies, change settings, and more.

1. Open your startup code file (*Program.cs* in templates) and notice that a line has been added that resembles the following:

   ```csharp
   builder.Services.AddApplicationInsightsTelemetry(builder.Configuration["APPLICATIONINSIGHTS_CONNECTION_STRING"]);
   ```

:::moniker-end

## Next steps

For ASP.NET Core projects, learn how you can enable monitoring for your app at [Application Insights for ASP.NET Core applications](/azure/azure-monitor/app/asp-net-core?tabs=netcorenew%2Cnetcore6#run-your-application).

For ASP.NET projects, see [Configure Application Insights for your ASP.NET website](/azure/azure-monitor/app/asp-net#add-client-side-monitoring).

The links take you to the section of the articles after the initial setup steps, which you've already done.

## Related content

- [Azure Monitor product page](https://azure.microsoft.com/services/monitor/)
- [Azure App Insights documentation](/azure/azure-monitor/app/app-insights-overview/)
