---
title: "Create an Angular app"
description: In this tutorial, learn how to create a simple Angular application in Visual Studio.
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
# Create an Angular app

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Angular frontend web application.

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 Preview 2 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/package/npm)), which is included with Node.js
- Angular CLI ([https://angular.io/cli](https://angular.io/cli))
  This can be the version of your choice

## Create your app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for Angular in the search bar at the top and then select **Standalone TypeScript Angular Template**.

   :::image type="content" source="media/vs-2022/angular-choose-standalone-template.png" alt-text="Choose a template":::

1. Give your project and solution a name.

   When you get to the Additional information window, be sure NOT to check the **Add integration for Empty ASP.NET Web API Project** option. This option adds files to your Angular template so that it can be hooked up with the ASP.NET Core project, if an ASP.NET Core project is added.

   :::image type="content" source="media/vs-2022/angular-additional-info-no-integration.png" alt-text="Additional information":::

## View the project properties

The default project settings allow you to build and debug the project. But, if you need to change settings, right-click the project in Solution Explorer, select **Properties**, and then go the **Build** or **Debugging** section.

>[!NOTE]
> *launch.json* stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, *launch.json* must be located under the *.vscode* folder.

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

Note, the initial build may take a while, as the Angular CLI will run the npm install command.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window, and you'll see a command prompt:

- The Angular CLI running the ng start command

   >[!NOTE]
   > Check console output for messages, such as a message instructing you to update your version of Node.js.

Next, you should see the base Angular apps appear!

## Next steps

For ASP.NET Core integration:

> [!div class="nextstepaction"]
> [Create an ASP.NET Core app with Angular](tutorial-asp-net-core-with-angular.md)
