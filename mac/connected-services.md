---
title: "Connected Services"
description: "Add Azure data storage, authentication, and push notifications to mobile apps from within Visual Studio for Mac"
ms.assetid: 41CB62FF-0F39-4CE8-8917-6A77F058719F
author: sayedihashimi
ms.author: sayedha
ms.date: 11/06/2018
---

# Connected Services walkthrough

The Connected Services workflow brings the Azure portal workflow into Visual Studio for Mac, so you don’t have to leave your project to add services.

This walkthrough shows how to add an Azure backend service, which brings cloud data storage, authentication, and push notifications to a cross-platform Xamarin.Forms Portable Class Library (PCL) application.

1. Start by double-clicking on the **Connected Services** node in the solution, which brings up the **Services Gallery**.
  This is a list of all the available services for the application type. Select a service (such as **Mobile backend with Azure App Service**) by clicking on it.

    [![Connected Services node in Visual Studio for Mac](media/connected-services-image001-sml.png "Connected Services node in Visual Studio for Mac")](media/connected-services-image001.png#lightbox)

2. The Service Details Page has a description of the service and the dependencies to be installed.
  Click the **Add** button to add the dependencies to the app:

    [![Mobile backend with Azure](media/connected-services-image002-sml.png "Mobile backend with Azure")](media/connected-services-image002.png#lightbox)

3. The dependencies need to be added to both the PCL and the platform-specific projects to work.
  Select the checkboxes to add the service to every project that will reference it (either directly or indirectly):

    [![Check all projects that should reference the service](media/connected-services-image003-sml.png "Check all projects that should reference the service")](media/connected-services-image003.png#lightbox)

4. Choose **Accept** on the **License Acceptance** dialogs for the NuGet packages.
  There may be two dialogs to accept, one for the MobileClient and dependencies, and another for SQLiteStore, which is required for offline data sync:

    [![Accept License Agreements](media/connected-services-image004-sml.png "Accept License Agreements")](media/connected-services-image004.png#lightbox)

    ![License Acceptance window](media/connected-services-image005.png "License Acceptance window")

5. Once the dependencies are added, you'll be asked to log in with the account you want to use to communicate with Azure.
  If you’re already logged in with a Microsoft ID, Visual Studio for Mac will attempt to fetch your Azure subscriptions
  and any app services associated with them. If you do not have any subscriptions, you can add one by signing up for a free trial or purchasing a subscription plan in the Azure portal.

6. Select an app service from the list. This will fill the template code for the `MobileServiceClient` object with the corresponding URL of the app service on Azure:

    [![Select app service from list](media/connected-services-image006-sml.png "Select app service from list")](media/connected-services-image006.png#lightbox)

    If there are no services listed, click the **New** button (see Step 9.)

7. Copy the template code for the `MobileServiceClient` into the PCL. The file location is not important, so long as there is only one instance of it.
  The recommended approach is to create an `AzureService` class that handles all Azure interactions and uses the `MobileServiceClient`:

    ![Copy config code into the ap](media/connected-services-image007.png "Copy config code into the app")

8. Follow the documentation in **Next Steps** to add data, offline sync, authentication, and push notifications to your app:

    [![Review the next steps instructions](media/connected-services-image008-sml.png "Review the next steps instructions")](media/connected-services-image008.png#lightbox)

9. If you don’t have any existing app services, you can create new services from within Visual Studio for Mac.
  Click the **New** button in the bottom left of the services list to open the **New App Service** dialog:

    [![Create a new app service in Visual Studio for Mac](media/connected-services-image009-sml.png "Create a new app service in Visual Studio for Mac")](media/connected-services-image009.png#lightbox)

A new service requires the following parameters:

- **App service name** – unique name/id for the plan
- **Subscription** – the subscription you’d like to use to pay for the service
- **Resource Group** – a way or organizing all your Azure resources for a project. Option to use existing or create a new one. If this is your first Azure service, create a new one.
- **Service Plan** – Determines the location and cost of any resources that use it. Option to use existing or create a new one. If this is your first Azure service, use the default one or create a new one in the free tier (F1).

Visit the [Mobile apps documentation](/azure/app-service-mobile/) for more information.

## See also

- [Connected Services (Visual Studio on Windows)](/visualstudio/azure/vs-azure-tools-connected-services-storage)