---
title: "CA1726: Use preferred terms | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "UsePreferredTerms"
  - "CA1726"
helpviewer_keywords:
  - "UsePreferredTerms"
ms.assetid: 642b2acd-3a33-4d1f-b0a7-67073ae73be2
caps.latest.revision: 24
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1726: Use preferred terms
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1726: Use preferred terms](https://docs.microsoft.com/visualstudio/code-quality/ca1726-use-preferred-terms).

|||
|-|-|
|TypeName|UsePreferredTerms|
|CheckId|CA1726|
|Category|Microsoft.Naming|
|Breaking Change|Breaking - when fired on assemblies<br /><br /> Non-breaking - when fired on type parameters|

## Cause
 The name of an externally visible identifier includes a term for which an alternative, preferred term exists. Alternatively, the name includes the term Flag or Flags.

## Rule Description
 This rule parses an identifier into tokens. Each single token and each contiguous dual token combination is compared to terms that are built into the rule and in the Deprecated section of any custom dictionaries. The following table shows the terms that are built into the rule and their preferred alternatives.

|Obsolete term|Preferred term|
|-------------------|--------------------|
|`Arent`|`AreNot`|
|`Cancelled`|`Canceled`|
|`Cant`|`Cannot`|
|`ComPlus`|`EnterpriseServices`|
|`Couldnt`|`CouldNot`|
|`Didnt`|`DidNot`|
|`Doesnt`|`DoesNot`|
|`Dont`|`DoNot`|
|`Flag` or `Flags`|There is no replacement term. Do not use.|
|`Hadnt`|`HadNot`|
|`Hasnt`|`HasNot`|
|`Havent`|`HaveNot`|
|`Indices`|`Indexes`|
|`Isnt`|`IsNot`|
|`LogIn`|`LogOn`|
|`LogOut`|`LogOff`|
|`Shouldnt`|`ShouldNot`|
|`SignOn`|`SignIn`|
|`SignOff`|`SignOut`|
|`Wasnt`|`WasNot`|
|`Werent`|`WereNot`|
|`Wont`|`WillNot`|
|`Wouldnt`|`WouldNot`|
|`Writeable`|`Writable`|

## How to Fix Violations
 To fix a violation of this rule, replace the term with the preferred alternative term.

## When to Suppress Warnings
 Suppress a warning from this rule only if the name of the identifier is intentional and relates specifically to the original term instead of the preferred term.

## Related Rules
 [Naming Warnings](../code-quality/naming-warnings.md)
