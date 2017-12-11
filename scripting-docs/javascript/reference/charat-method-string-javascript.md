---
title: "charAt Method (String) (JavaScript) | Microsoft Docs"
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
  - "charAt"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "String object, returning characters"
  - "charAt method"
  - "characters, returning part of"
ms.assetid: 63173e15-17f6-47c5-8f94-98ef1eb04c1a
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# charAt Method (String) (JavaScript)
Returns the character at the specified index.  
  
## Syntax  
  
```  
  
strObj. charAt(index)  
```  
  
## Parameters  
 `strObj`  
 Required. Any `String` object or string literal.  
  
 `index`  
 Required. The zero-based index of the desired character.  
  
## Remarks  
 The `charAt` method returns a character value equal to the character at the specified `index`. The first character in a string is at index 0, the second is at index 1, and so forth. Values of `index` that are out of range return an empty string.  
  
## Example  
 The following example illustrates the use of the `charAt` method:  
  
```JavaScript  
var str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";  
document.write(str.charAt(str.length - 1));  
  
// Output: Z  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [String Object](../../javascript/reference/string-object-javascript.md)  
  
## See Also  
 [String Object](../../javascript/reference/string-object-javascript.md)