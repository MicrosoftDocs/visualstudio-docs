---
title: Find articles in the Help Viewer
description: Learn how to search for articles in the Microsoft Help Viewer, use the index, and filter the table of contents. Customize searches by using wildcard expressions, logical operators, and advanced search operators.
ms.date: 07/10/2024
ms.topic: how-to
author: jasonchlus
ms.author: jasonchlus
manager: mijacobs
ms.subservice: help-viewer
---
# Find articles in the Help Viewer

You use the table of contents (TOC), index, and search to find articles in the Help Viewer. This article describes the features of the Help Viewer that can help you find articles more quickly.

For historical reasons, articles in Help Viewer are referred to as *Help topics* or just *topics*.

## Filter the Table of Contents

You can filter the TOC to narrow the scope of topics that appear in the **Contents** tab. Titles appear in the list only if they contain the root of the term that you specify. For example, if you specify "troubleshooting" as a filter, only titles that contain "troubleshoot" or "troubleshooting" appear. Nodes whose titles don't contain the term are collapsed to a single node with an ellipsis (**...**).

1. Choose the **Contents** tab.

2. In the **Filter Contents** text box, enter a term.

> [!NOTE]
> If the filter takes a long time to run, you might display results more quickly by using the `title:` advanced search operator.

### Synchronize a topic with the TOC

If you have opened a topic using the index or full-text search features, you can determine where this topic is in the TOC by synchronizing the TOC with the topic window.

1. View a topic.

2. Click the **Show Topic in Contents** button on the toolbar, or press **Ctrl**+**S**.

     The **Contents** tab opens and displays the topic's location in the TOC.

## Find topics by using the Help Viewer index

The index contains a list of keywords that are associated with topics in the installed content. Each topic might have more than one keyword associated with it, and each keyword might be associated with more than one topic. Use this index in the same way as you would use an index in a book.

### To find a topic by using the index

On the **Index** tab, perform either of the following tasks:

- Specify the keyword to search for in the text box. For example, specify "update" to find topics with keywords such as "update," "updated," and "updating."

    By choosing the filter button near the top of the tab, you can display either all entries that contain the text that you specify or only those entries that start with the text that you specify.

    > [!NOTE]
    > When the filter button appears on a darker background with a border, entries must *contain* the text that you specify. If the background and border don't appear, entries must *start with* the text that you specify.

- Scroll through the index, and choose a keyword.

    If the keyword that you specify is associated with only one topic, it appears. Otherwise, a list of all topics that are associated with that keyword appears.

## Use the Search feature to find articles

You can use the full-text search feature of Microsoft Help Viewer to locate all topics that contain a particular word. You can also refine and customize your search by using wildcard expressions, logical operators, and advanced search operators.

## To perform a full-text search

1. Use one of these methods to open the Help Viewer **Search** tab:

   - In the **Help Viewer** window, select the **Search** tab.
   - On the keyboard, select **Ctrl**+**E**.

1. In the search box, enter the word that you want to find.

1. In the search query, specify any logical or advanced search operators that you'd like to apply to the search. To search all available help, don't use operators.

    > [!NOTE]
    > In the **Viewer Options** dialog box, you can specify additional preferences such as the maximum number of search results to display at a time and whether to include English content if your primary locale isn't English.

1. Select the **Enter** key.

     A search returns a maximum of 200 hits, by default, and displays them in the search results area. Version information for each result may appear, depending on the content.

1. To view a topic, select its title from the results list.

## Full-text search tips

You can create more targeted searches that return only those topics that interest you, if you understand how syntax affects your query. The syntax includes special characters, reserved words, and filters. This section provides tips, procedures, and detailed syntax information to help you better craft your queries.

### General guidelines

The following table includes some basic rules and guidelines for developing search queries in help.

|Syntax|Description|
|------------|-----------------|
|Case sensitivity|Searches aren't case-sensitive. Develop your search criteria by using uppercase or lowercase characters. For example, "OLE" and "ole" return the same results.|
|Character combinations|You can't search only for individual letters (a-z) or numbers (0-9). If you try to search for certain reserved words, such as "and," "from," and "with," they're ignored. For more information, see [Words ignored in searches](#words-ignored-in-searches-stop-words) later in this article.|
|Evaluation order|Search queries are evaluated from left to right.|

### Search syntax

You might enter a search string that includes multiple words, such as "word1 word2." That string is equivalent to typing "word1 AND word2." Searches that use the AND operator return only topics that contain all the individual words in the search string.

> [!IMPORTANT]
> - Phrase searches are not supported. If you specify more than one word in a search string, returned topics contain all the words that you specified but not necessarily the exact phrase that you specified.
> - Use logical operators to specify the relationship between words in your search phrase. You can include logical operators, such as AND, OR, NOT, and NEAR, to further refine your search. For example, if you search for "declaring NEAR union", search results include topics that contain the words "declaring" and "union" no more than a few words apart from each other. For more information, see [Logical operators in search expressions](../help-viewer/logical-operators-search-expressions.md).

### Filters

You can further restrict search results by using advanced search operators. Help includes three categories that you can use to filter results of a full-text search: Title, Code, and Keyword.

### Ranking of search results

The search algorithm applies certain criteria to help rank search results higher or lower in the results list. In general:

- Content that includes search words in the title is ranked higher than content that doesn't.

- Content that includes search words in close proximity is ranked higher than content that doesn't.

- Content that contains a higher density of the search words is ranked higher than content that has a lower density of the search words.

### Words ignored in searches (stop words)

Commonly occurring words or numbers, which are sometimes called stop words, are automatically ignored during a full-text search. For example, if you search for the phrase "pass through," search results display topics that contain the word "pass" but not "through."

## Logical and advanced operators in search expressions

You can use logical operators and advanced search operators to refine your search of the Help content in **Help Viewer**.

### Logical operators

Logical operators specify how multiple search terms should be combined in a search query. The following table shows the logical operators AND, OR, NOT and NEAR.

|To search for|Use|Example|Result|
|-------------------|---------|-------------|------------|
|Both terms in the same article|AND|dib AND palette|Topics that contain both "dib" and "palette".|
|Either term in an article|OR|raster OR vector|Topics that contain either "raster" or "vector".|
|First term without the second term in the same article|NOT|"operating system" NOT DOS|Topics that contain "operating system" but not "DOS".|
|Both terms, close together in an article|NEAR|user NEAR kernel|Topics that contain "user" within close proximity of "kernel".|

> [!IMPORTANT]
> You must enter logical operators in all capital letters for the search engine to recognize them.

### Advanced operators

Advanced search operators refine your search for content by specifying where in an article to look for the search term. The following table describes the four available advanced search operators.

|To search for|Use|Example|Result|
|-------------------|---------|-------------|------------|
|A term in the title of the article|`title:`|`title:binaryreader`|Topics that contain "binaryreader" in their titles.|
|A term in a code example|`code:`|`code:readdouble`|Topics that contain "readdouble" in a code example.|
|A term in an example of a specific programming language|`code:vb:`|`code:vb:string`|Topics that contain "string" in a Visual Basic code example.|
|An article that is associated with a specific index keyword|`keyword:`|`keyword:readbyte`|Topics that are associated with the "readbyte" index keyword.|

> [!IMPORTANT]
> You must enter advanced search operators with a final colon and no intervening space before the colon for the search engine to recognize them.

#### Programming languages for code examples

You can use the `code:` operator to find content about any of several programming languages. To return examples for a specific programming language, use one of the following programming language values:

|Programming Language|Search operator syntax|
| - |---------|
|Visual Basic|`code:vb`<br/>`code:visualbasic`|
|C#|`code:c#`<br/>`code:csharp`|
|C++|`code:cpp`<br/>`code:c++`<br/>`code:cplusplus`|
|F#|`code:f#`<br/>`code:fsharp`|
|JavaScript|`code:javascript`<br/>`code:js`|
|XAML|`code:xaml`|

> [!NOTE]
> The `code:` operator only finds content that is marked up with a programming language label, as opposed to content that is generically marked up as code.

## Related content

- [Shortcut keys in the Help Viewer](shortcut-keys.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)
