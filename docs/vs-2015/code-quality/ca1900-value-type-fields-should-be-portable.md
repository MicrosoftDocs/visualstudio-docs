---
title: "CA1900: Value type fields should be portable | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1900"
  - "ValueTypeFieldsShouldBePortable"
helpviewer_keywords:
  - "ValueTypeFieldsShouldBePortable"
  - "CA1900"
ms.assetid: 1787d371-389f-4d39-b305-12b53bc0dfb9
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1900: Value type fields should be portable
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1900: Value type fields should be portable](https://docs.microsoft.com/visualstudio/code-quality/ca1900-value-type-fields-should-be-portable).

|||
|-|-|
|TypeName|ValueTypeFieldsShouldBePortable|
|CheckId|CA1900|
|Category|Microsoft.Portability|
|Breaking Change|Breaking - If the field can be seen outside the assembly.<br /><br /> Non-breaking - If the field is not visible outside the assembly.|

## Cause
 This rule checks that structures that are declared with explicit layout will align correctly when marshaled to unmanaged code on 64-bit operating systems. IA-64 does not allow unaligned memory accesses and the process will crash if this violation is not fixed.

## Rule Description
 Structures that have explicit layout that contains misaligned fields cause crashes on 64-bit operating systems.

## How to Fix Violations
 All fields that are smaller than 8 bytes must have offsets that are a multiple of their size, and fields that are 8 bytes or more must have offsets that are a multiple of 8. Another solution is to use `LayoutKind.Sequential` instead of `LayoutKind.Explicit`, if reasonable.

## When to Suppress Warnings
 This warning should be suppressed only if it occurs in error.
