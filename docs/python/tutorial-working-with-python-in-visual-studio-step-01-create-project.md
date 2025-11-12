---
title: "Tutorial: Create a Project Python in Visual Studio"
titleSuffix: ""
description: Explore step 1 of a tutorial about Python capabilities in Visual Studio, including prerequisites and creating a new Python project.
author: cwebster-99
ms.author: cowebster
ms.subservice: python
ms.topic: tutorial
ms.date: 11/11/2025
manager: mijacobs
ms.custom: vs-acquisition

# CustomerIntent: As a developer, I want to create Python applications and projects in Visual Studio so I can support my Python development needs.
---

# Part 1: Work with Python in Visual Studio

This article is the first step in a six-part tutorial series that demonstrates how to work with Python in Visual Studio. Python is a popular programming language that's reliable, flexible, easy to learn, and free to use on all operating systems. A strong developer community and many free libraries provide robust support for working with Python. The language supports all kinds of development, including web applications, web services, desktop apps, scripting, and scientific computing. Many universities, scientists, casual developers, and professional developers use Python. Visual Studio provides first-class language support for Python.

The six parts in the tutorial series include:

- [Step 1: Create a Python project (this article)](#create-a-new-python-project)
- [Step 2: Write and run Python code in Visual Studio](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)
- [Step 3: Use the Interactive REPL window](tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)
- [Step 4: Run code in the Visual Studio debugger](tutorial-working-with-python-in-visual-studio-step-04-debugging.md)
- [Step 5: Install packages in your Python environment](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md)
- [Step 6: Work with Git in Visual Studio](tutorial-working-with-python-in-visual-studio-step-06-working-with-git.md)

In Step 1 of the tutorial, you learn how to:

> [!div class="checklist"]
> - Create a Python application project in Visual Studio
> - Manage your Python project files in Solution Explorer

[!INCLUDE[tutorial-prereqs](includes/tutorial-prereqs.md)]

## Create a new Python project

A *project* is how Visual Studio manages all the files that come together to produce a single application. Application files include source code, resources, and configurations. A project formalizes and maintains the relationships among all the project's files. The project also manages external resources that are shared between multiple projects. A project allows your application to effortlessly expand and grow. Using projects is easier than managing relationships by hand in unplanned folders, scripts, text files, and your memory.

This tutorial begins by creating a simple project that contains a single, empty code file.

::: moniker range="visualstudio"
1. In Visual Studio, select **File** > **New** > **Project** or use the keyboard shortcut **Ctrl**+**Shift**+**N**. The **Create a new project** screen opens, where you can search and browse templates across different languages.

1. To view Python templates, search for *python*. Search is a great way to find a template when you can't remember its location in the languages tree.

   :::image type="content" source="media/visualstudio/tutor-python-1-create-project.png" alt-text="Screenshot showing the Create a new project dialog in Visual Studio. Python project templates are visible." lightbox="media/vs-2022/tutor-python-1-create-project-2022.png":::

   Python web support in Visual Studio includes several project templates, such as web applications in the Bottle, Flask, and Django frameworks. When you install Python with the Visual Studio Installer, select **Python Web Support** under **Optional** to install these templates. For this tutorial, start with an empty project.

1. Select the **Python Application** template, and select **Next**.

1. On the **Configure your new project** screen, specify a name and file location for the project, and then select **Create**.

:::moniker-end
::: moniker range="<=vs-2019"

1. In Visual Studio, select **File** > **New** > **Project** to open the **New Project** dialog. You can also use the keyboard shortcut **Ctrl**+**Shift**+**N**. In the dialog box, you can browse templates across different languages, select a template for your project, and specify where Visual Studio places files.

1. To view Python templates, select **Installed** > **Python** on the left menu, or search for *Python*. The search option is a great way to find a template when you can't remember its location in the languages tree.

   :::image type="content" source="media/tutor-python-1-create-project.png" alt-text="Screenshot showing the Create a new project dialog box with Python project templates." lightbox="media/tutor-python-1-create-project.png":::

   Python support in Visual Studio includes several project templates, including web applications using the Bottle, Flask, and Django frameworks. For the purposes of this walkthrough, however, let's start with an empty project.

1. Select the **Python Application** template, specify a name for the project, and select **OK**.

::: moniker-end
::: moniker range="vs-2022"

1. In Visual Studio, select **File** > **New** > **Project** or use the keyboard shortcut **Ctrl**+**Shift**+**N**. The **Create a new project** screen opens, where you can search and browse templates across different languages.

1. To view Python templates, search for *python*. Search is a great way to find a template when you can't remember its location in the languages tree.

   :::image type="content" source="media/vs-2022/tutor-python-1-create-project-2022.png" alt-text="Screenshot showing the Create a new project dialog box in Visual Studio with Python project templates." lightbox="media/vs-2022/tutor-python-1-create-project-2022.png":::

   Python web support in Visual Studio includes several project templates, such as web applications in the Bottle, Flask, and Django frameworks. When you install Python with the Visual Studio Installer, select **Python Web Support** under **Optional** to install these templates. For this tutorial, start with an empty project.

1. Select the **Python Application** template, and select **Next**.

1. On the **Configure your new project** screen, specify a name and file location for the project, and then select **Create**.

::: moniker-end

After a few moments, your new project opens in Visual Studio:

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/tutor-python-1-environment-windows.png" alt-text="Screenshot that shows the new project open in Visual Studio." lightbox="media/tutor-python-1-environment-windows.png":::

:::moniker-end

::: moniker range="<=vs-2019"

:::image type="content" source="media/tutor-python-1-environment-windows.png" alt-text="Screenshot showing the new project open in Visual Studio." lightbox="media/tutor-python-1-environment-windows.png":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/tutor-python-1-environment-windows-2022.png" alt-text="Screenshot showing the new project open in Visual Studio 2022." lightbox="media/vs-2022/tutor-python-1-environment-windows-2022.png":::

::: moniker-end

Here's what you see:

- **(1)**: The Visual Studio **Solution Explorer** window shows the project structure.
- **(2)**: The default code file opens in the editor.
- **(3)**: The **Properties** window shows more information for the item selected in **Solution Explorer**, including its exact location on disk.

## Review elements in Solution Explorer

Take some time to familiarize yourself with **Solution Explorer**. This window in Visual Studio is where you can browse files and folders in your project.

:::moniker range="visualstudio"

:::image type="content" source="media/visualstudio/tutor-python-1-solution-explorer.png" alt-text="Screenshot that shows Solution Explorer." lightbox="media/tutor-python-1-solution-explorer.png":::
     
:::moniker-end

::: moniker range="<=vs-2019"

:::image type="content" source="media/tutor-python-1-solution-explorer.png" alt-text="Screenshot of Solution Explorer expanded to show features." lightbox="media/tutor-python-1-solution-explorer.png":::

::: moniker-end
::: moniker range="vs-2022"

:::image type="content" source="media/vs-2022/tutor-python-1-solution-explorer-2022.png" alt-text="Screenshot of Solution Explorer expanded to show features for Visual Studio 2022." lightbox="media/vs-2022/tutor-python-1-solution-explorer-2022.png":::

::: moniker-end

1. In **Solution Explorer** (**1**), notice the top-level item in the structure. This item is your Visual Studio _solution_. By default, your solution name is the same as your project.

   A solution, which is shown as an _.sln_ file on disk, is a container for one or more related projects. For example, if you write a C++ extension for your Python application, that C++ project can be in the same solution. The solution might also contain a project for a web service, and projects for dedicated test programs.

1. Locate the item directly under the solution name. This item is your project (**2**). Your project name is the name you entered in the **Create a new project** dialog. Visual Studio uses bold to identify the currently selected project in your solution.

   On disk, a _.pyproj_ file in your project folder represents the project.

1. Toggle the **Expand/Collapse** arrow next to the project name to view your project source files. 

   Visual Studio uses bold to identify which file is the _Start File_ for the program. In this example, you have only a single _.py_ file (**3**).

1. To view the properties for a file in the **Properties** window, select the file in **Solution Explorer**.

   If you don't see the **Properties** window, select the wrench icon in the **Solution Explorer** banner. Double-clicking a file opens it in whatever way is appropriate for that file.

1. Under your project node, locate the **Python Environments** node **(4)**. Expand the node to show the available Python interpreters.

1. Under the **Python Environments** node, expand an interpreter node to see the libraries installed in that environment (**5**).

Right-click any node or item in **Solution Explorer** to show a context menu of applicable commands. For example, **Rename** lets you change the name of a node or item, including the project and the solution.

## Next step

> [!div class="nextstepaction"]
> [Step 2: Write and run Python code](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md)
