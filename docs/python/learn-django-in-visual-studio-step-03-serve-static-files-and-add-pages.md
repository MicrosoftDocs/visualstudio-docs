---
title: Django in Visual Studio tutorial Step 3, static files & template inheritance
titleSuffix: ""
description: Step 3 of a core walkthrough of Django capabilities in Visual Studio, including serving static files, adding pages to the Django app, and using template inheritance.
ms.date: 04/18/2024
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to create Django applications in Visual Studio so I can serve static files from my app and use template inheritance.
---

# Tutorial: Serve static files and use template inheritance with Django in Visual Studio

This article presents Step 3 in the tutorial series _Work with the Django web framework in Visual Studio_.

The previous Step in this tutorial series creates a minimal Django app with a single page of self-contained HTML. Modern web apps are typically composed of many pages, and use shared resources like CSS and JavaScript files to provide consistent styling and behavior. In Step 3, you work with Visual Studio item templates to add content to your Django project and expand the capabilities of the application.

In Step 3 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Use Visual Studio item templates to quickly add new files with boilerplate code
> - Serve static files from the Django code
> - Add more pages to the Django app
> - Use template inheritance to create a header and navigation across pages

## Prerequisites

- A Visual Studio solution and Django application projects created in [Step 1: Create the Django project](learn-django-in-visual-studio-step-01-project-and-solution.md) and updated in [Step 2: Create a Django app with views and page templates](learn-django-in-visual-studio-step-02-create-an-app.md) of this tutorial series.

- Review the [Prerequisites](learn-django-in-visual-studio-step-01-project-and-solution.md#prerequisites) section in Step 1 of this tutorial series for details about Django template versions, Visual Studio projects versus Django projects, and Python development on Mac.

## Explore item templates in Visual Studio

As you develop a Django application, you typically add many more Python, HTML, CSS, and JavaScript files. For each file type (and other files like *web.config* that you might need for deployment), Visual Studio provides convenient [item templates](python-item-templates.md) to get you started. You can use these templates to quickly add new files of different types with boilerplate code.

1. To view the available templates, go to **Solution Explorer** in Visual Studio and open your project structure.

1. Right-click the folder in which you want to create a new file and select **Add** > **New Item**. The **Add New Item** dialog opens:
   
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/django/vs-2022/step-03-add-item-from-template.png" alt-text="Screenshot that shows the available templates on the Add New Item dialog in Visual Studio." border="false" lightbox="media/django/vs-2022/step-03-add-item-from-template.png"::: 

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/django/step-03-add-new-item-dialog.png" alt-text="Screenshot that shows the available templates on the Add New Item dialog in Visual Studio." lightbox="media/django/step-03-add-new-item-dialog.png" border="false":::

   ::: moniker-end

1. To use a template, select the desired template, enter a name for the file, and select **Add**.

Visual Studio adds the file to your current project and marks the changes for source control.

### Understand how Visual Studio identifies item templates

The Visual Studio project file (_.pyproj_) contains a project type identifier that marks the file as a Python project. Visual Studio uses this type identifier to recognize and show only those item templates that are suitable for the project type. Visual Studio follows this approach to supply a rich set of item templates for many project types without asking you to sort through them every time.

## Serve static files from your app

In a web app built with Python (by using any framework), your Python files always run on the web host's server and are never transmitted to a user's computer. Other files like CSS and JavaScript are used only by the browser, so the host server simply delivers them as-is when they're requested. These types of files are referred to as "static" files, and Django can deliver them automatically without you needing to write any code. 

A Django project is set up by default to serve static files from the app's _static_ folder. This behavior is made possible by the following code in the Django project's _settings.py_ file:

```python
# Static files (CSS, JavaScript, Images)
# https://docs.djangoproject.com/en/1.9/howto/static-files/

STATIC_URL = '/static/'

STATIC_ROOT = posixpath.join(*(BASE_DIR.split(os.path.sep) + ['static']))
```

You can organize the files within the app's _static_ folder by using any folder structure you like, and use relative paths within the _static_ folder to refer to the files. 

### Use static CSS file in HTML template

Follow these steps to add a CSS file to the app, then use the CSS stylesheet in the _index.html_ template:

1. In **Solution Explorer**, right-click the _HelloDjangoApp_ folder in your project, select **Add** > **New folder**, and name the folder _static_.

1. Right-click the _static_ folder and select **Add** > **New Item**.

1. In the **Add New Item** dialog, select the **Style Sheet** template, name the file _site.cs_, and then select **Add**.

   Visual Studio adds the _site.css_ file to the project and opens the file in the editor. Here's an example of the updated Django project structure:

   :::image type="content" source="media/django/step-03-static-file-structure.png" alt-text="Screenshot that shows the static file structure in Solution Explorer." lightbox="media/django/step-03-static-file-structure.png" border="false":::

1. Replace the contents of the _site.css_ file with the following styles:

   ```css
   .message {
       font-weight: 600;
       color: blue;
   }
   ```

1. Replace the contents of the _HelloDjangoApp/templates/index.html_ file with the following markup:

   ```html
   <html>
      <head>
         <title>{{ title }}</title>
         {% load static %} <!-- Instruct Django to load static files -->
         <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
      </head>
      <body>
         <span class="message">{{ message }}</span>{{ content }}
      </body>
   </html>
   ```

   This code replaces the `<strong>` HTML element from Step 2 in the tutorial series with a `<span>` element that references the `message` style class. Using a style class in this way gives you more flexibility in styling the HTML element.

1. Save your project changes by selecting **File** > **Save All** or use the **Ctrl**+**Shift**+**S** keyboard shortcut. (This step isn't necessary because as you develop your project, Visual Studio saves your files automatically.)

1. Run the project and observe the results. When you're done, stop the app.

1. (Optional) You can commit your changes to source control and update your remote repository. For more information, see [Commit changes to source control](learn-django-in-visual-studio-step-02-create-an-app.md#commit-changes-to-source-control) in Step 2 of this tutorial series.

### Use {% load static %} tag

The `{% load static %}` statement must be present in the _index.html_ file before site relative references to static files in HTML elements like `<head>` and `<body>`. In the example shown in this section, "static files" refers to a custom Django template tag set. The tag set allows you to use the `{% static %}` syntax to refer to static files. Without the `{% load static %}` tag, you see an exception when the app runs.

### Add references without {% load static %} tag

You can also set up site relative references to static files in the HTML markup without using the `{% load static %}` tag. In this case, you specify the location of the _static_ folder within the Django project folder hierarchy:

```html
<html>
    <head>
        <title>{{ title }}</title>
        <link rel="stylesheet" type="text/css" href="../../static/site.css" />
    </head>
    <body>
        <span class="message">{{ message }}</span>{{ content }}
    </body>
</html>
```

### Organize static files and folders

You can add other CSS, JavaScript, and HTML files in your _static_ folder according to your project needs. A typical way to organize static files is to create subfolders named _fonts_, _scripts_, and _content_ (for stylesheets and any other files). In each case, remember to include the folders in the relative file path in the `{% static %}` references.

## Add page to Django application

Adding another page to the Django application involves the following tasks:

- Add a Python function that defines the view
- Add a template for the page's HTML markup
- Update the URL routes in the Django project's _urls.py_ file

Follow these steps to add an About (`/about`) page to the _HelloDjangoApp_ project, and links to that page from the home page:

1. In **Solution Explorer**, right-click the _templates/HelloDjangoApp_ folder in your project, and select **Add** > **New Item**.

   > [!TIP]
   > If you don't see the **New Item** command on the **Add** menu, make sure to stop your Django app so Visual Studio exits debugging mode, as needed.

1. In the **Add New Item** dialog, select the **HTML Page** template, name the file _about.html_, and then select **Add**.

1. Replace the contents of the _about.html_ file with the following HTML markup:

   ```html
   <html>
      <head>
         <title>{{ title }}</title>
         {% load static %}
         <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
      </head>
      <body>
         <div><a href="home">Home</a></div>
         {{ content }}
      </body>
   </html>
   ```

   In a subsequent step, you replace the explicit link to the home page with a navigation bar.

1. In the _HelloDjangoApp/views.py_ file, add a function named `about` that uses the template:

   ```python
   def about(request):
      return render(
         request,
         "HelloDjangoApp/about.html",
         {
            'title' : "About HelloDjangoApp",
            'content' : "Example app page for Django."
         }
      )
   ```

1. In the Django project's _BasicProject/urls.py_ file, add the path for the `about` page as the last item in the `urlPatterns` array:

   ```python
   # Django processes URL patterns in the order they appear in the array
   urlpatterns = [
      re_path(r'^$', HelloDjangoApp.views.index, name='index'),
      re_path(r'^home$', HelloDjangoApp.views.index, name='home'),
      re_path(r'^about$', HelloDjangoApp.views.about, name='about')
    ]
   ```

1. In the _templates/HelloDjangoApp/index.html_ file, add the following markup as the first statement in the `<body>` element:

   ```html
   <div><a href="about">About</a></div>
   ```

   This markup adds a link to the `/about` page for the Django app. In a later step, you replace this link with a navigation bar.

1. Save your project changes, and run the project again. Browse to the `/about` page and check navigation between the various app pages.

1. When you're done, stop the app.

### Route to "index" page

If you try to browse to the `/index` page for your running app, you see a **Page not found (404)** error.

Although the _HelloDjangoApp/views.py_ file has a function named `index`, the URL routing patterns in the Django project's _BasicProject/urls.py_ file don't contain a regular expression that matches the string `index`. The current expression for the app "index" page is `^$`. To match the string `index`, you need to add another URL entry for the pattern `^index$`.

The next section describes how it's better to use the `{% url '<pattern_name>' %}` tag in the page template to refer to the _name_ of a pattern. In this case, Django creates the proper URL for you. For example, you can replace the `<div><a href="home">Home</a></div>` markup in the _templates/HelloDjangoApp/about.html_ file with the markup `<div><a href="{% url 'index' %}">Home</a></div>`. The use of the `'index'` string now works because the first URL pattern in the _urls.py_ file is named `'index'`. You can also use `'home'` to refer to the second pattern.

## Use template inheritance for header and navigation

Instead of explicit navigation links on each page, many web apps have a branding header and navigation bar that provides the most important page links, popup menus, and so on. To ensure consistency within the app, the header and navigation bar should be the same across all pages, but you don't need to repeat same code in every page template. You can define the common parts of all your pages in a single file.

Django's templating system provides two ways to reuse specific elements across multiple templates:

- **Includes** are other page templates that you insert at a specific place in the referring template with the syntax `{% include <template_path> %}`. You can also use a variable if you want to change the path dynamically in code. Includes are typically used in the body of a page to pull in the shared template at a specific location on the page.

- **Inheritance** uses the `{% extends <template_path> %}` syntax at the beginning of a page template to specify a shared base template that the referring template builds upon. Inheritance is commonly used to define a shared layout, navigation bar, and other structures for an app's pages. This approach requires referring templates to add or modify only specific areas of the base template called *blocks*.

For both approaches, the `<template_path>` value is relative to the app's _templates_ folder (`../` or `./` are also allowed).

A base template delineates blocks by using the `{% block <block_name> %}` and `{% endblock %}` tags. If a referring template uses tags with the same block name, then the block content in the referring template overrides the matching block in the base template.

The following steps demonstrate template inheritance:

1. In **Solution Explorer**, right-click the _templates/HelloDjangoApp_ folder, and create a new file from the **HTML Page** template with the name _layout.html_.

1. Replace the contents of the _layout.html_ file with the following HTML markup:

   ```html
   <!DOCTYPE html>
   <html>
   <head>
      <meta charset="utf-8" />
      <title>{{ title }}</title>
      {% load static %}
      <link rel="stylesheet" type="text/css" href="{% static 'site.css' %}" />
   </head>

   <body>
      <div class="navbar">
         <a href="/" class="navbar-brand">Hello Django</a>
         <a href="{% url 'home' %}" class="navbar-item">Home</a>
         <a href="{% url 'about' %}" class="navbar-item">About</a>
      </div>

      <div class="body-content">
         {% block content %}
         {% endblock %}
         <hr/>
         <footer>
            <p>&copy; 2024</p>
         </footer>
      </div>
   </body>
   </html>
   ```

   This template contains a block named `content`, which identifies all the content that the referring pages need to replace.

1. In the _HelloDjangoApp/static/site.css_ file, add the following styles to the end of the file:

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

   These style definitions generate an interesting result for this exercise. This walkthrough doesn't demonstrate responsive design. 

1. Replace the contents of the _templates/HelloDjangoApp/index.html_ file with the following code:

   ```html
   {% extends "HelloDjangoApp/layout.html" %}
   {% block content %}
   <span class="message">{{ message }}</span>{{ content }}
   {% endblock %}
   ```

   The `index` template now refers to the base template and overrides the `content` block. You can see that by using inheritance, this template is simplified.

1. Replace the contents of the _templates/HelloDjangoApp/about.html_ file with the following code, so the `about` template also refers to the base template and overrides the `content` block:

   ```html
   {% extends "HelloDjangoApp/layout.html" %}
   {% block content %}
   {{ content }}
   {% endblock %}
   ```

1. Run the app again and observe the results. Use the navigation bar links to switch between app pages. 

   :::image type="content" source="media/django/step-03-template-inheritance-navigation.png" alt-text="Screenshot that shows the revised Django app that uses template inheritance to render a header and navigation bar across all pages." lightbox="media/django/step-03-template-inheritance-navigation.png" border="false":::

1. When you're done, stop the app and save your project changes.

1. Because you made substantial changes to the app, it's a good time to save your changes to a Git repository. For more information, see [Commit changes to source control](learn-django-in-visual-studio-step-02-create-an-app.md#commit-changes-to-source-control) in Step 2 of this tutorial series.

## Next step

> [!div class="nextstepaction"]
> [Step 4: Use the full Django Web Project template](learn-django-in-visual-studio-step-04-full-django-project-template.md)
