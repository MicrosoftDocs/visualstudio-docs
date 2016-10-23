---
title: "Methods declared &#39;Overrides&#39; cannot be declared &#39;Overridable&#39; because they are implicitly overridable"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cc892f81-eb1f-42a9-8f54-eff352adb5dd
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
# Methods declared &#39;Overrides&#39; cannot be declared &#39;Overridable&#39; because they are implicitly overridable
Unlike most methods, methods marked with the `Overrides` modifier are overridable by default.  
  
 **Error ID:** BC30730  
  
### To correct this error  
  
-   Omit the `Overridable` modifier from methods marked with the `Overrides` modifier.  
  
## See Also  
 [Overrides](../Topic/Overrides%20\(Visual%20Basic\).md)   
 [Overridable](../Topic/Overridable%20\(Visual%20Basic\).md)