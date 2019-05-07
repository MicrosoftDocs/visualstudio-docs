---
title: "Debug a JavaScript or TypeScript app"
description: Visual Studio provides support for debugging JavaScript and TypeScript apps in Visual Studio
ms.date: "12/03/2018"
ms.topic: "conceptual"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---

# Debug a JavaScript or TypeScript app in Visual Studio

You can debug JavaScript and TypeScript code using Visual Studio. You can set and hit breakpoints, attach the debugger, inspect variables, view the call stack, and use other debugging features.

> [!TIP]
> If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free. Depending on the type of app development you're doing, you may need to install the **Node.js development workload** with Visual Studio.

## Debug server-side script

1. With your project open in Visual Studio, open a server-side JavaScript file (such as *server.js*), click in the gutter to the left gutter to set a breakpoint:

    ![Set a breakpoint](../javascript/media/tutorial-nodejs-react-set-breakpoint.png)

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run.

1. To run your app, press **F5** (**Debug** > **Start Debugging**).

    The debugger pauses at the breakpoint you set (the current statement is marked in yellow). Now, you can inspect your app state by hovering over variables that are currently in scope, using debugger windows like the **Locals** and **Watch** windows.

1. Press **F5** to continue the app.

1. If you want to use the Chrome Developer Tools or F12 Tools, press **F12**. You can use these tools to examine the DOM and interact with the app using the JavaScript Console.

## Debug client-side script

Visual Studio provides debugging support for Chrome and Internet Explorer only. In some scenarios, the debugger automatically hits breakpoints in JavaScript and TypeScript code and in embedded scripts on HTML files.

If your source is minified or created by a transpiler like TypeScript or Babel, the use of [source maps](#generate_sourcemaps) is required for the best debugging experience. Without source maps, you can still attach the debugger to a running client-side script. However, you may only be able to set and hit breakpoints in the minified or transpiled file, not in the original source file. For example, in a Vue.js app, minified script gets passed as a string to an `eval` statement, and there is no way to step through this code effectively using the Visual Studio debugger, unless you use source maps. In some complex debugging scenarios, you might also use Chrome Developer Tools or F12 Tools for Microsoft Edge.

To attach the debugger from Visual Studio and hit breakpoints in client-side code, the debugger typically needs help to identify the correct process. Here is one way to enable this using Chrome.

### Attach the debugger to client-side script using Chrome

1. Close all Chrome windows.

    This action is necessary before you can run Chrome in debug mode.

2. Open the **Run** command from the Windows **Start** button (right-click and choose **Run**), and enter the following command:

    `chrome.exe --remote-debugging-port=9222`

    This command starts Chrome with debugging enabled.

    ::: moniker range=">=vs-2019"

    > [!NOTE]
    > You can also set the `--remote-debugging-port` flag at browser launch by selecting **Browse With...** > from the **Debug** toolbar, then choosing **Add**, and then setting the flag in the **Arguments** field. Use a different friendly name for the browser such as **Chrome with Debugging**. For details, see the [Release Notes](https://docs.microsoft.com/visualstudio/releases/2019/release-notes-preview#browser-cli-params-support).

    ::: moniker-end

3. Switch to Visual Studio and set a breakpoint in your source code. (Set the breakpoint in a line of code that allows breakpoints, such as a `return` statement or a `var` declaration).

    ![Set a breakpoint](../javascript/media/tutorial-nodejs-react-set-breakpoint-client-code.png)

    If you need to find particular code in a large, generated file, use **Ctrl**+**F** (**Edit** > **Find and Replace** > **Quick Find**).

4. With Chrome selected as the debug target in Visual Studio, press **Ctrl**+**F5** (**Debug** > **Start Without Debugging**) to run the app in the browser.

    The app opens in a new browser tab.

    If Chrome is available on your machine, but does not show up as an option, choose **Browse With** from the debug target dropdown list, and select Chrome as the default browser target (choose **Set as Default**).

5. Choose **Debug** > **Attach to Process**.

6. In the **Attach to Process** dialog box, choose **WebKit code** in the **Attach to** field, type **chrome** in the filter box to filter the search results.

    **WebKit code** is the required value for Chrome, which is a Webkit-based browser.

7. Select the Chrome process with the correct host port (1337 in this illustration), and select **Attach**.

    ![Attach to process](../javascript/media/tutorial-nodejs-react-attach-to-process.png)

    You know the debugger has attached correctly when the DOM Explorer and the JavaScript Console open in Visual Studio. These debugging tools are similar to Chrome Developer Tools and F12 Tools for Microsoft Edge.

    > [!NOTE]
    > If the debugger does not attach and you see the message "Unable to attach to the process. An operation is not legal in the current state", use the Task Manager to close all instances of Chrome before starting Chrome in debugging mode. Chrome Extensions may be running and preventing full debug mode.

8. If the code with the breakpoint already executed, refresh your browser page to hit the breakpoint.

    While paused in the debugger, you can examine your app state by hovering over variables and using debugger windows. You can advance the debugger by stepping through code (**F5**, **F10**, and **F11**).

    For minified or transpiled JavaScript, you may hit the breakpoint in either the transpiled JavaScript or its mapped location in your TypeScript file (using source maps), depending on your environment and browser state. Either way, you can step through code and examine variables.

    * If you need to break into code in a TypeScript file and are unable to do it, use **Attach to Process** as described in the previous steps to attach the debugger. Then open the dynamically generated TypeScript file from Solution Explorer by opening **Script Documents** > **filename.tsx**, set a breakpoint, and refresh the page in your browser (set the breakpoint in a line of code that allows breakpoints, such as the `return` statement or a `var` declaration).

        Alternatively, if you need to break into code in a TypeScript file and are unable to do it, try using the `debugger;` statement in the TypeScript file, or set breakpoints in the Chrome Developer Tools instead.

    * If you need to break into code in a transpiled JavaScript file (for example, *app-bundle.js*), and are unable to do it, remove the source map file, *filename.js.map*.

     > [!TIP]
     > Once you attach to the process the first time by following these steps, you can quickly reattach to the same process by choosing **Debug** > **Reattach to Process**.

## <a name="generate_sourcemaps"></a> Generate source maps for debugging

Visual Studio has the capability to use and generate source maps on JavaScript source files. This is often required if your source is minified or created by a transpiler like TypeScript or Babel. The options available depend on the project type.

* A TypeScript project in Visual Studio generates source maps for you by default.

* In a JavaScript project, you need to generate source maps using a bundler like webpack and a compiler like the TypeScript compiler (or Babel), which you can add to your project. For the TypeScript compiler, you must also add a *tsconfig.json* file. For an example that shows how to do this using a basic webpack configuration, see [Create a Node.js app with React](../javascript/tutorial-nodejs-with-react-and-jsx.md).

> [!NOTE]
> If you are new to source maps, please read [Introduction to JavaScript Source Maps](https://www.html5rocks.com/en/tutorials/developertools/sourcemaps/) before continuing.

To configure advanced settings for source maps, use either a *tsconfig.json* or the project settings in a TypeScript project, but not both.

### Configure source maps using a tsconfig.json file

If you add a *tsconfig.json* file to your project, Visual Studio treats the directory root as a TypeScript project. To add the file, right-click your project in Solution Explorer, and then choose **Add > New Item > Web > Scripts > TypeScript JSON Configuration File**. A *tsconfig.json* file like the following gets added to your project.

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

#### Compiler options for tsconfig.json

* **inlineSourceMap**: Emit a single file with source maps instead of creating a separate source map for each source file.
* **inlineSources**: Emit the source alongside the source maps within a single file; requires *inlineSourceMap* or *sourceMap* to be set.
* **mapRoot**: Specifies the location where the debugger should find source map (*.map*) files instead of the default location. Use this flag if the run-time *.map* files need to be in a different location than the *.js* files. The location specified is embedded in the source map to direct the debugger to the location of the *.map* files.
* **sourceMap**: Generates a corresponding *.map* file.
* **sourceRoot**: Specifies the location where the debugger should find TypeScript files instead of the source locations. Use this flag if the run-time sources need to be in a different location than the location at design-time. The location specified is embedded in the source map to direct the debugger to where the source files are located.

For more details about the compiler options, check the page [Compiler Options](https://www.typescriptlang.org/docs/handbook/compiler-options.html) on the TypeScript Handbook.

### Configure source maps using project settings

You can also configure the source map settings using project properties by right-clicking the project and then choosing **Project > Properties > TypeScript Build > Debugging**.

These project settings are available.

* **Generate source maps** (equivalent to **sourceMap** in *tsconfig.json*): Generates corresponding *.map* file.
* **Specify root directory of source maps** (equivalent to **mapRoot** in *tsconfig.json*): Specifies the location where the debugger should find map files instead of the generated locations. Use this flag if the run-time *.map* files need to be located in a different location than the .js files. The location specified is embedded in the source map to direct the debugger to where the map files are located.
* **Specify root directory of TypeScript files** (equivalent to **sourceRoot** in *tsconfig.json*): Specifies the location where the debugger should find TypeScript files instead of source locations. Use this flag if the run-time source files need to be in a different location than the location at design-time. The location specified is embedded in the source map to direct the debugger to where the source files are located.

## Debug JavaScript in dynamic files using Razor (ASP.NET)

Visual Studio provides debugging support for Chrome and Internet Explorer only. It will automatically attach breakpoints to JavaScript/TypeScript and embedded scripts on HTML files.

Debugging dynamically generated files is not automatic. You cannot automatically hit breakpoints on files generated with Razor syntax (cshtml, vbhtml). There are two approaches you can use to debug this kind of file:

* **Place the `debugger;` statement where you want to break**: This causes the dynamic script to stop execution and start debugging immediately while it is being created.
* **Load the page and open the dynamic document on Visual Studio**: You'll need to open the dynamic file while debugging, set your breakpoint, and refresh the page for this method to work. Depending on whether you're using Chrome or Internet Explorer, you'll find the file using one of the following strategies:

   For Chrome, go to **Solution Explorer > Script Documents > YourPageName**.

    > [!NOTE]
    > When using Chrome, you might get a message **no source is available between \<script> tags**. This is OK, just continue debugging.

   For Internet Explorer, go to **Solution Explorer > Script Documents > Windows Internet Explorer > YourPageName**.

For more information, see [Client-side debugging of ASP.NET projects in Google Chrome](https://devblogs.microsoft.com/aspnet/client-side-debugging-of-asp-net-projects-in-google-chrome/).