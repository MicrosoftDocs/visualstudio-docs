---
title: "JavaScript in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
  
 For the JavaScript language reference documentation, see [JavaScript](http://msdn.microsoft.com/library/d1et7k7c\(v=vs.94\).aspx).  
  
 Specific versions of Visual Studio, or specific Visual Studio extensions, may be required to develop particular application types and services using HTML and JavaScript. The following list has links to more information.  
  
-   To create cross-platform apps using Apache Cordova, [get the Visual Studio Tools for Apache Cordova](http://go.microsoft.com/fwlink/p/?LinkId=397606).  
  
-   To create [Windows Store](http://dev.windows.com/develop), [Windows Phone](http://dev.windows.com/develop), and universal apps (that support both platforms), [get the tools](http://dev.windows.com/en-us/develop/downloads).  
  
-   To create cloud-based services, see the [Microsoft Azure site](http://azure.microsoft.com/documentation/).  
  
-   To create web sites and web apps, [see the ASP.NET site](http://www.asp.net/get-started/websites).  
  
    > [!NOTE]
    >  You can create an empty ASP.Net Web site and use it for HTML, CSS, and JavaScript programming. The Webconfig file provided by ASP.NET enables debugging in Visual Studio (or you can use F12 tools when you run the app).  
  
 The JavaScript editor in Visual Studio provides IntelliSense support. For more info, see [JavaScript IntelliSense](../ide/javascript-intellisense.md).  
  
## What's New in JavaScript  
 New features for JavaScript are listed in the following table.  
  
|Feature|Description|  
|-------------|-----------------|  
|Classes|New syntax supports declaration of [classes](../Topic/class%20Statement%20\(JavaScript\).md).|  
|Promises|[Promises](../Topic/Promise%20Object%20\(JavaScript\).md) allow easier and cleaner asynchronous coding. Promise constructors are supported, along with the `all` and `race` utility methods.|  
|Iterators|Now you can iterate over iterable objects (including arrays, array-like objects, and iterators), invoking a custom iteration hook with statements to be executed for the value of each distinct property. For more information, see [Iterators and Generators](../Topic/Iterators%20and%20Generators%20\(JavaScript\).md). **Note:**  Generators are not yet supported.|  
|Arrow functions|The arrow function (=>) provides shorthand syntax for the `function` keyword which features a lexical `this` binding.|  
|New methods for built-in objects|The [Array Object](../Topic/Array%20Object%20\(JavaScript\).md), [Math Object](../Topic/Math%20Object%20\(JavaScript\).md), [Number Object](../Topic/Number%20Object%20\(JavaScript\).md), [Object Object](../Topic/Object%20Object%20\(JavaScript\).md), and [String Object](../Topic/String%20Object%20\(JavaScript\).md) built-in objects include many new utility functions and properties for manipulating and inspecting data.|  
|Object literal enhancements|Objects now support computed properties, concise method definitions, and shorthand syntax for properties whose value is initialized to a same-named variable. For more information, see [Creating Objects](../Topic/Creating%20Objects%20\(JavaScript\).md).|  
|Proxies|[Proxies](../Topic/Proxy%20Object%20\(JavaScript\).md) enable custom behavior for objects.|  
|Rest parameters|Rest parameters allow you to turn consecutive arguments in a function call to an array. For more information, see [Functions](../Topic/Functions%20\(JavaScript\).md).|  
|Spread operator|The [spread operator](../Topic/Spread%20Operator%20\(...\)%20\(JavaScript\).md) (`…`) expands iterable expressions into individual arguments. For example, `a.b(…array)` is approximately the same as `a.b.apply(a, array)`.|  
|Symbols|[Symbol](../Topic/Symbol%20Object%20\(JavaScript\).md) objects allow properties to be added to existing objects with no possibility of interference with the existing object properties, with no unintended visibility, and with no other uncoordinated additions by other code.|  
|Template strings|[Template strings](../Topic/Template%20Strings%20\(JavaScript\).md) are string literals that allow for expressions to be evaluated and concatenated with the string literal.|  
|Unicode enhancements|Improvements have been made to Unicode support. For example, a new escape sequence format supports astral code points (code points with more than four hexadecimal digits). For more information, see [Special Characters](../Topic/Special%20Characters%20\(JavaScript\).md).|  
|WeakSet|A [WeakSet](../Topic/WeakSet%20Object%20\(JavaScript\).md) is a collection of objects that will be garbage collected if they are not referenced anywhere else.|