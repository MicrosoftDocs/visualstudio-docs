---
title: "CA1600: Do not use idle process priority"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9b0d073b-78b6-41be-8ef3-14692a735283
caps.latest.revision: 15
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
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