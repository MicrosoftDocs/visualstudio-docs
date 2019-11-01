---
title: "Exception thrown and not caught | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5022"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: b5235490-a8e7-42e3-804e-d85235bc6f05
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Exception thrown and not caught
You included a `throw` statement in your code, but it was not enclosed within a **try** block, or there was no associated **catch** block to trap the error. Exceptions are thrown from within the **try** block using the **throw** statement, and caught outside the **try** block with a **catch** statement.  
  
### To correct this error  
  
- Enclose code that can throw an exception in a **try** block, and ensure there is a corresponding **catch** block.  
  
- Make sure your catch statement expects the correct form of exception.  
  
- If the exception is rethrown, make sure there is another corresponding catch statement.  
  
## See also  
 [Error Object](../../javascript/reference/error-object-javascript.md)   
 [throw Statement](../../javascript/reference/throw-statement-javascript.md)   
 [try...catch...finally Statement](../../javascript/reference/try-dot-dot-dot-catch-dot-dot-dot-finally-statement-javascript.md)