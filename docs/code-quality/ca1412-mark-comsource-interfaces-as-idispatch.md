---
title: "CA1412: Mark ComSource Interfaces as IDispatch | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-code-analysis"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "MarkComSourceInterfacesAsIDispatch"
  - "CA1412"
helpviewer_keywords: 
  - "CA1412"
  - "MarkComSourceInterfacesAsIDispatch"
ms.assetid: 131a7563-0410-443c-a8f5-52104250cfb4
caps.latest.revision: 16
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA1412: Mark ComSource Interfaces as IDispatch
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
  
 [!code-csharp[FxCop.Interoperability.MarkIDispatch#1](../code-quality/codesnippet/CSharp/ca1412-mark-comsource-interfaces-as-idispatch_1.cs)]
 [!code-vb[FxCop.Interoperability.MarkIDispatch#1](../code-quality/codesnippet/VisualBasic/ca1412-mark-comsource-interfaces-as-idispatch_1.vb)]  
  
## Related Rules  
 [CA1408: Do not use AutoDual ClassInterfaceType](../code-quality/ca1408-do-not-use-autodual-classinterfacetype.md)  
  
## See Also  
 [Interoperating with Unmanaged Code](/dotnet/framework/interop/index)