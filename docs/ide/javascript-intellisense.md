---
title: "JavaScript IntelliSense | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
ms.assetid: af1a3171-c9d8-45a3-9c96-a763e3b163ef
caps.latest.revision: 63
author: "kempb"
ms.author: "kempb"
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
# JavaScript IntelliSense
[!include[vs_dev15](../misc/includes/vs_dev15_md.md)] provides a powerful JavaScript editing experience right out of the box. Powered by a TypeScript based language service, Visual Studio delivers richer IntelliSense, support for modern JavaScript features, and improved productivity features such as Go to Definition, refactoring, and more.

> [!NOTE]
>  The JavaScript language service in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)] uses a new engine for the language service ("salsa"). Details are included here in this topic, and you might also want to read this [blog post](https://blogs.msdn.microsoft.com/visualstudio/2016/04/08/previewing-salsa-javascript-language-service-visual-studio-15/). The new editing experience also mostly applies in VS Code. See the [VS Code docs](https://code.visualstudio.com/docs/languages/javascript) for more info.

For more information about the general IntelliSense functionality of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)], see [Using IntelliSense](../ide/using-intellisense.md). 

## What's New in the JavaScript language service in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)]

- Richer IntelliSense

    JavaScript IntelliSense in [!include[vs_dev15](../misc/includes/vs_dev15_md.md)] will now display a lot more information on parameter and member lists.
This new information is provided by the TypeScript language service, which uses static analysis behind the scenes to better understand your code.
TypeScript uses several sources to build up this information.
    - [IntelliSense based on type inference](#TypeInference)
    - [IntelliSense based on JSDoc](#JsDoc)
    - [IntelliSense based on TypeScript Declaration Files](#TSDeclFiles)

- [Automatic acquisition of type definitions](#Auto)
- [Support for ES6 and beyond](#ES6)
- [JSX syntax support](#JSX)

## <a name="TypeInference"></a>IntelliSense based on type inference
In JavaScript, most of the time there is no explicit type information available. 
Luckily, it is usually fairly easy to deduce a type given the surrounding code context.
This process is called type inference.

For a variable or property, the type is typically the type of the value used to initialize it or the most recent value assignment. 

```js
var nextItem = 10;
nextItem; // here we know nextItem is a number

nextItem = "box";
nextItem; // now we know nextItem is a string
```

For a function, the return type can be inferred from the return statements. 

For function parameters, there is currently no inference, but there are ways to work around this using JSDoc or TypeScript `.d.ts` files (see later sections).

Additionally, there is special inference for the following:
 - "ES3-style" classes, specified using a constructor function and assignments to
the prototype property.
 - CommonJS-style module patterns, specified as property assignments on the `exports`
object, or assignments to the `module.exports` property.

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

## <a name="JsDoc"></a> IntelliSense based on JSDoc

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
 
See [this doc](https://github.com/Microsoft/TypeScript/wiki/JsDoc-support-in-JavaScript) 
for the JsDoc annotations currently supported.

## <a name="TsDeclFiles"></a> IntelliSense based on TypeScript Declaration Files

Because JavaScript and TypeScript are now based on the same language service, they are able to interact in a richer way. For example, JavaScript IntelliSense can be provided for values declared in a `.d.ts` file ([more info](https://github.com/Microsoft/TypeScript-Handbook/blob/master/pages/Writing%20Definition%20Files.md)), and types such as interfaces and classes declared in TypeScript are available for use as types in JsDoc comments. 

Below, we show a simple example of a TypeScript definition file providing such type information (via an interface) to a JavaScript file in the same project (using a JsDoc tag).

_**TypeScript declarations used in JavaScript**_

<img src="https://raw.githubusercontent.com/wiki/Microsoft/TypeScript/images/decl1.png" height="400" width="640"/>

## <a name="Auto"></a> Automatic acquisition of type definitions
In the TypeScript world, most popular JavaScript libraries have their APIs described by `.d.ts` files, and the most common repository for such definitions is on [DefinitelyTyped](https://github.com/DefinitelyTyped/DefinitelyTyped).

By default, the Salsa language service will try to detect which JavaScript libraries are in use and automatically download and reference the corresponding `.d.ts` file that describes the library in order to provide richer IntelliSense. The files are downloaded to a cache located under the user folder at `%LOCALAPPDATA%\Microsoft\TypeScript`. 

> [!NOTE]
> This feature is **disabled** by default if using a `tsconfig.json` configuration file, but may be set to enabled as outlined further below).

Currently auto-detection works for dependencies downloaded from npm (by reading the `package.json` file), Bower (by reading the `bower.json` file), and for loose files in your project that match a list of roughly the top 400 most popular JavaScript libraries. For example, if you have `jquery-1.10.min.js` in your project, the file `jquery.d.ts` will be fetched and loaded in order to provide a better editing experience. This `.d.ts` file will have no impact on your project. 

If you do not wish to use auto-acquisition, disable it by adding a configuration file as outlined below. You can still place definition files for use directly within your project manually.

## <a name="ES6"></a> Support for ES6 and beyond

ES6, or ECMAScript 2015, is the next version of JavaScript. It brings new syntax to the language such as classes, arrow functions, `let`/`const`, and more. All of this new syntax is supported in Visual Studio.

One of the key features TypeScript provides is the ability to use ES6 features, and emit code that can execute in JavaScript runtimes that don't yet understand those newer features. This is commonly known as "transpiling". Because JavaScript uses the same language service, it too can take advantage of ES6+ to ES5 transpilation.

Before this can be set up, some understanding of the configuration options is required.  TypeScript is configured via a `tsconfig.json` file. In the absence of such a file, some default values are used. For compatibility reasons, these defaults are different in a context where only JavaScript files (and optionally `.d.ts` files) are present. To compile JavaScript files, a `tsconfig.json` file must be added, and some of these defaults must then be set explicitly.

The required settings for the tsconfig file are outlined below:

 - `allowJs`: This value must be set to `true` for JavaScript files to be recognized.
By default this is `false`, as TypeScript compiles to JavaScript, and this is necessary to avoid the compiler including files it just compiled.
 - `outDir`: This should be set to a location not included in the project, in order that the emitted JavaScript files are not detected and then included in the project (see `exclude` below).
 - `module`: If using modules, this setting tells the compiler which module format the emitted code should use (e.g. `commonjs` for Node or bundlers such as Browserify).
 - `exclude`: This setting states which folders not to include in the project. 
 The output location, as well as non-project folders such as `node_modules` or `temp`, should be added to this setting.
 - `enableAutoDiscovery`: This setting enables the automatic detection and download of definition files as outlined above.
 - `compileOnSave`: This setting tells the compiler if it should recompile any time a source file is saved in Visual Studio.

In order to convert JavaScript files to CommonJS modules in an `./out` folder, settings
similar to the below might be included in a `tsconfig.json` file.

```json
{
  "compilerOptions": {
    "module": "commonjs",
    "allowJs": true,
    "outDir": "out"
  },
  "exclude": [
    "node_modules",
    "wwwroot",
    "out"
  ],
  "compileOnSave": true,
  "typingOptions": {
    "enableAutoDiscovery": true
  }
}
```

With the above settings in place, if a source file (`./app.js`) existed which contains several ECMAScript 2015 language features as shown below:

```js
import {Subscription} from 'rxjs/Subscription';

class Foo {
    sayHi(name) {
        return `Hi ${name}, welcome to Salsa!`;
    }
}

export let sqr = x => x * x;
export default Subscription;
```

Then a file would be emitted to `./out/app.js` targeting ECMAScript 5 (the default) that looks something like the below:

```js
"use strict";
var Subscription_1 = require('rxjs/Subscription');
var Foo = (function () {
    function Foo() {
    }
    Foo.prototype.sayHi = function (name) {
        return "Hi " + name + ", welcome to Salsa!";
    };
    return Foo;
}());
exports.sqr = function (x) { return x * x; };
Object.defineProperty(exports, "__esModule", { value: true });
exports.default = Subscription_1.Subscription;
//# sourceMappingURL=app.js.map
```

## <a name="JSX"></a> JSX syntax support

JavaScript in Visual Studio 2017 has rich support for the JSX syntax. JSX is a syntax set that allows HTML tags within JavaScript files. 

The illustration below shows a React component defined in the `comps.tsx` TypeScript file, and then this component being used from the `app.jsx` file, complete with IntelliSense for completions and documentation within the JSX expressions.
You don't need TypeScript here, this specific example just happens to contain some TypeScript code as well.
<img src="https://raw.githubusercontent.com/wiki/Microsoft/TypeScript/images/react.png" height="500" width="640"/>

> [!NOTE]
> To convert the JSX syntax to React calls, the setting `"jsx": "react"` must be added to the `compilerOptions` in the `tsconfig.json` file outlined above.

The JavaScript file created at `./out/app.js' upon build would contain the code:

```js
"use strict";
var comps_1 = require('./comps');
var x = React.createElement(comps_1.RepoDisplay, {description: "test"});
```
