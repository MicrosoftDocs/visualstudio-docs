---
title: JavaScript IntelliSense
ms.date: 06/28/2017
ms.topic: conceptual
ms.technology: vs-javascript
helpviewer_keywords:
  - "IntelliSense [JavaScript]"
  - "<reference> JavaScript XML tag"
  - "JavaScript Code Editor"
  - "XML code comments, JavaScript IntelliSense"
  - "reference JavaScript XML tag"
  - "JavaScript, IntelliSense"
  - "code comments, JavaScript IntelliSense"
  - "JavaScript, reference groups"
  - "JavaScript Editor"
  - "reference directives [JavaScript]"
  - "JavaScript, XML documentation comments"
  - "reference groups [JavaScript]"
  - "JavaScript, reference directives"
  - "IntelliSense [JavaScript], about"
  - "IntelliSense extensibility [JavaScript]"
  - "XML documentation comments [JavaScript]"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# JavaScript IntelliSense

Visual Studio provides a powerful JavaScript editing experience right out of the box. Powered by a TypeScript based language service, Visual Studio delivers richer IntelliSense, support for modern JavaScript features, and improved productivity features such as Go to Definition, refactoring, and more.

> [!NOTE]
> Starting in Visual Studio 2017, the JavaScript language service uses a new engine for the language service (called "Salsa"). Details are included in this article, and you can also read this [blog post](https://devblogs.microsoft.com/visualstudio/previewing-salsa-javascript-language-service-visual-studio-15/). The new editing experience also mostly applies to Visual Studio Code. See the [VS Code docs](https://code.visualstudio.com/docs/languages/javascript) for more info.

For more information about the general IntelliSense functionality of Visual Studio, see [Using IntelliSense](../ide/using-intellisense.md).

## What's new in the JavaScript language service in Visual Studio 2017

Starting in Visual Studio 2017, JavaScript IntelliSense displays a lot more information on parameter and member lists. This new information is provided by the TypeScript language service, which uses static analysis behind the scenes to better understand your code.

TypeScript uses several sources to build up this information:

- [IntelliSense based on type inference](#TypeInference)
- [IntelliSense based on JSDoc](#JsDoc)
- [IntelliSense based on TypeScript declaration files](#TsDeclFiles)
- [Automatic acquisition of type definitions](#Auto)

<a name="TypeInference"></a>

### IntelliSense based on type inference

In JavaScript, most of the time there is no explicit type information available. Luckily, it is usually fairly easy to figure out a type given the surrounding code context.
This process is called type inference.

For a variable or property, the type is typically the type of the value used to initialize it or the most recent value assignment.

```js
var nextItem = 10;
nextItem; // here we know nextItem is a number

nextItem = "box";
nextItem; // now we know nextItem is a string
```

For a function, the return type can be inferred from the return statements.

For function parameters, there is currently no inference, but there are ways to work around this using JSDoc or TypeScript *.d.ts* files (see later sections).

Additionally, there is special inference for the following:

- "ES3-style" classes, specified using a constructor function and assignments to the prototype property.
- CommonJS-style module patterns, specified as property assignments on the `exports` object, or assignments to the `module.exports` property.

```js
function Foo(param1) {
    this.prop = param1;
}
Foo.prototype.getIt = function () { return this.prop; };
// Foo will appear as a class, and instances will have a 'prop' property and a 'getIt' method.

exports.Foo = Foo;
// This file will appear as an external module with a 'Foo' export.
// Note that assigning a value to "module.exports" is also supported.
```

<a name="JsDoc"></a>

### IntelliSense based on JSDoc

Where type inference does not provide the desired type information (or to support documentation), type information may be provided explicitly via JSDoc annotations.  For example, to give a partially declared object a specific type, you can use the `@type` tag as shown below:

```js
/**
 * @type {{a: boolean, b: boolean, c: number}}
 */
var x = {a: true};
x.b = false;
x. // <- "x" is shown as having properties a, b, and c of the types specified
```

As mentioned, function parameters are never inferred. However, using the JSDoc `@param` tag you can add types to function parameters as well.

```js
/**
 * @param {string} param1 - The first argument to this function
 */
function Foo(param1) {
    this.prop = param1; // "param1" (and thus "this.prop") are now of type "string".
}
```

See [JSDoc support in JavaScript](https://github.com/Microsoft/TypeScript/wiki/JsDoc-support-in-JavaScript) for the JsDoc annotations currently supported.

<a name="TsDeclFiles"></a>
### IntelliSense based on TypeScript declaration files

Because JavaScript and TypeScript are now based on the same language service, they are able to interact in a richer way. For example, JavaScript IntelliSense can be provided for values declared in a *.d.ts* file (see [TypeScript documentation](https://www.typescriptlang.org/docs/handbook/declaration-files/introduction.html)), and types such as interfaces and classes declared in TypeScript are available for use as types in JsDoc comments.

Below, we show a simple example of a TypeScript definition file providing such type information (via an interface) to a JavaScript file in the same project (using a `JsDoc` tag).

![TypeScript definition file](https://raw.githubusercontent.com/wiki/Microsoft/TypeScript/images/decl1.png)

<a name="Auto"></a>
### Automatic acquisition of type definitions

In the TypeScript world, most popular JavaScript libraries have their APIs described by *.d.ts* files, and the most common repository for such definitions is on [DefinitelyTyped](https://github.com/DefinitelyTyped/DefinitelyTyped).

By default, the Salsa language service will try to detect which JavaScript libraries are in use and automatically download and reference the corresponding *.d.ts* file that describes the library in order to provide richer IntelliSense. The files are downloaded to a cache located under the user folder at *%LOCALAPPDATA%\Microsoft\TypeScript*.

> [!NOTE]
> This feature is **disabled** by default if using a *tsconfig.json* configuration file, but may be set to enabled as outlined further below.

Currently auto-detection works for dependencies downloaded from npm (by reading the *package.json* file), Bower (by reading the *bower.json* file), and for loose files in your project that match a list of roughly the top 400 most popular JavaScript libraries. For example, if you have *jquery-1.10.min.js* in your project, the file *jquery.d.ts* will be fetched and loaded in order to provide a better editing experience. This *.d.ts* file will have no impact on your project.

If you do not wish to use auto-acquisition, disable it by adding a configuration file as outlined below. You can still place definition files for use directly within your project manually.

## See also

- [Using IntelliSense](../ide/using-intellisense.md)
- [JavaScript support (Visual Studio for Mac)](/visualstudio/mac/javascript)