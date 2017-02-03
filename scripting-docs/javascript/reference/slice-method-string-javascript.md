---
title: "slice Method (String) (JavaScript) | Microsoft Docs"
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
  - "slice"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "strings [Visual Studio], returning characters"
  - "slice method"
ms.assetid: 80cd77a6-3718-492e-8e96-f909d8721d91
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# slice Method (String) (JavaScript)
Returns a section of a string.  
  
## Syntax  
  
```  
  
stringObj.slice(start, [end])   
```  
  
## Parameters  
 `stringObj`  
 Required. A `String` object or string literal.  
  
 `start`  
 Required. The index to the beginning of the specified portion of `stringObj`.  
  
 `end`  
 Optional. The index to the end of the specified portion of `stringObj`. The substring includes the characters up to, but not including, the character indicated by `end`. If this value is not specified, the substring continues to the end of `stringObj`.  
  
## Remarks  
 The `slice` method returns a `String` object containing the specified portion of `stringObj`.  
  
 The `slice` method copies up to, but not including, the character indicated by `end`.  
  
 If `start` is negative, it is treated as *length* + `start` where *length* is the length of the string. If `end` is negative, it is treated as *length* + `end`. If `end` is omitted, copying continues to the end of `stringObj`. If `end` occurs before `start`, no characters are copied to the new string.  
  
## Example  
 In the first example, the `slice` method returns the entire string. In the second example, the `slice` method returns the entire string, except for the last character.  
  
```javascript  
var str1 = "all good boys do fine";  
  
var slice1 = str1.slice(0);  
var slice2 = str1.slice(0,-1);  
var slice3 = str1.slice(4);  
var slice4 = str1.slice(4, 8);  
  
document.write(slice1 + "<br/>");  
document.write(slice2 + "<br/>");  
document.write(slice3 + "<br/>");  
document.write(slice4);  
  
// Output:  
// all good boys do fine  
// all good boys do fin  
// good boys do fine  
// good  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [slice Method (Array)](../../javascript/reference/slice-method-array-javascript.md)