---
title: "JavaScript"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-javascript
ms.topic: conceptual
ms.assetid: f3eee13e-30e4-4bc1-81f5-058d7e379b75
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# JavaScript in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

JavaScript is a first-class language in Visual Studio. You can use most or all of the standard editing aids (code snippets, IntelliSense, and so on) when you write JavaScript code in the Visual Studio IDE. You can write JavaScript code for many application types and services.

 For the JavaScript language reference documentation, see [JavaScript](https://msdn.microsoft.com/library/d1et7k7c\(v=vs.94\).aspx).

 Specific versions of Visual Studio, or specific Visual Studio extensions, may be required to develop particular application types and services using HTML and JavaScript. The following list has links to more information.

- To create cross-platform apps using Apache Cordova, [get the Visual Studio Tools for Apache Cordova](https://go.microsoft.com/fwlink/p/?LinkId=397606).

- To create [Windows Store](https://developer.microsoft.com/), [Windows Phone](https://developer.microsoft.com/), and universal apps (that support both platforms), [get the tools](https://developer.microsoft.com/windows/downloads).

- To create cloud-based services, see the [Microsoft Azure site](https://azure.microsoft.com/documentation/).

- To create web sites and web apps, [see the ASP.NET site](https://dotnet.microsoft.com/apps/aspnet/web-apps).

  > [!NOTE]
  > You can create an empty ASP.Net Web site and use it for HTML, CSS, and JavaScript programming. The Webconfig file provided by ASP.NET enables debugging in Visual Studio (or you can use F12 tools when you run the app).

  The JavaScript editor in Visual Studio provides IntelliSense support. For more info, see [JavaScript IntelliSense](../ide/javascript-intellisense.md).

## What's New in JavaScript
 New features for JavaScript are listed in the following table.

|Feature|Description|
|-------------|-----------------|
|Classes|New syntax supports declaration of [classes](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Statements/class).|
|Promises|[Promises](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Promise) allow easier and cleaner asynchronous coding. Promise constructors are supported, along with the `all` and `race` utility methods.|
|Iterators|Now you can iterate over iterable objects (including arrays, array-like objects, and iterators), invoking a custom iteration hook with statements to be executed for the value of each distinct property. For more information, see [Iterators and Generators](https://developer.mozilla.org/docs/Web/JavaScript/Guide/Iterators_and_Generators). **Note:**  Generators are not yet supported.|
|Arrow functions|The arrow function (=>) provides shorthand syntax for the `function` keyword which features a lexical `this` binding.|
|New methods for built-in objects|The [Array Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Array), [Math Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Math), [Number Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Number), [Object Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Object), and [String Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/String) built-in objects include many new utility functions and properties for manipulating and inspecting data.|
|Object literal enhancements|Objects now support computed properties, concise method definitions, and shorthand syntax for properties whose value is initialized to a same-named variable. For more information, see [Creating Objects](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Object).|
|Proxies|[Proxies](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Proxy) enable custom behavior for objects.|
|Rest parameters|Rest parameters allow you to turn consecutive arguments in a function call to an array. For more information, see [Functions](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Function).|
|Spread operator|The [spread operator](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Operators/Spread_operator) (`…`) expands iterable expressions into individual arguments. For example, `a.b(…array)` is approximately the same as `a.b.apply(a, array)`.|
|Symbols|[Symbol](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Symbol) objects allow properties to be added to existing objects with no possibility of interference with the existing object properties, with no unintended visibility, and with no other uncoordinated additions by other code.|
|Template strings|[Template strings](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Template_literals) are string literals that allow for expressions to be evaluated and concatenated with the string literal.|
|Unicode enhancements|Improvements have been made to Unicode support. For example, a new escape sequence format supports astral code points (code points with more than four hexadecimal digits). For more information, see [Special Characters](https://developer.mozilla.org/docs/Web/JavaScript/Guide/Regular_Expressions#Types_of_special_characters).|
|WeakSet|A [WeakSet](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/WeakSet) is a collection of objects that will be garbage collected if they are not referenced anywhere else.|
