---
title: Create a React project in Visual Studio
description: Create, build, and run a simple React front-end web application project from a Visual Studio template, and set basic properties for the project.
ms.date: 10/02/2024
ms.custom: vs-acquisition
ms.topic: tutorial
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'
---

# Create a React project

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple React frontend web application.

## Prerequisites

Make sure to install the following software:

- Visual Studio 2022 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.
- npm ([`https://www.npmjs.com/`](https://www.npmjs.com/package/npm)), which is included with Node.js

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot showing Create a new project":::

1. Search for React in the search bar at the top and then select **React App** for either JavaScript or TypeScript, based on your preference.

   :::image type="content" source="media/vs-2022/react-choose-standalone-template.png" alt-text="Screenshot showing choosing a template":::

   Starting in Visual Studio 2022 version 11, the template name was changed from **Standalone JavaScript React Project** to **React App**.

1. Give your project and solution a name. 

1. Choose **Create**, and then wait for Visual Studio to create the project.

   Please note that creation of the React project takes a moment because the create-react-app command that runs at this time also runs the npm install command.

## View the project properties

The default project settings allow you to build and debug the project. But, if you need to change settings, right-click the project in Solution Explorer, select **Properties**, and then go the **Linting**, **Build** or **Deploy** section.

For debugger configuration, use [launch.json](../javascript/debug-nodejs.md#configure-debugging).

>[!NOTE]
> `launch.json` stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, `launch.json` must be located under the `.vscode` folder.

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window, and you'll see a command prompt such as:

- VITE v4.4.9 ready in 780 ms

>[!NOTE]
> Check console output for messages, such as a message instructing you to update your version of Node.js.

Next, you should see the base React app appear!

## Next steps

> [!div class="nextstepaction"]
> [Create a React app](create-react-app.md)

For ASP.NET Core integration:

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with React](tutorial-asp-net-core-with-react.md)
