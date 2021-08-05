---
title: Specify alternate location for deployment updates
description: Learn how to specify an alternate location for updates for your ClickOnce application in your deployment manifest.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, updates
  - deployment update, alternative locations
ms.assetid: 7faacd35-2638-492d-80f6-6b57e5f820de
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Specify an alternate location for deployment updates
You can install your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application initially from a CD or a file share, but the application must check for periodic updates on the Web. You can specify an alternate location for updates in your deployment manifest so that your application can update itself from the Web after its initial installation.

> [!NOTE]
> Your application must be configured to install locally to use this feature. For more information, see [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). In addition, if you install a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application from the network, setting an alternate location causes [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] to use that location for both the initial installation and all subsequent updates. If you install your application locally (for example, from a CD), the initial installation is performed using the original media, and all subsequent updates will use the alternate location.

### Specify an alternate location for updates by using MageUI.exe (Windows Forms-based utility)

1. Open a .NET Framework command prompt and type:

     **mageui.exe**

2. On the **File** menu, choose **Open** to open your application's deployment manifest.

3. Select the **Deployment Options** tab.

4. In the text box named **Launch Location**, enter the URL to the directory that will contain the deployment manifest for application updates.

5. Save the deployment manifest.

### Specify an alternate location for updates by using Mage.exe

1. Open a .NET Framework command prompt.

2. Set the update location using the following command. In this example, *HelloWorld.exe.application* is the path to your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application manifest, which always has the .application extension, and `http://adatum.com/Update/Path` is the URL that [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] will check for application updates.

    **Mage -Update HelloWorld.exe.application -ProviderUrl http:\//adatum.com/Update/Path**

3. Save the file.

   > [!NOTE]
   > You now need to re-sign the file with *Mage.exe*. For more information, see [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).

## .NET Framework Security
 If you install your application from an offline medium such as a CD, and the computer is online, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] first checks the URL specified by the `<deploymentProvider>` tag in the deployment manifest to determine if the update location contains a more recent version of the application. If it does, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] installs the application directly from there, instead of from the initial installation directory, and the common language runtime (CLR) determines your application's trust level using `<deploymentProvider>`. If the computer is offline, or `<deploymentProvider>` is unreachable, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] installs from the CD, and the CLR grants trust based on the installation point; for a CD install, this means your application receives full trust. All subsequent updates will inherit that trust level.

 All [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications that use `<deploymentProvider>` should explicitly declare the permissions they need in their application manifest, so that the application does not receive different levels of trust on different computers.

## See also
- [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md)
- [ClickOnce deployment manifest](../deployment/clickonce-deployment-manifest.md)
- [Secure ClickOnce applications](../deployment/securing-clickonce-applications.md)
- [Choose a ClickOnce update strategy](../deployment/choosing-a-clickonce-update-strategy.md)