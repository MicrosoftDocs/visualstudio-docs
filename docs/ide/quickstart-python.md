---
title: Create a Python Web App with Visual Studio
titleSuffix: ""
description: Learn how to use Visual Studio and the Flask framework to build a web application in Python, add a code file, and run the app.
ms.date: 07/29/2025
ms.subservice: python
ms.topic: quickstart
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.custom: vs-acquisition

#customer intent: As a developer, I want to create a Python web app in Visual Studio so that I can write and debug code, and run my app.
---

# Quickstart: Create a Python web app with Visual Studio

In this quickstart, you create a Python web application based on the Flask framework in Visual Studio. You create the project through discrete steps that help you learn about Visual Studio's basic features. Explore how to create project items, add code, and run applications.

::: moniker range="vs-2019"

If you need to install Visual Studio, go to [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) to install it for free. In the installer, select the **Python development** workload.

::: moniker-end
::: moniker range=">=vs-2022"

If you need to install Visual Studio, go to [Visual Studio downloads](https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta) to install it for free. In the Visual Studio Installer, select the **Python development** workload. In the installation details pane, select **Python web support**.

:::image type="content" source="media/vs-2022/python-web.png" alt-text="Screenshot of the Visual Studio Installer with the Python development workload and Python web support selected." lightbox="media/vs-2022/python-web.png":::

::: moniker-end

## Create the project

The following steps create an empty project that serves as a container for the application.

1. Open Visual Studio. On the start screen, select **Create a new project**.

1. In the **Create a new project** dialog, enter *Python web* in the search box. In the results list, select **Web Project**, and then select **Next**.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-00-web-project-2019a.png" alt-text="Screenshot that shows how to create a new Python Web Project in Visual Studio 2019." lightbox="media/quickstart-python-00-web-project-2019a.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/python-web-project.png" alt-text="Screenshot that shows how to create a new Python Web Project in Visual Studio." lightbox="media/vs-2022/python-web-project.png":::

   ::: moniker-end

   ::: moniker range="vs-2019"

   If you don't see the Python project templates, run the **Visual Studio Installer**. In the Installer, select **More** > **Modify**, select the **Python development** workload, and then choose **Modify**.

   :::image type="content" source="../python/media/installation-python-workload.png" alt-text="Screenshot that shows how to select the Python development workload in the Visual Studio Installer." lightbox="../python/media/installation-python-workload.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

    If you don't see the Python web project templates, select **Tools** > **Get Tools and Features** to run the Visual Studio Installer. In the installer, select the **Python development** workload. Under **Installation details**, select **Python web support**, and then select **Modify**.

   ::: moniker-end

1. In the **Configure your new project** dialog, enter *HelloPython* for the **Project name**, specify a project **Location**, and select **Create**.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-00-web-project-2019b.png" alt-text="Screenshot that shows how to configure settings for the new Python Web Project in Visual Studio 2019." lightbox="media/quickstart-python-00-web-project-2019b.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/configure-project.png" alt-text="Screenshot that shows how to configure settings for the new Python Web Project in Visual Studio." lightbox="media/vs-2022/configure-project.png":::

   ::: moniker-end

   The new project opens in **Solution Explorer**. The **Solution name** is automatically set to match the **Project name**. The new project is empty because it doesn't contain any files.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-01-empty-project-2019.png" alt-text="Screenshot that shows the newly created empty Python Web Project in the Solution Explorer." lightbox="media/quickstart-python-01-empty-project-2019.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/solution-explorer.png" alt-text="Screenshot showing the newly created empty Python Web Project in the Solution Explorer." lightbox="media/vs-2022/solution-explorer.png":::

   ::: moniker-end

### Projects and solutions in Visual Studio

There are advantages to creating a project in Visual Studio for a Python application. Python applications are typically defined by using only folders and files, but this simple structure can become burdensome as applications grow larger. Applications can involve autogenerated files, JavaScript for web applications, and other components. A Visual Studio project helps manage this complexity.

The project is identified with a *.pyproj* file, which identifies all the source and content files associated with your project. The *.pyproj* file contains build information for each file, maintains information to integrate with source-control systems, and helps organize your application into logical components.

A Visual Studio solution is a container that helps you manage one or more related projects as a group. Visual Studio shows your solutions in **Solution Explorer**. The solution stores configuration settings that aren't specific to a project. Projects in a solution can also reference one another. For example, running a Python app project can automatically build a second project, like a C++ extension that the Python app uses.

## Install the Flask library

Web apps in Python almost always use one of the many available Python libraries to handle low-level details like routing web requests and shaping responses. Visual Studio provides many templates for web apps. You create a project from one of these templates later in this Quickstart.

Use the following steps to install the Flask library into the default *global environment* that Visual Studio uses for this project.

1. Expand the **Python Environments** node in the project to see the default environment for the project.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-02-default-environment-2019.png" alt-text="Screenshot of Solution Explorer showing the default environment in Visual Studio 2019." lightbox="media/quickstart-python-02-default-environment-2019.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/python-environment.png" alt-text="Screenshot that shows the default environment in Solution Explorer in Visual Studio." lightbox="media/vs-2022/python-environment.png":::

   ::: moniker-end

1. Right-click the environment and select **Manage Python Packages**. This command opens the **Python Environments** window on the **Packages (PyPI)** tab.

1. Enter *flask* in the search field.

   - If the **Flask** command appears below the search box, then Flask is already present on the system. Continue to the next step.

   - If the **Flask** command doesn't appear below the search box, select **Run command: pip install flask**.

      ::: moniker range="vs-2019"

      :::image type="content" source="media/quickstart-python-03-install-package-2019.png" alt-text="Screenshot that shows how to install the Flask library by using pip install in Visual Studio 2019." lightbox="media/quickstart-python-03-install-package-2019.png":::

      ::: moniker-end
      ::: moniker range=">=vs-2022"

      :::image type="content" source="media/vs-2022/install-flask.png" alt-text="Screenshot that shows how to install the Flask library by using pip install in Visual Studio." lightbox="media/vs-2022/install-flask.png":::

      ::: moniker-end

      An elevation prompt appears if the global environment packages folder is in a protected area like *C:\Program Files*. Accept any prompts for administrator privileges. You can observe the Visual Studio **Output** window for progress.

1. After you install Flask, the library appears in the environment in **Solution Explorer**. You can now use Flask commands in your Python code.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-04-package-installed-2019.png" alt-text="Screenshot that shows the Flask library installed and present in Solution Explorer in Visual Studio 2019." lightbox="media/quickstart-python-04-package-installed-2019.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/flask-installed.png" alt-text="Screenshot that shows the Flask library installed and present in Solution Explorer in Visual Studio." lightbox="media/vs-2022/flask-installed.png":::

   ::: moniker-end

> [!NOTE]
> Instead of installing libraries in the global environment, developers typically create a *virtual environment* in which to install libraries for a specific project. Visual Studio templates typically offer this option, as described in [Quickstart - Create a Python project using a template](../python/quickstart-02-python-in-visual-studio-project-from-template.md).

For more information about other available Python packages, see the [Python Package Index](https://pypi.org/).

## Add a code file

You're now ready to add some Python code to implement a minimal web application.

1. Right-click the project in **Solution Explorer** and select **Add** > **New Item**.

1. In the **Add New Item** dialog, select the **Empty** Python file option.

1. Enter the file name *app.py*, and select **Add**. Visual Studio automatically opens the file in an editor window.

1. Copy the following code and paste it into the *app.py* file:

   ```python
   from flask import Flask

   # Create an instance of the Flask class that is the WSGI application.
   # The first argument is the name of the application module or package,
   # typically __name__ when using a single module.
   app = Flask(__name__)

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

The **Add New Item** dialog displays many other types of files that you can add to a Python project, such as a Python class, a Python package, a Python unit test, or *web.config* files. In general, these *item templates* are a great way to quickly create files with useful boilerplate code.

For more information about Flask, see the [Flask Quickstart](https://flask.palletsprojects.com/quickstart/#quickstart).

## Run the application

Follow these steps to run your web application:

1. In **Solution Explorer**, right-click the *app.py* file and select **Set as Startup File**. This command identifies the code file to launch in Python when running the app.

   ::: moniker range="vs-2019"

   :::image type="content" source="media/quickstart-python-05-set-as-startup-file-2019.png" alt-text="Screenshot that shows how to set the startup file for a project in Solution Explorer in Visual Studio 2019." lightbox="media/quickstart-python-05-set-as-startup-file-2019.png":::

   ::: moniker-end
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/set-startup-file.png" alt-text="Screenshot that shows how to set the startup file for a project in Solution Explorer in Visual Studio." lightbox="media/vs-2022/set-startup-file.png":::

   ::: moniker-end

1. Right-click the project in **Solution Explorer** and select **Properties**.

1. In the **Properties** dialog, on the **Debug** tab, set the **Port Number** property to `4449`. This setting ensures that Visual Studio launches a browser with `localhost:4449` to match the `app.run` arguments in the code.

1. In Visual Studio, select **Debug** > **Start Without Debugging** or select **Ctrl**+**F5**, which saves changes to your files and runs the app.

   A command window opens and displays the message **"Running in https:\//localhost:4449"**. A browser window opens to `localhost:4449` and displays the message **"Hello, Python!"**. The `GET` request also appears in the command window with a status of **"200"**.

   If a browser doesn't open automatically, open the browser of your choice and go to `localhost:4449`.

   If you see only the Python interactive shell in the command window, or if that window flashes on the screen briefly, make sure the *app.py* file is set as the startup file.

1. In the browser window, go to `localhost:4449/hello` to test that the decorator for the `/hello` resource also works.

   Again, the `GET` request appears in the command window with a status of **"200"**.

   Try some other URLs as well to see that they show **"404"** status codes in the command window.

1. Close the command window to stop the app, and then close the browser window.

## Start with or without debugging

You can run your app with or without debugging enabled. Here are the differences between these options:

- The **Start Debugging** command runs the app in the context of the [Visual Studio debugger](../python/debugging-python-in-visual-studio.md). With the debugger, you can set breakpoints, examine variables, and step through your code line by line. Apps might run slower in the debugger because of the hooks that make debugging possible.

- Use the **Start Without Debugging** command to run the app directly with no debugging context, similar to running the app from the command line. This command also automatically launches a browser and opens the URL specified in the project **Properties** > **Debug** tab.

## Related content
 
- [Quickstart: Create a Python project from a template](../python/quickstart-02-python-in-visual-studio-project-from-template.md)
- [Tutorial: Work with Python in Visual Studio](../python/tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
- [Python web application project templates](../python/python-web-application-project-templates.md)
