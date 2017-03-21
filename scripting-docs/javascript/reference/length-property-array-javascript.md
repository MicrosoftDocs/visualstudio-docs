---
title: "length Property (Array) (JavaScript) | Microsoft Docs"
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
  - "length Property"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Array object"
  - "Length property"
  - "length property (array)"
ms.assetid: e1c6377c-2e84-440a-9660-f1f512e4a938
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# length Property (Array) (JavaScript)
Gets or sets the length of the array. This is a number one higher than the highest element defined in an array.  
  
## Syntax  
  
```  
  
numVar = arrayObj.length   
```  
  
## Parameters  
 `numVar`  
 Required. Any number.  
  
 `arrayObj`  
 Required. Any `Array` object.  
  
## Remarks  
 In JavaScript arrays are sparse, and the elements in an array do not have to be contiguous. The `length` property is not necessarily the number of elements in the array. For example, in the following array definition, `my_array.length` contains 7, not 2:  
  
```JavaScript  
var my_array = new Array( );  
my_array[0] = "Test";  
my_array[6] = "Another Test";  
```  
  
 If you make the `length` property smaller than its previous value, the array is truncated, and any elements with array indexes equal to or greater than the new value of the `length` property are lost.  
  
 If you make the length property larger than its previous value, the array is expanded, and any new elements created have the value `undefined`.  
  
 The following example illustrates the use of the `length` property:  
  
```JavaScript  
var a;  
a = new Array(0,1,2,3,4);  
document.write(a.length);  
  
// Output  
// 5  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
> [!NOTE]
>  Starting with Internet Explorer 9 Standards mode, trailing commas included in the initialization of an Array are handled differently.