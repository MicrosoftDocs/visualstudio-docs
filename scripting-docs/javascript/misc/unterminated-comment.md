---
title: "Unterminated comment | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1016"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: d4286315-814b-4966-b4c4-1ee19d796eff
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Unterminated comment
You began a multi-line comment block, but did not properly terminate it. Multi-line comments begin with a "/*" combination, and end with the reverse "\*/" combination. The following is an example:  
  
```JavaScript  
/* This is a comment  
This is another part of the same comment.*/  
```  
  
### To correct this error  
  
- Be sure to terminate multi-line comments with "*/".  
  
## See also  
 [Comment Statements](../../javascript/reference/comment-statements-javascript.md)