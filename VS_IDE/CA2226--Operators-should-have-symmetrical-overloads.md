---
title: "CA2226: Operators should have symmetrical overloads"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d202401a-ea14-4559-b15e-0ea4f5b68789
caps.latest.revision: 14
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA2226: Operators should have symmetrical overloads
|||  
|-|-|  
|TypeName|OperatorsShouldHaveSymmetricalOverloads|  
|CheckId|CA2226|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A type implements the equality or inequality operator and does not implement the opposite operator.  
  
## Rule Description  
 There are no circumstances where either equality or inequality is applicable to instances of a type, and the opposite operator is undefined. Types typically implement the inequality operator by returning the negated value of the equality operator.  
  
 The C# compiler issues an error for violations of this rule.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement both the equality and inequality operators, or remove the one that is present.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Your type will not work in a manner that is consistent with the .NET Framework.  
  
## Related Rules  
 [CA1046: Do not overload operator equals on reference types](../VS_IDE/CA1046--Do-not-overload-operator-equals-on-reference-types.md)  
  
 [CA2225: Operator overloads have named alternates](../VS_IDE/CA2225--Operator-overloads-have-named-alternates.md)  
  
 [CA2224: Override equals on overloading operator equals](../VS_IDE/CA2224--Override-equals-on-overloading-operator-equals.md)  
  
 [CA2218: Override GetHashCode on overriding Equals](../VS_IDE/CA2218--Override-GetHashCode-on-overriding-Equals.md)  
  
 [CA2231: Overload operator equals on overriding ValueType.Equals](../VS_IDE/CA2231--Overload-operator-equals-on-overriding-ValueType.Equals.md)