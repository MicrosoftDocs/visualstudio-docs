---
title: "codePointAt Method (String) (JavaScript) | Microsoft Docs"
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
ms.assetid: 7979018f-1be3-4a13-9e8f-c84c7ed35288
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# codePointAt Method (String) (JavaScript)
Returns the code point for a Unicode UTF-16 character.  
  
## Syntax  
  
```  
stringObj.codePointAt(pos);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object.  
  
 `pos`  
 Required. The position of the character.  
  
## Remarks  
 This method returns code point values, including astral code points (code points with more than four hexadecimal values), for all UTF-16 characters.  
  
 If `pos` is less than zero (0) or greater than the size of the string, the return value is `undefined`.  
  
## Example  
 The following example shows how to use the `codePointAt` method.  
  
```JavaScript  
var cp1 = "𠮷".codePointAt(0);  
var cp2 = 'abc'.codePointAt(1);  
  
if(console && console.log) {  
    console.log(cp1);  
    console.log(cp2);}  
  
// Output:  
// 0x20BB7  
// 98   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]
