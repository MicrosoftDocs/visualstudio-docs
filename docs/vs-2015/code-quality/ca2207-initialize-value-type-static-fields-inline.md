---
title: "CA2207: Initialize value type static fields inline | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "InitializeValueTypeStaticFieldsInline"
  - "CA2207"
helpviewer_keywords:
  - "CA2207"
  - "InitializeValueTypeStaticFieldsInline"
ms.assetid: d1ea9d8b-ecc2-46ca-86e2-c41dd0e76658
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2207: Initialize value type static fields inline
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|InitializeValueTypeStaticFieldsInline|
|CheckId|CA2207|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A value-type declares an explicit static constructor.

## Rule Description
 When a value-type is declared, it undergoes a default initialization where all value-type fields are set to zero and all reference-type fields are set to `null` (`Nothing` in Visual Basic). An explicit static constructor is only guaranteed to run before an instance constructor or static member of the type is called. Therefore, if the type is created without calling an instance constructor, the static constructor is not guaranteed to run.

 If all static data is initialized inline and no explicit static constructor is declared, the C# and Visual Basic compilers add the `beforefieldinit` flag to the MSIL class definition. The compilers also add a private static constructor that contains the static initialization code. This private static constructor is guaranteed to run before any static fields of the type are accessed.

## How to Fix Violations
 To fix a violation of this rule initialize all static data when it is declared and remove the static constructor.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Related Rules
 [CA1810: Initialize reference type static fields inline](../code-quality/ca1810-initialize-reference-type-static-fields-inline.md)
