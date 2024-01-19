---
title: Python in Visual Studio tutorial step 1, create a project
titleSuffix: ""
description: Overview and step 1 of a core walkthrough of Python capabilities in Visual Studio, including prerequisites and creating a new Python project.
author: cwebster-99
ms.author: cowebster
ms.subservice: python
ms.topic: tutorial
ms.date: 01/19/2024
manager: jmartens
ms.custom: vs-acquisition

# CustomerIntent: As a developer, I want to reformat Python code in Visual Studio so I can adjust settings like code spacing and line wrapping.

---

# Tutorial: Work with Python in Visual Studio

In this tutorial, you learn how to work with Python in Visual Studio. Python is a popular programming language that's reliable, flexible, easy to learn, and free to use on all operating systems. Python is supported by a strong developer community and many free libraries. The language supports all kinds of development, including web applications, web services, desktop apps, scripting, and scientific computing. Many universities, scientists, casual developers, and professional developers use Python. Visual Studio provides first-class language support for Python.

This tutorial guides you through a six-step process:

> [!div class="checklist"]
> * [Step 1: Create a Python project (this article)](#step-1-create-a-new-python-project)
> * [Step 2: Write and run code to see Visual Studio IntelliSense at work](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)
> * [Step 3: Create more code in the Interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)
> * [Step 4: Run the completed program in the Visual Studio debugger](tutorial-working-with-python-in-visual-studio-step-04-debugging.md)
> * [Step 5: Install packages and manage Python environments](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md)
> * [Step 6: Work with Git](tutorial-working-with-python-in-visual-studio-step-06-working-with-git.md)

This article covers the tasks in **Step 1**. You create a new project and review the UI elements visible in Solution Explorer.

[!INCLUDE[tutorial-prereqs](includes/tutorial-prereqs.md)]

## Step 1: Create a new Python project

A *project* is how Visual Studio manages all the files that come together to produce a single application. Application files include source code, resources, and configurations. A project formalizes and maintains the relationships among all the project's files. The project also manages external resources that are shared between multiple projects. A project allows your application to effortlessly expand and grow. Using projects is easier than managing relationships by hand in unplanned folders, scripts, text files, and your memory.

This tutorial begins with a simple project containing a single, empty code file.

::: moniker range="<=vs-2019"

1. In Visual Studio, select **File** > **New** > **Project** to open the **New Project** dialog. You can also use the keyboard shortcut Ctrl + Shift + N. In the dialog, you can browse templates across different languages, select a template for your project, and specify where Visual Studio places files.

1. To view Python templates, select **Installed** > **Python** on the left menu, or search for "Python." The search option is a great way to find a template when you can't remember its location in the languages tree.

   :::image type="content" source="media/vs-getting-started-python-01-new-project.png" alt-text="Screenshot showing the Create a new project dialog box with Python project templates." lightbox="media/vs-getting-started-python-01-new-project.png":::

   Python support in Visual Studio includes several project templates, including web applications using the Bottle, Flask, and Django frameworks. For the purposes of this walkthrough, however, let's start with an empty project.

1. Select the **Python Application** template, specify a name for the project, and select **OK**.

::: moniker-end

::: moniker range=">=vs-2022"

1. In Visual Studio, select **File** > **New** > **Project** or use the keyboard shortcut Ctrl + Shift + N. The **Create a new project** screen opens, where you can search and browse templates across different languages.
   
1. To view Python templates, search for *python*. Search is a great way to find a template when you can't remember its location in the languages tree.

   :::image type="content" source="media/vs-2022/working-in-python-01-create-project-2022.png" alt-text="Screenshot showing the Create a new project dialog box in Visual Studio 2022 with Python project templates." lightbox="media/vs-2022/working-in-python-01-create-project-2022.png":::

   Python web support in Visual Studio includes several project templates, such as web applications in the Bottle, Flask, and Django frameworks. When you install Python with the Visual Studio Installer, select **Python Web Support** under **Optional** to install these templates. For this tutorial, start with an empty project.

1. Select the **Python Application** template, and select **Next**.

1. On the **Configure your new project** screen, specify a name and file location for the project, and then select **Create**.

::: moniker-end

After a few moments, your new project opens in Visual Studio:

::: moniker range="<=vs-2019"

   :::image type="content" source="media/vs-getting-started-python-02-windows.png" alt-text="Screenshot showing the new project open in Visual Studio." lightbox="media/vs-getting-started-python-02-windows.png":::

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/getting-started-python-windows.png" alt-text="Screenshot showing the new project open in Visual Studio 2022." lightbox="media/vs-2022/getting-started-python-windows.png":::

::: moniker-end

Here's what you see:

- **(1)** The Visual Studio **Solution Explorer** window shows the project structure.
- **(2)** The default code file opens in the editor.
- **(3)** The **Properties** window shows more information for the item selected in **Solution Explorer**, including its exact location on disk.

## Review elements in Solution Explorer

Take some time to familiarize yourself with **Solution Explorer**, where you can browse files and folders in your project.

::: moniker range="<=vs-2019"

:::image type="content" source="media/vs-getting-started-python-03-solution-explorer.png" alt-text="Screenshot of Solution Explorer expanded to show features." lightbox="media/vs-getting-started-python-03-solution-explorer.png":::

::: moniker-end

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/getting-started-python-solution-explorer.png" alt-text="Screenshot of Solution Explorer expanded to show features for Visual Studio 2022." lightbox="media/vs-2022/getting-started-python-solution-explorer.png":::

::: moniker-end

- **(1)** At the top level is the *solution*, which by default has the same name as your project. A solution, which is shown as a **.sln** file on disk, is a container for one or more related projects. For example, if you write a C++ extension for your Python application, that C++ project can be in the same solution. The solution might also contain a project for a web service, and projects for dedicated test programs.
   
- **(2)** Your project is highlighted in bold and uses the name you entered in the **Create a new project** dialog. On disk, this project is represented by a **.pyproj** file in your project folder.
   
- **(3)** Under your project you see source files. In this example, you have only a single **.py** file. Selecting a file displays its properties in the **Properties** window. If you don't see the **Properties** window, select the wrench icon in the **Solution Explorer** banner. Double-clicking a file opens it in whatever way is appropriate for that file.
   
- **(4)** Also under the project is the **Python Environments** node. Expand the node to show the available Python interpreters.
   
- **(5)** Expand an interpreter node to see the libraries installed in that environment.
   
Right-click any node or item in **Solution Explorer** to show a context menu of applicable commands. For example, **Rename** lets you change the name of a node or item, including the project and the solution.

## Next step

> [!div class="nextstepaction"]
> [Step 2: Write and run code](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)

## Related content

- [Python projects in Visual Studio](managing-python-projects-in-visual-studio.md)
- [Learn about the Python language on python.org](https://www.python.org)
- [Python for Beginners](https://www.python.org/about/gettingstarted/) (python.org)
