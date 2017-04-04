---
title: "Spread Operator (...) (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
ms.assetid: 10263a4c-bd27-4d87-9917-fb4b6bf373db
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Spread Operator (...) (JavaScript)
Allows parts of an array literal to be initialized from an iterable expression (such as another array literal), or allows an expression to be expanded to multiple arguments (in function calls).  
  
## Syntax  
  
```  
var array = [[arg0ToN ,] ...iterable [, arg0ToN]]  
func([args ,] ...iterable [, args | ...iterable])  
  
```  
  
## Parameters  
 `iterable`  
 Required. An iterable object.  
  
 `arg0ToN`  
 Optional. One or more elements of an array literal.  
  
 `args`  
 Optional. One or more arguments to a function.  
  
## Remarks  
 For more information on iterators, see [Iterators and Generators](../../javascript/advanced/iterators-and-generators-javascript.md). For more information on using the spread operator as a rest parameter, see [Functions](../../javascript/functions-javascript.md).  
  
## Example  
 In this following code example, the use of the spread operator is contrasted with the use of the `concat` method.  
  
```JavaScript  
var a, b, c, d, e;  
a = [1,2,3];  
b = "dog";  
c = [42, "cat"];  
  
// Using the concat method.  
d = a.concat(b, c);  
  
// Using the spread operator.  
e = [...a, b, ...c];  
  
console.log(d);  
console.log(e);  
  
// Output:  
// 1, 2, 3, "dog", 42, "cat"  
// 1, 2, 3, "dog", 42, "cat"  
```  
  
## Example  
 The following code example shows how to use the spread operator in a function call. In this example, two array literals are passed to the function using the spread operator, and the arrays are expanded to multiple arguments.  
  
```JavaScript  
function f(a, b, c, x, y, z) {  
  return a + b + c + x + y + z;  
}  
  
var args = [1, 2, 3];  
console.log(f(...args, 4, ...[5, 6]));  
  
// Output:  
// 21  
  
```  
  
## Example  
 With spread operators, you can simplify code that previously required the use of `apply`.  
  
```JavaScript  
function f(x, y, z) {  
    return x + y + z;  
}  
  
var args = [1, 2, 3];  
  
// Old method  
func.apply(this, args);  
// New method  
func(...args);  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [Operator Precedence](../../javascript/operator-subtractprecedence-javascript.md)   
 [Operator Summary (JavaScript)](../../javascript/misc/operator-subtractsummary-javascript.md)