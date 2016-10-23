---
title: "MSBuild Error MSB3127"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 161eea9a-332f-463e-a49e-d4030e937d52
caps.latest.revision: 8
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
# MSBuild Error MSB3127
**MSB3127: The default icon <iconname\> could not be found in the current file references or is not part of the required download group. The default icon file name is case sensitive so the file name referenced in the application manifest must exactly match the icon's file name.**  
  
 When you publish an application that is configured to use file associations, the default icon that is referenced in the manifest must be located in the current file references, or it must be part of the required download group. The default icon is the icon that appears for files that have the configured file association (the configured file name extension).  
  
### To correct this error  
  
-   Add the icon file to the current project and include it in the required download group. For more information, see [How to: Specify Which Files Are Published by ClickOnce](../VS_IDE/How-to--Specify-Which-Files-Are-Published-by-ClickOnce.md).  
  
## See Also  
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)