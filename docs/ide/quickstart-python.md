---
title: "Quickstart: use Visual Studio to create your first Python web app | Microsoft Docs"
description: A short introduction to using Python in Visual Studio that builds a simple web app using the Flask framework.
ms.custom: ""
ms.date: 03/20/2018
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: quickstart
dev_langs:
  - python
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload:
  - "python"
  - "data-science"
---

# Quickstart: Use Visual Studio to create your first Python web app

In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you create a simple Python web application based on the Flask framework. You create the project through discrete steps to help you learn about Visual Studio's basic features and to understand how Visual Studio automates those steps through project templates.

If you haven't already installed Visual Studio, go to the [Visual Studio Downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free. In the installer, make sure to select the **Python development** workload.

## Create the project

The following steps create an empty project that serves as the container for the application:

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File > New > Project...**.

1. In the **New Project** dialog box, enter "Python Web Project" in the search field on the upper right, choose **Web project** in the middle list, give the project a name like "HelloPython", then choose **OK**.

    ![New project dialog with Python Web Project selected](media/quickstart-python-00-web-project.png)

    If you don't see the Python project templates, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools > Get Tools and Features...** to open the Visual Studio Installer. Choose the **Python development** workload, then choose **Modify**.

    ![Python development workload in the Visual Studio installer](../python/media/installation-python-workload.png)

1. The new project opens in **Solution Explorer** in the right pane. The project is empty at this point because it contains no other files.

    ![Solution explorer showing the newly created empty project](media/quickstart-python-01-empty-project.png)

**Question: What's the advantage of creating a project in Visual Studio for a Python application?**

Answer: Python applications are typically defined using only folders and files, but this simple structure can become burdensome as applications become larger and perhaps involve auto-generated files, JavaScript for web applications, and so on. A Visual Studio project helps manage this complexity. The project (a `.pyproj` file) identifies all the source and content files associated with your project, contains build information for each file, maintains the information to integrate with source-control systems, and helps you organize your application into logical components.

## Install the Flask library

Web apps in Python almost always use one of the many available Python libraries to handle low-level details like routing web requests and shaping responses. For this purpose, Visual Studio provides a variety of templates for web apps, which are discussed later in this article. 

Here, you use the following steps to install the Flask library into the default "global environment" that Visual Studio uses for this project.

1. Expand the **Python Environments** node in the project to see the default environment for the project.

    ![Solution explorer showing the default environment](media/quickstart-python-02-default-environment.png)

1. Right-click the environment and select **Install Python Package...**. This command opens the **Python Environments** window on the **Packages** tab.

1. Enter "flask" in the search field and select **pip install flask from PyPI**. Accept any prompts for administrator privileges and observe the **Output** window in Visual Studio for progress. (A prompt for elevation happens when the packages folder for the global environment is located within a protected area like `c:\program files`.)

    ![Installing the Flask library](media/quickstart-python-03-install-package.png)

1. Once installed, the library appears in the environment in **Solution Explorer**, which means that you can make use of it in Python code.

    ![Flask library installed](media/quickstart-python-04-package-installed.png)

Note that instead of installing libraries in the global environment, developers typically create a "virtual environment" in which to install libraries for a specific project. This approach, which you can use as an option with other Visual Studio templates, has a number of advantages discussed at the end of this article.

## Add a code file

You're now ready to add a bit of Python code to implement a minimal web app.

1. Right-click the project in **Solution Explorer** and select **Add > New Item...**.

1. In the dialog that appears, select **Empty Python File**, name it `app.py`, and select **Add**. Visual Studio automatically opens the file in an editor window. (In general, the **Add > New Item...** command is a great way to add different kinds of files to a project, as the item templates often provide useful boilerplate code.)

1. Copy the following code and paste it into `app.py`:

    ```python
    from flask import Flask

    # Create an instance of the Flask class that is the WSGI application.
    # The first argument is the name of the application module or package,
    # typically __name__ when using a single module.
    app = Flask(__name__)

    # Make the WSGI interface available at the top level so wfastcgi can get it.
    wsgi_app = app.wsgi_app

    # Flask route decorators map / and /hello to the hello function.
    # To add other resources, create functions that generate the page contents
    # and add decorators to define the appropriate resource locators for them.

    @app.route('/')
    @app.route('/hello')
    def hello():
        # Render the page
        return "Hello Python!"

    if __name__ == '__main__':
        # Run the app server on localhost:4449
        app.run('localhost', 4449)
    ```

1. After pasting this code, Visual Studio may show a squiggle underneath `flask` in the first line. Such indicators appear when Visual Studio is still building the IntelliSense database for the environment after modules are installed.

For more information about Flask, see the [Flask Quickstart](https://flask.pocoo.org/docs/0.12/quickstart/) (flask.pocoo.org).

## Run the application

1. Right-click `app.py` in **Solution Explorer** and select **Set as startup file**. This command identifies the code file to launch in Python when running the app.

    ![Setting the startup file for a project in Solution Explorer](media/quickstart-python-05-set-as-startup-file.png)

1. Right-click the project in **Solution Explorer** and select **Properties**. Then select the **Debug** tab and set the **Port Number** property to `4449`. This step ensures that Visual Studio launches a browser with `localhost:4449` to match the `app.run` arguments in the code.

1. Select **Debug > Start Without Debugging** (Ctrl+F5), which saves changes to files and runs the app.

1. A command window appears with the message "* Running in https://localhost:4449/", and a browser window should open to `localhost:4449` where you see the message, "Hello, Python!" The GET request also appears in the command window with a status of 200.

    If a browser does not open automatically, start the browser of your choice and navigate to `localhost:4449`.

    If you see only the Python interactive shell in the command window, or if that window flashes on the screen briefly, ensure that you set `app.py` as the startup file in step 1 above.

1. Navigate to `localhost:4449/hello` to test that the decorator for the `/hello` resource also works. Again, the GET request appears in the command window with a status of 200. Feel free to try some other URL as well to see that they show 404 status codes in the command window.

1. Close the command window to stop the app, then close the browser window.

## Using Visual Studio templates

Congratulations on running your first Python app from Visual Studio, in which you've learned a little about using the Visual Studio IDE with Python!

Because the steps you followed in this Quickstart are fairly generic, you've probably guessed that they could be automated. Such automation is the role of Visual Studio project *templates*. For example, the web app you just created is very similar to the one produced by the "Blank Flask Web Project" template as demonstrated in the following steps.

1. From the top menu bar, choose **File > New > Project...**, then in the **New Project** dialog search for "blank flask", select the "Blank Flask Web Project" template in the middle list, give the project a name, and select **OK**:

    ![Creating a new project with the Blank Flask Web Project template](media/quickstart-python-06-blank-flask-template.png)

1. Visual Studio prompts you with a dialog that says "This project requires external packages." This dialog appears because the template includes a `requirements.txt` file specifying a dependency on Flask. Visual Studio can then install the dependencies automatically. Visual Studio also gives you the option to install the package into a *virtual environment*, which is recommended over installing into a global environment as explained in the next section. Select **Install into a virtual environment** to continue.

    ![Installing Flask into a virtual environment](media/quickstart-python-07-install-into-virtual-environment.png)

1. Visual Studio displays a **Add Virtual Environment** dialog. Accept the default and select **Create**, then consent to any elevation requests.

1. After Visual Studio creates that environment, look in **Solution Explorer** to see that you have an `app.py` file along with `requirements.txt`. Open `app.py` to see that the template has provided code very similar to what you used earlier. A very helpful part of that code is that it allows you to set the host and port using environment variables rather than hard-coding them. Such code works in both development and production environments simply by changing those variables:

    ```python
    if __name__ == '__main__':
        import os
        HOST = os.environ.get('SERVER_HOST', 'localhost')
        try:
            PORT = int(os.environ.get('SERVER_PORT', '5555'))
        except ValueError:
            PORT = 5555
        app.run(HOST, PORT)
    ```

1. Select **Debug > Start Without Debugging** to run the app and open a browser to `localhost:5555`.

With the Python workload installed, Visual Studio provides a variety of templates including ones for the [Flask, Bottle, and Django web frameworks](../python/python-web-application-project-templates.md), Azure cloud services, different machine learning scenarios, and even a template to create a project from an existing folder structure containing a Python app. Using these templates can save you significant time when starting a project and are also a great way to learn about different app types.

### The benefits of virtual environments

When you begin a project, it's highly recommended to create a *virtual environment* right away, as most Visual Studio templates invite you to do. A virtual environment is a folder within a Python project that contains exactly those libraries on which a project depends. As you develop your app over time, the virtual environment always reflects those dependencies. (A shared global environment, on the other hand, contain any number of libraries whether you use them in your project or not.)

When using a virtual environment in Visual Studio, you can easily generate a `requirements.txt` file that describes the exact list of your app's dependencies:

1. In **Solution Explorer**, expand the **Python Environments** node.
1. Right-click the virtual environment and select **Generate requirements.txt**.
1. If you already have a `requirements.txt` file in the project, Visual Studio asks whether to replace the entire file, refresh existing entries, or update and add entries. Choose whichever option is suitable.

The `requirements.txt` file eliminates the need to add any libraries to source control or to copy libraries when deploying to a web server. Instead, other developers who clone your project from source control can simply restore libraries from the list in `requirements.txt`. Visual Studio, for example, automatically detects a `requirements.txt` file when you open a project, and prompts you about how to install those dependencies. You can also use `requirements.txt` to install dependencies on a web server, such as Azure App Service (see [Managing Python on Azure App Service](../python/managing-python-on-azure-app-service.md).

Visual Studio can also build its IntelliSense database for a virtual environment much more quickly than it can for a global environment, because the latter typically contains many more packages.

For more information, see [Using virtual environments](../python/selecting-a-python-environment-for-a-project.md#using-virtual-environments)

## Next steps

To continue with a fuller tutorial on Python in Visual Studio, including using the interactive window, debugging, data visualization, and working with Git, select the button below.

> [!div class="nextstepaction"]
> [Tutorial: Getting Started with Python in Visual Studio](../python/tutorial-working-with-python-in-visual-studio-step-01-create-project.md).

To explore more that Visual Studio has to offer, select the links below.

- Learn about [Python web app templates in Visual Studio](../python/python-web-application-project-templates.md).
- Learn about [Python debugging](../python/debugging-python-in-visual-studio.md)
- Learn more about the [Visual Studio IDE](../ide/visual-studio-ide.md) in general.
