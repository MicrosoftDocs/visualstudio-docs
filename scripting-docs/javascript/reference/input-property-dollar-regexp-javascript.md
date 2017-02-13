---
title: "input Property ($_) (RegExp) (JavaScript) | Microsoft Docs"
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
  - "$_"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "input property"
  - "$_ property"
ms.assetid: 88c6d1d8-56f7-4334-a7eb-e899aec9cda4
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# input Property ($_) (RegExp) (JavaScript)
Returns the string against which a regular expression search was performed. Read-only.  
  
## Syntax  
  
```  
  
RegExp.input  
```  
  
## Remarks  
 The object associated with this property is always the global `RegExp` object.  
  
 The value of **input** property is modified any time the searched string is changed.  
  
 The following example illustrates the use of the **input** property:  
  
```javascript  
function inputDemo(){  
   var s;  
   var re = new RegExp("d(b+)(d)","ig");  
   var str = "cdbBdbsbdbdz";  
   var arr = re.exec(str);  
   s = "The string used for the match was " + RegExp.input;   
   return(s);  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [RegExp Object](../../javascript/reference/regexp-object-javascript.md)  
  
## See Also  
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)