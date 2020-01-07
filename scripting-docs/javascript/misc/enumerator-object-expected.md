---
title: "Enumerator object expected | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5015"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: dc6e32c1-a6e6-4e12-ac99-e3f65f91c8d7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Enumerator object expected
You attempted to invoke the **Enumerator.prototype.atEnd, Enumerator.prototype.item, Enumerator.prototype.moveFirst,** or **Enumerator.prototype.moveNext** method on an object of a type other than `Enumerator`. The object of this type of invocation must be of type `Enumerator`. Here is an example of code that breaks this rule:  
  
```JavaScript  
var o = new Object;  
o.f = Enumerator.prototype.atEnd;  
o.f();  
```  
  
### To correct this error  
  
- Only invoke the **Enumerator.prototype.atEnd**, **Enumerator.prototype.item**, **Enumerator.prototype.moveFirst**, or **Enumerator.prototype.moveNext** methods on objects of type `Enumerator`. To find out if your object is an `Enumerator` object, use:  
  
    ```js
    if(x instanceof Enumerator)  
    ```  
  
## See also  
 [Enumerator Object](../../javascript/reference/enumerator-object-javascript.md)