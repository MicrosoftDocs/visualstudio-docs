---
title: "CA2226: Operators should have symmetrical overloads | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "OperatorsShouldHaveSymmetricalOverloads"
  - "CA2226"
helpviewer_keywords:
  - "OperatorsShouldHaveSymmetricalOverloads"
  - "CA2226"
ms.assetid: d202401a-ea14-4559-b15e-0ea4f5b68789
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2226: Operators should have symmetrical overloads
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
 Do not suppress a warning from this rule. Your type will not work in a manner that is consistent with the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].

## Related Rules
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)

 [CA2225: Operator overloads have named alternates](../code-quality/ca2225-operator-overloads-have-named-alternates.md)

 [CA2224: Override equals on overloading operator equals](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)

 [CA2218: Override GetHashCode on overriding Equals](../code-quality/ca2218-override-gethashcode-on-overriding-equals.md)

 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)
