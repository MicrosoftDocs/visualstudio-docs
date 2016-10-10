---
title: "XML literals and XML axis properties are not available during this debugging session because they are not used in this assembly"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 36be5c92-dd6b-41d4-894a-2bd71d772092
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
# XML literals and XML axis properties are not available during this debugging session because they are not used in this assembly
An XML literal or XML axis property has been referenced in the **Watch** or **Immediate** window during a debugging session in which XML in Visual Basic features are not available. This is the case for an assembly that either does not use the XML in Visual Basic features or is a release build.  
  
 **Error ID:** BC31196  
  
### To correct this error  
  
-   Start a new debugging session using the debug build of the assembly.  
  
## See Also  
 [Debugging Your Visual Basic Application](../Topic/Debugging%20Your%20Visual%20Basic%20Application.md)   
 [XML Literals](../Topic/XML%20Literals%20\(Visual%20Basic\).md)   
 [XML Axis Properties](../Topic/XML%20Axis%20Properties%20\(Visual%20Basic\).md)   
 [XML](../Topic/XML%20in%20Visual%20Basic.md)