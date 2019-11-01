---
title: "Quickstart: Use Visual Studio to create your first Node.js app"
description: In this quickstart, you create a Node.js app in Visual Studio
ms.date: 06/27/2018
ms.technology: vs-javascript
ms.topic: quickstart
ms.devlang: javascript
ms.assetid: b0e4ebed-1a01-41ef-aad1-4d8465ce5322
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Quickstart: Use Visual Studio to create your first Node.js app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Node.js web application.

## Prerequisites

* You must have Visual Studio installed and the Node.js development workload.

    ::: moniker range=">=vs-2019"
    If you haven't already installed Visual Studio 2019, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.
    ::: moniker-end
    ::: moniker range="vs-2017"
    If you haven't already installed Visual Studio 2017, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.
    ::: moniker-end

    If you need to install the workload but already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **Node.js development** workload, then choose **Modify**.

    ![Node.js workload in VS Installer](../ide/media/quickstart-nodejs-workload.png)

* You must have the Node.js runtime installed.

    If you don't have it installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website. In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime, you can configure your project to reference the installed runtime in the properties page (after you create a project, right-click the project node and choose **Properties**).

## Create a project

First, you'll create an Node.js web application project.

1. If you don't have the Node.js runtime already installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website.

    In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime, you can configure your project to reference the installed runtime in the properties page (after you create a project, right-click the project node and choose **Properties**).

1. Open Visual Studio.

1. Create a new project.

    ::: moniker range=">=vs-2019"
    Press **Esc** to close the start window. Type **Ctrl + Q** to open the search box, type **Node.js**, then choose **Create new Blank Node.js Web application project** (JavaScript). In the dialog box that appears, choose **Create**.
    ::: moniker-end
    ::: moniker range="vs-2017"
    From the top menu bar, choose **File** > **New** > **Project**. In the left pane of the **New Project** dialog box, expand **JavaScript**, then choose **Node.js**. In the middle pane, choose **Blank Node.js Web application**, then choose **OK**.
    ::: moniker-end
    If you don't see the **Blank Node.js Web application** project template, you must add the **Node.js development** workload. For detailed instructions, see the [Prerequisites](#prerequisites).

    Visual Studio creates and the new solution and opens the project. *server.js* opens in the editor in the left pane.

## Explore the IDE

1. Take a look at **Solution Explorer** in the right pane.

   ![Solution Explorer](../ide/media/quickstart-nodejs-solution-explorer.png)

   - Highlighted in bold is your project, using the name you gave in the **New Project** dialog box. On disk, this project is represented by a *.njsproj* file in your project folder.

   - At the top level is a solution, which by default has the same name as your project. A solution, represented by a *.sln* file on disk, is a container for one or more related projects.

   - The npm node shows any installed npm packages. You can right-click the npm node to search for and install npm packages using a dialog box.

1. If you want to install npm packages or Node.js commands from a command prompt, right-click the project node and choose **Open Command Prompt Here**.

   ![Node.js command prompt](../ide/media/quickstart-nodejs-command-prompt.png)

1. In the *server.js* file in the editor (left pane), choose `http.createServer` and then press **F12** or choose **Go To Definition** from the context (right-click) menu. This command takes you to the definition of the `createServer` function in *index.d.ts*.

   ![Go To Definition context menu](../ide/media/quickstart-nodejs-gotodefinition.png)

1. Got back to *server.js*, then put your cursor at the end of the string in this line of code, `res.end('Hello World\n');`, and modify it so that it looks like this:

    `res.end('Hello World\n' + res.connection.`

    Where you type `connection.`, IntelliSense provides options to auto-complete the code entry.

   ![IntelliSense auto-complete](../ide/media/quickstart-nodejs-intellisense.png)

1. Choose **localPort**, and then type `);` to complete the statement so that it looks like this:

    `res.end('Hello World\n' + res.connection.localPort);`

## Run the application

1. Press **Ctrl**+**F5** (or **Debug > Start Without Debugging**) to run the application. The app opens in a browser.

1. In the browser window, you will see "Hello World" plus the local port number.

1. Close the web browser.

Congratulations on completing this Quickstart in which you got started with the Visual Studio IDE and Node.js. If you'd like to delve deeper into its capabilities, continue with a tutorial in the **Tutorials** section of the table of contents.

## Next steps

> [!div class="nextstepaction"]
> [Deploy the app to Linux App Service](../javascript/publish-nodejs-app-azure.md)

- [Tutorial for Node.js and Express](../javascript/tutorial-nodejs.md)
- [Tutorial for Node.js and React](../javascript/tutorial-nodejs-with-react-and-jsx.md)