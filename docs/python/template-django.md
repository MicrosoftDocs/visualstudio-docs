---
title: "Django Web Project Template in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "2/14/2017"
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

# Django web project template

Django is <what?>. The Python Tools for Visual Studio (PTVS) provides a project template to set up the structure of a Django-based web application.


Template Editing
----------------

### IntelliSense

The Django template editor understands the context variables passed into the 
template and makes them available as completions.

![IntelliSense](Images/DjangoTemplateIntelliSense.png)

Django tags and filters (builtins and user defined) are also available.

![IntelliSense](Images/DjangoTemplateIntelliSenseFilter.png)

### Embedded CSS IntelliSense

Syntax coloring and IntelliSense is now available for embedded CSS and JavaScript.

![CSS IntelliSense](Images/DjangoTemplateIntelliSenseCSS.png)

![JavaScript IntelliSense](Images/DjangoTemplateIntelliSenseJS.png)


Template Debugging
------------------

[Standard debugging features](Debugging) such as Breakpoints, Stepping and Inspecting values are available for Django templates.

![Breakpoints](Images/DjangoTemplateDebugging.png)


Django Management Console
-------------------------

The following commands are available under the "Project" menu or the "Python" context menu that appears when you right-click your project in Solution Explorer.

### Django Shell

The "Open Django Shell" command opens a shell in your application context which enables you to manipulate your models.

![Console](Images/DjangoConsoleShell.png)

### Sync DB

The "Django Sync DB" command executes `manage.py syncdb` in an interactive window.

![Console](Images/DjangoConsoleSyncDB.png)

### Collect Static

The "Collect Static Files" command executes `manage.py collectstatic --noinput`.

This copies all the static files to the path specified by `STATIC_ROOT` in your `settings.py`.

![Console](Images/DjangoConsoleCollectStatic.png)

### Validate

The "Validate Django App" command executes `manage.py validate`.

This will report any validation errors in the installed models specified by `INSTALLED_APPS` in your `settings.py`.

![Console](Images/DjangoConsoleValidate.png)


Microsoft Azure
---------------

### Publishing

When [publishing to Microsoft Azure](Web-Project#publishing-to-microsoft-azure), static files are automatically collected as part of the publish operation.


### Tutorials

See the following tutorials for examples of using PTVS to create Django applications for Microsoft Azure.

 * [Django and SQL Database on Azure](Django-and-SQL-Database-on-Azure)
 * [Django and MySQL on Azure](Django-and-MySQL-on-Azure)
