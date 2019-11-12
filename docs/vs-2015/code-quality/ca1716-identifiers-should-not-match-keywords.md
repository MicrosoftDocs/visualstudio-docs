---
title: "CA1716: Identifiers should not match keywords | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldNotMatchKeywords"
  - "CA1716"
helpviewer_keywords:
  - "IdentifiersShouldNotMatchKeywords"
  - "CA1716"
ms.assetid: 900cc8a1-1089-4069-a4ce-10b109ac4fab
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1716: Identifiers should not match keywords
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|IdentifiersShouldNotMatchKeywords|
|CheckId|CA1716|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 A name of a namespace, a type, or a viritual or interface member matches a reserved keyword in a programming language.

## Rule Description
 Identifiers for namespaces, types, and virtual and interface members should not match keywords that are defined by languages that target the common language runtime. Depending on the language that is used and the keyword, compiler errors and ambiguities can make the library difficult to use.

 This rule checks against keywords in the following languages:

- Visual Basic

- C#

- C++/CLI

  Case-insensitive comparison is used for [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] keywords, and case-sensitive comparison is used for the other languages.

## How to Fix Violations
 Select a name that does not appear in the list of keywords.

## When to Suppress Warnings
 You can suppress a warning from this rule if you are convinced that the identifier will not confuse users of the API, and that  the library is usable in all available languages in the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)].
