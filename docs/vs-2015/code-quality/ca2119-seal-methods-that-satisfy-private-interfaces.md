---
title: "CA2119: Seal methods that satisfy private interfaces | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "SealMethodsThatSatisfyPrivateInterfaces"
  - "CA2119"
helpviewer_keywords:
  - "CA2119"
  - "SealMethodsThatSatisfyPrivateInterfaces"
ms.assetid: 483d02e1-cfaf-4754-a98f-4116df0f3509
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2119: Seal methods that satisfy private interfaces
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|SealMethodsThatSatisfyPrivateInterfaces|
|CheckId|CA2119|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 An inheritable public type provides an overridable method implementation of an `internal` (`Friend` in Visual Basic) interface.

## Rule Description
 Interface methods have public accessibility, which cannot be changed by the implementing type. An internal interface creates a contract that is not intended to be implemented outside the assembly that defines the interface. A public type that implements a method of an internal interface using the `virtual` (`Overridable` in Visual Basic) modifier allows the method to be overridden by a derived type that is outside the assembly. If a second type in the defining assembly calls the method and expects an internal-only contract, behavior might be compromised when, instead, the overridden method in the outside assembly is executed. This creates a security vulnerability.

## How to Fix Violations
 To fix a violation of this rule, prevent the method from being overridden outside the assembly by using one of the following:

- Make the declaring type `sealed` (`NotInheritable` in Visual Basic).

- Change the accessibility of the declaring type to `internal` (`Friend` in Visual Basic).

- Remove all public constructors from the declaring type.

- Implement the method without using the `virtual` modifier.

- Implement the method explicitly.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if, after careful review, no security issues exist that might be exploitable if the method is overridden outside the assembly.

## Example
 The following example shows a type, `BaseImplementation`, that violates this rule.

 [!code-cpp[FxCop.Security.SealMethods1#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods1/cpp/FxCop.Security.SealMethods1.cpp#1)]
 [!code-csharp[FxCop.Security.SealMethods1#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods1/cs/FxCop.Security.SealMethods1.cs#1)]
 [!code-vb[FxCop.Security.SealMethods1#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods1/vb/FxCop.Security.SealMethods1.vb#1)]

## Example
 The following example exploits the virtual method implementation of the previous example.

 [!code-cpp[FxCop.Security.SealMethods2#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods2/cpp/FxCop.Security.SealMethods2.cpp#1)]
 [!code-csharp[FxCop.Security.SealMethods2#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods2/cs/FxCop.Security.SealMethods2.cs#1)]
 [!code-vb[FxCop.Security.SealMethods2#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Security.SealMethods2/vb/FxCop.Security.SealMethods2.vb#1)]

## See Also
 [Interfaces](https://msdn.microsoft.com/library/2feda177-ce11-432d-81b4-d50f5f35fd37)
 [Interfaces](https://msdn.microsoft.com/library/61b06674-12c9-430b-be68-cc67ecee1f5b)
