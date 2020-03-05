---
title: "Object expected | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5007"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 5d88c93d-e5b5-4b11-9bb5-bf1a5e41ccc3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Object expected
You attempted to invoke a method or property on an object of a type other than `Object`, or you passed an argument of a type other than `Object` when an `Object` was required.  
  
### To correct this error  
  
- Only invoke the method or property on objects of type `Object`.  
  
- If the error occurs for a non-object argument, pass an object of type `Object`.  
  
- Check whether an undefined or null reference is getting invoked instead of an object of type `Object`.  
  
     For example, if you get this error on myVar in the following code:  
  
    ```JavaScript  
    var str = myVar.toString();  
    ```  
  
     you can use this code instead:  
  
    ```JavaScript  
    if (myVar) {  
        var str = myVar.toString();  
    }  
    ```  
  
## See also  
 [Object Object](../../javascript/reference/object-object-javascript.md)   
 [Objects and Arrays](../../javascript/objects-and-arrays-javascript.md)