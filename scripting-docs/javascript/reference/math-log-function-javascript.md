---
title: "Math.log Function (JavaScript) | Microsoft Docs"
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
  - "log"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "log method"
  - "Math object"
ms.assetid: 5d617fb5-4b27-404e-842f-eea5549a7c1a
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Math.log Function (JavaScript)
Returns the natural logarithm (base `e`) of a number.  
  
## Syntax  
  
```  
Math.log(number)   
```  
  
#### Parameters  
 number  
 A number.  
  
## Return Value  
 If `number` is positive, this function returns the natural logarithm of the number. If `number` is negative, this function returns `NaN`. If `number` is 0, this function returns `-Infinity`.  
  
## Example  
 The following code shows how to use this function.  
  
```JavaScript  
var numArr = [ 45.3, 69.0, 557.04, 0.222 ];  
  
for (i in numArr) {  
    document.write(Math.log(numArr[i]));  
    document.write("<br/>");  
}  
  
// Output:   
// 3.8133070324889884  
// 4.23410650459726  
// 6.322637050634291  
// -1.5050778971098575  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Math Object](../../javascript/reference/math-object-javascript.md)  
  
## See Also  
 [Math.sqrt Function](../../javascript/reference/math-sqrt-function-javascript.md)