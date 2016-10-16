---
title: "CA1050: Declare types in namespaces"
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
  - "CA1050"
  - "DeclareTypesInNamespaces"
helpviewer_keywords: 
  - "DeclareTypesInNamespaces"
  - "CA1050"
ms.assetid: 1002748d-ac8d-404f-85dd-7a12d1ad3e05
caps.latest.revision: 15
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
# CA1050: Declare types in namespaces
|||  
|-|-|  
|TypeName|DeclareTypesInNamespaces|  
|CheckId|CA1050|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type is defined outside the scope of a named namespace.  
  
## Rule Description  
 Types are declared in namespaces to prevent name collisions, and as a way to organize related types in an object hierarchy. Types that are outside any named namespace are in a global namespace that cannot be referenced in code.  
  
## How to Fix Violations  
 To fix a violation of this rule, place the type in a namespace.  
  
## When to Suppress Warnings  
 Although you never have to suppress a warning from this rule, it is safe to do this when the assembly will never be used together with other assemblies.  
  
## Example  
 The following example shows a library that has a type incorrectly declared outside a namespace, and a type that has the same name declared in a namespace.  
  
 [!code[FxCop.Design.TypesLiveInNamespaces#1](../codequality/codesnippet/CSharp/ca1050--declare-types-in-namespaces_1.cs)]
[!code[FxCop.Design.TypesLiveInNamespaces#1](../codequality/codesnippet/VisualBasic/ca1050--declare-types-in-namespaces_1.vb)]  
  
## Example  
 The following application uses the library that was defined previously. Note that the type that is declared outside a namespace is created when the name `Test` is not qualified by a namespace. Note also that to access the `Test` type in `Goodspace`, the namespace name is required.  
  
 [!code[FxCop.Design.TestTypesLive#1](../codequality/codesnippet/CSharp/ca1050--declare-types-in-namespaces_2.cs)]
[!code[FxCop.Design.TestTypesLive#1](../codequality/codesnippet/VisualBasic/ca1050--declare-types-in-namespaces_2.vb)]