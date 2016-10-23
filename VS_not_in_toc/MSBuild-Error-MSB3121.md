---
title: "MSBuild Error MSB3121"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c1e83a2a-515f-412d-b8b7-4821e510a923
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
# MSBuild Error MSB3121
**MSB3121: The file association element in the application manifest is missing one or more of the following required attributes: extension, description, progid, or default icon.**  
  
 The [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md) must contain values for all four attributes.  
  
### To correct this error  
  
-   Set each [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md) attribute to a valid value.  
  
## See Also  
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [ClickOnce Application Manifest](../VS_IDE/ClickOnce-Application-Manifest.md)