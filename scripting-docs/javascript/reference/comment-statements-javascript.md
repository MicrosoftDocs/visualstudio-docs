---
title: "Comment Statements (JavaScript) | Microsoft Docs"
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
  - "Comment_JavaScript"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "comments, ignoring"
  - "comment statements"
ms.assetid: b604824f-ac17-49d3-bcdb-2a893ab5fff8
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Comment Statements (JavaScript)
Causes comments to be ignored by the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] parser.  
  
## Syntax  
  
```  
Single-line Comment:  
// comment   
```  
  
```  
Multiline Comment:  
/*  
comment  
*/  
```  
  
```  
Comments with conditional compilation:  
//@CondStatement   
  
/*@  
condStatement  
@*/  
```  
  
## Remarks  
 The `comment` argument is the text of any comment you want to include in your script. The `condStatement` argument is to be used if conditional compilation is activated. If single-line comments are used, there can be no space between the "//" and "\@" characters.  
  
 Use comments to keep parts of a script from being read by the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] parser. You can use comments to include explanatory remarks in a program.  
  
 If single-line comments are used, the parser ignores any text between the comment marker and the end of the line. If multi-line comments are used, the parser ignores any text between the beginning and end markers.  
  
 Comments are used to support conditional compilation while retaining compatibility with browsers that do not support that feature. These browsers treat those forms of comments as single-line or multi-line comments respectively.  
  
## Example  
 The following example illustrates the most common uses of comments.  
  
```JavaScript  
/* This is a multiline comment that  
    can span as many lines as necessary.  */  
function myfunction(arg1, arg2){  
    var r;  
    // This is a single line comment.  
    r = arg1 + arg2  
    return(r);  
}  
```  
  
## Example  
 The following example shows how to use conditional compilation. This example uses special comment delimiters that are used only if conditional compilation is activated by the `@cc_on` statement. Scripting engines that do not support conditional compilation see only the message that says conditional compilation is not supported.  
  
```JavaScript  
/*@cc_on @*/  
/*@if (@_jscript_version >= 4)  
    alert("JavaScript version 4 or better");  
    @else @*/  
    alert("Conditional compilation not supported by this scripting engine.");  
/*@end @*/  
```  
  
## Requirements  
 [!INCLUDE[jsv1](../../javascript/misc/includes/jsv1-md.md)]