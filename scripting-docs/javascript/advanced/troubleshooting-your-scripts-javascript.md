---
title: "Troubleshooting Your Scripts (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "automative type conversion"
  - "troubleshooting scripts"
ms.assetid: 0e0545d9-44e5-4179-befc-99a882c5c672
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Troubleshooting Your Scripts (JavaScript)
There are places in any programming language that have surprises. For example, the `null` value in [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] does not behave the same as the `Null` value in the C or C++ languages.  
  
 Here are some of the trouble areas that you may run into as you write [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripts.  
  
## Syntax Errors  
 It is important to pay attention to detail when you write scripts. For example, strings must be enclosed in quotation marks.  
  
## Order of Script Interpretation  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] interpretation is part of the your Web browser's HTML parsing process. If you place a script inside the \<HEAD> tag in a document, it is interpreted before any part of the \<BODY> tag. If you have objects that are created in the \<BODY> tag, they do not exist at the time the \<HEAD> is being parsed, and cannot be manipulated by the script.  
  
> [!NOTE]
>  This behavior is specific to Internet Explorer. ASP and WSH have different execution models (as do other hosts).  
  
## Automatic Type Coercion  
 [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is a loosely-typed language with automatic coercion. Even though values having different types are not equal, the expressions in the following example evaluate to **true**.  
  
```javascript  
"100" == 100;  
false == 0;  
```  
  
 To check that both the type and value are the same, use the strict equality operator (===). The following both evaluate to false:  
  
```javascript  
"100" === 100;  
false === 0;  
```  
  
## Operator Precedence  
 [Operator precedence](../../javascript/operator-subtractprecedence-javascript.md) determines when an operation is performed during the evaluation of an expression. In the following example multiplication is performed before subtraction, even though the subtraction appears first in the expression.  
  
```javascript  
theRadius = aPerimeterPoint - theCenterpoint * theCorrectionFactor;  
```  
  
## Using for...in Loops with Objects  
 When you iterate through the properties of an object with a [for...in](../../javascript/reference/for-dot-dot-dot-in-statement-javascript.md) loop, you cannot predict or control the order in which the fields of the object are assigned to the loop counter variable. Moreover, the order may be different in different implementations of the language.  
  
## with Keyword  
 The [with](../../javascript/reference/with-statement-javascript.md) statement is convenient for accessing properties that already exist in a specified object, but cannot be used to add properties to an object. To create new properties in an object, you must refer to the object specifically.  
  
## this Keyword  
 Although you use the `this` keyword inside the definition of an object to refer to the object itself, you cannot use `this` or similar keywords to refer to the currently executing function when that function is not an object definition. If the function is to be assigned to an object as a method, you can use the `this` keyword within the function to refer to the object.  
  
## Writing a Script That Writes a Script in Internet Explorer  
 The \</SCRIPT> tag terminates the current script if the interpreter encounters it. To display "\</SCRIPT>" itself, rewrite this as at least two strings, for example, "\</SCR" and "IPT>", which you can then concatenate together in the statement that writes them out.  
  
## Implicit Window References in Internet Explorer  
 Because more than one window can be open at a time, any implicit window reference points to the current window. For other windows, you must use an explicit reference.