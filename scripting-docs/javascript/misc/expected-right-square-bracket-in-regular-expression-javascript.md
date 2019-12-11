---
title: "Expected ']' in regular expression (JavaScript) | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5019"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 1ca2079a-44dd-479f-a1e3-e04a14d0739e
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected ']' in regular expression (JavaScript)
You attempted to create a character class for a regular expression match, but did not include the right bracket. Individual literal character combinations can be assembled into character classes by placing them within brackets. A character class matches any one character it contains. For example, /[abc]/ matches any one of the letters "a", "b", or "c".  
  
### To correct this error  
  
- Add the right bracket to the regular expression.  
  
    > [!NOTE]
    > If you want to match a single bracket, escape it with a backslash - \\[ - so it is not interpreted as a special character by [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)].  
  
## See also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](https://msdn.microsoft.com/library/1400241x)