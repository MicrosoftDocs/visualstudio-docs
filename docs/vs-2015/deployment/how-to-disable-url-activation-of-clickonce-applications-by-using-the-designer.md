---
title: "How to: Disable URL Activation of ClickOnce Applications by Using the Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "disallowURLActivation"
  - "URL activation, ClickOnce applications"
  - "ClickOnce deployment, URL activation"
ms.assetid: a337a582-e67c-409a-b52e-607cd1a8fc57
caps.latest.revision: 18
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Disable URL Activation of ClickOnce Applications by Using the Designer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Typically, a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application will start automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to start the application from the **Start** menu instead. The following procedure describes how to disable URL activation.  
  
 This technique can be used only for [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be started only by using their URL. For more information about the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md).  
  
 This procedure uses [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. You can also accomplish this task by using the [!INCLUDE[winsdklong](../includes/winsdklong-md.md)]. For more information, see [How to: Disable URL Activation of ClickOnce Applications](../deployment/how-to-disable-url-activation-of-clickonce-applications.md).  
  
## Procedure  
  
#### To disable URL activation for your application  
  
1. Right-click your project name in **Solution Explorer**, and click **Properties**.  
  
2. On the **Properties** page, click the **Publish** tab.  
  
3. Click **Options**.  
  
4. Click **Manifests**.  
  
5. Select the check box labeled **Block application from being activated via a URL**.  
  
6. Deploy your application.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)
