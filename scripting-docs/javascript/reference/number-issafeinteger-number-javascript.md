---
title: "Number.isSafeInteger (Number) (JavaScript) | Microsoft Docs"
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
ms.assetid: c7ef6ce8-fe71-4e53-be44-4dd440aef21d
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Number.isSafeInteger (Number) (JavaScript)
Returns a Boolean value that indicates whether a number can be safely represented in JavaScript.  
  
## Syntax  
  
```  
Number.isSafeInteger(numValue)   
```  
  
## Return Value  
 `true` if the number is between `Number.MIN_SAFE_INTEGER` and `Number.MAX_SAFE_INTEGER`, inclusive; otherwise `false`.  
  
## Remarks  
 A safe integer in JavaScript is one that is an IEEE-754 double precisions number before any rounding has been applied.  
  
## Example  
  
```JavaScript  
// Returns true  
Number.isSafeInteger(-100)  
Number.isSafeInteger(9007199254740991)  
  
// Returns false  
Number.isSafeInteger(Number.NaN)  
Number.isSafeInteger(Infinity)  
Number.isSafeInteger("100")  
Number.isSafeInteger(9007199254740992);  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]  
  
 **Applies To**: [Number Object](../../javascript/reference/number-object-javascript.md)