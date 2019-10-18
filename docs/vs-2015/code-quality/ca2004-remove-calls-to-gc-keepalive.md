---
title: "CA2004: Remove calls to GC.KeepAlive | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "RemoveCallsToGCKeepAlive"
  - "CA2004"
helpviewer_keywords:
  - "RemoveCallsToGCKeepAlive"
  - "CA2004"
ms.assetid: bc543b5b-23eb-4b45-abc2-9325cd254ac2
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2004: Remove calls to GC.KeepAlive
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|RemoveCallsToGCKeepAlive|
|CheckId|CA2004|
|Category|Microsoft.Reliability|
|Breaking Change|Non-breaking|

## Cause
 Classes use `SafeHandle` but still contain calls to `GC.KeepAlive`.

## Rule Description
 If you are converting to `SafeHandle` usage, remove all calls to `GC.KeepAlive` (object). In this case, classes should not have to call `GC.KeepAlive`,assuming they do not have a finalizer but rely on `SafeHandle` to complete the OS handle for them.  Although the cost of leaving in a call to `GC.KeepAlive` might be negligible as measured by performance, the perception that a call to `GC.KeepAlive` is either necessary or sufficient to solve a lifetime issue that might no longer exist makes the code harder to maintain.

## How to Fix Violations
 Remove calls to `GC.KeepAlive`.

## When to Suppress Warnings
 You can suppress this warning only if it is not technically correct to convert to `SafeHandle` usage in your class.
