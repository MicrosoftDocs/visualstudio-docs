---
title: "Create an Angular app"
description: In this tutorial, learn how to create a simple Angular application in Visual Studio.
ms.date: 07/30/2021
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

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Angular frontend web application.

## Prerequisites

Make sure to have the following installed:

- Visual Studio 2022 Preview 2 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/)) 
- Angular CLI ([https://angular.io/cli](https://angular.io/cli))
  This can be the version of your choice

## Create your app

1. In the New Project Dialog, select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for Angular in the search bar at the top and then select **Standalone Angular Template**.

   :::image type="content" source="media/vs-2022/angular-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name. 

   When you get to the Additional information window be sure NOT to check the **Add integration for Empty ASP.NET Web API Project** option. This option adds files to your Angular template so that it can be hooked up with the ASP.NET Core project, if an ASP.NET Core project is added.

   :::image type="content" source="media/vs-2022/angular-additional-info.png" alt-text="Additional information":::

## Set the project properties

1. In Solution Explorer, right-click the Angular project, select **Properties**, and then go the **Debugging** section.

1. Change the Debugger to launch to the **launch.json** option.
 
   :::image type="content" source="media/vs-2022/angular-choose-debugger.png" alt-text="Choose the debugger (launch.json)":::

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

Note, the initial build may take a while, as the Angular CLI will run the npm install command.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window. You see a command prompt appear:

- The Angular CLI running the ng start command

Next, you should see the base Angular app appear!