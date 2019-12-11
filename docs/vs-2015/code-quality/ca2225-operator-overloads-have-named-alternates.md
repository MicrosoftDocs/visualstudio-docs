---
title: "CA2225: Operator overloads have named alternates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "OperatorOverloadsHaveNamedAlternates"
  - "CA2225"
helpviewer_keywords:
  - "OperatorOverloadsHaveNamedAlternates"
  - "CA2225"
ms.assetid: af8f7ab1-63ad-4861-afb9-b7a7a2be15e1
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2225: Operator overloads have named alternates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|OperatorOverloadsHaveNamedAlternates|
|CheckId|CA2225|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An operator overload was detected, and the expected named alternative method was not found.

## Rule Description
 Operator overloading allows the use of symbols to represent computations for a type. For example, a type that overloads the plus symbol (+) for addition would typically have an alternative member named 'Add'. The named alternative member provides access to the same functionality as the operator, and is provided for developers who program in languages that do not support overloaded operators.

 This rule examines the operators listed in the following table.

|C#|Visual Basic|C++|Alternate name|
|---------|------------------|-----------|--------------------|
|+ (binary)|+|+ (binary)|Add|
|+=|+=|+=|Add|
|&|And|&|BitwiseAnd|
|&=|And=|&=|BitwiseAnd|
|&#124;|Or|&#124;|BitwiseOr|
|&#124;=|Or=|&#124;=|BitwiseOr|
|--|N/A|--|Decrement|
|/|/|/|Divide|
|/=|/=|/=|Divide|
|==|=|==|Equals|
|^|Xor|^|Xor|
|^=|Xor=|^=|Xor|
|>|>|>|Compare|
|>=|>=|>=|Compare|
|++|N/A|++|Increment|
|<>|!=|Equals|
|<<|<<|<<|LeftShift|
|<<=|<<=|<<=|LeftShift|
|<|<|<|Compare|
|<=|<=|\<=|Compare|
|&&|N/A|&&|LogicalAnd|
|&#124;&#124;|N/A|&#124;&#124;|LogicalOr|
|!|N/A|!|LogicalNot|
|%|Mod|%|Mod or Remainder|
|%=|N/A|%=|Mod|
|* (binary)|*|*|Multiply|
|*=|N/A|*=|Multiply|
|~|Not|~|OnesComplement|
|>>|>>|>>|RightShift|
=|N/A|>>=|RightShift|
|- (binary)|- (binary)|- (binary)|Subtract|
|-=|N/A|-=|Subtract|
|true|IsTrue|N/A|IsTrue (Property)|
|- (unary)|N/A|-|Negate|
|+ (unary)|N/A|+|Plus|
|false|IsFalse|False|IsTrue (Property)|

 N/A == Cannot be overloaded in the selected language.

 The rule also checks implicit and explicit cast operators in a type (`SomeType`) by checking for methods named `ToSomeType` and `FromSomeType`.

 In C#, when a binary operator is overloaded, the corresponding assignment operator, if any, is also implicitly overloaded.

## How to Fix Violations
 To fix a violation of this rule, implement the alternative method for the operator; name it using the recommended alternative name.

## When to Suppress Warnings
 Do not suppress a warning from this rule if you are implementing a shared library. Applications can ignore a warning from this rule.

## Example
 The following example defines a structure that violates this rule. To correct the example, add a public `Add(int x, int y)` method to the structure.

 [!code-csharp[FxCop.Usage.OperatorOverloadsHaveNamedAlternates#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.OperatorOverloadsHaveNamedAlternates/cs/FxCop.Usage.OperatorOverloadsHaveNamedAlternates.cs#1)]

## Related Rules
 [CA1046: Do not overload operator equals on reference types](../code-quality/ca1046-do-not-overload-operator-equals-on-reference-types.md)

 [CA2226: Operators should have symmetrical overloads](../code-quality/ca2226-operators-should-have-symmetrical-overloads.md)

 [CA2224: Override equals on overloading operator equals](../code-quality/ca2224-override-equals-on-overloading-operator-equals.md)

 [CA2218: Override GetHashCode on overriding Equals](../code-quality/ca2218-override-gethashcode-on-overriding-equals.md)

 [CA2231: Overload operator equals on overriding ValueType.Equals](../code-quality/ca2231-overload-operator-equals-on-overriding-valuetype-equals.md)
