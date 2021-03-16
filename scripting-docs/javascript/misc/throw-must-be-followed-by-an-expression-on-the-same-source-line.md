---
description: "You used the throw keyword, but did not follow it with an expression on the same source line."
title: "Throw must be followed by an expression on the same source line | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: error-reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1035"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: b03b7747-01a1-40c6-af80-a1dd70bc5781
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Throw must be followed by an expression on the same source line
You used the `throw` keyword, but did not follow it with an expression on the same source line. A `throw` statement consists of two parts: the `throw` keyword, followed by the expression to be thrown. For example:  
  
```JavaScript  
if (denominator == 0) {  
 throw new DivideByZeroException();  
}  
```  
  
 You cannot split these two components up.  
  
### To correct this error  
  
- Make sure that the `throw` keyword and the expression to be thrown appears on the same line.  
  
## See also  
 [Error Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Error)   
 [throw Statement](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Statements/throw)   
 [try...catch...finally Statement](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Statements/try...catch)
