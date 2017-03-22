---
title: "split Method (String) (JavaScript) | Microsoft Docs"
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
  - "split"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "split method"
ms.assetid: 7f093336-c887-4efb-b91f-819b6d18a181
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# split Method (String) (JavaScript)
Split a string into substrings using the specified separator and return them as an array.  
  
## Syntax  
  
```  
  
stringObj.split([separator[, limit]])  
```  
  
## Parameters  
 `stringObj`  
 Required. The `String` object or string literal to be split. This object is not modified by the **split** method.  
  
 `separator`  
 Optional. A string or a **Regular Expression** object that identifies character or characters to use in separating the string. If omitted, a single-element array containing the entire string is returned.  
  
 `limit`  
 Optional. A value used to limit the number of elements returned in the array.  
  
## Return Value  
 The result of the **split** method is an array of strings split at each point where `separator` occurs in `stringObj`. The `separator` is not returned as part of any array element.  
  
## Example  
 The following example illustrates the use of the **split** method.  
  
```JavaScript  
var s = "The quick brown fox jumps over the lazy dog.";  
var ss = s.split(" ");  
for (var i in ss) {  
    document.write(ss[i]);  
    document.write("<br/>");  
}  
  
// Output:   
// The  
// quick  
// brown  
// fox  
// jumps  
// over  
// the  
// lazy  
// dog.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [concat Method (String)](../../javascript/reference/concat-method-string-javascript.md)   
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)   
 [Scrolling, panning, and zooming sample app](http://code.msdn.microsoft.com/ie/Scrolling-panning-and-6834aaf9)