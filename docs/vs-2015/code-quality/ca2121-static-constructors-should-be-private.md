---
title: "CA2121: Static constructors should be private | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2121"
  - "StaticConstructorsShouldBePrivate"
helpviewer_keywords:
  - "CA2121"
  - "StaticConstructorsShouldBePrivate"
ms.assetid: ee93c620-8fc1-4e47-866c-d389c3ca9f2e
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2121: Static constructors should be private
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|Item|Value|
|-|-|
|TypeName|StaticConstructorsShouldBePrivate|
|CheckId|CA2121|
|Category|Microsoft.Security|
|Breaking Change|Breaking|

## Cause
 A type has a static constructor that is not private.

## Rule Description
 A static constructor, also known as a class constructor, is used to initialize a type. The system calls the static constructor before the first instance of the type is created or any static members are referenced. The user has no control over when the static constructor is called. If a static constructor is not private, it can be called by code other than the system. Depending on the operations that are performed in the constructor, this can cause unexpected behavior.

 This rule is enforced by the C# and Visual Basic .NET compilers.

## How to Fix Violations
 Violations are typically caused by one of the following actions:

- You defined a static constructor for your type and did not make it private.

- The programming language compiler added a default static constructor to your type and did not make it private.

  To fix the first kind of violation, make your static constructor private. To fix the second kind, add a private static constructor to your type.

## When to Suppress Warnings
 Do not suppress these violations. If your software design requires an explicit call to a static constructor, it is likely that the design contains serious flaws and should be reviewed.
