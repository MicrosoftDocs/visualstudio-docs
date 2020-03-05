---
title: "CA1701: Resource string compound words should be cased correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "ResourceStringCompoundWordsShouldBeCasedCorrectly"
  - "CA1701"
helpviewer_keywords:
  - "CA1701"
  - "ResourceStringCompoundWordsShouldBeCasedCorrectly"
ms.assetid: 4ddbe09f-24b8-4c47-9373-a06f4487ca0d
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1701: Resource string compound words should be cased correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|ResourceStringCompoundWordsShouldBeCasedCorrectly|
|CheckId|CA1701|
|Category|Microsoft.Naming|
|Breaking Change|Non-breaking|

## Cause
 A resource string contains a compound word that does not appear to be cased correctly.

## Rule Description
 Each word in the resource string is split into tokens that are based on the casing. Each contiguous two-token combination is checked by the Microsoft spelling checker library. If recognized, the word produces a violation of the rule. Examples of compound words that cause a violation are "CheckSum" and "MultiPart", which should be cased as "Checksum" and "Multipart", respectively. Due to previous common usage, several exceptions are built into the rule, and several single words are flagged, such as "Toolbar" and "Filename", that should be cased as two distinct words. In this example, "ToolBar" and "FileName" would be flagged.

 Naming conventions provide a common look for libraries that target the common language runtime. This reduces the learning curve that is required for new software libraries, and increases customer confidence that the library was developed by someone who has expertise in developing managed code.

## How to Fix Violations
 Change the word so that it is cased correctly.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if both parts of the compound word are recognized by the spelling dictionary and the intent is to use two words.

 You can also add compound words to a custom dictionary for the spelling checker. Words in the custom dictionary do not cause violations. For more information, see [How to: Customize the Code Analysis Dictionary](../code-quality/how-to-customize-the-code-analysis-dictionary.md).

## Related Rules
 [CA1702: Compound words should be cased correctly](../code-quality/ca1702-compound-words-should-be-cased-correctly.md)

 [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)

 [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)

## See Also
 [Capitalization Conventions](https://msdn.microsoft.com/library/4c4ea526-9203-486f-b72d-29d61c5b3c6d)
 [Naming Guidelines](https://msdn.microsoft.com/library/fc076d66-9b5f-42d3-aa65-61d970c794a3)
