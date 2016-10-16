---
title: "CA1821: Remove empty finalizers"
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
  - "RemoveEmptyFinalizers"
  - "CA1821"
helpviewer_keywords: 
  - "CA1821"
ms.assetid: 3f4855a0-e4a0-46e6-923c-4c3b7074048d
caps.latest.revision: 13
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
# CA1821: Remove empty finalizers
|||  
|-|-|  
|TypeName|RemoveEmptyFinalizers|  
|CheckId|CA1821|  
|Category|Microsoft.Performance|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A type implements a finalizer that is empty, calls only the base type finalizer, or calls only conditionally emitted methods.  
  
## Rule Description  
 Whenever you can, avoid finalizers because of the additional performance overhead that is involved in tracking object lifetime. The garbage collector will run the finalizer before it collects the object. This means that two collections will be required to collect the object. An empty finalizer incurs this added overhead without any benefit.  
  
## How to Fix Violations  
 Remove the empty finalizer. If a finalizer is required for debugging, enclose the whole finalizer in `#if DEBUG / #endif` directives.  
  
## When to Suppress Warnings  
 Do not suppress a message from this rule. Failure to suppress finalization decreases performance and provides no benefits.  
  
## Example  
 The following example shows an empty finalizer that should be removed, a finalizer that should be enclosed in `#if DEBUG / #endif` directives, and a finalizer that uses the `#if DEBUG / #endif` directives correctly.  
  
 [!code[FxCop.Performance.RemoveEmptyFinalizers#1](../codequality/codesnippet/CSharp/ca1821--remove-empty-finalizers_1.cs)]