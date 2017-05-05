---
title: "getVarDate Method (Date) (JavaScript) | Microsoft Docs"
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
  - "getVarDate"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Date object"
  - "getVarDate method"
  - "dates, VT_DATE format"
ms.assetid: 561238de-5c91-45a3-b839-a16910d3a1cf
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# getVarDate Method (Date) (JavaScript)
Returns a VT_DATE value from a `Date` object.  
  
> [!WARNING]
>  This method is supported in Internet Explorer only.  
  
## Syntax  
  
```  
  
dateObj.getVarDate()   
```  
  
#### Parameters  
 The required `dateObj` reference is a `Date` object.  
  
## Return Value  
 Returns a VT_DATE value.  
  
## Remarks  
 The `getVarDate` method is used when JavaScript code interacts with COM objects, ActiveX objects, or other objects that accept and return date values in VT_DATE format. These include objects in Visual Basic and Visual Basic Scripting Edition (VBScript). The actual format of the returned value depends on regional settings.  
  
## Requirements  
 Supported in the following document modes: Quirks, Internet Explorer 6 standards, Internet Explorer 7 standards, Internet Explorer 8 standards, Internet Explorer 9 standards, and Internet Explorer 10 standards. Not supported in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. See [Version Information](../../javascript/reference/javascript-version-information.md).  
  
 **Applies To**: [Date Object](../../javascript/reference/date-object-javascript.md)  
  
## See Also  
 [getDate Method (Date)](../../javascript/reference/getdate-method-date-javascript.md)   
 [Date.parse Function](../../javascript/reference/date-parse-function-javascript.md)