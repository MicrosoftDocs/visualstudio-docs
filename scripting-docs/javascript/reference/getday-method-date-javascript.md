---
title: "getDay Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getDay"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "GetDay method"
  - "Date object"
  - "dates, returning day of the week"
ms.assetid: 27be7168-3dce-41c9-ae69-6280b7984c2e
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getDay Method (Date) (JavaScript)
Gets the day of the week, using local time.  
  
## Syntax  
  
```  
  
dateObj. getDay()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 An integer between 0 and 6 representing the day of the week (Sunday is 0, Saturday is 6).  
  
## Remarks  
 To get the day using Universal Coordinated Time (UTC), use the `getUTCDay` method.  
  
 The following example shows how to use the `getDay` method.  
  
```JavaScript  
var date = new Date("Saturday, February 9, 2008");  
day = date.getDay();  
document.write(day);  
  
// Output: 6  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getUTCDay Method (Date)](../../javascript/reference/getutcday-method-date-javascript.md)