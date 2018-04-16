---
title: Tutorial - Learning Django in Visual Studio, step 4
description: A walkthrough of Django basics in the context of Visual Studio projects, specifically the features provided by the Django Web Project template.
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

# Tutorial step 4: Use the full Django Web Project template

**Previous step: [Serve static files, add pages, and use template inheritance](learning-django-in-visual-studio-step-03-serve-static-files-and-add-pages.md)**

Now that you've explored the basics of Django by building an app upon the "Blank Django App Project" template in Visual Studio, you can easily understand the fuller app that's produced by the "Django Web Project" template.

In this step you now learn:

> [!div class="checklist"]
> - How to create a fuller Django web app using the "Django Web Project" template (step 4-1)
> - Understand the views and page templates created by the project template, which consist of three pages that inherit from a base page template and that employs static JavaScript libraries like jQuery and Bootstrap (step 4-2)
> - Understand the URL routing provided by the template (step 4-3)

The template also provides basic authentication, which is covered in the Step 5.

TODO's: add source control steps, add Q&A

## Step 4-2: Create a project from the template

1. In Visual Studio, select the **File > New > Project...** menu command, search for and select the "Django Web Project" template, specify a name and location for the project, and select **OK**.

1. Because the template includes a `requirements.txt` file, Visual Studio prompts asks where to install those dependencies. Choose the option, **Install into a virtual environment**, and in the **Add Virtual Environment** dialog select **Create** to accept the defaults.

1. Once Python finishes setting up the virtual environment, Visual Studio displays the contents of the template's `readme.html` file. Follow the instructions in that readme to create a Django super user (that is, an administrator) that you use later when exercising the authentication features of the app. To be specific, just right-click the Visual Studio project and select the **Python > Django Create Superuser** command, then follow the prompts.

1. select **Debug > Start debugging** or use the **Web Server** button on the toolbar to run the server:

    ![Run web server toolbar button in Visual Studio](media/django/run-web-server-toolbar-button.png)

1. The app created by the template has three pages, Home, About, and Contact, which you navigate between using the top menu. Take a minute or two to examine different parts of the app. To authenticate with the app through the **Log in** command, use the superuser credentials created in Step 3.

1. Stop the server when done by closing the console window.

### Examine what the template creates

At the broadest level, the "Django Web Project" template creates the following structure:

- Files in the project root:
  - `manage.py`, the Django administrative utility.
  - `db.sqlite3`, a default SQLite database.
  - `requirements.txt` containing a dependency on Django 1.x.
  - `readme.html`, a file that's displayed in Visual Studio after creating the a project. As noted in the previous section, follow the instructions here to create a super user (administrator) account for the app.
- The `app` folder contains all the app files, including views, models, tests, forms, templates and static files.
- The `FullDjango` (Django project) folder contains the typical Django project files: `__init.py__`, `settings.py`, `urls.py`, and `wsgi.py`. By using the project template, `settings.py` is already configured for the app and the database file, and `urls.py` is already configured with routes to all the app pages, including the login form.

## Step 4-2: Understand the views and page templates created by the project template

As you observe when you run the project, the app contains three views: Home, About, and Contact. The code for these views are found in the `app/views` folder. Each view function simply calls django.shortcuts.render with the path to a template and a simple data object. For example, the About page is handled by the `about` function:

```python
def about(request):
    """Renders the about page."""
    assert isinstance(request, HttpRequest)
    return render(
        request,
        'app/about.html',
        {
            'title':'About',
            'message':'Your application description page.',
            'year':datetime.now().year,
        }
    )
```

Templates are located in the app's `templates/app` folder. The base template, `layout.html`, is the most extensive. It refers to all the necessary static files (JavaScript and CSS), defines a block named "content" that other pages override, and provides another block named "scripts". The following annotated excerpts from `layout.html` show these specific areas:

```html
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />

    <!-- Define a viewport for Bootstrap's responsive rendering -->
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>{{ title }} - My Django Application</title>

    <!-- Load the primary styles and scripts -->
    {% load staticfiles %}
    <link rel="stylesheet" type="text/css" href="{% static 'app/content/bootstrap.min.css' %}" />
    <link rel="stylesheet" type="text/css" href="{% static 'app/content/site.css' %}" />
    <script src="{% static 'app/scripts/modernizr-2.6.2.js' %}"></script>
</head>
<body>
    <!-- Navbar omitted -->

    <div class="container body-content">

<!-- "content" block that pages are expected to override -->
{% block content %}{% endblock %}
        <hr/>
        <footer>
            <p>&copy; {{ year }} - My Django Application</p>
        </footer>
    </div>

<!-- Additional scripts with a "scripts" block through which pages can
     add scripts of their own.  -->
    <script src="{% static 'app/scripts/jquery-1.10.2.js' %}"></script>
    <script src="{% static 'app/scripts/bootstrap.js' %}"></script>
    <script src="{% static 'app/scripts/respond.js' %}"></script>
{% block scripts %}{% endblock %}

</body>
</html>
```

The individual page template, which extend the base template `layout.html`, are `about.html`, `contact.html`, and `index.html`. The `about.html` is the simplest and shows the `{% extends %}` and `{% block content %}` tags:

```html
{% extends "app/layout.html" %}

{% block content %}

<h2>{{ title }}.</h2>
<h3>{{ message }}</h3>

<p>Use this area to provide additional information.</p>

{% endblock %}
```

`index.html` and `contact.html` use the same structure with addition content in the "content" block.

In the `templates/app` folder you also find a fourth page `login.html`, along with `loginpartial.html` that's brought into `layout.html` using the `{% include %}` tag. These template files are discussed in the later section on authentication.

## Step 4-3: Understand the URL routing created by the template

When created by the "Django Web Project" template, the Django project's `urls.py` file appears as follows:

    ```python
    from datetime import datetime
    from django.conf.urls import url
    import django.contrib.auth.views

    import app.forms
    import app.views

    urlpatterns = [
        url(r'^$', app.views.home, name='home'),
        url(r'^contact$', app.views.contact, name='contact'),
        url(r'^about', app.views.about, name='about'),
        url(r'^login/$',
            django.contrib.auth.views.login,
            {
                'template_name': 'app/login.html',
                'authentication_form': app.forms.BootstrapAuthenticationForm,
                'extra_context':
                {
                    'title': 'Log in',
                    'year': datetime.now().year,
                }
            },
            name='login'),
        url(r'^logout$',
            django.contrib.auth.views.logout,
            {
                'next_page': '/',
            },
            name='logout'),
    ]
    ```

The first three URL patterns map directly to the `home`, `contact`, and `about` views in the app's `views.py` file. The patterns `^login/$` and `^logout$`, on the other hand, use built-in Django views instead of app-defined views. The calls to the `url` method also include extra data to customize the view. To see how those work, let's look at authentication next.

## Next steps

> [!div class="nextstepaction"]
> [Authenticate users in Django](learning-django-in-visual-studio-step-05-django-authentication.md)

## Going deeper

- Django project code: [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) (docs.djangoproject.com)
- Administrative utility: [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) (docs.djangoproject.com)
