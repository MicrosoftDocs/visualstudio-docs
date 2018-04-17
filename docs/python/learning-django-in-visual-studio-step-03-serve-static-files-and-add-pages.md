---
title: Tutorial - Learning Django in Visual Studio, step 3
description: A walkthrough of Django basics in the context of Visual Studio projects, specifically demonstrating how to serve static files, add pages to the app, and use template inheritance
ms.date: 04/16/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: tutorial
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Tutorial step 3: Serve static files, add pages, and use template inheritance

**Previous step: [Create a Django app with views and templates](learning-django-in-visual-studio-step-02-create-an-app.md)**

In the previous steps of this tutorial you've learned how to create a very basic Django app with a single page of self-contained HTML. Modern web apps, however are typically composed of many pages, and make use of shared resources like CSS and JavaScript and file to provide consistent styling and behavior.

In this step you now learn how to:

> [!div class="checklist"]
> - Use Visual Studio item templates to quickly new files of different types with convenient boilerplate code (step 3-1)
> - Configure the Django project to serve static files (step 3-2)
> - Add additional pages to the app (step 3-3)
> - Use template inheritance to create a header and nav bar that's used across pages (step 3-4)

TODO's: add source control steps, add Q&A

## Step 3-1: Use item templates

As you develop a Django app, you typically add many more Python, HTML, CSS, and JavaScript files. For each of these (as well as other files like `web.config` that you may need for deployment), Visual Studio provides convenient [item templates](python-item-templates.md) to get you started.

To access a template, go to **Solution Explorer**, right-click the folder in which you want to create the item, select **Add > New Item...**, select the desired template, specify a name for the file, and select **OK**. Adding an item in this manner automatically adds the file to your Visual Studio project.

## Step 3-2: Serve static files from your app

Your Python files, of course, run on the server. Other files, such as CSS and JavaScript (and possibly some HTML) are *static* files because the server simply delivers them as-is when requested by a client.

The Django project is configured by default to serve static files from the app's `static` folder, thanks to these lines in the Django project's `settings.py`:

```python
# Static files (CSS, JavaScript, Images)
# https://docs.djangoproject.com/en/1.9/howto/static-files/

STATIC_URL = '/static/'

STATIC_ROOT = posixpath.join(*(BASE_DIR.split(os.path.sep) + ['static']))
```

You can organize files using any folder structure within `static` that you like, as you use relative paths within that folder whenever you refer to the files. To demonstrate this, the following steps add a CSS file to the app, then use stylesheet in the `index.html` template:

1. In **Solution Explorer**, right-click the "HelloDjangoApp" folder in the Visual Studio project, select **Add > New folder**, and name the folder `static`.

1. Right-click the `static` folder and select **Add > New item...**. In the dialog that appears, select the "Stylesheet" template, name the file `site.css`, and select **OK**. The `site.css` file appears in the project and is opened in the editor.

1. Make the contents of `site.css` match the following, and save the file:

    ```css
    .message {
        font-weight: 600;
        color: blue;
    }
    ```

1. Make the contents of the app's `templates/index.html` file match the following:

    ```html
    <html>
        <head>
            <title>{{ title }}</title>
            {% load staticfiles %} <!-- Instruct Django to load static files -->
            <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
        </head>
        <body>
            <span class="message">{{ message }}</span>{{ content }}
        </body>
    </html>
    ```

    The `{% load staticfiles %}` line is essential before referring to static files in elements like `<head>` and `<body>`. In this case, "staticfiles" refers to a custom template tag set, specifically the one that allows you to use the `{% static %}` syntax to refer to static files.  Without `{% load staticfiles %}`, you'll see an exception when the app runs.

    In any case, you can see that the markup here replaces the `<strong>` element with a `<span>` that references the `message` style, which gives you much more flexibility in styling the message element.

1. Run the server to observe the results. Stop the server when done.

You can add other CSS, JavaScript, and HTML files in your `static` folder however you want. A typical way to organize static files is to create subfolders named `fonts`, `scripts`, and `content` (for stylesheets and any other files). In each case, remember to include those folders in the relative path to the file in `{% static }` references.

## Step 3-3: Add a page to the app

Adding another page to the app means adding a Python function that defines the view, adding a template for the page's markup, and adding the necessary routing to the Django project's `urls.py` file. The following steps add an "About" page to the "HelloDjangoApp" project, and links to that page from the home page:

1. In **Solution Explorer**, right-click the app's `template` folder, select **Add > New item...**, select the "HTML Page" item template, name it `about.html`, and select **OK**.

1. Replace the contents of `about.html` with the following markup (don't worry about the explicit link; you replace it in the next section with a simple navigation bar):

    ```html
    <html>
        <head>
            <title>{{ title }}</title>
            {% load staticfiles %}
            <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
        </head>
        <body>
            <div><a href="index">Home</a></div>
            {{ content }}
        </body>
    </html>
    ```

1. Open the app's `views.py` file and add a function named `about` that uses the template:

    ```python
    def about(request):
        return render(
            request,
            "about.html",
            {
                'title' : "About HelloDjangoApp",
                'content' : "Example app page for Django."
            }
        )
    ```

1. Open the Django project's `urls.py` file and add the following line to the `urlPatterns` array (you also need a comma at the end of the previous line):

    ```python
    url(r'^about', HelloDjangoApp.views.about, name='about')
    ```

1. Open the app's `templates/index.html` file and add the following line below the `<body>` element to link to the About page:

    ```html
    <div><a href="about">About</a></div>
    ```

1. Save all the file using the **File > Save All** menu command, or just press or Ctrl+Shift+S. (Technically, this step isn't needed as the next one automatically saves files; however, it's a good command to know about!)

1. Run the server to observe the results and check navigation between pages. Close the server when done.

## Step 3-4: Use template inheritance to create a header and nav bar

Having an explicit link on each page is obviously not anything close to modern web design. Most modern sites use a consistent header for branding on every page along with a navigation bar that contains the most important page links, popup menus, and so on. To keep the header and nav bar consistent, however, you don't want to repeat the same code in every page template. You rather want to define the consistent parts of all your pages in one place.

Django's templating system provides two means for reusing specific elements across multiple templates: includes and inheritance.

Includes are other templates that you insert at a specific place in the referring template using the syntax `{% include <template_path> %}` where `<template_path>` points to the included template file relative to the `templates` folder, or you can use `../` or `./`. (You can also use a token for if you want to change the path dynamically in code.) Includes are typically used in the body of a page to pull in the shared template at a specific location on the page.

Interitance uses the `{% extends <template_path> %}` at the beginning of a template to specify a shared base template that the referring template then builds upon. Inheritance is commonly used to define a shared layout, nav bar, and other structures for an app's pages, such that referring templates need only add or modify specific areas of the base template.

Those areas as called "blocks" and are delineated using `{% block <block_name> %}` and `{% endblock %}` tags. If a referring template uses tags with the same block name, its block content replaces that of the base template.

The following steps demonstrate how inheritance works:

1. In the app's `templates` folder, create a new HTML file (using the **Add > New item...** context menu) called `layout.html`, and paste in the contents below. You can see that this template contains a block named "content" that is all that the referring pages need to replace:

    ```html
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="utf-8" />
        <title>{{ title }}</title>
        {% load staticfiles %}
        <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
    </head>

    <body>
        <div class="navbar">
           <a href="/" class="navbar-brand">Hello Django</a>
           <a href="{% url 'home' %}" class="navbar-item">Home</a>
           <a href="{% url 'about' %}" class="navbar-item">About</a>
        </div>

        <div class="body-content">
    {% block content %}{% endblock %}
            <hr/>
            <footer>
                <p>&copy; 2018</p>
            </footer>
        </div>
    </body>
    </html>
    ```

1. Add the following styles to the app's `static/site.css` file (this walkthrough isn't attempting to demonstrate responsive design here; these styles are simply to generate an interesting result):

    ```css
    .navbar {
        background-color: lightslategray;
        font-size: 1em;
        font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;    
        color: white;
        padding: 8px 5px 8px 5px;
    }

    .navbar a {
        text-decoration: none;
        color: inherit;
    }

    .navbar-brand {
        font-size: 1.2em;
        font-weight: 600;
    }

    .navbar-item {
        font-variant: small-caps;
        margin-left: 30px;
    }

    .body-content {
        padding: 5px;
        font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }
    ```

1. Modify `templates/index.html` to refer to the base template and override the content block. You can see that by using inheritance, this template becomes very simple:

    ```html
    {% extends "layout.html" %}
    {% block content %}
    <span class="message">{{ message }}</span>{{ content }}
    {% endblock %}
    ```

1. Modify `templates/about.html` to also refer to the base template and override the content block:

    ```html
    {% extends "layout.html" %}
    {% block content %}
    {{ content }}
    {% endblock %}
    ```

1. Run the server to observe the results. Close the server when done.

## Next steps

> [!div class="nextstepaction"]
> [Use the full Django Web Project template](learning-django-in-visual-studio-step-04-full-django-project-template.md)

## Going deeper

- Django project code: [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) (docs.djangoproject.com)
- Administrative utility: [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) (docs.djangoproject.com)