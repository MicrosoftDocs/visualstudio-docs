---
title: "What&#39;s New in JavaScript | Microsoft Docs"
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
  - "TypeScript"
  - "DHTML"
ms.assetid: 342b68ef-df93-48c4-81de-bdf6b6ce58d9
caps.latest.revision: 33
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# What&#39;s New in JavaScript
This document lists new features in JavaScript that are supported in both [Edge mode](http://blogs.msdn.com/b/ie/archive/2014/11/11/living-on-the-edge-our-next-step-in-interoperability.aspx), [!INCLUDE[win8_appname_long](../javascript/includes/win8-appname-long-md.md)], and Windows Phone Store apps.  
  
 To find out which JavaScript elements are supported in Edge mode but deprecated in [!INCLUDE[win8_appname_long](../javascript/includes/win8-appname-long-md.md)] apps, see [Version Information](../javascript/reference/javascript-version-information.md).  
  
> [!IMPORTANT]
>  For information about how to create [!INCLUDE[win8_appname_long](../javascript/includes/win8-appname-long-md.md)] and Windows Phone Store apps using JavaScript, including information about the Visual Studio JavaScript editor and other features, see [Develop Windows Store apps using Visual Studio 2013](http://go.microsoft.com/fwlink/p/?LinkID=238263).  
  
## New features in JavaScript  
  
|Feature|Description|  
|-------------|-----------------|  
|Classes|New syntax supports declaration of [classes](../javascript/reference/class-statement-javascript.md).|  
|Promises|[Promises](../javascript/reference/promise-object-javascript.md) allow easier and cleaner asynchronous coding. Promise constructors are supported, along with the `all` and `race` utility methods.|  
|Iterators|Now you can iterate over iterable objects (including arrays, array-like objects, and iterators), invoking a custom iteration hook with statements to be executed for the value of each distinct property. For more information, see [Iterators and Generators](../javascript/advanced/iterators-and-generators-javascript.md). **Note:**  Generators are not yet supported.|  
|Arrow functions|The arrow function (=>) provides shorthand syntax for the `function` keyword which features a lexical `this` binding.|  
|New methods for built-in objects|The [Array Object](../javascript/reference/array-object-javascript.md), [Math Object](../javascript/reference/math-object-javascript.md), [Number Object](../javascript/reference/number-object-javascript.md), [Object Object](../javascript/reference/object-object-javascript.md), and [String Object](../javascript/reference/string-object-javascript.md) built-in objects include many new utility functions and properties for manipulating and inspecting data.|  
|Object literal enhancements|Objects now support computed properties, concise method definitions, and shorthand syntax for properties whose value is initialized to a same-named variable. For more information, see [Creating Objects](../javascript/creating-objects-javascript.md).|  
|Proxies|[Proxies](../javascript/reference/proxy-object-javascript.md) enable custom behavior for objects.|  
|Rest parameters|Rest parameters allow you to turn consecutive arguments in a function call to an array. For more information, see [Functions](../javascript/functions-javascript.md).|  
|Spread operator|The [spread operator](../javascript/reference/spread-operator-decrement-dot-dot-dot-javascript.md) (`…`) expands iterable expressions into individual arguments. For example, `a.b(…array)` is approximately the same as `a.b.apply(a, array)`.|  
|Symbols|[Symbol](../javascript/reference/symbol-object-javascript.md) objects allow properties to be added to existing objects with no possibility of interference with the existing object properties, with no unintended visibility, and with no other uncoordinated additions by other code.|  
|Template strings|[Template strings](../javascript/advanced/template-strings-javascript.md) are string literals that allow for expressions to be evaluated and concatenated with the string literal.|  
|Unicode enhancements|Improvements have been made to Unicode support. For example, a new escape sequence format supports astral code points (code points with more than four hexadecimal digits). For more information, see [Special Characters](../javascript/advanced/special-characters-javascript.md).|  
|WeakSet|A [WeakSet](../javascript/reference/weakset-object-javascript.md) is a collection of objects that will be garbage collected if they are not referenced anywhere else.|  
  
## See Also  
 [JavaScript Language Reference](../javascript/javascript-language-reference.md)