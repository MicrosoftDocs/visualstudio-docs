---
description: "An attempt has been made to invoke JSON.stringify with a value that is not valid."
title: "Circular reference in value argument not supported | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: error-reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5034"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 5d06f0fa-86f5-49d1-8d50-af1759990f43
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Circular reference in value argument not supported
An attempt has been made to invoke `JSON.stringify` with a value that is not valid. The `value` argument, an array or object, contains a circular reference.  
  
### To correct this error  
  
- Remove the circular reference from the argument.  
  
## Example  
 The code in this example causes a runtime error because `john` has a reference to `mary` and `mary` has a reference to `john`. to remove the circular reference, either remove or unset the property `brother` from the `mary` object or the `sister` property from the `john` object.  
  
```JavaScript  
var john = new Object();  
var mary = new Object();  
john.sister = mary;  
mary.brother = john;  
  
// This line causes a runtime error.  
var error = JSON.stringify(john);  
```  
  
## See also  
 [JSON Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/JSON)   
 [JSON.parse Function](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse)   
 [JavaScript Run-time Errors](/microsoft-edge/devtools-guide/console/error-and-status-codes#javascript-run-time-errors)
