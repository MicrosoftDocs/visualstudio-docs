---
title: "MSBuild Error MSB3125"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f8a08b05-1946-4788-8577-ceefde785e95
caps.latest.revision: 7
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Error MSB3125
**MSB3125: The application is using file associations but has no EntryPoint build parameter.**  
  
 This error occurs when no entryPoint build parameter is present. When you configure an application to use file associations, there must be an entryPoint build parameter in the application manifest. The <entryPoint\> element identifies the assembly that should be executed when the application is run.  
  
### To correct this error  
  
-   Set the [<entryPoint\> Element](../VS_IDE/-entryPoint--Element--ClickOnce-Application-.md) to a valid value. For more information, see [ClickOnce Application Manifest](../VS_IDE/ClickOnce-Application-Manifest.md).  
  
## See Also  
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [ClickOnce Application Manifest](../VS_IDE/ClickOnce-Application-Manifest.md)