---
title: "String.raw Function (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "DHTML"
ms.assetid: b1038b73-3944-4645-b075-3a674b313762
caps.latest.revision: 3
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# String.raw Function (JavaScript)
Returns the raw string form of a template string.  
  
## Syntax  
  
```  
String.raw`templateStr`;  
String.raw(obj, ...substitutions);  
```  
  
#### Parameters  
 `templateStr`  
 Required. The template string.  
  
 `obj`  
 Required. A well-formed object specified using object literal notation, such as { raw: 'value' }.  
  
 `...substitutions`  
 Optional. An array (a [rest parameter](../../javascript/functions-javascript.md)) consisting of one or more substitution values.  
  
## Remarks  
 The `String.raw` function is intended for use with [template strings](../../javascript/advanced/template-strings-javascript.md). The raw string will include any escape characters and backslashes that are present in the string.  
  
 An error is thrown if `obj` is not a well-formed object.  
  
## Example  
  
```  
function log(arg) {  
    if(console && console.log) {  
        console.log(arg);  
    }  
};  
  
var name = "bob";  
  
log(`hello \t${name}`);  
log(String.raw`hello \t${name}`);  
// The following usage for String.raw is supported but  
// is not typical.  
log(String.raw({ raw: 'fred'}, 'F', 'R', 'E'));  
  
// Output:  
// hello   bob  
// hello \tbob  
// fFrReEd   
```  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]