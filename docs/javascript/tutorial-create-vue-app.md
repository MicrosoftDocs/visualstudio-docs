---
title: "Create a Vue.js app"
description: In this tutorial, learn how to create a simple Vue.js application in Visual Studio.
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
# Create a Vue.js app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create and run a simple Vue.js frontend web application.

## Prerequisites

Make sure to have the following installed:

- Visual Studio 2022 Preview 2 or later. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/)) 
- Vue.js ([Installation | Vue.js (vuejs.org)](https://v3.vuejs.org/guide/installation.html#npm))
- Vue.js CLI ([(Installation | Vue.js (vuejs.org)](https://v3.vuejs.org/guide/installation.html#cli))

## Create your app

1. In the New Project Dialog, select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for Vue in the search bar at the top and then select **Standalone JavaScript Vue Template** or **Standalone TypeScript Vue Template**, based on your preference.

   :::image type="content" source="media/vs-2022/vue-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name. 

## Set the project properties

1. In Solution Explorer, right-click the Vue.js project, select **Properties**, and then go the **Debugging** section.

1. Change the Debugger to launch to the **launch.json** option.
 
   :::image type="content" source="media/vs-2022/vue-choose-debugger.png" alt-text="Choose the debugger (launch.json)":::

## Build Your Project

Choose **Build** > **Build Solution**  to build the project.

## Start Your Project

Press **F5** or select the **Start** button at the top of the window. You see a command prompt appear:

- npm running the vue-cli-service start command

Next, you should see the base Vue.js app appear!