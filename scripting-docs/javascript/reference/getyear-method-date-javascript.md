---
title: "getYear Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getYear"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "dates, returning year"
  - "GetYear method"
ms.assetid: 0e23e832-acd4-49a9-a175-515d0094f172
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getYear Method (Date) (JavaScript)
Gets the year of a `Date` object.  
  
## Syntax  
  
```  
  
dateObj.getYear()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns the year.  
  
## Remarks  
  
> [!IMPORTANT]
>  This method is obsolete, and is provided for backward compatibility only. Use the `getFullYear` method instead.  
  
 In [!INCLUDE[jsv1textspecific](../../javascript/reference/includes/jsv1textspecific-md.md)], and then in Internet Explorer versions starting with [!INCLUDE[jsv9textspecific](../../javascript/reference/includes/jsv9textspecific-md.md)], the value returned is the stored year minus 1900. For example, the year 1899 is returned as -1 and the year 2000 is returned as 100.  
  
 In [!INCLUDE[jsv3textspecific](../../javascript/reference/includes/jsv3textspecific-md.md)] through [!INCLUDE[jsv58textspecific](../../javascript/reference/includes/jsv58textspecific-md.md)], the formula depends on the year. For the years 1900 through 1999, the value returned is a 2-digit value that is the stored year minus 1900. For dates outside that range, the 4-digit year is returned. For example, 1996 is returned as 96, but 1825 and 2025 are returned as is.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getFullYear Method (Date)](../../javascript/reference/getfullyear-method-date-javascript.md)   
 [getUTCFullYear Method (Date)](../../javascript/reference/getutcfullyear-method-date-javascript.md)   
 [setFullYear Method (Date)](../../javascript/reference/setfullyear-method-date-javascript.md)   
 [setUTCFullYear Method (Date)](../../javascript/reference/setutcfullyear-method-date-javascript.md)   
 [setYear Method (Date)](../../javascript/reference/setyear-method-date-javascript.md)