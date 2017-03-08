---
title: "JavaScript in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f3eee13e-30e4-4bc1-81f5-058d7e379b75
caps.latest.revision: 17
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# JavaScript in Visual Studio
JavaScript is a first-class language in Visual Studio. You can use most or all of the standard editing aids (code snippets, IntelliSense, and so on) when you write JavaScript code in the Visual Studio IDE. You can write JavaScript code for many application types and services.  
  
 For the JavaScript language reference documentation, see [JavaScript](https://docs.microsoft.com/scripting/javascript/javascript-language-reference).
  
 Specific versions of Visual Studio, or specific Visual Studio extensions, may be required to develop particular application types and services using HTML and JavaScript. The following list has links to more information.  
  
-   To create cross-platform apps using Apache Cordova, see [Visual Studio Tools for Apache Cordova](https://docs.microsoft.com/visualstudio/cross-platform/tools-for-cordova/).  
  
-   For links to JavaScript technologies you can use in Visual Studio, see the [JavaScript](https://docs.microsoft.com/scripting/javascript/) and [Scripting Technologies](https://docs.microsoft.com/scripting/) pages.
  
 The JavaScript editor in Visual Studio provides IntelliSense support. For more info, see [JavaScript IntelliSense](../ide/javascript-intellisense.md).  
  
## What's New in JavaScript  
 New features for JavaScript are listed in the following table.  
  
|Feature|Description|  
|-------------|-----------------|  
|Classes|New syntax supports declaration of [classes](http://msdn.microsoft.com/Library/bf45ebad-4678-4062-88df-55d32b603c69).|  
|Promises|[Promises](http://msdn.microsoft.com/Library/358ad98b-f7fa-448c-9ee0-ef1e2a45e9c6) allow easier and cleaner asynchronous coding. Promise constructors are supported, along with the `all` and `race` utility methods.|  
|Iterators|Now you can iterate over iterable objects (including arrays, array-like objects, and iterators), invoking a custom iteration hook with statements to be executed for the value of each distinct property. For more information, see [Iterators and Generators](http://msdn.microsoft.com/Library/68ef5b2f-0349-492b-b557-73ff2a2f90cf). **Note:**  Generators are not yet supported.|  
|Arrow functions|The arrow function (=>) provides shorthand syntax for the `function` keyword which features a lexical `this` binding.|  
|New methods for built-in objects|The [Array Object](http://msdn.microsoft.com/Library/08e5f552-0797-4b48-8164-609582fc18c9), [Math Object](http://msdn.microsoft.com/Library/607b94cb-921c-43cd-b514-fdbc13aeced6), [Number Object](http://msdn.microsoft.com/Library/76e87c37-cf6c-46cc-bafa-04be1fe3d78d), [Object Object](http://msdn.microsoft.com/Library/d24ef8fc-217b-4828-94e1-19f72780bae0), and [String Object](http://msdn.microsoft.com/Library/8063ecd5-5778-4e87-b985-b21420171914) built-in objects include many new utility functions and properties for manipulating and inspecting data.|  
|Object literal enhancements|Objects now support computed properties, concise method definitions, and shorthand syntax for properties whose value is initialized to a same-named variable. For more information, see [Creating Objects](http://msdn.microsoft.com/Library/58d1baa5-4fe8-4a56-a926-5b11765df704).|  
|Proxies|[Proxies](http://msdn.microsoft.com/Library/2b89abee-04fa-47e6-9676-980016cff5f8) enable custom behavior for objects.|  
|Rest parameters|Rest parameters allow you to turn consecutive arguments in a function call to an array. For more information, see [Functions](http://msdn.microsoft.com/Library/e2a72b5a-3edd-43d8-95e8-91721b38c1c1).|  
|Spread operator|The [spread operator](http://msdn.microsoft.com/Library/10263a4c-bd27-4d87-9917-fb4b6bf373db) (`…`) expands iterable expressions into individual arguments. For example, `a.b(…array)` is approximately the same as `a.b.apply(a, array)`.|  
|Symbols|[Symbol](http://msdn.microsoft.com/Library/2ad059f1-4b7f-4758-882a-c74ce1283ab0) objects allow properties to be added to existing objects with no possibility of interference with the existing object properties, with no unintended visibility, and with no other uncoordinated additions by other code.|  
|Template strings|[Template strings](http://msdn.microsoft.com/Library/f2e525a5-b0fc-49c3-95a0-641788e5c12a) are string literals that allow for expressions to be evaluated and concatenated with the string literal.|  
|Unicode enhancements|Improvements have been made to Unicode support. For example, a new escape sequence format supports astral code points (code points with more than four hexadecimal digits). For more information, see [Special Characters](http://msdn.microsoft.com/Library/3b38b1bd-1f0f-4748-b13e-55cab36fd126).|  
|WeakSet|A [WeakSet](http://msdn.microsoft.com/Library/f97e6e7c-d678-4e32-978e-d949a7cafa3a) is a collection of objects that will be garbage collected if they are not referenced anywhere else.|