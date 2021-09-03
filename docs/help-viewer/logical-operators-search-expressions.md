---
title: Logical operators in search expressions (Help Viewer)
description: Understand how to use logical operators and advanced search operators to refine search expressions in Microsoft Help Viewer.
ms.custom: SEO-VS-2020
ms.date: 11/02/2017
ms.topic: reference
helpviewer_keywords:
  - "Help Viewer, logical operators in search"
  - "logical operators in search [Help Viewer]"
ms.assetid: 0c38ae7d-3e20-4d47-a020-9677cd285916
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-help-viewer
ms.workload:
  - "multiple"
---
# Logical and advanced operators in search expressions

You can use logical operators and advanced search operators to refine your search of the Help content in **Help Viewer**.

## Logical operators

Logical operators specify how multiple search terms should be combined in a search query. The following table shows the logical operators AND, OR, NOT and NEAR.

|To search for|Use|Example|Result|
|-------------------|---------|-------------|------------|
|Both terms in the same article|AND|dib AND palette|Topics that contain both "dib" and "palette".|
|Either term in an article|OR|raster OR vector|Topics that contain either "raster" or "vector".|
|First term without the second term in the same article|NOT|"operating system" NOT DOS|Topics that contain "operating system" but not "DOS".|
|Both terms, close together in an article|NEAR|user NEAR kernel|Topics that contain "user" within close proximity of "kernel".|

> [!IMPORTANT]
> You must enter logical operators in all capital letters for the search engine to recognize them.

## Advanced operators

Advanced search operators refine your search for content by specifying where in an article to look for the search term. The following table describes the four available advanced search operators.

|To search for|Use|Example|Result|
|-------------------|---------|-------------|------------|
|A term in the title of the article|`title:`|`title:binaryreader`|Topics that contain "binaryreader" in their titles.|
|A term in a code example|`code:`|`code:readdouble`|Topics that contain "readdouble" in a code example.|
|A term in an example of a specific programming language|`code:vb:`|`code:vb:string`|Topics that contain "string" in a Visual Basic code example.|
|An article that is associated with a specific index keyword|`keyword:`|`keyword:readbyte`|Topics that are associated with the "readbyte" index keyword.|

> [!IMPORTANT]
> You must enter advanced search operators with a final colon and no intervening space before the colon for the search engine to recognize them.

### Programming languages for code examples

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

## See also

- [How to: Search for topics](../help-viewer/find-topics.md)
- [Microsoft Help Viewer](../help-viewer/overview.md)
