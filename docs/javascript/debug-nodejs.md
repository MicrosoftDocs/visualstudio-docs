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

You can debug JavaScript and TypeScript code using Visual Studio. You can set and hit breakpoints, attach the debugger, inspect variables, view the call stack, and perform other debugging functions.

## Debug server-side script

1. With your project open in Visual Studio, open a server-side JavaScript file (such as *server.js*), click in the gutter to the left gutter to set a breakpoint:

    ![Set a breakpoint](../javascript/media/tutorial-nodejs-react-set-breakpoint.png)

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run.

1. To run your app, press **F5** (**Debug** > **Start Debugging**).

    The debugger pauses at the breakpoint you set (the current statement is marked in yellow). Now, you can inspect your app state by hovering over variables that are currently in scope, using debugger windows like the **Locals** and **Watch** windows.

1. Press **F5** to continue the app.

1. If you want to use the Chrome Developer Tools or F12 Tools, press **F12**. You can use these tools to examine the DOM and interact with the app using the JavaScript Console.

## Debug client-side script

Visual Studio provides debugging support for Chrome and Internet Explorer only. In most scenarios, it will automatically hit breakpoints in JavaScript and TypeScript code and in embedded scripts on HTML files.

If your source is minified or created by a transpiler like TypeScript or Babel, the use of [sourcemaps](#generate_sourcemaps) might be required. Without sourcemaps, you can still attach the debugger to a running script, but you may only be able to hit breakpoints in the minified or transpiled file, not in the pre-minified or pre-transpiled source. For some JavaScript frameworks such as Vue.js, where minified script gets passed as a string to an `eval` statement, you need sourcemaps for effective debugging in Visual Studio.

To attach the debugger from Visual Studio and hit breakpoints in client-side code, in most scenarios the debugger needs help to identify the correct process. Here is one way to enable this using Chrome.

### Attach the debugger to client-side script using Chrome

1. Close all Chrome windows.

2. Open the **Run** command from the Windows **Start** button (right-click and choose **Run**), and enter the following command:

    `chrome.exe --remote-debugging-port=9222`

    This starts Chrome with debugging enabled.

3. Switch to Visual Studio and set a breakpoint in your source code. (Set the breakpoint in a line of code that allows breakpoints, such as a `return` statement or a `var` declaration).

    ![Set a breakpoint](../javascript/media/tutorial-nodejs-react-set-breakpoint-client-code.png)

    If you need to find particular code in a large file, use **Ctrl**+**F** (**Edit** > **Find and Replace** > **Quick Find**).

4. With Chrome selected as the debug target in Visual Studio, press **Ctrl**+**F5** (**Debug** > **Start Without Debugging**) to run the app in the browser.

    The app opens in a new browser tab.

    If Chrome is available on your machine, but does not show up as an option, choose **Browse With** from the debug target dropdown list, and select Chrome as the default browser target (choose **Set as Default**).

5. Choose **Debug** > **Attach to Process**.

6. In the **Attach to Process** dialog box, choose **Webkit code** in the **Attach to** field, type **chrome** in the filter box to filter the search results.

    **Webkit** is the required value for Chrome, which is a Webkit-based browser.

7. Select the Chrome process with the correct host port (1337 in this illustration), and select **Attach**.

    ![Attach to process](../javascript/media/tutorial-nodejs-react-attach-to-process.png)

    You know the debugger has attached correctly when the DOM Explorer and the JavaScript Console open in Visual Studio. These debugging tools are similar to Chrome Developer Tools and F12 Tools for Edge.

    > [!NOTE]
    > If the debugger does not attach and you see the message `Unable to attach to the process. An operation is not legal in the current state`, use the Task Manager to close all instances of Chrome before starting Chrome in debugging mode. Chrome Extensions may be running and preventing full debug mode.

8. If the code with the breakpoint already executed, refresh your browser page to hit the breakpoint.

    While paused in the debugger, you can examine your app state by hovering over variables and using debugger windows. You can advance the debugger by stepping through code (**F5**, **F10**, and **F11**).

    For minified or transpiled JavaScript, you may hit the breakpoint in either the transpiled JavaScript or its mapped location in your TypeScript file (using sourcemaps), depending on your environment and browser state. Either way, you can step through code and examine variables.

    * If you need to break into code in a TypeScript file and are unable to do it, use **Attach to Process** as described in the previous steps to attach the debugger. Then open the dynamically generated TypeScript file from Solution Explorer by opening **Script Documents** > **filename.tsx**, set a breakpoint, and refresh the page in your browser (set the breakpoint in a line of code that allows breakpoints, such as the `return` statement or a `var` declaration).

        Alternatively, if you need to break into code in a TypeScript file and are unable to do it, try using the `debugger;` statement in the TypeScript file, or set breakpoints in the Chrome Developer Tools instead.

    * If you need to break into code in a transpiled JavaScript file (for example, *app-bundle.js*), and are unable to do it, remove the sourcemap file, *filename.js.map*.

     > [!TIP]
     > Once you attach to the process the first time by following these steps, you can quickly reattach to the same process in Visual Studio 2017 by choosing **Debug** > **Reattach to Process**.

## <a name="generate_sourcemaps"></a> Generate source maps for debugging

Visual Studio has the capability to use and generate source maps on JavaScript source files. This is often required if your source is minified or created by a transpiler like TypeScript or Babel. By default, a TypeScript project in Visual Studio will generate sourcemaps for you.

> [!NOTE]
> If you are new to source maps, please read [Introduction to JavaScript Source Maps](https://www.html5rocks.com/en/tutorials/developertools/sourcemaps/) before before continuing.

To configure more advanced settings, use either a tsconfig.json or the project settings, but not both.

### Configure source maps using a tsconfig.json file
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
- **Generate source maps** (sourceMap *tsconfig.json* equivalent): Generates corresponding .map file.
- **Specify root directory of source maps** (mapRoot *tsconfig.json* equivalent): Specifies the location where debugger should locate map files instead of generated locations. Use this flag if the .map files will be located at run-time in a different location than the .js files. The location specified will be embedded in the sourceMap to direct the debugger where the map files will be located.
- **Specify root directory of TypeScript files** (sourceRoot tsconfig.json equivalent): Specifies the location where debugger should locate TypeScript files instead of source locations. Use this flag if the sources will be located at run-time in a different location than that at design-time. The location specified will be embedded in the sourceMap to direct the debugger where the source files will be located.

### Debug JavaScript in dynamic files using Razor (ASP.NET)

Visual Studio provides debugging support for Chrome and Internet Explorer only. It will automatically attach breakpoints to JavaScript/TypeScript and embedded scripts on HTML files.

Debugging dynamically-generated files is not automatic. You cannot automatically hit breakpoints on files generated with Razor syntax (cshtml, vbhtml). There are two approaches you can use to debug this kind of files:

1. **Place the `debugger;` statement where you want to break**: This will cause the dynamic script to stop execution and start debugging immediately while being created.
1. **Load the page and open the dynamic document on Visual Studio**: You'll need to open the dynamic file while debugging, place your breakpoint and refresh the page for this one to work. Depending if you're using Chrome or Internet Explorer you'll find the file using one of the following strategies:

   For Chrome, go to *Solution Explorer > Script Documents > YourPageName*. **Note**: When using Chrome you might get a screen indicating no source available between `<script>` tags. This is OK, just continue debugging.

   For Internet Explorer, go to *Solution Explorer > Script Documents > Windows Internet Explorer > YourPageName*.

Check more details on [Client-side debugging of ASP.NET projects in Google Chrome](https://blogs.msdn.microsoft.com/webdev/2016/11/21/client-side-debugging-of-asp-net-projects-in-google-chrome/).
