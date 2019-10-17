---
title: "The URI to be encoded contains an invalid character | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5024"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: a3f0fdbb-8d4b-41ae-a396-43dfc9483760
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# The URI to be encoded contains an invalid character
You attempted to encode a string as a URI (Uniform Resource Identifier), but it contained invalid characters. Although most characters are valid inside strings to be converted to URIs, some Unicode character sequences are illegal.  
  
### To correct this error  
  
- Ensure the string to be encoded contains only valid Unicode sequences. A complete URI is composed of a sequence of components and separators. The names in angle brackets represent components, and the ":", "/", ";" and "?" are reserved characters used as separators. The general form is:  
  
    ```JavaScript  
    <Scheme>:<first>/<second>;<third>?<fourth>  
    ```  
  
## See also  
 [encodeURI Function](../../javascript/reference/encodeuri-function-javascript.md)   
 [encodeURIComponent Function](../../javascript/reference/encodeuricomponent-function-javascript.md)