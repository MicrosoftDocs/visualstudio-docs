---
title: "toLocaleString Method (Object) (JavaScript) | Microsoft Docs"
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
  - "toLocaleString"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "toLocaleString method"
ms.assetid: 0901afcb-126b-4ed7-bd6a-2301d50e2326
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleString Method (Object) (JavaScript)
Returns a date converted to a string using the current locale.  
  
## Syntax  
  
```  
  
dateObj.toLocaleString()   
```  
  
## Remarks  
 The required `dateObj` is any `Date` object.  
  
 The `toLocaleString` method returns a `String` object that contains the date written in the current locale's long default format.  
  
-   For dates between 1601 and 1999 A.D., the date is formatted according to the user's Control Panel Regional Settings.  
  
-   For dates outside this range, the default format of the **toString** method is used.  
  
 For example, in the United States, `toLocaleString` returns "01/05/96 00:00:00" for January 5. In Europe, it returns "05/01/96 00:00:00" for the same date, as European convention puts the day before the month.  
  
> [!NOTE]
>  `toLocaleString` should only be used to display results to a user; it should never be used as the basis for computation within a script as the returned result is machine-specific.  
  
## Example  
 The following example illustrates the use of the `toLocaleString` method.  
  
```JavaScript  
function toLocaleStrDemo(){     
   var d, s;                      //Declare variables.  
   d = new Date();                //Create Date object.  
   s = "Current setting is ";  
   s += d.toLocaleString();       //Convert to current locale.  
   return(s);                     //Return converted date  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Array Object](../../javascript/reference/array-object-javascript.md)&#124; [Date Object](../../javascript/reference/date-object-javascript.md)&#124; [Number Object](../../javascript/reference/number-object-javascript.md)&#124; [Object Object](../../javascript/reference/object-object-javascript.md)  
  
## See Also  
 [toLocaleDateString Method (Date)](../../javascript/reference/tolocaledatestring-method-date-javascript.md)