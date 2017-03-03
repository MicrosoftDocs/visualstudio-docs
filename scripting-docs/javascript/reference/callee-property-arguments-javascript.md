---
title: "callee Property (arguments) (JavaScript) | Microsoft Docs"
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
  - "callee"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "callee property"
ms.assetid: ad9d4d21-73f0-44f6-8bec-502f3456cd23
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# callee Property (arguments) (JavaScript)
Returns the `Function` object being executed, that is, the body text of the specified `Function` object.  
  
## Syntax  
  
```  
[function.]arguments.callee  
```  
  
## Remarks  
 The optional *function* argument is the name of the currently executing `Function` object.  
  
 The `callee` property is a member of the **arguments** object that becomes available only when the associated function is executing.  
  
 The initial value of the `callee` property is the `Function` object being executed. This allows anonymous functions to be recursive.  
  
## Example  
  
```javascript  
function factorial(n){  
  if (n <= 0)  
     return 1;  
  else  
     return n * arguments.callee(n - 1)  
}  
document.write(factorial(4));  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [arguments Object](../../javascript/reference/arguments-object-javascript.md)&#124; [Function Object](../../javascript/reference/function-object-javascript.md)  
  
## See Also  
 [caller Property (Function)](../../javascript/reference/caller-property-function-javascript.md)