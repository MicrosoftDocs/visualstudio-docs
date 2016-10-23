---
title: "MSBuild Error MSB3124"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d8365103-aa9d-400e-9c24-0a43e2bfbd14
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
# MSBuild Error MSB3124
**MSB3124: A file association has already been created for extension '<extensionname\>'.**  
  
 This error occurs when a duplicate file association extension is encountered.  
  
### To correct this error  
  
-   Remove [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md)`extension` attributes that are not unique. Each listed <fileAssociation\> element's extension attributes must be unique.  
  
## See Also  
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [ClickOnce Application Manifest](../VS_IDE/ClickOnce-Application-Manifest.md)