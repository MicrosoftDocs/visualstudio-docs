---
title: "Function expected | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5002"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: f62ade94-9f6f-4832-9b9b-49a06a385bbe
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Function expected
Either you attempted to invoke one of the **Function prototype** methods on an object that was not a `Function` object, or you used an object in a function call context. For example, the following code produces this error because **example** is not a function.  
  
```JavaScript  
var example = new Object();  // Create a new object called "example".  
var x = example();           // Try and call example as if it were a function.  
```  
  
### To correct this error  
  
- Only call **Function prototype** methods on `Function` objects.  
  
- Ensure that you use the function call operator `()` to call functions only.  
  
## See also  
 [Function Object](../../javascript/reference/function-object-javascript.md)   
 [prototype Property (Object)](../../javascript/reference/prototype-property-object-javascript.md)