---
title: "decodeURIComponent Function (JavaScript) | Microsoft Docs"
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
  - "decodeURIComponent"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "decodeURIComponent method"
ms.assetid: 486ccee2-afd7-4863-97ce-4adb50cf39c0
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# decodeURIComponent Function (JavaScript)
Gets the unencoded version of an encoded component of a Uniform Resource Identifier (URI).  
  
## Syntax  
  
```  
decodeURIComponent(encodedURIString)  
```  
  
## Remarks  
 The required `encodedURIString` argument is a value representing an encoded URI component.  
  
 A URIComponent is part of a complete URI.  
  
 If the `encodedURIString` is not valid, a URIError occurs.  
  
## Example  
 The following code first encodes and then decodes a URI.  
  
```JavaScript  
var uriEncode = encodeURI ("http://www.Not a URL.com");  
var uriDecode = decodeURIComponent(uriEncode);  
  
document.write (uriEncode);  
document.write("<br/>");  
document.write (uriDecode);  
  
// Output:  
// http://www.Not%20a%20URL.com  
// http://www.Not a URL.com  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [decodeURI Function](../../javascript/reference/decodeuri-function-javascript.md)   
 [encodeURI Function](../../javascript/reference/encodeuri-function-javascript.md)