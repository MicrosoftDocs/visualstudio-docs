---
title: Flask in Visual Studio tutorial Step 3, static files & template inheritance
titleSuffix: ""
description: Step 3 of a core walkthrough of Flask capabilities in Visual Studio, including serving static files, adding pages to the Flask app, and using template inheritance.
ms.date: 04/18/2024
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to create Flask applications in Visual Studio so I can serve static files from my app and use template inheritance.
---

# Tutorial: Serve static files and use template inheritance with Flask in Visual Studio

This article presents Step 3 in the tutorial series _Work with the Flask web framework in Visual Studio_.

The previous Steps in this tutorial series create a minimal Flask app with a single page of self-contained HTML. Modern web apps are typically composed of many pages, and use shared resources like CSS and JavaScript files to provide consistent styling and behavior. In Step 3, you work with Visual Studio item templates to add content to your Flask project and expand the capabilities of the application.

In Step 3 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Use Visual Studio item templates to quickly add new files with boilerplate code
> - Serve static files from the Flask code
> - Add more pages to the Flask app
> - Use template inheritance to create a header and navigation across pages

## Prerequisites

- A Visual Studio solution and Flask application project created in [Step 1: Create Flask project](learn-flask-visual-studio-step-01-project-solution.md) and updated in [Step 2: Refactor Flask project](learn-flask-visual-studio-step-02-create-app.md).

## Explore item templates in Visual Studio

As you develop a Flask application, you typically add many more Python, HTML, CSS, and JavaScript files. For each file type (and other files like *web.config* that you might need for deployment), Visual Studio provides convenient [item templates](python-item-templates.md) to get you started. You can use these templates to quickly add new files of different types with boilerplate code.

1. To view the available templates, go to **Solution Explorer** in Visual Studio and open your project structure.

1. Right-click the folder in which you want to create a new file and select **Add** > **New Item**. The **Add New Item** dialog opens:
   
   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/flask/vs-2022/step-03-add-item-from-template.png" alt-text="Screenshot that shows the available templates on the Add New Item dialog in Visual Studio." border="false" lightbox="media/flask/vs-2022/step-03-add-item-from-template.png"::: 

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/flask/step-03-add-new-item-dialog.png" alt-text="Screenshot that shows the available templates on the Add New Item dialog in Visual Studio." lightbox="media/flask/step-03-add-new-item-dialog.png" border="false":::

   ::: moniker-end

1. To use a template, select the desired template, enter a name for the file, and select **Add**.

Visual Studio adds the file to your current project and marks the changes for source control.

### Understand how Visual Studio identifies item templates

The Visual Studio project file (_.pyproj_) contains a project type identifier that marks the file as a Python project. Visual Studio uses this type identifier to recognize and show only those item templates that are suitable for the project type. Visual Studio follows this approach to supply a rich set of item templates for many project types without asking you to sort through them every time.

## Serve static files from your app

In a web app built with Python (by using any framework), your Python files always run on the web host's server and are never transmitted to a user's computer. Other files like CSS and JavaScript are used only by the browser, so the host server simply delivers them as-is when they're requested. These types of files are referred to as "static" files, and Flask can deliver them automatically without you needing to write any code. Within HTML files, for example, you can refer to static files by using a relative path in the project. The first procedure in this section shows how to use a static CSS file with an existing page template.

When you need to deliver a static file from code, such as through an API endpoint implementation, Flask provides a convenient method. You can refer to files by using relative paths within a folder named _static_ in the project root. The second procedure in this section demonstrates how to work with a simple static data file from code.

In both procedures, you can organize the files under the _static_ folder according to your preference.

### Use static CSS file in a template

Follow these steps to use a static file in a template:

1. In **Solution Explorer**, right-click the _HelloFlask_ folder in your project, select **Add** > **New folder**, and name the folder _static_.

1. Right-click the _static_ folder and select **Add** > **New Item**.

1. In the **Add New Item** dialog, select the **Style Sheet** template, name the file _site.cs_, and then select **Add**.

   Visual Studio adds the _site.css_ file to the project and opens the file in the editor. Here's an example of the updated Flask project structure:

   :::image type="content" source="media/flask/step-03-static-file-structure.png" alt-text="Screenshot that shows the static file structure in Solution Explorer." lightbox="media/flask/step-03-static-file-structure.png" border="false":::

1. Replace the contents of the _site.css_ file with the following styles:

   ```css
   .message {
       font-weight: 600;
       color: blue;
   }
   ```

1. Replace the contents of the _HelloFlask/templates/index.html_ file with the following markup:

   ```html
   <html>
      <head>
         <title>{{ title }}</title>
         <link rel="stylesheet" type="text/css" href="/static/site.css" />
      </head>
      <body>
         <span class="message">{{ message }}</span>{{ content }}
      </body>
   </html>
   ```

   This code replaces the `<strong>` HTML element from Step 2 in the tutorial series with a `<span>` element that references the `message` style class. Using a style class in this way gives you more flexibility in styling the HTML element.

1. Save your project changes by selecting **File** > **Save All** or use the **Ctrl**+**Shift**+**S** keyboard shortcut. (This step isn't necessary because as you develop your project, Visual Studio saves your files automatically.)

1. Run the project and observe the results. When you're done, stop the app.

1. (Optional) You can commit your changes to source control and update your remote repository. For more information, see [Commit changes to source control](learn-flask-visual-studio-step-02-create-app.md#commit-changes-to-source-control) in Step 2 of this tutorial series.

### Serve static file from code

Flask provides a function named `send_static_file` that you can call from code to refer to any file within the project's _static_ folder. The following process creates a simple API endpoint that returns a static data file:

1. In the _static_ folder, create a static JSON data file named _data.json_. You can use the **Text** file template as a basis for the file.

1. Replace the contents of the JSON file with the following code that provides some sample data to demonstrate the mechanism:

   ```json
   {
      "01": {
         "note" : "Sample data to demonstrate the mechanism."
      }
   }
   ```

1. In the _HelloFlask/views.py_ file, add a function with the route `/api/data` endpoint that returns the static data file by using the `send_static_file` method:

    ```python
    @app.route('/api/data')
    def get_data():
      return app.send_static_file('data.json')
    ```

1. Save your project changes, and run the project again. Browse to the `/api/data` route endpoint and confirm the app returns the static file:

   :::image type="content" source="media/flask/step-03-render-static-file.png" alt-text="Screenshot that shows the updated application page view for the slash home route and the static file output for the slash API slash data route." border="false" lightbox="media/flask/step-03-render-static-file.png":::

1. When you're done, stop the app.

### Organize static files and folders

You can add other CSS, JavaScript, and HTML files in your _static_ folder according to your project needs. A typical way to organize static files is to create subfolders named _fonts_, _scripts_, and _content_ (for stylesheets and any other files).

### Use URL routes and query parameters from APIs

You can handle URL variables and query parameters with APIs when your work with Flask. For more information, see [Use variable URL routes and query parameters](learn-flask-visual-studio-step-01-project-solution.md#use-variable-url-routes-and-query-parameters) in Step 1 of this tutorial series.

## Add page to the Flask application

Adding another page to the Flask application involves the following tasks:

- Add a Python function that defines the view
- Add a template for the page's HTML markup
- Update the URL routes in the Flask project's _views.py_ file

Follow these steps to add an About (`/about`) page to the _BasicProject_ Flask project, and links to that page from the home page:

1. In **Solution Explorer**, right-click the _HelloFlask/templates_ folder in your project, and select **Add** > **New Item**.

   > [!TIP]
   > If you don't see the **New Item** command on the **Add** menu, make sure to stop your Flask app so Visual Studio exits debugging mode, as needed.

1. In the **Add New Item** dialog, select the **HTML Page** template, name the file _about.html_, and then select **Add**.

1. Replace the contents of the _about.html_ file with the following HTML markup:

   ```html
   <html>
      <head>
         <title>{{ title }}</title>
         <link rel="stylesheet" type="text/css" href="/static/site.css" />
      </head>
      <body>
         <div><a href="home">Home</a></div>
         {{ content }}
      </body>
   </html>
   ```

   In a subsequent step, you replace the explicit link to the home page with a navigation bar.

1. In the _HelloFlask/views.py_ file, add a function named `about` that uses the template:

   ```python
   @app.route('/about')
   def about():
      return render_template(
         "about.html",
         title = "About HelloFlask",
         content = "Example app page for Flask.")
    ```

1. In the _HelloFlask/templates/index.html_ file, add the following markup as the first statement in the `<body>` element:

   ```html
   <div><a href="about">About</a></div>
   ```

   This markup adds a link to the `/about` page for the Flask app. In a later step, you replace this link with a navigation bar.

1. Save your project changes, and run the project again. Browse to the `/about` page and check navigation between the various app pages.

1. When you're done, stop the app.

### Name your page function

Flask doesn't impose any restrictions or requirements on the name for your page function. The `@app.route` decorator determines the URLs for which Flask calls the function to generate a response. Developers typically match the page function name to the route, but this type of matching isn't required.

## Use template inheritance for header and navigation

Instead of explicit navigation links on each page, many web apps have a branding header and navigation bar that provides the most important page links, popup menus, and so on. To ensure consistency within the app, the header and navigation bar should be the same across all pages, but you don't need to repeat same code in every page template. You can define the common parts of all your pages in a single file.

Flask's templating system (Jinja by default) provides two ways to reuse specific elements across multiple templates:

- **Includes** are other page templates that you insert at a specific place in the referring template with the syntax `{% include <template_path> %}`. You can also use a variable if you want to change the path dynamically in code. Includes are typically used in the body of a page to pull in the shared template at a specific location on the page.

- **Inheritance** uses the `{% extends <template_path> %}` syntax at the beginning of a page template to specify a shared base template that the referring template builds upon. Inheritance is commonly used to define a shared layout, navigation bar, and other structures for an app's pages. This approach requires referring templates to add or modify only specific areas of the base template called *blocks*.

For both approaches, the `<template_path>` value is relative to the app's _templates_ folder (_../_ or _./_ are also allowed).

A base template delineates blocks by using the `{% block <block_name> %}` and `{% endblock %}` tags. If a referring template uses tags with the same block name, then the block content in the referring template overrides the matching block in the base template.

The following steps demonstrate template inheritance:

1. In **Solution Explorer**, right-click the _HelloFlask/templates_ folder, and create a new file from the **HTML Page** template with the name _layout.html_.

1. Replace the contents of the _layout.html_ file with the following HTML markup:

   ```html
   <!DOCTYPE html>
   <html>
   <head>
      <meta charset="utf-8" />
      <title>{{ title }}</title>
      <link rel="stylesheet" type="text/css" href="/static/site.css" />
   </head>

   <body>
      <div class="navbar">
         <a href="/" class="navbar-brand">Hello Flask</a>
         <a href="{{ url_for('home') }}" class="navbar-item">Home</a>
         <a href="{{ url_for('about') }}" class="navbar-item">About</a>
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

1. In the _HelloFlask/static/site.css_ file, add the following styles to the end of the file:

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

1. Replace the contents of the _HelloFlask/templates/index.html_ file with the following markup:

   ```html
   {% extends "layout.html" %}
   {% block content %}
   <span class="message">{{ message }}</span>{{ content }}
   {% endblock %}
   ```

   The `index` template now refers to the base template and overrides the `content` block. You can see that by using inheritance, this template is simplified.

1. Replace the contents of the _HelloFlask/templates/about.html_ file with the following markup, so the `about` template also refers to the base template and overrides the `content` block:

   ```html
   {% extends "layout.html" %}
   {% block content %}
   {{ content }}
   {% endblock %}
   ```

1. Run the app again and observe the results. Use the navigation bar links to switch between app pages. 

   :::image type="content" source="media/flask/step-03-template-inheritance-navigation.png" alt-text="Screenshot that shows the revised Flask app that uses template inheritance to render a header and navigation bar across all pages." lightbox="media/flask/step-03-template-inheritance-navigation.png" border="false":::

1. When you're done, stop the app and save your project changes.

1. Because you made substantial changes to the app, it's a good time to save your changes to a Git repository. For more information, see [Commit changes to source control](learn-flask-visual-studio-step-02-create-app.md#commit-changes-to-source-control) in Step 2 of this tutorial series.

## Tutorial review

Congratulations on completing this tutorial on Flask in Visual Studio.

In this tutorial, you learned how to:

- Create a Flask project with multiple pages
- Use templates to create different page views 
- Serve static files, add pages, and use template inheritance

## Related content

- [Jinja Template Designer Documentation](http://jinja.palletsprojects.com/en/2.10.x/templates/) (jinja.pocoo.org)
- [url_for](https://flask.palletsprojects.com/en/3.0.x/api/#flask.url_for) in the Flask Application object documentation (flask.pocoo.org)
- [Tutorial source code on GitHub (Microsoft/python-sample-vs-learning-flask)](https://github.com/Microsoft/python-sample-vs-learning-flask)
