---
title: "CA1011: Consider passing base types as parameters | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ConsiderPassingBaseTypesAsParameters"
  - "CA1011"
helpviewer_keywords:
  - "CA1011"
  - "ConsiderPassingBaseTypesAsParameters"
ms.assetid: ce1e1241-dcf4-419b-9363-1d5bc4989279
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1011: Consider passing base types as parameters
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ConsiderPassingBaseTypesAsParameters|
|CheckId|CA1011|
|Category|Microsoft.Design|
|Breaking Change|Breaking|

## Cause
 A method declaration includes a formal parameter that is a derived type, and the method calls only members of the base type of the parameter.

## Rule Description
 When a base type is specified as a parameter in a method declaration, any type that is derived from the base type can be passed as the corresponding argument to the method. When the argument is used inside the method body, the specific method that is executed depends on the type of the argument. If the additional functionality that is provided by the derived type is not required, use of the base type allows wider use of the method.

## How to Fix Violations
 To fix a violation of this rule, change the type of the parameter to its base type.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule

- if the method requires the specific functionality that is provided by the derived type

   \- or -

- to enforce that only the derived type, or a more derived type, is passed to the method.

  In these cases, the code will be more robust because of the strong type checking that is provided by the compiler and runtime.

## Example
 The following example shows a method, `ManipulateFileStream`, that can be used only with a <xref:System.IO.FileStream> object, which violates this rule. A second method, `ManipulateAnyStream`, satisfies the rule by replacing the <xref:System.IO.FileStream> parameter by using a <xref:System.IO.Stream>.

 [!code-cpp[FxCop.Design.ConsiderPassingBaseTypes#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Design.ConsiderPassingBaseTypes/cpp/FxCop.Design.ConsiderPassingBaseTypes.cpp#1)]
 [!code-csharp[FxCop.Design.ConsiderPassingBaseTypes#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Design.ConsiderPassingBaseTypes/cs/FxCop.Design.ConsiderPassingBaseTypes.cs#1)]
 [!code-vb[FxCop.Design.ConsiderPassingBaseTypes#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Design.ConsiderPassingBaseTypes/vb/FxCop.Design.ConsiderPassingBaseTypes.vb#1)]

## Related Rules
 [CA1059: Members should not expose certain concrete types](../code-quality/ca1059-members-should-not-expose-certain-concrete-types.md)
