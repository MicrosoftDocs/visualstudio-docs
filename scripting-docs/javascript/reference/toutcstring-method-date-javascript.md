---
title: "toUTCString Method (Date) (JavaScript) | Microsoft Docs"
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
  - "toUTCString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "UTC dates, converting to strings"
  - "toUTCString method"
ms.assetid: eb0983ed-7884-42fa-a2cc-de92b3111207
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toUTCString Method (Date) (JavaScript)
Returns a date converted to a string using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.toUTCString()   
```  
  
## Remarks  
 The required `dateObj` reference is any `Date` object.  
  
 The `toUTCString` method returns a `String` object that contains the date formatted using UTC convention in a convenient, easily read form.  
  
## Example  
 The following example illustrates the use of the `toUTCString` method.  
  
```JavaScript  
function toUTCStrDemo(){  
   var d, s;                   //Declare variables.  
   d = new Date();             //Create Date object.  
   s = "Current setting is ";  
   s += d.toUTCString();       //Convert to UTC string.  
   return(s);                  //Return UTC string.  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [toGMTString Method (Date)](../../javascript/reference/togmtstring-method-date-javascript.md)