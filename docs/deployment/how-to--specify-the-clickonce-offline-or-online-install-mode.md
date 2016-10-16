---
title: "How to: Specify the ClickOnce Offline or Online Install Mode"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, specifying install mode"
  - "install mode"
  - "online applications"
  - "offline applications"
  - "ClickOnce install mode"
ms.assetid: 0aee5fc1-e966-4bda-9b8f-d9997aeaa779
caps.latest.revision: 8
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
# How to: Specify the ClickOnce Offline or Online Install Mode
The `Install Mode` for a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application determines whether the application will be available offline or online. When you choose **The application is available online only**, the user must have access to the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] publishing location (either a Web page or a file share) in order to run the application. When you choose **The application is available offline as well**, the application adds entries to the **Start** menu and the **Add or Remove Programs** dialog box; the user is able to run the application when they are not connected.  
  
 The `Install Mode` can be set on the **Publish** page of the **Project Designer**.  
  
 **Note** The `Install Mode` can also be set using the Publish wizard. For more information, see [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to--publish-a-clickonce-application-using-the-publish-wizard.md).  
  
### To make a ClickOnce application available online only  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In the **Install Mode and Settings** area, click the **The application is available online only** option button.  
  
### To make a ClickOnce application available online or offline  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In the **Install Mode and Settings** area, click the **The application is available offline as well** option button.  
  
     When installed, the application adds entries to the **Start** menu and to **Add or Remove Programs** in Control Panel.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to--publish-a-clickonce-application-using-the-publish-wizard.md)   
 [Choosing a ClickOnce Deployment Strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)