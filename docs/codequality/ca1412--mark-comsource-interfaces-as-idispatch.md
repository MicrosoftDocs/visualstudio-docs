---
title: "CA1412: Mark ComSource Interfaces as IDispatch"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MarkComSourceInterfacesAsIDispatch"
  - "CA1412"
helpviewer_keywords: 
  - "CA1412"
  - "MarkComSourceInterfacesAsIDispatch"
ms.assetid: 131a7563-0410-443c-a8f5-52104250cfb4
caps.latest.revision: 16
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1412: Mark ComSource Interfaces as IDispatch
|||  
|-|-|  
|TypeName|MarkComSourceInterfacesAsIDispatch|  
|CheckId|CA1412|  
|Category|Microsoft.Interoperability|  
|Breaking Change|Breaking|  
  
## Cause  
 A type is marked with the \<xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> attribute and at least one specified interface is not marked with the \<xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute set to the `InterfaceIsDispatch` value.  
  
## Rule Description  
 \<xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> is used to identify the event interfaces that a class exposes to Component Object Model (COM) clients. These interfaces must be exposed as `InterfaceIsIDispatch` to enable Visual Basic 6 COM clients to receive event notifications. By default, if an interface is not marked with the \<xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute, it is exposed as a dual interface.  
  
## How to Fix Violations  
 To fix a violation of this rule, add or modify the \<xref:System.Runtime.InteropServices.InterfaceTypeAttribute> attribute so that its value is set to InterfaceIsIDispatch for all interfaces that are specified with the \<xref:System.Runtime.InteropServices.ComSourceInterfacesAttribute> attribute.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a class where one of the interfaces violates the rule.  
  
 [!code[FxCop.Interoperability.MarkIDispatch#1](../codequality/codesnippet/CSharp/ca1412--mark-comsource-interfaces-as-idispatch_1.cs)]
[!code[FxCop.Interoperability.MarkIDispatch#1](../codequality/codesnippet/VisualBasic/ca1412--mark-comsource-interfaces-as-idispatch_1.vb)]  
  
## Related Rules  
 [CA1408: Do not use AutoDual ClassInterfaceType](../codequality/ca1408--do-not-use-autodual-classinterfacetype.md)  
  
## See Also  
 [How to: Raise Events Handled by a COM Sink](assetId:///7c9944b2-e951-4c3e-a0a1-59b2ae37d7fd)   
 [Interoperating with Unmanaged Code](../Topic/Interoperating%20with%20Unmanaged%20Code.md)