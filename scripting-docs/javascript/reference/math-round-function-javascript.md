---
title: "Math.round Function (JavaScript) | Microsoft Docs"
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
  - "round"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Round method"
  - "Math object"
ms.assetid: 51008df3-5d0c-4951-84cb-4f41000db0be
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.round Function (JavaScript)
Returns a supplied numeric expression rounded to the nearest integer.  
  
## Syntax  
  
```  
  
Math.round(  
number  
)   
```  
  
## Remarks  
 The required `number` argument is the value to be rounded to the nearest integer.  
  
 For positive numbers, if the decimal portion of `number` is 0.5 or greater, the return value is equal to the smallest integer greater than `number`. If the decimal portion is less than 0.5, the return value is the largest integer less than or equal to `number`.  
  
 For negative numbers, if the decimal portion is exactly -0.5, the return value is the smallest integer that is greater than the number.  
  
 For example, `Math.round(8.5)` returns 9, but `Math.round(-8.5)` returns -8.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## See Also  
 [Math.random Function](../../javascript/reference/math-random-function-javascript.md)