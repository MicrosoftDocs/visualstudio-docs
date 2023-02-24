---
title: "Create a Vue.js app"
description: In this tutorial, learn how to create a simple Vue.js application in Visual Studio.
ms.date: 02/24/2023
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
monikerRange: '>= vs-2022'
---
# Create a Vue.js app

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Vue.js frontend web application.

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 Preview 2 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/package/npm)), which is included with Node.js
- Vue.js ([Installation | Vue.js (vuejs.org)](https://v3.vuejs.org/guide/installation.html#npm))
- Vue.js CLI ([(Installation | Vue.js (vuejs.org)](https://v3.vuejs.org/guide/installation.html#cli))

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for Vue in the search bar at the top and then select **Standalone JavaScript Vue Template** or **Standalone TypeScript Vue Template**, based on your preference.

   :::image type="content" source="media/vs-2022/vue-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name.

## View the project properties

The default project settings allow you to build and debug the project. But, if you need to change settings, right-click the project in Solution Explorer, select **Properties**, and then go the **Build** or **Debugging** section.

>[!NOTE]
> *launch.json* stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, *launch.json* must be located under the *.vscode* folder.

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window, and you'll see a command prompt:

- npm running the vue-cli-service start command

   >[!NOTE]
   > Check console output for messages, such as a message instructing you to update your version of Node.js.

Next, you should see the base Vue.js app appear!

## Next steps

For ASP.NET Core integration:

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with Vue](tutorial-asp-net-core-with-vue.md)