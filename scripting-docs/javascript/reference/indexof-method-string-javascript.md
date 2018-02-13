---
title: "indexOf Method (String) (JavaScript) | Microsoft Docs"
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
  - "indexOf"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "indexOf method, string"
  - "string, indexOf method"
ms.assetid: a17372fa-669b-471b-9240-46927a265152
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# indexOf Method (String) (JavaScript)
Returns the position of the first occurrence of a substring.  
  
## Syntax  
  
```  
  
strObj. indexOf(subString[, startIndex])  
```  
  
## Parameters  
 `strObj`  
 Required. A `String` object or string  literal.  
  
 `subString`  
 Required. The substring to search for in the string  
  
 `startIndex`  
 Optional. The index at which to begin searching the `String` object. If omitted, search starts at the beginning of the string.  
  
## Remarks  
 The **indexOf** method returns the beginning of the substring in the `String` object. If the substring is not found, -1 is returned.  
  
 If `startindex` is negative, `startindex` is treated as zero. If it is greater than the highest index, it is treated as the highest index.  
  
 Searching is performed from left to right. Otherwise, this method is identical to **lastIndexOf**.  
  
## Example  
 The following example illustrates the use of the **indexOf** method.  
  
```JavaScript  
var str = "original equipment manufacturer";  
  
var s = "equip is at position " + str.indexOf("equip");  
s += "<br />";  
s += "abc is at position " + str.indexOf("abc");  
  
document.write(s);  
  
// Output:  
// equip is at position 9  
// abc is at position -1  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [lastIndexOf Method (String)](../../javascript/reference/lastindexof-method-string-javascript.md)   
 [Scrolling, panning, and zooming sample app](http://code.msdn.microsoft.com/ie/Scrolling-panning-and-6834aaf9)