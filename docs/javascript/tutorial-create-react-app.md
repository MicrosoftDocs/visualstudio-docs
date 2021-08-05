---
title: "Create a React app"
description: In this tutorial, learn how to create a simple React application in Visual Studio.
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
# Create a React app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple React frontend web application.

## Prerequisites

Make sure to have the following installed:

- Visual Studio 2022 Preview 2 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/)) 
- npx ([https://www.npmjs.com/package/npx](https://www.npmjs.com/package/npx))

## Create your app

1. In the New Project Dialog, select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for React in the search bar at the top and then select **Standalone JavaScript React Template** or **Standalone TypeScript React Template**, based on your preference.

   :::image type="content" source="media/vs-2022/react-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name. 

   If you previously selected Standalone JavaScript React Template, when you get to the Additional information window be sure NOT to check the **Add integration for Empty ASP.NET Web API Project** option. This option adds files to your React template so that it can be hooked up with the ASP.NET Core project, if an ASP.NET Core project is added.

   :::image type="content" source="media/vs-2022/react-additional-info.png" alt-text="Additional information":::

   Please note that creation of the React project takes a moment because the create-react-app command that runs at this time also runs the npm install command

## Set the project properties

1. In Solution Explorer, right-click the React project, select **Properties**, and then go the **Debugging** section.

1. Change the Debugger to launch to the **launch.json** option.
 
   :::image type="content" source="media/vs-2022/react-choose-debugger.png" alt-text="Choose the debugger (launch.json)":::

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window. You see a command prompt appear:

- npm running the react-scripts start command

Next, you should see the base React app appear!