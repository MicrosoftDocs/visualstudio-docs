---
title: "decodeURI Function (JavaScript) | Microsoft Docs"
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
  - "decodeURI"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "decodeURI method"
ms.assetid: af6c81dc-10f4-4243-a7ce-d18ae3ea0fb8
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# decodeURI Function (JavaScript)
Gets the unencoded version of an encoded Uniform Resource Identifier (URI).  
  
## Syntax  
  
```  
decodeURI(URIstring)  
```  
  
## Remarks  
 The required `URIstring` argument is a value representing an encoded URI.  
  
 Use the `decodeURI` function instead of the deprecated `unescape` function.  
  
 The `decodeURI` function returns a string value.  
  
 If the `URIString` is not valid, a URIError occurs.  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## Example  
 The following code first encodes a URI component and then decodes it.  
  
```JavaScript  
var uriEncode = encodeURIComponent ("www.Not a URL.com");  
var uriDecode = decodeURIComponent(uriEncode);  
  
document.write (uriEncode);  
document.write ("<br/>");  
document.write (uriDecode);  
  
// Output:  
// www.Not%20a%20URL.com  
// www.Not a URL.com  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
## See Also  
 [decodeURIComponent Function](../../javascript/reference/decodeuricomponent-function-javascript.md)   
 [encodeURI Function](../../javascript/reference/encodeuri-function-javascript.md)   
 [Global Object](../../javascript/reference/global-object-javascript.md)