---
title: "CA2224: Override equals on overloading operator equals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2224"
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "OverrideEqualsOnOverridingOperatorEquals"
helpviewer_keywords:
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "CA2224"
ms.assetid: 7312afd9-84ba-417f-923e-7a159b53bf70
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2224: Override equals on overloading operator equals
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverrideEqualsOnOverloadingOperatorEquals|
|CheckId|CA2224|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A public type implements the equality operator, but does not override <xref:System.Object.Equals%2A?displayProperty=fullName>.

## Rule Description
 The equality operator is intended to be a syntactically convenient way to access the functionality of the <xref:System.Object.Equals%2A> method. If you implement the equality operator, its logic must be identical to that of <xref:System.Object.Equals%2A>.

 The C# compiler issues a warning if your code violates this rule.

## How to Fix Violations
 To fix a violation of this rule, you should either remove the implementation of the equality operator, or override <xref:System.Object.Equals%2A> and have the two methods return the same values. If the equality operator does not introduce inconsistent behavior, you can fix the violation by providing an implementation of <xref:System.Object.Equals%2A> that calls the <xref:System.Object.Equals%2A> method in the base class.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if the equality operator returns the same value as the inherited implementation of <xref:System.Object.Equals%2A>. The Example section includes a type that could safely suppress a warning from this rule.

## Examples of Inconsistent Equality Definitions

### Description
 The following example shows a type with inconsistent definitions of equality. `BadPoint` changes the meaning of equality by providing a custom implementation of the equality operator, but does not override <xref:System.Object.Equals%2A> so that it behaves identically.

### Code
 [!code-csharp[FxCop.Usage.OperatorEqualsRequiresEquals#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OperatorEqualsRequiresEquals/cs/FxCop.Usage.OperatorEqualsRequiresEquals.cs#1)]

## Example
 The following code tests the behavior of `BadPoint`.

 [!code-csharp[FxCop.Usage.TestOperatorEqualsRequiresEquals#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.TestOperatorEqualsRequiresEquals/cs/FxCop.Usage.TestOperatorEqualsRequiresEquals.cs#1)]

 This example produces the following output.

 **a =  ([0] 1,1) and b = ([1] 2,2) are equal? No**
**a == b ? No**
**a1 and a are equal? Yes**
**a1 == a ? Yes**
**b and bcopy are equal ? No**
**b == bcopy ? Yes**
## Example
 The following example shows a type that technically violates this rule, but does not behave in an inconsistent manner.

 [!code-csharp[FxCop.Usage.ValueTypeEquals#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.ValueTypeEquals/cs/FxCop.Usage.ValueTypeEquals.cs#1)]

## Example
 The following code tests the behavior of `GoodPoint`.

 [!code-csharp[FxCop.Usage.TestValueTypeEquals#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.TestValueTypeEquals/cs/FxCop.Usage.TestValueTypeEquals.cs#1)]

 This example produces the following output.

 **a =  (1,1) and b = (2,2) are equal? No**
**a == b ? No**
**a1 and a are equal? Yes**
**a1 == a ? Yes**
**b and bcopy are equal ? Yes**
**b == bcopy ? Yes**
## Class Example

### Description
 The following example shows a class (reference type) that violates this rule.

### Code
 [!code-csharp[FxCop.Usage.OverrideEqualsClassViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsClassViolation/cs/FxCop.Usage.OverrideEqualsClassViolation.cs#1)]

## Example
 The following example fixes the violation by overriding <xref:System.Object.Equals%2A?displayProperty=fullName>.

 [!code-csharp[FxCop.Usage.OverrideEqualsClassFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsClassFixed/cs/FxCop.Usage.OverrideEqualsClassFixed.cs#1)]

## Structure Example

### Description
 The following example shows a structure (value type) that violates this rule.

### Code
 [!code-csharp[FxCop.Usage.OverrideEqualsStructViolation#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsStructViolation/cs/FxCop.Usage.OverrideEqualsStructViolation.cs#1)]

## Example
 The following example fixes the violation by overriding <xref:System.ValueType.Equals%2A?displayProperty=fullName>.

 [!code-csharp[FxCop.Usage.OverrideEqualsStructFixed#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OverrideEqualsStructFixed/cs/FxCop.Usage.OverrideEqualsStructFixed.cs#1)]

## Related Rules
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)

 [CA2225: Operator overloads have named alternates](../code-quality/ca2225-operator-overloads-have-named-alternates.md)

 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)

 [CA2218: Override GetHashCode on overriding Equals](../code-quality/ca2218-override-gethashcode-on-overriding-equals.md)

 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)
