---
title: "throw Statement (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "throw_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "error handling, throw statement"
  - "throw statement"
ms.assetid: 75cbade0-fb81-4ffe-b187-b71be380bb05
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# throw Statement (JavaScript)
Generates an error condition that can be handled by a `try...catch...finally` statement.  
  
## Syntax  
  
```  
throw exception   
```  
  
## Remarks  
 The required `exception` argument can be any expression.  
  
 The following example throws an error inside a `try` block, and it is caught in the `catch` block.  
  
```JavaScript  
try {  
        throw new Error(200, "x equals zero");  
}  
catch (e) {  
    document.write(e.message);  
}  
  
// Output: x equals zero.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [try...catch...finally Statement](../../javascript/reference/try-dot-dot-dot-catch-dot-dot-dot-finally-statement-javascript.md)   
 [Error Object](../../javascript/reference/error-object-javascript.md)