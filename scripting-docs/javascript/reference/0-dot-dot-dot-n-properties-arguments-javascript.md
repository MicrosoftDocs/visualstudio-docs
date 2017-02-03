---
title: "0...n Properties (arguments) (JavaScript) | Microsoft Docs"
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
  - "0...n"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "0...n properties"
ms.assetid: 52857c4b-3d56-4500-93ff-4db4729c2578
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# 0...n Properties (arguments) (JavaScript)
Returns the actual value of individual arguments from an **arguments** object returned by the **arguments** property of an executing function.  
  
## Syntax  
  
```  
[function.]arguments[[0|1|2|...|n]]  
```  
  
## Parameters  
 *function*  
 Optional. The name of the currently executing `Function` object.  
  
 0, 1, 2, *, n*  
 Required. Non-negative integer in the range of 0 to *n* where 0 represents the first argument and *n* represents the final argument. The value of the final argument *n* is **arguments.length-1**.  
  
## Remarks  
 The values returned by the 0 . . . n properties are the actual values passed to the executing function. While not actually an array of arguments, the individual arguments that comprise the **arguments** object are accessed the same way that array elements are accessed.  
  
## Example  
 The following example illustrates the use of the **0 . . .**  ***n*** properties of the **arguments** object. To fully understand the example, pass one or more arguments to the function:  
  
```javascript  
function ArgTest(){  
   var s = "";  
   s += "The individual arguments are: "  
   for (n = 0; n < arguments.length; n++){  
      s += ArgTest.arguments[n];  
      s += " ";  
   }  
   return(s);  
}  
document.write(ArgTest(1, 2, "hello", new Date()));  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [arguments Object](../../javascript/reference/arguments-object-javascript.md)&#124; [Function Object](../../javascript/reference/function-object-javascript.md)  
  
## See Also  
 [length Property (arguments)](../../javascript/reference/length-property-arguments-javascript.md)   
 [length Property (Function)](../../javascript/reference/length-property-function-javascript.md)