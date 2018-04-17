---
title: Tutorial - Learning Django in Visual Studio, step 2
description: A walkthrough of Django basics in the context of Visual Studio projects, specifically steps of creating an app and using views and templates.
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

# Tutorial step 2: Create a Django app with views and page templates

**Previous step: [Create a Visual Studio project and solution](learning-django-in-visual-studio-step-01-project-and-solution.md)**

What you have so far in the Visual Studio project are only the site-level components of a Django *project*, which can run one or more Django *apps*. The next step is to create your first app with a single page.

In this step you now learn how to:

> [!div class="checklist"]
> - Create a Django app with a single page (step 2-1)
> - Run the app from the Django project (step 2-2)
> - Render a view using HTML (step 2-3)
> - Render a view using a Django page template (step 2-4)

## Step 2-1: create an app with a default structure

A Django app is a separate Python package that contains a set of related files for a specific purpose. A Django project can contain any number of apps, which reflects the fact that a web host can serve any number of separate entry points from a single domain name. For example, a Django project for a domain like contoso.com might contain one app for www.contoso.com, a second app for support.contoso.com, and a third app for docs.contoso.com. In this case, the Django project handles site-level URL routing and settings (in its `urls.py` and `settings.py` files), while each app has its own distinct styling and behavior through its internal routing, views, models, static files, and administrative interface.

A Django app typically begins with a standard set of files. Visual Studio provides item templates to initialize a Django app within a Django project, along with an integrated menu command that serves the same purpose:

- Templates: In **Solution Explorer**, right-click the project and select **Add** > **New item**. In the **Add New Item** dialog, select the "Django 1.9 App" template, specify the app name in the **Name** field, and select **OK**.

- Integrated command: In **Solution Explorer**, right-click the project and select **Add** > **Django app**. This command prompts you for a name and creates a Django 1.9 app.

    ![Menu command for adding a Django app](media/django/step02-add-django-app-command.png)

Using either method, create an app with the name "HelloDjangoApp". The result is a folder in your project with that name, which contains the following items:

![Django app files in Solution Explorer](media/django/step02-django-app-in-solution-explorer.png)

| Item | Description |
| --- | --- |
| `__init.py__` | The file that identifies the app as a package. |
| `migrations` | A folder in which Django stores scripts that update the database to align with changes to the models. Django's migration tools then apply the necessary changes to any previous version of the database so that it matches the current models. Using migrations, you keep your focus on your models and let Django handle the underlying database schema. Migrations are discussed in step 6; for now, the folder simply contains an `__init.py__` file (indicating that the folder defines its own Python package). |
| `templates` | A folder for Django page templates containing a single file `index.html`. Templates are blocks of HTML into which views can add information to dynamically render a page. Page template "variables," such as `{{ content }}` in `index.html`, are placeholders for dynamic values as explained later in this article (step 2). |
| `admin.py` | The Python file in which you extend the app's administrative interface (see step 6), which is used to see and edit data in a database. Initially, this file contains only the statement, `from django.contrib import admin`. By default, Django includes a standard administrative interface through entries in the Django project's `settings.py` file, which you can turn on by uncommenting existing entries in `urls.py`. |
| `apps.py` | A Python file that defines a configuration class for the app (see below, after this table). |
| `models.py` | Models are data objects, identified by functions, through which views interact with the app's underlying database (see step 6). Django provides the database connection layer so that apps don't need to concern themselves with those details. The `models.py` file is a default place in which to create your models, and initially contains only the statement, `from django.db import models`. |
| `tests.py` | A Python file that contains the basic structure of unit tests. |
| `views.py` | Views are what you typically think of as web pages, including those that aren't necessary seen by users of the app (such as intermediate forms). Views typically render as HTML that web browsers know how to display. A view is defined by a Python function whose responsibility is to render the HTML to send to the browser. The `views.py` file is a default place in which to create views, and initially contains only the statement, `from django.shortcuts import render`. |

The contents of `app.py` appears as follows when using the name "HelloDjangoApp":

```python
from django.apps import AppConfig

class HelloDjangoAppConfig(AppConfig):
    name = 'HelloDjango'
```

### Question: Is creating a Django app in Visual Studio any different from creating an app on the command line?

Answer: Running the **Add** > **Django app** command or using **Add** > **New Item** with a Django app template produces the same files as the Django command `manage.py startapp <app_name>`. The benefit to creating the app in Visual Studio is that the app folder and all its files are automatically integrated into the project. You can use the same Visual Studio command to create any number of apps in your project.

## Step 2-2: Run the app from the Django project

At this point, if you run the project again in Visual Studio (using the toolbar button or **Debug** > **Start Debugging**), you still see the default page. No app content appears because you need to define an app-specific page and add the app to the Django project:

1. In the `HelloDjangoApp` folder, modify `views.py` to match the code below, which defines a view named "index":

    ```python
    from django.shortcuts import render
    from django.http import HttpResponse

    def index(request):
        return HttpResponse("Hello, Django!")
    ```

1. In the `BasicProject` folder (created in step 1), modify `urls.py` to at least match the following code (you can retain the instructive comments if you like):

    ```python
    from django.conf.urls import include, url
    import HelloDjangoApp.views

    # Django processes URL patterns in the order they appear in the array
    urlpatterns = [
        url(r'^$', HelloDjangoApp.views.index, name='index'),
        url(r'^home$', HelloDjangoApp.views.index, name='home'),
    ]
    ```

    Each URL pattern describes the views to which Django routes specific site-relative URLs (that is, the portion that follows "https://www.domain.com/"). The first entry in `urlPatterns` that starts with the regular expression `^$` is the routing for the site root, "/". The second entry, `^home$` specifically routes "/home". You can have any number of routings to the same view.

1. Run the project again to see the message "Hello, Django!" as defined by the view. Stop the server when you're done.

### Commit to source control

Because you've made changes to your code and have tested them successfully, now is a great time to review and commit your changes to source control. Later steps in this tutorial remind you of appropriate time to commit to source control again, and refer you back to this section.

1. Select the changes button along the bottom of Visual Studio (circles below), which navigates to **Team Explorer**.

    ![Source control changes button on the Visual Studio status bar](media/django/step02-source-control-changes-button.png)

1. In **Team Explorer**, enter a commit message like "Create initial Django app" and select **Commit All**. When the commit is complete, you see a message "Commit <hash> created locally. Sync to share your changes with the server." If you want to push changes to your remote repository, select **Sync**, then select **Push** under **Outgoing Commits**. You can also accumulate multiple local commits before pushing to remote.

    ![Push commits to remote in Team Explorer](media/django/step02-source-control-push-to-remote.png)

### Question: what is the 'r' prefix before the routing strings for?

Answer: The 'r' prefix on a string in Python means "raw," which instructs Python to not escape any characters within the string. Because regular expressions use many special characters, using the 'r' prefix makes those strings much easier to read than if they contained a number of '\' escape characters.

### Question: what do the ^ and $ characters mean in the URL routing entries?

Answer: In the regular expressions that define URL patterns, ^ means "start of line" and $ means "end of line," where again the URLs are relative to the site root (the part that follows "https://www.domain.com/"). The regular expression `^$` effectively means "blank" and therefore matches the full URL "https://www.domain.com/" (nothing added to the site root). The pattern `^home$` matches exactly "https://www.domain.com/home/". (Django doesn't use the trailing / in pattern matching.)

If you don't use a trailing $ in a regular expression, as with `^home`, then URL pattern matches *any* URL that begins with "home" such as "home", "homework", "homestead", and "home192837".

To experiment with different regular expressions, try online tools such as [regex101.com](https://regex101.com) at [pythex.org](http://www.pythex.org).

## Step 2-3: render a view using HTML

The `index` function that you have so far in `views.py` generates nothing more than a plain-text HTTP response for the page. Most real-world web pages, of course, respond with rich HTML pages that often incorporate live data. Indeed, the primary reason to define a view using a function is so you can generated that content dynamically.

Because the argument to `HttpResponse` is just a string, you can build up any HTML you like within a string. As a simple example, replace the `index` function with the following code, which generates an HTML response using dynamic content that's updated every time you refresh the page:

```python
from datetime import datetime

def index(request):
    now = datetime.now()

    html_content = "<html><head><title>Hello, Django</title></head><body>"
    html_content += "<strong>Hello Django!</strong> on " + now.strftime("%A, %d %B, %Y at %X")
    html_content += "</body></html>"

    return HttpResponse(html_content)
```

Run the project again to see a message like "**Hello Django!** on Monday, 16 April, 2018 at 16:28:10". Refresh the page to update the time and confirm that the content is being generated with each request. Stop the server when you're done.

## Step 2-4: render a view using a page template

Generating HTML in code works fine for very small pages, but as pages get more sophisticated you typically want to maintain the static HTML parts of your page (along with references to CSS and JavaScript files) as "page templates" into which you then insert dynamic, code-generated content. In the previous section, only the date and time from the `now.strftime` call is dynamic, which means all the other content can be placed in a page template.

A Django page template is a block of HTML that can contain any number of replacement tokens called "variables" that are delineated by `{{` and `}}`, as in `{{ content }}`. Django's templating module then replaces variables with dynamic content that you provide in code.

The following steps demonstrate the use of page templates:

1. Under the `BasicProject` folder, which contains the Django project's, open `settings.py` file and add the app name, "HelloDjangoApp", to the `INSTALLED_APPS` list. Adding the app to the list tells the Django project that there's a folder of that name containing an app:

    ```python
    INSTALLED_APPS = [
        'HelloDjangoApp',
        # Other entries...
    ]
    ```

1. Also in `settings.py`, make sure the the `TEMPLATES` object contains the following line (included by default), which instructs Django to look for templates in an installed app's `templates` folder:

    ```json
    'APP_DIRS': True,
    ```

1. In the `HelloDjangoApp` folder, open the `templates/index.html` page template file, to observe that it contains one variable, `{{ content }}`:

    ```html
    <html>
    <head><title></title></head>

    <body>

    {{ content }}

    </body>
    </html>
    ```

1. In the `HelloDjangoApp` folder, open `views.py` and rewrite the `index` function to use the template. First, add the necessary import statements to the top of the file:

    ```python
    from datetime import datetime        # Should already be present from step 2-2
    from django.shortcuts import render
    ```

    Then modify the `index` function as follows to use the `django.shortcuts.render` helper function, which provides a simplified interface for working with page templates:

    ```python
    def index(request):
        now = datetime.now()

        return render(
            request,
            "index.html",  # Relative path from the 'templates' folder to the template file
            {
                'content': "<strong>Hello Django!</strong> on " + now.strftime("%A, %d %B, %Y at %X")
            }
        )
    ```

    The first argument to `render`, as you can see, is the request object, followed by the relative path to the template file within the app's `templates` folder. Typically, a template file is named for the page that uses it, if appropriate. You can also organize templates into subfolders within `templates`, in which case you prepend folder names to the filename argument.

    The third argument is then a dictionary of variables that the template refers to. You can include objects in the dictionary, in which case a varaible in the template can refer to `{{ object.property }}`.

1. Run the project and observe the output. You should see the a similar message to that seen step 2-2, indicating that the template works.

    Observe, however, that the HTML you used in the `content` property renders only as plain text because the `render` function automatically escapes that HTML. Although you can get around escaping, you ideally should avoid using inline HTML in the first place. Formatting and styling are best kept in the page template, not in the code, and it's a simple matter to create additional variables where needed.

    For example, change `templates/index.html` to match the following markup, which adds a page title and keeps all formatting in the page template:

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

    Then write the `index` view function as follows, to provide values for all the variables in the page template:

    ```python
    def index(request):
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

1. Stop the server and restart the project, and observe that the page now renders properly.

    > [!Tip]
    > A shortcut to stopping and restarting the project is to use the **Debug** > **Restart** menu command (Ctrl+Shift+F5) or the restart button on the debugging toolbar:
    >
    > ![Restart button on the debugging toolbar in Visual Studio](media/debugging-restart-toolbar-button.png)

1. Commit your changes to source control and update your remote repository, if desired, as described under [step 2-2](#commit-to-source-control).

### Question: do page templates have to be in a separate file?

Answer: Although templates are usually maintained in separate HTML files, you can also use an inline template. Using a separate file is recommended, however, to maintain a clean separation between markup and code.

### Question: must templates use the .html file extension?

Answer: No, using the `.html` extension for page template files is entirely optional, because you always identify the exact relative path to the file in the second argument to the `render` function. However, Visual Studio (and other editors) typically give you features like code completion and syntax coloration with `.html` files, which outweighs the fact that page templates are not strictly HTML.

### Question: When I run the project, I see an error that the template cannot be found. What's wrong?

Answer: If you see errors that the template cannot be found, make sure you added the app to the Django project's `settings.py` in the `INSTALLED_APPS` list. Without that entry, Django won't know to look in the app's `templates` folder.

## Next steps

> [!div class="nextstepaction"]
> [Serve static files, add pages, and use template inheritance](learning-django-in-visual-studio-step-03-serve-static-files-and-add-pages.md)

## Going deeper

- For more capabilities of Django templates, such as includes and inheritance, see [The Django template language](https://docs.djangoproject.com/en/2.0/ref/templates/language/) in the Django documentation.
- [Regular expression training on inLearning (LinkedIn)](https://www.linkedin.com/learning/topics/regular-expressions)