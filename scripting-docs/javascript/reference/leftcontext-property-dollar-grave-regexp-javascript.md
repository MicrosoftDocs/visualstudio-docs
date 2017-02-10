---
title: "leftContext Property ($`) (RegExp) (JavaScript) | Microsoft Docs"
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
  - "$`"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "leftContext property ($`)"
ms.assetid: 840e56c0-eb7c-461f-bb56-91acff9b5bcf
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# leftContext Property ($`) (RegExp) (JavaScript)
Returns the characters from the beginning of a searched string up to the position before the beginning of the last match. Read-only.  
  
## Syntax  
  
```  
  
RegExp.leftContext  
```  
  
## Remarks  
 The object associated with this property is always the global `RegExp` object.  
  
 The initial value of the `leftContext` property is an empty string. The value of the `leftContext` property changes whenever a successful match is made.  
  
## Example  
 The following example illustrates the use of the `leftContext` property:  
  
```javascript  
// Create the regular expression pattern.  
var re = new RegExp("d(b+)(d)","ig");  
var str = "cdbBdbsbdbdz";  
  
// Perform the search.  
var arr = re.exec(str);  
  
// Print the output.  
var s = ""   
s += "$1: " + RegExp.$1 + "<br />";  
s += "$2: " + RegExp.$2 + "<br />";  
s += "$3: " + RegExp.$3 + "<br />";  
s += "input: " + RegExp.input + "<br />";  
s += "lastMatch: " + RegExp.lastMatch + "<br />";  
s += "leftContext: " + RegExp.leftContext + "<br />";  
s += "rightContext: " + RegExp.rightContext + "<br />";   
s += "lastParen: " + RegExp.lastParen + "<br />";  
  
document.write(s);  
```  
  
## Requirements  
 [!INCLUDE[jsv55](../../javascript/reference/includes/jsv55-md.md)]  
  
 **Applies To**: [RegExp Object](../../javascript/reference/regexp-object-javascript.md)  
  
## See Also  
 [$1...$9 Properties (RegExp)](../../javascript/reference/dollar-1-dot-dot-dot-dollar-9-properties-regexp-javascript.md)   
 [index Property (RegExp)](../../javascript/reference/index-property-regexp-javascript.md)   
 [input Property ($_) (RegExp)](../../javascript/reference/input-property-dollar-regexp-javascript.md)   
 [lastIndex Property (RegExp)](../../javascript/reference/lastindex-property-regexp-javascript.md)   
 [lastMatch Property ($&) (RegExp)](../../javascript/reference/lastmatch-property-dollar-regexp-javascript.md)   
 [lastParen Property ($+) (RegExp)](../../javascript/reference/lastparen-property-dollar-regexp-javascript.md)   
 [rightContext Property ($') (RegExp)](../../javascript/reference/rightcontext-property-dollar-regexp-javascript.md)