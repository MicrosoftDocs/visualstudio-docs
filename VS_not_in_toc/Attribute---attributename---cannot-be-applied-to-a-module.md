---
title: "Attribute &#39;&lt;attributename&gt;&#39; cannot be applied to a module"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b38fea31-6b0b-4c54-9518-b59226505802
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
# Attribute &#39;&lt;attributename&gt;&#39; cannot be applied to a module
You attempted to apply an attribute to a module whose `AttributeUsageAttribute` does not specify `AttributeTargets.Module`. When the attribute was declared, it was not defined to be applied to a module.  
  
 **Error ID:** BC30549  
  
### To correct this error  
  
1.  Check the attribute declaration and specify `AttributeTargets.Module`or`AttributeTargets.All`.  
  
## See Also  
 <xref:System.AttributeUsageAttribute?qualifyHint=False>   
 <xref:System.AttributeTargets?qualifyHint=False>