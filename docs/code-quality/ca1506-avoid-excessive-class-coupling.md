---
title: "CA1506: Avoid excessive class coupling | Microsoft Docs"
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
  - "AvoidExcessiveClassCoupling"
  - "CA1506"
helpviewer_keywords: 
  - "AvoidExcessiveClassCoupling"
  - "CA1506"
ms.assetid: 9f0943c0-e802-4e3f-8798-2ab8653ddc80
caps.latest.revision: 12
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA1506: Avoid excessive class coupling
|||  
|-|-|  
|TypeName|AvoidExcessiveClassCoupling|  
|CheckId|CA1506|  
|Category|Microsoft.Maintainability|  
|Breaking Change|Breaking|  
  
## Cause  
 A type or method is coupled with many other types.  
  
## Rule Description  
 This rule measures class coupling by counting the number of unique type references that a type or method contains.  
  
 Types and methods that have a high degree of class coupling can be difficult to maintain. It is a good practice to have types and methods that exhibit low coupling and high cohesion.  
  
## How to Fix Violations  
 To fix this violation, try to redesign the type or method to reduce the number of types to which it is coupled.  
  
## When to Suppress Warnings  
 Exclude this warning when the type or method is still considered maintainable despite its large number of dependencies on other types.  
  
## See Also  
 [Maintainability Warnings](../code-quality/maintainability-warnings.md)   
 [Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)