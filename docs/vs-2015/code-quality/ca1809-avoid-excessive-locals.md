---
title: "CA1809: Avoid excessive locals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1809"
  - "AvoidExcessiveLocals"
helpviewer_keywords:
  - "AvoidExcessiveLocals"
  - "CA1809"
ms.assetid: 5c81ea43-cb49-448f-980f-a1dd9764043c
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1809: Avoid excessive locals
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|AvoidExcessiveLocals|
|CheckId|CA1809|
|Category|Microsoft.Performance|
|Breaking Change|Non-breaking|

## Cause
 A member contains more than 64 local variables, some of which might be compiler-generated.

## Rule Description
 A common performance optimization is to store a value in a processor register instead of in memory, which is referred to as *enregistering* the value. The common language runtime considers up to 64 local variables for enregistration. Variables that are not enregistered are put on the stack and must be moved to a register before manipulation. To allow the chance that all local variables get enregistered, limit the number of local variables to 64.

## How to Fix Violations
 To fix a violation of this rule, refactor the implementation to use no more than 64 local variables.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule, or to disable the rule, if performance is not an issue.

## Related Rules
 [CA1804: Remove unused locals](../code-quality/ca1804-remove-unused-locals.md)
