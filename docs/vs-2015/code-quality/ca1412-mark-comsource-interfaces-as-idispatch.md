---
title: "CA1412: Mark ComSource Interfaces as IDispatch | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MarkComSourceInterfacesAsIDispatch"
  - "CA1412"
helpviewer_keywords:
  - "CA1412"
  - "MarkComSourceInterfacesAsIDispatch"
ms.assetid: 131a7563-0410-443c-a8f5-52104250cfb4
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1412: Mark ComSource Interfaces as IDispatch
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkComSourceInterfacesAsIDispatch|
|CheckId|CA1412|
|Category|Microsoft.Interoperability|
|Breaking Change|Breaking|

## Cause
 A type is marked with the <xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> attribute and at least one specified interface is not marked with the <xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute set to the `InterfaceIsDispatch` value.

## Rule Description
 <xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> is used to identify the event interfaces that a class exposes to Component Object Model (COM) clients. These interfaces must be exposed as `InterfaceIsIDispatch` to enable Visual Basic 6 COM clients to receive event notifications. By default, if an interface is not marked with the <xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute, it is exposed as a dual interface.

## How to Fix Violations
 To fix a violation of this rule, add or modify the <xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute so that its value is set to InterfaceIsIDispatch for all interfaces that are specified with the <xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> attribute.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Example
 The following example shows a class where one of the interfaces violates the rule.

 [!code-csharp[FxCop.Interoperability.MarkIDispatch#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Interoperability.MarkIDispatch/cs/FxCop.Interoperability.MarkIDispatch.cs#1)]
 [!code-vb[FxCop.Interoperability.MarkIDispatch#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Interoperability.MarkIDispatch/vb/FxCop.Interoperability.MarkIDispatch.vb#1)]

## Related Rules
 [CA1408: Do not use AutoDual ClassInterfaceType](../code-quality/ca1408-do-not-use-autodual-classinterfacetype.md)

## See Also
 [How to: Raise Events Handled by a COM Sink](https://msdn.microsoft.com/7c9944b2-e951-4c3e-a0a1-59b2ae37d7fd)
 [Interoperating with Unmanaged Code](https://msdn.microsoft.com/library/ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)
