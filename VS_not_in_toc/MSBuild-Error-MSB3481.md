---
title: "MSBuild Error MSB3481"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 55f99775-3bd5-4e1b-b184-c6405d75e8ff
caps.latest.revision: 5
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
# MSBuild Error MSB3481
**MSB3481: The signing certificate could not be located. Ensure that it is in the current user's personal store.**  
  
 This error is generated when the signing certificate was not found in your personal certificate store. This error is similar to [MSBuild Error MSB3486](../VS_not_in_toc/MSBuild-Error-MSB3486.md), which means that the certificate was found, but does not match.  
  
### To correct this error  
  
-   Make sure that a valid certificate that matches your project's .pfx file is in your personal certificate store.  
  
## See Also  
 [<PackageFiles\> Element](../VS_IDE/-PackageFiles--Element--Bootstrapper-.md)