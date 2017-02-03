---
title: "lastIndexOf Method (String) (JavaScript) | Microsoft Docs"
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
  - "lastIndexOf"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "lastIndexOf method, string"
  - "string, lastIndexOf method"
ms.assetid: 1ed36ccd-0f0b-4f16-be45-0567207670af
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# lastIndexOf Method (String) (JavaScript)
Returns the last occurrence of a substring in the string.  
  
## Syntax  
  
```  
  
strObj.lastIndexOf(substring[, startindex])  
```  
  
## Parameters  
 `strObj`  
 Required. A `String` object or string literal.  
  
 `substring`  
 Required. The substring to search for.  
  
 `startindex`  
 Optional. The index at which to begin searching. If omitted, the search begins at the end of the string.  
  
## Remarks  
 The **lastIndexOf** method returns an integer value indicating the beginning of the substring within the `String` object. If the substring is not found, a -1 is returned.  
  
 If `startindex` is negative, `startindex` is treated as zero. If it is larger than the greatest character position index, it is treated as the largest possible index.  
  
 Searching is performed starting at the last character in the string. Otherwise, this method is identical to **indexOf**.  
  
 The following example illustrates the use of the **lastIndexOf** method.  
  
```javascript  
var str = "time, time";  
  
var s = "";  
s += "time is at position " + str.lastIndexOf("time");  
s += "<br />";  
s += "abc is at position " + str.lastIndexOf("abc");  
  
document.write(s);  
  
// Output:  
// time is at position 6  
// abc is at position -1  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [indexOf Method (String)](../../javascript/reference/indexof-method-string-javascript.md)