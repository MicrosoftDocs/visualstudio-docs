---
title: "Create a Node.js and React app - Visual Studio | Microsoft Docs"
description: tutorial - create a Node.js and React app in Visual Studio
ms.custom: "mvc"
ms.date: "02/19/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-nodejs"
ms.tgt_pltfrm: ""
ms.topic: "tutorial"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
dev_langs: 
  - JavaScript
ms.workload: 
  - "nodejs"
---
# Tutorial: Create a Node.js and React app in Visual Studio
In this tutorial for Node.js development using Visual Studio, you'll create a Node.js web application project from a Visual Studio template and then create a simple app using React. If you haven't already installed Visual Studio, install it for free [here](http://www.visualstudio.com).  

In this tutorial, you learn how to:
> [!div class="checklist"]
> * Create a Node.js project
> * Add npm packages
> * Add React code to your app
> * Transpile JSX
> * Attach the debugger

## Create a project
First, create an Node.js web application project.

1. If you don't have the Node.js runtime already installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website.

    In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime you can configure your project to reference the installed runtime.

    This topic was tested with version 8.9.4.

1. Open Visual Studio 2017.  

1. From the top menu bar, choose **File** > **New** > **Project...**.  

1. In the **New Project** dialog box, in the left pane, expand **JavaScript**, then choose **Node.js**. In the middle pane, choose **Blank Node.js Web Application**, type the name **NodejsWebAppBlank**, then choose **OK**.   

     If you don't see the **Blank Node.js Web Application** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Choose the **Node.js development** workload, then choose **Modify**. 

    Visual Studio creates the new solution and opens your project. The *server.js* project file opens in the editor (left pane).

    ![Node.js project in Solution Explorer](../nodejs/media/tutorial-nodejs-react-project-structure.png)  

    - Highlighted in bold is your project, using the name you gave in the **New Project** dialog box. On disk, this project is represented by a *.njsproj* file in your project folder.

    - At the top level is a solution, which by default has the same name as your project. A solution, represented by a *.sln* file on disk, is a container for one or more related projects.

    - The npm node shows any installed npm packages. You can right-click the npm node to search for and install npm packages using a dialog box.

    - Project files such as server.js show up under the project node. *server.js* is the project startup file (to configure properties such as the startup file, right-click the project node and choose **Properties**).

## Add npm packages

This app requires a number of npm modules to run correctly.

* babel-cli
* babel-loader
* babel-preset-react
* express
* path
* react
* react-dom
* webpack

1. In Solution Explorer (right pane), right-click the **npm** node in the project and choose **Install New npm Packages**.

1. In the **Install New npm Packages** dialog box, search for the react package, and click **Install Package** to install it.

    ![Install npm packages](../nodejs/media/tutorial-nodejs-react-install-packages.png)

    The **Output** window shows progress on installing each package. When installed, package appears under the **npm** node.

    The project's *package.json* file is updated with the new package information including the package version.

1. Repeat the previous steps for each of the other npm modules.
    Here are the npm modules as they appear in Solution Explorer after they are installed.

    ![npm packages](../nodejs/media/tutorial-nodejs-react-npm-modules.png) 

    In the **Install New npm Packages** dialog box, you can choose to install the most current package version or specify a version. We recommend you install the current version, but if you run into unexpected errors later, you may need to install the versions shown in the illustration.

> [!NOTE]
> If you prefer to install npm packages using the command line, right-click the project node and choose **Open Command Prompt Here**. Use standard Node.js commands to install packages.

## Add project files

In these steps, you add four new files to your project.
* *app.js*
* *browser-bundle.js*
* *webpack-config.js*
* *index.html*

For this simple app, we will just add the new project files in the project root. (In most apps, you typically add the files to subfolders and adjust relative path references accordingly.)

1. In Solution Explorer, right-click the project **NodejsWebAppBlank** (or whatever you named the project) and choose **Add** > **New Item**.

1. In the **Add New Item** dialog box, choose **JavaScript file**, type a name like *app.js*, and click **OK**.

1. Repeat these steps to add *browser-bundle.js* and *webpack-config.js*.

1. Repeat the same steps to add index.html to the project. Instead of a JavaScript file, choose **HTML file**.

## Add app code

1. Open *server.js* and replace the code with the following code:

    ```javascript
    'use strict';
    var http = require('http');
    var path = require('path');
    var express = require('express');

    var app = express();

    var staticPath = path.join(__dirname, '/');
    app.use(express.static(staticPath));

    // Allows you to set port in the project properties.
    app.set('port', process.env.PORT || 3000);

    var server = app.listen(app.get('port'), function() {
        console.log('listening');
    });
    ```

   The preceding code uses Express to start Node.js as your web application server. This code sets the port to the port number configured in the project properties (1337 by default). To open the project properties, right-click the project in Solution Explorer and choose **Properties**.

1. Open *app.js* and add the following code:

    ```javascript
    var React = require('react');
    var ReactDOM = require('react-dom');

    class Hello extends React.Component {
        render() {
            return (
                <h1>Welcome to React!!</h1>
            );
        }
    }

    ReactDOM.render(<Hello />, document.getElementById('root'));
    ```

    The preceding code uses JSX syntax and React to display a simple message.

1. Open *index.html* and replace the **body** section with the following code:

    ```html
    <body>
        <div id="root"></div>
        <!-- scripts -->
        <script src="browser-bundle.js"></script>
    </body>
    ```

    This HTML page loads *browser-bundle.js*, which contains the JSX and React code transpiled to plain JavaScript. Currently, *browser-bundle.js* is an empty file. In the next section, we configure options to transpile the code.

## Configure webpack and babel

In the previous steps, we added *webpack-config.js* to the project. Next, we add webpack configuration code. We will add a very simple webpack configuration that specifies an input file (*app.js*) and an output file (*browser-bundle.js*) for bundling and transpiling JSX to plain JavaScript. We also configure some babel options to support React. This is a very basic configuration that is intended as an introduction to webpack and babel.

1. In Solution Explorer, open *webpack-config.js* and add the following code.

    ```javascript
    module.exports = {
        devtool: 'source-map',
        entry: "./app.js",
        output: {
            filename: "./browser-bundle.js"
        },
        module: {
            rules: [
                {
                    test: /\.js$/,
                    exclude: /(node_modules|bower_components)/,
                    use: {
                        loader: 'babel-loader',
                        options: {
                            presets: ['react']
                        }
                    }
                }
            ]
        }
    }
    ```

    The webpack configuration code instructs babel to use the **babel-preset-react** npm package to transpile the React code.

## Transpile the JSX

1. In Solution Explorer, right-click the project node and choose **Open Command Prompt Here**.

1. In the command prompt, type the following command:

    `node_modules\.bin\webpack app.js --config webpack-config.js`

    The command prompt window shows the result.

    ![Run webpack](../nodejs/media/tutorial-nodejs-react-run-webpack.png) 

    If you see any errors instead of the preceding output, you must resolve them before your app will work. If your npm package versions are different than the versions shown in this tutorial, that can be a source of errors. One way to fix this is to use the exact versions shown in the earlier illustration.

1. In Solution Explorer, open *browser-bundle.js* to see the transpiled JavaScript code.

> [!NOTE]
> You can run webpack commands in different ways, such as by using Gulp or the Task Runner Explorer, or both (you might try the [Task Runner Extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.CommandTaskRunner)).

1. If prompted to reload externally modified files, click **Yes to All**.

    ![Load modified files](../nodejs/media/tutorial-nodejs-react-reload-files.png) 

Each time you make changes to *app.js*, you must re-run the webpack command.

## Run the app

1. Make sure that Google chrome is selected as the current debug target.

    ![Select Chrome as debug target](../nodejs/media/tutorial-nodejs-react-debug-target.png)  

1. Press **F5** (**Debug** > **Start Debugging**), or the green arrow button, to run the app.

    A Node.js console window opens that shows the port on which the debugger is listening.

    Visual Studio starts the app by launching the startup file, *server.js*.

    ![Run React in browser](../nodejs/media/tutorial-nodejs-react-running-react.png) 

1. Close the browser window.

1. Close the console window.

## Set a breakpoint and run the app

1. In *server.js*, click in the left gutter before the following line of code to set a breakpoint:

    ![Set a breakpoint](../nodejs/media/tutorial-nodejs-react-set-breakpoint.png) 

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run. 

1. Press **F5** (**Debug** > **Start Debugging**) to run the application.

    The debugger pauses at the breakpoint you set (the current statement is marked in yellow). Now, you can inspect your app state by hovering over variables that are currently in scope, using debugger windows like the **Locals** and **Watch** window, etc.

1. Press **F5** to continue the app.

1. If you want to use the Chrome Developer Tools, press **F12**. You can use these tools to examine the DOM and interact with the app using the JavaScript Console.

1. Close the web browser and the console.

If you would like more information on using a template based on Express, see [Create an Express 4 web application](../nodejs/tutorial-nodejs.md)

## Set and hit a breakpoint in the client-side React code

In the preceding section, we attached the debugger to server-side Node.js code. To attach the debugger and hit breakpoints in client-side React code, the Visual Studio debugger needs help to identify the correct process. Here is one way to enable this.

> [!TIP]
> Once you attach to the process the first time by following these steps, you can quickly re-attach to the same process in Visual Studio 2017 by choosing **Debug** > **Reattach to Process**.

1. Close all Chrome windows.

1. Open the **Run** command from the Windows **Start** button (right-click and choose **Run**), and enter the following command:

    `chrome.exe --remote-debugging-port=9222`

    This starts Chrome with debugging enabled.

1. Switch to Visual Studio and set a breakpoint in *browser-bundle.js* code as shown in the following illustration.

    ![Set a breakpoint](../nodejs/media/tutorial-nodejs-react-set-breakpoint-client-code.png) 

1. With Chrome selected as the debug target in Visual Studio, press **Ctrl + F5** (**Debug** > **Start Without Debugging**) to run the app in the browser.

    The app opens in a new browser tab.

1. Choose **Debug** > **Attach to Process**.

1. In the **Attach to Process** dialog box, choose **Webkit code** in the **Attach to** field, type **chrome** in the filter box to filter the search results.

1. Select the Chrome process with the correct host port (1337 in this example), and click **Attach**.

    ![Attach to process](../nodejs/media/tutorial-nodejs-react-attach-to-process.png) 

    When the debugger attaches, you see the DOM Explorer and the JavaScript Console open in Visual Studio. These debugging tools are very similar to Chrome Developer Tools and F12 Tools for Edge.

1. Because the code with the breakpoint already executed, refresh your browser page to hit the breakpoint.

    While paused in the debugger, you can examine your app state by hovering over variables and using debugger windows.

Next time you want to attach the debugger, you can save time by using **Debug** > **Reattach to Process**.

## Set and hit a breakpoint using sourcemaps

We previously generated a sourcemap file by including `devtool: 'source-map'` in the `webpack-config.js file`. To use the sourcemap file for debugging:

1. In Solution Explorer, right-click the project and choose **Add** > **Existing Item**, then add the *browser-bundle.js.map* file the project root.

1. In *browser-bundle.js*, remove the breakpoint you set previously.

1. In *app.js*, set a breakpoint on the `render()` line of code.

1. Either choose **Debug** > **Reattach to Process** (if you attached the debugger to client-side React code previously) or follow all the steps in the section **Set and hit a breakpoint in the client-side React code**. (Skip the step on setting a breakpoint in *browser-bundle.js*.)

## Next steps 

In this tutorial, you learned how to create a Node.js app using React. To learn more about Node.js Tools for Visual Studio, see the documentation.

> [!div class="nextstepaction"]
> [Node.js Tools for Visual Studio](https://github.com/Microsoft/nodejstools)