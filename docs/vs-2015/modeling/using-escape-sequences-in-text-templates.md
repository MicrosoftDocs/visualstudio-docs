---
title: "Using Escape Sequences in Text Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, escape sequences"
ms.assetid: 36fff542-2f42-460f-a2d5-03fc76817f3b
caps.latest.revision: 31
author: jillre
ms.author: jillfra
manager: jillfra
---
# Using Escape Sequences in Text Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use escape sequences in text templates to generate text template tags and (in C# code only) to escape control characters and quotation marks.

 To print open and close tags for a standard code block to the output file, escape the tags as follows:

```
\<# ... \#>
```

 You can do the same with other text template directive and code block tags.

 If a text block includes strings used to escape text template tags, then you may use the following escape sequences:

- If a text template tag is preceded by an even number of escape (\\) characters the template parser will include half of the escape characters and include the sequence as a text template tag. For example, if there are four escape characters in the text template, there will be two "\\" characters in the generated file.

- If the text template tag is preceded by an odd number of escape (\\) characters, the template parser will include half of the "\\" characters plus the tag itself (\<# or #>). The tag is not considered to be a text template tag.

- If an escape (\\) character appears anywhere else in any sequence other than where it escapes a control character or a quote (in C# only), the character will be output directly.

## See Also
 [How to: Generate Templates from Templates By Using Escape Sequences](../modeling/how-to-generate-templates-from-templates-by-using-escape-sequences.md)
