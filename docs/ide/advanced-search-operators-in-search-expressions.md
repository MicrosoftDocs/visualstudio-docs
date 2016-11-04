---
title: "Advanced Search Operators in Search Expressions | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Help Viewer 2.0, searching for keywords"
  - "Help Viewer 2.0, searching code"
  - "Help Viewer 2.0, searching code by programming language"
  - "Help Viewer 2.0, searching titles"
  - "searching code [Help Viewer 2.0]"
  - "searching titles [Help Viewer 2.0]"
ms.assetid: 0cdc1746-8481-45ec-9c53-d0d89cdcbd5e
caps.latest.revision: 9
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Advanced Search Operators in Search Expressions
By using advanced search operators, you can refine your search for content by creating more complicated search expressions from simpler ones. As the following table shows, these operators restrict the context in which a query runs.  
  
> [!WARNING]
>  You must enter advanced search operators with a final colon and no intervening space before the colon for the search engine to recognize them.  
  
|To search for|Use|Example|Result|  
|-------------------|---------|-------------|------------|  
|A term in the title of the topic|title:|title:binaryreader|Topics that contain “binaryreader” in their titles.|  
|A term in a code example|code:|code:readdouble|Topics that contain "readdouble" in a code example.|  
|A term in an example of a specific programming language|code:vb:|code:vb:string|Topics that contain “string” in a Visual Basic example.|  
|A topic that is associated with a specific index keyword|keyword:|keyword:readbyte|Topics that are associated with the “readbyte” index keyword.|  
  
 You can use the code: operator to find content about any of several programming languages, but it returns results only for content that is marked up with a specific programming language. The following table lists the programming languages that this operator supports:  
  
|Programming Language|Use|  
|--------------------------|---------|  
|Visual Basic|code:vb<br /><br /> or<br /><br /> code:visualbasic|  
|C#|code:c#<br /><br /> or<br /><br /> code:csharp|  
|C++|code:cpp<br /><br /> or<br /><br /> code:c++<br /><br /> or<br /><br /> code:cplusplus|  
|F#|code:f#<br /><br /> or<br /><br /> code:fsharp|  
|JavaScript|code:javascript<br /><br /> or<br /><br /> code:js|  
|XAML|code:xaml|  
  
## See Also  
 [Logical Operators in Search Expressions](../ide/logical-operators-in-search-expressions.md)   
 [Full-Text Search Tips](../ide/full-text-search-tips.md)