---
title: "How to: Change the Publish Language for a ClickOnce Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Publish language property"
  - "ClickOnce deployment, changing publish language"
  - "publishing, ClickOnce"
ms.assetid: ef5024c4-cda1-4970-bc75-32a2a10c92c3
caps.latest.revision: 21
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Change the Publish Language for a ClickOnce Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When publishing a [!INCLUDE[ndptecclick](../includes/ndptecclick-md.md)] application, the user interface displayed during installation defaults to the language and culture of your development computer. If you are publishing a localized application, you will need to specify a language and culture to match the localized version. This is determined by the `Publish language` property for your project.  
  
 The `Publish language` property can be set in the **Publish Options** dialog box, accessible from the **Publish** page of the **Project Designer**.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To change the publish language  
  
1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.  
  
2. Click the **Publish** tab.  
  
3. Click the **Options** button to open the **Publish Options** dialog box.  
  
4. Click **Description**.  
  
5. In the **Publish Options** dialog box, select a language and culture from the **Publish language** drop-down list, and then click **OK**.  
  
## See Also  
 [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)
