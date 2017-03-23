---
title: "toString Method (Date) | Microsoft Docs"
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
ms.assetid: d3037289-d805-409b-8781-045c59a2c404
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toString Method (Date)
Returns a string representation of a date. The format of the string depends on the locale. For U.S. English (en-us), it is as follows:  
  
 *day of the week* *month* *day* *hour*: *minute*:*second* *time zone* *year*  
  
## Syntax  
  
```  
  
date.toString()  
```  
  
## Parameters  
 `date`  
 Required. The date to represent as a string.  
  
## Return Value  
 Returns the string representation of the date.  
  
## Example  
 The following example illustrates the use of the `toString` method with a date.  
  
```JavaScript  
var myDate = new Date();  
myDate.setFullYear(2100, 5, 5);  
var dateString = myDate.toString();  
document.write(dateString);  
  
// Output: <date>  
  
```  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]