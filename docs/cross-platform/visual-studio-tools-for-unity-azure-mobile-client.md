---
title: "Visual Studio Tools for Unity Azure Walkthrough Mobile Client | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 5A8762A1-D843-4FD8-A89B-E5E489ECA03D
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Implement the Azure MobileServiceClient

Central to the Azure Mobile Client SDK is the <a href="https://msdn.microsoft.com/en-us/library/azure/microsoft.windowsazure.mobileservices.mobileserviceclient(v=azure.10).aspx">MobileServiceClient</a>, which allows access to your Mobile App backend.

## Locate the URL of the Mobile App backend

The `MobileServiceClient` constructor takes the Mobile App URL as a parameter, so before going forward, locate the URL.

1. In the Azure portal, click the **App Services** button.

    ![Click App Services](media/vstu_azure-implement-azure-mobileserviceclient-image1.png)

2. Click the entry for your Mobile App.

    ![Click Mobile App](media/vstu_azure-implement-azure-mobileserviceclient-image2.png)

3. Copy the URL of your Mobile App backend.

    ![Copy URL](media/vstu_azure-implement-azure-mobileserviceclient-image3.png)

## Create the MobileServiceClient singleton

There should only be a single instance of `MobileServiceClient`, so the walkthrough uses a variation of the singleton pattern.

1. Inside of the **Assets/Scripts** directory of your Unity project, create a new C# script named **AzureMobileServiceClient**.

2. Open the `AzureMobileServiceClient` script and delete any existing template code, including using statements and the class declaration.

3. Add the following code:

  ```csharp
  using Microsoft.WindowsAzure.MobileServices;

  public static class AzureMobileServiceClient
  {
      private const bool ignoreTls = true;
      private const string backendUrl = "MOBILE_APP_URL";
      private static MobileServiceClient client;

      public static MobileServiceClient Client
      {
          get
          {
              if (client == null)
              {
                  client = new MobileServiceClient(backendUrl);
              }

              return client;
          }
      }
  }
  ```

  > [!NOTE]
  > If IntelliSense does not recognize the Microsoft.WindowsAzure namespace, check that you have completed all of the steps in the [Prepare the development environment]() section.

4. In the preceding code, replace `MOBILE_APP_URL` with the URL of your Mobile App backend.

## Next step

* [Update Unity Mono security store](visual-studio-tools-for-unity-azure-security.md)
