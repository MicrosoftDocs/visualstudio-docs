---
title: "How to: Disable URL Activation of ClickOnce Applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "disallowUrlActivation"
  - "URL activation, ClickOnce applications"
  - "ClickOnce deployment, URL activation"
ms.assetid: db31a16b-960f-4264-91d7-c7c40f876068
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Disable URL Activation of ClickOnce Applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Typically, a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application will launch automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to launch the application from the **Start** menu instead. The following procedure describes how to disable URL activation.  
  
 This technique can be used only for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be launched only by using their URL. For more information on the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md).  
  
 This procedure uses the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)] tool MageUI.exe. For more information on this tool, see [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](https://msdn.microsoft.com/library/f9e130a6-8117-49c4-839c-c988f641dc14). You can also perform this procedure using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
## Procedure  
  
#### To disable URL activation for your application  
  
1. Open your deployment manifest in MageUI.exe. If you have not yet created one, follow the steps in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).  
  
2. Select the **Deployment Options** tab.  
  
3. Clear the **Automatically run application after installing** check box.  
  
4. Save and sign the manifest.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)
