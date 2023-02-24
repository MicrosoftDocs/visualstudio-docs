---
title: "Create an ASP.NET Core app with React"
description: In this tutorial, you create an app using ASP.NET Core and React
ms.date: 02/24/2023
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

You can use the method described in this article to create ASP.NET Core Single Page Applications that:

- Put the client app in a separate project, outside from the ASP.NET Core project
- Create the client project based on the framework CLI installed on your computer

> [!NOTE]
> A simplified, updated template is available starting in Visual Studio 2022 version 17.5. This article describes the process using the new template.

## Prerequisites

Make sure to install the following:

- Visual Studio 2022 version 17.5 or later with the **ASP.NET and web development** workload installed. Go to the [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/) page to install it for free.
  If you need to install the workload and already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **ASP.NET and web development** workload, then choose **Modify**.
- npm ([https://www.npmjs.com/](https://www.npmjs.com/package/npm)), which is included with Node.js
- npx ([https://www.npmjs.com/package/npx](https://www.npmjs.com/package/npx))

## Create the frontend app

1. In the Start window (choose **File** > **Start Window** to open), select **Create a new project**.

   :::image type="content" source="media/vs-2022/create-new-project.png" alt-text="Create a new project":::

1. Search for React in the search bar at the top and then select **React and ASP.NET Core (Preview)**. This is a JavaScript template.

   :::image type="content" source="media/vs-2022/react-choose-template.png" alt-text="Choose a template":::

1. Give your project and solution a name, and then choose **Create** to create the solution.

   Once the project is created, Solution Explorer should look like this:

   :::image type="content" source="media/vs-2022/asp-net-core-with-react-solution-explorer.png" alt-text="Take a look at Solution Explorer":::

   Compared to the [standalone React template](../javascript/tutorial-create-react-app.md), you see some new and modified files for integration with ASP.NET Core:

   - aspnetcore-https.js
   - aspnetcore-react.js
   - setupProxy.js
   - App.js (modified)
   - App.test.js (modified)

1. Select an installed browser from the Debug toolbar, such as Chrome or Microsoft Edge.

   If the browser you want is not yet installed, install the browser first, and then select it.

## Set the project properties

1. In Solution Explorer, right-click the ASP.NET Core project and choose **Properties**.

   :::image type="content" source="media/vs-2022/asp-net-core-project-properties.png" alt-text="Open project properties"::: 

1. Go to the Debug menu and select **Open debug launch profiles UI** option. Uncheck the **Launch Browser** option for https.

   :::image type="content" source="media/vs-2022/asp-net-core-deselect-launch-browser.png" alt-text="Open debug launch profiles UI"::: 

   This prevents opening the web page with the source weather data.

   >[!NOTE]
   > *launch.json* stores the startup settings associated with the **Start** button in the Debug toolbar. Currently, *launch.json* must be located under the *.vscode* folder.

## Start the project

1. To start the project, press **F5** or select the **Start** button at the top of the window. You will see two command prompts appear:

   - The ASP.NET Core API project running
   - npm running the react-scripts start command

   >[!NOTE]
   > Check console output for messages, such as a message instructing you to update your version of Node.js.

You should see a React app appear, that is populated via the API. If you don't see the app, see [Troubleshooting](#troubleshooting).

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

1. In *Program.cs*, update the check for `Environment.IsDevelopment` so it looks like the following.

   ```csharp
   // Configure the HTTP request pipeline.
   if (app.Environment.IsDevelopment())
   {
      app.UseSwagger();
      app.UseSwaggerUI();
   }
   else
   {
      app.UseDefaultFiles();
      app.UseStaticFiles();
   }
   ```

1. To publish, right click the ASP.NET Core project, choose **Publish**, and select options to match your desired publish scenario, such as Azure, publish to a folder, et al.

   The publish process takes more time than it does for just an ASP.NET Core project, since the `npm run build` command gets invoked when publishing.

   You can modify the `npm run build` command using the **Production Build Command** in the React project properties. To modify it, right-click the React project in Solution Explorer and choose **Properties**.

## Troubleshooting

### Proxy error

You may see the following error:

```cmd
[HPM] Error occurred while trying to proxy request /weatherforecast from localhost:4200 to https://localhost:5001 (ECONNREFUSED) (https://nodejs.org/api/errors.html#errors_common_system_errors)
```

If you see this issue, most likely the frontend started before the backend. Once you see the backend command prompt up and running, just refresh the React App in the browser.

### Verify ports

If the weather data does not load correctly, you may also need to verify that your ports are correct.

1. Make sure that the port numbers match. Go to the *launchSettings.json* file in your ASP.NET Core project (in the *Properties* folder). Get the port number from the `applicationUrl` property.

   If there are multiple `applicationUrl` properties, look for one using an `https` endpoint. It should look similar to `https://localhost:7049`.

1. Then, go to the *setupProxy.js* file for your React project (look in the *src* folder). Update the target property to match the `applicationUrl` property in  *launchSettings.json*. When you update it, that value should look similar to this:

   ```js
   target: 'https://localhost:7049',
   ```
