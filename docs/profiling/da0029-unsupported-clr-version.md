---
title: "DA0029: Unsupported CLR Version | Microsoft Docs"
ms.custom: 
ms.date: "11/04/2016"
ms.reviewer: 
ms.suite: 
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: 
ms.topic: "article"
f1_keywords: 
  - "vs.performance.29"
  - "vs.performance.rules.DA0029"
helpviewer_keywords: 
  - "vs.performance.29"
  - "vs.performance.DA0029"
  - "vs.performance.rules.DA0029"
author: "mikejo5000"
ms.author: "mikejo"
<<<<<<< HEAD
manager: "ghogen"
=======
manager: ghogen
ms.workload: 
  - "multiple"
>>>>>>> master
---
# DA0029: Unsupported CLR Version

|||
|-|-|
|Rule Id|DA0029|
|Category|Profiling Tools Usage|
|Profiling method|Profiling from the command line|
|Message|An unsupported CLR version was detected during collection. Managed symbols may not resolve correctly.|
|Rule type|Information.|

## Cause

You are trying to profile an application that uses the .NET Framework 1.1 that is not supported by the Profiling Tools.

## Rule Description

This warning occurs because the profiling tools will be unable to resolve symbols for the managed code running in the application. The profiling tools cannot resolve managed code symbols for applications that are running the .NET Framework 1.1.

## How to Fix Violations

None.