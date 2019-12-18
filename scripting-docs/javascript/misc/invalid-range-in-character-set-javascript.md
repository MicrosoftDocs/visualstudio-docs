---
title: "Invalid range in character set (JavaScript) | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5021"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 971e9d5a-f88a-47a8-af94-f3c7c4aed5ab
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Invalid range in character set (JavaScript)
You attempted to create a regular expression with an invalid character set range. Character sets must range from single characters only, such as a-z or 0-9; you cannot include character classes such as \w in a character set. The first character in the range must also come before the second character in the range. For example:  
  
```JavaScript  
var good = /[a-z]/;     // A valid character range - a comes before z.  
var notGood = /[z-a]/;  // An invalid character range - z does not come before a.  
```  
  
### To correct this error  
  
- Use only single characters to compose your regular expression character set, and make sure they are in the correct order.  
  
## See also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](https://msdn.microsoft.com/library/1400241x)