---
title: "Create your first Node.js app"
ms.custom: [vs-acquisition,  SEO-VS-2020]
description: In this quickstart, you create a Node.js app in Visual Studio
ms.date: 03/25/2021
ms.technology: vs-javascript
ms.topic: quickstart
ms.devlang: javascript
ms.assetid: b0e4ebed-1a01-41ef-aad1-4d8465ce5322
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Quickstart: Create your first Node.js app with Visual Studio

In this 5-to-10-minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Node.js web app.

## Prerequisites

Before you begin, install Visual Studio and set up your Node.js environment.

### Install Visual Studio

::: moniker range=">=vs-2019"
If you haven't already installed Visual Studio 2019, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads) page to install it for free.
::: moniker-end
::: moniker range="vs-2017"
If you haven't already installed Visual Studio 2017, go to the [Visual Studio downloads](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) page to install it for free.
::: moniker-end

### Set up your Node.js environment

Visual Studio can help set up your environment, including installing tools common with Node.js development.

1. In Visual Studio, go to **Tools** > **Get Tools and Features**.

1. In the Visual Studio Installer, choose the **Node.js development** workload and select **Modify** to download and install the workload.

    ![Node.js workload in Visual Studio Installer](../ide/media/quickstart-nodejs-workload.png)

1. Install the LTS version of the [Node.js runtime](https://nodejs.org/en/download/). We recommend the LTS version for best compatibility with outside frameworks and libraries.

    Although Node.js is built for 32-bit and 64-bit architectures, the Node.js installer only supports one version installed at a time.

1. If Visual Studio doesn't detect your installed runtime (it generally does), configure your project to reference the installed runtime:

   1. After you [create your project](#create-your-app-project), right-click the project node.

   1. Select **Properties** and set the **Node.exe path**. You can use a global installation of Node.js or specify the path to a local interpreter in each of your Node.js projects.

## Create your app project

1. If you haven't yet, install the LTS version of the [Node.js runtime](https://nodejs.org/en/download/). For more information, see the [prerequisites](#prerequisites).

1. Open Visual Studio.

1. Create a new project.

    ::: moniker range=">=vs-2019"

    1. Press **Esc** to close the start window.

    1. Press **Ctrl + Q** to open the search box, then type **Node.js**.

    1. Choose **Blank Node.js Web Application (JavaScript)**. In the dialog, select **Create**.

    ::: moniker-end

    ::: moniker range="vs-2017"
    1. From the top menu bar, choose **File** > **New** > **Project**.

    1. In the left pane of the **New Project** dialog, expand **JavaScript** and choose **Node.js**.

    1. In the middle pane, choose **Blank Node.js Web application** and select **OK**.

    ::: moniker-end
    
    If you don't see the **Blank Node.js Web application** project template, you must add the **Node.js development** workload. For detailed instructions, see the [prerequisites](#prerequisites).

    Visual Studio creates and opens the project. The project's *server.js* file opens in the editor on the left.

## Explore the IDE

1. In the right pane, look at **Solution Explorer**.

   ![Solution Explorer](../ide/media/quickstart-nodejs-solution-explorer.png)

   - Highlighted in bold is your project, using the name provided when you set up the project. On disk, this project is represented by a *.njsproj* file in your project folder.

   - At the top level is a solution, which by default has the same name as your project. A solution, represented by a *.sln* file on disk, is a container for one or more related projects.

   - The **npm** node shows installed npm packages. You can right-click the npm node to search for and install npm packages by using a dialog.

1. If you want to install npm packages or Node.js commands from a command prompt, right-click the project node and choose **Open Command Prompt Here**.

   ![Node dot j s command prompt](../ide/media/quickstart-nodejs-command-prompt.png)

1. If you want to test navigation to source code, from the open *server.js* file, select **http.createServer** and press **F12** or choose **Go To Definition** from the context (right-click) menu. This command takes you to the definition of the `createServer` function in *http.d.ts*.

   ![Go To Definition context menu](../ide/media/quickstart-nodejs-gotodefinition.png)

1. Go back to *server.js* and locate this line of code: `res.end('Hello World\n');`. Modify the code like this:

    `res.end('Hello World\n' + res.connection.`

    When you type **connection.**, IntelliSense provides options to auto-complete the code entry.

   ![IntelliSense auto-complete](../ide/media/quickstart-nodejs-intellisense.png)

1. Choose **localPort** and type **);** to complete the statement:

    `res.end('Hello World\n' + res.connection.localPort);`

## Run the app

1. Press **Ctrl+F5** (or **Debug** > **Start Without Debugging**) to run the app. 
 
   The app opens in a browser.

1. In the browser, verify that you see a "Hello World" message and the local port number.

Congratulations! You created a simple Node.js app with Visual Studio. To delve deeper, continue in the **Tutorials** section of the table of contents.

## Next steps

> [!div class="nextstepaction"]
> [Deploy the app to Linux App Service](../javascript/publish-nodejs-app-azure.md)

> [!div class="nextstepaction"]
> [Tutorial for Node.js and Express](../javascript/tutorial-nodejs.md)

> [!div class="nextstepaction"]
> [Tutorial for Node.js and React](../javascript/tutorial-nodejs-with-react-and-jsx.md)
