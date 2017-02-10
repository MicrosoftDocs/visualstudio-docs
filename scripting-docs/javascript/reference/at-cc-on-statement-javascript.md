---
title: "@cc_on Statement (JavaScript) | Microsoft Docs"
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
  - "@cc_on_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "conditional compilation, activating"
  - "@cc_on statement"
  - "@set statement"
  - "@if statement"
ms.assetid: fdeda7ee-b9f4-4e52-8aa2-21c90c02a332
caps.latest.revision: 21
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# @cc_on Statement (JavaScript)
Activates conditional compilation support within comments in a script.  
  
> [!WARNING]
>  Conditional compilation is not supported in Internet Explorer 11 Standards mode and [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. Conditional compilation is supported in Internet Explorer 10 Standards mode and in all earlier versions.  
  
## Syntax  
  
```  
@cc_on   
```  
  
## Remarks  
 The `@cc_on` statement activates conditional compilation within comments in a script.  
  
 It is not common to use conditional compilation variables in scripts written for ASP or ASP.NET pages or command-line programs because the capabilities of the compilers can be determined by using other methods.  
  
 When you write a script for a Web page, always put conditional compilation code in comments. This enables hosts that do not support conditional compilation to ignore it.  
  
 It is strongly recommended that you use the `@cc_on` statement in a comment, so that browsers that do not support conditional compilation will accept your script as valid syntax:  
  
 An `@if` or `@set` statement outside of a comment also activates conditional compilation.  
  
## Example  
 The following example illustrates the use of the `@cc_on` statement.  
  
```javascript  
/*@cc_on @*/  
/*@  
    document.write("JavaScript version: " + @_jscript_version + ".");  
    document.write("<br />");  
    @if (@_win32)  
        document.write("Running on the 32-bit version of Windows.");  
    @elif (@_win16)  
        document.write("Running on the 16-bit version of Windows.");  
    @else  
        document.write("Running on a different operating system.");  
    @end  
@*/  
```  
  
## Requirements  
 Supported in all versions of Internet Explorer, but not in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps.  
  
## See Also  
 [Conditional Compilation](../../javascript/advanced/conditional-compilation-javascript.md)   
 [Conditional Compilation Variables](../../javascript/advanced/conditional-compilation-variables-javascript.md)   
 [@if Statement](../../javascript/reference/at-if-statement-javascript.md)   
 [@set Statement](../../javascript/reference/at-set-statement-javascript.md)