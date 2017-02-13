---
title: "localeCompare Method (String) (JavaScript) | Microsoft Docs"
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
  - "localeCompare"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "localeCompare method"
ms.assetid: 66914079-12dd-4393-a84c-c05f58231c36
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# localeCompare Method (String) (JavaScript)
Determines whether two strings are equivalent in the current locale.  
  
## Syntax  
  
```  
  
stringVar.localeCompare(stringExp[, locales][, options])   
```  
  
## Parameters  
 `stringVar`  
 Required. The first string to compare.  
  
 `stringExp`  
 Required. The second string to compare.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used. This parameter must conform to [BCP 47](http://tools.ietf.org/html/rfc5646) standards; see the [Intl.Collator object](../../javascript/reference/intl-collator-object-javascript.md) for details.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options. see the [Intl.Collator object](../../javascript/reference/intl-collator-object-javascript.md) for details.  
  
## Remarks  
 For the comparison strings, you may specify either `String` objects or string literals.  
  
 Starting in Internet Explorer 11, `localeCompare` uses the `Intl.Collator` object internally to make comparisons, which adds support for the `locales` and `options` parameters. For more information about these parameters, see [Intl.Collator](../../javascript/reference/intl-collator-object-javascript.md) and [Intl.Collator.compare](../../javascript/reference/compare-property-intl-collator.md).  
  
> [!IMPORTANT]
>  The `locales` and `options` parameters are not supported in all document modes and browser versions. For more information, see the Requirements section.  
  
 The `localeCompare` method performs a locale-sensitive string comparison of `stringVar` and `stringExp` and returns  one of the following results, depending on the sort order of the system default locale:  
  
-   -1 if `stringVar` sorts before `stringExp`.  
  
-   +1 if `stringVar` sorts after `stringExp`.  
  
-   0 (zero) if the two strings are equivalent.  
  
## Example  
 The following code shows how to use `localeCompare`.  
  
```javascript  
var str1 = "def";  
var str2 = "abc"  
  
document.write(str1.localeCompare(str2) + "<br/>");  
  
// Output: 1  
var str3 = "ghi";  
  
document.write(str1.localeCompare(str3)+ "<br/>");  
  
// Output: -1  
var str4 = "def";  
  
document.write(str1.localeCompare(str4));  
  
// Output: 0  
```  
  
## Example  
 The following code shows how to use `localeCompare` with the German (Germany) locale.  
  
```javascript  
var str1 = "a";  
var str2 = "b";  
  
document.write(str1.localeCompare(str2, "de-DE"));  
  
// Output  
// - 1  
```  
  
## Example  
 The following example shows how to use `localeCompare` with the German (Germany) locale and a locale-specific extension that specifies the sort order for German phone books. This example shows locale-specific differences.  
  
```javascript  
var arr = ["ä", "ad", "af", "a"];  
  
document.write(arr[0].localeCompare(arr[1], "de-DE-u-co-phonebk"));  // Returns 1  
document.write (arr[0].localeCompare(arr[2], "de-DE-u-co-phonebk"));  // Returns -1  
document.write (arr[0].localeCompare(arr[3], "de-DE-u-co-phonebk"));  // Returns 1  
  
document.write (arr[0].localeCompare(arr[1], "de-DE"));  // Returns -1  
document.write (arr[0].localeCompare(arr[2], "de-DE"));  // Returns -1  
document.write (arr[0].localeCompare(arr[3], "de-DE"));  // Returns 1  
  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 `locales` and `options` parameters:  
  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [toLocaleString Method (Object)](../../javascript/reference/tolocalestring-method-object-javascript.md)