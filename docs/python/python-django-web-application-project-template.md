---
title: Django web project template for Python
description: An overview of the Visual Studio templates for web applications written in Python using the Django framework.
ms.date: 04/17/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: conceptual
author: kraigb
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Django web project template

[Django](https://www.djangoproject.com/) is a high-level Python framework designed for rapid, secure, and scalable web development. Python support in Visual Studio provides several project templates to set up the structure of a Django-based web application. To use a template in Visual Studio, select **File** > **New** > **Project**, search for "Django", and select from the "Blank Django Web Project," "Django Web Project", and "Polls Django Web Project" templates. See the [Learning Django tutorial](learn-django-in-visual-studio-step-01-project-and-solution.md) for a walkthrough of all the templates.

Visual Studio provides full IntelliSense for Django projects:

- Context variables passed into the template:

    ![IntelliSense for context variables](media/template-django-intellisense.png)

- Tagging and filtering for both built-ins and user-defined:

    ![IntelliSense for tags and filters](media/template-django-intellisense-filter.png)

- Syntax coloring for embedded CSS and JavaScript:

    ![CSS IntelliSense](media/template-django-intellisense-css.png)

    ![JavaScript IntelliSense](media/template-django-intellisense-js.png)

Visual Studio also provides full [debugging support](debugging-python-in-visual-studio.md) for Django projects: 

![Breakpoints](media/template-django-debugging.png)

It's typical for Django projects to be managed through their `manage.py` file, which is an assumption that Visual Studio follows. If you stop using that file as the entry point, you essentially break the project file. In that case you need to [recreate the project from existing files](managing-python-projects-in-visual-studio.md#creating-a-project-from-existing-files) without marking it as a Django project.

## Django management console

The Django management console is accessed through various commands on the **Project** menu or by right-clicking the project in Solution Explorer.

- **Open Django Shell...**: opens a shell in your application context that enables you to manipulate your models"

    ![Console](media/template-django-console-shell.png)

- **Django Sync DB**: executes `manage.py syncdb` in an interactive window:

    ![Console](media/template-django-console-sync-db.png)

- **Collect Static**: executes `manage.py collectstatic --noinput` to copy all the static files to the path specified by `STATIC_ROOT` in your `settings.py`. When [publishing to Azure App Service](publishing-python-web-applications-to-azure-from-visual-studio.md), static files are automatically collected as part of the publish operation.

    ![Console](media/template-django-console-collect-static.png)

- **Validate**: executes `manage.py validate`, which reports any validation errors in the installed models specified by `INSTALLED_APPS` in your `settings.py`:

    ![Console](media/template-django-console-validate.png)

## See also

- [Learning Django tutorial](learn-django-in-visual-studio-step-01-project-and-solution.md)