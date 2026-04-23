---
title: Create an Angular project in Visual Studio
description: Create, build, and run a simple Angular front-end web application project from a Visual Studio template, and set basic properties for the project.
ms.date: 12/4/2024
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

# Create an Angular project

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Angular frontend web application.

## Prerequisites

Make sure to install the following software:

- Visual Studio 2022 or later. Go to the [Visual Studio downloads](https://aka.ms/vs/download/?cid=learn-onpage-download-cta) page to install it for free.
- npm ([`https://www.npmjs.com/`](https://www.npmjs.com/package/npm)), which is included with Node.js
- Angular CLI ([`https://angular.dev/tools/cli`](https://angular.dev/tools/cli)), which can be the version of your choice.

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Screenshot showing Create a new project":::

1. Search for Angular in the search bar at the top and then select **Angular App**.

   :::image type="content" source="media/vs-2022/angular-choose-standalone-template.png" alt-text="Screenshot showing choosing a template":::

   Starting in Visual Studio 2022 version 11, the template name was changed from **Standalone TypeScript Angular Project** to **Angular App**.

1. Give your project and solution a name.

1. Choose **Create**, and then wait for Visual Studio to create the project.

## View the project properties

The default project settings allow you to build and debug the project. But, if you need to change settings, right-click the project in Solution Explorer, select **Properties**, and then go the **Linting**, **Build** or **Deploy** section.

For debugger configuration, use [launch.json](../javascript/debug-nodejs.md#configure-debugging).

>[!NOTE]
> `launch.json` stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, `launch.json` must be located under the `.vscode` folder.

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

Note, the initial build may take a while, as the Angular CLI runs the npm install command.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window, and you will see a command prompt:

- The Angular CLI running the ng start command

   >[!NOTE]
   > Check console output for messages, such as a message instructing you to update your version of Node.js.

Next, you should see the base Angular apps appear!

## Next steps

For ASP.NET Core integration:

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with Angular](tutorial-asp-net-core-with-angular.md)
