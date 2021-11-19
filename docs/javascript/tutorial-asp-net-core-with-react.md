---
title: "Create an ASP.NET Core app with React"
description: In this tutorial, you create an app using ASP.NET Core and React
ms.date: 11/08/2021
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
# Tutorial: Create an ASP.NET Core app with React in Visual Studio

In this article, you learn how to build an ASP.NET Core project to act as an API backend and a React project to act as the UI.

Currently, Visual Studio includes ASP.NET Core Single Page Application (SPA) templates that support Angular and React. The templates provide a built in Client App folder in your ASP.NET Core projects that contains the base files and folders of each framework.

Starting in Visual Studio 2022 Preview 2, you can use the method described in this article to create ASP.NET Core Single Page Applications that:

- Put the client app in a separate project, outside from the ASP.NET Core project
- Create the client project based on the framework CLI installed on your computer

> [!NOTE]
> Currently, the front-end project must be published manually (not currently supported with the Publish tool). For additional information, see [https://github.com/MicrosoftDocs/visualstudio-docs/issues/7135](https://github.com/MicrosoftDocs/visualstudio-docs/issues/7135).

## Prerequisites

Make sure to have the following installed:

- Visual Studio 2022 Preview 2 or later with the **ASP.NET and web development** workload installed. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
  If you need to install the workload and already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **ASP.NET and web development** workload, then choose **Modify**.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/)) 
- npx ([https://www.npmjs.com/package/npx](https://www.npmjs.com/package/npx))

## Create the frontend app

1. In the New Project Dialog, select **Create a new project**. 

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for React in the search bar at the top and then select **Standalone JavaScript React Template**. (The standalone TypeScript React Template is not currently supported in this tutorial.)

   :::image type="content" source="media/vs-2022/react-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name. When you get to the **Additional information** window, be sure to check the **Add integration for Empty ASP.NET Web API Project** option. This option adds files to your React template so that it can be hooked up later with the ASP.NET Core project.

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-additional-info.png" alt-text="Additional information":::

   Once the project is created, you see some new and modified files:

   - aspnetcore-https.js
   - aspnetcore-react.js
   - setupProxy.js
   - App.js (modified)
   - App.test.js (modified)

## Create the backend app

1. In the solution explorer, right-click the solution name, hover over **Add**, and then select **New Project**. 

   :::image type="content" source="media/vs-2022/asp-net-core-add-project.png" alt-text="Add a new project":::

1. Search and select the ASP.NET Core Web API project.
 
   :::image type="content" source="media/vs-2022/asp-net-core-choose-web-api-template.png" alt-text="Choose the Web API template":::

1. Give your project and solution a name. When you get to the **Additional information** window, select **.NET 6.0** as your target framework.

   Once the project is created, Solution Explorer should look like this:

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-solution-explorer.png" alt-text="Take a look at Solution Explorer":::

## Set the project properties

1. Right-click the ASP.NET Core project and choose **Properties**.

   :::image type="content" source="media/vs-2022/asp-net-core-project-properties.png" alt-text="Open project properties"::: 
 
1. Go to the Debug menu and select **Open debug launch profiles UI** option. Uncheck the **Launch Browser** option.

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-deselect-launch-browser.png" alt-text="Open debug launch profiles UI"::: 

1. Next, right-click the React project and select the **Properties** menu and go the **Debugging** section. Change the Debugger to launch to the **launch.json** option.
 
   :::image type="content" source="media/vs-2022/asp-net-core-with-react-choose-debugger.png" alt-text="Choose the debugger (launch.json)":::

## Set the startup project

1. Right-click the solution and select **Set Startup Project**. Change the startup project from Single startup project to **Multiple startup projects**. Select **Start** for each project’s action.
  
1. Next, select the backend project and move it above the frontend, so that it starts up first.

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-startup-project.png" alt-text="Choose the startup project":::

## Start the project

1. Before you start the project, make sure that the port numbers match. Go to the *launchSettings.json* file in your ASP.NET Core project (in the *Properties* folder). Get the port number from the `applicationUrl` property.

   If there are multiple `applicationUrl` properties, look for one using an `https` endpoint. It should look similar to `https://localhost:7049`.

1. Then, go to the *setupProxy.js* file for your React project (look in the *src* folder). Update the target property to match the `applicationUrl` property in  *launchSettings.json*.

1. To start the project, press **F5** or select the **Start** button at the top of the window. You will see two command prompts appear:

- The ASP.NET Core API project running
- npm running the react-scripts start command

You should see an React app appear, that is populated via the API.

## Troubleshooting

You may see the following error:

```
[HPM] Error occurred while trying to proxy request /weatherforecast from localhost:4200 to https://localhost:5001 (ECONNREFUSED) (https://nodejs.org/api/errors.html#errors_common_system_errors)
```

If you see this issue, most likely the frontend started before the backend. Once you see the backend command prompt up and running, just refresh the React App in the browser.
