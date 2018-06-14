---
title: "Quickstart: Use Visual Studio to create your first Vue.js app"
description: In this quickstart, you create a Vue.js app in Visual Studio using the Node.js Tools for Visual Studio
ms.date: 11/15/2017
ms.prod: visual-studio-dev15
ms.technology: vs-nodejs
ms.topic: quickstart
ms.devlang: javascript
ms.assetid: b0e4ebed-1a01-41ef-aad1-4d8465ce5322
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Quickstart: Use Visual Studio to create your first Vue.js app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create and run a simple Vue.js web application. If you haven't already installed Visual Studio 2017, go to the [Visual Studio downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

> [!IMPORTANT]
> This article requires the Vue.js template, which is available starting in Visual Studio 2017 version 15.8 Preview 3.

## Create a project

First, you'll create a Vue.js web application project.

1. If you don't have the Node.js runtime already installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website.

    In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime, you can configure your project to reference the installed runtime in the properties page (after you create a project, right-click the project node and choose **Properties**).

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box, under either **JavaScript** > **Node.js** or **TypeScript** > **Node.js**, choose **Basic Vue.js Web Application**, and then enter a project name, and then click **OK**.

    Visual Studio creates the new project. The new project opens in Solution Explorer (right pane).

     If you don't see the **Basic Vue.js Web application** project template, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Choose the **Node.js development** workload, then choose **Modify**.

     ![Node.js workload in VS Installer](../ide/media/quickstart-nodejs-workload.png)

    After you choose the **Basic Vue.js Web Application** template and click **OK**, Visual Studio creates and the new solution and opens the project.

## Explore the IDE

1. Take a look at **Solution Explorer** in the right pane.

   TBD TBD TBD screenshot

  - Highlighted in bold is your project, using the name you gave in the **New Project** dialog box. On disk, this project is represented by a .*njsproj* file in your project folder.

  - At the top level is a solution, which by default has the same name as your project. A solution, represented by a .*sln* file on disk, is a container for one or more related projects.

  - The npm node shows any installed npm packages. You can right-click the npm node to search for and install npm packages using a dialog box.

1. If you want to install npm packages or run Node.js commands from a command prompt, right-click the project node and choose **Open Command Prompt Here**.

## Add a .vue file to the project

1. In Solution Explorer, right-click any folder and choose **Add** > **New Item**.

1. Select either **JavaScript Vue Single File Component** or **TypeScript Vue Single File Component**, and then click **Add**.

    Visual Studio adds the new file to the project.

## Build the project

* From Visual Studio, use **Build** > **Build Solution** to build the project. Check the **Output** window to see build results.

    The Vue.js project template uses the `build` npm script by configuring a post build event. If you want to modify this setting, open the project file (*\<projectname\>.njsproj*) from Windows Explorer and locate this line of code:

    ```xml
    <PostBuildEvent>npm run build</PostBuildEvent>
    ```

## Run the application

1. Press **Ctrl**+**F5** (or **Debug > Start Without Debugging**) to run the application. The app opens in a browser.

1. In the browser window, you will see TBD TBD TBD TBD

1. Close the web browser.

## Debug the application

1. In the *TBD TBD TBD* file, click in the left gutter before the following line of code to set a breakpoint:

    TBD TBD TBD TBD

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run.

2. To start the application with the debugger attached, press **F5** (or **Debug > Start Debugging**). The app opens in a browser.

    When you debug this app, the following script runs: `node_modules\@vue\cli-service\bin\vue-cli-service.js serve`. You can see and modify this setting in the project properties (right-click the project node in Solution Explorer and choose **Properties**).

Congratulations on completing this Quickstart! We hope you learned a little bit about using the Visual Studio IDE with Vue.js. If you'd like to delve deeper into its capabilities, please continue with a tutorial in the **Tutorials** section of the table of contents.

## Next steps

- Go through the [Tutorial for Node.js and Express](../nodejs/tutorial-nodejs.md)
- Go through the [Tutorial for Node.js and React](../nodejs/tutorial-nodejs-with-react-and-jsx.md)