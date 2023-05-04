---
title: Add Azure Application Insights by using Connected Services | Microsoft Docs
description: Add Azure Application Insights to your app by using the Visual Studio to add a connected service
author: AngelosP
manager: jmartens
ms.technology: vs-azure
ms.workload: azure-vs
ms.topic: conceptual
ms.date: 05/03/2023
ms.author: angelpe
---
# Add Azure Application Insights by using Visual Studio Connected Services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With Visual Studio, you can connect any of the following to Azure Application Insights by using the **Connected Services** feature:

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

:::moniker range="vs-2019"

## Connect to Azure Application Insights using Connected Services

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add Connected Service**.

1. In the **Connected Services** tab, select the + icon for **Service Dependencies**.

    ![Add Service Dependency](./media/vs-azure-tools-connected-services-storage/vs-2019/connected-services-tab.png)

1. In the **Add Dependency** page, select **Azure Application Insights**.

    ![Add Azure Application Insights](./media/azure-app-insights-add-connected-service/azure-app-insights.png)

    If you aren't signed in already, sign into your Azure account. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Application Insights** screen, select an existing Azure Application Insights component, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Connect to existing Application Insights component](./media/azure-app-insights-add-connected-service/created-app-insights.png)

1. To create an Application Insights component:

   1. Select **Create a new Application Insights component** at the bottom of the screen.

   1. Fill out the **Application Insights: Create new** screen, and select **Create**.

       ![New Azure App Insights component](./media/azure-app-insights-add-connected-service/create-new-app-insights.png)

   1. When the **Configure Azure Application Insights** screen is displayed, the new component appears in the list. Select the new component in the list, and select **Next**.

1. Enter an instrumentation key name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Specify connection string](./media/azure-app-insights-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Summary of changes](./media/azure-app-insights-add-connected-service/summary-of-changes.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Service dependencies](./media/azure-app-insights-add-connected-service/service-dependencies-after.png)
:::moniker-end

:::moniker range=">=vs-2022"

## Connect to Azure Application Insights using Connected Services

1. Open your project in Visual Studio.

1. In **Solution Explorer**, right-click the **Connected Services** node, and, from the context menu, select **Add** to open the menu of available services.

   ![Screenshot showing Connected Services context menu options.](./media/vs-2022/add-connected-service-context-menu.png)

1. Choose **Azure Application Insights**. The **Add Dependency** page appears. You should see two options, one for a local emulator, **Application Insights Sdk**, and one for connecting to the live Azure Application Insights service. You can reduce cost and simplify early development by starting with the local emulator. You can migrate to the live service later by repeating these steps and choosing the other option.

   ![Screenshot showing Application Insights choices](./media/vs-2022/application-insights-choices.png)

   If you choose to use the Application Insights Sdk locally, click **Next** to see the **Summary of changes** screen and complete the process. A NuGet package reference is added to your project and the connection code for the local emulator is added to your project.

   If you want to connect to the Azure service, continue to the next step, or if you aren't signed in already, sign into your Azure account before continuing. If you don't have an Azure account, you can sign up for a [free trial](https://azure.microsoft.com/free/).

1. In the **Configure Azure Application Insights** screen, select an existing Azure Application Insights component, and select **Next**.

    If you need to create a new component, go to the next step. Otherwise, skip to step 7.

    ![Connect to existing Application Insights component](./media/azure-app-insights-add-connected-service/created-app-insights.png)

1. To create an Application Insights component:

   1. Select **Create a new Application Insights component** at the bottom of the screen.

   1. Fill out the **Application Insights: Create new** screen, and select **Create**.

       ![New Azure App Insights component](./media/azure-app-insights-add-connected-service/create-new-app-insights.png)

   1. When the **Configure Azure Application Insights** screen is displayed, the new component appears in the list. Select the new component in the list, and select **Next**.

1. Enter an instrumentation key name, or choose the default, and choose whether you want the connection string stored in a local secrets file, or in [Azure Key Vault](/azure/key-vault).

   ![Specify connection string](./media/azure-app-insights-add-connected-service/connection-string.png)

1. The **Summary of changes** screen shows all the modifications that will be made to your project if you complete the process. If the changes look OK, choose **Finish**.

   ![Summary of changes](./media/azure-app-insights-add-connected-service/summary-of-changes.png)

1. The connection appears under the **Service Dependencies** section of the **Connected Services** tab.

   ![Service dependencies](./media/azure-app-insights-add-connected-service/service-dependencies-after.png)

:::moniker-end

## See also

- [Azure Monitor product page](https://azure.microsoft.com/services/monitor/)
- [Azure App Insights documentation](/azure/azure-monitor/app/app-insights-overview/)
- [Connected services (Visual Studio for Mac)](/visualstudio/mac/connected-services)
