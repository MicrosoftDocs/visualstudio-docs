---
title: "length Property (arguments) (JavaScript) | Microsoft Docs"
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
  - "DHTML"
helpviewer_keywords: 
  - "length property (arguments)"
  - "Length property"
ms.assetid: 3cf36823-15bc-489b-a951-24c4923d9dba
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# length Property (arguments) (JavaScript)
Returns the actual number of arguments passed to a function by the caller.  
  
## Syntax  
  
```  
[function.]arguments.length  
```  
  
## Remarks  
 The optional *function* argument is the name of the currently executing `Function` object.  
  
 The **length** property of the **arguments** object is initialized by the scripting engine to the actual number of arguments passed to a `Function` object when execution begins in that function.  
  
## Example  
 The following example illustrates the use of the **length** property of the **arguments** object. To fully understand the example, pass more arguments to the function than the 2 arguments expected:  
  
```javascript  
function ArgTest(a, b){  
   var s = "";  
  
   s += "Expected Arguments: " + ArgTest.length;  
   s += "<br />";  
   s += "Passed Arguments: " + arguments.length;  
  
   document.write (s);  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [arguments Object](../../javascript/reference/arguments-object-javascript.md)&#124; [Function Object](../../javascript/reference/function-object-javascript.md)  
  
## See Also  
 [arguments Property (Function)](../../javascript/reference/arguments-property-function-javascript.md)   
 [length Property (Array)](../../javascript/reference/length-property-array-javascript.md)   
 [length Property (String)](../../javascript/reference/length-property-string-javascript.md)