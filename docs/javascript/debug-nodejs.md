---
title: "Debug a Node.js app"
description: Visual Studio provides support for debugging Node.js applications in Visual Studio
ms.custom: ""
ms.date: "12/03/2018"
ms.technology: vs-nodejs
ms.topic: "conceptual"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---

# Debug a Node.js app in Visual Studio

You can debug server-side code 

## Debug client-side script

Visual Studio provides debugging support for Chrome and Internet Explorer only. It will automatically attach breakpoints to JavaScript/TypeScript and embedded scripts on HTML files.

Dynamically generated files are not automatic though. See below to understand how the process works.

### Debug JavaScript in dynamic files (using Razor)

Breakpoints on files generated with Razor syntax (cshtml, vbhtml) are not automatically attached when debugging. There are two approaches you can do in order to debug this kind of files:

1. **Place the `debugger;` statement where you want to break**: This will cause the dynamic script to stop execution and start debugging immediately while being created.
1. **Load the page and open the dynamic document on Visual Studio**: You'll need to open the dynamic file while debugging, place your breakpoint and refresh the page for this one to work. Depending if you're using Chrome or Internet Explorer you'll find the file using one of the following strategies:

   For Chrome, go to *Solution Explorer > Script Documents > YourPageName*. **Note**: When using Chrome you might get a screen indicating no source available between `<script>` tags. This is OK, just continue debugging.

   For Internet Explorer, go to *Solution Explorer > Script Documents > Windows Internet Explorer > YourPageName*.

Check more details on [Client-side debugging of ASP.NET projects in Google Chrome](https://blogs.msdn.microsoft.com/webdev/2016/11/21/client-side-debugging-of-asp-net-projects-in-google-chrome/).

## Debug with source maps

Visual Studio has the capability to use and generate source maps on JavaScript source files. This is often required if your source is minified or created by a transpiler like TypeScript or Babel. By default it will generate it for you.

> [!NOTE]
> If you are new to source maps, please read [Introduction to JavaScript Source Maps](https://www.html5rocks.com/en/tutorials/developertools/sourcemaps/) before before continuing.

See below if you'll like to know how to configure more advance settings. You can use either a tsconfig.json or the project settings, but not both.

### Configure source maps using tsconfig.json file
By adding a *tsconfig.json* file to your project you will indicate that the directory root is a TypeScript project. Just right click *project > Add > New Item > Web > Scripts > TypeScript JSON Configuration File* to generate a file like below:

tsconfig.json:

```json
{
  "compilerOptions": {
    "noImplicitAny": false,
    "noEmitOnError": true,
    "removeComments": false,
    "sourceMap": true,
    "target": "es5"
  },
  "exclude": [
    "node_modules",
    "wwwroot"
  ]
}
```

#### tsconfig compiler options
- **inlineSourceMap**: Emit a single file with source maps instead of having a separate file.
- **inlineSources**: Emit the source alongside the sourcemaps within a single file; requires *inlineSourceMap* or *sourceMap* to be set.
- **mapRoot**: Specifies the location where debugger should locate map files instead of generated locations. Use this flag if the .map files will be located at run-time in a different location than the .js files. The location specified will be embedded in the sourceMap to direct the debugger where the map files will be located.
- **sourceMap**: Generates corresponding .map file.
- **sourceRoot**: Specifies the location where debugger should locate TypeScript files instead of source locations. Use this flag if the sources will be located at run-time in a different location than that at design-time. The location specified will be embedded in the sourceMap to direct the debugger where the source files will be located.

For more details about the compiler options check the page [Compiler Options](https://www.typescriptlang.org/docs/handbook/compiler-options.html) on the TypeScript Handbook.

### Configure source maps using project settings
You can also configure the souce map settings on the project properties by right click *Project > Properties > TypeScript Build > Debugging*.

These project settings are available.
- **Generate source maps** (sourceMap tsconfig.json equivalent): Generates corresponding .map file.
- **Specify root directory of source maps** (mapRoot tsconfig.json equivalent): Specifies the location where debugger should locate map files instead of generated locations. Use this flag if the .map files will be located at run-time in a different location than the .js files. The location specified will be embedded in the sourceMap to direct the debugger where the map files will be located.
- **Specify root directory of TypeScript files** (sourceRoot tsconfig.json equivalent): Specifies the location where debugger should locate TypeScript files instead of source locations. Use this flag if the sources will be located at run-time in a different location than that at design-time. The location specified will be embedded in the sourceMap to direct the debugger where the source files will be located.