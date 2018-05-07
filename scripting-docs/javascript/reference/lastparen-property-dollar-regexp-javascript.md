---
title: "lastParen Property ($+) (RegExp) (JavaScript) | Microsoft Docs"
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
  - "$+"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "lastParen property ($+)"
ms.assetid: 18aca591-a97a-48da-8b06-422346804b16
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# lastParen Property ($+) (RegExp) (JavaScript)
Returns the last parenthesized submatch from any regular expression search, if any. Read-only.  
  
## Syntax  
  
```  
  
RegExp.lastParen  
```  
  
## Remarks  
 The object associated with this property is always the global `RegExp` object.  
  
 The initial value of the `lastParen` property is an empty string. The value of the `lastParen` property changes whenever a successful match is made.  
  
## Example  
 The following example illustrates the use of the `lastParen` property:  
  
```JavaScript  
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
 [leftContext Property ($`) (RegExp)](../../javascript/reference/leftcontext-property-dollar-grave-regexp-javascript.md)   
 [rightContext Property ($') (RegExp)](../../javascript/reference/rightcontext-property-dollar-regexp-javascript.md)