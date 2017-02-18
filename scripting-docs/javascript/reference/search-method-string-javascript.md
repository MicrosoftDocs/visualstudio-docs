---
title: "search Method (String) (JavaScript) | Microsoft Docs"
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
  - "search"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "search method"
ms.assetid: 1cae0fbc-3319-4327-ba4e-d5fa2c4a9ba0
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# search Method (String) (JavaScript)
Finds the first substring match in a regular expression search.  
  
## Syntax  
  
```  
  
stringObj.search(rgExp)   
```  
  
## Parameters  
 `stringObj`  
 Required. The `String` object or string literal on which to perform the search.  
  
 `rgExp`  
 Required. An instance of a **Regular Expression** object containing the regular expression pattern and applicable flags.  
  
## Return Value  
 If a match is found, the **search** method returns an integer value that indicates the offset from the beginning of the string where the first match occurred. If no match is found, it returns -1.  
  
## Remarks  
 You can also set the `i` flag that causes the search to be case-insensitive.  
  
## Example  
 The following example illustrates the use of the **search** method.  
  
```javascript  
var src = "is but a Dream within a dream";  
var re = /dream/;  
var pos = src.search(re);  
document.write(pos);  
document.write("<br/>");  
  
re = /dream/i;  
pos = src.search(re);  
document.write(pos);  
  
// Output:   
// 24   
// 9  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [exec Method (Regular Expression)](../../javascript/reference/exec-method-regular-expression-javascript.md)   
 [match Method (String)](../../javascript/reference/match-method-string-javascript.md)   
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)   
 [replace Method (String)](../../javascript/reference/replace-method-string-javascript.md)   
 [test Method (Regular Expression)](../../javascript/reference/test-method-regular-expression-javascript.md)   
 [Regular Expression Programming (JavaScript)](http://msdn.microsoft.com/en-us/3b62e27c-4f07-4726-a95b-6e841807bfaf)