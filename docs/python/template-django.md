---
title: "Django Web Project Template in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c479be58-13eb-4d77-9a27-c97ddc290963
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Django Web Project Template

[Django](https://www.djangoproject.com/) is a high-level Python framework designed for rapid, secure, and scalable web development. Python Tools for Visual Studio (PTVS) provides a project template to set up the structure of a Django-based web application. To use the template in Visual Studio, select **File > New > Project**, search for "Django", and select the "Django Web Project" template. The resulting project will include boilerplate code as well as a default SQLite database. The "Blank Django Web Project" template is similar but does not include the database.

PTVS provides full IntelliSense for Django projects:

- Context variables passed into the template:

    ![IntelliSense for context variables](media/template-django-intellisense.png)

- Tagging and filtering for both built-ins and user-defined:

    ![IntelliSense for tags and filters](media/template-django-intellisense-filter.png)

- Syntax coloring for embedded CSS and JavaScript:

    ![CSS IntelliSense](media/template-django-intellisense-css.png)

    ![JavaScript IntelliSense](media/template-django-intellisense-js.png)


PTVS also provides full [debugging support](debugging.md) for Django projects: 

![Breakpoints](media/template-django-debugging.png)

## Django management console

The Django management console is access through various commands on the **Project** menu or by right-clicking the project in Solution Explorer.

- **Open Django Shell...**: opens a shell in your application context which enables you to manipulate your models"

    ![Console](media/template-django-console-shell.png)

- **Django Sync DB**: executes `manage.py syncdb` in an interactive window:

    ![Console](media/template-django-console-sync-db.png)

- **Collect Static**: executes `manage.py collectstatic --noinput` to copy all the static files to the path specified by `STATIC_ROOT` in your `settings.py`. Note that when [publishing to Microsoft Azure](template-web.md#publishing-to-azure-app-service), static files are automatically collected as part of the publish operation.

    ![Console](media/template-django-console-collect-static.png)

- **Validate**: executes `manage.py validate`, which reports any validation errors in the installed models specified by `INSTALLED_APPS` in your `settings.py`:

    ![Console](media/template-django-console-validate.png)