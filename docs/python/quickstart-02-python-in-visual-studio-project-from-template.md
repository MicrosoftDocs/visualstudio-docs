---
title: "Quickstart: Create Python project from template"
description: Follow guided steps to create a Visual Studio project for Python by using the built-in template for a basic Flask application.
ms.date: 04/18/2024
ms.topic: quickstart
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to create new projects by using built-in templates so I can quickly develop Python applications in Visual Studio.
---

# Quickstart: Create Python project from a template in Visual Studio

In this quickstart, you follow guided steps to quickly create a Flask application by using a built-in Python project template. Visual Studio makes it easy to develop Python projects with boilerplate code and functionality in templates for several Python frameworks, including Flask, Django, and Bottle. The Python project described in this article is similar to the project you create manually through the [Quickstart: Create a web app with Flask](../ide/quickstart-python.md) article.

## Prerequisites

- Visual Studio installed with support for Python workloads.

   In the Visual Studio Installer, select the **Python development** workload and the **Python web support** option for access to web project templates. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

   :::image type="content" source="media/quickstart-python-install-web-support.png" alt-text="Screenshot that shows how to select Python web support in the Visual Studio Installer for the Python development workload." lightbox="media/quickstart-python-install-web-support.png" border="false":::

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Create the project

Follow this procedure to create a Visual Studio solution and a new Flask web project:

::: moniker range=">=vs-2022"

1. In Visual Studio, select **File** > **New** > **Project** and search for "Flask." Select the **Blank Flask Web Project** template and select **Next**.

   :::image type="content" source="media/vs-2022/quickstart-python-blank-flask-template.png" alt-text="Screenshot that shows how to select the Blank Flask Web Project template in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-blank-flask-template.png"::: 

1. Visual Studio displays the project configuration dialog. Enter a **Name** for the project and select **Create**. You can leave the other fields set to the defaults.

   :::image type="content" source="media/vs-2022/quickstart-python-configure-blank-flask-project.png" alt-text="Screenshot that shows how to configure a new Blank Flask Web Project in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-configure-blank-flask-project.png":::

1. After a moment, Visual Studio displays a prompt about how to handle package dependencies. The prompt is different based on whether you already have package dependencies installed.

   The dialog **This project requires external packages.** indicates that the selected template includes a _requirements.txt_ file that specifies dependencies on the Flask package. Visual Studio can install the packages automatically, which gives you the option to install the packages into a _virtual environment_. Using a virtual environment is recommended over installing into a global environment.
   
   If you receive this dialog, select the **Install into a virtual environment** option:

   :::image type="content" source="media/quickstart-python-install-packages-prompt.png" alt-text="Screenshot of the prompt to install required package dependencies into a virtual environment in Visual Studio." lightbox="media/quickstart-python-install-packages-prompt.png":::

   Alternatively, you might see the **Python package specification file "requirements.txt" was detected in project \<Project name>".** prompt at the top of the Visual Studio window. This prompt indicates that the package dependencies are already available in your configuration. Visual Studio can create a virtual environment for you from the existing configuration.
   
   If you see this prompt, select the **Create virtual environment** option:

   :::image type="content" source="media/vs-2022/quickstart-python-requirements-prompt.png" alt-text="Screenshot of the prompt that indicates a requirements file for the project is detected in Visual Studio." border="false" lightbox="media/vs-2022/quickstart-python-requirements-prompt.png":::

1. Visual Studio displays the **Add environment** dialog. Accept the default values and select **Create**, then consent to any elevation requests.

   :::image type="content" source="media/vs-2022/quickstart-python-add-virtual-environment.png" alt-text="Screenshot that shows how to add a virtual environment for the Flask project in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-add-virtual-environment.png":::

::: moniker-end
::: moniker range="<=vs-2019"

1. In Visual Studio, select **File** > **New** > **Project**.

1. In the **New Project** dialog, search for "blank flask". Select the **Blank Flask Web Project** template in the middle list, enter a project **Name**, and select **OK**:

   :::image type="content" source="media/quickstart-python-blank-flask-template.png" alt-text="Screenshot that shows how to select the Blank Flask Web Project template to create a new Flask app in Visual Studio." border="false" lightbox="media/quickstart-python-blank-flask-template.png" :::

1. After a moment, Visual Studio displays a prompt:

   The dialog **This project requires external packages.** indicates that the selected template includes a _requirements.txt_ file that specifies dependencies on the Flask package. Visual Studio can install the packages automatically, which gives you the option to install the packages into a _virtual environment_. Using a virtual environment is recommended over installing into a global environment.
   
   If you receive this dialog, select the **Install into a virtual environment** option:

   :::image type="content" source="media/quickstart-python-install-packages-prompt.png" alt-text="Screenshot of the prompt to install required package dependencies into a virtual environment in Visual Studio." lightbox="media/quickstart-python-install-packages-prompt.png":::

   Alternatively, you might see the **Python package specification file "requirements.txt" was detected in project \<Project name>".** prompt at the top of the Visual Studio window. This prompt indicates that the package dependencies are already available in your configuration. Visual Studio can create a virtual environment for you from the existing configuration.
   
   If you see this prompt, select the **Create virtual environment** option:

   :::image type="content" source="media/vs-2022/quickstart-python-requirements-prompt.png" alt-text="Screenshot of the prompt that indicates a requirements file for the project is detected in Visual Studio." border="false" lightbox="media/vs-2022/quickstart-python-requirements-prompt.png":::

1. Visual Studio displays the **Add environment** dialog. Accept the default values and select **Create**, then consent to any elevation requests.

   :::image type="content" source="media/quickstart-python-add-virtual-environment.png" alt-text="Screenshot that shows how to add a virtual environment for the Flask project in Visual Studio." border="false" lightbox="media/quickstart-python-add-virtual-environment.png":::

::: moniker-end

> [!TIP]
> When you begin a project, it's highly recommended to create a virtual environment right away, as most Visual Studio templates invite you to do. Virtual environments maintain your project's exact requirements over time as you add and remove libraries. You can then easily generate a _requirements.txt_ file, which you use to reinstall those dependencies on other development computers (as when using source control) and when deploying the project to a production server. For more information on virtual environments and their benefits, see [Use virtual environments](../python/selecting-a-python-environment-for-a-project.md#use-virtual-environments) and [Manage required packages with requirements.txt](../python/managing-required-packages-with-requirements-txt.md).

## Examine the boilerplate code

In this section, you examine the boilerplate code in the Flask project file (_.py_) that Visual Studio creates for the selected template. 

1. Open **Solution Explorer** to view your solution and Flask project files. The initial project contains only two files, _app.py_ and _requirements.txt_:

   :::image type="content" source="media/flask/vs-2022/step-01-flask-project-solution-explorer.png" alt-text="Screenshot that shows the initial Flask project files in Solution Explorer." border="false" lightbox="media/flask/vs-2022/step-01-flask-project-solution-explorer.png"::: 

   The _requirements.txt_ file specifies the Flask package dependencies. The presence of this file is what invites you to create a virtual environment when first creating the project.

   The single _app.py_ file contains boilerplate code for a blank Flask web project. The template provides code similar to the descriptions in the [Quickstart - Create a web app with Flask](../ide/quickstart-python.md) article, with a few added sections.
   
1. Open the _app.py_ file in the editor and examine the top section.

   The code begins with an `import` statement for the Flask package. This statement creates an instance of the `Flask` class, which is assigned to the variable `app`: 

   ```python
   from flask import Flask
   app = Flask(__name__)
   ```

   Next, the code assigns the `wsgi_app` variable, which is useful when you deploy the Flask app to a web host:

   ```python
   # Make the WSGI interface available at the top level so wfastcgi can get it.
   wsgi_app = app.wsgi_app
   ```

1. The middle section assigns a function to a URL route, which means the function provides the resource identified by the URL. In this case, the route defines a view:

   ```python
   @app.route('/')
   def hello():
       """Renders a sample page."""
       return "Hello World!"
   ```

   You define routes by using Flask's `@app.route` decorator with an argument that's the relative URL from the site root. As you can see in the code, the function returns only a text string, which is enough for a browser to render. 

1. The bottom section contains optional code to start the Flask development server. You can set the host and port through environment variables rather than hard-coding them. Such code allows you to easily control the configuration on both development and production machines without changing the code:

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

1. Select **Debug** > **Start without Debugging** to run the Flask app and open a browser to the default host and port value, `localhost:5555`.

## Explore Python templates in Visual Studio

When you install the Python workload, Visual Studio provides various project templates for the [Flask, Bottle, and Django web frameworks](../python/python-web-application-project-templates.md) and Azure cloud services. There are also templates for different machine learning scenarios and a template to create a project from an existing folder structure that contains a Python application. You can access the templates by using the **File** > **New** > **Project** menu option. Select the **Python** language node and its child nodes to see the available templates.

Visual Studio also provides several file or _item templates_ to quickly create a Python class, a Python package, a Python unit test, _web.config_ files, and more. When you have a Python project open, you access item templates by using the **Project** > **Add New Item** menu option. For more information, see the [item templates](python-item-templates.md) reference.

Using templates can save you significant time when starting a project or creating a file. They're also a great way to learn about different app types and code structures. It's helpful to take a few minutes to create projects and items from the various templates to familiarize yourself with what they offer.

## Use Cookiecutter templates

Visual Studio provides direct integration with [Cookiecutter](https://cookiecutter.readthedocs.io/en/latest/) to help you discover templates, input template options, and create projects and files. For more information, see the [Quickstart: Create a project from a Cookiecutter template](../python/quickstart-04-python-in-visual-studio-project-from-cookiecutter.md) article.

## Related content

- [Tutorial: Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
- [Manually identify an existing Python interpreter](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment)
- [Python tools install directory](installing-python-support-in-visual-studio.md#download-and-install-the-python-workload)
