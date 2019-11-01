---
title: "The URI to be decoded is not a valid encoding | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5025"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 029e0790-ffd1-496d-8700-3b3dbac1b6fd
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# The URI to be decoded is not a valid encoding
You attempted to decode an improperly formed URI (Uniform Resource Identifier). URIs have a special syntax; most non-alphanumeric characters must be encoded before they can be used in a URI. You can use the `encodeURI` and `encodeURIComponent` methods to create a URI from a normal [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] string.  
  
 A complete URI is composed of a sequence of components and separators. The general form is:  
  
```JavaScript  
<Scheme>:<first>/<second>;<third>?<fourth>  
```  
  
 The names in angle brackets represent components, and the ":", "/", ";" and "?" are reserved characters used as separators.  
  
### To correct this error  
  
- Ensure you are trying to decode valid URIs only. You cannot decode normal [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] strings, as they may contain invalid characters.  
  
## See also  
 [decodeURI Function](../../javascript/reference/decodeuri-function-javascript.md)   
 [decodeURIComponent Function](../../javascript/reference/decodeuricomponent-function-javascript.md)