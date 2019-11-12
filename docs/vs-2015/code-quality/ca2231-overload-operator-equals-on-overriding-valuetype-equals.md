---
title: "CA2231: Overload operator equals on overriding ValueType.Equals | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "OverloadOperatorEqualsOnOverridingValueTypeEquals"
  - "CA2231"
  - "OverrideOperatorEqualsOnOverridingValueTypeEquals"
helpviewer_keywords:
  - "OverloadOperatorEqualsOnOverridingValueTypeEquals"
  - "CA2231"
ms.assetid: 114c0161-261a-40ad-8b2c-0932d6909d2a
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2231: Overload operator equals on overriding ValueType.Equals
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OverloadOperatorEqualsOnOverridingValueTypeEquals|
|CheckId|CA2231|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A value type overrides <xref:System.Object.Equals%2A?displayProperty=fullName> but does not implement the equality operator.

## Rule Description
 In most programming languages there is no default implementation of the equality operator (==) for value types. If your programming language supports operator overloads, you should consider implementing the equality operator. Its behavior should be identical to that of <xref:System.Object.Equals%2A>.

 You cannot use the default equality operator in an overloaded implementation of the equality operator. Doing so will cause a stack overflow. To implement the equality operator, use the Object.Equals method in your implementation. For example:

```vb
If (Object.ReferenceEquals(left, Nothing)) Then
    Return Object.ReferenceEquals(right, Nothing)
Else
    Return left.Equals(right)
End If
```

```csharp
if (Object.ReferenceEquals(left, null))
    return Object.ReferenceEquals(right, null);
return left.Equals(right);
```

## How to Fix Violations
 To fix a violation of this rule, implement the equality operator.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule; however, we recommend that you provide the equality operator if possible.

## Example
 The following example defines a type that violates this rule.

 [!code-csharp[FxCop.Usage.EqualsGetHashCode#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.EqualsGetHashCode/cs/FxCop.Usage.EqualsGetHashCode.cs#1)]

## Related Rules
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)

 [CA2225: Operator overloads have named alternates](../code-quality/ca2225-operator-overloads-have-named-alternates.md)

 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)

 [CA2224: Override equals on overloading operator equals](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)

 [CA2218: Override GetHashCode on overriding Equals](../code-quality/ca2218-override-gethashcode-on-overriding-equals.md)

## See Also
 <xref:System.Object.Equals%2A?displayProperty=fullName>
