---
title: "CA1040: Avoid empty interfaces"
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
  - "CA1040"
  - "AvoidEmptyInterfaces"
helpviewer_keywords: 
  - "AvoidEmptyInterfaces"
  - "CA1040"
ms.assetid: 120a741b-5fd1-4836-8453-7857e0cd0380
caps.latest.revision: 16
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# CA1040: Avoid empty interfaces
|||  
|-|-|  
|TypeName|AvoidEmptyInterfaces|  
|CheckId|CA1040|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The interface does not declare any members or implement two or more other interfaces.  
  
## Rule Description  
 Interfaces define members that provide a behavior or usage contract. The functionality that is described by the interface can be adopted by any type, regardless of where the type appears in the inheritance hierarchy. A type implements an interface by providing implementations for the members of the interface. An empty interface does not define any members. Therefore, it does not define a contract that can be implemented.  
  
 If your design includes empty interfaces that types are expected to implement, you are probably using an interface as a marker or a way to identify a group of types. If this identification will occur at run time, the correct way to accomplish this is to use a custom attribute. Use the presence or absence of the attribute, or the properties of the attribute, to identify the target types. If the identification must occur at compile time, then it is acceptable to use an empty interface.  
  
## How to Fix Violations  
 Remove the interface or add members to it. If the empty interface is being used to label a set of types, replace the interface with a custom attribute.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule when the interface is used to identify a set of types at compile time.  
  
## Example  
 The following example shows an empty interface.  
  
 [!code[FxCop.Design.InterfacesNotEmpty#1](../codequality/codesnippet/CSharp/ca1040--avoid-empty-interfaces_1.cs)]
[!code[FxCop.Design.InterfacesNotEmpty#1](../codequality/codesnippet/CPP/ca1040--avoid-empty-interfaces_1.cpp)]
[!code[FxCop.Design.InterfacesNotEmpty#1](../codequality/codesnippet/VisualBasic/ca1040--avoid-empty-interfaces_1.vb)]