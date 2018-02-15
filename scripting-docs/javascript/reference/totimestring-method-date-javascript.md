---
title: "toTimeString Method (Date) (JavaScript) | Microsoft Docs"
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
  - "toTimeString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toTimeString method"
ms.assetid: a4a8c0f2-55a9-4e84-94c3-f0a547fb04b5
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toTimeString Method (Date) (JavaScript)
Returns a time as a string value.  
  
## Syntax  
  
```  
  
objDate. toTimeString( )  
```  
  
## Remarks  
 The required `objDate` reference is a `Date` object.  
  
 The `toTimeString` method returns a string value containing the time in the current time zone.  
  
## Example  
 In the following example, the time is set to 2000 milliseconds after midnight January 1, 1970 UTC, and then it is written out.  
  
```JavaScript  
var aDate = new Date();  
     aDate.setTime(2000);  
     document.write(aDate.toTimeString());  
  
// Output depends on the time in the current time zone.  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [toDateString Method (Date)](../../javascript/reference/todatestring-method-date-javascript.md)   
 [toLocaleTimeString Method (Date)](../../javascript/reference/tolocaletimestring-method-date-javascript.md)