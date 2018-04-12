---
title: "CA1600: Do not use idle process priority | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.technology: 
  - "vs-ide-code-analysis"
ms.topic: "article"
f1_keywords: 
  - "DoNotUseIdleProcessPriority"
  - "CA1600"
helpviewer_keywords: 
  - "CA1600"
  - "DoNotUseIdleProcessPriority"
ms.assetid: 9b0d073b-78b6-41be-8ef3-14692a735283
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# CA1600: Do not use idle process priority
|||  
|-|-|  
|TypeName|DoNotUseIdleProcessPriority|  
|CheckId|CA1600|  
|Category|Microsoft.Mobility|  
|Breaking Change|Breaking|  
  
## Cause  
 This rule occurs when processes are set to `ProcessPriorityClass.Idle`.  
  
## Rule Description  
 Do not set process priority to Idle. Processes that have `System.Diagnostics.ProcessPriorityClass.Idle` will occupy the CPU when it would otherwise be idle, and will therefore block standby.  
  
## How to Fix Violations  
 Set processes to `ProcessPriorityClass.BelowNormal`.  
  
## When to Suppress Warnings  
 This rule should be suppressed only when Idle process priority is required and mobility considerations can be ignored safely.