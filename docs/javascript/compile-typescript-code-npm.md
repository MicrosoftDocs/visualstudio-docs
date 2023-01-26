---
title: Compile and build TypeScript code using npm
description: Learn how to add TypeScript support to your Visual Studio projects by using the Node Package Manager (npm).
ms.date: 01/23/2023
ms.topic: conceptual
ms.custom: devdivchpfy22
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-javascript
dev_langs:
  - JavaScript
ms.workload:
  - nodejs
---
# Compile TypeScript code (Node.js)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can add TypeScript support to your projects using the TypeScript SDK or by using npm. The TypeScript SDK is available by default in the Visual Studio installer.

For projects developed in Visual Studio 2019, we encourage you to use the TypeScript npm package for greater portability across different platforms and environments.

For ASP.NET Core projects, it's recommended that you use the [NuGet package](../javascript/compile-typescript-code-nuget.md) instead.

## Add TypeScript support using npm

The [TypeScript npm package](https://www.npmjs.com/package/typescript) adds TypeScript support. When the npm package for TypeScript 2.1 or higher is installed into your project, the corresponding version of the TypeScript language service gets loaded in the editor.

1. [Follow instructions](./tutorial-nodejs.md?toc=%252fvisualstudio%252fjavascript%252ftoc.json) to install the Node.js development workload and the Node.js runtime.

   For a simple Visual Studio integration, create your project using one of the Node.js TypeScript templates, such as the Blank Node.js Web Application template. Else, use either a Node.js JavaScript template included with Visual Studio and follow instructions here. Or, use an [Open Folder](../javascript/develop-javascript-code-without-solutions-projects.md) project.

1. If your project doesn't already include it, install the [TypeScript npm package](https://www.npmjs.com/package/typescript).

   From Solution Explorer (right pane), open the *package.json* in the project root. The packages listed correspond to packages under the npm node in Solution Explorer. For more information, see [Manage npm packages](../javascript/npm-package-management.md).

   For a Node.js project, you can install the TypeScript npm package using the command line or the IDE. To install using the IDE, right-click the npm node in Solution Explorer, choose **Install New npm package**, search for **TypeScript**, and install the package.

   Check the **npm** option in the **Output** window to see package installation progress. The installed package shows up under the **npm** node in Solution Explorer.

1. If your project doesn't already include it, add a *tsconfig.json* file to your project root. To add the file, right-click the project node and choose **Add > New Item**. Choose the **TypeScript JSON Configuration File**, and then click **Add**.

   Visual Studio adds the *tsconfig.json* file to the project root. You can use this file to [configure options](https://www.typescriptlang.org/docs/handbook/tsconfig-json.html) for the TypeScript compiler.

1. Open *tsconfig.json* and update to set the compiler options that you want.

   An example of a simple *tsconfig.json* file follows.

   ```json
   {
     "compilerOptions": {
       "noImplicitAny": false,
       "noEmitOnError": true,
       "removeComments": false,
       "sourceMap": true,
       "target": "es5",
       "outDir": "dist"
     },
     "include": [
       "scripts/**/*"
     ]
   }
   ```

   In this example:
   - *include* tells the compiler where to find TypeScript (*.ts) files.
   - *outDir* option specifies the output folder for the plain JavaScript files that are transpiled by the TypeScript compiler.
   - *sourceMap* option indicates whether the compiler generates *sourceMap* files.

   The previous configuration provides only a basic introduction to configuring TypeScript. For information on other options, see [tsconfig.json](https://www.typescriptlang.org/docs/handbook/tsconfig-json.html).

## Build the application

1. Add TypeScript (*.ts*) or TypeScript JSX (*.tsx*) files to your project, and then add TypeScript code. A simple example of TypeScript follows:

   ```typescript
   let message: string = 'Hello World';
   console.log(message);
   ```

1. In *package.json*, add support for Visual Studio build and clean commands using the following scripts.

   ```json
   "scripts": {
     "build": "tsc --build",
     "clean": "tsc --build --clean"
   },
   ```

   To build using a third-party tool like webpack, you can add a command-line build script to your *package.json* file:

   ```json
   "scripts": {
      "build": "webpack-cli app.tsx --config webpack-config.js"
   }
   ```

   For an example of using webpack with React and a webpack configuration file, see [Create a web app with Node.js and React](../javascript/tutorial-nodejs-with-react-and-jsx.md).

   ::: moniker range="vs-2019"
   For an example of using Vue.js with TypeScript, see [Create a Vue.js application](create-application-with-vuejs.md).
   ::: moniker-end

1. If you need to configure options such as the startup page, path to the Node.js runtime, application port, or runtime arguments, right-click the project node in Solution Explorer, and choose **Properties**.

   >[!NOTE]
   > When configuring third-party tools, Node.js projects don't use the paths that are configured under **Tools** > **Options** > **Projects and solutions** > **Web Package Management** > **External Web Tools**. These settings are used for other project types.

1. Choose **Build > Build Solution**.

   The app builds automatically when you run it. However, the following might occur during the build process:

   If you generated source maps, open the folder specified in the *outDir* option and you find the generated \*.js file(s) along with the generated \*js.map file(s).

   Source map files are required for [debugging](../javascript/debug-nodejs.md).

### Run the application

For instructions to run the app after you compile it, see [Create a Node.js and Express app](./tutorial-nodejs.md?toc=%252fvisualstudio%252fjavascript%252ftoc.json#run-the-app).

## Automate build tasks

You can use Task Runner Explorer in Visual Studio to help automate tasks for third-party tools like npm and webpack.

- [NPM Task Runner](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.NPMTaskRunner) - Adds support for npm scripts defined in *package.json*. Supports yarn.
- [Webpack Task Runner](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebPackTaskRunner) - Adds support for webpack.

## See also

[Properties, React, Angular, Vue](../ide/reference/property-pages-javascript-esproj.md)