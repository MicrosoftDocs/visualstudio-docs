---
title: "Expected ')' in regular expression (JavaScript) | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5020"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 2087ba1d-9783-4d40-b609-e8542f579f7f
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected ')' in regular expression (JavaScript)
You attempted to create a regular expression capture, assertion, or group, but did not include the closing parenthesis. Parentheses have several purposes in regular expressions. Primarily, they are used to capture sub-expressions, to specify assertions, or to group patterns together so that the items can be treated as a single unit by *, +, ?, and so on.  
  
### To correct this error  
  
- Add the rightmost closing parentheses.  
  
    > [!NOTE]
    > If you want to match a single parenthesis, escape it with a backslash - \\( - so that it is not interpreted as a special character by [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)].  
  
## See also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](https://msdn.microsoft.com/library/1400241x)