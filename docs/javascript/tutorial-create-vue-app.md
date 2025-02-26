---
title: Create a Vue.js project in Visual Studio
description: Create, build, and run a Vue.js front-end web application project from a Visual Studio template, and set basic properties for the project.
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
# Create a Vue.js project

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Vue.js frontend web application.

## Prerequisites

Make sure to install the following software:

- Visual Studio 2022 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) page to install it for free.
- npm ([`https://www.npmjs.com/`](https://www.npmjs.com/package/npm)), which is included with Node.js
- Vue.js ([Installation | Vue.js (vuejs.org)](https://v3.vuejs.org/guide/installation.html#npm))

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot showing Create a new project":::

1. Search for Vue in the search bar at the top and then select **Vue App** for either JavaScript or TypeScript.

   :::image type="content" source="media/vs-2022/vue-choose-standalone-template.png" alt-text="Screenshot showing choosing a template":::

   Starting in Visual Studio 2022 version 11, the template name was changed from **Standalone JavaScript Vue Project** to **Vue App**.

1. Give your project and solution a name, and then choose **Next**.

1. Choose **Create**, and then wait for Visual Studio to create the project.

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

Next, you should see the base Vue.js app appear!

## Next steps

For ASP.NET Core integration:

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with Vue](tutorial-asp-net-core-with-vue.md)
