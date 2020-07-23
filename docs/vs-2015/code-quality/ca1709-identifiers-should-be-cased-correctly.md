---
title: "CA1709: Identifiers should be cased correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "IdentifiersShouldBeCasedCorrectly"
  - "CA1709"
helpviewer_keywords:
  - "CA1709"
  - "IdentifiersShouldBeCasedCorrectly"
ms.assetid: f633d1a7-4ca4-40ae-b207-ec571c5fb083
caps.latest.revision: 30
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1709: Identifiers should be cased correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1709: Identifiers should be cased correctly](/visualstudio/code-quality/ca1709-identifiers-should-be-cased-correctly).

|Item|Value|
|-|-|
|TypeName|IdentifiersShouldBeCasedCorrectly|
|CheckId|CA1709|
|Category|Microsoft.Naming|
|Breaking Change|Breaking - when raised on assemblies, namespaces, types, members and parameters.<br /><br /> Non-breaking - when fired on generic type parameters.|

## Cause
 The name of an identifier is not cased correctly.

 \- or -

 The name of an identifier contains a two-letter acronym and the second letter is lowercase.

 \- or -

 The name of an identifier contains an acronym of three or more uppercase letters.

## Rule Description
 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

 By convention, parameter names use camel casing; namespace, type, and member names use Pascal casing. In a camel-cased name, the first letter is lowercase, and the first letter of any remaining words in the name is in uppercase. Examples of camel-cased names are "packetSniffer", "ioFile", and "fatalErrorCode". In a Pascal-cased name, the first letter is uppercase, and the first letter of any remaining words in the name is in uppercase. Examples of Pascal-cased names are "PacketSniffer", "IOFile", and "FatalErrorCode".

 This rule splits the name into words based on the casing and checks any two-letter words against a list of common two-letter words, such as "In" or "My". If a match is not found, the word is assumed to be an acronym. In addition, this rule assumes it has found an acronym when the name contains either four uppercase letters in a row or three uppercase letters in a row at the end of the name.

 By convention, two-letter acronyms use all uppercase letters, and acronyms of three or more characters use Pascal casing. The following examples use this naming convention: 'DB', 'CR', 'Cpa', and 'Ecma'. The following examples violate the convention: 'Io', 'XML', and 'DoD', and for nonparameter names, 'xp' and 'cpl'.

 'ID' is special-cased to cause a violation of this rule. 'Id' is not an acronym but is an abbreviation for 'identification'.

## How to Fix Violations
 Change the name so that it is cased correctly.

## When to Suppress Warnings
 It is safe to suppress this warning if you have your own naming conventions, or if the identifier represents a proper name, for example, the name of a company or a technology.

 You can also add specific terms, abbreviations, and acronyms that to a code analysis custom dictionary. Terms specified in the custom dictionary will not cause violations of this rule. For more information, see [How to: Customize the Code Analysis Dictionary](../code-quality/how-to-customize-the-code-analysis-dictionary.md)

## Related Rules
 [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)
