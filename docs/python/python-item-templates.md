---
title: Item templates for Python projects
description: A reference list of item templates for Python project that are available through the Add > New Item dialog in Visual Studio.
ms.date: 04/25/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: tutorial
author: kraigb
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Python item templates

The item templates are available in Python projects through the **Project** > **Add New Item** menu command, or the **Add** > **New Item** command on the context menu in **Solution Explorer**.

![Add New Item dialog box](media/project-item-templates.png)

Using the name you provide for the item, a template typically creates one or more files and folders within the currently selected folder in the project (right-clicking a folder to bring up the context menu automatically selects that folder). Adding an item includes it in the Visual Studio project, and the item appears in **Solution Explorer**.

The following table briefly explains the effect of each item template within a Python project:

| Template | What the template creates |
| --- | --- |
| Empty Python File | An empty file with the `.py` extension. |
| Python class | A `.py` file containing a single empty Python class definition. |
| Python Package | A folder that contains an `__init.py__` file. |
| Python Unit Test | A `.py` file with a single unit test based on the `unittest` framework, along with a call to `unittest.main()` to run the tests in the file. |
| HTML Page | An `.html` file with a simple page structure consisting of a `<head>` and `<body>` element. |
| JavaScript | An empty  `.js` file. |
| Style Sheet | A `.css` file containing an empty style for `body` |
| Text file | An empty `.txt` file. |
| Django 1.9 App<br/>Django 1.4 App | A folder with the name of the app, which contains the core files for a Django app as explained in [Learning Django in Visual Studio, Step 2-2](learn-django-in-visual-studio-step-02-create-an-app.md#step-2-1-create-an-app-with-a-default-structure) for Django 1.9. For Django 1.4, the `migrations` folder, the `admin.py` file, and the `apps.py` file are not included. |
| IronPython WPF Window | A WPF Window consisting of two side-by-side files: a `.xaml` file that defines a `<Window>` with an empty `<Grid>` element, and an associated `.py` file that loads the XAML file using the `wpf` library. Typically used within a project created using one of the IronPython project templates. See [Managing Python projects - project templates](managing-python-projects-in-visual-studio.md#project-templates). |
| Web Role Support Files | A `bin` folder in the project root (regardless of the selected folder in the project). The folder contains a default deployment script and a `web.config` file for Azure Cloud Service web roles. The template also includes a `readme.html` file that explains the details. |
| Worker Role Support Files | A `bin` folder in the project root (regardless of the selected folder in the project). The folder contains default deployment and launch script, along with a `web.config` file, for Azure Cloud Service worker roles. The template also includes a `readme.html` file that explains the details. |
| Azure web.config (FastCGI) | A `web.config` file that contains entries for apps using a [WSGI](https://wsgi.readthedocs.io/en/latest/) object to handle incoming connections. This file is typically deployed to the root of a web server running IIS, such as Azure App Service. For more information, see [Publishing to Azure App Service](publishing-python-web-applications-to-azure-from-visual-studio.md). |
| Azure web.config (HttpPlatformHandler) | A `web.config` file that contains entries for apps that listen on a socket for incoming connections. This file is typically deployed to the root of a web server running IIS, such as Azure App Service. For more information, see [Publishing to Azure App Service](publishing-python-web-applications-to-azure-from-visual-studio.md). |
| Azure static files web.config | A `web.config` file typically added to a `static` folder (or other folder containing static items) to disable Python handling for that folder. This config file works in conjunction with one of the FastCGI or HttpPlatformHandler config files above. For more information, see [Publishing to Azure App Service](publishing-python-web-applications-to-azure-from-visual-studio.md). |
| Azure Remote debugging web.config | A `web.config.debug` file that enables remote debugging over WebSockets, alongside `Microsoft.PythonTools.WebRole.dll` and a `ptvsd` folder containing the modules to deploy to the server to enable remote debugging. You typically create this item in the same place as your `web.config` file. For more information, see [Remotely debugging Python code on Azure](debugging-remote-python-code-on-azure.md). Also see the note below. |

> [!Note]
> If you add the debugging `web.config` template to a project and plan to use Python remote debugging, you need to publish the site in "Debug" configuration. This setting is separate from the current active solution configuration and always defaults to "Release." To change it, open the **Settings** tab and use the **Configuration** combo box in the publish wizard. (See the [Azure documentation](https://azure.microsoft.com/develop/python/) for more information on creating and deploying to Azure Web Apps.)
>
> ![Changing the publish configuration](media/template-web-publish-config.png)

## See also

- [Managing Python projects - project templates](managing-python-projects-in-visual-studio.md#project-templates)
- [Python web project templates](python-web-application-project-templates.md)
- [Publishing to Azure app service](publishing-python-web-applications-to-azure-from-visual-studio.md)