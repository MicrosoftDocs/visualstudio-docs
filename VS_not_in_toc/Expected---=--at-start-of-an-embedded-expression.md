---
title: "Expected &#39;%=&#39; at start of an embedded expression"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 20b0382e-1744-47e4-84e1-7fc926cbc4df
caps.latest.revision: 4
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
# Expected &#39;%=&#39; at start of an embedded expression
The start identifier for an embedded expression, `<%=`, has not been coded correctly. Note that you cannot use a percent character (%) in the name for an XML element literal.  
  
 **Error ID:** BC31179  
  
### To correct this error  
  
-   Ensure that the start identifier for the embedded expression is coded as `<%=`.  
  
## See Also  
 [Embedded Expressions in XML](../Topic/Embedded%20Expressions%20in%20XML%20\(Visual%20Basic\).md)   
 [XML Literals](../Topic/XML%20Literals%20\(Visual%20Basic\).md)   
 [XML](../Topic/XML%20in%20Visual%20Basic.md)