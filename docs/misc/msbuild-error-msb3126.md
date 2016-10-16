---
title: "MSBuild Error MSB3126"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "GenerateManifest.FileAssociationsNotInstalled"
helpviewer_keywords: 
  - "MSB3126"
ms.assetid: 0c92cbb6-9100-4433-8113-f2f3a1432243
caps.latest.revision: 8
ms.author: "mblome"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# MSBuild Error MSB3126
**MSB3126: The application is using file associations but is not marked for installation. File associations cannot be used for applications that are not installed such as applications hosted in a web browser.**  
  
 This error occurs when an application is configured to use file associations but the application's install mode is set to online only. Because online only applications typically run in a browser, file associations are not available.  
  
### To correct this error  
  
-   Set the **Install Mode and Settings** to **The application is available offline as well (launchable from Start menu)**. For more information, see [How to: Specify the ClickOnce Offline or Online Install Mode](../deployment/how-to--specify-the-clickonce-offline-or-online-install-mode.md).  
  
## See Also  
 [Publish Page, Project Designer](../reference/publish-page--project-designer.md)   
 [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md)