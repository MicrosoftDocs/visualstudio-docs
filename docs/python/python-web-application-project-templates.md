---
title: Web application templates for Python
description: Work with Python web app templates in Visual Studio for the Bottle, Flask, and Django frameworks, debug configurations, and publish to Azure App Service.
ms.date: 04/18/2024
ms.topic: article
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

#customer intent: As a developer, I want to use Python web app templates in Visual Studio so that I can build with the Bottle, Flask, and Django frameworks and publish to Azure App Service.
---

# Python web application project templates

Python in Visual Studio supports developing web projects in Bottle, Flask, and Django frameworks through project templates and a debug launcher that can be configured to handle various frameworks. These templates include a *requirements.txt* file to declare the necessary dependencies. When you create a project from one of these templates, Visual Studio prompts you to install the dependent packages, as described in [Installation requirements](#installation-requirements) later in this article.

You can also use the generic **Web Project** template for other frameworks such as Pyramid. In this case, no frameworks are installed with the template. Instead, you install the necessary packages into the environment you're using for the project. For more information, see [Python environments window - Package tab](python-environments-window-tab-reference.md#packages-tab).

## Project template options

You create a project from a template by selecting **File** > **New** > **Project** from the toolbar menu. In the **Create a new project** dialog, you can filter the list of templates to see the options available for Python web projects. Enter key terms in the **Search** box, or use the filter dropdown menus to select **Python** as the language and **Web** as the project type.

:::image type="content" source="media/projects-new-project-dialog-web.png" alt-text="Screenshot that shows the Create a new project dialog with the templates filtered to show options for Python web apps in Visual Studio." border="false" lightbox="media/projects-new-project-dialog-web.png" :::

After you select a template, you provide a name for the project and solution, and set options for the solution directory and Git repository.

The generic **Web Project** template provides an empty Visual Studio project with no code and makes no assumptions other than being a Python project. The other templates are based on the Bottle, Flask, or Django web frameworks, and grouped into three categories as described in the following sections. The apps created by any of these templates contain sufficient code to run and debug the app locally. Each template also provides the necessary [WSGI app object](https://www.python.org/dev/peps/pep-3333/) (python.org) for use with production web servers.

### Blank group

All **Blank \<framework> Web Project** templates create a project with more or less minimal boilerplate code and the necessary dependencies declared in a *requirements.txt* file.

| Template | Description |
| --- | --- |
| **Blank Bottle Web Project** | Generates a minimal app in the *app.py* file with a Home page for the `/` location and a `/hello/<name>` page that echoes the `<name>` value by using a short inline page template. |
| **Blank Django Web Project** | Generates a Django project with the core Django site structure but no Django apps. For more information, see [Django templates](python-django-web-application-project-template.md) and [Learn Django Step 1](learn-django-in-visual-studio-step-01-project-and-solution.md). |
| **Blank Flask Web Project** | Generates a minimal app with a single "Hello World!" page for the `/` location. This app is similar to the result of following the detailed steps in [Quickstart: Use Visual Studio to create your first Python web app](../ide/quickstart-python.md?toc=/visualstudio/python/toc.json&bc=/visualstudio/python/_breadcrumb/toc.json). For more information, see [Learn Flask Step 1](learn-flask-visual-studio-step-01-project-solution.md). |

### Web group

All **\<Framework> Web Project** templates create a starter web app with an identical design regardless of the chosen framework. The app has Home, About, and Contact pages, along with a navigation menubar and responsive design that uses Bootstrap. Each app is appropriately configured to serve static files (CSS, JavaScript, and fonts), and uses a page template mechanism appropriate for the framework.

| Template | Description |
| --- | --- |
| **Bottle Web Project** | Generates an app whose static files are contained in the *static* folder and handled through code in the *app.py* file. Routing for the individual pages is contained in the *routes.py* file. The *views* folder contains the page templates. |
| **Django Web Project** | Generates a Django project and a Django app with three pages, authentication support, and a SQLite database (but no data models). For more information, see [Django templates](python-django-web-application-project-template.md) and [Learn Django Step 4](learn-django-in-visual-studio-step-04-full-django-project-template.md). |
| **Flask Web Project** | Generates an app whose static files are contained in the *static* folder. Code in the *views.py* file handles routing with page templates that use the Jinja engine contained in the *templates* folder. The *runserver.py* file provides startup code. | 

## Installation requirements

When you create a project from a framework-specific template, Visual Studio provides a dialog to help you install the necessary packages by using pip. We also recommend using a [virtual environment](selecting-a-python-environment-for-a-project.md#use-virtual-environments) for web projects to ensure the correct dependencies are included when you publish your web site:

:::image type="content" source="media/template-web-requirements-txt-wizard.png" alt-text="Screenshot that shows the dialog to install packages for a project template in Visual Studio." border="false":::

If you use source control, you typically omit the virtual environment folder because that environment can be recreated by using the *requirements.txt* file only. The best way to exclude the folder is to first select the **I will install them myself** option, then disable auto-commit before creating the virtual environment. For more information, see **Examine Git controls** in the [Learn Django Tutorial](learn-django-in-visual-studio-step-01-project-and-solution.md#examine-git-controls) and [Learn Flask Tutorial](learn-flask-visual-studio-step-01-project-solution.md#examine-git-controls).

When you deploy to Microsoft Azure App Service, select a version of Python as a [site extension](/azure/app-service/quickstart-python) and manually install packages. Also, because Azure App Service does **not** automatically install packages from a *requirements.txt* file when deployed from Visual Studio, follow the configuration details on [aka.ms/PythonOnAppService](/azure/app-service/quickstart-python).

## Debugging options

When you open a web project for debugging, Visual Studio starts a local web server on a random port and opens your default browser to that address and port. To specify more options, right-click the project in **Solution Explorer**, select **Properties**. In the **Properties** page, select the **Debug** tab.

:::image type="content" source="media/template-web-launcher-properties.png" alt-text="Screenshot that shows the Web launcher properties for the generic web template in Visual Studio." border="false" lightbox="media/template-web-launcher-properties.png" :::

There are three groups of common configuration options for debugging the project. The **Run** group includes the following properties:

- The **Search Paths**, **Script Arguments**, **Interpreter Path**, and **Interpreter Arguments** options are the same as for [normal debugging](debugging-python-in-visual-studio.md).
- The **Launch URL** specifies the URL that opens in your browser. The default location is `localhost`.
- The **Port Number** identifies the port to use, if none is specified in the URL (Visual Studio selects one automatically by default). This setting allows you to override the default value of the `SERVER_PORT` environment variable, which is used by the templates to configure which port the local debug server listens on.
- The **Environment** list defines variables to set in the spawned process. The format is a newline-separated list of `<NAME>=<VALUE>` pairs.

The properties in the **Run Server Command** and **Debug Server Command** groups determine how the web server is launched. Because many frameworks require the use of a script outside of the current project, the script can be configured here and the name of the startup module can be passed as a parameter.

- The **Command** can be a Python script (*\*.py* file), a module name (as in, `python.exe -m module_name`), or a single line of code (as in, `python.exe -c "code"`). The value in the dropdown box indicates which type is intended.
- The list of **Arguments** are passed on the command line following the command.
- Again, the **Environment** list defines variables to set after all properties that might modify the environment, such as the port number and search paths. These variable values can overwrite other property values.

Any project property or environment variable can be specified with MSBuild syntax, such as `$(StartupFile) --port $(SERVER_PORT)`. `$(StartupFile)` is the relative path to the startup file and `{StartupModule}` is the importable name of the startup file. `$(SERVER_HOST)` and `$(SERVER_PORT)` are normal environment variables that are set by the **Launch URL** and **Port Number** properties, automatically, or by the **Environment** property.

> [!NOTE]
> Values in **Run Server Command** are used with the **Debug** > **Start Server** command or the keyboard shortcut **Ctrl**+**F5**. Values in the **Debug Server Command** group are used with the **Debug** > **Start Debug Server** command or **F5**.

### Sample Bottle configuration

The **Bottle Web Project** template includes boilerplate code that does the necessary configuration. An imported bottle app might not include this code, however, in which case the following settings launch the app by using the installed `bottle` module:

- **Run Server Command** group:
   - **Command**: `bottle` (module)
   - **Arguments**: `--bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

- **Debug Server Command** group:
   - **Command**: `bottle` (module)
   - **Arguments** `--debug --bind=%SERVER_HOST%:%SERVER_PORT% {StartupModule}:app`

The `--reload` option isn't recommended when using Visual Studio for debugging.

### Sample Pyramid configuration

Pyramid apps are currently best created by using the `pcreate` command-line tool. After you create the app, it can be imported by using the [**From existing Python code**](managing-python-projects-in-visual-studio.md#create-a-project-from-existing-files) template. After the import completes, select the **Generic Web Project** customization to configure the options. These settings assume that Pyramid is installed into a virtual environment at the `..\env` location.

- **Run** group:
   - **Port Number**: 6543 (or whatever is configured in the *.ini* files)

- **Run Server Command** group:
   - Command: `..\env\scripts\pserve-script.py` (script)
   - Arguments: `Production.ini`

- **Debug Server Command** group:
   - Command: `..\env\scripts\pserve-script.py` (script)
   - Arguments: `Development.ini`

> [!TIP]
> You likely need to configure the **Working Directory** property of your project because Pyramid apps are typically one folder below the project root.

### Other configurations

If you have settings for another framework that you would like to share, or if you'd like to request settings for another framework, open an [issue on GitHub](https://github.com/Microsoft/PTVS/issues).

## Related content

- [Python item templates reference](python-item-templates.md)
- [Select a Python environment for a project in Visual Studio](selecting-a-python-environment-for-a-project.md)
