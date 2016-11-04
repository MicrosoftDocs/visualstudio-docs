---
title: "How to: Specify a Start Menu Name for a ClickOnce Application | Microsoft Docs"
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
  - "Start menu resource name"
  - "Start menu name"
  - "ClickOnce deployment, Start menu name"
ms.assetid: 4b5183b2-2fd4-4433-9310-4a73bb12c4e3
caps.latest.revision: 17
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
# How to: Specify a Start Menu Name for a ClickOnce Application
When a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application is installed for both online and offline use, an entry is added to the **Start** menu and the **Add or Remove Programs** list. By default, the display name is the same as the name of the application assembly, but you can change the display name by setting **Product name** in the **Publish Options** dialog box.  
  
 **Product name** will be displayed on the publish.htm page; for an installed offline application, it will be the name of the entry in the **Start** menu, and it will also be the name that shows in **Add or Remove Programs**.  
  
 **Publisher name** will appear on the publish.htm page above **Product name**, and for an installed offline application, it will also be the name of the folder that contains the application's icon in the **Start** menu.  
  
 You can set the **Product name** and **Publisher name** properties in the **Publish Options** dialog box, available on the **Publish** page of the **Project Designer**.  
  
### To specify a Start menu name  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  Click the **Options** button to open the **Publish Options** dialog box.  
  
4.  Click **Description**.  
  
5.  In the **Publish Options** dialog box, enter the name to display in **Product name**.  
  
6.  Optionally, you can enter a publisher name in **Publisher name**.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)