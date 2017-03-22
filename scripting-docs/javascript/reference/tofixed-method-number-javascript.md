---
title: "toFixed Method (Number) (JavaScript) | Microsoft Docs"
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
  - "toFixed"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toFixed method"
ms.assetid: b5f03400-865e-4ab2-818c-f734c0f6d6f0
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toFixed Method (Number) (JavaScript)
Represents a number in fixed-point notation.  
  
## Syntax  
  
```  
  
numObj.toFixed([fractionDigits])  
```  
  
## Parameters  
 `numObj`  
 Required A `Number` object.  
  
 `fractionDigits`  
 Optional. The number of digits after the decimal point. Must be in the range 0 – 20, inclusive.  
  
## Return Value  
 Returns a string representation of a number in fixed-point notation, containing `fractionDigits` digits after the decimal point.  
  
 If `fractionDigits` is not supplied or **undefined**, the default value is zero.  
  
## Example  
 The following code shows how to use `toFixed`.  
  
```JavaScript  
var num = new Number(123);  
var fix = num.toFixed();  
document.write(fix);  
document.write("<br/>");  
  
num = new Number(123.456);  
fix = num.toFixed(5);  
document.write(fix);  
  
// Output:  
// 123  
123.45600  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)  
  
## See Also  
 [toExponential Method (Number)](../../javascript/reference/toexponential-method-number-javascript.md)   
 [toPrecision Method (Number)](../../javascript/reference/toprecision-method-number-javascript.md)