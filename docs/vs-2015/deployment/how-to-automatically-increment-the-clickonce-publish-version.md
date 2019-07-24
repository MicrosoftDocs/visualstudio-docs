---
title: "How to: Automatically Increment the ClickOnce Publish Version | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
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
caps.latest.revision: 11
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Automatically Increment the ClickOnce Publish Version
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When publishing a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application, changing the `Publish Version` property causes the application to be published as an update. By default, Visual Studio automatically increments the `Revision` number of the `Publish Version` each time you publish the application.  
  
 You can disable this behavior on the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To disable automatically incrementing the Publish Version  
  
1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2. Click the **Publish** tab.  
  
3. In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.  
  
## See Also  
 [How to: Set the ClickOnce Publish Version](../deployment/how-to-set-the-clickonce-publish-version.md)   
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
