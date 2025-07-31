---
title: Django in Visual Studio tutorial Step 5, authentication
titleSuffix: ""
description: Step 5 of a core walkthrough of Django capabilities in Visual Studio, specifically the authentication features provided in the Django Web Project template.
ms.date: 04/18/2024
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python
ms.custom: sfi-image-nochange

# CustomerIntent: As a developer, I want to create Django web applications in Visual Studio so I can use the authentication features included with the Django Web Project template.
---

# Tutorial: Authenticate users with Django in Visual Studio

This article presents Step 5 in the tutorial series _Work with the Django web framework in Visual Studio_.

Authentication is a common requirement for web apps. The **Django Web Project** template in Visual Studio provides all the necessary modules for authentication in the Django project's _settings.py_ file. Step 4 in this tutorial series creates a Django web app by using this template. In Step 5, you explore the authentication capabilities of the template and work with the features in the running app. 

In Step 5 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Explore authentication flow in the Django Web Project template in Visual Studio
> - Examine code that supports the authentication process
> - Modify code to enable access to Django administrator interfaces
> - Run the Django web app and use authentication features 

## Prerequisites

- A Visual Studio solution and a Django web app based on the **Django Web Project** template (_DjangoWeb_). [Step 4: Use the full Django Web Project template](learn-django-in-visual-studio-step-04-full-django-project-template.md) describes how to create this app.

- The Django web app must have a super user (administrator) account. [Step 4 (Create Django super user)](learn-django-in-visual-studio-step-04-full-django-project-template.md#create-django-super-user) describes how to create the super user credentials.

- Review the [Prerequisites](learn-django-in-visual-studio-step-01-project-and-solution.md#prerequisites) section in Step 1 of this tutorial series for details about Django template versions, Visual Studio projects versus Django projects, and Python development on Mac.

## Explore authentication flow

This section explains the default authentication flow provided by the **Django Web Project** template for a Django web app.

1. In Visual Studio, select **Debug** > **Start Debugging** (**F5**) to start the Django web app (_DjangoWeb_).

1. When the app opens in the browser, notice the **Log in** option at the right in the navigation bar:

   :::image type="content" source="media/django/step-05-login-control.png" alt-text="Screenshot that shows the Log in option on the navigation bar in the running Django web app." lightbox="media/django/step-05-login-control.png":::

   The running Django app has a navigation bar with three page options, **Home**, **About**, and **Contact**, and a **Log in** option. The authentication configuration allows any user to see the content on the "Home," "About," and "Contact" pages. 
   
1. For authenticated access to the Django web app, a designated super user can use the **Log in** option, which opens the "Log in" page:

   :::image type="content" source="media/django/step-05-login-page.png" alt-text="Screenshot that shows the Log in authentication page for the super user in the running Django web app." lightbox="media/django/step-05-login-page.png":::

1. After the super user signs in, they can access restricted page views for the site and complete administration tasks:

   :::image type="content" source="media/django/step-05-super-user-interface.png" alt-text="Screenshot that shows one of the page views available to the Django super user and the updated navigation bar with the Log out option." lightbox="media/django/step-05-super-user-interface.png":::

1. The super user can use the **Log off** option to sign out of the Django web app and return to the "Home" page of the Django web app as an unauthenticated user.

In the following sections, you modify the authentication configuration to support Django administrative site access for the super user.

## Examine authentication code

Now that you understand the general authentication features of a Django web app, you're ready to examine the underlying code provided by the **Django Web Project** template:

1. In **Solution Explorer**, expand the project's _app/templates/app_ folder. The following steps review several files in this folder.

1. Open the base template file, _layout.html_. Scroll to the `<div class="navbar ...>` element and locate the `{% include app/loginpartial.html %}` tag.

   The `{% include %}` tag instructs Django's template system to pull in the contents of the included file at this point in the containing template.

1. Open the _loginpartial.html_ file. Observe how this template uses the conditional tag `{% if user.is_authenticated %}` along with an `{% else %}` tag to render different UI elements depending on whether the user is authenticated:

    ```html
    {% if user.is_authenticated %}
    <form id="logoutForm" action="/logout" method="post" class="navbar-right">
        {% csrf_token %}
        <ul class="nav navbar-nav navbar-right">
            <li><span class="navbar-brand">Hello {{ user.username }}!</span></li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
        </ul>
    </form>

    {% else %}

    <ul class="nav navbar-nav navbar-right">
        <li><a href="{% url 'login' %}">Log in</a></li>
    </ul>

    {% endif %}
    ```

1. When you start the app, no super user is authenticated and the template code renders only the **Log in** link. The link targets the site relative "login" path specified in the Django project's URL file (_DjangoWeb/DjangoWeb/urls.py_), as described in [Step 4 (Examine URL route patterns)](learn-django-in-visual-studio-step-04-full-django-project-template.md#examine-url-route-patterns). The "login" route is mapped to the `django.contrib.auth.views.login` view and the view receives the following data:

    ```python
    {
        'template_name': 'app/login.html',
        'authentication_form': app.forms.BootstrapAuthenticationForm,
        'extra_context':
        {
            'title': 'Log in',
            'year': datetime.now().year,
        }
    }
    ```

    This code defines three properties:
    
    - `template_name` identifies the template for the "Log in" page defined in the _app/login.html_ file. Remember, this link is site relative. The full folder path is _app/templates/app/login.html_.
    
    - `extra_context` adds information to the default context data given to the template. In this case, the information includes a "Log in" title, along with the date, time, and year.
    
    - `authentication_form` specifies a form class to use with the login procedure. In the template, this property value appears as the `form` object. The default value is `AuthenticationForm` (from `django.contrib.auth.views`), but the Visual Studio project template instead uses the form defined in the project's _app/forms.py_ file:

        ```python
        from django import forms
        from django.contrib.auth.forms import AuthenticationForm
        from django.utils.translation import ugettext_lazy as _

        class BootstrapAuthenticationForm(AuthenticationForm):
            """Authentication form which uses bootstrap CSS."""
            username = forms.CharField(max_length=254,
                                    widget=forms.TextInput({
                                        'class': 'form-control',
                                        'placeholder': 'User name'}))
            password = forms.CharField(label=_("Password"),
                                    widget=forms.PasswordInput({
                                        'class': 'form-control',
                                        'placeholder':'Password'}))
        ```

       The form class derives from `AuthenticationForm` and specifically overrides the username and password fields to add placeholder text. The Visual Studio template includes this explicit code on the assumption that you likely want to customize the form, such as adding password strength validation.

1. When user interaction with the app opens the "Log in" page, the app renders the _login.html_ template. The variables `{{ form.username }}` and `{{ form.password }}` render the `CharField` forms from the `BootstrapAuthenticationForm` class. There's also a built-in section to show validation errors, and a ready-made element for social logins if you choose to add those services:

    ```html
    {% extends "app/layout.html" %}

    {% block content %}

    <h2>{{ title }}</h2>
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <form action="." method="post" class="form-horizontal">
                    {% csrf_token %}
                    <h4>Use a local account to log in.</h4>
                    <hr />
                    <div class="form-group">
                        <label for="id_username" class="col-md-2 control-label">User name</label>
                        <div class="col-md-10">
                            {{ form.username }}
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="id_password" class="col-md-2 control-label">Password</label>
                        <div class="col-md-10">
                            {{ form.password }}
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <input type="hidden" name="next" value="/" />
                            <input type="submit" value="Log in" class="btn btn-default" />
                        </div>
                    </div>
                    {% if form.errors %}
                    <p class="validation-summary-errors">Please enter a correct user name and password.</p>
                    {% endif %}
                </form>
            </section>
        </div>
        <div class="col-md-4">
            <section id="socialLoginForm"></section>
        </div>
    </div>

    {% endblock %}
    ```

1. When the user selects **Log in** on the page form, Django attempts to authenticate the credentials, such as the super user's credentials:

   - If authentication fails, the user remains on the "Log in" page and the `form.errors` tag is set to true:

      :::image type="content" source="media/django/step-05-incorrect-credentials.png" alt-text="Screenshot that shows the message when the user enters incorrect credentials in the Django sign in process.":::

   - If authentication succeeds, Django opens the relative URL in the `next` field, `<input type="hidden" name="next" value="/" />`, which in this case is the "Home" page (`/`).

1. When the app renders the "Home" page after the user is authenticated, the `user.is_authenticated` property is true when the _loginpartial.html_ template is rendered. In this case, the navigation bar shows a **Hello (username)** message and the **Log off** option replaces the **Log in** option: 

   :::image type="content" source="media/django/step-05-logoff-control.png" alt-text="Screenshot that shows the updated navigation bar for the authenticated user with the Hello message and Log off option.":::

   You can use the `user.is_authenticated` property in other parts of the app code to check authentication.

## Access Django administrator interfaces

To check whether the authenticated user is authorized to access specific resources, you need to retrieve user-specific permissions from your database.

The super user or administrator, in particular, is authorized to access the built-in Django administrator interfaces by using the site relative URLs `/admin/` and `/admin/doc/`. For more information, see [Using the Django authentication system](https://docs.djangoproject.com/en/5.0/topics/auth/default/#permissions-and-authorization) (Django docs).

To enable access to the Django administrator interfaces, follow these steps:

1. Install the `docutils` Python package into your environment. For instructions, see [Install packages for the Python environment](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md#install-packages-for-the-python-environment).

1. In **Solution Explorer**, expand the Django project folder, _DjangoWeb/DjangoWeb/_. The following steps update several files in this folder.

1. Open the Django project's _urls.py_ file and modify the contents as follows:

   1. At the top of the file, add the following package import for URLs to the end of the current list:

      ```python
      from django.conf.urls import include
      ```

   1. After the import list, add the following statement:

      ```python
      admin.autodiscover()
      ```

   1. Locate the `urlpatterns` definition, and add the following path entry _before_ the `'admin/'` entry:

      ```python
      path('admin/doc/', include('django.contrib.admindocs.urls')),
      ```

1. Open the Django project's _settings.py_ file and locate the `INSTALLED_APPS` collection. Add the following entry immediately _after_ the `app` entry:

    ```python
    'django.contrib.admindocs',
    ```

1. Stop and restart the Django web app.

1. In the URL address field of the browser, change the page view of the app to the `/admin/` or `/admin/doc/` route. These pages provide the super user with access to Django administrative tasks like creating user or group accounts, changing the password, and viewing Django documentation:

   :::image type="content" source="media/django/step-05-super-user-documentation.png" alt-text="Screenshot that shows an example page view for Django documentation for the authenticated super user in the Django web app." lightbox="media/django/step-05-super-user-documentation.png":::

## Explore log off behavior

There are two ways the super user can log off and end the authenticated session. The Django web app includes the **Log off** option on the navigation bar and the Django administrative site provides the **Log Out** option.

### Log out from Django administrative site

If the super user is viewing pages on the Django administrative site, they can select **Log out** on the site navigation bar. The browser refreshes to show the "Logged off" page for the site:

:::image type="content" source="media/django/step-05-site-logged-out.png" alt-text="Screenshot that shows the Logged out page after the super user logs out of the Django administrative site." lightbox="media/django/step-05-site-logged-out.png":::

On this page, the user has two options, **Home** and **Log in again**. Both options return the user to the "Home" page for the Django administrative site (/admin), where the user is prompted to reenter their credentials. 
   
:::image type="content" source="media/django/step-05-site-login-dialog.png" alt-text="Screenshot that shows the Log in dialog for the Django administrative site." lightbox="media/django/step-05-site-login-dialog.png":::

### Log off from Django web app

If the super user is viewing pages in the Django web app, such as "About" or "Contact," they can select **Log off** on the Django web app navigation bar. The log off behavior is minimal. It simply ends the authenticated session and browses the user back to the app "Home" page.

You can rework the log off behavior so it's more informative for the user:

1. In **Solution Explorer**, expand the project's _app/templates/app_ folder, and open the _loginpartial.html_ file.

1. In the template file, notice that the **Log off** link simply does an HTTP POST (`action="/logout" method="post"`) operation to the site relative URL path "/login" (`href="{% url 'login' %}"`).

   ```html
   {% if user.is_authenticated %}
   <form id="logoutForm" action="/logout" method="post" class="navbar-right">
      {% csrf_token %}
      <ul class="nav navbar-nav navbar-right">
         <li><span class="navbar-brand">Hello {{ user.username }}!</span></li>
         <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
      </ul>
   </form>

   {% else %}

   <ul class="nav navbar-nav navbar-right">
      <li><a href="{% url 'login' %}">Log in</a></li>
   </ul>

   {% endif %}
   ```
    
   The built-in view `django.contrib.auth.views.logout` function handles this log out process.

   The current behavior doesn't display any UI that lets the user know they're logged off. The process simply browses the user back to the Django web app "Home" page according to the `'logout/'` path pattern defined in the Django project's URL file (_DjangoWeb/DjangoWeb/urls.py_):

   ```python
    path('logout/', LogoutView.as_view(next_page='/'), name='logout'),
   ```

   To display a more informative log off confirmation, you can create a "Log off" page for the app.

1. In the _app/templates/app_ folder, create a new HTML template file named _loggedoff.html_.

1. Add the following content to the new template file:

   ```html
   {% extends "app/layout.html" %}
   {% block content %}
   <h3>You have been logged off</h3>
   {% endblock %}
   ```

1. In the Django project's URL file, _DjangoWeb/DjangoWeb/urls.py_, change the URL pattern for the `'logout/'` path as follows:

    ```python
    path('logout/', LogoutView.as_view(template_name='app/loggedoff.html'), name='logout'),
    ```

   The updated code adds a `template_name` property to work with the new HTML template for the "Logged off" page.

1. Stop and restart the Django web app. Sign in again, and then select **Log off**. This time, the app shows a more informative message to the user to confirm they're logged off:

   :::image type="content" source="media/django/step-05-logged-off-page.png" alt-text="Screenshot that shows the updated log off behavior for the Django web app  with a message on the Log off page." lightbox="media/django/step-05-logged-off-page.png" :::

1. Stop the server and close the application browser windows.

## Save project to source control

If you've been committing your Visual Studio solution to source control throughout the course of this tutorial series, now is a good time to do another commit. Follow the instructions in [Step 2 (commit changes to source control)](learn-django-in-visual-studio-step-02-create-an-app.md#commit-changes-to-source-control) in this tutorial series.

Your solution should match the tutorial source code on GitHub: [Microsoft/python-sample-vs-learning-django](https://github.com/Microsoft/python-sample-vs-learning-django).

### Use {% csrf_token %} tag in form elements

The `{% csrf_token %}` tag includes Django's built-in [cross-site request forgery (csrf) protection](https://docs.djangoproject.com/en/5.0/ref/csrf/) (Django docs). You usually add this tag to any element that involves POST, PUT, or DELETE request methods, such as a form. The template rendering function (`render`) then inserts the necessary protection.

## Tutorial review

Congratulations on completing this tutorial on Django in Visual Studio.

In this tutorial, you learned how to:

- Build different types of Django projects by using various templates in Visual Studio
- Create a Django web app with multiple pages
- Use templates to create different routes and page views 
- Serve static files, add pages, and use template inheritance
- Provide authenticated access to restricted app pages and features and Django administrative interfaces

## Related content

- [User authentication in Django](https://docs.djangoproject.com/en/5.0/topics/auth/) (docs.djangoproject.com)
- [Tutorial source code on GitHub (Microsoft/python-sample-vs-learning-django)](https://github.com/Microsoft/python-sample-vs-learning-django)
