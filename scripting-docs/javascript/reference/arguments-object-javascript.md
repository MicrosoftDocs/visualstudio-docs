---
title: "arguments Object (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "arguments, arguments object"
  - "arguments object"
ms.assetid: 5eb79ca9-bbb8-4a42-aaf5-16a93ecb425f
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# arguments Object (JavaScript)
An object representing the arguments to the currently executing function, and the functions that called it.  
  
## Syntax  
  
```  
[function.]arguments[n]  
```  
  
## Parameters  
 *function*  
 Optional. The name of the currently executing `Function` object.  
  
 *n*  
 Required. The zero-based index to argument values passed to the `Function` object.  
  
## Remarks  
 You cannot explicitly create an **arguments** object. The **arguments** object only becomes available when a function begins execution. The **arguments** object of the function is not an array, but the individual arguments are accessed the same way array elements are accessed. The index *n* is actually a reference to one of the **0** ***n*** properties of the **arguments** object.  
  
## Example  
 The following example illustrates the use of the **arguments** object.  
  
```JavaScript  
function ArgTest(a, b)  
{  
   var s = "";  
  
   s += "Expected Arguments: " + ArgTest.length;  
   s += "<br />";  
   s += "Passed Arguments: " + arguments.length;  
   s += "<br />";  
  
   s += "The individual arguments are: "  
   for (n = 0; n < arguments.length; n++)  
   {  
      s += ArgTest.arguments[n];  
      s += " ";  
   }  
  
   document.write(s);  
}  
  
ArgTest(1, 2, "hello", new Date())  
  
// Output:  
// Expected Arguments: 2  
// Passed Arguments: 4  
// The individual arguments are: 1 2 hello Tues Jan 8 08:27:09 PST 20xx  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [0...n Properties (arguments)](../../javascript/reference/0-dot-dot-dot-n-properties-arguments-javascript.md)   
 [callee Property (arguments)](../../javascript/reference/callee-property-arguments-javascript.md)   
 [length Property (arguments)](../../javascript/reference/length-property-arguments-javascript.md)