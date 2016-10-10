---
title: "CA1823: Avoid unused private fields"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 614f94f6-0dc7-430f-8124-cb889a4a720f
caps.latest.revision: 11
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
# CA1823: Avoid unused private fields
|||  
|-|-|  
|TypeName|AvoidUnusedPrivateFields|  
|CheckId|CA1823|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 This rule is reported when a private field in your code exists but is not used by any code path.  
  
## Rule Description  
 Private fields were detected that do not appear to be accessed in the assembly.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the field or add code that uses it.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule.  
  
## Related Rules  
 [CA1812: Avoid uninstantiated internal classes](../VS_IDE/CA1812--Avoid-uninstantiated-internal-classes.md)  
  
 [CA1801: Review unused parameters](../VS_IDE/CA1801--Review-unused-parameters.md)  
  
 [CA1804: Remove unused locals](../VS_IDE/CA1804--Remove-unused-locals.md)  
  
 [CA1811: Avoid uncalled private code](../VS_IDE/CA1811--Avoid-uncalled-private-code.md)