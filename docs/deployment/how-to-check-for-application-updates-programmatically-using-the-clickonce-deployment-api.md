---
title: Automatic app updates using ClickOnce deployment API
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, updates
  - application updates
ms.assetid: 1a886310-67c8-44e5-a382-c2f0454f887d
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# How to: Check for application updates programmatically using the ClickOnce deployment API
ClickOnce provides two ways to update an application once it is deployed. In the first method, you can configure the ClickOnce deployment to check automatically for updates at certain intervals. In the second method, you can write code that uses the <xref:System.Deployment.Application.ApplicationDeployment> class to check for updates based on an event, such as a user request.

 The following procedures show some code for performing a programmatic update and also describe how to configure your ClickOnce deployment to enable programmatic update checks.

 In order to update a ClickOnce application programmatically, you must specify a location for updates. This is sometimes referred to as a deployment provider. For more information on setting this property, see [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md).

> [!NOTE]
> You can also use the technique described below to deploy your application from one location but update it from another. For more information, see [How to: Specify an alternate location for deployment updates](../deployment/how-to-specify-an-alternate-location-for-deployment-updates.md).

### To check for updates programmatically

1. Create a new Windows Forms application using your preferred command-line or visual tools.

2. Create whatever button, menu item, or other user interface item you want your users to select to check for updates. From that item's event handler, call the following method to check for and install updates.

     [!code-csharp[ClickOnceAPI#6](../deployment/codesnippet/CSharp/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api_1.cs)]
     [!code-cpp[ClickOnceAPI#6](../deployment/codesnippet/CPP/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api_1.cpp)]
     [!code-vb[ClickOnceAPI#6](../deployment/codesnippet/VisualBasic/how-to-check-for-application-updates-programmatically-using-the-clickonce-deployment-api_1.vb)]

3. Compile your application.

### Use Mage.exe to deploy an application that checks for updates programmatically

- Follow the instructions for deploying your application using Mage.exe as explained in [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). When calling Mage.exe to generate the deployment manifest, make sure to use the command-line switch `providerUrl`, and to specify the URL where ClickOnce should check for updates. If your application will update from `http://www.adatum.com/MyApp`, for example, your call to generate the deployment manifest might look like this:

    ```cmd
    mage -New Deployment -ToFile WindowsFormsApp1.application -Name "My App 1.0" -Version 1.0.0.0 -AppManifest 1.0.0.0\MyApp.manifest -providerUrl http://www.adatum.com/MyApp/MyApp.application
    ```

### Using MageUI.exe to deploy an application that checks for updates programmatically

- Follow the instructions for deploying your application using Mage.exe as explained in [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). On the **Deployment Options** tab, set the **Start Location** field to the application manifest ClickOnce should check for updates. On the **Update Options** tab, clear the **This application should check for updates** check box.

## .NET Framework Security
 Your application must have full-trust permissions to use programmatic updating.

## See also
- [How to: Specify an alternate location for deployment updates](../deployment/how-to-specify-an-alternate-location-for-deployment-updates.md)
- [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md)
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)