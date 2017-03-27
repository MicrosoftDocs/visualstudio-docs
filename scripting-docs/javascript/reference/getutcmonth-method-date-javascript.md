---
title: "getUTCMonth Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getUTCMonth"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, UTC"
  - "UTC dates, returning"
  - "Month method"
  - "getUTCMonth method"
ms.assetid: eabae139-4da0-4e4a-a4cb-608e6375fc9e
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getUTCMonth Method (Date) (JavaScript)
Gets the month of a `Date` object using Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getUTCMonth()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns an integer between 0 (January) and 11 (December).  
  
## Remarks  
 To get the month in local time, use the **getMonth** method.  
  
## Example  
 The following example shows how to use the `getUTCMonth` method.  
  
```JavaScript  
var date = new Date("2/2/2002");  
document.write(date.getUTCMonth());  
  
// Output: 1  
  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getMonth Method (Date)](../../javascript/reference/getmonth-method-date-javascript.md)   
 [setMonth Method (Date)](../../javascript/reference/setmonth-method-date-javascript.md)   
 [setUTCMonth Method (Date)](../../javascript/reference/setutcmonth-method-date-javascript.md)