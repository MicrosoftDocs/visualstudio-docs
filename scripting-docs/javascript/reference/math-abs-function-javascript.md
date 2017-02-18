---
title: "Math.abs Function (JavaScript) | Microsoft Docs"
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
  - "abs"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "absolute values, calculating"
  - "absolute values"
  - "numeric expressions"
  - "abs method"
ms.assetid: 9af4b5b8-de77-47bb-bb59-abdde371e4c3
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.abs Function (JavaScript)
Returns the absolute value of a number (the value without regard to whether it is positive or negative). For example, the absolute value of -5 is the same as the absolute value of 5.  
  
## Syntax  
  
```  
Math.abs(number)  
```  
  
#### Parameters  
 The required `number` argument is a numeric expression for which the absolute value is needed.  
  
## Return Value  
 The absolute value of the `number` argument.  
  
## Example  
 The following example illustrates the use of the `abs` function.  
  
```javascript  
var s;  
var v1 = Math.abs(6);  
var v2 = Math.abs(-6);  
if (v1 == v2) {  
    document.write("Absolute values are the same.");  
}  
else {  
document.write("Absolute values are different.");  
}  
  
// Output: Absolute values are the same.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## See Also  
 [Math Object](../../javascript/reference/math-object-javascript.md)