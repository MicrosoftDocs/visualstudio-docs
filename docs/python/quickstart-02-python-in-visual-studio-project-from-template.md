---
title: Quickstart - Create a Python project using a template
description: In this quickstart, you create a Visual Studio project for Python using the built-in template for a basic Flask app.
ms.date: 05/12/2022
ms.topic: quickstart
author: rjmolyneaux
ms.author: rmolyneaux
manager: jmartens
ms.technology: vs-python
ms.custom: devdivchpfy22
ms.workload:
  - python
  - data-science
---
# Quickstart: Create a Python project from a template in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Once you've [installed Python support in Visual Studio](installing-python-support-in-visual-studio.md), it's easy to create a new Python project using a variety of templates. In this Quickstart, you create a simple Flask app using a template. The resulting project is similar to the project you create manually through [Quickstart - Create a web app with Flask](../ide/quickstart-python.md).

::: moniker range="<=vs-2019"

1. Start Visual Studio.
1. From the top menu bar, choose **File** > **New** > **Project**, then in the **New Project** dialog search for "blank flask", select the **Blank Flask Web Project** template in the middle list, give the project a name, and select **OK**:

    :::image type="content" source="media/quickstart-python-06-blank-flask-template.png" alt-text="Screenshot of creating a new project with the Blank Flask Web Project template.":::

1. Visual Studio prompts you with a dialog that says **This project requires external packages.** This dialog appears because the template includes a *requirements.txt* file specifying a dependency on Flask. Visual Studio can install the packages automatically, and gives you the option to install them into a *virtual environment*. Using a virtual environment is recommended over installing into a global environment, so select **Install into a virtual environment** to continue.

    :::image type="content" source="media/quickstart-python-07-install-into-virtual-environment.png" alt-text="Screenshot of installing Flask into a virtual environment.":::

1. Visual Studio displays the **Add Virtual Environment** dialog. Accept the default and select **Create**, then consent to any elevation requests.

     > [!Tip]
     > When you begin a project, it's highly recommended to create a virtual environment right away, as most Visual Studio templates invite you to do. Virtual environments maintain your project's exact requirements over time as you add and remove libraries. You can then easily generate a *requirements.txt* file, which you use to reinstall those dependencies on other development computers (as when using source control) and when deploying the project to a production server. For more information on virtual environments and their benefits, see [Use virtual environments](../python/selecting-a-python-environment-for-a-project.md#use-virtual-environments) and [Manage required packages with requirements.txt](../python/managing-required-packages-with-requirements-txt.md).

1. After Visual Studio creates that environment, look in **Solution Explorer** to see that you have an *app.py* file along with *requirements.txt*. Open *app.py* to see that the template has provided code like that in [Quickstart - Create a web app with Flask](../ide/quickstart-python.md), with a few added sections. All of the code shown here's created by the template, so you don't need to paste any into *app.py* yourself.

    The code begins with the necessary imports:

    ```python
        from flask import Flask
        app = Flask(__name__)
    ```

    Next is the following line that can be helpful when deploying an app to a web host:

    ```python
        wsgi_app = app.wsgi_app
    ```

    Then comes route decorator on a simple function that defines a view:

    ```python
        @app.route('/')
        def hello():
        """Renders a sample page."""
        return "Hello World!"
    ```

    Finally, the following startup code allows you to set the host and port through environment variables rather than hard-coding them. Such code allows you to easily control the configuration on both development and production machines without changing the code:

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

1. Select **Debug** > **Start without Debugging** to run the app and open a browser to `localhost:5555`.
::: moniker-end

::: moniker range=">=vs-2022"

1. Start Visual Studio and from the top menu bar, choose **File** > **New** > **Project**. Then in the **New Project** dialog search for "blank flask", select the **Blank Flask Web Project** template from the list and select **Next**.  

     :::image type="content" source="media/vs-2022/quickstart-python-06-blank-flask-template.png" alt-text="Screenshot of creating a new project with the Blank Flask Web Project template.":::

1. Visual Studio displays the project configuration dialog, give the project a name and select **Create**.

     :::image type="content" source="media/vs-2022/quickstart-python-065-blank-flask-project-config.png" alt-text="Screenshot of configure the new project fields with a name and desired location.":::

1. Visual Studio prompts you with a dialog that says **This project requires external packages.** This dialog appears because the template includes a *requirements.txt* file specifying a dependency on Flask. Visual Studio can install the packages automatically, and gives you the option to install them into a *virtual environment*. Using a virtual environment is recommended over installing into a global environment, so select **Install into a virtual environment** to continue.

1. Visual Studio displays the **Add Virtual Environment** dialog. Accept the default and select **Create**, then consent to any elevation requests.

     :::image type="content" source="media/vs-2022/quickstart-python-07-install-into-virtual-environment.png" alt-text="Screenshot of installing Flask into a virtual environment.":::

     > [!Tip]
     > When you begin a project, it's highly recommended to create a virtual environment right away, as most Visual Studio templates invite you to do. Virtual environments maintain your project's exact requirements over time as you add and remove libraries. You can then easily generate a *requirements.txt* file, which you use to reinstall those dependencies on other development computers (as when using source control) and when deploying the project to a production server. For more information on virtual environments and their benefits, see [Use virtual environments](../python/selecting-a-python-environment-for-a-project.md#use-virtual-environments) and [Manage required packages with requirements.txt](../python/managing-required-packages-with-requirements-txt.md).

1. After Visual Studio creates that environment, look in **Solution Explorer** to see that you have an *app.py* file along with *requirements.txt*. Open *app.py* to see that the template has provided code like that in [Quickstart - Create a web app with Flask](../ide/quickstart-python.md), with a few added sections. All of the code shown here is created by the template, so you don't need to paste any into *app.py* yourself.

    The code begins with the necessary imports:

    ```python
    from flask import Flask
    app = Flask(__name__)
    ```

    Next is the following line that can be helpful when deploying an app to a web host:

    ```python
        wsgi_app = app.wsgi_app
    ```

    Then comes route decorator on a simple function that defines a view:

    ```python
        @app.route('/')
        def hello():
        """Renders a sample page."""
        return "Hello World!"
    ```

    The startup code below allows you to set the host and port through environment variables rather than hard-coding them. Such code allows you to easily control the configuration on both development and production machines without changing the code:

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

1. Select **Debug** > **Start without Debugging** to run the app and open a browser to `localhost:5555`.
::: moniker-end

**Question: What other Python templates does Visual Studio offer?**

**Answer**: With the Python workload installed, Visual Studio provides a variety of project templates including ones for the [Flask, Bottle, and Django web frameworks](../python/python-web-application-project-templates.md), Azure cloud services, different machine learning scenarios, and even a template to create a project from an existing folder structure containing a Python app. You access these templates through the **File** > **New** > **Project** dialog box by selecting the **Python** language node and its child nodes.

Visual Studio also provides a variety of file or *item templates* to quickly create a Python class, a Python package, a Python unit test, *web.config* files, and more. When you have a Python project open, you access item templates through the **Project** > **Add New Item** menu command. See the [item templates](python-item-templates.md) reference.

Using templates can save you significant time when starting a project or creating a file. They're also a great way to learn about different app types and code structures. It's helpful to take a few minutes to create projects and items from the various templates to familiarize yourself with what they offer.

**Question: Can I also use Cookiecutter templates?**

**Answer**: Yes! In fact, Visual Studio provides direct integration with Cookiecutter, which you can learn about through [Quickstart: Create a project from a Cookiecutter template](../python/quickstart-04-python-in-visual-studio-project-from-cookiecutter.md).

## Next steps

> [!div class="nextstepaction"]
> [Tutorial: Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)

## See also

- [Manually identify an existing Python interpreter](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment)
[Install Python support in Visual Studio on Windows](installing-python-support-in-visual-studio.md#how-to-install-python-support-in-visual-studio-on-windows)
- [Python tools install directory](installing-python-support-in-visual-studio.md#install-locations)
