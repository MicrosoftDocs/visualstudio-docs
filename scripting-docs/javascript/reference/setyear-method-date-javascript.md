---
title: "setYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "setYear"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "Year method"
  - "setYear method"
ms.assetid: 36431050-e0ec-45ee-830d-0d7c20e207ea
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# setYear Method (Date) (JavaScript)
Sets the year value in the `Date` object.  
  
## Syntax  
  
```  
  
dateObj.setYear(numYear)   
```  
  
## Parameters  
 `dateObj`  
 Required. Any `Date` object.  
  
 `numYear`  
 Required. For the years 1900 through 1999, this is a numeric value equal to the year minus 1900. For dates outside that range, this is a 4-digit numeric value.  
  
## Remarks  
 This method is obsolete, and is maintained for backwards compatibility only. Use the `setFullYear` method instead.  
  
 To set the year of a `Date` object to 1997, call **setYear(97)**. To set the year to 2010, call **setYear(2010)**. Finally, to set the year to a year in the range 0-99, use the `setFullYear` method.  
  
> [!NOTE]
>  For [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] version 1.0, `setYear` uses a value that is the result of the addition of 1900 to the year value provided by `numYear`, regardless of the value of the year. For example, to set the year to 1899 `numYear` is -1 and to set the year 2000 `numYear` is 100.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getFullYear Method (Date)](../../javascript/reference/getfullyear-method-date-javascript.md)   
 [getUTCFullYear Method (Date)](../../javascript/reference/getutcfullyear-method-date-javascript.md)   
 [getYear Method (Date)](../../javascript/reference/getyear-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)   
 [setUTCFullYear Method (Date)](../../javascript/reference/setutcfullyear-method-date-javascript.md)