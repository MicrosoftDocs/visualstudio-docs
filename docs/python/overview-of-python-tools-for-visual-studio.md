---
title: Python support in Visual Studio on Windows
titleSuffix: ""
description: Explore Python Tools for Visual Studio (PTVS) and other Python features in Visual Studio to edit, debug, test, and publish your Python applications.
ms.date: 04/18/2024
ms.topic: overview
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python
dev_langs:
 - Python

#customer intent: As a developer, I want support for Python in Visual Studio so that I can edit, debug, test, and publish my Python applications.
---

# Python support in Visual Studio on Windows

Python is a popular programming language that's reliable, flexible, easy to learn, free to use on all operating systems, and supported by both a strong developer community and many free libraries. Python supports all manner of development, including web applications, web services, desktop apps, scripting, and scientific computing. Scientists, casual developers, professional developers, and many universities alike use Python for programming. You can learn more about the language on [python.org](https://www.python.org) and [Python for Beginners](https://www.python.org/about/gettingstarted/).

Visual Studio is a powerful Python IDE on Windows. Visual Studio provides [open-source](https://github.com/Microsoft/ptvs) support for the Python language through the **Python Development** and **Data Science** workloads (Visual Studio 2017 and later) and the free Python Tools for Visual Studio extension (Visual Studio 2015 and earlier). [Tour the Visual Studio IDE](../ide/quickstart-ide-orientation.md) to familiarize yourself with the IDE features for writing and editing Python code.

Visual Studio Code is available on Mac and Linux. For more information, see [questions and answers](#questions-and-answers).

To get started:

- Follow the [installation instructions](installing-python-support-in-visual-studio.md) to set up the Python workload.

- Familiarize yourself with the Python capabilities of Visual Studio through the sections in this article.

- Go through one or more of the Quickstarts to create a project. If you're unsure, start with [Quickstart: Open and run Python code in a folder](quickstart-05-python-visual-studio-open-folder.md) or [Create a web app with Flask](../ide/quickstart-python.md?toc=/visualstudio/python/toc.json&bc=/visualstudio/python/_breadcrumb/toc.json).

- Follow the [Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md) tutorial for a full end-to-end experience.

## Support for multiple interpreters

Visual Studio's **Python Environments** window gives you a single place to manage all of your global Python environments, conda environments, and virtual environments. Visual Studio automatically detects installations of Python in standard locations, and allows you to configure custom installations. With each environment, you can easily manage packages, open an interactive window for that environment, and access environment folders.

::: moniker range="vs-2019"

:::image type="content" source="media/environments/environments-expanded-view-2019.png" alt-text="Screenshot that shows the expanded view of the Python Environments window in Visual Studio 2019." border="false" lightbox="media/environments/environments-expanded-view-2019.png":::

::: moniker-end
:::moniker range=">=vs-2022"

:::image type="content" source="media/environments/environments-expanded-view-2022.png" alt-text="Screenshot that shows the expanded view of the Python Environments window in Visual Studio 2022." border="false" lightbox="media/environments/environments-expanded-view-2022.png":::

:::moniker-end

Use the **Open interactive window** command to run Python interactively within the context of Visual Studio. Use the **Open in PowerShell** command to open a separate command window in the folder of the selected environment. In that command window, you can run any python script.

For more information:

- [Manage Python environments](managing-python-environments-in-visual-studio.md)
- [Python Environments reference](python-environments-window-tab-reference.md)

## Rich editing, IntelliSense, and code comprehension

Visual Studio provides a first-class Python editor, including syntax coloring, autocomplete across all your code and libraries, code formatting, signature help, refactoring, linting, and type hints. Visual Studio also provides unique features like class view, **Go to Definition**, **Find All References**, and code snippets. Direct integration with the [Interactive window](#interactive-window) helps you quickly develop existing Python code in a file.

:::image type="content" source="media/code-editing-completions-simple.png" alt-text="Screenshot that shows code completions for Python code in Visual Studio." border="false":::

For more information:

- [Edit Python code](editing-python-code-in-visual-studio.md)
- [Format code](formatting-python-code.md)
- [Refactor code](refactoring-python-code.md)
- [Use a linter](linting-python-code.md)
- [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md)

## Interactive window

For every Python environment known to Visual Studio, you can easily open the same interactive (REPL) environment for a Python interpreter directly within Visual Studio, rather than using a separate command prompt. You can easily switch between environments as well. To open a separate command prompt, select your desired environment in the **Python Environments** window, then select the **Open in PowerShell** command as explained earlier in the [Support for multiple interpreters](#support-for-multiple-interpreters) section.

:::moniker range="<=vs-2019"

:::image type="content" source="media/interactive-window.png" alt-text="Screenshot that shows the expanded view of the Python interactive window in Visual Studio 2019.":::

:::moniker-end
:::moniker range=">=vs-2022"

:::image type="content" source="media/interactive-window-2022.png" alt-text="Screenshot that shows the expanded view of the Python interactive window in Visual Studio 2022." border="false" lightbox="media/interactive-window-2022.png":::

:::moniker-end

Visual Studio also provides tight integration between the Python code editor and the **Interactive** window. The **Ctrl**+**Enter** keyboard shortcut conveniently sends the current line of code (or code block) in the editor to the **Interactive** window, then moves to the next line (or block). **Ctrl**+**Enter** lets you easily step through code without having to run the debugger. You can also send selected code to the **Interactive** window with the same keystroke, and easily paste code from the **Interactive** window into the editor. Together, these capabilities allow you to work out details for a segment of code in the **Interactive** window and easily save the results in a file in the editor.

Visual Studio also supports IPython/Jupyter in the REPL, including inline plots, .NET, and Windows Presentation Foundation (WPF).

For more information:

- [Python Interactive window](python-interactive-repl-in-visual-studio.md)
- [IPython in Visual Studio](interactive-repl-ipython.md)

## Project system, and project and item templates

Visual Studio helps you manage the complexity of a project as it grows over time. A Visual Studio *project* is more than a folder structure. A project aids in the understanding of how different files are used and how they relate to each other. Visual Studio helps you distinguish app code, test code, web pages, JavaScript, build scripts, and so on, which then enable file-appropriate features. A Visual Studio *solution* helps you manage multiple related projects, such as a Python project and a C++ extension project.

> [!NOTE]
> In Visual Studio 2019 and later, you can open a folder containing Python code and run that code without creating a Visual Studio project or solution file. For more information, see [Quickstart: Open and run Python code in a folder](quickstart-05-python-visual-studio-open-folder.md). Keep in mind that there are benefits to using a project file, as explained in this section.

The following image shows an example of a Visual Studio solution containing both Python and Flask projects in **Solution Explorer**.

:::image type="content" source="media/projects-solution-explorer-two-projects.png" alt-text="Screenshot that shows a Visual Studio solution containing both Python and Flask projects in Solution Explorer." border="false" lightbox="media/projects-solution-explorer-two-projects.png":::

Project and item templates automate the process of setting up different types of projects and files. The templates save you valuable time and relieve you from managing intricate and error-prone details. Visual Studio provides templates for web, Azure, data science, console, and other types of projects. You can find templates for files like Python classes, unit tests, Azure web configuration, HTML, and even Django apps.

:::image type="content" source="media/project-and-item-templates.png" alt-text="Screenshot of python project and item templates in Visual Studio" border="false" lightbox="media/project-and-item-templates.png":::

For more information:

- [Manage Python projects](managing-python-projects-in-visual-studio.md)
- [Item templates reference](python-item-templates.md)
- [Python project templates](managing-python-projects-in-visual-studio.md#project-templates)
- [Work with C++ and Python](working-with-c-cpp-python-in-visual-studio.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md#visual-studio-templates)
- [Solutions and projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md)

## Full-featured debugging

One of Visual Studio's strengths is its powerful debugger. For Python in particular, Visual Studio includes Python/C++ [mixed-mode debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md), remote debugging on Linux, debugging within the **Interactive** window, and debugging Python unit tests.

:::image type="content" source="media/debugging-exception-popup.png" alt-text="Screenshot  of the Visual Studio debugger for Python showing an exception popup dialog.":::

In Visual Studio 2019 and later, you can run and debug code without having a Visual Studio project file. See [Quickstart: Open and run Python code in a folder](quickstart-05-python-visual-studio-open-folder.md) for an example.

For more information:

- [Debug Python](debugging-python-in-visual-studio.md)
- [Python/C++ mixed-mode debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md)
- [Remote debugging on Linux](debugging-python-code-on-remote-linux-machines.md)
- [Feature tour of the Visual Studio Debugger](../debugger/debugger-feature-tour.md)

## Profiling tools with comprehensive reporting

Profiling explores how time is being spent within your application. Visual Studio supports profiling with CPython-based interpreters and includes the ability to compare performance between different profiling runs.

:::image type="content" source="media/profiling-results.png" alt-text="Screenshot that shows the Visual Studio profiler results for a Python project." border="false" lightbox="media/profiling-results.png":::

For more information:

- [Python profiling tools](profiling-python-code-in-visual-studio.md)
- [Visual Studio Profiling feature tour](../profiling/profiling-feature-tour.md)

## Unit testing tools

Discover, run, and manage tests in Visual Studio **Test Explorer**, and easily debug unit tests.

:::image type="content" source="media/unit-test-debugging.png" alt-text="Screenshot that shows debugging output for a Python unit test in Visual Studio." border="false":::

For more information:

- [Unit testing tools for Python](unit-testing-python-in-visual-studio.md)
- [Unit test your code](../test/unit-test-your-code.md)

## Azure SDK for Python

The Azure libraries for Python simplify consuming Azure services from Windows, macOS X, and Linux apps. You can use them to create and manage Azure resources, and to connect to Azure services.

For more information, see [Azure SDK for Python](/azure/python/) and [Azure libraries for Python](/azure/developer/python/sdk/azure-sdk-overview).

## Questions and answers

**Q. Is Python support available with Visual Studio for Mac?**

A. Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

**Q. What can I use to build UI with Python?**

A. The main offering in this area is the [Qt Project](https://www.qt.io/qt-for-application-development/) with bindings for Python known as [PySide (the official binding)](https://wiki.qt.io/PySide) (also see [PySide downloads](https://download.qt.io/official_releases/pyside/.)) and [PyQt](https://wiki.python.org/moin/PyQt). Python support in Visual Studio doesn't include any specific tools for UI development.

**Q. Can a Python project produce a stand-alone executable?**

A. Python is generally an interpreted language, where code is run on demand in a suitable Python-capable environment such as Visual Studio and web servers. Visual Studio doesn't currently provide the means to create a stand-alone executable, which essentially means a program with an embedded Python interpreter. However, the Python community offers different means to create executables as described on [Stack Overflow](https://stackoverflow.com/questions/5458048/how-to-make-a-python-script-standalone-executable-to-run-without-any-dependency). CPython also supports being embedded within a native application, as described on the blog post, [Using CPython's embeddable zip file](https://devblogs.microsoft.com/python/cpython-embeddable-zip-file/).

## Related content

- [Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md) 
- [Quickstart: Open and run Python code in a folder](quickstart-05-python-visual-studio-open-folder.md)
- [Python Interactive window](python-interactive-repl-in-visual-studio.md)
