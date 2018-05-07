---
title: "undefined Constant (JavaScript) | Microsoft Docs"
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
  - "undefined"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "undefined property"
ms.assetid: 2a689d7d-00b0-48fb-9c95-5c2867bde006
caps.latest.revision: 20
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# undefined Constant (JavaScript)
A value that has never been defined, such as a variable that has not been initialized.  
  
## Syntax  
  
```  
undefined  
```  
  
## Remarks  
 The `undefined` constant is a member of the `Global` object, and becomes available when the scripting engine is initialized. When a variable has been declared but not initialized, its value is **undefined**.  
  
 If a variable has not been declared, you cannot compare it to `undefined`, but you can compare the type of the variable to the string "undefined".  
  
 The `undefined` constant is useful when explicitly testing or setting a variable to undefined.  
  
## Example  
 The following example shows how to use the `undefined` constant.  
  
```JavaScript  
// A variable that has not been initialized.  
var declared;  
  
if (declared == undefined)  
    document.write("declared has not been given a value <br/>");  
else  
    document.write("declared has been given a value <br/>");  
  
document.write("typeof declared is " + typeof(declared) + "<br/>");  
  
// An undeclared variable cannot be compared to undefined,  
// so the next line would generate an error.  
// if (notDeclared == undefined);  
  
document.write("typeof notDeclared is " + typeof(notDeclared));  
  
// Output:  
// declared has not been given a value  
// typeof declared is undefined  
// typeof notDeclared is undefined  
```  
  
## Requirements  
 The `undefined` property was introduced in [!INCLUDE[jsv55text](../../javascript/reference/includes/jsv55text-md.md)], and was made read-only in [!INCLUDE[jsv9textspecific](../../javascript/reference/includes/jsv9textspecific-md.md)].  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## See Also  
 [typeof Operator](../../javascript/reference/typeof-operator-decrementjavascript.md)