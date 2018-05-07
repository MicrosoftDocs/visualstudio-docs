---
title: "toUpperCase Method (String) (JavaScript) | Microsoft Docs"
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
  - "toUpperCase"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toUpperCase method"
ms.assetid: 4fd4ccc3-e794-498a-9db1-baf48fc1dda1
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toUpperCase Method (String) (JavaScript)
Converts all the alphabetic characters in a string to uppercase.  
  
## Syntax  
  
```  
  
      strVariable.toUpperCase()  
"String Literal".toUpperCase()   
```  
  
## Remarks  
 The `toUpperCase` method has no effect on non-alphabetic characters.  
  
## Example  
 The following example demonstrates the effects of the `toUpperCase` method:  
  
```JavaScript  
var str1 = "This is a STRING.";  
var str2 = str1.toUpperCase();  
document.write(str2);  
  
// Output: THIS IS A STRING.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [toLocaleUpperCase Method (String)](../../javascript/reference/tolocaleuppercase-method-string-javascript.md)   
 [toLowerCase Method](../../javascript/reference/tolowercase-method-javascript.md)