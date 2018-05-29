---
title: "Create a Node.js and Express app"
description: In this tutorial, you create an app in using Node.js tools for Visual Studio
ms.custom: ""
ms.date: "03/13/2018"
ms.technology: vs-nodejs
ms.topic: "tutorial"
ms.devlang: javascript
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
dev_langs:
  - JavaScript
ms.workload:
  - "nodejs"
---
# Tutorial: Create a Node.js and Express app in Visual Studio
In this tutorial for Visual Studio development using Node.js and Express, you create a simple Node.js web application, add some code, explore some features of the IDE, and run the app. If you haven't already installed Visual Studio, install it for free [here](http://www.visualstudio.com).

In this tutorial, you learn how to:
> [!div class="checklist"]
> * Create a Node.js project
> * Add some code
> * Use IntelliSense
> * Run the app
> * Hit a breakpoint

## Prerequisites

* You must have Visual Studio 2017 installed and the Node.js development workload.

    If you haven't already installed Visual Studio, install it for free [here](http://www.visualstudio.com).

    If you need to install the workload but already have Visual Studio, click the **Open Visual Studio Installer** link in the left pane of the **New Project** dialog box. The Visual Studio Installer launches. Choose the **Node.js development** workload, then choose **Modify**.

* You must have the Node.js runtime installed.

    If you don't have it installed, install the LTS version from the [Node.js](https://nodejs.org/en/download/) website. In general, Visual Studio automatically detects the installed Node.js runtime. If it does not detect an installed runtime, you can configure your project to reference the installed runtime in the properties page (after you create a project, right-click the project node and choose **Properties**).

    This tutorial was tested with Node.js 8.10.0.

## Create a project
First, you'll create an Node.js web application project.

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box, in the left pane, expand **JavaScript**, and then choose **Node.js**. In the middle pane, select **Basic Azure Node.js Express 4 Application** and then choose **OK**.

     If you don't see the **Basic Azure Node.js Express 4 Application** project template, you must install the **Node.js development** workload first.

    Visual Studio creates the new solution and opens your project. The *app.js* project file opens in the editor (left pane).

    - Highlighted in bold is your project, using the name you gave in the **New Project** dialog box. In the file system, this project is represented by a *.njsproj* file in your project folder. You can set properties and environment variables associated with the project by right-clicking the project and choosing **Properties**. You can do round-tripping with other development tools, because the project file does not make custom changes to the Node.js project source.

    - At the top level is a solution, which by default has the same name as your project. A solution, represented by a *.sln* file on disk, is a container for one or more related projects.

    - The npm node shows any installed npm packages. You can right-click the npm node to search for and install npm packages using a dialog box.

    - Project files such as *app.js* show up under the project node. *app.js* is the project startup file.

1. Open the **npm** node and make sure that all the required npm packages are present.

    If any are missing (exclamation point icon), you can right-click the **npm** node and choose **Install Missing npm Packages**.

## Add some code

1. In Solution Explorer (right pane), open the views folder, then open *index.pug*.

1. Replace the content with the following markup.

    ```js
    extends layout

    block content
      h1= title
      p Welcome to #{title}
      script.
        var f1 = function() { document.getElementById('myImage').src='#{data.item1}' }
      script.
        var f2 = function() { document.getElementById('myImage').src='#{data.item2}' }
      script.
        var f3 = function() { document.getElementById('myImage').src='#{data.item3}' }

      button(onclick='f1()') One!
      button(onclick='f2()') Two!
      button(onclick='f3()') Three!
      p
      a: img(id='myImage' height='200' width='200' src='')
    ```

    The preceding code adds markup to dynamically generate an HTML page with a title and welcome message. The page also includes code to display an image that changes whenever you press a button.

1. In the routes folder, open *index.js*.

1. Add the following code before the call to `router.get`:

    ```js
    var getData = function () {
        var data = {
            'item1': 'http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-76.jpg',
            'item2': 'http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-77.jpg',
            'item3': 'http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-78.jpg'
        }
        return data;
    }
    ````

    This code creates a data object that we will pass to the dynamically generated HTML page.

1. Replace the `router.get` function call with the following code:

    ```js
    router.get('/', function (req, res) {
        res.render('index', { title: 'Express', "data" });
    });
    ```
    
    The preceding code sets the current page using the Express router object and renders the page, passing the title and data object to the page.

    To demonstrate several features of Visual Studio, we included an error in the line of code containing `res.render`. We need to fix the error before the app can run. We fix the error in the next section.

## Use IntelliSense

1. In *index.js*, go to the line of code containing `res.render`.

1. Put your cursor after the `data` string, type `: get` and IntelliSense will show you the `getData` function. Select `getData`.

    ![Use IntelliSense](../nodejs/media/tutorial-nodejs-intellisense.png)

1. Remove the comma (`,`) before `"data"` and you see green syntax highlighting on the expression. Hover over the syntax highlighting.

    ![View syntax error](../nodejs/media/tutorial-nodejs-syntax-checking.png)

    The last line of this message tells you that the JavaScript interpreter expected a comma (`,`).

1. Click the **Error List** tab.

    You see the warning and description along with the filename and line number.

    ![View error list](../nodejs/media/tutorial-nodejs-error-list.png)

1. Fix the code by adding the comma (`,`) before `"data"`.

## Set a breakpoint

1. In *index.js*, click in the left gutter before the following line of code to set a breakpoint:

    `res.render('index', { title: 'Express', "data": getData() });`

    Breakpoints are the most basic and essential feature of reliable debugging. A breakpoint indicates where Visual Studio should suspend your running code so you can take a look at the values of variables, or the behavior of memory, or whether or not a branch of code is getting run.

    ![Set a breakpoint](../nodejs/media/tutorial-nodejs-set-breakpoint.png)

## Run the application

1. Select the debug target in the Debug toolbar.

    ![Select the debug target](../nodejs/media/tutorial-nodejs-deploy-target.png)

1. Press **F5** (**Debug** > **Start Debugging**) to run the application.

    The debugger pauses at the breakpoint you set. Now, you can inspect your app state.

1. Hover over `getData` to see its properties in a DataTip

    ![Inspect variables](../nodejs/media/tutorial-nodejs-inspect-variables.png)

1. Press **F5** (**Debug** > **Continue**) to continue.

    The app opens in a browser.

    In the browser window, you will see "Express" as the title and "Welcome to Express" in the first paragraph.

1. Click the buttons to display different images.

    ![App running in browser](../nodejs/media/tutorial-nodejs-running-in-browser.png)

1. Close the web browser.

## (Optional) Publish to Azure App Service

1. In Solution Explorer, right-click the project and choose **Publish**.

   ![Publish to Azure App Service](../nodejs/media/tutorial-nodejs-publish-to-azure.png)

1. Choose **Microsoft Azure App Service**.

    In the **App Service** dialog box, you can sign into your Azure account and connect to existing Azure subscriptions.

1. Follow the remaining steps to select a subscription, choose or create a resource group, choose or create an app service plane, and then follow the steps when prompted to publish to Azure. For more detailed instructions, see [Publish to Azure website using web deploy](https://github.com/Microsoft/nodejstools/wiki/Publish-to-Azure-Website-using-Web-Deploy).

1. The **Output** window shows progress on deploying to Azure.

    On successful deployment, your app opens in a browser running in Azure App Service. Click a button to display an image.

   ![App running in Azure App Service](../nodejs/media/tutorial-nodejs-running-in-azure.png)

Congratulations on completing this tutorial!

## Next steps

In this tutorial, you learned how to create and run a Node.js app using Express and hit a breakpoint using the debugger.

> [!div class="nextstepaction"]
> [Node.js tools for Visual Studio](https://github.com/Microsoft/nodejstools)