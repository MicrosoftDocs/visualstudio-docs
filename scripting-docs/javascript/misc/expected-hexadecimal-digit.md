---
title: "Expected hexadecimal digit | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1023"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 67a86df7-49f9-43cb-99c6-99b1a427827a
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected hexadecimal digit
You created an incorrect Unicode escape sequence. Unicode escape sequences begin with \u, followed by exactly four hexadecimal digits (no more and no less). Unicode hexadecimal digits can contain only the numbers 0-9, the upper case letters A-F, and the lower case letters a-f. The following example demonstrates a correctly formed Unicode escape sequence.  
  
```JavaScript  
z = "\u1A5F";  
```  
  
### To correct this error  
  
- Be sure your Unicode hexadecimal digits begin with \u, contains only the numbers 0-9, the upper case letters A-F, the lower case letters a-f; and are grouped into four digits.  
  
    > [!NOTE]
    > If you want to use the literal text \u in a string, then use two backslashes - (\\\u) - one to escape the first backslash.  
  
## See also  
 [Data Types](../../javascript/data-types-javascript.md)