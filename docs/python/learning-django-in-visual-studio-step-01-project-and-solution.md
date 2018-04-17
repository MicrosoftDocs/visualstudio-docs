---
title: Tutorial - Learning Django in Visual Studio, step 1
description: A walkthrough of Django basics in the context of Visual Studio projects, demonstrating the support Visual Studio provides for Django development.
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

# Tutorial step 1: Get started with the Django web framework in Visual Studio

[Django](https://www.djangoproject.com/) is a high-level Python framework designed for rapid, secure, and scalable web development. This tutorial explores the Django framework in the context of the project templates that Visual Studio provides to streamline the creation of Django-based web apps.

In this tutorial, you learn how to:

> [!div class="checklist"]
> - Create a basic Django project in a Git repository using the "Blank Django Web Project" template (step 1).
> - Create a Django app with one page and render that page using a template (step 2).
> - Serve static files, add pages, and use template inheritance (step 3).
> - Use the Django Web Project template to create an app with multiple pages and responsive design (step 4).
> - Authenticate users (step 5).
> - Use the Polls Django Web Project template to create an app that uses models, database migrations, and customizations to the administrative interface (step 6).

## Prerequisites

- Visual Studio 2017 with the Python workload installed. For instructions, see [Installing Python support in Visual Studio](installing-python-support-in-visual-studio.md).

Django project templates are also included with all earlier versions of Python Tools for Visual Studio, though details may differ from what's discussed in this tutorial especially those that use earlier versions of the Django framework.

### "Visual Studio projects" and "Django projects"

In Django terminology, a "Django project" is composed of several site-level configuration files along with one or more "apps" that you deploy to a web host to create a full web application. A Django project can contain multiple apps, and the same app can be in multiple Django projects.

A Visual Studio project, for its part, can contain the Django project along with multiple apps. For the sake of simplicity, whenever this tutorial refers to just a "project," it's referring to the Visual Studio project. When it refers to the "Django project" portion of the web application, it uses "Django project" specifically.

Over the course of this tutorial you'll create a single Visual Studio solution that contains three separate Django projects, each of which contains a single Django app. By keeping the projects in the same solution, you can easily switch back and forth between different files for comparison.

## Step 1-1: create a Visual Studio project and solution

When working with Django from the command line, you typically start a project by running the `django-admin startproject <project_name>` command. In Visual Studio, using the "Blank Django Web Project" template provides the same structure within a Visual Studio project and solution.

1. In Visual Studio, select **File** > **New** > **Project**, search for "Django", and select the **Blank Django Web Project** template. (The template is also found under **Python** > **Web** in the left-hand list.)

    ![New project dialog in Visual Studio for the Blank Django Web Project](media/django/step01-new-blank-project.png)

1. In the fields at the bottom of the dialog, enter the following information (as shown in the previous graphic), then select **OK**:

    - **Name**: set the name of the Visual Studio project to "BasicProject". This name is also used for the Django project.
    - **Location**: specify a location in which to create the Visual Studio solution and project.
    - **Solution**: leave this control set to default "Create new solution" option.
    - **Solution name**: set to "LearningDjango", which is appropriate for the solution as a container for multiple projects in this tutorial.
    - **Create directory for solution**: Leave set (the default).
    - **Create new Git repository**: Select this option (which is not set by default) so that Visual Studio creates a local Git repository when it creates the solution.

1. After a moment, Visual Studio prompts you with a dialog saying "This project requires external packages" (shown below) because the template includes a `requirements.txt` file referencing the latest Django 1.x package. (Select **Show required packages** to see the exact dependencies.) Select the option, **Install into a virtual environment**.

    ![Prompt saying This project requires external packages](media/django/step01-requirements-prompt.png)

1. An **Add Virtual Environment** dialog appears. Select **Create** to accept the defaults. (You can change the name of the virtual environment if you want, which just changes the name of its subfolder.)

1. Consent to administrator privileges if prompted, then be patient while Python creates the virtual environment. The process takes a few minutes because Visual Studio must download packages and build their wheels. You can see progress in the Visual Studio **Output** window. While you're waiting, you can also ponder the Q&A below.

### Question: Why do I want to create a virtual environment?

Answer: A virtual environment is a great way to isolate your app's exact dependencies. Such isolation avoids conflicts within a global Python environment, and aids both testing and collaboration. Over time, as you develop an app, you invariably bring in any number many helpful Python packages. By keeping these in a project-specific virtual environment, you can easily update the project's `requirements.txt` file that describes that environment, which is included in source control. When the project is copied to any other computers, including build servers, deployment servers, and other development computers, it's easy to recreate the environment using only `requirements.txt`. For more information, see [Using virtual environments](selecting-a-python-environment-for-a-project.md#using-virtual-environments).

## Step 1-2: examine the Git controls and publish to a remote repository

Because you selected the **Create new Git repository** in the **New Project** dialog, the project is already committed to source control as soon as the creation process is complete. Visual Studio indicates this fact through its Git controls on the bottom corner of its main window. From left to right, these controls show unpushed commits, uncommitted changes, the name of the repository, and the current branch:

![Git controls in the Visual Studio window](media/django/step01-git-controls.png)

Select the unpushed commits button (the up arrow with "2"), and Visual Studio opens its **Team Explorer** window, which provides easy options to publish the repository to Visual Studio Team Services, GitHub, or another remote repository.

![Team Explorer window showing available Git repository options for source control](media/django/step01-team-explorer.png)

You can choose whichever service you want for your own projects. This tutorial shows the use of GitHub, where the completed sample code for the tutorial is maintained in a repository named [python-sample-vs-learning-django](https://github.com/Microsoft/python-sample-vs-learning-django). When selecting any of the **Publish** controls, **Team Explorer** prompts you for more information. For example, when publishing the sample for this tutorial, the repository itself had to be created first, in which case we used the **Push to Remote Repository** option, copied in the repository's URL, and selected **Publish**.

![Team Explorer window for pushing to an existing remote repository](media/django/step01-push-to-github.png)

If you don't have an existing repository, the **Publish to GitHub** and **Push to Visual Studio Team Services** options let you create one directly from within Visual Studio.

As you work through this tutorial, get into the habit of periodically using the controls in Visual Studio to commit and push changes. This tutorial reminds you at appropriate points.

### Question: What are some advantages of using source control from the beginning of a project?

Answer: First of all, using source control from the start, especially if you also use a remote repository, provides a regular offsite backup of your project. Unlike maintaining a project just on a local file system, source control also provides a complete change history and the easy ability to revert a single file or the whole project to a previous state. That change history helps determine the cause of regressions (test failures). Furthermore, source control is essential if multiple people are working on a project, as it manages overwrites and provides conflict resolution. Finally, source control, which is fundamentally a form of automation, sets you up well for automating builds, testing, and release management. It's really the first step in using DevOps for a project, and because the barriers to entry are so low, there's really no reason to not use source control from the beginning.

For further discussion on source control as automation, see [The Source of Truth: The Role of Repositories in DevOps](https://msdn.microsoft.com/magazine/mt763232), an article in MSDN Magazine written for mobile apps it applies just as well to web apps.

## Step 1-3: examine the boilerplate code

Once project creation completes, examine the boilerplate Django project code (which is again the same as generated by the CLI command `django-admin startproject <project_name>`).

1. In your project root is `manage.py`, the Django command-line administrative utility that Visual Studio automatically sets as the project startup file. You run the utility on the command line using `python manage.py <command> [options]`, or use just `manage.py <command> [options]` from the Python interactive window in Visual Studio. You can also use `django-admin <command> [options]` or `python -m django <command> [options]`.

    Visual Studio provides convenient menu commands for common Django tasks. Right-click the project in **Solution Explorer** and select **Python** to see the list. We'll encounter a number of these in the course of this tutorial.

    ![Django commands on a Python project context menu](media/django/step01-django-commands-menu.png)

1. In your project is a folder named the same as the project. It contains the basic Django project files:

    - `__init.py`: an empty file that tells Python that this folder is a Python package.
    - `wsgi.py`: an entry point for WSGI-compatible web servers to serve your project. You typically leave this file as-is as it provides the hooks for production web servers.
    - `settings,py`: contains settings for Django project.
    - `urls.py`: contains a table of contents for the Django project.

    ![Django project files in Solution Explorer](media/django/step01-django-project-in-solution-explorer.png)

1. As noted earlier, the Visual Studio template also adds a `requirements.txt` file to your project specifying the Django package dependency. The presence of this file is what invites you to create a virtual environment when first creating the project.

### Question: Can Visual Studio generate a requirements.txt file from a virtual environment after I install other packages?

Answer: Yes. Expand the **Python Environments** node, right-click your virtual environment, and select the **Generate requirements.txt** command. It's good to use this command periodically as you modify the environment, and commit changes to `requirements.txt` to source control along with any other code changes that depend on that environment. If you set up continuous integration on a build server, you should generate the file and commit changes whenever you modify the environment.

## Step 1-4: run the empty Django project

1. In Visual Studio, select **Debug** > **Start debugging** (F5) or use the **Web Server** button on the toolbar (the browser you see may vary):

    ![Run web server toolbar button in Visual Studio](media/django/run-web-server-toolbar-button.png)

1. Running the server means running the command `manage.py runserver <port>`, which starts Django's built-in development server. If Visual Studio says "Failed to start debugger" with a message about having no startup file, right-click `manage.py` in **Solution Explorer** and select **Set as Startup File**.

1. When you start the server, you see a console window open that also displays the server log. Visual Studio automatically opens a browser to `http://localhost:<port>`. Because the Django project has no apps, however, Django shows only a default page to acknowledge that what you have so far is working fine:

    ![Django project default view](media/django/step01-first-run-success.png)

1. When you're done, stop the server by closing the console window, or by using the **Debug** > **Stop Debugging** command in Visual Studio.

### Question: What's the difference between using the Debug menu commands and the server commands on the project's Python submenu?

Answer: In addition to the **Debug** menu commands and toolbar buttons, you can also launch the server using the **Python** > **Run server** or **Python** > **Run debug server** commands on the project's context menu. Both commands open a console window in which you see the local URL (localhost:port) for the running server. However, you must manually open a browser with that URL, and running the debug server does not automatically start the Visual Studio debugger. You can attach a debugger to the running process later, if you want, using the **Debug** > **Attach to Process** command.

## Next steps

At this point, the basic Django project does not contain any apps. You create an app in the next step. Because you typically work with Django apps more than the Django project, you won't need to know much more about the boilerplate files at present.

> [!div class="nextstepaction"]
> [Create a Django app with views and templates](learning-django-in-visual-studio-step-02-create-an-app.md)

## Going deeper

- Django project code: [Writing your first Django app, part 1](https://docs.djangoproject.com/en/2.0/intro/tutorial01/) (docs.djangoproject.com)
- Administrative utility: [django-admin and manage.py](https://docs.djangoproject.com/en/2.0/ref/django-admin/) (docs.djangoproject.com)
