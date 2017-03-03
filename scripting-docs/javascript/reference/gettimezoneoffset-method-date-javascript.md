---
title: "getTimezoneOffset Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getTimeZoneOffset"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "getTimezoneOffset method"
  - "time zones [Visual Studio]"
ms.assetid: 58ee22b0-4688-45bd-a337-cc23119b09ce
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getTimezoneOffset Method (Date) (JavaScript)
Gets the difference in minutes between the time on the local computer and Universal Coordinated Time (UTC).  
  
## Syntax  
  
```  
  
dateObj.getTimezoneOffset()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns the number of minutes between the time on the current computer (either the client machine or, if this method is called from a server script, the server machine) and UTC. It is positive if the current computer's local time is behind UTC (e.g., Pacific Daylight Time), and negative if the current computer's local time is ahead of UTC (e.g., Japan). If a server in New York City is contacted by a client in Los Angeles on December 1, `getTimezoneOffset` returns 480 if executed on the client, or 300 if executed on the server.  
  
## Remarks  
  
## Example  
 The following example shows how to use the `getTimezoneOffset` method.  
  
```javascript  
var date =  new Date();  
var minutes = date.getTimezoneOffset();  
  
if (minutes < 0)  
    document.write(minutes / 60 + " hours after UTC");  
else  
    document.write(minutes / 60 + " hours before UTC");  
  
// Output (for example, where local time is PST):   
7 hours before UTC  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getTime Method (Date)](../../javascript/reference/gettime-method-date-javascript.md)