---
title: "concat Method (String) (JavaScript) | Microsoft Docs"
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
  - "concat"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "concat method (String)"
  - "Concat method"
ms.assetid: 5d28ebb2-d534-4179-9297-a4c821ee9f24
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# concat Method (String) (JavaScript)
Returns a string that contains the concatenation of two or more strings.  
  
## Syntax  
  
```  
  
string1. concat([string2[, string3[, . . . [, stringN]]]])  
```  
  
## Parameters  
 `string1`  
 Required. The `String` object or string literal to which all other specified strings are concatenated.  
  
 `string2,. . ., stringN`  
 Optional. The strings to append to the end of `string1`.  
  
## Remarks  
 The result of the `concat` method is equivalent to: `result` = `string1` + `string2` + `string3` + `stringN`. A change of value in either a source or result string does not affect the value in the other string. If any of the arguments are not strings, they are first converted to strings before being concatenated to `string1`.  
  
## Example  
 The following example illustrates the use of the `concat` method when used with a string:  
  
```javascript  
var str1 = "ABCD"  
var str2 = "EFGH";  
var str3 = "1234";  
var str4 = "5678";  
document.write(str1.concat(str2, str3, str4));  
  
// Output: "ABCDEFGH12345678"  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [Addition Operator (+)](../../javascript/reference/addition-operator-decrement-javascript.md)