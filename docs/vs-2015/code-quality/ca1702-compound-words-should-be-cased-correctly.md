---
title: "CA1702: Compound words should be cased correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1702"
  - "CompoundWordsShouldBeCasedCorrectly"
helpviewer_keywords:
  - "CA1702"
  - "CompoundWordsShouldBeCasedCorrectly"
ms.assetid: 05481245-7ad8-48c3-a456-3aa44b6160a6
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1702: Compound words should be cased correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [CA1702: Compound words should be cased correctly](https://docs.microsoft.com/visualstudio/code-quality/ca1702-compound-words-should-be-cased-correctly).

|||
|-|-|
|TypeName|CompoundWordsShouldBeCasedCorrectly|
|CheckId|CA1702|
|Category|Microsoft.Naming|
|Breaking Change|Breaking- when fired on assemblies.<br /><br /> Non-breaking - when fired on type parameters.|

## Cause
 The name of an identifier contains multiple words and at least one of the words appears to be a compound word that is not cased correctly.

## Rule Description
 The name of the identifier is split into words that are based on the casing. Each contiguous two-word combination is checked by the Microsoft spelling checker library. If it is recognized, the identifier produces a violation of the rule. Examples of compound words that cause a violation are "CheckSum" and "MultiPart", which should be cased as "Checksum" and "Multipart", respectively. Due to previous common usage, several exceptions are built into the rule, and several single words are flagged, such as "Toolbar" and "Filename", that should be cased as two distinct words (in this case, "ToolBar" and "FileName").

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 Change the name so that it is cased correctly.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if both parts of the compound word are recognized by the spelling dictionary and the intent is to use two words.

## Related Rules
 [CA1701: Resource string compound words should be cased correctly](../code-quality/ca1701-resource-string-compound-words-should-be-cased-correctly.md)

 [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)

 [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)

## See Also
 [Naming Guidelines](https://msdn.microsoft.com/library/fc076d66-9b5f-42d3-aa65-61d970c794a3)
 [Capitalization Conventions](https://msdn.microsoft.com/library/4c4ea526-9203-486f-b72d-29d61c5b3c6d)
