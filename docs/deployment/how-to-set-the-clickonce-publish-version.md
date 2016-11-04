---
title: "How to: Set the ClickOnce Publish Version | Microsoft Docs"
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
  - "ClickOnce deployment, setting publish version"
  - "publishing, ClickOnce"
  - "Publish Version property"
ms.assetid: 06f15504-6385-40a6-b01d-cd90ca36dc73
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
# How to: Set the ClickOnce Publish Version
The [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] `Publish Version` property determines whether or not the application that you are publishing will be treated as an update. Each time version is incremented, the application will be published as an update.  
  
 The `Publish Version` property can be set on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
>  There is a project option that will automatically increment the `Publish Version` property each time the application is published; this option is enabled by default. For more information, see [How to: Automatically Increment the ClickOnce Publish Version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md).  
  
### To change the Publish Version  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In **Publish Version** field, increment the **Major**, **Minor**, **Build**, or **Revision** version numbers.  
  
    > [!NOTE]
    >  You should never decrement a version number; doing so could cause unpredictable update behavior.  
  
## See Also  
 [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md)   
 [How to: Automatically Increment the ClickOnce Publish Version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)