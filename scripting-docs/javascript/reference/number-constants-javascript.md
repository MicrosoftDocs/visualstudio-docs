---
title: "Number Constants (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "POSITIVE_INFINITY constant [JavaScript]"
  - "MAX_VALUE constant [JavaScript]"
  - "MIN_VALUE constant [JavaScript]"
  - "number constants [JavaScript]"
  - "Number.NEGATIVE_INFINITY constant [JavaScript]"
  - "Number.POSITIVE_INFINITY constant [JavaScript]"
  - "NEGATIVE_INFINITY constant [JavaScript]"
  - "NaN constant [JavaScript]"
  - "Number.MIN_VALUE constant [JavaScript]"
  - "constants [JavaScript], number"
  - "Number.NaN constant [JavaScript]"
  - "Number.MAX_VALUE constant [JavaScript]"
ms.assetid: e0701b41-99ae-4916-9ec0-f79bb15386fb
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Number Constants (JavaScript)
The following number constants are properties of the `Number` object.  
  
## Number Object Constants  
 You do not have to create `Number` object to access these constants.  
  
|Constant|Value returned|  
|--------------|--------------------|  
|`Number.EPSILON`|The smallest number that can be represented in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)]. Equal to approximately 2.2204460492503130808472633361816E-16.|  
|`Number.MAX_SAFE_INTEGER`|The largest number that can be safely represented in JavaScript. Equal to 9007199254740991.|  
|`Number.MAX_VALUE`|The largest number that can be represented in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)]. Equal to approximately 1.79E+308.|  
|`Number.MIN_SAFE_INTEGER`|The smallest number that can be safely represented in JavaScript. Equal to −9007199254740991.|  
|`Number.MIN_VALUE`|The closest number to zero that can be represented in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)]. Equal to approximately 5.00E-324.|  
|`Number.NaN`|A value that is not a number.<br /><br /> In equality comparisons, `NaN` does not equal any value, including itself. To test whether a value is equivalent to `NaN`, use the [isNaN function](../../javascript/reference/isnan-function-javascript.md).|  
|`Number.NEGATIVE_INFINITY`|A value that is less than the largest negative number that can be represented in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)].<br /><br /> [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] displays `NEGATIVE_INFINITY` values as `-infinity`.|  
|`Number.POSITIVE_INFINITY`|A value greater than the largest number that can be represented in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)].<br /><br /> [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] displays `POSITIVE_INFINITY` values as `infinity`.|  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
 For `Number.EPSILON`, `Number.MAX_SAFE_INTEGER`, and `Number.MIN_SAFE_INTEGER`:  
  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)  
  
## See Also  
 [Math Constants](../../javascript/reference/math-constants-javascript.md)   
 [JavaScript Constants](../../javascript/reference/javascript-constants.md)   
 [Infinity Constant](../../javascript/reference/infinity-constant-javascript.md)   
 [NaN Constant](../../javascript/reference/nan-constant-javascript.md)   
 [isNaN Function](../../javascript/reference/isnan-function-javascript.md)