---
title: "length Property (String) (JavaScript) | Microsoft Docs"
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
  - "length Property"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "strings [Visual Studio], length"
  - "Length property"
  - "length property (String)"
ms.assetid: 7dbd4a0e-c24e-4561-9b5b-e75e649a10a4
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# length Property (String) (JavaScript)
Returns the length of a `String` object.  
  
> [!WARNING]
>  JavaScript strings are immutable, so the length of a string cannot be modified.  
  
## Syntax  
  
```  
  
      strVariable.length  
"String Literal".length   
```  
  
## Remarks  
 The `length` property contains an integer that indicates the number of characters in the `String` object. The last character in the `String` object has an index of i`length` - 1.  
  
## Example  
 The following code shows how to use `length`. JavaScript strings are immutable and cannot be modified in place. However, you can write the reversed string to an array and then call `join` with the empty character, which produces a string with no separator characters.  
  
```javascript  
var str = "every good boy does fine";  
        var start = 0;  
        var end = str.length - 1;  
        var tmp = "";  
        var arr = new Array(end);  
  
        while (end >= 0) {  
            arr[start++] = str.charAt(end--);  
        }  
  
// Join the elements of the array with a   
        var str2 = arr.join('');  
        document.write(str2);  
  
// Output: enif seod yob doog yreve  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]