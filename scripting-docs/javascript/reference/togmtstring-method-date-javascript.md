---
title: "toGMTString Method (Date) (JavaScript) | Microsoft Docs"
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
  - "toGMTString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toGMTString method"
ms.assetid: 9dc1e722-5722-4b8c-a213-a2650f55f207
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toGMTString Method (Date) (JavaScript)
Returns a date converted to a string using Greenwich Mean Time(GMT).  
  
## Syntax  
  
```  
  
dateObj.toGMTString()   
```  
  
## Remarks  
 The required `dateObj` reference is any `Date` object.  
  
 The `toGMTString` method is obsolete, and is provided for backwards compatibility only. It is recommended that you use the `toUTCString` method instead.  
  
 The `toGMTString` method returns a `String` object that contains the date formatted using GMT convention. The format of the return value is as follows: "05 Jan 1996 00:00:00 GMT."  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [toUTCString Method (Date)](../../javascript/reference/toutcstring-method-date-javascript.md)