---
title: "parseFloat Function (JavaScript) | Microsoft Docs"
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
  - "parseFloat"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "parseFloat method"
ms.assetid: a7d87a69-1919-4623-be85-972e6376dd2d
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# parseFloat Function (JavaScript)
Converts a string to a floating-point number.  
  
## Syntax  
  
```  
parseFloat(numString)   
```  
  
## Remarks  
 The required `numString` argument is a string that contains a floating-point number.  
  
 The `parseFloat` function returns a numerical value equal to the number contained in `numString`. If no prefix of `numString` can be successfully parsed into a floating-point number, `NaN` (not a number) is returned.  
  
```JavaScript  
parseFloat("abc")      // Returns NaN.  
parseFloat("1.2abc")   // Returns 1.2.  
```  
  
 You can test for `NaN` using the `isNaN` function.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## See Also  
 [isNaN Function](../../javascript/reference/isnan-function-javascript.md)   
 [parseInt Function](../../javascript/reference/parseint-function-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)