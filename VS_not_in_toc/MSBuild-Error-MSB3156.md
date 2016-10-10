---
title: "MSBuild Error MSB3156"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 98b1bd42-9efe-44a2-8a43-476edc03590d
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
# MSBuild Error MSB3156
**MSB3156: Xml validation did not pass for item '<package\>' located at '<folder\>'.**  
  
 This warning is generated when the manifest (specifically product.xml) does not pass XML validation. The specific problems are listed in a subsequent error message ([MSBuild Error MSB3159](../VS_not_in_toc/MSBuild-Error-MSB3159.md) or [MSBuild Error MSB3160](../VS_not_in_toc/MSBuild-Error-MSB3160.md)).  
  
### To correct this error  
  
-   Resolve the manifest validation issues listed in the subsequent error messages.  
  
## See Also  
 [Product and Package Schema Reference](../VS_IDE/Product-and-Package-Schema-Reference.md)   
 [<PackageFiles\> Element](../VS_IDE/-PackageFiles--Element--Bootstrapper-.md)