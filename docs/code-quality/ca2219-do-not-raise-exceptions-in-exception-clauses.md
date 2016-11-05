---
title: "CA2219: Do not raise exceptions in exception clauses | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "DoNotRaiseExceptionsInExceptionClauses"
  - "CA2219"
helpviewer_keywords: 
  - "DoNotRaiseExceptionsInExceptionClauses"
  - "CA2219"
ms.assetid: 7b9b0bee-4e8e-49a4-8c40-52142b49061f
caps.latest.revision: 5
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA2219: Do not raise exceptions in exception clauses
|||  
|-|-|  
|TypeName|DoNotRaiseExceptionsInExceptionClauses|  
|CheckId|CA2219|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking, Breaking|  
  
## Cause  
 An exception is thrown from a `finally`, filter, or fault clause.  
  
## Rule Description  
 When an exception is raised in an exception clause, it greatly increases the difficulty of debugging.  
  
 When an exception is raised in a `finally` or fault clause, the new exception hides the active exception, if present. This makes the original error hard to detect and debug.  
  
 When an exception is raised in a filter clause, the runtime silently catches the exception, and causes the filter to evaluate to false. There is no way to tell the difference between the filter evaluating to false and an exception being throw from a filter. This makes it hard to detect and debug errors in the filter's logic.  
  
## How to Fix Violations  
 To fix this violation of this rule, do not explicitly raise an exception from a `finally`, filter, or fault clause.  
  
## When to Suppress Warnings  
 Do not suppress a warning for this rule. There are no scenarios under which an exception raised in an exception clause provides a benefit to the executing code.  
  
## Related Rules  
 [CA1065: Do not raise exceptions in unexpected locations](../code-quality/ca1065-do-not-raise-exceptions-in-unexpected-locations.md)  
  
## See Also  
 [Design Warnings](../code-quality/design-warnings.md)