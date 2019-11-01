---
title: "Full-Text Search Tips | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "hv_search"
helpviewer_keywords:
  - "Help Viewer 2.0, full-text search tips"
  - "full-text search tips [Help Viewer 2.0]"
ms.assetid: bcaad23d-2ca7-4bec-8b54-b884bc34e70b
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Full-Text Search Tips
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

One of the more useful methods of locating information in Help is by performing a full-text search. To refine and customize your results, you must understand how syntax affects your query. This topic provides tips, procedures, and detailed syntax information to help you better craft your queries.

## Full-Text Search Tips
 You can create more targeted searches that return only those topics that interest you if you understand how Help interprets the formatting that you use in queries. These formats include special characters, reserved words, and filters.

### General Guidelines
 The following table includes some basic rules and guidelines for developing search queries in Help.

|Syntax|Description|
|------------|-----------------|
|Case sensitivity|Searches aren't case-sensitive. Develop your search criteria using uppercase or lowercase characters. For example, "OLE" and "ole" return the same results.|
|Character combinations|You can't search only for individual letters (a–z) or numbers (0–9). If you try to search for certain reserved words, such as ”and”, ”from”, and ”with”, they will be ignored. For more information, see "Words Ignored in Searches (Stop Words)" later in this topic.|
|Evaluation order|Search queries are evaluated from left to right.|

### Search Syntax
 If you specify a search string that includes multiple words, such as "word1 word2," that string is equivalent to typing "word1 AND word2", which returns only topics that contain all of the individual words in the search string.

> [!IMPORTANT]
> 1. Phrase searches are not supported. If you specify more than one word in a search string, returned topics will contain all of the words that you specified but not necessarily the exact phrase that you specified.
>    2. Use logical operators to specify the relationship between words in your search phrase. You can include logical operators, such as AND, OR, NOT, and NEAR, to further refine your search. For example, if you search for "declaring NEAR union", search results will include topics that contain the words "declaring" and "union" no more than a few words apart from each other. For more information, see [Logical Operators in Search Expressions](../ide/logical-operators-in-search-expressions.md).

### Filters
 You can further restrict search results by using advanced search operators. Help includes three categories that you can use to filter results of a full-text search: Title, Code, and Keyword. For more information, see [Advanced Search Operators in Search Expressions](../ide/advanced-search-operators-in-search-expressions.md).

### Ranking of Search Results
 The search algorithm applies certain criteria to help rank search results higher or lower in the results list. In general:

1. Content that includes search words in the title is ranked higher than content that doesn't.

2. Content that includes search words in close proximity is ranked higher than content that doesn't.

3. Content that contains a higher density of the search words is ranked higher than content that has a lower density of the search words.

### Words Ignored in Searches (Stop Words)
 Commonly occurring words or numbers, which are sometimes called stop words, are automatically ignored during a full-text search. For example, if you search for the phrase "pass through", search results will display topics that contain the word "pass" but not "through".

## See Also
 [Locate Information](../ide/locate-information.md)
 [Logical Operators in Search Expressions](../ide/logical-operators-in-search-expressions.md)
