---
title: "'return' statement outside of function | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT1018"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 03568f9f-5f4f-4a10-a738-9a73f3832b9e
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# 'return' statement outside of function
You used a `return` statement in the global scope of your code. The `return` statement should only appear within the body of a function.  
  
 Invoking a function with the `()` operator is an expression. All expressions have values; the `return` statement is used to specify the value returned by a function. The general form is:  
  
```js
  
return [ expression ];  
```  
  
 When the `return` statement is executed, *expression* is evaluated and returned as the value of the function. If there is no expression, **undefined** is returned.  
  
 Execution of the function stops when the `return` statement is executed, even if there are other statements still remaining in the function body. The exception to this rule is if the **return** statement occurs within a **try** block, and there is a corresponding **finally** block, the code in the **finally** block will execute before the function returns.  
  
 If a function returns because it reaches the end of the function body without executing a `return` statement, the value returned is the **undefined** value (this means the function result cannot be used as part of a larger expression).  
  
### To correct this error  
  
- Remove the `return` statement from the main body of your code (the global scope).  
  
## See also  
 [return Statement](../../javascript/reference/return-statement-javascript.md)   
 [Function Object](../../javascript/reference/function-object-javascript.md)   
 [caller Property (Function)](../../javascript/reference/caller-property-function-javascript.md)