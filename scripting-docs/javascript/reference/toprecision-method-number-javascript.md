---
title: "toPrecision Method (Number) (JavaScript) | Microsoft Docs"
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
  - "toPrecision"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toPrecision method"
ms.assetid: ac13c82f-1038-447a-823f-f755bba535ca
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toPrecision Method (Number) (JavaScript)
Represents a number either in exponential or fixed-point notation with a specified number of digits.  
  
## Syntax  
  
```  
  
numObj.toPrecision([precision])  
```  
  
## Parameters  
 `numObj`  
 Required. A `Number` object.  
  
 `precision`  
 Optional. The number of significant digits. Must be in the range 1 – 21, inclusive.  
  
## Return Value  
 For numbers in exponential notation, `precision` - 1 digits are returned after the decimal point. For numbers in fixed notation, `precision` significant digits are returned.  
  
 If `precision` is not supplied or is **undefined**, the **toString** method is called instead.  
  
## Example  
 The following code shows how to use `toPrecision`.  
  
```JavaScript  
var num = new Number(123);  
var prec = num.toPrecision();  
document.write(prec);  
document.write("<br/>");  
  
num = new Number(123.456);  
prec = num.toPrecision(5);  
document.write(prec);  
  
// Output:  
// 123  
// 123.46  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)  
  
## See Also  
 [toFixed Method (Number)](../../javascript/reference/tofixed-method-number-javascript.md)   
 [toExponential Method (Number)](../../javascript/reference/toexponential-method-number-javascript.md)