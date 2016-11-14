---
title: "How to: Disable URL Activation of ClickOnce Applications | Microsoft Docs"
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
  - "disallowUrlActivation"
  - "URL activation, ClickOnce applications"
  - "ClickOnce deployment, URL activation"
ms.assetid: db31a16b-960f-4264-91d7-c7c40f876068
caps.latest.revision: 9
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Disable URL Activation of ClickOnce Applications
Typically, a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application will launch automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to launch the application from the **Start** menu instead. The following procedure describes how to disable URL activation.  
  
 This technique can be used only for [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be launched only by using their URL. For more information on the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md).  
  
 This procedure uses the [!INCLUDE[winsdklong](../deployment/includes/winsdklong_md.md)] tool MageUI.exe. For more information on this tool, see [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](../Topic/MageUI.exe%20\(Manifest%20Generation%20and%20Editing%20Tool,%20Graphical%20Client\).md). You can also perform this procedure using [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
## Procedure  
  
#### To disable URL activation for your application  
  
1.  Open your deployment manifest in MageUI.exe. If you have not yet created one, follow the steps in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md).  
  
2.  Select the **Deployment Options** tab.  
  
3.  Clear the **Automatically run application after installing** check box.  
  
4.  Save and sign the manifest.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)