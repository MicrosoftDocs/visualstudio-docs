---
title: "Create an ASP.NET Core app with React"
description: In this tutorial, you create an app using ASP.NET Core and React
ms.date: 08/12/2022
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

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this article, you learn how to build an ASP.NET Core project to act as an API backend and a React project to act as the UI.

Currently, Visual Studio includes ASP.NET Core Single Page Application (SPA) templates that support Angular and React. The templates provide a built in Client App folder in your ASP.NET Core projects that contains the base files and folders of each framework.

Starting in Visual Studio 2022 Preview 2, you can use the method described in this article to create ASP.NET Core Single Page Applications that:

- Put the client app in a separate project, outside from the ASP.NET Core project
- Create the client project based on the framework CLI installed on your computer

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 or later with the **ASP.NET and web development** workload installed. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
  If you need to install the workload and already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **ASP.NET and web development** workload, then choose **Modify**.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/package/npm)), which is included with Node.js
- npx ([https://www.npmjs.com/package/npx](https://www.npmjs.com/package/npx))

## Create the frontend app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**. 

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for React in the search bar at the top and then select **Standalone JavaScript React Template**. (The standalone TypeScript React Template is not currently supported in this tutorial.)

   :::image type="content" source="media/vs-2022/react-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name. When you get to the **Additional information** window, be sure to check the **Add integration for Empty ASP.NET Web API Project** option. This option adds files to your React template so that it can be hooked up later with the ASP.NET Core project.

   :::image type="content" source="media/vs-2022/react-additional-info.png" alt-text="Additional information":::

   Once the project is created, you see some new and modified files:

   - aspnetcore-https.js
   - aspnetcore-react.js
   - setupProxy.js
   - App.js (modified)
   - App.test.js (modified)

1. Select an installed browser from the Debug toolbar, such as Chrome or Microsoft Edge.

   If the browser you want is not yet installed, install the browser first, and then select it.

## Create the backend app

1. In Solution Explorer, right-click the solution name, hover over **Add**, and then select **New Project**. 

   :::image type="content" source="media/vs-2022/asp-net-core-add-project.png" alt-text="Add a new project":::

1. Search and select the ASP.NET Core Web API project.
 
   :::image type="content" source="media/vs-2022/asp-net-core-choose-web-api-template.png" alt-text="Choose the Web API template":::

1. Give your project and solution a name. When you get to the **Additional information** window, select **.NET 6.0** as your target framework.

   Once the project is created, Solution Explorer should look like this:

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-solution-explorer.png" alt-text="Take a look at Solution Explorer":::

## Set the project properties

1. In Solution Explorer, right-click the ASP.NET Core project and choose **Properties**.

   :::image type="content" source="media/vs-2022/asp-net-core-project-properties.png" alt-text="Open project properties"::: 

1. Go to the Debug menu and select **Open debug launch profiles UI** option. Uncheck the **Launch Browser** option.

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-deselect-launch-browser.png" alt-text="Open debug launch profiles UI"::: 

   >[!NOTE]
   > Currently, *launch.json* must be located under the *.vscode* folder.

## Set the startup project

1. In Solution Explorer, right-click the solution name and select **Set Startup Project**. Change the startup project from Single startup project to **Multiple startup projects**. Select **Start** for each project’s action.
  
1. Next, select the backend project and move it above the frontend, so that it starts up first.

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-startup-project.png" alt-text="Choose the startup project":::

## Start the project

1. Before you start the project, make sure that the port numbers match. Go to the *launchSettings.json* file in your ASP.NET Core project (in the *Properties* folder). Get the port number from the `applicationUrl` property.

   If there are multiple `applicationUrl` properties, look for one using an `https` endpoint. It should look similar to `https://localhost:7049`.

1. Then, go to the *setupProxy.js* file for your React project (look in the *src* folder). Update the target property to match the `applicationUrl` property in  *launchSettings.json*. When you update it, that value should look similar to this:

   ```js
   target: 'https://localhost:7049',
   ```

1. To start the project, press **F5** or select the **Start** button at the top of the window. You will see two command prompts appear:

   - The ASP.NET Core API project running
   - npm running the react-scripts start command

   >[!NOTE]
   > Check console output for messages, such as a message instructing you to update your version of Node.js.

You should see an React app appear, that is populated via the API.

## Publish the project

Starting in Visual Studio 2022 version 17.3, you can publish the integrated solution using the Visual Studio Publish tool.

>[!NOTE]
> To use publish, create your JavaScript project using Visual Studio 2022 version 17.3 or later.

1. In Solution Explorer, right-click the ASP.NET Core project and choose **Add** > **Project Reference**.

1. Select the React project and choose **OK**.

1. Right-click the ASP.NET Core project in Solution Explorer and choose **Unload project**.

   This opens the *.csproj* file for the project.

1. In the *.csproj* file, update the project reference and add `<ReferenceOutputAssembly>` with the value set to `false`.

   When you've updated the reference, it should look like this (substituting your own project folder and project name).

   ```xml
   <ProjectReference Include="..\reactprojectfolder\reactprojectname.esproj">
       <ReferenceOutputAssembly>false</ReferenceOutputAssembly>
   </ProjectReference>
   ```

1. Right.click the ASP.NET Core project and choose **Reload Project**.

1. To publish, right click the ASP.NET Core project, choose **Publish**, and select options to match your desired publish scenario, such as Azure, publish to a folder, et al.

   The publish process takes more time than it does for just an ASP.NET Core project, since the `npm run build command` gets invoked when publishing.

## Troubleshooting

You may see the following error:

```
[HPM] Error occurred while trying to proxy request /weatherforecast from localhost:4200 to https://localhost:5001 (ECONNREFUSED) (https://nodejs.org/api/errors.html#errors_common_system_errors)
```

If you see this issue, most likely the frontend started before the backend. Once you see the backend command prompt up and running, just refresh the React App in the browser.
