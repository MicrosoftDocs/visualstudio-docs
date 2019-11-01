---
title: "Invalid replacer argument | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5035"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 4727186f-facd-4aa6-9447-bbefbae83f07
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Invalid replacer argument
An attempt has been made to invoke `JSON.stringify` with an argument that is not valid. The `replacer` argument must be a function or an array.  
  
### To correct this error  
  
- Change the `replacer` argument to a function or an array.  
  
## Example  
 The code in this example causes a runtime error because `memberfilter` is an object instead of a function or array.  
  
```JavaScript  
var contact = new Object();  
contact.firstname = "Jesper";  
contact.surname = "Aaberg";  
contact.phone = ["555-0100", "555-0120"];  
  
var memberfilter = new Object();  
  
// This line will cause a runtime error.  
var jsontext = JSON.stringify(contact, memberfilter, "\t");  
```  
  
## See also  
 [JSON Object](../../javascript/reference/json-object-javascript.md)   
 [JSON.parse Function](../../javascript/reference/json-parse-function-javascript.md)   
 [JavaScript Run-time Errors](../../javascript/reference/javascript-run-time-errors.md)