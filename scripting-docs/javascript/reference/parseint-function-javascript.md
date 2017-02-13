---
title: "parseInt Function (JavaScript) | Microsoft Docs"
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
  - "parseInt"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "parseInt method"
ms.assetid: e86471af-2a0e-4359-83af-f1ac81e51421
caps.latest.revision: 24
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# parseInt Function (JavaScript)
Converts a string to an integer.  
  
## Syntax  
  
```  
parseInt(numString, [radix])   
```  
  
## Parameters  
 `numString`  
 Required. A string to convert into a number.  
  
 `radix`  
 Optional. A value between 2 and 36 that specifies the base of the number in `numString`. If this argument is not supplied, strings with a prefix of '0x' are considered hexadecimal. All other strings are considered decimal.  
  
## Remarks  
 The `parseInt` function returns an integer value equal to the number contained in `numString`. If no prefix of `numString` can be successfully parsed into an integer, `NaN` (not a number) is returned.  
  
```javascript  
parseInt("abc");     // Returns NaN.  
parseInt("12abc");   // Returns 12.  
```  
  
 You can test for `NaN` using the `isNaN` function.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
> [!NOTE]
>  Starting in [!INCLUDE[jsv9textspecific](../../javascript/reference/includes/jsv9textspecific-md.md)], the `parseInt` function does not treat a string that has a prefix of '0' as an octal. When you are not using the `parseInt` function, however, strings with a prefix of '0' can still be interpreted as octals. See [Data Types](../../javascript/data-types-javascript.md) for information about octal integers.  
  
## See Also  
 [isNaN Function](../../javascript/reference/isnan-function-javascript.md)   
 [parseFloat Function](../../javascript/reference/parsefloat-function-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)   
 [valueOf Method (Object)](../../javascript/reference/valueof-method-object-javascript.md)