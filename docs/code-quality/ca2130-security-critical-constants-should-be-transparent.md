---
title: "CA2130: Security critical constants should be transparent | Microsoft Docs"
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
  - "CA2130"
ms.assetid: 344c7f7b-9130-4675-ae7f-9fa260cc9789
caps.latest.revision: 10
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
# CA2130: Security critical constants should be transparent
|||  
|-|-|  
|TypeName|ConstantsShouldBeTransparent|  
|CheckId|CA2130|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A constant field or an enumeration member is marked with the <xref:System.Security.SecurityCriticalAttribute>.  
  
## Rule Description  
 Transparency enforcement is not enforced for constant values because compilers inline constant values so that no lookup is required at run time. Constant fields should be security transparent so that code reviewers do not assume that transparent code cannot access the constant.  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the SecurityCritical attribute from the field or value.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 In the following examples, the enum value `EnumWithCriticalValues.CriticalEnumValue` and the constant `CriticalConstant` raise this warning. To fix the issues, remove the [`SecurityCritical`] attribute to make them security transparent.  
  
 [!code-cs[FxCop.Security.CA2130.ConstantsShouldBeTransparent#1](../code-quality/codesnippet/CSharp/ca2130-security-critical-constants-should-be-transparent_1.cs)]