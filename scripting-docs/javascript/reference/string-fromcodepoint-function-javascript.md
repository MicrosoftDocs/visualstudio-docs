---
title: "String.fromCodePoint Function (JavaScript) | Microsoft Docs"
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
ms.assetid: 7c4c057b-c67a-4b10-afdd-4f75c7c5988c
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# String.fromCodePoint Function (JavaScript)
Returns the string associated with a Unicode UTF-16 code point.  
  
## Syntax  
  
```  
String.fromCodePoint(...codePoints);  
```  
  
#### Parameters  
 `...codePoints`  
 Required. A rest parameter that specifies one or more UTF-16 code point values.  
  
## Remarks  
 This function throws a `RangeError` exception if `...codePoints` is not a valid UTF-16 code point.  
  
## Example  
 The following example shows how to use the `fromCodePoint` function.  
  
```JavaScript  
var str1 = String.fromCodePoint(0x20BB7);  
var str2 = String.fromCodePoint(98);  
var str3 = String.fromCodePoint(97, 98, 99);  
  
if(console && console.log) {  
    console.log(str1);  
    console.log(str2);  
    console.log(str3);  
}  
  
// Output:  
// 𠮷  
// b  
// abc   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]