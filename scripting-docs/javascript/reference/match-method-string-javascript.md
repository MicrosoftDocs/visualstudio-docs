---
title: "match Method (String) (JavaScript) | Microsoft Docs"
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
  - "match"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Match method"
ms.assetid: eda9ad27-4f9b-4cb1-8345-a0ae85979ca0
caps.latest.revision: 22
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# match Method (String) (JavaScript)
Matches a string with a regular expression, and returns an array containing the results of that search.  
  
## Syntax  
  
```  
  
stringObj.match(rgExp)   
```  
  
## Parameters  
 `stringObj`  
 Required. The `String` object or string literal on which to perform the search.  
  
 `rgExp`  
 Required. A regular expression object that contains the regular expression pattern and applicable flags. This can also be a variable name or string literal containing the regular expression pattern and flags.  
  
## Remarks  
 If the `match` method does not find a match, it returns `null`. If it finds a match, `match` returns an array, and the properties of the global `RegExp` object are updated to reflect the results of the match.  
  
 If the global flag (`g`) is not set, Element zero of the array contains the entire match, while elements 1 through *n* contain any submatches. This behavior is the same as the behavior of the [exec Method (Regular Expression)](../../javascript/reference/exec-method-regular-expression-javascript.md) when the global flag is not set. If the global flag is set, elements 0 through *n* contain all matches that occurred.  
  
 If the global flag is not set, the array returned by the `match` method has two properties, `input` and `index`. The `input` property contains the entire searched string. The `index` property contains the position of the matched substring within the complete searched string.  
  
 If the flag `i` is set, the search is not case-sensitive.  
  
## Example  
 The following example illustrates the use of the `match` method.  
  
```javascript  
var src = "azcafAJAC";  
  
var re = /[a-c]/;  
  
var result = src.match(re);  
  
// The entire match is in array element 0.  
document.write(result[0] + "<br/>");  
  
// Now try the same match with the global flag.  
var reg = /[a-c]/g;  
result = src.match(reg);  
  
// The matches are in elements 0 through n.  
for (var index = 0; index < result.length; index++)  
{  
    document.write ("submatch " + index + ": " +  result[index]);  
    document.write("<br />");  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [exec Method (Regular Expression)](../../javascript/reference/exec-method-regular-expression-javascript.md)   
 [RegExp Object](../../javascript/reference/regexp-object-javascript.md)   
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [replace Method (String)](../../javascript/reference/replace-method-string-javascript.md)   
 [search Method (String)](../../javascript/reference/search-method-string-javascript.md)   
 [test Method (Regular Expression)](../../javascript/reference/test-method-regular-expression-javascript.md)   
 [Regular Expression Programming (JavaScript)](http://msdn.microsoft.com/en-us/3b62e27c-4f07-4726-a95b-6e841807bfaf)   
 [Alternation and Subexpressions (JavaScript)](http://msdn.microsoft.com/en-us/c59dd3e8-7fee-493e-9123-065af1e651ae)   
 [Backreferences (JavaScript)](http://msdn.microsoft.com/en-us/5d8dbd5a-cd03-4548-850b-9d7bad2c839a)