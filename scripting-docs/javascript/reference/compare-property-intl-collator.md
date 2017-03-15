---
title: "compare Property (Intl.Collator) | Microsoft Docs"
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
ms.assetid: 59f274dc-6e52-4344-8d5c-b9f0000b66e0
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# compare Property (Intl.Collator)
Returns a function that compares two strings by using the collator’s sort order.  
  
## Syntax  
  
```JavaScript  
collatorObj.compare  
```  
  
#### Parameters  
 `collatorObj`  
 Required. The name of the `Collator` object to use for the comparison.  
  
## Remarks  
 The function returned by the `compare` property takes two arguments, `x` and `y`, and returns the result of a locale-specific comparison of `x` and `y` by using the options specified in the `Collator` object.  
  
 The result of the comparison will be:  
  
-   -1 if `x` is before `y` in the sort order.  
  
-   0 (zero) if `x` is equal to `y` in the sort order.  
  
-   1 if `x` is after `y` in the sort order.  
  
## Example  
 The following example creates a `Collator` object and performs a comparison.  
  
```JavaScript  
var co = new Intl.Collator(["de-DE-u-co-phonebk"]);  
  
if (console && console.log) {  
    console.log(co.compare("a", "b")); // Returns -1  
}  
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
 The following example uses a `Collator` object to search for a string.  
  
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
 [Intl.Collator Object](../../javascript/reference/intl-collator-object-javascript.md)