---
title: "charCodeAt Method (String) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "charCodeAt"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "charCodeAt method"
ms.assetid: 5b0290a7-ee4d-4738-a909-c02ef64a2f1a
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# charCodeAt Method (String) (JavaScript)
Returns the Unicode value of the character at the specified location.  
  
## Syntax  
  
```  
  
strObj. charCodeAt(index)  
```  
  
## Parameters  
 `strObj`  
 Required. Any `String` object or string literal.  
  
 `index`  
 Required. The zero-based index of the desired character. If there is no character at the specified index, `NaN` is returned.  
  
## Remarks  
  
## Example  
 The following example illustrates the use of the `charCodeAt` method.  
  
```javascript  
var str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";   
document.write(str.charCodeAt(str.length - 1));  
  
// Output: 90   
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [String.fromCharCode Function](../../javascript/reference/string-fromcharcode-function-javascript.md)