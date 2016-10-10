---
title: "How to: Enable AutoStart for CD Installations"
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
ms.assetid: caaec619-900c-4790-90e3-8c91f5347635
caps.latest.revision: 17
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
# How to: Enable AutoStart for CD Installations
When deploying a ClickOnce application by means of removable media such as CD-ROM or DVD-ROM, you can enable `AutoStart` so that the ClickOnce application is automatically launched when the media is inserted.  
  
 `AutoStart` can be enabled on the **Publish** page of the **Project Designer**.  
  
### To enable AutoStart  
  
1.  With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.  
  
2.  Click the **Publish** tab.  
  
3.  Click the **Options** button.  
  
     The **Publish Options** dialog box appears.  
  
4.  Click **Deployment**.  
  
5.  Select the **For CD installations, automatically start Setup when CD is inserted** check box.  
  
     An Autorun.inf file will be copied to the publish location when the application is published.  
  
## See Also  
 [Publishing ClickOnce Applications](../VS_IDE/Publishing-ClickOnce-Applications.md)   
 [How to: Publish a ClickOnce Application using the Publish Wizard](../VS_IDE/How-to--Publish-a-ClickOnce-Application-using-the-Publish-Wizard.md)