---
title: "Intl.Collator Object (JavaScript) | Microsoft Docs"
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
  - "Collator"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: acbb9461-f956-4b5b-ae5f-6a47815ae15c
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Intl.Collator Object (JavaScript)
Provides locale-specific string comparisons.  
  
## Syntax  
  
```  
collatorObj = new Intl.Collator([locales][, options])  
```  
  
#### Parameters  
 `collatorObj`  
 Required. The variable name to assign the `Collator` object to.  
  
 `locales`  
 Optional. An array of locale strings that contain one or more language or locale tags. If you include more than one locale string, list them in descending order of priority so that the first entry is the preferred locale. If you omit this parameter, the default locale of the JavaScript runtime is used. See the Remarks section for more information.  
  
 `options`  
 Optional. An object that contains one or more properties that specify comparison options. See the Remarks section for details.  
  
## Remarks  
 The `locales` parameter must conform to [BCP 47](http://tools.ietf.org/html/rfc5646) language or locale tags such as "en-US" and "zh-Hans-CN". The tag may include language, region, country, and variant. For a list of languages, see the [IANA language subtag registry](http://go.microsoft.com/fwlink/p/?linkid=227303). For examples of language tags, see [Appendix A](http://tools.ietf.org/html/rfc5646#appendix-A) of BCP 47. For `Collator`, you may include the -u extension in the locale string to specify one or more of the following Unicode extensions:  
  
-   -co to specify variant collations (locale-specific): "*language*-*region*-u-co-*value*".  
  
-   -kn to specify a numeric comparison: "*language*-*region*-u-kn-true&#124;false".  
  
-   –kf to specify whether to sort uppercase or lowercase characters first: "*language*-*region*-u-kf-upper&#124;lower&#124;false"). This extension is not currently supported.  
  
 To specify a numeric comparison, you can set the –kn extension in the locale string or use the `numeric` property in the `options` parameter. If you're using the `numeric` property, the –kn value will not apply.  
  
 The `options` parameter may include the following properties:  
  
-   `localeMatcher`. Specifies the locale-matching algorithm to use. The possible values are "lookup" and "best fit". The default value is "best fit".  
  
-   `usage`. Specifies whether the goal of comparison is sorting or searching. The possible values are "sort" and "search". The default value is "sort".  
  
-   `sensitivity`. Specifies the collator’s sensitivity. The possible values are "base", "accent", "case", and "variant". The default value is `undefined`.  
  
-   `ignorePunctuation`. Specifies whether punctuation is ignored in the comparison. The possible values are "true" and "false". The default value is `false`.  
  
-   `numeric`. Specifies whether numeric sorting is used. The possible values are "true" and "false". The default value is `false`.  
  
-   `caseFirst`. Not currently supported.  
  
## Properties  
 The following table lists the properties of the `Collator` object.  
  
|||  
|-|-|  
|Property|Description|  
|[compare](../../javascript/reference/compare-property-intl-collator.md)|Returns a function that compares two strings by using the collator’s sort order.|  
|[constructor](../../javascript/reference/constructor-property-intl-collator.md)|Specifies the function that creates a collator.|  
|[prototype](../../javascript/reference/prototype-property-intl-collator.md)|Returns a reference to the prototype for a collator.|  
  
## Methods  
 The following table lists the methods of the `Collator` object.  
  
|||  
|-|-|  
|Method|Description|  
|[resolvedOptions](../../javascript/reference/resolvedoptions-method-intl-collator.md)|Returns an object that contains the properties and values of the collator.|  
  
## Example  
 The following example creates a `Collator` object and performs a comparison.  
  
```JavaScript  
var co = new Intl.Collator(["de-DE"]);  
co.compare("a", "b"); // Returns -1  
  
```  
  
## Example  
 The following example uses `Collator` objects to sort an array. This example shows locale-specific differences.  
  
```JavaScript  
var co1 = new Intl.Collator(["de-DE-u-co-phonebk"]);  
var co2 = new Intl.Collator(["de-DE"]);  
var co3 = new Intl.Collator(["en-US"]);  
  
var arr = ["ä", "ad", "af", "a"];  
  
if (console && console.log) {  
    console.log(arr.sort(co1.compare));  // Returns a,ad,ä,af  
    console.log(arr.sort(co2.compare));  // Returns a,ä,ad,af  
    console.log(arr.sort(co3.compare));  // Returns a,ä,ad,af  
}  
```  
  
## Example  
 The following example uses a `Collator` object to search for a string and specifies comparison options.  
  
```JavaScript  
// String to search  
var arr = ["ä", "ad", "af", "a"];  
// String searched for  
var s = "af";  
  
var co = new Intl.Collator("de-DE", { usage: "search" });  
var matches = arr.filter(function (i) {  
    return co.compare(i, s) === 0;  
});  
  
if (console && console.log) {  
    console.log(matches);  // Returns af  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv11](../../javascript/reference/includes/jsv11-md.md)]  
  
## See Also  
 [localeCompare Method (String)](../../javascript/reference/localecompare-method-string-javascript.md)   
 [Intl.DateTimeFormat Object](../../javascript/reference/intl-datetimeformat-object-javascript.md)   
 [Intl.NumberFormat Object](../../javascript/reference/intl-numberformat-object-javascript.md)