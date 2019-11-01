---
title: "CA1704: Identifiers should be spelled correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA1704"
  - "IdentifiersShouldBeSpelledCorrectly"
helpviewer_keywords:
  - "CA1704"
  - "IdentifiersShouldBeSpelledCorrectly"
ms.assetid: f2c7a44d-1690-44ca-9cd0-681b04b12b2a
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1704: Identifiers should be spelled correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|IdentifiersShouldBeSpelledCorrectly|
|CheckId|CA1704|
|Category|Microsoft.Naming|
|Breaking Change|Breaking|

## Cause
 The name of an identifier contains one or more words that are not recognized by the Microsoft spelling checker library. This rule does not check constructors or special-named members such as get and set property accessors.

## Rule Description
 This rule parses the identifier into tokens and checks the spelling of each token. The parsing algorithm performs the following transformations:

- Uppercase letters start a new token. For example, MyNameIsJoe tokenizes to "My", "Name", "Is", "Joe".

- For multiple uppercase letters, the last uppercase letter starts a new token. For example, GUIEditor tokenizes to "GUI", "Editor".

- Leading and trailing apostrophes are removed. For example, 'sender' tokenizes to "sender".

- Underscores signify the end of a token and are removed. For example, Hello_world tokenizes to "Hello", "world".

- Embedded ampersands are removed. For example, for&mat tokenizes to "format".

  By default, the English (en) version of the spelling checker is used. No other language dictionaries are currently available.

## How to Fix Violations
 To fix a violation of this rule, correct the spelling of the word or add the word to a custom dictionary that is named CustomDictionary.xml. Place the dictionary in the installation directory of the tool, the project directory, or in the directory that is associated with the tool under the profile of the user (%USERPROFILE%\Application Data\\...). To learn how to add the custom dictionary to a project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], see [How to: Customize the Code Analysis Dictionary](../code-quality/how-to-customize-the-code-analysis-dictionary.md)

- Add words that should not cause a violation under the Dictionary/Words/Recognized path.

- Add words that should cause a violation under the Dictionary/Words/Unrecognized path.

- Add words that should be flagged as obsolete under the Dictionary/Words/Deprecated path. See the related rule topic [CA1726: Use preferred terms](../code-quality/ca1726-use-preferred-terms.md)for more information.

- Add exceptions to the acronym casing rules to the Dictionary/Acronyms/CasingExceptions path.

  The following is an example of the structure of a custom dictionary file.

```
<Dictionary>
   <Words>
      <Unrecognized>
         <Word>cb</Word>
      </Unrecognized>
      <Recognized>
         <Word>stylesheet</Word>
         <Word>GotDotNet</Word>
      </Recognized>
      <Deprecated>
         <Term PreferredAlternate="EnterpriseServices">ComPlus</Term>
      </Deprecated>
   </Words>
   <Acronyms>
      <CasingExceptions>
         <Acronym>CJK</Acronym>
         <Acronym>Pi</Acronym>
      </CasingExceptions>
   </Acronyms>
</Dictionary>
```

## When to Suppress Warnings
 Suppress a warning from this rule only if the word is intentionally misspelled and the word applies to a limited set of the library. Correctly spelled words reduce the learning curve that is required for new software libraries.

## Related Rules
 [CA2204: Literals should be spelled correctly](../code-quality/ca2204-literals-should-be-spelled-correctly.md)

 [CA1703: Resource strings should be spelled correctly](../code-quality/ca1703-resource-strings-should-be-spelled-correctly.md)

 [CA1709: Identifiers should be cased correctly](../code-quality/ca1709-identifiers-should-be-cased-correctly.md)

 [CA1708: Identifiers should differ by more than case](../code-quality/ca1708-identifiers-should-differ-by-more-than-case.md)

 [CA1707: Identifiers should not contain underscores](../code-quality/ca1707-identifiers-should-not-contain-underscores.md)

 [CA1726: Use preferred terms](../code-quality/ca1726-use-preferred-terms.md)

## See Also
 [How to: Customize the Code Analysis Dictionary](../code-quality/how-to-customize-the-code-analysis-dictionary.md)
