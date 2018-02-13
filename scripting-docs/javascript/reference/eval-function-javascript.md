---
title: "eval Function (JavaScript) | Microsoft Docs"
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
  - "eval"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "eval function"
  - "parsing, code"
  - "parser"
ms.assetid: 85587e39-9325-4b75-b9f9-9d7d475a2120
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# eval Function (JavaScript)
Evaluates [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code and executes it.  
  
## Syntax  
  
```  
eval(codeString)   
```  
  
## Parameters  
 `codeString`  
 Required. A `String` value that contains valid [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code.  
  
## Remarks  
 The `eval` function enables dynamic execution of [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] source code.  
  
 The `codeString` string is parsed by the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] parser and executed.  
  
 The code passed to the `eval` function is executed in the same context as the call to the `eval` function.  
  
 Whenever possible, use the [JSON.parse function](../../javascript/reference/json-parse-function-javascript.md) to de-serialize JavaScript Object Notation (JSON) text. The `JSON.parse` function is more secure and executes faster than the `eval` function.  
  
## Example  
 The following code initializes the variable `myDate` to a test date.  
  
```JavaScript  
var dateFn = "Date(1971,3,8)";  
var myDate;  
eval("myDate = new " + dateFn + ";");  
  
document.write(myDate);  
  
// Output: Thu Apr 8 00:00:00 PDT 1971  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]  
  
 **Applies To**: [Global Object](../../javascript/reference/global-object-javascript.md)  
  
## See Also  
 [String Object](../../javascript/reference/string-object-javascript.md)