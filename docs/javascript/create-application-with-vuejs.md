---
title: "Create a Vue.js app using Node.js Tools for Visual Studio"
description: You can create Node.js applications in Visual Studio using the Vue.js framework
ms.custom: ""
ms.date: "07/06/2018"
ms.technology: vs-nodejs
ms.topic: "conceptual"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---

# Create a Vue.js application using Node.js Tools for Visual Studio

Visual Studio 2017 includes improved support for the [Vue.js](https://vuejs.org/) framework, which improves the development experience when creating an application with Vue.js, JavaScript and TypeScript.

New features that support Vue.js application development in Visual Studio include the following:

* Support for Script, Style and Template blocks in .*vue* files
* Recognition of the lang attribute on .*vue* files
* Vue.js project and file templates

## Prerequisites

* You must have Visual Studio 2017 version 15.8 Preview 3 or later installed and the **Node.js development** workload.

    > [!IMPORTANT]
    > This article requires features that are only available starting in Visual Studio 2017 version 15.8 Preview 3.

    If you haven't already installed Visual Studio, go to the [Visual Studio downloads](https://www.visualstudio.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2017) page to install it for free.

    If you need to install the workload but already have Visual Studio, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box (select **File** > **New** > **Project**). The Visual Studio Installer launches. Choose the **Node.js development** workload, then choose **Modify**.

* To create the ASP.NET Core project, you must have the ASP.NET and web development and .NET Core cross-platform development workloads installed.

* You must have the Node.js runtime installed.

    If you don't have it installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website. In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime, you can configure your project to reference the installed runtime in the properties page (after you create a project, right-click the project node and choose **Properties**).

## Create a Vue.js project using a template

You can use the new Vue.js templates to create a new project. This is the easiest way to get started. For detailed steps, see [Use Visual Studio to create your first Vue.js app](../javascript/quickstart-vuejs-with-nodejs.md).

## Create a Vue.js project with ASP.NET Core and the Vue CLI

Vue.js provides an official CLI for quickly scaffolding projects. If you would like to use the CLI to create your application, follow the steps in this article to set up your development environment.

> [!IMPORTANT]
> These steps assume that you already have some experience with the Vue.js framework. If not, please visit [Vue.js](https://vuejs.org/) to learn more about the framework.

### Create a new ASP.NET Core project

For this example, we use an empty ASP.NET Core Application (C#), but you can choose from a variety of projects and languages of your choice.

#### Create an Empty project

1. Open Visual Studio and choose **File** > **New** > **Project** from the main menu.

1. Under **Visual C#** > **Web**, choose **ASP.NET Core Web Application**, and then click **OK**.

    If you don't see the **ASP.NET Core Web Application** project template, you must install the **ASP.NET and web development** workload and the .**NET Core** development workload first. To install the workload(s), click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box (select **File** > **New** > **Project**). The Visual Studio Installer launches. Select the required workloads.

1. Select **Empty**, and then click **OK**.

    Visual Studio creates the project, which opens in Solution Explorer (right pane).

#### Configure the project startup file

* Open the file *./Startup.cs*, and add the following lines to the Configure method:

    ```csharp
    app.UseDefaultFiles() // Enables default file mapping on the web root.
    app.UseStaticFiles(); // Marks files on the web root as servable.
    ```

### Install the vue CLI

To install the vue-cli npm module, open a command prompt and type `npm install --g vue-cli` or `npm install -g @vue/cli` for version 3.0 (currently in beta).

### Scaffold a new client application using the vue CLI

1. Go to your command prompt and change the current directory to your project root folder.

1. Type `vue init webpack ClientApp` and follow steps when prompted to answer additional questions.

#### Modify the webpack configuration to output the built files to wwwroot

* Open the file *./ClientApp/config/index.js*, and change the `build.index` and `build.assetsRoot` to wwwroot path:

    ```js
    // Template for index.html
    index: path.resolve(__dirname, '../../wwwroot/index.html'),

    // Paths
    assetsRoot: path.resolve(__dirname, '../../wwwroot'),
    ```

#### Indicate the project to build the ClientApp each time that a build is triggered

1. In Visual Studio, go to **Project** > **Properties** > **Build Events**.

1. On **Pre-build event command line**, type `npm --prefix ./ClientApp run build`.

#### Configure webpack's output module names

* Open the file *./ClientApp/build/webpack.base.conf.js*, and add the following properties to the output property:

    ```js
    devtoolModuleFilenameTemplate: '[absolute-resource-path]',
    devtoolFallbackModuleFilenameTemplate: '[absolute-resource-path]?[hash]'
    ```

### Add TypeScript support with the Vue CLI

These steps require vue-cli 3.0, which is currently in beta.

1. Go to your command prompt and change the current directory to the project root folder.

1. Type `vue create ClientApp` and choose **Manually select features**.

1. Choose **Typescript** and any other options desired.

1. Follow the remaining steps and answer questions where indicated.

#### Configure a Vue.js project for TypeScript

1. Open the file *./ClientApp/tsconfig.json* and add `noEmit:true` to the compiler options.

    By setting this option, you avoid cluttering your project each time that you build in Visual Studio.

1. Next, create a *vue.config.js* file in *./ClientApp/* and add the following code.

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

    The preceding code configures webpack and set the wwwroot folder.

#### Build with vue-cli 3.0
There is an unknown issue with the vue-cli 3.0 that prevents automating the build process. Everytime you wish to refresh the wwwroot folder you will need to run the command `npm run build` on the ClientApp folder.

## Limitations

* Lang attribute only supports JavaScript and TypeScript languages. The accepted values are: js, jsx, ts and tsx.
* Lang attribute doesn't work with template or style tags.
* Debugging script blocks in .*vue* files is not supported due to its preprocessed nature.
* TypeScript doesn't recognize .*vue* files as modules. You need a file that contains code such as the following code to tell TypeScript what .*vue* files look like (vue-cli 3.0 template already includes this file).

    ```js
    // ./ClientApp/vue-shims.d.ts
    declare module "*.vue" {
        import Vue from "vue";
        export default Vue;
    }
    ```

* Running the command `npm run build` as a pre-build event on the project properties doesn't work when using vue-cli 3.0.

## See also
https://vuejs.org/v2/guide - Vue get started guide.  
https://github.com/vuejs/vue-cli - Vue CLI project.  
https://webpack.js.org/configuration/ - Webpack configuration documentation.