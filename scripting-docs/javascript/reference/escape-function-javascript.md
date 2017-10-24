---
title: "escape Function (JavaScript) | Microsoft Docs"
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
  - "escape"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "encoding string objects"
  - "Escape method"
  - "hexadecimal"
  - "String object, encoding"
ms.assetid: caa92bea-ba69-4109-a68a-6e2debda463a
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# escape Function (JavaScript)
Encodes strings so they can be read on all computers. Deprecated.  
  
## Syntax  
  
```  
escape(charString)   
```  
  
## Remarks  
 The required `charString` argument is any `String` object or literal to be encoded.  
  
 The **escape** function returns a string value (in Unicode format) that contains the contents of `charstring`. All spaces, punctuation, accented characters, and any other non-ASCII characters are replaced with `%`*xx* encoding, where *xx* is equivalent to the hexadecimal number representing the character. For example, a space is returned as "%20."  
  
 Characters with a value greater than 255 are stored using the **%u** *xxxx* format.  
  
> [!NOTE]
>  The **escape** function should not be used to encode Uniform Resource Identifiers (URI). Use `encodeURI` and `encodeURIComponent` functions instead.  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
## See Also  
 [encodeURI Function](../../javascript/reference/encodeuri-function-javascript.md)   
 [encodeURIComponent Function](../../javascript/reference/encodeuricomponent-function-javascript.md)   
 [String Object](../../javascript/reference/string-object-javascript.md)   
 [unescape Function](../../javascript/reference/unescape-function-javascript.md)