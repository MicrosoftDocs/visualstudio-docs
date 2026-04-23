---
title: Manage npm packages for Node.js and ASP.NET Core projects
description: Manage packages in Visual Studio by using the Node.js package manager (npm) for both Node.js and ASP.NET Core applications.
ms.date: "2/11/2025"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
---
# Manage npm packages in Visual Studio

npm allows you to install and manage packages for use in both Node.js and ASP.NET Core applications. Visual Studio makes it easy to interact with npm and issue npm commands through the UI or directly. If you're unfamiliar with npm and want to learn more, go to the [npm documentation](https://docs.npmjs.com/).

Visual Studio integration with npm is different depending on your project type.
::: moniker range=">=vs-2022"
* [CLI-based projects (.esproj)](#cli-based-project-esproj)
* [ASP.NET Core](#aspnet-core-projects)
* [Open folder (Node.js)](../javascript/develop-javascript-code-without-solutions-projects.md)
::: moniker-end


> [!IMPORTANT]
> npm expects the *node_modules* folder and *package.json* in the project root. If your app's folder structure is different, you should modify your folder structure if you want to manage npm packages using Visual Studio.

::: moniker range=">=vs-2022"
## CLI-based project (.esproj)

Starting in Visual Studio 2022, the npm package manager is available for [CLI-based projects](../javascript/javascript-in-vs-2022.md#project-templates), so you can now download npm modules similarly to the way you download NuGet packages for ASP.NET Core projects. Then you can use *package.json* to modify and delete packages.

To open the package manager, from Solution Explorer, right-click the **npm** node in your project and choose **Add npm package**.

:::image type="content" source="../javascript/media/vs-2022/npm-packages-open-manager-esproj.png" alt-text="Open package manager from Solution Explorer" border="true":::

Next, you can search for npm packages, select one, and install by selecting **Install Package**.

:::image type="content" source="../javascript/media/vs-2022/npm-packages-install-esproj.png" alt-text="Install new npm package for esproj" border="true":::
::: moniker-end


## ASP.NET Core projects

For projects such as ASP.NET Core projects, you can add npm support in your project and use npm to install packages.

>[!NOTE]
> For ASP.NET Core projects, you can also use [Library Manager](/aspnet/core/client-side/libman/?view=aspnetcore-3.1&preserve-view=true) or yarn instead of npm to install client-side JavaScript and CSS files. One of these options might be necessary if you require integration with MSBuild or the dotnet CLI for package management, which is not provided by npm.

If your project does not already include a *package.json* file, you can add one to enable npm support by adding a *package.json* file to the project.

1. To add the *package.json* file, right-click the project in Solution Explorer and choose **Add** > **New Item** (or press **Ctrl** + **SHIFT** + **A**). Use the search box to find the npm file, choose the **npm Configuration File**, use the default name, and click **Add**.

1. Include one or more npm packages in the `dependencies` or `devDependencies` section of *package.json*. For example, you might add the following to the file:

   ```json
   "devDependencies": {
      "gulp": "4.0.2",
      "@types/jquery": "3.5.29"
   }
   ```

   When you save the file, Visual Studio adds the package under the **Dependencies / npm** node in Solution Explorer. If you don't see the node, right-click **package.json** and choose **Restore Packages**. To view package installation status, select **npm** output in the Output window.

   >[!NOTE]
   > The npm node is available for most ASP.NET Core project types, including Blazor. For MAUI Blazor projects, you must use the npm command line because no npm node will be present in Solution Explorer.

   You can configure npm packages using `package.json`. Either open `package.json` directly, or right-click the npm node in Solution Explorer and choose **Open package.json**.

## Troubleshooting npm packages

* If you see any errors when building your app or transpiling TypeScript code, check for npm package incompatibilities as a potential source of errors. To help identify errors, check the npm Output window when installing the packages, as described previously in this article. For example, if one or more npm package versions has been deprecated and results in an error, you might need to install a more recent version to fix errors. For information on using *package.json* to control npm package versions, see [package.json configuration](../javascript/configure-packages-with-package-json.md).

* In some ASP.NET Core scenarios, Solution Explorer might not show the correct status for installed npm packages due to a known issue described [here](https://github.com/aspnet/Tooling/issues/479). For example, the package might appear as not installed when it is installed. In most cases, you can update Solution Explorer by deleting *package.json*, restarting Visual Studio, and re-adding the *package.json* file as described earlier in this article. Or, when installing packages, you can use the npm Output window to verify installation status.

* In some ASP.NET Core scenarios, the npm node in Solution Explorer might not be visible after you build the project. To make the node visible again, right-click the project node and choose **Unload Project.** Then right-click the project node and choose **Reload Project**.

