---
title: "caller Property (Function) (JavaScript) | Microsoft Docs"
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
  - "caller"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "caller property"
  - "function calls, functions that are executing"
ms.assetid: ae210853-7160-4102-9cfd-ab489f180ce1
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# caller Property (Function) (JavaScript)
Gets the function that invoked the current function.  
  
## Syntax  
  
```  
  
functionName.caller  
```  
  
## Remarks  
 The `functionName` object is the name of any executing function.  
  
 The `caller` property is defined for a function only while that function is executing. If the function is called from the top level of a [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] program, `caller` contains `null`.  
  
 If the `caller` property is used in a string context, the result is the same as `functionName`.`toString`, that is, the decompiled text of the function is displayed.  
  
 The following example illustrates the use of the `caller` property:  
  
```JavaScript  
function CallLevel(){  
   if (CallLevel.caller == null)  
      return("CallLevel was called from the top level.");  
   else  
      return("CallLevel was called by another function.");  
}  
  
document.write(CallLevel());  
  
// Output: CallLevel was called from the top level.  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [function Statement](../../javascript/reference/function-statement-javascript.md)