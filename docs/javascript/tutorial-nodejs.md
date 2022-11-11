---
title: "Create a Node.js and Express app"
description: In this tutorial, learn how to create a basic Node.js application by using the Express web application framework in Visual Studio.
ms.date: 02/25/2022
ms.custom: vs-acquisition
ms.topic: tutorial
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-javascript
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Tutorial: Create a Node.js and Express app in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you will learn how to use Visual Studio to build a simple Node.js web app that uses the Express framework.

Before you begin, here's a quick FAQ to introduce you to some key concepts:

- **What is Node.js?**
  
  Node.js is a server-side JavaScript runtime environment that executes JavaScript code.

- **What is npm?**
  
  A package manager makes it easier to use and share Node.js source code libraries. The default package manager for Node.js is npm. The npm package manager simplifies the installation, updating, and uninstallation of libraries.

- **What is Express?**
  
  Express is a server web application framework that Node.js uses to build web apps. With Express, there are many different ways to create a user interface. The implementation provided in this tutorial uses the Express application generator's default template engine, called Pug, to render the front-end.

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 **version 17.4** or later with the **ASP.NET and web development** workload installed. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
  If you need to install the workload and already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **ASP.NET and web development** workload, then choose **Modify**.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/package/npm)), which is included with Node.js
- npx ([https://www.npmjs.com/package/npx](https://www.npmjs.com/package/npx))

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::
   
1. Search for Express in the search bar at the top and then select **JavaScript Express Application**.

   :::image type="content" source="media/vs-2022/express-choose-template.png" alt-text="Choose a template":::
   
1. Give your project and solution a name. 

## View the project properties

The default project settings allow you to build and debug the project. But, if you need to change settings, right-click the project in Solution Explorer, select **Properties**, and then go the **Build** or **Debugging** section.

>[!NOTE]
> *launch.json* stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, *launch.json* must be located under the *.vscode* folder.

## Build your project

Choose **Build** > **Build Solution**  to build the project.

## Start your app

Press **F5** or select the **Start** button at the top of the window, and you'll see a command prompt: 

- npm running the node ./bin/www command

>[!NOTE]
> Check console output for messages, such as a message instructing you to update your version of Node.js.

Next, you should see the base Express app appear!

## Debug your app

We will now go through a couple of ways you can debug your app. 

First, if your app is still running, press **Shift + F5** or select the red stop button at the top of the window. You might notice that the browser showing your app closed, but the command prompt running the node process remained. Go ahead and close any lingering command prompts for now -- we will return to this later on.

### Breaking in the Node process 

In the dropdown next to the **Start** button, you should see the following start options:
- localhost (Edge)
- localhost (Chrome)
- Debug Dev Env
- Launch Node and Browser

Go ahead and select the **Launch Node and Browser** option. Now, before pressing **F5** or selecting the **Start** button again, set a breakpoint in *index.js* by selecting the left gutter before the following line of code: 

`res.render('index', { title: 'Express' });`

Tip! You can also put your cursor on a line of code and hit F9 to toggle the breakpoint for that line. 

Then, press **F5** or select **Debug** > **Start Debugging** to debug your app.

The debugger should then pause at the breakpoint you set, so that you can inspect your app state.

When you're finished inspecting the state, hit f5? to continue, and your app should load as expected. 

This time, if you hit stop, you will notice that both the browser and the command prompt windows close. To see why, we need to take a closer look at the *launch.json*.

### Understanding the *launch.json*

Show hidden files, open launch.json. 

[image]

If you have worked with vscode, this launch.json file may look familiar. The launch.json here works in much the same way to denote launch configurations used for debugging. Each entry denotes a target to be debugged. 

For browser entries, the Visual Studio debugger is *only* attached to the frontend process, and the node process is spun up without a debugger for the sake of serving the frontend, but the process itself is not debugged. This was why the command prompt lingered earlier in [this](link) section earlier. We intentionally left the node process running when it is not the debugged process. 

For the `compound` entry that we selected in [this](link), the entry references two entries, one for the frontend and the backend. Selecting the compound option indicates to the Visual Studio debugger to attach to both the frontend and backend processes. At the current moment, there is no JavaScript running in the frontend process, so we did not set breakpoints. In order to do so, you need to serve static javascript to run in the frontend process [link], which will enable you to debug the frontend and backend together. If you choose to add javascript to the frontend, you will also be able to debug only the browser by selecting a browser-only launch configuration. 

If you'd like to only debug the node process, select Debug Dev Env. You'll notice that in this case, there is no browser that gets launched. When selecting this option, you'll need to open up a browser and navigate to the url yourself in order to connect to the Express app. 

Tip! See launch options here (link js-debugger options). 

There are many different ways to configure launches for debugging. Something something runtime arguments etc etc. Additionally, if you'd like to hide an individual launch config, but still reference it, you can do the following (code excerpt). 

### 
