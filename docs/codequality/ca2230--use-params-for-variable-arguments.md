---
title: "CA2230: Use params for variable arguments"
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
  - "UseParamsForVariableArguments"
  - "CA2230"
helpviewer_keywords: 
  - "CA2230"
  - "UseParamsForVariableArguments"
ms.assetid: bf98b733-4855-4110-9f16-eba5a9e79421
caps.latest.revision: 15
ms.author: "douge"
manager: "douge"
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
# CA2230: Use params for variable arguments
|||  
|-|-|  
|TypeName|UseParamsForVariableArguments|  
|CheckId|CA2230|  
|Category|Microsoft.Usage|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type contains a public or protected method that uses the `VarArgs` calling convention.  
  
## Rule Description  
 The `VarArgs` calling convention is used with certain method definitions that take a variable number of parameters. A method using the `VarArgs` calling convention is not Common Language Specification (CLS) compliant and might not be accessible across programming languages.  
  
 In C#, the `VarArgs` calling convention is used when a method's parameter list ends with the `__arglist` keyword. Visual Basic does not support the `VarArgs` calling convention, and Visual C++  allows its use only in unmanaged code that uses the ellipse `...` notation.  
  
## How to Fix Violations  
 To fix a violation of this rule in C#, use the [params](../Topic/params%20\(C%23%20Reference\).md) keyword instead of `__arglist`.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows two methods, one that violates the rule and one that satisfies the rule.  
  
 [!code[FxCop.Usage.UseParams#1](../codequality/codesnippet/CSharp/ca2230--use-params-for-variable-arguments_1.cs)]  
  
## See Also  
 \<xref:System.Reflection.CallingConventions?displayProperty=fullName>   
 [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md)