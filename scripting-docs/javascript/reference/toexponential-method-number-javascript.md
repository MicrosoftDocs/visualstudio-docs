---
title: "toExponential Method (Number) (JavaScript) | Microsoft Docs"
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
  - "toExponential"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toExponential method"
ms.assetid: 7c4a6d84-3c1f-4cc4-a67d-7753e5d4ed66
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toExponential Method (Number) (JavaScript)
Represents a number in exponential notation.  
  
## Syntax  
  
```  
  
numObj. toExponential([fractionDigits])  
```  
  
## Parameters  
 `numObj`  
 Required. A **Number** object.  
  
 `fractionDigits`  
 Optional. The number of digits after the decimal point. Must be in the range 0 - 20, inclusive.  
  
## Return Value  
 Returns a string representation of a number in exponential notation. The string contains one digit before the decimal point, and may contain `fractionDigits` digits after it.  
  
 If `fractionDigits` is not supplied, the `toExponential` method returns as many digits necessary to uniquely specify the number.  
  
## Example  
  
```JavaScript  
var num = new Number(123);  
var exp = num.toExponential();  
document.write(exp);  
document.write("<br/>");  
  
num = new Number(123.456);  
exp = num.toExponential(5);  
document.write(exp);  
  
// Output:   
// 1.23e+2  
// 1.23456e+2  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)  
  
## See Also  
 [toFixed Method (Number)](../../javascript/reference/tofixed-method-number-javascript.md)   
 [toPrecision Method (Number)](../../javascript/reference/toprecision-method-number-javascript.md)