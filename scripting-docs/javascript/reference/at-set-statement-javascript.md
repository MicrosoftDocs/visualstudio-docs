---
title: "@set Statement (JavaScript) | Microsoft Docs"
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
  - "@set_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "@set statement"
  - "conditional compilation, variables"
ms.assetid: 36f15926-3e69-422d-82a2-d186dc088203
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# @set Statement (JavaScript)
Creates variables used with conditional compilation statements.  
  
> [!WARNING]
>  Conditional compilation is not supported in Internet Explorer 11 Standards mode and [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. Conditional compilation is supported in Internet Explorer 10 Standards mode and in all earlier versions.  
  
## Syntax  
  
```  
  
@set @varname = term   
```  
  
## Parameters  
 *varname*  
 Required. Valid [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] variable name. Must be preceded by an "\@" character at all times.  
  
 `term`  
 Required. Zero or more unary operators followed by a constant, conditional compilation variable, or parenthesized expression.  
  
## Remarks  
 Numeric and Boolean variables are supported for conditional compilation. Strings are not. Variables created using `@set` are generally used in conditional compilation statements, but can be used anywhere in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] code.  
  
 Examples of variable declarations look like this:  
  
```JavaScript  
  
      @set @myvar1 = 12  
  
@set @myvar2 = (@myvar1 * 20)  
  
@set @myvar3 = @_jscript_version  
```  
  
 The following operators are supported in parenthesized expressions:  
  
-   `! ~`  
  
-   `* / %`  
  
-   `+ -`  
  
-   `<< >> >>>`  
  
-   `< <= > >=`  
  
-   `== != === !==`  
  
-   `& ^ |`  
  
-   `&& | |`  
  
 If a variable is used before it has been defined, its value is `NaN`. `NaN` can be checked for using the `@if` statement:  
  
```JavaScript  
@if (@newVar != @newVar)  
   ...  
```  
  
 This works because `NaN` is the only value not equal to itself.  
  
## Requirements  
 Supported in all versions of Internet Explorer, but not in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## See Also  
 [Conditional Compilation](../../javascript/advanced/conditional-compilation-javascript.md)   
 [Conditional Compilation Variables](../../javascript/advanced/conditional-compilation-variables-javascript.md)   
 [@cc_on Statement](../../javascript/reference/at-cc-on-statement-javascript.md)   
 [@if Statement](../../javascript/reference/at-if-statement-javascript.md)