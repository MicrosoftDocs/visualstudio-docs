---
title: "encodeURIComponent Function (JavaScript) | Microsoft Docs"
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
  - "encodeURIComponent"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "encodeURIComponent method"
ms.assetid: 8202bce6-1342-40dc-a5ef-ac6d210a7d15
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# encodeURIComponent Function (JavaScript)
Encodes a text string as a valid component of a Uniform Resource Identifier (URI).  
  
## Syntax  
  
```  
encodeURIComponent(encodedURIString)  
```  
  
## Remarks  
 The required `encodedURIString` argument is a value representing an encoded URI component.  
  
 The `encodeURIComponent` function returns an encoded URI. If you pass the result to `decodeURIComponent`, the original string is returned. Because the `encodeURIComponent` function encodes all characters, be careful if the string represents a path such as **/folder1/folder2/default.html**. The slash characters will be encoded and will not be valid if sent as a request to a web server. Use the `encodeURI` function if the string contains more than a single URI component.  
  
## Example  
 The following code first encodes a URI component and then decodes it.  
  
```javascript  
var uriEncode = encodeURIComponent ("www.Not a URL.com");  
var uriDecode = decodeURIComponent(uriEncode);  
  
document.write(uriEncode);  
document.write("<br/>");  
document.write(uriDecode);  
  
// Output:  
// www.Not%20a%20URL.com  
// www.Not a URL.com  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [decodeURI Function](../../javascript/reference/decodeuri-function-javascript.md)   
 [decodeURIComponent Function](../../javascript/reference/decodeuricomponent-function-javascript.md)