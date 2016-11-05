---
title: "How to: Automatically Increment the ClickOnce Publish Version | Microsoft Docs"
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
  - "deploying applications [ClickOnce], incrementing publish version automatically"
  - "Publish Version property, incrementing"
  - "ClickOnce deployment, incrementing publish version automatically"
  - "publishing, ClickOnce"
ms.assetid: 686ab88a-6305-4914-a05b-fe269cc0ae1e
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
# How to: Automatically Increment the ClickOnce Publish Version
When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, changing the `Publish Version` property causes the application to be published as an update. By default, Visual Studio automatically increments the `Revision` number of the `Publish Version` each time you publish the application.  
  
 You can disable this behavior on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To disable automatically incrementing the Publish Version  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.  
  
## See Also  
 [How to: Set the ClickOnce Publish Version](../deployment/how-to-set-the-clickonce-publish-version.md)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)