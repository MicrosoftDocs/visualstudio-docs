---
title: "MSBuild Error MSB3141"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f32ce5fd-bb82-4a8b-aebe-61efef89cdc1
caps.latest.revision: 6
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
# MSBuild Error MSB3141
**MSB3141: No 'PublicKey' or 'Hash' attribute specified for file '<file\>' in item '<package\>'."**  
  
 This error occurs when you attempt to use HomeSite for the bootstrapper packages. However, the bootstrapper manifest does not contain the correct information for file verification (either a public key or a hash) at run time.  
  
### To correct this error  
  
-   Download the package file for which the information is missing and copy it into the bootstrapper cache.  
  
## See Also  
 [<PackageFiles\> Element](../VS_IDE/-PackageFiles--Element--Bootstrapper-.md)