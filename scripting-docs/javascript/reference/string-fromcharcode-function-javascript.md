---
title: "String.fromCharCode Function (JavaScript) | Microsoft Docs"
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
  - "fromCharCode"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "fromCharCodeAt method"
  - "characters, from Unicode"
ms.assetid: f64120c1-23a7-48ca-8d1c-db3e8856cab4
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# String.fromCharCode Function (JavaScript)
Returns a string from a number of Unicode character values.  
  
## Syntax  
  
```  
String.fromCharCode([code1[, code2[, ...[, codeN]]]])   
```  
  
## Parameters  
 `String`  
 Required. The `String` object.  
  
 `code1`, . . . , `codeN`  
 Optional. A series of Unicode character values to convert to a string. If no arguments are supplied, the result is the empty string.  
  
## Remarks  
 You call this function on the `String` object rather than on a string instance.  
  
 The following example shows how to use this method:  
  
```javascript  
var test = String.fromCharCode(112, 108, 97, 105, 110);  
document.write(test);  
  
// Output: plain  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [charCodeAt Method (String)](../../javascript/reference/charcodeat-method-string-javascript.md)