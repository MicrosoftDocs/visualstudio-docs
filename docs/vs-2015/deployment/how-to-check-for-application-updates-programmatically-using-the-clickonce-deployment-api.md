---
title: "How to: Check for Application Updates Programmatically Using the ClickOnce Deployment API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, updates"
  - "application updates"
ms.assetid: 1a886310-67c8-44e5-a382-c2f0454f887d
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Check for Application Updates Programmatically Using the ClickOnce Deployment API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

ClickOnce provides two ways to update an application once it is deployed. In the first method, you can configure the ClickOnce deployment to check automatically for updates at certain intervals. In the second method, you can write code that uses the <xref:System.Deployment.Application.ApplicationDeployment> class to check for updates based on an event, such as a user request.  
  
 The following procedures show some code for performing a programmatic update and also describe how to configure your ClickOnce deployment to enable programmatic update checks.  
  
 In order to update a ClickOnce application programmatically, you must specify a location for updates. This is sometimes referred to as a deployment provider. For more information on setting this property, see [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md).  
  
> [!NOTE]
> You can also use the technique described below to deploy your application from one location but update it from another. For more information, see [How to: Specify an Alternate Location for Deployment Updates](../deployment/how-to-specify-an-alternate-location-for-deployment-updates.md).  
  
### To check for updates programmatically  
  
1. Create a new Windows Forms application using your preferred command-line or visual tools.  
  
2. Create whatever button, menu item, or other user interface item you want your users to select to check for updates. From that item's event handler, call the following method to check for and install updates.  
  
     [!code-cpp[ClickOnceAPI#6](../snippets/cpp/VS_Snippets_Winforms/ClickOnceAPI/cpp/form1.cpp#6)]
     [!code-csharp[ClickOnceAPI#6](../snippets/csharp/VS_Snippets_Winforms/ClickOnceAPI/CS/Form1.cs#6)]
     [!code-vb[ClickOnceAPI#6](../snippets/visualbasic/VS_Snippets_Winforms/ClickOnceAPI/VB/Form1.vb#6)]  
  
3. Compile your application.  
  
### Using Mage.exe to deploy an application that checks for updates programmatically  
  
- Follow the instructions for deploying your application using Mage.exe as explained in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). When calling Mage.exe to generate the deployment manifest, make sure to use the command-line switch `providerUrl`, and to specify the URL where ClickOnce should check for updates. If your application will update from [http://www.adatum.com/MyApp](http://www.adatum.com/MyApp), for example, your call to generate the deployment manifest might look like this:  
  
    ```  
    mage -New Deployment -ToFile WindowsFormsApp1.application -Name "My App 1.0" -Version 1.0.0.0 -AppManifest 1.0.0.0\MyApp.manifest -providerUrl http://www.adatum.com/MyApp/MyApp.application  
    ```  
  
### Using MageUI.exe to deploy an application that checks for updates programmatically  
  
- Follow the instructions for deploying your application using Mage.exe as explained in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). On the **Deployment Options** tab, set the **Start Location** field to the application manifest ClickOnce should check for updates. On the **Update Options** tab, clear the **This application should check for updates** check box.  
  
## .NET Framework Security  
 Your application must have full-trust permissions to use programmatic updating.  
  
## See Also  
 [How to: Specify an Alternate Location for Deployment Updates](../deployment/how-to-specify-an-alternate-location-for-deployment-updates.md)   
 [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)
