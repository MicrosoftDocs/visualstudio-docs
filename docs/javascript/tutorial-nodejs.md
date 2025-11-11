---
title: "Tutorial: Create a Node.js and Express app"
description: Follow this tutorial and learn how to create a basic Node.js application by using the Express web application framework in Visual Studio.
ms.date: 12/17/2024
ms.custom: vs-acquisition
ms.topic: tutorial
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: javascript-typescript
monikerRange: '>= vs-2022'
dev_langs:
  - JavaScript

#customer intent: As a developer, I want to create Node.js applications with the Express web application framework in Visual Studio, so I can access features to support my development.
---

# Tutorial: Create a Node.js and Express app in Visual Studio

This article demonstrates how to use Visual Studio to build a basic Node.js web app that uses the Express framework.

Node.js is a server-side JavaScript runtime environment that executes JavaScript code. By default, Node.js uses the npm package manager to make it easy to use and share Node.js source code libraries. The npm package manager simplifies the installation, updating, and uninstallation of libraries.

Express is a server web application framework that Node.js uses to build web apps. With Express, there are many different ways to create a user interface. The implementation provided in this tutorial uses the Express application generator's default template engine, called Pug, to render the frontend.

In this tutorial, you:

> [!div class="checklist"]
> * Create a Node.js app by using a JavaScript template
> * Build the app and examine the running process 
> * Debug the app in the Visual Studio debugger

## Prerequisites

- Visual Studio 2022 **version 17.12** or later with the **ASP.NET and web development** workload installed.

   - To install Visual Studio for free, go to the [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) page.

   - If you already have Visual Studio, you can install the workload from within the Interactive Development Environment (IDE):
   
      1. Select **Tools** > **Get Tools and Features**.

      1. In the Visual Studio Installer, select the **Workloads** tab.

      1. Select the **ASP.NET and web development** workload, and then select **Modify**.

      1. Follow the prompts and complete the installation.

- Node.js with the npm package manager and the npx package.

   You can check your Node.js installation with the `node -v` command. The command output should show the installed version of Node.js, such as `v23.4.0`. For more information, see [Downloading and installing Node.js and npm](https://docs.npmjs.com/downloading-and-installing-node-js-and-npm).

   - The [npm package manager](https://www.npmjs.com/package/npm) is included in the Node.js installation. Verify the installation with the `npm -v` command. The command output should show the installed version of the package manager, such as `10.9.2`.

   - The [npx package](https://www.npmjs.com/package/npx) is part of the npm CLI. Confirm the package installation with the `npx -v` command. The command output should show the installed package version, such as `10.9.2`.

## Create your app

Follow these steps to create a new Node.js app in Visual Studio:

1. In the Visual Studio **Start** window (**File** > **Start Window**), select **Create a new project**:

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot that shows how to select the Create a new project option in the Visual Studio Start window.":::
   
1. In the **Search** box, enter _Express_, and select the **JavaScript Express Application** template in the list of results:

   :::image type="content" source="media/vs-2022/express-choose-template.png" alt-text="Screenshot that shows how to search for and select the JavaScript Express Application template in the Visual Studio Start window.":::

1. Select **Next** to continue to the configuration page.

1. Enter a **Project name** and **Solution name** for your new app. Choose the default **Location** or browse to a different path in your environment.

1. Select **Create** to create the new Node.js project.

Visual Studio creates your new project and opens your project hierarchy in **Solution Explorer**.

## View your project properties

The default project settings allow you to build and debug the project. You can change the settings as needed.

1. In **Solution Explorer**, right-click the project and select **Properties**. You can also access these properties by selecting **Project** > **ExpressProject Properties**.

1. In the **Project Properties** pane, go to the **Build** section and configure the properties as desired.

1. To configure debug settings, select **Debug** > **ExpressProject Debug Properties**.

> [!NOTE]
> The _launch.json_ file stores the startup settings associated with the **Start** action in the Debug toolbar. Currently, the _launch.json_ must be located in the _.vscode_ folder.

## Build your project

Build your project by selecting **Build** > **Build Solution**.

## Start your app

Start your new app by selecting **Ctrl** + **F5** or **Start Without Debugging** (green arrow outline icon) in the toolbar.

A terminal opens and shows the executing command:

```output
> expressproject@0.0.0 start
> node ./bin/www

GET / 200 29342.066 ms - 170
GET /stylesheets/style.css 200 18.967 ms - 111
```

> [!NOTE]
> Check the terminal output for messages. Also check the **Output** pane in Visual Studio. Watch for instructions to update your version of Node.js.

When the app launches successfully, a browser window opens showing the Express app:

:::image type="content" source="media/vs-2022/express-app-running-browser.png" alt-text="Screenshot that shows the running Express app in the browser.":::

## Debug your app

Now you're ready to explore ways to debug your app.

If your app is still running, select **Shift + F5** to end the current session or **Stop** :::image type="icon" source="./media/debugger-stop.png"::: (red square icon) in the Debug toolbar. You might notice that ending the session closes the browser that shows your app, but the terminal window running the Node process remains open. For now, go ahead and close any lingering windows. Later in this article, you review scenarios for when you might want to leave the Node process running.

### Debug the Node process 

The dropdown list to the left of the **Start** action shows available start options for the app:

- localhost (Edge)
- localhost (Chrome)
- Launch ExpressProject     
- Launch Node and Browser

Follow these steps to debug the Node process for the app:

1. In the **Start** dropdown list, select **Launch Node and Browser**.

1. In **Solution Explorer**, expand the _routes_ folder and open the _index.js_ file.

1. In the code editor, set a breakpoint in the _index.js_ file:

   1. Locate the code statement `res.render('index', { title: 'Express' });`.
  
   1. Select in the left gutter on the line for the statement. Visual Studio adds a red circle in the gutter to indicate the set breakpoint.

   > [!TIP]
   > You can also place your cursor on a line of code and select **F9** to toggle the breakpoint for that line. 

1. Start your app in the debugger by selecting **F5** or **Start Debugging** :::image type="icon" source="./media/debugger-start.png"::: (green arrow icon) in the Debug toolbar.

   Visual Studio starts execution of your app. When the debugger reaches your set breakpoint, the debugging process pauses.

1. While execution is paused, you can inspect the state of your app. Hover over variables and examine their properties.

1. When you're ready to continue, select **F5**. Processing continues and your app opens in the browser. 

This time, if you select **Stop**, notice that both the browser and terminal windows close. To understand why the behavior is different, take a closer look at the _launch.json_ file.

### Examine the launch.json file

Follow these steps to examine the _launch.json_ file for the project:

1. In **Solution Explorer**, expand the _.vscode_ folder and open the _launch.json_ file.

   > [!TIP]
   > If you don't see the _.vscode_ folder in **Solution Explorer**, select the **Show All Files** action in the **Solution Explorer** toolbar. 

1. Take a look at the file in the code editor. If you have experience with Visual Studio Code, the _launch.json_ file probably looks familiar. The _launch.json_ file in this project corresponds to the file used by Visual Studio Code to denote launch configurations used for debugging. Each entry specifies one or more targets to debug. 

1. Examine the first two entries in the file. These entries define behavior for different internet browsers:

   ```json
       {
         "name": "localhost (Edge)",
         "type": "edge",
         "request": "launch",
         "url": "http://localhost:3000",
         "webRoot": "${workspaceFolder}\\public"
       },
       {
         "name": "localhost (Chrome)",
         "type": "chrome",
         "request": "launch",
         "url": "http://localhost:3000",
         "webRoot": "${workspaceFolder}\\public"
       }
   ```

   The supported browsers are indicated with the `type` property. If you launch the app with only a browser type as the sole debug target, Visual Studio debugs only the front-end browser process. The Node process starts without a debugger attached. Visual Studio **doesn't bind** any breakpoints set in the Node process. 

   > [!NOTE]
   > Currently, `edge` and `chrome` are the only supported browser types for debugging.

   When you end the session, the Node process continues to run, by design. The process is intentionally left running when a browser is the debug target. If work is solely being done on the frontend, having the backend process continuously running eases the development workflow.

   At the start of [this section](#debug-your-app), you closed the lingering terminal window so you could set breakpoints in the Node process. To enable Visual Studio to debug the Node process, the process must be restarted with the debugger attached. If a nondebuggable Node process is left running, attempting to launch the Node process in debug mode (without reconfiguring the port) **fails**. 

1. Review the third entry in the _launch.json_ file. This entry specifies `node` as the debug type:

   ```json
       {
         "name": "Launch ExpressProject",
         "type": "node",
         "request": "launch",
         "cwd": "${workspaceFolder}/bin",
         "program": "${workspaceFolder}/bin/www",
         "stopOnEntry": true
       }
   ```

   The third entry launches only the Node process in debug mode. Visual Studio doesn't launch the browser.

1. Examine the fourth entry in the _launch.json_ file, which defines a compound launch configuration:

   ```json
       {
         "name": "Launch Node and Browser",
         "configurations": [
           "Launch ExpressProject",                   
           "localhost (Edge)"
         ]
       }
   ```

   This compound configuration is the same as a [Visual Studio Code compound launch configuration](https://code.visualstudio.com/docs/editor/debugging#_compound-launch-configurations). When you select this configuration, you can debug both the frontend and backend. Notice that the definition simply references the individual launch configurations for the Node and browser processes. 

   There are many other attributes you can use in a launch configuration. For example, you can hide a configuration to remove it from the **Start** dropdown list, but allow references to the configuration by setting the `hidden` attribute in the `presentation` object to `true`:

   ```json
       {
         "name": "localhost (Chrome)",
         "type": "chrome",
         "request": "launch",
         "url": "http://localhost:3000",
         "webRoot": "${workspaceFolder}\\public",
         "presentation": {
           "hidden": true
         }
       }
   ```

1. Configure options by using supported attributes to enhance your debugging experience. Currently, only **launch** configurations are supported. Any attempt to use an **attach** configuration results in a deployment failure. For more information, see [Options](https://github.com/microsoft/vscode-js-debug/blob/main/OPTIONS.md).

## Related links

- [Debug a JavaScript or TypeScript app in Visual Studio](./debug-nodejs.md)
- [Migrate Node.js projects in Visual Studio](./migrate-nodejs-projects.md)
- [Manage npm packages in Visual Studio](./npm-package-management.md)
