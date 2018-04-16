---
title: Tutorial - Learning Django in Visual Studio, step 2
description: A walkthrough of Django basics in the context of Visual Studio projects, specifically steps of creating an app and using views and templates.
ms.date: 04/16/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
dev_langs:
  - python
ms.topic: tutorial
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Tutorial step 2: Create a Django app with views and templates

**Previous step: [Create a Visual Studio project and solution](learning-django-in-visual-studio-step-01-project-and-solution.md)**

What you have so far in the Visual Studio project is only a the site-level components of a Django project, which can run one or more Django apps. The next step is to create your first app, after which you learn how to render views in the app with and without Django templates.

In this step you now learn how to:

> [!div class="checklist"]
> - Create a Django app with a single page (step 2-1)
> - Render a view using HTML (step 2-2)
> - Render a view using a page template (step 2-3)

TODO's: add source control steps, add Q&A

## Step 2-1: create an app with a single page

A Django app is a separate Python package that contains standard files for different parts of the app:

| Part | Tutorial steps | Description |
| --- | --- | --- |
| Views (`views.py`) | Steps 2 through 6 | Views are what you typically think of as web pages, including those that aren't necessary seen by users of the app (such as intermediate forms). Views typically render as HTML that web browsers know how to display. A view is defined by a Python function whose responsibility is to render the HTML to send to the browser. |
| Templates<br/>(HTML files in a `templates` folder) | Steps 2 through 6 | Templates are blocks of HTML into which views can add information to dynamically render a page. |
| Models (`models.py`) | Step 6 | Models are data objects, identified by functions, through which views interact with the app's underlying database. Django provides the database connection layer so that apps don't need to concern themselves with those details. |
| Migrations<br/>(Python files in a `migrations` folder) | Step 6 | A folder in which Django stores scripts that update the database to align with changes to the models. Django's migration tools then apply the necessary changes to any previous version of the database so that it matches the current models. Using migrations, you keep your focus on your models and let Django handle the underlying database schema. |

### Initialize the app structure

Visual Studio provides an integrated command to initialize a Django app. It also provides item templates for Django 1.9 (and 1.4) apps.

- Templates: In **Solution Explorer**, right-click the project and select **Add** > **New item**. In the **Add New Item** dialog, select the "Django 1.9 App" (or "Django 1.4 App") template, specify the app name in the **Name** field, and select **OK**.

- Integrated command: In **Solution Explorer**, right-click the project and select **Add** > **Django app**. This command prompts you for a name and creates a Django 1.9 app.

    ![Menu command for adding a Django app](media/django/add-django-app-command.png)

Both methods create a folder using the name you provided (such as "HelloDjangoApp") containing the following items:

![Django app files in Solution Explorer](media/django/django-app-in-solution-explorer.png)

| Item | Description |
| --- | --- |
| `__init.py__` | The file that identifies the app as a package. |
| `migrations` | A folder containing an `__init.py__` file, indicating that the folder defines its own Python package. |
| `templates` | A folder containing a single file `index.html` template. Within that file is the token `{{ content }}` that can be replaced dynamically (Django refers to tokens as "variables"). |
| `views.py` | The Python file in which you create the functions for your views. Initially, this file contains only the statement, `from django.shortcuts import render`. |
| `models.py` | The Python file in which you create the functions for your models. Initially, this file contains only the statement, `from django.db import models`. |
| `admin.py` | The Python file in which you register models with Django. Initially, this file contains  only the statement, `from django.contrib import admin`. |
| `tests.py` | A Python file that contains the basic structure of unit tests. |
| `apps.py` | A Python file that defines a configuration class for the app (see below). |

The contents of `app.py` appears as follows when using the name "HelloDjangoApp":

```python
from django.apps import AppConfig

class HelloDjangoAppConfig(AppConfig):
    name = 'HelloDjango'
```

> [!Tip]
> Running the **Add** > **Django app** command or using **Add** > **New Item** with a Django app template produces the same files as does the Django command `manage.py startapp <app_name>`. The benefit to creating the app in Visual Studio is that the app folder is automatically integrated into the project. You can use the same Visual Studio command to create any number of apps in your project.

### Run the app from the Django project

At this point, if you start the server again in Visual Studio, you still see the default page. No app content appears because you need to define an app-specific page and add the app to the Django project:

1. In the HelloDjangoApp folder, Modify `views.py` to match the following, which defines a view for "index":

    ```python
    from django.shortcuts import render
    from django.http import HttpResponse

    def index(request):
        return HttpResponse("Hello, Django!")
    ```

1. In the HelloDjangoProject folder, modify `urls.py` by pasting the following code (you can retain the comments in the file if you like). The first entry in `urlPatterns` that starts with `'^$'` is the routing for the site root, "/"; the second, `'^home'` specifically routes "/home". You can have any number of routings to the same view:

    ```python
    from django.conf.urls import include, url
    import HelloDjangoApp.views

    urlpatterns = [
        url(r'^$', HelloDjangoApp.views.index, name='index'),
        url(r'^home', HelloDjangoApp.views.index, name='home')
    ]
    ```

1. Run the web server again to see the message "Hello, Django!" as defined by the view. Stop the server when you're done.

## Step 2-2: render a view using HTML

The `index` function in `views.py` as defined in the previous section generates nothing more than a plain-text HTTP response for the page. Most real-world web pages, of course, respond with rich HTML and JavaScript pages. Indeed, the primary reason to define a view using a function is so you can generated that content dynamically.

Because the argument to `HttpResponse` is just a string, you can build up HTML within a string. As a simple example, replace the `index` function with the following code, which generates an HTML response using dynamic content that's updated every time you refresh the page:

```python
from datetime import datetime

def index(request):
    now = datetime.now()

    html_content = "<html><head><title>Hello, Django</title></head><body>"
    html_content += "<strong>Hello Django!</strong> on " + now.strftime("%A, %d %B, %Y at %X")
    html_content += "</body></html>"

    return HttpResponse(html_content)
```

Run the server again to see a message like "**Hello Django!** on Monday, 02 April, 2018 at 12:03:36". Refresh the page to update the time and confirm that the content is being generated with each request. Stop the server when you're done.

## Step 2-3: render a view using a page template

Generating HTML in code works fine for small pages, but as pages get more sophisticated you typically want to maintain the static parts of your page, such as HTML, CSS, and JavaScript, as page templates into which you then insert dynamic, code-generated content. In the previous section, only the date and time from the `no.strftime` method is dynamic; all the other content can be placed in a page template.

A Django page template is an HTML that contains replacement tokens (variables) delineated by `{{` and `}}`, as in `{{ content }}`. Django's templating module then replaces tokens with dynamic content that you provide in code. (You can also use an inline template, but using a separate file is recommended to maintain a clean separation between markup and code.)

The following steps demonstrate the use of page templates:

1. Add the app to the site's `INSTALLED_APPS` list in `settings.py`, which tells the Django project that there's a folder of that name containing an app:

    ```python
    INSTALLED_APPS = [
        'HelloDjangoApp',
        # Other entries...
    ]
    ```

1. Make sure the the `TEMPLATES` object of `settings.py` also contains the following line, which instructs Django to look for templates in an installed app's `templates` folder:

    ```json
    'APP_DIRS': True,
    ```

1. Open the `templates/index.html` file in the app, which Visual Studio created with the app. The template contains one token `{{ content }}`.

    ```html
    <html>
    <head><title></title></head>

    <body>

    {{ content }}

    </body>
    </html>
    ```

1. With this template you can write the `index` function in the app's `views.py` file. First, add the following statement to the top of the file:

    ```python
    from django.shortcuts import render
    ```

    Then modify the `index` function as follows:

    ```python
    def index(request):
        from datetime import datetime
        now = datetime.now()

        return render(
            request,
            "index.html",  # Relative path from the 'templates' folder to the template file
            {
                'content': "<strong>Hello Django!</strong> on " + now.strftime("%A, %d %B, %Y at %X")
            }
        )
    ```

    This code takes advantage of the `django.shortcuts.render` helper function, which provides a simplified interface for working with page templates. Its second argument is the relative path to the template file within the app's `templates` folder. Typically, a template file is named for the page that uses it, if appropriate. You can also organize templates into subfolders within `templates`, in which case you prepend folder names to the filename argument.

1. Run the server and observe the output. You should see the message again, indicating that the template works

    If you see errors that the template cannot be found, make sure you added the app to the Django project's `settings.py` in the `INSTALLED_APPS` list. Without that entry, Django won't know to look in the app's `templates` folder.

1. Observe that the HTML you used in the `content` property renders only as plain text because the `render` function automatically escapes it. Ideally, you avoid using inline HTML in the first place. Formatting and styling should be kept in the markup and not in the code, and it's a simple matter to create additional tokens. For example, change `templates/index.html` to match the following (giving it a little formatting now):

    ```html
    <html>
        <head>
            <title>{{ title }}</title>
        </head>
        <body>
            <strong>{{ message }}</strong>{{ content }}
        </body>
    </html>
    ```

    Then write the `index` view function as follows:

    ```python
    def index(request):
        from datetime import datetime
        now = datetime.now()

        return render(
            request,
            "index.html",  # Relative path from the 'templates' folder to the template file
            {
                'title' : "Hello Django",
                'message' : "Hello Django!",
                'content' : " on " + now.strftime("%A, %d %B, %Y at %X")
            }
        )
    ```

1. Stop the server and restart it, observing that the page now renders properly.

> [!Tip]
> Using the `.html` extension for page template files is entirely optional, because you always identify the exact relative path to the file in the second argument to the `render` function. However, Visual Studio (and other editors) typically give you features like code completion and syntax coloration with `.html` files, which outweighs the fact that page templates are not strictly HTML.

For more capabilities of Django templates, such as includes and inheritance, see [The Django template language](https://docs.djangoproject.com/en/2.0/ref/templates/language/) in the Django documentation. Template inheritance is covered in the next step of this tutorial.

## Next steps

> [!div class="nextstepaction"]
> [Serve static files, add pages, and use template inheritance](learning-django-in-visual-studio-step-03-serve-static-files-and-add-pages.md)

## Going deeper

- Django project code: [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) (docs.djangoproject.com)
- Administrative utility: [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) (docs.djangoproject.com)