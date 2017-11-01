---
title: "Advanced Search Operators in Search Expressions | Microsoft Docs"
ms.custom: ""
ms.date: "06/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-help-viewer"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Help Viewer, searching for keywords"
  - "Help Viewer, searching code"
  - "Help Viewer, searching code by programming language"
  - "Help Viewer, searching titles"
  - "searching code [Help Viewer]"
  - "searching titles [Help Viewer]"
ms.assetid: 0cdc1746-8481-45ec-9c53-d0d89cdcbd5e
caps.latest.revision: 9
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# Advanced search operators in search expressions
By using advanced search operators in the Help Viewer, you can refine your search for content by specifying where in a topic to look for the search term. The following table describes the four available advanced search operators.

|To search for|Use|Example|Result|  
|-------------------|---------|-------------|------------|  
|A term in the title of the topic|title:|title:binaryreader|Topics that contain "binaryreader" in their titles.|  
|A term in a code example|code:|code:readdouble|Topics that contain "readdouble" in a code example.|  
|A term in an example of a specific programming language|code:vb:|code:vb:string|Topics that contain "string" in a Visual Basic code example.|  
|A topic that is associated with a specific index keyword|keyword:|keyword:readbyte|Topics that are associated with the "readbyte" index keyword.|  

> [!WARNING]
>  You must enter advanced search operators with a final colon and no intervening space before the colon for the search engine to recognize them.    

## Programming languages for code examples
You can use the code: operator to find content about any of several programming languages, but it returns results only for content that is marked up with a programming language label. To return examples for a specific programming languge, use one of the following programming language values:  

|Programming Language|Search operator syntax|  
|--------------------|---------|  
|Visual Basic|code:vb<br/>code:visualbasic|  
|C#|code:c#<br/>code:csharp|  
|C++|code:cpp<br/>code:c++<br/>code:cplusplus|  
|F#|code:f#<br/>code:fsharp|  
|JavaScript|code:javascript<br/>code:js|  
|XAML|code:xaml|  

## See also
[Logical Operators in Search Expressions](../ide/logical-operators-in-search-expressions.md)   
[Full-Text Search Tips](../ide/full-text-search-tips.md)
