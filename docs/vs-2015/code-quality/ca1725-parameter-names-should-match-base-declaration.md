---
title: "CA1725: Parameter names should match base declaration | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ParameterNamesShouldMatchBaseDeclaration"
  - "CA1725"
helpviewer_keywords:
  - "CA1725"
  - "ParameterNamesShouldMatchBaseDeclaration"
ms.assetid: 9b657ab0-fe81-4f4c-9481-ba746988c922
caps.latest.revision: 13
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1725: Parameter names should match base declaration
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ParameterNamesShouldMatchBaseDeclaration|
|CheckId|CA1725|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 The name of a parameter in an externally visible method override does not match the name of the parameter in the base declaration of the method, or the name of the parameter in the interface declaration of the method.

## Rule Description
 Consistent naming of parameters in an override hierarchy increases the usability of the method overrides. A parameter name in a derived method that differs from the name in the base declaration can cause confusion about whether the method is an override of the base method or a new overload of the method.

## How to Fix Violations
 To fix a violation of this rule, rename the parameter to match the base declaration. The fix is a breaking change for COM visible methods.

## When to Suppress Warnings
 Do not suppress a warning from this rule except for COM visible methods in libraries that have previously shipped.
