---
title: "for...of Statement (JavaScript) | Microsoft Docs"
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
ms.assetid: 7872b0b2-5701-4d72-9b52-ed13991542cc
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# for...of Statement (JavaScript)
Executes one or more statements for each value of an iterator obtained from an iterable object.  
  
## Syntax  
  
```  
for (variable of object) {  
    statements   
}  
```  
  
## Parameters  
 `variable`  
 Required. A variable that can be any property value of `object`.  
  
 `object`  
 Required. An iterable object such as an `Array`, `Map`, `Set`, or an object that implements the [iterator interfaces](../../javascript/advanced/iterators-and-generators-javascript.md).  
  
 `statements`  
 Optional. One or more statements to be executed for each value of an `object`. Can be a compound statement.  
  
## Remarks  
 At the beginning of each iteration of a loop, the value of `variable` is the next property value of `object`.  
  
## Example  
 The following example illustrates the use of the `for...of` statement on an array.  
  
```JavaScript  
let arr = [ "fred", "tom", "bob" ];  
  
for (let i of arr) {  
    console.log(i);  
}  
  
// Output:  
// fred  
// tom  
// bob  
  
```  
  
## Example  
 The following example illustrates the use of the `for...of` statement on a `Map` object.  
  
```JavaScript  
var m = new Map();  
m.set(1, "black");  
m.set(2, "red");  
  
for (var n of m) {  
  console.log(n);  
}  
  
// Output:  
// 1,black  
// 2,red  
  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
## See Also  
 [for...in Statement](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md)   
 [for Statement](../../javascript/reference/for-statement-javascript.md)   
 [while Statement](../../javascript/reference/while-statement-javascript.md)