---
title: "CA1012: Abstract types should not have constructors"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "AbstractTypesShouldNotHaveConstructors"
  - "CA1012"
helpviewer_keywords:
  - "CA1012"
ms.assetid: 09f458ac-dd88-4cd7-a47f-4106c1e80ece
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# CA1012: Abstract types should not have constructors
|||
|-|-|
|TypeName|AbstractTypesShouldNotHaveConstructors|
|CheckId|CA1012|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A public type is abstract and has a public constructor.

## Rule Description
 Constructors on abstract types can be called only by derived types. Because public constructors create instances of a type, and you cannot create instances of an abstract type, an abstract type that has a public constructor is incorrectly designed.

## How to Fix Violations
 To fix a violation of this rule, either make the constructor protected or do not declare the type as abstract.

## When to Suppress Warnings
 Do not suppress a warning from this rule. The abstract type has a public constructor.

## Example
 The following example contains an abstract type that violates this rule.

 [!code-vb[FxCop.Design.AbstractTypeBad#1](../code-quality/codesnippet/VisualBasic/ca1012-abstract-types-should-not-have-constructors_1.vb)]
 [!code-csharp[FxCop.Design.AbstractTypeBad#1](../code-quality/codesnippet/CSharp/ca1012-abstract-types-should-not-have-constructors_1.cs)]

## Example
 The following example fixes the previous violation by changing the accessibility of the constructor from `public` to `protected`.

 [!code-csharp[FxCop.Design.AbstractTypeGood#1](../code-quality/codesnippet/CSharp/ca1012-abstract-types-should-not-have-constructors_2.cs)]
 [!code-vb[FxCop.Design.AbstractTypeGood#1](../code-quality/codesnippet/VisualBasic/ca1012-abstract-types-should-not-have-constructors_2.vb)]