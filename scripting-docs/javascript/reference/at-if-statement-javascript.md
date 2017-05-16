---
title: "@if Statement (JavaScript) | Microsoft Docs"
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
  - "@if_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "elif statement"
  - "conditional statements, if"
  - "if statement, @if"
  - "else statement"
  - "@if statement"
ms.assetid: ff11b29d-c06a-4276-b11d-db73e2da98ac
caps.latest.revision: 18
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# @if Statement (JavaScript)
Conditionally executes a group of statements, depending on the value of an expression.  
  
> [!WARNING]
>  Conditional compilation is not supported in Internet Explorer 11 Standards mode and [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps. Conditional compilation is supported in Internet Explorer 10 Standards mode and in all earlier versions.  
  
## Syntax  
  
```  
  
      @if (  
   condition1  
)  
   text1  
[@elif (  
   condition2  
)  
   text2]  
[@else  
   text3]  
@end   
```  
  
## Parameters  
 *condition1, condition2*  
 Optional. An expression that can be coerced into a Boolean expression.  
  
 `text1`  
 Optional. Text to be parsed if `condition1` is **true**.  
  
 `text2`  
 Optional. Text to be parsed if `condition1` is **false** and `condition2` is **true**.  
  
 `text3`  
 Optional. Text to be parsed if both `condition1` and `condition2` are **false**.  
  
## Remarks  
 When you write an `@if` statement, you do not have to place each clause on a separate line. You can use multiple **@elif** clauses. However, all **@elif** clauses must come before an **@else** clause.  
  
 The `@if` statement is typically used to determine which text among several options should be used for text output.  
  
 It is not common to use conditional compilation variables in scripts written for ASP or ASP.NET pages or command-line programs. This is because the capabilities of the compilers can be determined by using other methods.  
  
 When you write a script for a Web page, always add conditional compilation code in comments. This enables hosts that do not support conditional compilation to ignore it.  
  
## Example  
 The following example illustrates the use of the **@if...@elif...@else...@end** statement.  
  
```JavaScript  
/*@cc_on @*/  
/*@  
    document.write("JavaScript version: " + @_jscript_version + ".");  
    document.write("<br />");  
    @if (@_win32)  
        document.write("Running on a 32-bit version of Windows.");  
    @elif (@_win16)  
        document.write("Running on a 16-bit version of Windows.");  
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
 [@cc_on Statement](../../javascript/reference/at-cc-on-statement-javascript.md)   
 [@set Statement](../../javascript/reference/at-set-statement-javascript.md)