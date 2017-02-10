---
title: "Math Object (JavaScript) | Microsoft Docs"
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
  - "Math object"
ms.assetid: 607b94cb-921c-43cd-b514-fdbc13aeced6
caps.latest.revision: 24
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math Object (JavaScript)
An intrinsic object that provides basic mathematics functionality and constants.  
  
## Syntax  
  
```  
  
Math.[{property | method}]  
```  
  
## Parameters  
 *property*  
 Required. Name of one of the properties of the **Math**. object.  
  
 *method*  
 Required. Name of one of the methods of the **Math**. object.  
  
## Remarks  
 The **Math** object cannot be created using the **new** operator, and gives an error if you attempt to do so. The scripting engine creates it when the engine is loaded. All of its methods and properties are available to your script at all times.  
  
## Requirements  
 The `Math` object was introduced in [!INCLUDE[jsv1text](../../javascript/reference/includes/jsv1text-md.md)].  
  
<a name="js56jsobjmathprop"></a>   
## Constants  
 The following table lists the constants of the `Math` object.  
  
|Constant|Description|  
|--------------|-----------------|  
|[Math.E Constant](../../javascript/reference/math-constants-javascript.md)|The mathematical constant e. This is Euler's number, the base of natural logarithms.|  
|[Math.LN2 Constant](../../javascript/reference/math-constants-javascript.md)|The natural logarithm of 2.|  
|[Math.LN10 Constant](../../javascript/reference/math-constants-javascript.md)|The natural logarithm of 10.|  
|[Math.LOG2E Constant](../../javascript/reference/math-constants-javascript.md)|The base-2 logarithm of e.|  
|[Math.LOG10E Constant](../../javascript/reference/math-constants-javascript.md)|The base-10 logarithm of e.|  
|[Math.PI Constant](../../javascript/reference/math-constants-javascript.md)|Pi. This is the ratio of the circumference of a circle to its diameter.|  
|[Math.SQRT1_2 Constant](../../javascript/reference/math-constants-javascript.md)|The square root of 0.5, or, equivalently, one divided by the square root of 2.|  
|[Math.SQRT2 Constant](../../javascript/reference/math-constants-javascript.md)|The square root of 2.|  
  
<a name="js56jsobjmathmeth"></a>   
## Functions  
 The following table lists the functions of the `Math` object.  
  
|Function|Description|  
|--------------|-----------------|  
|[Math.abs Function](../../javascript/reference/math-abs-function-javascript.md)|Returns the absolute value of a number.|  
|[Math.acos Function](../../javascript/reference/math-acos-function-javascript.md)|Returns the arccosine of a number.|  
|[Math.acosh Function](../../javascript/reference/math-acosh-function-javascript.md)|Returns the hyperbolic arccosine (or inverse hyperbolic cosine) of a number.|  
|[Math.asin Function](../../javascript/reference/math-asin-function-javascript.md)|Returns the arcsine of a number.|  
|[Math.asinh Function](../../javascript/reference/math-asinh-function-javascript.md)|Returns the inverse hyperbolic sine of a number.|  
|[Math.atan Function](../../javascript/reference/math-atan-function-javascript.md)|Returns the arctangent of a number.|  
|[Math.atan2 Function](../../javascript/reference/math-atan2-function-javascript.md)|Returns the angle (in radians) from the X axis to a point represented by the supplied y and x coordinates.|  
|[Math.atanh Function](../../javascript/reference/math-atanh-function-javascript.md)|Returns the inverse hyperbolic tangent of a number.|  
|[Math.ceil Function](../../javascript/reference/math-ceil-function-javascript.md)|Returns the smallest integer that is greater than or equal to the supplied numeric expression.|  
|[Math.cos Function](../../javascript/reference/math-cos-function-javascript.md)|Returns the cosine of a number.|  
|[Math.cosh Function](../../javascript/reference/math-cosh-function-javascript.md)|Returns the hyperbolic cosine of a number.|  
|[Math.exp Function](../../javascript/reference/math-exp-function-javascript.md)|Returns *e* (the base of natural logarithms) raised to a power.|  
|[Math.expm1 Function](../../javascript/reference/math-expm1-function-javascript.md)|Returns the result of subtracting 1 from e (the base of the natural logarithms) raised to a power).|  
|[Math.floor Function](../../javascript/reference/math-floor-function-javascript.md)|Returns the greatest integer that is less than or equal to the supplied numeric expression.|  
|[Math.hypot Function](../../javascript/reference/math-hypot-function-javascript.md)|Returns the square root of the sum of the squares of the arguments.|  
|[Math.imul Function](../../javascript/reference/math-imul-function-javascript.md)|Returns the product of two numbers that are treated as 32-bit signed integers.|  
|[Math.log Function](../../javascript/reference/math-log-function-javascript.md)|Returns the natural logarithm of a number.|  
|[Math.log1p Function](../../javascript/reference/math-log1p-function-javascript.md)|Returns the natural logarithm of 1 + a number.|  
|[Math.log10 Function](../../javascript/reference/math-log10-function-javascript.md)|Returns the base 10 logarithm of a number.|  
|[Math.log2 Function](../../javascript/reference/math-log2-function-javascript.md)|Returns the base 2 logarithm of a number.|  
|[Math.max Function](../../javascript/reference/math-max-function-javascript.md)|Returns the greater of two supplied numeric expressions.|  
|[Math.min Function](../../javascript/reference/math-min-function-javascript.md)|Returns the lesser of two supplied numbers.|  
|[Math.pow Function](../../javascript/reference/math-pow-function-javascript.md)|Returns the value of a base expression raised to a specified power.|  
|[Math.random Function](../../javascript/reference/math-random-function-javascript.md)|Returns a pseudorandom number between 0 and 1.|  
|[Math.round Function](../../javascript/reference/math-round-function-javascript.md)|Returns a specified numeric expression rounded to the nearest integer.|  
|[Math.sign Function](../../javascript/reference/math-sign-function-javascript.md)|Returns the sign of a number, indicating whether the number is positive, negative, or 0.|  
|[Math.sin Function](../../javascript/reference/math-sin-function-javascript.md)|Returns the sine of a number.|  
|[Math.sinh Function](../../javascript/reference/math-sinh-function-javascript.md)|Returns the inverse hyperbolic sine of a number.|  
|[Math.sqrt Function](../../javascript/reference/math-sqrt-function-javascript.md)|Returns the square root of a number.|  
|[Math.tan Function](../../javascript/reference/math-tan-function-javascript.md)|Returns the tangent of a number.|  
|[Math.tanh Function](../../javascript/reference/math-tanh-function-javascript.md)|Returns the hyperbolic tangent of a number.|  
|[Math.trunc Function](../../javascript/reference/math-trunc-function-javascript.md)|Returns the integer portion of a number, removing any fractional digits.|  
  
## See Also  
 [JavaScript Objects](../../javascript/reference/javascript-objects.md)   
 [Number Object](../../javascript/reference/number-object-javascript.md)