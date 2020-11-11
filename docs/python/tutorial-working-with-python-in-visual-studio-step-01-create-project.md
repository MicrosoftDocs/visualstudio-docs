---
title: Python in Visual Studio tutorial step 1, create a project
titleSuffix: ""
description: Overview and step 1 of a core walkthrough of Python capabilities in Visual Studio, including prerequisites and creating a new Python project.
ms.date: 01/28/2019
ms.topic: tutorial
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.custom: seodec18
ms.workload:
  - python
  - data-science
---

# Tutorial: Work with Python in Visual Studio

Python is a popular programming language that is reliable, flexible, easy to learn, free to use on all operating systems, and supported by both a strong developer community and many free libraries. The language supports all manners of development, including web applications, web services, desktop apps, scripting, and scientific computing and is used by many universities, scientists, casual developers, and professional developers alike.

Visual Studio provides first-class language support for Python. This tutorial guides you through the following steps:

- [Step 0: Installation](tutorial-working-with-python-in-visual-studio-step-00-installation.md)
- [Step 1: Create a Python project (this article)](#step-1-create-a-new-python-project)
- [Step 2: Write and run code to see Visual Studio IntelliSense at work](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)
- [Step 3: Create more code in the Interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)
- [Step 4: Run the completed program in the Visual Studio debugger](tutorial-working-with-python-in-visual-studio-step-04-debugging.md)
- [Step 5: Install packages and manage Python environments](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md)
- [Step 6: Work with Git](tutorial-working-with-python-in-visual-studio-step-06-working-with-git.md)

[!INCLUDE[tutorial-prereqs](includes/tutorial-prereqs.md)]

## Step 1: Create a new Python project

A *project* is how Visual Studio manages all the files that come together to produce a single application, including source code, resources, configurations, and so on. A project formalizes and maintains the relationship between all the project's files as well as external resources that are shared between multiple projects. As such, projects allow your application to effortlessly expand and grow much easier than simply managing a project's relationships in ad hoc folders, scripts, text files, and even your own mind.

In this tutorial you begin with a simple project containing a single, empty code file.

1. In Visual Studio, select **File** > **New** > **Project** (**Ctrl**+**Shift**+**N**), which brings up the **New Project** dialog. Here you browse templates across different languages, then select one for your project and specify where Visual Studio places files.

1. To view Python templates, select **Installed** > **Python** on the left, or search for "Python". Using search is a great way to find a template when you can't remember its location in the languages tree.

    ![New project dialog with Python projects shown](media/vs-getting-started-python-01-new-project.png)

    Notice how Python support in Visual Studio includes a number of project templates, including web applications using the Bottle, Flask, and Django frameworks. For the purposes of this walkthrough, however, let's start with an empty project.

1. Select the **Python Application** template, specify a name for the project, and select **OK**.

1. After a few moments, Visual Studio shows the project structure in the **Solution Explorer** window (1). The default code file is open in the editor (2). The **Properties** window (3) also appears to show additional information for any item selected in **Solution Explorer**, including its exact location on disk.

    ![Solution Explorer with a Python project](media/vs-getting-started-python-02-windows.png)

1. Take a few moments to familiarize yourself with **Solution Explorer**, which is where you browse files and folders in your project.

    ![Solution Explorer expanded to show various features](media/vs-getting-started-python-03-solution-explorer.png)

    (1) Highlighted in bold is your project, using the name you gave in the **New Project** dialog. On disk, this project is represented by a *.pyproj* file in your project folder.

    (2) At the top level is a *solution*, which by default has the same name as your project. A solution, represented by a *.sln* file on disk, is a container for one or more related projects. For example, if you write a C++ extension for your Python application, that C++ project could reside within the same solution. The solution might also contain a project for a web service, along with projects for dedicated test programs.

    (3) Under your project you see source files, in this case only a single *.py* file. Selecting a file displays its properties in the **Properties** window. Double-clicking a file opens it in whatever way is appropriate for that file.

    (4) Also under the project is the **Python Environments** node. When expanded, you see the Python interpreters that are available to you. Expand an interpreter node to see the libraries that are installed into that environment (5).

    Right-click any node or item in **Solution Explorer** to access a menu of applicable commands. For example, the **Rename** command allows you to change the name of any node or item, including the project and the solution.

## Next step

> [!div class="nextstepaction"]
> [Write and run code](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)

## Go deeper

- [Python projects in Visual Studio](managing-python-projects-in-visual-studio.md).
- [Learn about the Python language on python.org](https://www.python.org)
- [Python for Beginners](https://www.python.org/about/gettingstarted/) (python.org)
