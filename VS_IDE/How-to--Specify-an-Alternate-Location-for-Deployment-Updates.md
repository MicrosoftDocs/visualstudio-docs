---
title: "How to: Specify an Alternate Location for Deployment Updates"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7faacd35-2638-492d-80f6-6b57e5f820de
caps.latest.revision: 15
manager: wpickett
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Specify an Alternate Location for Deployment Updates
You can install your ClickOnce application initially from a CD or a file share, but the application must check for periodic updates on the Web. You can specify an alternate location for updates in your deployment manifest so that your application can update itself from the Web after its initial installation.  
  
> [!NOTE]
>  Your application must be configured to install locally to use this feature. For more information, see [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md). In addition, if you install a ClickOnce application from the network, setting an alternate location causes ClickOnce to use that location for both the initial installation and all subsequent updates. If you install your application locally (for example, from a CD), the initial installation is performed using the original media, and all subsequent updates will use the alternate location.  
  
### Specifying an alternate location for updates by using MageUI.exe (Windows Forms-based utility)  
  
1.  Open a .NET Framework command prompt and type:  
  
     **mageui.exe**  
  
2.  On the **File** menu, choose **Open** to open your application's deployment manifest.  
  
3.  Select the **Deployment Options** tab.  
  
4.  In the text box named **Launch Location**, enter the URL to the directory that will contain the deployment manifest for application updates.  
  
5.  Save the deployment manifest.  
  
### Specifying an alternate location for updates by using Mage.exe  
  
1.  Open a .NET Framework command prompt.  
  
2.  Set the update location using the following command. In this example, **HelloWorld.exe.application** is the path to your ClickOnce application manifest, which always has the .application extension, and **http://adatum.com/Update/Path** is the URL that ClickOnce will check for application updates.  
  
     **Mage -Update HelloWorld.exe.application -ProviderUrl http://adatum.com/Update/Path**  
  
3.  Save the file.  
  
    > [!NOTE]
    >  You now need to re-sign the file with Mage.exe. For more information, see [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md).  
  
## .NET Framework Security  
 If you install your application from an offline medium such as a CD, and the computer is online, ClickOnce first checks the URL specified by the `<deploymentProvider>` tag in the deployment manifest to determine if the update location contains a more recent version of the application. If it does, ClickOnce installs the application directly from there, instead of from the initial installation directory, and the common language runtime (CLR) determines your application's trust level using `<deploymentProvider>`. If the computer is offline, or `<deploymentProvider>` is unreachable, ClickOnce installs from the CD, and the CLR grants trust based on the installation point; for a CD install, this means your application receives full trust. All subsequent updates will inherit that trust level.  
  
 All ClickOnce applications that use `<deploymentProvider>` should explicitly declare the permissions they need in their application manifest, so that the application does not receive different levels of trust on different computers.  
  
## See Also  
 [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md)   
 [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md)   
 [Securing ClickOnce Applications](../VS_IDE/Securing-ClickOnce-Applications.md)   
 [Choosing a ClickOnce Update Strategy](../VS_IDE/Choosing-a-ClickOnce-Update-Strategy.md)