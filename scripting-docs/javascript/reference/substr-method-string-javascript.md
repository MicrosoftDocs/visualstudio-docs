---
title: "substr Method (String) (JavaScript) | Microsoft Docs"
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
  - "substr"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "substr method"
ms.assetid: f12541c1-2623-482e-941d-2e22bc3c4a4a
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# substr Method (String) (JavaScript)
Gets a substring beginning at the specified location and having the specified length.  
  
## Syntax  
  
```  
  
stringvar.substr(start [, length ])   
```  
  
## Parameters  
 `stringvar`  
 Required. A string literal or `String` object from which the substring is extracted.  
  
 `start`  
 Required. The starting position of the desired substring. The index of the first character in the string is zero.  
  
 `length`  
 Optional. The number of characters to include in the returned substring.  
  
## Remarks  
 If `length` is zero or negative, an empty string is returned. If not specified, the substring continues to the end of `stringvar`.  
  
## Example  
 The following example illustrates the use of the `substr` method.  
  
```JavaScript  
var s = "The quick brown fox jumps over the lazy dog.";  
var ss = s.substr(10, 5);    
document.write("[" + ss + "] <br>");  
  
ss = s.substr(10);  
document.write("[" + ss + "] <br>");  
  
ss = s.substr(10, -5);  
document.write("[" + ss + "] <br>");  
  
// Output:  
// [brown]   
// [brown fox jumps over the lazy dog.]   
// []  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [substring Method (String)](../../javascript/reference/substring-method-string-javascript.md)