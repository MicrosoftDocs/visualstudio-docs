---
title: "arguments Property (Function) (JavaScript) | Microsoft Docs"
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
  - "arguments"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "arguments, arguments property"
  - "Arguments property"
ms.assetid: efc7a1ee-0880-4f05-b0f2-808f31a4af1d
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# arguments Property (Function) (JavaScript)
Gets the arguments for the currently executing `Function` object.  
  
## Syntax  
  
```  
  
function.arguments  
```  
  
## Remarks  
 The `function` argument is the name of the currently executing function, and can be omitted.  
  
 This property allows a function to handle a variable number of arguments. The **length** property of the `arguments` object contains the number of arguments passed to the function. The individual arguments contained in the `arguments` object can be accessed in the same way array elements are accessed.  
  
## Example  
 The following example illustrates the use of the `arguments` property:  
  
```javascript  
function ArgTest(arg1, arg2){  
   var s = "";  
   s += "The individual arguments are: "  
   for (n = 0; n < arguments.length; n++){  
      s += ArgTest.arguments[n];  
      s += " ";  
   }  
   return(s);  
}  
document.write(ArgTest(1, 2, "hello"));  
  
//Output: function ArgTest(arg1, arg2){  
   var s = "";  
   s += "The individual arguments are: "  
   for (n = 0; n < arguments.length; n++){  
      s += ArgTest.arguments[n];  
      s += " ";  
   }  
   return(s);  
}  
document.write(ArgTest(1, 2, "hello"));  
  
// Output: The individual arguments are: 1 2 hello  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [arguments Object](../../javascript/reference/arguments-object-javascript.md)   
 [function Statement](../../javascript/reference/function-statement-javascript.md)