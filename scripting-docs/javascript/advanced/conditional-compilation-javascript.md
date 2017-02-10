---
title: "Conditional Compilation (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "ConditionalComp_JavaScript"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "conditional compilation, overview"
  - "conditional compilation"
ms.assetid: a843de4e-3aae-43cd-ad64-477dd00814a2
caps.latest.revision: 16
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Conditional Compilation (JavaScript)
Conditional compilation allows the use of new [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] language features without sacrificing compatibility with older versions that do not support the features.  
  
> [!WARNING]
>  Conditional compilation is supported in all versions of Internet Explorer prior to Internet Explorer 11. Starting with Internet Explorer 11 Standards mode, and in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, conditional compilation is not supported.  
  
## Statements  
 Conditional compilation is activated by using the `@cc_on` statement, or using an `@if` or `@set` statement. Some typical uses for conditional compilation include using new features in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)], embedding debugging support into a script, and tracing code execution.  
  
 Always place conditional compilation code in comments, so that hosts (like Netscape Navigator) that do not support conditional compilation will ignore it. Here is an example.  
  
```javascript  
/*@cc_on @*/  
/*@if (@_jscript_version >= 4)  
    alert("JavaScript version 4 or better");  
    @else @*/  
    alert("Conditional compilation not supported by this scripting engine.");  
/*@end @*/  
```  
  
 This example uses special comment delimiters that are used only if conditional compilation is activated by the `@cc_on` statement. Scripting engines that do not support conditional compilation see only the message that says conditional compilation is not supported.