---
title: "Cannot assign to a function result | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: error-reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5003"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: ee8ffb3a-1451-4cb3-99bf-5e9cf8b77d79
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Cannot assign to a function result
You attempted to assign a value to a function result. The result of a function can be assigned to a variable, but it cannot be used as a variable. If you want to assign a new value to the function itself, omit the parentheses (the function call operator). The following example demonstrates a situation in which this error is generated.  
  
```js
myFunction() = 42;  // Attempting to assign the value 42 to the result of the function call.  
```  
  
### To correct this error  
  
- Do not use the value of a function call result as something you can *assign to*. You can assign the result of the function call *to a variable* though.  
  
    ```JavaScript  
    myVar = myFunction(42);  
    ```  
  
- Alternatively, you can assign the function itself (and not its return value) to a variable.  
  
    ```JavaScript  
    myFunction = new Function("return 42;");  
    ```  
  
## See also  
 [Function Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Function)   
 [Writing JavaScript Code](https://developer.mozilla.org/docs/Learn/Getting_started_with_the_web/JavaScript_basics)   
 [Functions](https://developer.mozilla.org/docs/Learn/JavaScript/Building_blocks/Functions)