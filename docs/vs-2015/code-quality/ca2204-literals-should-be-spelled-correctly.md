---
title: "CA2204: Literals should be spelled correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "Literals should be spelled correctly"
  - "CA2204"
  - "LiteralsShouldBeSpelledCorrectly"
helpviewer_keywords:
  - "CA2204"
ms.assetid: b0bbcbb6-c92d-4c14-8ef7-9c8b38c791a6
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2204: Literals should be spelled correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|LiteralsShouldBeSpelledCorrectly|
|CheckId|CA2204|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 A method passes a literal string to that is used in a parameter or property that requires a localized string and the literal string contains one or more words that are not recognized by the Microsoft spelling checker library.

## Rule Description
 This rule checks a literal string that is passed as a value to a parameter or property when one or more of the following cases is true:

- The <xref:System.ComponentModel.LocalizableAttribute> attribute of the parameter or property is set to true.

- The parameter or property name contains "Text", "Message", or "Caption".

- The name of the string parameter that is passed to a Console.Write or Console.WriteLine method is either "value" or "format".

  This rule parses the literal string into words, tokenizing compound words, and checks the spelling of each word/token. For information about the parsing algorithm, see [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704-identifiers-should-be-spelled-correctly.md).

  By default, the English (en) version of the spelling checker is used.

## How to Fix Violations
 To fix a violation of this rule, correct the spelling of the word or add the word to a custom dictionary. For information about how to use custom dictionaries, see [How to: Customize the Code Analysis Dictionary](../code-quality/how-to-customize-the-code-analysis-dictionary.md).

## When to Suppress Warnings
 Do not suppress a warning from this rule. Correctly spelled words reduce the learning curve required for new software libraries.

## Related Rules
 [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704-identifiers-should-be-spelled-correctly.md)

 [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703-resource-strings-should-be-spelled-correctly.md)
