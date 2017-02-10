---
title: "substring Method (String) (JavaScript) | Microsoft Docs"
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
  - "substring"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "substrings"
  - "substring method"
ms.assetid: 9cf9a005-cbe3-42fd-828b-57a39f54224c
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# substring Method (String) (JavaScript)
Returns the substring at the specified location within a `String` object.  
  
## Syntax  
  
```  
  
      strVariable. substring(start [, end])  
"String Literal".substring(start [, end])   
```  
  
## Parameters  
 `start`  
 Required. The zero-based index integer indicating the beginning of the substring.  
  
 `end`  
 Optional. The zero-based index integer indicating the end of the substring. The substring includes the characters up to, but not including, the character indicated by `end`.  
  
 If `end` is omitted, the characters from `start` through the end of the original string are returned.  
  
## Remarks  
 The `substring` method returns a string containing the substring from `start` up to, but not including, `end`.  
  
 The **substring** method uses the lower value of `start` and `end` as the beginning point of the substring. For example, strvar.substring(0, 3**)** and strvar.substring(3, 0) return the same substring.  
  
 If either `start` or `end` is `NaN` or negative, it is replaced with zero.  
  
 The length of the substring is equal to the absolute value of the difference between `start` and `end`. For example, the length of the substring returned in strvar.substring(0, 3) and strvar.substring(3, 0) is three.  
  
## Example  
 The following example illustrates the use of the **substring** method.  
  
```javascript  
var s = "The quick brown fox jumps over the lazy dog.";  
var ss = s.substring(10, 15);  
document.write(ss);  
  
// Output:  
// brown  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [substr Method (String)](../../javascript/reference/substr-method-string-javascript.md)