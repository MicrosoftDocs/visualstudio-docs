---
title: Getting started with the Django web framework  | Microsoft Docs
description: A walkthrough of Django basics in the context of Visual Studio projects, demonstrating the support Visual Studio provides for Django development.
ms.custom:
ms.date: 03/15/2018
ms.reviewer:
ms.suite:
ms.technology: 
  - "devlang-python"
dev_langs:
  - "python"
ms.tgt_pltfrm:
ms.topic: "article"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Getting Started with Django in Visual Studio

[Django](https://www.djangoproject.com/) is a high-level Python framework designed for rapid, secure, and scalable web development. Python support in Visual Studio provides a basic project template that creates an basic Django-based web server to which you can add Django apps.

In Django terminology, a "Django project" is a configuration along with one or more apps that you would deploy to a web host to create a web site. A Django project can contain multiple apps, and the same app can be in multiple Django projects. However, to avoid confusion with Visual Studio "projects," this article refers to Django projects as a Django server.

To use the template in Visual Studio, select **File > New > Project**, search for "Django", and select the **Blank Django Web Project** template. The resulting project includes the same boilerplate server code that you obtain by using the `django-admin startproject <project_name>` command, along with a `requirements.txt` file specifying the Django package dependency.

This basic server project does not contain any apps by default. You create several apps in the process of following this walkthrough.

## Boilerplate server code

The Django boilerplate server code consists of the following files (as explained in [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) in the Django documentation):

- In your project root is `manage.py`, the Django command-line administrative utility. You run the utility by typing `manage.py <command> [options]` at a command prompt. You can also use `django-admin <command> [options]` or `ptyhon -m django <command> [options]`. You'll encounter this tool as you use Django. (For more information see [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) in the Django docs.)
- In your project is a folder named the same as your project, which defines a Python package for the server. It contains four files:
  - `__init.py`: an empty file that tells Python that this folder is a Python package.
  - `wsgi.py`: an entry point for WSGI-compatible web servers to serve your project. You typically leave this file as-is.
  - `settings,py`: contains settings for Django server.
  - `urls.py`: contains a table of contents for for server.

You typically work with Django apps more than the server, so there's little more you need to know about these files at present.

### Create a project using Django 2.0

At present, the Blank Django Web Project template uses the latest Django 1.x version. To use Django 2.x, you can instead the quickest means is to initial a Django project from the command line, then create a Visual Studio project around it:

TODO: it's actually better to start with the template, then import 2.0 files. There are other project file settings, like pulling in the Django targets, that you don't get with the From existing code template.

1. Open a command prompt and navigate to the location in which you want to create the project, such as `c:\proj\HelloDjango`.
1. Run `django-admin startproject <project_name>` replacing `<project_name>` as you want, such as "HelloDjango". This command creates the `manage.py` file along with a folder with the project name containing `__init.py__`, `settings.py`, `urls.py`, and `wsgi.py`.
1. Open Visual Studio, select **File > New Project...**, navigate to the Python templates, and select "From existing Python code".
1. Enter your project name in the **Name** field, enter the project's parent folder in **Location**, and select **OK**.
1. Visual Studio prompts you for the folder containing the project code. Enter (or navigate to and select) the same folder as in step 1, then select **Finish**.
1. Once the project appears in **Solution Explorer**, right-click the project name, and select **Add > New item...**.
1. In the dialog that appears, select "Text file", name it `requirements.txt`, and select **Add**.
1. In the editor open with `requirements.txt` add the single line `django >=2.0, <3`, then save the file.
1. Expand the **Python Environments** node in **Solution Explorer**, right-click on the environment being used, and then select **Install from requirements.txt**. This command makes sure that Django 2.x is installed, as stipulated in `requirements.txt`. It may take a few minutes to complete the installation, because installing Django 2.x uninstalled any earlier versions.
1. Right-click the project in **Solution Explorer**, select **Properties**, select the **Debug** tab, select **Django web launcher** in the **Launch mode** list, then save the file. Setting the launch mode informs Visual Studio that you're working with Django.

Overall, these steps create a project that's virtually identical to the one created from the "Blank Django Web project" template, but bases the project on Djanjo 2.x instead of 1.x.

> [!Note]
> When you close the project, you're prompted to save the Visual Studio solution file that contains the project. You can save the solution directly in the project folder.

## Run the empty server

In Visual Studio, select **Debug > Start debugging** or use the **Web Server** button on the toolbar (the browser shown for you may vary):

![Run web server toolbar button in Visual Studio](media/django/run-web-server-toolbar-button.png)

Running the server means launching `manage.py runserver <port>`. When you start the server you see a console window open that also displays the server log. Visual Studio also opens a browser to `http://localhost:<port>`. Because the server has no apps, however, Django shows only a default page to acknowledge that what you have so far is working fine:

![Django app default view](media/django/django-default-view.png)

In addition to the **Debug** menu commands and toolbar buttons, you can also launch the server by right-clicking your project in **Solution Explorer** and selecting the **Python > Run server** or **Python > Run debug server** commands. Both commands open a console window in which you see the local URL (localhost:port) for the running server. Open a browser to that URL to see the app.

## Create an app with a single page

What you have so far in the Visual Studio project is only a Django server, which can run one or more Django apps. The next step is to create your first app.

### What is an app?

Technically speaking, a Django app is a separate Python package that contains a standard set of Python files. To create an app, you create a folder with a blank `__init.py__` file, to mark it as a package, and then add a number of standard app files. Those files define different parts of a Django app:

- "Views" are what you typically think of as web pages, which ultimately are defined by HTML that web browsers know how to display. A view is defined by a Python function whose responsibility is to render the HTML to send to the browser.
- "Templates" are blocks of HTML into which views add information dynamically to render a page.
- "Models" are data objects, identified by functions, draw from views draw the data they render. Models are typically attached to an underlying data source, such as a database.
- "Migrations" are how Django connects a model to a database schema, which allow for changes made to the model (through the user interface of a view, for example), get propagated to the database.

### Initializing the app structure

Django provides a utility to initialize an app, namely `manage.py startapp <app_name>`. If you use this utility outside of Visual Studio, however, you'd need to manually add the app folder to your project in Visual Studio. Fortunately, Visual Studio has an integrated menu command. In **Solution Explorer**, right-click the project and select **Add > Django app...**, which prompts you for a name, then creates the following items in your project:

- A folder for the app, using the name you provided.
- An `__init.py__` file defining the app as a package.
- A `migrations` folder containing an `__init.py__` file, indicating that the folder defines its own Python package.
- A `templates` folder containing a single file `index.html` template. Within that file is the token `{{ content }}` that can be replaced dynamically.
- `views.py`, in which you create the functions for your views. Initially, this file contains only the statement, `from django.shortcuts import render`.
- `models.py`, in which you create the functions for your models. Initially, this file contains only the statement, `from django.db import models`.
- `admin.py`, in which you register models with Django. Initially, this file contains  only the statement, `from django.contrib import admin`.
- `tests.py`, which contains the basic structure of unit tests.
- `apps.py` defines a configuration class for the app, which appears as follows:

    ```python
    from django.apps import AppConfig


    class HelloDjangoConfig(AppConfig):
        name = 'HelloDjango'
    ```

### Running the app from the server

At this point, if you start the server again in Visual Studio, you should see an encouraging message:

![Congratulations message on running a Django app](media/django/first-app-run-success.png)

This message is default content that Django provides because you still need to define an app-specific page and add the app to the site:

1. Modify `views.py` to match the following, which defines a view for "index":

    ```python
    from django.shortcuts import render
    from django.http import HttpResponse

    def index(request):
            return HttpResponse("Hello, Django!")
    ```

1. Tell the site to route the "index" URL to the app's index view by modifying the site's `urls.py` as follows:

    ```python
    from django.conf.urls import include, url
    import HelloDjango.views

    urlpatterns = [
        url(r'^$', HelloDjango.views.index, name='index'),
    ]
    ```

1. Add the app to the site's `INSTALLED_APPS` list in `settings.py`:

    ```python
    INSTALLED_APPS = [
        'HelloDjango',
        # Other entries...
    ]
    ```

1. Run the web server again. You should see the message "Hello, Django!" as defined by the view.

## Render a view using a template

Review https://djangobook.com/templates-in-views/ first.
https://docs.djangoproject.com/en/2.0/topics/templates/

A template is an HTML file that contains replacement tokens. Django's `render` module makes it a simple matter to provide the content for tokens directly in your view code. Using template allows you to place the invariant parts of a view in HTML, then use your code to insert variable data.

Remember that the default Django app created a simple `index.html` file in the `templates` folder. The contents of this file are as follows:

```html
<html>
<head><title></title></head>

<body>

{{ content }}

</body>
</html>
```

`{{ content }}` is a token that the `render` module can locate and replace with whatever value you want to give it. For example, replace the app's `views.py` code with the following:

```python
from django.shortcuts import render
from datetime import datetime

def index(request):
    return render(request, 'index.html',
        {
            'content' : 'Hello, Django! Today is ' + datetime.now().date().strftime('%x') + '.'
        }
    )
```

Here the second argument to `render` is the relative path *within the app's `templates` folder*. That is, within the HelloDjango app you'll see a `templates` folder that contains `index.html`. You can also organize templates into subfolders and use those folder names in this argument.

When you run the server again you should see the fuller message, demonstrating that the content is being replaced at run time.

> [!Tip]
> If you see errors that the template could not be found, make sure you added the app to the server's `settings.py` in the `INSTALLED_APPS` list. Without that entry, Django won't know to look in the app's `templates` folder.

Putting inline HTML doesn't work. `render` escapes it. So can you? The truth is, you don't want to. Keep all markup in the template. If you want to format the output differently, create separate replacement tokens.

I make the mistake of having a second index.html template in a subfolder, and edited that thinking I was editing one with a different name. I couldn't figure out why the changes weren't working.