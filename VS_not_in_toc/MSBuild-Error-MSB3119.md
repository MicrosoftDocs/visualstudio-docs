---
title: "MSBuild Error MSB3119"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 52d68b0e-01d4-436f-a96c-733fd20a8c04
caps.latest.revision: 12
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
# MSBuild Error MSB3119
**MSB3119: File association extensions must start with a period character (.).**  
  
 This error occurs when you configure a file association and the extension does not start with a period character (.).  
  
### To correct this error  
  
-   Set the [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md)`extension` attribute to a value that starts with a period character (.), for example, ".doc".  
  
## See Also  
 [Publish Page, Project Designer](../VS_IDE/Publish-Page--Project-Designer.md)   
 [ClickOnce Application Manifest](../VS_IDE/ClickOnce-Application-Manifest.md)