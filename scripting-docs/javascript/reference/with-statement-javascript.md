---
title: "with Statement (JavaScript) | Microsoft Docs"
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
  - "with_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "With statement"
ms.assetid: 892c7621-ae9e-4c10-8adb-05532274b1ca
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# with Statement (JavaScript)
Establishes the default object for a statement.  
  
## Syntax  
  
```  
with (object) {  
    statements  
}   
```  
  
## Parameters  
 `object`  
 The default object.  
  
 `statements`  
 One or more statements for which `object` is the default object.  
  
## Remarks  
 The `with` statement is commonly used to shorten the amount of code that you have to write in certain situations.  
  
> [!WARNING]
>  The use of `with` is not allowed in strict mode. The use of `with` can make code harder to read and to debug and should generally be avoided.  
  
## Example  
 In this example, the `Math` object is used repeatedly:  
  
```javascript  
x = Math.cos(3 * Math.PI) + Math.sin(Math.LN10)   
y = Math.tan(14 * Math.E)  
```  
  
## Example  
 If you rewrite the example to use the `with` statement, your code becomes more succinct:  
  
```javascript  
with (Math){  
   x = cos(3 * PI) + sin (LN10)    
   y = tan(14 * E)  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [this Statement](../../javascript/reference/this-statement-javascript.md)