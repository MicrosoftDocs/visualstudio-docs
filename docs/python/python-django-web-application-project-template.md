---
title: Django Web Project templates for Python
description: Explore comprehensive Django web project templates in Visual Studio for rapid creation of Django web applications with Python.
ms.date: 04/18/2024
ms.topic: concept-article
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use Django web project templates in Visual Studio so I can quickly create Django web applications with Python.
---

# Django Web Project templates for Python in Visual Studio

[Django](https://www.djangoproject.com/) is a high-level Python framework designed for rapid, secure, and scalable web development. Python support in Visual Studio provides several project templates to set up the structure of a Django-based web application.

The templates are available in Visual Studio under **File** > **New** > **Project** and include the **Blank Django Web Project** and **Django Web Project**. For a walkthrough of the templates, see the [Work with the Django web framework in Visual Studio](learn-django-in-visual-studio-step-01-project-and-solution.md) tutorial series.

## Intellisense features

Visual Studio provides full IntelliSense support for Django projects, including the following features:

- Context variables passed into the template:

   :::image type="content" source="media/template-django-intellisense.png" alt-text="Screenshot that shows IntelliSense support for context variables used in Django development in Visual Studio." border="false" lightbox="media/template-django-intellisense.png":::

- Tagging and filtering for both built-ins and user-defined items:

   :::image type="content" source="media/template-django-intellisense-filter.png" alt-text="Screenshot that shows IntelliSense support of tags and filters used in Django development in Visual Studio." border="false" lightbox="media/template-django-intellisense-filter.png":::

- Syntax coloring for embedded CSS and JavaScript elements:

   :::image type="content" source="media/template-django-intellisense-css.png" alt-text="Screenshot that shows IntelliSense support for CSS used in Django development in Visual Studio." border="false" lightbox="media/template-django-intellisense-css.png":::

   :::image type="content" source="media/template-django-intellisense-js.png" alt-text="Screenshot that shows IntelliSense support for JavaScript used in Django development in Visual Studio." border="false" lightbox="media/template-django-intellisense-js.png":::

## Debugging support

Visual Studio also provides full [debugging support](debugging-python-in-visual-studio.md) for Django projects:

:::image type="content" source="media/template-django-debugging.png" alt-text="Screenshot that shows Debugger breakpoints used in Django development in Visual Studio." border="false" lightbox="media/template-django-debugging.png":::

## Django management console

The Django management console is accessed through various commands on the Django **Project** menu or by right-clicking the Django project in **Solution Explorer**.

- **Open Django Shell**: Opens a shell in your application context that enables you to manipulate your models:

   :::image type="content" source="media/template-django-console-shell.png" alt-text="Screenshot that shows the results of the Open Django Shell command in Visual Studio." border="false" lightbox="media/template-django-console-shell.png":::

- **Django Sync DB**: Runs the `manage.py syncdb` command in an **Interactive Window**:

   :::image type="content" source="media/template-django-console-sync-db.png" alt-text="Screenshot that shows the result of the Django Sync DB command in Visual Studio." border="false" lightbox="media/template-django-console-sync-db.png":::

- **Collect Static**: Runs the `manage.py collectstatic --noinput` command to copy all static files to the path specified by the `STATIC_ROOT` variable in your _settings.py file:

   :::image type="content" source="media/template-django-console-collect-static.png" alt-text="Screenshot that shows the result of the Collect Static command in Visual Studio." border="false" lightbox="media/template-django-console-collect-static.png":::

- **Validate**: Runs the `manage.py validate` command that reports any validation errors in the installed models specified by the `INSTALLED_APPS` variable in your _settings.py_ file:

   :::image type="content" source="media/template-django-console-validate.png" alt-text="Screenshot that shows the result of the Validate command in Visual Studio." border="false" lightbox="media/template-django-console-validate.png":::

> [!IMPORTANT]
> Django projects are typically managed through a _manage.py_ file and Visual Studio follows this approach. If you stop using the _manage.py_ file as the entry point, you essentially break the project file. In this case, you need to [recreate the project from existing files](managing-python-projects-in-visual-studio.md#create-a-project-from-existing-files) without marking it as a Django project.

## Related content

- [Tutorial: Work with the Django web framework in Visual Studio](learn-django-in-visual-studio-step-01-project-and-solution.md)
- [Tutorial: Use the full Django Web Project template](learn-django-in-visual-studio-step-04-full-django-project-template.md)
