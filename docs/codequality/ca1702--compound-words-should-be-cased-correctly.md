---
title: "CA1702: Compound words should be cased correctly"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CA1702"
  - "CompoundWordsShouldBeCasedCorrectly"
helpviewer_keywords: 
  - "CA1702"
  - "CompoundWordsShouldBeCasedCorrectly"
ms.assetid: 05481245-7ad8-48c3-a456-3aa44b6160a6
caps.latest.revision: 20
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA1702: Compound words should be cased correctly
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
 [CA1701: Resource string compound words should be cased correctly](../codequality/ca1701--resource-string-compound-words-should-be-cased-correctly.md)  
  
 [CA1709: Identifiers should be cased correctly](../codequality/ca1709--identifiers-should-be-cased-correctly.md)  
  
 [CA1708: Identifiers should differ by more than case](../codequality/ca1708--identifiers-should-differ-by-more-than-case.md)  
  
## See Also  
 [Naming Guidelines](../Topic/Naming%20Guidelines.md)   
 [Capitalization Conventions](../Topic/Capitalization%20Conventions.md)