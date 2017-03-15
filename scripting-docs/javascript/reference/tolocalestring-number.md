---
title: "toLocaleString (Number) | Microsoft Docs"
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
ms.assetid: 42c05252-13c1-4943-b1a4-b33285aeab3e
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# toLocaleString (Number)
Converts a number to a string by using the current or specified locale.  
  
## Syntax  
  
```  
  
numberObj.toLocaleString([locales][, options])   
```  
  
#### Parameters  
 `numberObj`  
 Required. The `Number` object to convert.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options.  
  
## Remarks  
 Starting in Internet Explorer 11, `toLocaleString` uses `Intl.NumberFormat` internally to make comparisons, which adds support for the `locales` and `options` parameters. For more information about these parameters, see [Intl.NumberFormat](../../javascript/reference/intl-numberformat-object-javascript.md).  
  
> [!IMPORTANT]
>  The `locales` and `options` parameters are not supported in all document modes and browser versions. For more information, see the Requirements section.  
  
> [!NOTE]
>  If you omit the `locales` parameter, use `toLocaleString` only to display results to a user; never use it to compute values within a script, because the returned result is machine-specific (the method returns the current locale).  
  
## Example  
 The following example shows how to use the `toLocaleString` method with no parameters.  
  
```JavaScript  
var n, s;  
n = new Number(100);  
s = "Current locale value is: ";  
s += n.toLocaleString();                 
document.write(s);  
  
// Output:  
// The value 100 as represented by the current locale.  
```  
  
## Example  
 The following example shows how to use the `toLocaleString` method with a specified locale and comparison options.  
  
```JavaScript  
var number = 123456789;  
var options1 = { style: "percent" };  
var options2 = { style: "currency", currency: "INR" };  
  
document.write(number.toLocaleString("en-US"));  
// 123,456,789  
document.write(number.toLocaleString("ja-JP"));  
// 123,456,789  
document.write(number.toLocaleString("ar-SA", options1));  
// ١٢,٣٤٥,٦٧٨,٩٠٠ %  
document.write(number.toLocaleString("hi-IN", options2));  
// ₹ 12,34,56,789.00  
  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 `locales` and `options` parameters:  
  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toLocaleDateString Method (Date)](../../javascript/reference/tolocaledatestring-method-date-javascript.md)