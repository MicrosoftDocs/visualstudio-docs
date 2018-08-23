---
title: "CA1601: Do not use timers that prevent power state changes | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "CA1601"
  - "DoNotUseTimersThatPreventPowerStateChanges"
helpviewer_keywords:
  - "CA1601"
  - "DoNotUseTimersThatPreventPowerStateChanges"
ms.assetid: b8028c92-0696-4c54-9773-0028f29bda9a
caps.latest.revision: 17
author: gewarren
ms.author: gewarren
manager: "wpickett"
---
# CA1601: Do not use timers that prevent power state changes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [CA1601: Do not use timers that prevent power state changes](https://docs.microsoft.com/visualstudio/code-quality/ca1601-do-not-use-timers-that-prevent-power-state-changes).

|TypeName|DoNotUseTimersThatPreventPowerStateChanges|
|CheckId|CA1601|
|Category|Microsoft.Mobility|
|Breaking Change|Breaking|

## Cause
 A timer has an interval set to occur more than one time per second.

## Rule Description
 Do not poll more often than one time per second or use timers that occur more frequently than one time per second. Higher-frequency periodic activity will keep the CPU busy and interfere with power-saving idle timers that turn off the display and hard disks.

## How to Fix Violations
 Set timer intervals to occur less than one time per second.

## When to Suppress Warnings
 This rule should be suppressed only if firing the timer more than one time per second is required and mobility considerations can safely be ignored.



