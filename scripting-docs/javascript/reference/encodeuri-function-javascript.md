---
title: "encodeURI Function (JavaScript) | Microsoft Docs"
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
  - "encodeURI"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "encodeURI method"
ms.assetid: 17bab5a2-bcd4-46c2-8b52-b2b5a0ed98a3
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# encodeURI Function (JavaScript)
Encodes a text string as a valid Uniform Resource Identifier (URI)  
  
## Syntax  
  
```  
  
encodeURI(  
URIString  
)  
  
```  
  
## Remarks  
 The required `URIString` argument is a value representing an encoded URI.  
  
 The `encodeURI` function returns an encoded URI. If you pass the result to `decodeURI`, the original string is returned. The `encodeURI` function does not encode the following characters: ":", "/", ";", and "?". Use `encodeURIComponent` to encode these characters.  
  
## Example  
 The following code first encodes and then decodes a URI.  
  
```javascript  
var uriEncode = encodeURI ("http://www.Not a URL.com");  
var uriDecode = decodeURIComponent(uriEncode);  
  
document.write(uriEncode);  
document.write("<br/>");  
document.write(uriDecode);  
  
// Output:  
// http://www.Not%20a%20URL.com  
// http://www.Not a URL.com  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [decodeURI Function](../../javascript/reference/decodeuri-function-javascript.md)   
 [decodeURIComponent Function](../../javascript/reference/decodeuricomponent-function-javascript.md)