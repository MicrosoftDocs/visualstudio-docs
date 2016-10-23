---
title: "How to: Disable URL Activation of ClickOnce Applications by Using the Designer"
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
ms.assetid: a337a582-e67c-409a-b52e-607cd1a8fc57
caps.latest.revision: 16
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
# How to: Disable URL Activation of ClickOnce Applications by Using the Designer
Typically, a ClickOnce application will start automatically immediately after it is installed from a Web server. For security reasons, you may decide to disable this behavior, and tell users to start the application from the **Start** menu instead. The following procedure describes how to disable URL activation.  
  
 This technique can be used only for ClickOnce applications installed on the user's computer from a Web server. It cannot be used for online-only applications, which can be started only by using their URL. For more information about the difference between online-only and installed applications, see [Choosing a ClickOnce Deployment Strategy](../VS_IDE/Choosing-a-ClickOnce-Deployment-Strategy.md).  
  
 This procedure uses Visual Studio. You can also accomplish this task by using the Windows Software Development Kit (SDK). For more information, see [How to: Disable URL Activation of ClickOnce Applications](../VS_IDE/How-to--Disable-URL-Activation-of-ClickOnce-Applications.md).  
  
## Procedure  
  
#### To disable URL activation for your application  
  
1.  Right-click your project name in **Solution Explorer**, and click **Properties**.  
  
2.  On the **Properties** page, click the **Publish** tab.  
  
3.  Click **Options**.  
  
4.  Click **Manifests**.  
  
5.  Select the check box labeled **Block application from being activated via a URL**.  
  
6.  Deploy your application.  
  
## See Also  
 [Publishing ClickOnce Applications](../VS_IDE/Publishing-ClickOnce-Applications.md)