---
title: "CA1408: Do not use AutoDual ClassInterfaceType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "DoNotUseAutoDualClassInterfaceType"
  - "CA1408"
helpviewer_keywords:
  - "CA1408"
  - "DoNotUseAutoDualClassInterfaceType"
ms.assetid: 60ca5e02-3c51-42dd-942b-4f950eecfa0f
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1408: Do not use AutoDual ClassInterfaceType
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotUseAutoDualClassInterfaceType|
|CheckId|CA1408|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A Component Object Model (COM) visible type is marked with the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute set to the `AutoDual` value of <xref:System.Runtime.InteropServices.ClassInterfaceType>.

## Rule Description
 Types that use a dual interface enable clients to bind to a specific interface layout. Any changes in a future version to the layout of the type or any base types will break COM clients that bind to the interface. By default, if the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute is not specified, a dispatch-only interface is used.

 Unless marked otherwise, all public nongeneric types are visible to COM; all nonpublic and generic types are invisible to COM.

## How to Fix Violations
 To fix a violation of this rule, change the value of the <xref:System.Runtime.InteropServices.ClassInterfaceAttribute> attribute to the `None` value of <xref:System.Runtime.InteropServices.ClassInterfaceType> and explicitly define the interface.

## When to Suppress Warnings
 Do not suppress a warning from this rule unless it is certain that the layout of the type and its base types will not change in a future version.

## Example
 The following example shows a class that violates the rule and a re-declaration of the class to use an explicit interface.

 [!code-csharp[FxCop.Interoperability.AutoDual#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoDual/cs/FxCop.Interoperability.AutoDual.cs#1)]
 [!code-vb[FxCop.Interoperability.AutoDual#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.AutoDual/vb/FxCop.Interoperability.AutoDual.vb#1)]

## Related Rules
 [CA1403: Auto layout types should not be COM visible](../code-quality/ca1403-auto-layout-types-should-not-be-com-visible.md)

 [CA1412: Mark ComSource Interfaces as IDispatch](../code-quality/ca1412-mark-comsource-interfaces-as-idispatch.md)

## See Also
 [Introducing the Class Interface](https://msdn.microsoft.com/733c0dd2-12e5-46e6-8de1-39d5b25df024)
 [Qualifying .NET Types for Interoperation](https://msdn.microsoft.com/library/4b8afb52-fb8d-4e65-b47c-fd82956a3cdd)
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
