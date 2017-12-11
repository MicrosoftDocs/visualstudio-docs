---
title: "unescape Function (JavaScript) | Microsoft Docs"
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
  - "unescape"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Unescape method"
ms.assetid: 4adf0270-88b5-4d54-8110-d879d6ae97c2
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# unescape Function (JavaScript)
Decodes `String` objects encoded with the `escape` function. Deprecated.  
  
## Syntax  
  
```  
unescape(charString)   
```  
  
## Remarks  
 The required `charString` argument is a `String` object or literal to be decoded.  
  
 The `unescape` function returns a string value that contains the contents of `charstring`. All characters encoded with the %*xx* hexadecimal form are replaced by their ASCII character set equivalents.  
  
 Characters encoded in **%u** *xxxx* format (Unicode characters) are replaced with the Unicode character with hexadecimal encoding *xxxx*.  
  
> [!NOTE]
>  The `unescape` function should not be used to decode Uniform Resource Identifiers (URI). Use `decodeURI` and `decodeURIComponent` functions instead.  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## See Also  
 [decodeURI Function](../../javascript/reference/decodeuri-function-javascript.md)   
 [decodeURIComponent Function](../../javascript/reference/decodeuricomponent-function-javascript.md)   
 [escape Function](../../javascript/reference/escape-function-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)