---
title: "Expected 'catch' | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1033"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: f1cd947f-eba2-411e-8e84-8ca86f608643
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Expected 'catch'
You used the exception handling **try** block, but did not write the associated **catch** statement. The exception handling mechanism requires that the code that can fail, along with the code that should not execute if an exception occurs, be wrapped inside a **try** block. Exceptions are thrown from within the **try** block using the **throw** statement, and caught outside the **try** block with one or more **catch** statements.  
  
### To correct this error  
  
- Add the associated **catch** block.  
  
- Try using a **finally** block instead of a **catch** block.  
  
## See also  
 [try...catch...finally Statement](../../javascript/reference/try-dot-dot-dot-catch-dot-dot-dot-finally-statement-javascript.md)   
 [Error Object](../../javascript/reference/error-object-javascript.md)