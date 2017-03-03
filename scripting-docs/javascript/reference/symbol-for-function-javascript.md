---
title: "Symbol.for Function (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: 27db15f3-9108-4892-8f89-e84031729cb6
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Symbol.for Function (JavaScript)
Returns the symbol for a specified key or, if the key is not present, creates a new symbol object with the new key.  
  
## Syntax  
  
```vb  
Symbol.for(key);  
```  
  
#### Parameters  
 `key`  
 Required. The key for the symbol, which is also used as the description.  
  
## Remarks  
 This method searches for the symbol in the global symbol registry. If you serialize symbols as strings, use the global symbol registry to make sure that a particular string maps to the correct symbol for all lookups.  
  
## Example  
  
```javascript  
var sym = Symbol.for("desc");  
  
console.log(sym.toString());  
  
// Two different object references.  
console.log(Symbol("symbol") === Symbol.for("symbol");)  
// Single object reference.   
console.log(Symbol.for("symbol") === Symbol.for("symbol");)  
  
// Output:  
// Symbol(desc);  
// false  
// true  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]