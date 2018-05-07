---
title: "trim Method (String) (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "trim method"
ms.assetid: 03d38c7e-25cd-4ede-b58e-1a10b5249bab
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# trim Method (String) (JavaScript)
Removes the leading and trailing white space and line terminator characters from a string.  
  
## Syntax  
  
```  
  
stringObj.trim()  
```  
  
## Parameters  
 `stringObj`  
 Required. A `String` object or string literal. This string is not modified by the `trim` method.  
  
## Return Value  
 The original string with leading and trailing white space and line terminator characters removed.  
  
## Remarks  
 The characters that are removed include space, tab, form feed, carriage return, and line feed. See [Special Characters](../../javascript/advanced/special-characters-javascript.md) for a comprehensive list of white space and line terminator characters.  
  
 For an example that shows how to implement your own trim method, see [Prototypes and Prototype Inheritance](../../javascript/advanced/prototypes-and-prototype-inheritance.md).  
  
## Example  
 The following example illustrates the use of the `trim` method.  
  
```JavaScript  
var message = "    abc def     \r\n  ";  
  
document.write("[" + message.trim() + "]");  
document.write("<br/>");  
document.write("length: " + message.trim().length);  
  
// Output:  
//  [abc def]  
//  length: 7  
```  
  
## Requirements  
 [!INCLUDE[jsv9](../../javascript/includes/jsv9-md.md)]  
  
## See Also  
 [Special Characters](../../javascript/advanced/special-characters-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)   
 [Scrolling, panning, and zooming sample app](http://code.msdn.microsoft.com/ie/Scrolling-panning-and-6834aaf9)