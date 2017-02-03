---
title: "Symbol.keyFor Function (JavaScript) | Microsoft Docs"
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
ms.assetid: f0b6f034-6d0a-421c-b1c6-52489411e9a3
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Symbol.keyFor Function (JavaScript)
Returns the key for a specified symbol.  
  
## Syntax  
  
```vb  
Symbol.keyFor(sym);  
```  
  
#### Parameters  
 `sym`  
 Required. The symbol object.  
  
## Remarks  
 This method searches for the symbol in the global symbol registry.  
  
## Example  
  
```javascript  
// Local symbol  
var sym1 = Symbol("desc");  
// Global symbol  
var sym2 = Symbol.for("desc");  
  
console.log(Symbol.keyFor(sym1)):  
console.log(Symbol.keyFor(sym2));  
  
// Output:  
// undefined  
// desc  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]