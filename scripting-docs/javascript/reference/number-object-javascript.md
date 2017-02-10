---
title: "Number Object (JavaScript) | Microsoft Docs"
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
  - "Number_JavaScript"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Number object"
ms.assetid: 76e87c37-cf6c-46cc-bafa-04be1fe3d78d
caps.latest.revision: 23
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Number Object (JavaScript)
An object that represents a number of any kind. All JavaScript numbers are 64-bit floating-point numbers.  
  
## Syntax  
  
```  
  
numObj = new Number(value)  
```  
  
## Parameters  
 `numObj`  
 Required. The variable name to which the `Number` object is assigned.  
  
 `value`  
 Required. The numeric value.  
  
## Remarks  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] creates `Number` objects when a variable is set to a number value, for example `var num = 255.336;`. It is seldom necessary to create `Number` objects explicitly.  
  
 The `Number` object has its own properties and methods, in addition to the properties and methods inherited from `Object`. Numbers are converted into strings under certain circumstances, for example when a number is added or concatenated with a string, as well as by means of the `toString` method. For more information, see [Addition Operator (+)](../../javascript/reference/addition-operator-decrement-javascript.md).  
  
 JavaScript has several number constants. For a complete list, see [Number Constants](../../javascript/reference/number-constants-javascript.md).  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## Properties  
 The following table lists the properties of the `Number` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor Property](../../javascript/reference/constructor-property-object-javascript.md)|Specifies the function that creates an object.|  
|[prototype Property](../../javascript/reference/prototype-property-object-javascript.md)|Returns a reference to the prototype for a class of objects.|  
  
## Functions  
 The following table lists the functions of the `Number`  object.  
  
|Function|Description|  
|--------------|-----------------|  
|[Number.isFinite Function](../../javascript/reference/number-isfinite-function-number-javascript.md)|Returns a Boolean value that indicates whether a value is finite.|  
|[Number.isInteger Function](../../javascript/reference/number-isinteger-function-number-javascript.md)|Returns a Boolean value that indicates whether a value is an integer.|  
|[Number.isNaN Function](../../javascript/reference/number-isnan-function-number-javascript.md)|Returns a Boolean value that indicates whether a value is the reserved value `NaN` (not a number).|  
|[Number.isSafeInteger](../../javascript/reference/number-issafeinteger-number-javascript.md)|Returns a Boolean value that indicates whether a value can be safely represented in JavaScript.|  
  
## Methods  
 The following table lists the methods of the `Number`  object.  
  
|Method|Description|  
|------------|-----------------|  
|[hasOwnProperty Method](../../javascript/reference/hasownproperty-method-object-javascript.md)|Returns a Boolean value that indicates whether an object has a property with the specified name.|  
|[isPrototypeOf Method](../../javascript/reference/isprototypeof-method-object-javascript.md)|Returns a Boolean value that indicates whether an object exists in another object's prototype hierarchy.|  
|[propertyIsEnumerable Method](../../javascript/reference/propertyisenumerable-method-object-javascript.md)|Returns a Boolean value that indicates whether a specified property is part of an object and whether it is enumerable.|  
|[toExponential method](../../javascript/reference/toexponential-method-number-javascript.md)|Returns a string that contains a number represented in exponential notation.|  
|[toFixed method](../../javascript/reference/tofixed-method-number-javascript.md)|Returns a string that represents a number in fixed-point notation.|  
|[toLocaleString Method](../../javascript/reference/tolocalestring-number.md)|Returns an object converted to a string based on the current locale.|  
|[toPrecision method](../../javascript/reference/toprecision-method-number-javascript.md)|Returns a string that contains a number that is represented in either exponential or fixed-point notation and that has a specified number of digits.|  
|[toString Method](../../javascript/reference/tostring-method-object-javascript.md)|Returns a string representation of an object.|  
|[valueOf Method](../../javascript/reference/valueof-method-object-javascript.md)|Returns the primitive value of the specified object.|  
  
## See Also  
 [JavaScript Objects](../../javascript/reference/javascript-objects.md)   
 [Math Object](../../javascript/reference/math-object-javascript.md)   
 [new Operator](../../javascript/reference/new-operator-decrementjavascript.md)