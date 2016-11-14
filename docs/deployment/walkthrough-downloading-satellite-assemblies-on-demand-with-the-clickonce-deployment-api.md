---
title: "Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, globalization"
  - "localization, Windows Forms"
  - "Windows Forms, localization"
  - "globalization, ClickOnce"
  - "satellite assemblies, ClickOnce"
  - "ClickOnce deployment, on-demand download"
  - "localization, ClickOnce deployment"
  - "ClickOnce deployment, localization"
ms.assetid: fdaa553f-a27e-44eb-a4e2-08c122105a87
caps.latest.revision: 11
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API
Windows Forms applications can be configured for multiple cultures through the use of satellite assemblies. A *satellite assembly* is an assembly that contains application resources for a culture other than the application's default culture.  
  
 As discussed in [Localizing ClickOnce Applications](../deployment/localizing-clickonce-applications.md), you can include multiple satellite assemblies for multiple cultures within the same [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment. By default, [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] will download all of the satellite assemblies in your deployment to the client machine, although a single client will probably require only one satellite assembly.  
  
 This walkthrough demonstrates how to mark your satellite assemblies as optional, and download only the assembly a client machine needs for its current culture settings. The following procedure uses the tools available in the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)]. You can also perform this task in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  Also see [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API Using the Designer](http://msdn.microsoft.com/library/ms366788\(v=vs.110\)) or [Walkthrough: Downloading Satellite Assemblies on Demand with the ClickOnce Deployment API Using the Designer](http://msdn.microsoft.com/library/ms366788\(v=vs.120\)).  
  
> [!NOTE]
>  For testing purposes, the following code example programmatically sets the culture to `ja-JP`. See the "Next Steps" section later in this topic for information on how to adjust this code for a production environment.  
  
## Prerequisites  
 This topic assumes that you know how to add localized resources to your application using Visual Studio. For detailed instructions, see [Walkthrough: Localizing Windows Forms](https://msdn.microsoft.com/en-us/library/vstudio/y99d1cd3\(v=vs.100\).aspx).  
  
### To download satellite assemblies on demand  
  
1.  Add the following code to your application to enable on-demand downloading of satellite assemblies.  
  
     [!code-cs[ClickOnce.SatelliteAssembliesSDK#1](../deployment/codesnippet/CSharp/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api_1.cs)]
     [!code-vb[ClickOnce.SatelliteAssembliesSDK#1](../deployment/codesnippet/VisualBasic/walkthrough-downloading-satellite-assemblies-on-demand-with-the-clickonce-deployment-api_1.vb)]  
  
2.  Generate satellite assemblies for your application by using [Resgen.exe (Resource File Generator)](../Topic/Resgen.exe%20\(Resource%20File%20Generator\).md) or [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
3.  Generate an application manifest, or open your existing application manifest, by using MageUI.exe. For more information about this tool, see [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](../Topic/MageUI.exe%20\(Manifest%20Generation%20and%20Editing%20Tool,%20Graphical%20Client\).md).  
  
4.  Click the **Files** tab.  
  
5.  Click the **ellipsis** button (**...**) and select the directory containing all of your application's assemblies and files, including the satellite assemblies you generated using Resgen.exe. (A satellite assembly will have a name in the form *isoCode*\ApplicationName.resources.dll, where *isoCode* is a language identifier in RFC 1766 format.)  
  
6.  Click **Populate** to add the files to your deployment.  
  
7.  Select the **Optional** check box for each satellite assembly.  
  
8.  Set the group field for each satellite assembly to its ISO language identifier. For example, for a Japanese satellite assembly, you would specify a download group name of `ja-JP`. This will enable the code you added in step 1 to download the appropriate satellite assembly, depending upon the user's <xref:System.Threading.Thread.CurrentUICulture%2A> property setting.  
  
## Next Steps  
 In a production environment, you will likely need to remove the line in the code example that sets <xref:System.Threading.Thread.CurrentUICulture%2A> to a specific value, because client machines will have the correct value set by default. When your application runs on a Japanese client machine, for example, <xref:System.Threading.Thread.CurrentUICulture%2A> will be `ja-JP` by default. Setting this value programmatically is a good way to test your satellite assemblies before you deploy your application.  
  
## See Also  
 [Localizing ClickOnce Applications](../deployment/localizing-clickonce-applications.md)