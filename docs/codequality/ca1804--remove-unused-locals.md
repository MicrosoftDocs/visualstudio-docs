---
title: "CA1804: Remove unused locals"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CA1804"
  - "RemoveUnusedLocals"
helpviewer_keywords: 
  - "RemoveUnusedLocals"
  - "CA1804"
ms.assetid: cc332e67-6543-4813-bd8a-6f6fc75bf22a
caps.latest.revision: 18
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1804: Remove unused locals
|||  
|-|-|  
|TypeName|RemoveUnusedLocals|  
|CheckId|CA1804|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A method declares a local variable but does not use the variable except possibly as the recipient of an assignment statement. For analysis by this rule, the tested assembly must be built with debugging information and the associated program database (.pdb) file must be available.  
  
## Rule Description  
 Unused local variables and unnecessary assignments increase the size of an assembly and decrease performance.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove or use the local variable. Note that the C# compiler that is included with [!INCLUDE[dnprdnlong](../codequality/includes/dnprdnlong_md.md)] removes unused local variables when the `optimize` option is enabled.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule if the variable was compiler emitted. It is also safe to suppress a warning from this rule, or to disable the rule, if performance and code maintenance are not primary concerns.  
  
## Example  
 The following example shows several unused local variables.  
  
 [!code[FxCop.Performance.UnusedLocals#1](../codequality/codesnippet/VisualBasic/ca1804--remove-unused-locals_1.vb)]
[!code[FxCop.Performance.UnusedLocals#1](../codequality/codesnippet/CSharp/ca1804--remove-unused-locals_1.cs)]  
  
## Related Rules  
 [CA1809: Avoid excessive locals](../codequality/ca1809--avoid-excessive-locals.md)  
  
 [CA1811: Avoid uncalled private code](../codequality/ca1811--avoid-uncalled-private-code.md)  
  
 [CA1812: Avoid uninstantiated internal classes](../codequality/ca1812--avoid-uninstantiated-internal-classes.md)  
  
 [CA1801: Review unused parameters](../codequality/ca1801--review-unused-parameters.md)