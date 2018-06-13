---
title: "typeof Operator (JavaScript) | Microsoft Docs"
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
  - "typeof_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "typeof operator"
ms.assetid: ee8a1036-119f-486f-b034-b07bdba87f0c
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# typeof Operator (JavaScript)
Returns a string that identifies the data type of an expression.  
  
## Syntax  
  
```  
  
typeof[(]expression[)] ;  
```  
  
## Remarks  
 The *expression* argument is any expression for which type information is sought.  
  
 The `typeof` operator returns type information as a string. There are seven possible values that `typeof` returns: "number," "string," "boolean," "object," "function," "undefined," and "unknown".  
  
 The parentheses are optional in the `typeof` syntax.  

 An object might return as an unknown type in an XMLHTTPRequest. A COM object with no analog in JavaScript may also return as an unknown type.
  
## Example  
 The following example tests the data type of variables.  
  
```JavaScript  
var index = 5;  
var result = (typeof index === 'number');  
// Output: true  
  
var description = "abc";  
var result = (typeof description === 'string');  
// Output: true  
```  
  
## Example  
 The following example tests for a data type of `undefined` for declared and undeclared variables.  
  
```JavaScript  
var declared;  
var result = (declared === undefined);  
// Output: true  
  
var result = (typeof declared === 'undefined');  
// Output: true  
  
var result = (typeof notDeclared === 'undefined')  
// Output: true  
  
var obj = {};  
var result = (typeof obj.propNotDeclared === 'undefined');  
// Output: true  
  
// An undeclared variable cannot be used in a comparison without  
// the typeof operator, so the next line generates an error.  
//  var result = (notDeclared === undefined);  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [Array.isArray Function](../../javascript/reference/array-isarray-function-javascript.md)   
 [Object.getPrototypeOf Function](../../javascript/reference/object-getprototypeof-function-javascript.md)   
 [undefined Constant](../../javascript/reference/undefined-constant-javascript.md)   
 [Comparison Operators](../../javascript/reference/comparison-operators-javascript.md)   
 [Data Types](../../javascript/data-types-javascript.md)   
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)