---
title: "Debug a JavaScript or TypeScript app"
description: Visual Studio provides support for debugging JavaScript and TypeScript apps in Visual Studio.
ms.date: "06/28/2022"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-javascript
ms.custom: devdivchpfy22
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Debug a JavaScript or TypeScript app in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can debug JavaScript and TypeScript code using Visual Studio. You can hit breakpoints, attach the debugger, inspect variables, view the call stack, and use other debugging features.

> [!TIP]
> If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free. Depending on the type of app development you're doing, you may need to install the **Node.js development workload** with Visual Studio.

## Debug server-side script

1. With your project open in Visual Studio, open a server-side JavaScript file (such as *server.js*), click in the gutter to set a breakpoint:

    :::image type="content" source="media/tutorial-nodejs-react-set-breakpoint.png" alt-text="Screenshot of the Visual Studio code window showing JavaScript code. A red dot in the left gutter indicates that a breakpoint is set.":::

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code, so you can look at the values of variables or the behavior of memory, or whether or not a branch of code is getting run.

1. To run your app, press **F5** (**Debug** > **Start Debugging**).

    The debugger pauses at the breakpoint you set (IDE highlights the statement in the yellow background). Now, you can inspect your app state by hovering over variables currently in scope, using debugger windows like the **Locals** and **Watch** windows.

    :::image type="content" source="media/tutorial-nodejs-react-set-breakpoint-debug-pause.png" alt-text="Screenshot of the Visual Studio code window showing JavaScript code. A red dot in the left gutter with yellow arrow indicates pause of execution of code.":::

1. Press **F5** to continue the app.

1. If you want to use the Chrome Developer Tools, press **F12** in the Chrome browser. Using these tools, you can examine the DOM or interact with the app using the JavaScript Console.

## Debug client-side script

Visual Studio provides client-side debugging support only for Chrome and Microsoft Edge (Chromium). In some scenarios, the debugger automatically hits breakpoints in JavaScript and TypeScript codes and embedded scripts on HTML files. For debugging client-side script in ASP.NET apps, see the blog post [Debug JavaScript in Microsoft Edge](https://devblogs.microsoft.com/visualstudio/debug-javascript-in-microsoft-edge-from-visual-studio/) and this [post for Google Chrome](https://devblogs.microsoft.com/aspnet/client-side-debugging-of-asp-net-projects-in-google-chrome). For debugging TypeScript in ASP.NET Core, see [Create an ASP.NET Core app with TypeScript](tutorial-aspnet-with-typescript.md).

>[!NOTE]
> For ASP.NET and ASP.NET Core, debugging embedded scripts in *.CSHTML* files is not supported. JavaScript code must be in separate files to enable debugging.

For applications other than ASP.NET, follow the steps described here.

### Prepare your app for debugging

If your source is minified or created by a transpiler like a TypeScript or Babel, use [source maps](#generate_source_maps) for the best debugging experience. You can even attach the debugger to a running client-side script without the source maps. However, you may only be able to set and hit breakpoints in the minified or transpiled file, not in the source file. For example, in a Vue.js app, the minified script gets passed as a string to an ```eval``` statement, and there's no way to step through this code effectively using the Visual Studio debugger unless you use source maps. Use Chrome Developer Tools or F12 Tools for Microsoft Edge for complex debugging scenarios.

For help with generating source maps, see [Generate source maps for debugging](#generate_source_maps).

### <a name="prepare_the_browser_for_debugging"></a> Prepare the browser for debugging

For this scenario, use either Microsoft Edge (Chromium) or Chrome.

1. Close all windows for the target browser.

   Other browser instances can prevent the browser from opening with debugging enabled. (Browser extensions may be running and intercept full debug mode, so you may need to open Task Manager to find and close unexpected instances of Chrome.)

   For best results, shut down all instances of Chrome, even if you're working with Microsoft Edge (Chromium). Both the browsers use the same chromium code base.

1. Start your browser with debugging enabled.

     Starting in Visual Studio 2019, you can set the ```--remote-debugging-port=9222``` flag at browser launch by selecting **Browse With...** > from the **Debug** toolbar, then choose **Add**, and then set the flag in the **Arguments** field. Use a different friendly name for the browser, like **Edge with Debugging** or **Chrome with Debugging**. For details, see the [Release Notes](/visualstudio/releases/2019/release-notes-v16.2).

    :::image type="content" source="media/tutorial-nodejs-react-edge-with-debugging.png" alt-text="Screenshot of setting your browser options to open with debugging enabled.":::

    Alternatively, open the **Run** command from the Windows **Start** button (right-click and choose **Run**), and enter the following command:

    `msedge --remote-debugging-port=9222`

    or,

    `chrome.exe --remote-debugging-port=9222`
  
    This starts your browser with debugging enabled.

    The app isn't yet running, so you get an empty browser page.

### Attach the debugger to client-side script

To attach the debugger from Visual Studio and hit breakpoints in the client-side code, it needs help with identifying the correct process. Here's one way to enable it.

1. Switch to Visual Studio and then set a breakpoint in your source code, which might be a JavaScript file, TypeScript file, or a JSX file. (Set the breakpoint in a line of code that allows breakpoints, such as a return statement or a var declaration.)

    :::image type="content" source="media/tutorial-nodejs-react-set-breakpoint-client-code.png" alt-text="Screenshot of the Visual Studio code window. A return statement is selected and a red dot in the left gutter indicates that a breakpoint is set.":::

    To find the specific code in a transpiled file, use **Ctrl**+**F** (**Edit** > **Find and Replace** > **Quick Find**).

    For client-side code, to hit a breakpoint in a TypeScript file, *.vue*, or *JSX* file typically requires the use of [source maps](#generate_source_maps). A source map must be configured correctly to support debugging in Visual Studio.

1. Select your target browser as the debug target in Visual Studio, then press **Ctrl**+**F5** (**Debug** > **Start Without Debugging**) to run the app in the browser.

    If you created a browser configuration with a friendly name, choose that as your debug target.
    The app opens in a new browser tab.

1. Choose **Debug** > **Attach to Process**.

    > [!TIP]
    > Starting in Visual Studio 2017, after you attach to the process the first time by following these steps, you can quickly reattach to the same process by choosing **Debug** > **Reattach to Process**.

1. In the **Attach to Process** dialog, get a filtered list of browser instances that you can attach to.
    Choose the correct debugger for your target browser, **JavaScript (Chrome)** or **JavaScript (Microsoft Edge - Chromium)** in the **Attach to** field, type **chrome** or **edge** in the filter box to filter the search results.

1. Select the browser process with the correct host port (localhost in this example), and select **Attach**.

    The port (for example, 1337) may also appear in the **Title** field to help you select the correct browser instance.

    The following example shows how this looks for the Microsoft Edge (Chromium) browser.

    :::image type="content" source="media/tutorial-nodejs-react-attach-to-process-edge.png" alt-text="Screenshot showing how to Attach to a process in Debug menu.":::
    > [!TIP]
    > If the debugger does not attach and you see the message "Failed to launch debug adapter" or "Unable to attach to the process. An operation is not legal in the current state.", use the Windows Task Manager to close all instances of the target browser before starting the browser in debugging mode. Browser extensions may be running and preventing full debug mode.

1. The code with the breakpoint may have already been executed, refresh your browser page. If necessary, take action to cause the code with the breakpoint to execute.

    While paused in the debugger, you can examine your app state by hovering over variables and using debugger windows. You can advance the debugger by stepping through code (**F5**, **F10**, and **F11**). For more information on basic debugging features, see [First look at the debugger](../debugger/debugger-feature-tour.md).

    You may hit the breakpoint in either a transpiled *.js* file or source file, depending on your app type, which steps you followed previously, and other factors such as your browser state. Either way, you can step through code and examine variables.

   * If you need to break into code in a TypeScript, JSX, or *.vue* source file and are unable to do it, make sure that your environment is set up correctly, as described in the [Troubleshooting](#troubleshooting_source_maps) section.

   * If you need to break into code in a transpiled JavaScript file (for example, *app-bundle.js*) and are unable to do it, remove the source map file, *filename.js.map*.

### <a name="troubleshooting_source_maps"></a> Troubleshooting breakpoints and source maps

If you need to break into code in a TypeScript or JSX source file and are unable to do it, use **Attach to Process** as described in the previous section to attach the debugger. Make sure that your environment is set up correctly:

* Close all browser instances, including Chrome extensions (using the Task Manager), so that you can run the browser in debug mode.

* Make sure you [start the browser in debug mode](#prepare_the_browser_for_debugging).

* Make sure that your source map file includes the correct relative path to your source file and that it doesn't include unsupported prefixes such as *webpack:///*, which prevents the Visual Studio debugger from locating a source file. For example, a reference like *webpack:///.app.tsx* might be corrected to *./app.tsx*. You can do this manually in the source map file (which is helpful for testing) or through a custom build configuration. For more information, see [Generate source maps for debugging](#generate_source_maps).

Alternatively, if you need to break into code in a source file (for example, *app.tsx*) and are unable to do it, try using the `debugger;` statement in the source file, or set breakpoints in the Chrome Developer Tools (or F12 Tools for Microsoft Edge) instead.

## <a name="generate_source_maps"></a> Generate source maps for debugging

Visual Studio has the capability to use and generate source maps on JavaScript source files. This is often required if your source is minified or created by a transpiler like TypeScript or Babel. The options available depend on the project type.

* A TypeScript project in Visual Studio generates source maps for you by default. For more information, see [Configure source maps using a tsconfig.json file](#configure_source_maps).

* In a JavaScript project, you can generate source maps using a bundler like webpack and a compiler like the TypeScript compiler (or Babel), which you can add to your project. For the TypeScript compiler, you must also add a *tsconfig.json* file and set the ```sourceMap``` compiler option. For an example that shows how to do this using a basic webpack configuration, see [Create a Node.js app with React](../javascript/tutorial-nodejs-with-react-and-jsx.md).

> [!NOTE]
> If you are new to source maps, read [Introduction to JavaScript Source Maps](https://www.html5rocks.com/en/tutorials/developertools/sourcemaps/) before continuing.

To configure advanced settings for source maps, use either a *tsconfig.json* or the project settings in a TypeScript project, but not both.

To enable debugging using Visual Studio, you need to make sure that the reference(s) to your source file in the generated source map are correct (this may require testing). For example, if you're using webpack, references in the source map file include the *webpack:///* prefix, which prevents Visual Studio from finding a TypeScript or JSX source file. Specifically, when you correct this for debugging purposes, the reference to the source file (such as *app.tsx*), must be changed from something like *webpack:///./app.tsx* to something like *./app.tsx*, which enables debugging (the path is relative to your source file). The following example shows how you can configure source maps in webpack, which is one of the most common bundlers, so that they work with Visual Studio.

(Webpack only) If you're setting the breakpoint in a TypeScript of JSX file (rather than a transpiled JavaScript file), you need to update your webpack configuration. For example, in *webpack-config.js*, you might need to replace the following code:

```javascript
  output: {
    filename: "./app-bundle.js", // This is an example of the filename in your project
  },
```

with this code:

```javascript
  output: {
    filename: "./app-bundle.js", // Replace with the filename in your project
    devtoolModuleFilenameTemplate: '[resource-path]'  // Removes the webpack:/// prefix
  },
```

This is a development-only setting to enable debugging of client-side code in Visual Studio.

For complicated scenarios, the browser tools (**F12**) sometimes work best for debugging, because they don't require changes to custom prefixes.

### <a name="configure_source_maps"></a> Configure source maps using a tsconfig.json file

If you add a *tsconfig.json* file to your project, Visual Studio treats the directory root as a TypeScript project. To add the file, right-click your project in Solution Explorer, and then choose **Add > New Item > TypeScript JSON Configuration File**. A *tsconfig.json* file like the following gets added to your project.

```json
{
  "compilerOptions": {
    "noImplicitAny": false,
    "module": "commonjs",
    "noEmitOnError": true,
    "removeComments": false,
    "sourceMap": true,
    "target": "es5"
  },
  "exclude": [
    "node_modules"
  ]
}
```

#### Compiler options for tsconfig.json file

* **inlineSourceMap**: Emit a single file with source maps instead of creating a separate source map for each source file.
* **inlineSources**: Emit the source alongside the source maps within a single file; requires *inlineSourceMap* or *sourceMap* to be set.
* **mapRoot**: Specifies the location where the debugger should find source map (*.map*) files instead of the default location. Use this flag if the run-time *.map* files need to be in a different location than the *.js* files. The location specified is embedded in the source map to direct the debugger to the location of the *.map* files.
* **sourceMap**: Generates a corresponding *.map* file.
* **sourceRoot**: Specifies the location where the debugger should find TypeScript files instead of the source locations. Use this flag if the run-time sources need to be in a different location than the location at design-time. The location specified is embedded in the source map to direct the debugger to where the source files are located.

For more details about the compiler options, check the page [Compiler Options](https://www.typescriptlang.org/docs/handbook/compiler-options.html) on the TypeScript Handbook.

### Configure source maps using project settings (TypeScript project)

You can also configure the source map settings using project properties by right-clicking the project and then choosing **Project > Properties > TypeScript Build > Debugging**.

These project settings are available.

* **Generate source maps** (equivalent to **sourceMap** in *tsconfig.json*): Generates corresponding *.map* file.
* **Specify root directory of source maps** (equivalent to **mapRoot** in *tsconfig.json*): Specifies the location where the debugger should find map files instead of the generated locations. Use this flag if the run-time *.map* files need to be located in a different location than the *.js* files. The location specified is embedded in the source map to direct the debugger to where the map files are located.
* **Specify root directory of TypeScript files** (equivalent to **sourceRoot** in *tsconfig.json*): Specifies the location where the debugger should find TypeScript files instead of source locations. Use this flag if the run-time source files need to be in a different location than the location at design-time. The location specified is embedded in the source map to direct the debugger to where the source files are located.

## Debug JavaScript in dynamic files using Razor (ASP.NET)

Starting in Visual Studio 2019, Visual Studio provides debugging support for Chrome and Microsoft Edge (Chromium) only.

However, you can't automatically hit breakpoints on files generated with Razor syntax (*cshtml, vbhtml*). There are two approaches you can use to debug this kind of file:

* **Place the `debugger;` statement where you want to break**: This statement causes the dynamic script to stop execution and start debugging immediately while it's being created.
* **Load the page and open the dynamic document on Visual Studio**: You'll need to open the dynamic file while debugging, set your breakpoint, and refresh the page for this method to work. Depending on whether you're using Chrome or Microsoft Edge (Chromium), you'll find the file using one of the following strategies:

  * For Chrome, go to **Solution Explorer > Script Documents > YourPageName**.

    > [!NOTE]
    > When using Chrome, you might get a message "no source is available between \<script> tags". It's OK, just continue debugging.

  * For Microsoft Edge (Chromium), use the same procedure as Chrome.

For more information, see [Client-side debugging of ASP.NET projects in Google Chrome](https://devblogs.microsoft.com/aspnet/client-side-debugging-of-asp-net-projects-in-google-chrome/).
