---
title: "constructor Property (Boolean) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
ms.assetid: b67ca875-23c6-4687-a5ce-1cdd25d1c923
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# constructor Property (Boolean)
Specifies the function that creates a Boolean.  
  
## Syntax  
  
```  
  
boolean.constructor([[value])  
```  
  
#### Parameters  
 `boolean`  
 The name of the Boolean.  
  
 `value`  
 Optional. Specifies the value of the Boolean. This can be the numbers 1 or 0, or the strings "true" or "false".  
  
## Remarks  
 The `constructor` property contains a reference to the function that constructs instances of the Boolean object.  
  
## Example  
 The following example illustrates the use of the constructor property.  
  
```JavaScript  
var x = new Boolean("true");  
  
if (x.constructor == Boolean)  
    document.write("Object is a Boolelan.");  
  
// Output:  
// Object is a Boolean.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]