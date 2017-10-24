---
title: "findIndex Method (Array) (JavaScript) | Microsoft Docs"
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
ms.assetid: 3a200cf0-db67-4c7b-89f8-5e9f5dc1a926
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# findIndex Method (Array) (JavaScript)
Returns an index value for the first array element that meets test criteria specified in a callback function.  
  
## Syntax  
  
```  
arrayObj.findIndex(callbackfn [, thisArg]);  
```  
  
#### Parameters  
 `arrayObj`  
 Required. The array object.  
  
 `callbackfn`  
 Required. The callback function to test each element in the array.  
  
 `thisArg`  
 Optional. Specifies the `this` object in the callback function. If not specified, the `this` object is undefined.  
  
## Remarks  
 The `findIndex` calls the callback function one time for each element in the array, in ascending order, until an element returns `true`. As soon as an element returns true, `findIndex` returns the index value of the element that returns true. If no elements in the array return true, `findIndex` returns -1.  
  
 `findIndex` does not mutate the array object.  
  
## Callback Function Syntax  
 The syntax of the callback function is as follows:  
  
 `function callbackfn(value, index, thisArg)`  
  
 You can declare the callback function by using up to three parameters.  
  
 The callback function parameters are as follows.  
  
|Callback argument|Definition|  
|-----------------------|----------------|  
|`value`|The value of the array element.|  
|`index`|The numeric index of the array element.|  
|`arrayObj`|The array object to be traversed.|  
  
## Example  
 In the following example, the callback function tests whether each element in the array is equal to 2.  
  
```JavaScript  
[1,2,3].findIndex(function(x) { x == 2; });  
// Returns an index value of 1.  
  
```  
  
## Example  
 The following example uses arrow syntax to test each element. In this example, no elements return `true`, and `findIndex` returns -1.  
  
```  
[1,2,3].findIndex(x => x == 4);  
// Returns an index value of -1.   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]