---
title: "format Property (Intl.NumberFormat) | Microsoft Docs"
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
ms.assetid: 68c3223a-023c-4fa0-aa99-d049a7a0e26a
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# format Property (Intl.NumberFormat)
Returns a function that formats a locale-specific number by using the specified number formatter settings.  
  
## Syntax  
  
```  
numberFormatObj.format  
```  
  
#### Parameters  
 `numberFormatObj`  
 Required. The name of the `NumberFormat` object to use as a formatter.  
  
## Remarks  
 The function returned by the `format` property takes a single argument, `value`, and returns a string that represents the localized number by using the options specified in the `NumberFormat` object. If `value` is not provided, the function returns `NaN` (not a number).  
  
## Example  
 The following example uses a `NumberFormat` object to create a localized number.  
  
```JavaScript  
var nf = new Intl.NumberFormat(["en-US"], {  
    style: "currency",  
    currency: "CNY",  
    currencyDisplay: "symbol",  
    maximumFractionDigits: 1  
})  
  
if (console && console.log) {  
    console.log(nf.format(100)); // "¥100.00"  
}  
  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [Intl.NumberFormat Object](../../javascript/reference/intl-numberformat-object-javascript.md)