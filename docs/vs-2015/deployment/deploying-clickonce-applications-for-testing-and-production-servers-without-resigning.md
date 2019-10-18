---
title: "Deploying ClickOnce Applications For Testing and Production Servers without Resigning | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce applications, deploying without resigning"
  - "ClickOnce deployment, without resigning"
  - "application updates, ClickOnce"
  - "update location [ClickOnce]"
  - "deploymentProvider tag"
  - "manifests [ClickOnce]"
ms.assetid: 1218a98d-1ad5-4eef-95dd-0e0b3c44168c
caps.latest.revision: 12
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Deploying ClickOnce Applications For Testing and Production Servers without Resigning
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic discusses a new feature of ClickOnce introduced in the .NET Framework version 3.5 that enables the deployment of ClickOnce applications from multiple network locations without re-signing or changing the ClickOnce manifests.  
  
> [!NOTE]
> Resigning is still the preferred method for deploying new versions of applications. Whenever possible, use the resigning method. For more information, see [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1).  
  
 Third-party developers and ISVs can opt-in to this feature, making it easier for their customers to update their applications. This feature can be used in the following situations:  
  
- When updating an application, not the first installation of an application.  
  
- When there is only one configuration of the application on a computer. For example, if an application is configured to point to two different databases, you cannot use this feature.  
  
## Excluding deploymentProvider from Deployment Manifests  
 In the .NET Framework 2.0 and the .NET Framework 3.0, any ClickOnce application that installs on the system for offline availability must specify a `deploymentProvider` in its deployment manifest. The `deploymentProvider` is often referred to as the update location; it is the location in which ClickOnce will check for application updates. This requirement, coupled with the need for application publishers to sign their deployments, made it difficult for a company to update a ClickOnce application from a vendor or other third-party. It also makes it more difficult to deploy the same application from multiple locations on the same network.  
  
 With changes that were made to ClickOnce in the .NET Framework 3.5, it is possible for a third-party to provide a ClickOnce application to another organization, which can then deploy the application on its own network.  
  
 In order to take advantage of this feature, developers of ClickOnce applications must exclude `deploymentProvider` from their deployment manifests. This means excluding the `-providerUrl` argument when you create deployment manifests with Mage.exe, or making sure the **Launch Location** text box on the **Application Manifest** tab is left blank if you are generating deployment manifests with MageUI.exe.  
  
## deploymentProvider and Application Updates  
 Starting with the .NET Framework 3.5, you no longer have to specify a `deploymentProvider` in your deployment manifest in order to deploy a ClickOnce application for both online and offline usage. This supports the scenario where you need to package and sign the deployment yourself, but allow other companies to deploy the application over their networks.  
  
 The key point to remember is that applications that exclude a `deploymentProvider` cannot change their install location during updates, until they ship an update that includes the `deploymentProvider` tag again.  
  
 Here are two examples to clarify this point. In the first example, you publish a ClickOnce application that has no `deploymentProvider` tag, and you ask users to install it from http://www.adatum.com/MyApplication/. If you decide you want to publish the next update of the application from http://subdomain.adatum.com/MyApplication/, you will have no way of signifying this in the deployment manifest that resides in http://www.adatum.com/MyApplication/. You can do one of two things:  
  
- Tell your users to uninstall the previous version, and install the new version from the new location.  
  
- Include an update on http://www.adatum.com/MyApplication/ that includes a `deploymentProvider` pointing to http://www.adatum.com/MyApplication/. Then, release another update later with `deploymentProvider` pointing to http://subdomain.adatum.com/MyApplication/.  
  
  In the second example, you publish a ClickOnce application that specifies `deploymentProvider`, and you then decide to remove it. Once the new version without `deploymentProvider` has been downloaded to clients, you will not be able to redirect the path used for updates until you release a version of your application that has `deploymentProvider` restored. As with the first example, `deploymentProvider` must initially point to the current update location, not your new location. In this case, if you attempt to insert a `deploymentProvider` that refers to http://subdomain.adatum.com/MyApplication/, then the next update will fail.  
  
## Creating a Deployment  
 For step by step guidance on creating deployments that can be deployed from different network locations, see [Walkthrough: Manually Deploying a ClickOnce Application that Does Not Require Re-Signing and that Preserves Branding Information](/visualstudio/deployment/walkthrough-manually-deploying-a-clickonce-app-no-re-signing-required?view=vs-2015).  
  
## See also  
 [Mage.exe (Manifest Generation and Editing Tool)](https://msdn.microsoft.com/library/77dfe576-2962-407e-af13-82255df725a1)   
 [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](https://msdn.microsoft.com/library/f9e130a6-8117-49c4-839c-c988f641dc14)
