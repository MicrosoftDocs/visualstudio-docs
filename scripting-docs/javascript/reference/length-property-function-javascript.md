---
title: "length Property (Function) (JavaScript) | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Length property"
  - "length property (function)"
ms.assetid: fdc8e1c9-0dac-4e1b-ba3a-11073c37ef63
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# length Property (Function) (JavaScript)
Gets the number of arguments defined for a function.  
  
## Syntax  
  
```  
  
functionName.length  
```  
  
## Remarks  
 The required *functionName* is the name of the function.  
  
 The **length** property of a function is initialized by the scripting engine to the number of arguments in the function's definition when an instance of the function is created.  
  
 What happens when a function is called with a number of arguments different from the value of its **length** property depends on the function.  
  
## Example  
 The following example illustrates the use of the **length** property:  
  
```JavaScript  
function ArgTest(a, b){  
    var s = "";  
  
    s += "Expected Arguments: " + ArgTest.length;  
    s += "<br />";  
    s += "Passed Arguments: " + arguments.length;  
  
    return s;  
}  
  
document.write(ArgTest(1, 2));  
  
// Output:   
// Expected Arguments: 2  
// Passed Arguments: 2  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]  
  
## See Also  
 [arguments Property (Function)](../../javascript/reference/arguments-property-function-javascript.md)   
 [length Property (Array)](../../javascript/reference/length-property-array-javascript.md)   
 [length Property (String)](../../javascript/reference/length-property-string-javascript.md)