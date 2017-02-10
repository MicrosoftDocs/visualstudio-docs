---
title: "normalize Method (String) (JavaScript) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: d50077c1-b5fa-4e7a-9c9d-dc66cfc423ac
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# normalize Method (String) (JavaScript)
Returns the Unicode Normalization Form of a specified string.  
  
## Syntax  
  
```  
stringObj.normalize([form]);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object to test against.  
  
 `form`  
 Optional. The Unicode Normalization Form value.  
  
## Return Value  
 The Unicode Normalization Form of a specified string.  
  
## Exceptions  
 If `form` is an unsupported value, a `RangeError` is thrown.  
  
## Remarks  
 If `stringObj` isn't a string, it will be converted to a string before the method attempts to return the Unicode Normalization Form of the string.  
  
 `form` must be a Unicode Normalization Form value, "NFC", "NFD", "NFKC", or "NFKD", corresponding to values specified for [Unicode Standard Annex #15](http://www.unicode.org/reports/tr15/). The default value of `form` is "NFC".  
  
## Example  
 The following code examples show the use of the `normalize` method.  
  
```javascript  
// ANGSTORM SIGN and LATIN CAPITAL A WITH RING ABOVE is canonically equivalent  
"\u212b".normalize("NFC") === "\u00c5";  
  
// Decomposed, ANGSTOM SIGN is LATIN CAPITAL A followed by COMBINING RING ABOVE  
"\u212b".normalize("NFD") === "\u0041\u030a"  
  
// Normalization Form C will combine the result back into the precombined character  
"\u0041\u030a".normalize("NFC") === "\u00c5"  
  
// LATIN SMALL LIGATURE FI is compatibility equivalent with LATIN SMALL LETTER F followed by  
// LATIN SMALL LETTER I.  
"\ufb01".normalize("NFKD") === "fi";  
  
// Same mapping in NFKC  
"\ufb01".normalize("NFKC") === "fi";  
  
// NFKC will not recombine compatibility characters.  
"fi".normalize("NFKC") === "fi";  
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]