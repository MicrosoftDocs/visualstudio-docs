---
title: Create a Vue.js Project in Visual Studio
description: Create, build, and run a Vue.js front-end web application project from a Visual Studio template, and set basic properties for the project.
ms.date: 05/26/2026
ms.custom: vs-acquisition
ms.topic: quickstart
ms.devlang: javascript
author: mikejo5000
ms.author: mikejo

ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '>= vs-2022'

# customer intent: As a developer, I want to create a Vue.js front-end web app project from a Visual Studio template, so I can set project properties, and build and run the app.
---

# Quickstart: Create a Vue.js project

In this Quickstart, you create and run a base Vue.js front-end web application. This article provides a 5-10 minute introduction to the Visual Studio integrated development environment (IDE).

## Prerequisites

Prepare your configuration with the following prerequisites:

- Visual Studio 2022 or later (Get the free version at [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/))

- npm (included with Node.js, [https://www.npmjs.com/](https://www.npmjs.com/package/npm))

- Vue.js ([Installation | Vue.js (vuejs.org)](https://vuejs.org/guide/quick-start.html#npm))

## Create your Vue app

Create a Vue.js web app by following these steps:

1. In the Visual Studio **Start** window (select **File** > **Start Window**), select **Create a new project**.

   ::: moniker range="visualstudio"

   :::image type="content" source="media/visualstudio/create-new-project.png" border="false" alt-text="Screenshot showing how to select the 'Create a new project' option.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="media/vs-2022/create-new-project.png" border="false" alt-text="Screenshot showing how to select the 'Create a new project' option.":::

   ::: moniker-end

1. In the **Create a new project** dialog, enter **Vue** in the search box. Select the **Vue App** template for JavaScript or TypeScript, and select **Next**.

   ::: moniker range="visualstudio"

   :::image type="content" source="media/visualstudio/vue-choose-template.png" border="false" alt-text="Screenshot showing how to choose a Vue template for JavaScript or TypeScript.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   :::image type="content" source="media/vs-2022/vue-choose-standalone-template.png" border="false" alt-text="Screenshot showing how to choose a Vue template for JavaScript or TypeScript.":::

   ::: moniker-end

   In Visual Studio 2022 version 11 and later, the template name **Standalone JavaScript Vue Project** is changed to **Vue App**.

1. Enter a name for your project and solution, and select **Create**.

Wait for Visual Studio to create your new project.

## View the project properties

The default project settings allow you to build and debug the project. 

If you want to change any settings, follow these steps:

1. Right-click the project in Solution Explorer and select **Properties**.

1. In the project properties pane, select **Debug**, **Linting**, **Build**, or **Deploy** to see the corresponding properties.

For debugger configuration, use the [launch.json](../javascript/debug-nodejs.md#configure-debugging) file.

> [!NOTE]
> The `launch.json` debugger configuration file stores the startup settings associated with the **Start** action in the Debug toolbar. The `launch.json` file must be located under the `.vscode` folder in your project.

## Build your project

To build your new project, select **Build** > **Build Solution**.

## Start your project

Select **F5** or use the **Start** action at the top of the window.

The project opens a command prompt with the following text (or similar):

```output
VITE v4.4.9 ready in 780 ms
```

> [!NOTE]
> Check the console output for messages, such as instructions to update your version of Node.js.

When the process succeeds, the base Vue.js app opens.

## Next step

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with Vue](tutorial-asp-net-core-with-vue.md)
