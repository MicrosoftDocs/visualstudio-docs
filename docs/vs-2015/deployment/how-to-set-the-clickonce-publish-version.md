---
title: "How to: Set the ClickOnce Publish Version | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "ClickOnce deployment, setting publish version"
  - "publishing, ClickOnce"
  - "Publish Version property"
ms.assetid: 06f15504-6385-40a6-b01d-cd90ca36dc73
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Set the ClickOnce Publish Version
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] `Publish Version` property determines whether or not the application that you are publishing will be treated as an update. Each time version is incremented, the application will be published as an update.  
  
 The `Publish Version` property can be set on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
> There is a project option that will automatically increment the `Publish Version` property each time the application is published; this option is enabled by default. For more information, see [How to: Automatically Increment the ClickOnce Publish Version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md).  
  
### To change the Publish Version  
  
1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.  
  
2. Click the **Publish** tab.  
  
3. In **Publish Version** field, increment the **Major**, **Minor**, **Build**, or **Revision** version numbers.  
  
    > [!NOTE]
    > You should never decrement a version number; doing so could cause unpredictable update behavior.  
  
## See Also  
 [Choosing a ClickOnce Update Strategy](../deployment/choosing-a-clickonce-update-strategy.md)   
 [How to: Automatically Increment the ClickOnce Publish Version](../deployment/how-to-automatically-increment-the-clickonce-publish-version.md)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
