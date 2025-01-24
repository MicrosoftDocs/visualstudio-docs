---
title: "Create a Vue.js app using Node.js"
description: Create Node.js applications in Visual Studio by using the Vue.js framework along with JavaScript or the TypeScript programming language.
ms.date: "11/06/2023"
ms.topic: "how-to"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: javascript-typescript
dev_langs:
  - JavaScript
monikerRange: '=vs-2019'
---
# Create a Vue.js application using Node.js Tools for Visual Studio

Visual Studio supports app development with the [Vue.js](https://vuejs.org/) framework in either JavaScript or TypeScript.

The following new features support Vue.js application development in Visual Studio:

* Support for Script, Style, and Template blocks in *.vue* files
* Recognition of the `lang` attribute on *.vue* files
* Vue.js project and file templates

## Prerequisites

* You must have Visual Studio 2017 version 15.8 or a later version installed and the **Node.js development** workload.

    > [!IMPORTANT]
    > This article requires features that are only available starting in Visual Studio 2017 version 15.8.

    If a required version isn't already installed, install [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta).

    If you need to install the workload but already have Visual Studio, go to **Tools** > **Get Tools and Features...**, which opens the Visual Studio Installer. Choose the **Node.js development** workload, then choose **Modify**.

* To create the ASP.NET Core project, you must have the ASP.NET and web development and .NET Core cross-platform development workloads installed.

* You must have the Node.js runtime installed.

    If you don't have it installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website. In general, Visual Studio automatically detects the installed Node.js runtime. If it doesn't detect an installed runtime, you can configure your project to reference the installed runtime in the properties page. (After you create a project, right-click the project node and choose **Properties**).

## Create a Vue.js project using Node.js

You can use the new Vue.js templates to create a new project. Use of the template is the easiest way to get started. For detailed steps, see [Use Visual Studio to create your first Vue.js app](../javascript/quickstart-vuejs-with-nodejs.md).

## Create a Vue.js project with ASP.NET Core and the Vue CLI

Vue.js provides an official CLI for quickly scaffolding projects. If you would like to use the CLI to create your application, follow the steps in this article to set up your development environment.

> [!IMPORTANT]
> These steps assume that you already have some experience with the Vue.js framework. If not, please visit [Vue.js](https://vuejs.org/) to learn more about the framework.

### Create a new ASP.NET Core project

For this example, you use an empty ASP.NET Core Application (C#). However, you can choose from various projects and programming languages.

#### Create an Empty project

* Open Visual Studio and create a new project.

    In Visual Studio 2019, choose **Create a new project** in the start window. If the start window isn't open, choose **File** > **Start Window**. Type **web app**, choose **C#** as the language, then choose **ASP.NET Core Empty**, and then choose **Next**. On the next screen, name the project **client-app**, and then choose **Next**.

    Choose either the recommended target framework or .NET 6, and then choose **Create**.

    If you don't see the **ASP.NET Core Web Application** project template, you must install the **ASP.NET and web development** workload and the .**NET Core** development workload first. To install the workload(s), click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box (select **File** > **New** > **Project**). The Visual Studio Installer launches. Select the required workloads.

#### Configure the project startup file

* Open the file *./Startup.cs*, and add the following lines to the Configure method:

    ```csharp
    app.UseDefaultFiles(); // Enables default file mapping on the web root.
    app.UseStaticFiles(); // Marks files on the web root as servable.
    ```

### Install the vue CLI

To install the vue-cli npm module, open a command prompt and type `npm install --g vue-cli` or `npm install -g @vue/cli` for version 3.0 (currently in beta).

### Scaffold a new client application using the vue CLI

1. Go to your command prompt and change the current directory to your project root folder.

1. Type `vue init webpack client-app` and follow steps when prompted to answer additional questions.

    > [!NOTE]
    > For *.vue* files, you need to use webpack or a similar framework with a loader to do the conversion. TypeScript and Visual Studio does not know how to compile *.vue* files. The same is true for bundling; TypeScript doesn't know how to convert ES2015 modules (that is, `import` and `export` statements) into a single final *.js* file to load in the browser. Again, webpack is the best choice here. To drive this process from within Visual Studio using MSBuild, you need to do start from a Visual Studio template. At present, there is no ASP.NET template for Vue.js development in-the-box.

#### Modify the webpack configuration to output the built files to wwwroot

* Open the file *./client-app/config/index.js*, and change the `build.index` and `build.assetsRoot` to wwwroot path:

    ```js
    // Template for index.html
    index: path.resolve(__dirname, '../../wwwroot/index.html'),

    // Paths
    assetsRoot: path.resolve(__dirname, '../../wwwroot'),
    ```

#### Indicate the project to build the client app each time that a build is triggered

1. In Visual Studio, go to **Project** > **Properties** > **Build Events**.

1. On **Pre-build event command line**, type `npm --prefix ./client-app run build`.

#### Configure webpack's output module names

* Open the file *./client-app/build/webpack.base.conf.js*, and add the following properties to the output property:

    ```js
    devtoolModuleFilenameTemplate: '[absolute-resource-path]',
    devtoolFallbackModuleFilenameTemplate: '[absolute-resource-path]?[hash]'
    ```

### Add TypeScript support with the Vue CLI

These steps require vue-cli 3.0, which is currently in beta.

1. Go to your command prompt and change the current directory to the project root folder.

1. Type `vue create client-app`, and then choose **Manually select features**.

1. Choose **Typescript**, and then select other desired options.

1. Follow the remaining steps and respond to the questions.

#### Configure a Vue.js project for TypeScript

1. Open the file *./client-app/tsconfig.json* and add `noEmit:true` to the compiler options.

    By setting this option, you avoid cluttering your project each time that you build in Visual Studio.

1. Next, create a *vue.config.js* file in *./client-app/* and add the following code.

    ```js
    module.exports = {
        outputDir: '../wwwroot',

        configureWebpack: {
            output: {
                devtoolModuleFilenameTemplate: '[absolute-resource-path]',
                devtoolFallbackModuleFilenameTemplate: '[absolute-resource-path]?[hash]'
            }
        }
    };
    ```

    The preceding code configures webpack and sets the wwwroot folder.

#### Build with vue-cli 3.0

An unknown issue with the vue-cli 3.0 might prevent automating the build process. Each time that you try to refresh the wwwroot folder, you need to run the command `npm run build` on the client-app folder.

Alternatively, you can build the vue-cli 3.0 project as a pre-build event using the ASP.NET project properties. Right-click the project, choose **Properties**, and include the following commands in the **Build** tab, in the **Pre-build event command line** text box.

```cmd
cd ./client-app
npm run build
cd ../
```

## Limitations

* `lang` attribute only supports JavaScript and TypeScript languages. The accepted values are: js, jsx, ts, and tsx.
* `lang` attribute doesn't work with template or style tags.
* Debugging script blocks in *.vue* files isn't supported due to its preprocessed nature.
* TypeScript doesn't recognize *.vue* files as modules. You need a file that contains code such as the following to tell TypeScript what *.vue* files look like (vue-cli 3.0 template already includes this file).

    ```js
    // ./client-app/vue-shims.d.ts
    declare module "*.vue" {
        import Vue from "vue";
        export default Vue;
    }
    ```

* Running the command `npm run build` as a pre-build event on the project properties doesn't work when using vue-cli 3.0.

## Related content

- [Vue get started guide](https://vuejs.org/v2/guide).
- [Vue CLI project](https://github.com/vuejs/vue-cli).
- [Webpack configuration documentation](https://webpack.js.org/configuration/).
