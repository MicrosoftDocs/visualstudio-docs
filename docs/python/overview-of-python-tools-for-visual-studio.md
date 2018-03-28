---
title: Overview of Python support in Visual Studio on Windows | Microsoft Docs
description: Summary of features available for Python in Visual Studio (also know as Python Tools for Visual Studio, PTVS), including questions and answers (FAQ) and feature support matrix across Visual Studio versions.
ms.custom:
ms.date: 03/27/2018
ms.reviewer:
ms.suite:
ms.technology: 
  - "devlang-python"
dev_langs:
  - "python"
ms.tgt_pltfrm:
ms.topic: "overview"
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Working with Python in Visual Studio (Windows)

Python is a popular programming language that is reliable, flexible, easy to learn, free to use on all operating systems, and supported by both a strong developer community and many free libraries. Python supports all manners of development, including web applications, web services, desktop apps, scripting, and scientific computing, and is used by many universities, scientists, casual developers, and professional developers alike. You can learn more about the language on [python.org](https://www.python.org) and [Python for Beginners](https://www.python.org/about/gettingstarted/).

Visual Studio on Windows is a powerful Python IDE. Visual Studio provides [open-source](https://github.com/Microsoft/ptvs) support for the Python language through the Python Development and Data Science workloads (Visual Studio 2017) and the free Python Tools for Visual Studio extension (Visual Studio 2015 and earlier). Python is not presently supported in Visual Studio for Mac, but is available on Mac and Linux through Visual Studio Code (see [questions and answers](#questions-and-answers)).

To get started:

- Follow the [installation instructions](installing-python-support-in-visual-studio.md) to set up the Python workload.
- Familiarize yourself with the Python capabilities of Visual Studio through the section in this article. You can also [Watch a video series (Microsoft Virtual Academy)](https://mva.microsoft.com/en-US/training-courses/python-tools-for-visual-studio-2017-18121) for an introduction to Python in Visual Studio (22 minutes total).
- Go through one or more of the Quickstarts to create a project. If you're unsure, start with [Create a project from a template](quickstart-02-python-in-visual-studio-project-from-template.md).
- Follow the [Working with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md) tutorial for a full end-to-end experience.

## Multiple interpreter support

Visual Studio's **Python Environments** window gives you a single place to manage all of your global Python environments, conda environments, and virtual environments. Visual Studio automatically detects installations of Python in standard locations, and allows you to configure custom installations. With each environment, you can easily manage packages, open an interactive window for that environment, and access environment folders.

For more information:

- Python-specific documentation:

  - [Managing Python environments](managing-python-environments-in-visual-studio.md)
  - [Python Environments window reference](python-environments-window-tab-reference.md)

## Rich editing, IntelliSense, and code comprehension

Visual Studio provides a first-class editing environment for Python, including syntax coloring, auto-complete across all your code and libraries, code formatting, signature help, refactoring, and linting. Visual Studio also provides unique features like class view, Go to Definition, Find All References, and code snippets. Direct integration with the [Interactive Window](#interactive-window) helps you quickly develop Python code that's already saved in a file.

For more information:

- Python-specific documentation

  - [Editing Python code](editing-python-code-in-visual-studio.md)
  - [Code formatting](formatting-python-code.md)
  - [Refactoring](refactoring-python-code.md)
  - [Linting](linting-python-code.md)

- General feature documentation: [Writing Code in the Code and Text Editor](../ide/writing-code-in-the-code-and-text-editor.md)

## Interactive Window

For every Python environment known to Visual Studio, you can easily open an interactive (REPL) window.

Visual Studio provides ability to easily highlight a portion of your code and send it to the Interactive Window.

For more information:

- Python-specific documentation: [Interactive Window](python-interactive-repl-in-visual-studio.md)

## Project system, and project and item templates

Visual Studio helps you manage the complexity of a project as it grows over time. A project is much more than a folder structure: it includes an understanding of how different files are used and how they relate to each other. Visual Studio helps you distinguish app code, test code, web pages, JavaScript, build scripts, and so on, which then enable file-appropriate features.

Project and item templates automate the process of setting up different types of projects and files, saving you valuable time and relieving you from managing intricate and error-prone details. Visual Studio provides templates for web, Azure, data science, console, and other types of projects, along with templates for files like Python classes, unit tests, Azure web configuration, HTML, and many more.

For more information:

- Python-specific documentation:

  - [Managing Python projects](managing-python-projects-in-visual-studio.md)
  - [Python project templates](managing-python-projects-in-visual-studio.md#project-templates)

- General feature documentation:

  - [Project and item templates](../ide/creating-project-and-item-templates.md#visual-studio-templates)
  - [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md)

## Full-featured debugging

One of Visual Studio's strengths is its powerful debugger. For Python in particular, Visual Studio includes Python/C++ mixed-mode debugging, remote debugging on Linux, remote debugging on Azure, debugging within the Interactive Window, and debugging Python unit tests.

For more information:

- Python-specific documentation:

  - [Debugging Python](debugging-python-in-visual-studio.md)
  - [Python/C++ mixed-mode debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md)
  - [Remote debugging on Linux](debugging-python-code-on-remote-linux-machines.md)
  - [Remote debugging on Azure](debugging-remote-python-code-on-azure.md)

- General feature documentation: [Feature Tour of the Visual Studio Debugger](../debugger/debugger-feature-tour.md)

## Profiling tools with comprehensive reporting

Profiling explores how time is being spent within your application. Visual Studio supports profiling with CPython-based interpreters and includes the ability to compare performance between different profiling runs.

For more information:

- Python-specific documentation: [Python profiling tools](profiling-python-code-in-visual-studio.md)
- General feature documentation: [Profiling Feature Tour](../profiling/profiling-feature-tour.md). (Not all Visual Studio profiling features are available for Python).

## Unit testing tools

Discover, run, and manage tests in Visual Studio Test Explorer, and easily debug unit tests.

For more information:

- Python-specific documentation: [Unit testing tools for Python](unit-testing-python-in-visual-studio.md)
- General feature documentation: [Unit test your code](../test/unit-test-your-code.md).

## IPython support

IPython in Visual Studio includes support for IPython/Jupyter in the REPL for inline plots, .NET, and Windows Presentation Foundation (WPF).

## Azure SDK for Python

The Python workload includes the [Azure SDK for Python](azure-sdk-for-python.md), which simplifies consuming Azure services from Windows, Mac OS X, and Linux apps.

## Python training on Microsoft Virtual Academy

|   |   |
|---|---|
| ![movie camera icon for video](../install/media/video-icon.png "Watch a video") | <ul><li>[Introduction to Programming with Python](https://mva.microsoft.com/en-US/training-courses/introduction-to-programming-with-python-8360?l=lqhuMxFz_8904984382)</li><li>[Python Beginner: Strings and Functions](https://mva.microsoft.com/en-US/training-courses/python-beginner-strings-and-functions-18015)</li><li>[Python Fundamentals: List and Loops](https://mva.microsoft.com/en-US/training-courses/python-fundamentals-lists-and-loops-18019)</li><li>[Top Python Questions](https://mva.microsoft.com/en-US/training-courses/python-tools-for-visual-studio-2017-18121)</li></ul> |

## Questions and answers

**Q. Is Python support available with Visual Studio for Mac?**

A. Not at this time, but you can upvote the request on [UserVoice](https://visualstudio.uservoice.com/forums/563332-visual-studio-for-mac/suggestions/18670291-python-tools-for-visual-studio-mac). The [Visual Studio for Mac](/visualstudio/mac/) documentation identifies the current types of development that it does support. In the meantime, Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

**Q. What can I use to build UI with Python?**

A. The main offering in this area is the [Qt Project](https://www.qt.io/qt-for-application-development/), with bindings for Python known as [PySide (the official binding)](http://wiki.qt.io/PySide) (also see [PySide downloads](https://download.qt.io/official_releases/pyside/.)) and [PyQt](https://wiki.python.org/moin/PyQt). At present, Python support in Visual Studio does not include any specific tools for UI development.

**Q. Can a Python project produce a stand-alone executable?**

A. Python is generally an interpreted language, with which code is run on demand in a suitable Python-capable environment such as Visual Studio and web servers. Visual Studio itself does not at present provide the means to create a stand-alone executable, which essentially means a program with an embedded Python interpreter. However, there are various means within the Python community to create executables as described on [StackOverflow](http://stackoverflow.com/questions/5458048/how-to-make-a-python-script-standalone-executable-to-run-without-any-dependency). CPython also supports being embedded within a native application, as described on the blog post, [Using CPython's Embeddable Zip File](https://blogs.msdn.microsoft.com/pythonengineering/2016/04/26/cpython-embeddable-zip-file/).

## Features matrix

Python features can be installed in the following editions of Visual Studio as described in the [installation guide](installing-python-support-in-visual-studio.md):

- [Visual Studio 2017 (all editions)](https://www.visualstudio.com/vs/)
- [Visual Studio 2015 (all editions)] (https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs)
- Visual Studio 2013 Community Edition
- Visual Studio 2013 Express for Web, Update 2 or higher
- Visual Studio 2013 Express for Desktop, Update 2 or higher
- Visual Studio 2013 (Pro edition or higher)
- Visual Studio 2012 (Pro edition or higher)
- Visual Studio 2010 SP1 (Pro edition or higher; .NET 4.5 required)

> [!Important]
> Features are fully supported and maintained for only the latest version of Visual Studio. Features are available in older versions but are not actively maintained.

| Python Support | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Multiple interpreters management | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Auto-detect popular interpreters | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Add custom interpreters | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Virtual Environments | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Pip/Easy Install | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

| Project System | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| New project from existing code | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Show all files | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Source control | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Git integration | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004;<sup>1</sup> | &#10007; |
<br/>

| Editing | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Syntax highlighting | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Auto-complete | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Signature help | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Quick info | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Object browser/class view | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Navigation bar | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Go to Definition | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Navigate to | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Find All References | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Auto indentation | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Code formatting | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Refactor - rename | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Refactor - extract method | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Refactor - add/remove import | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| PyLint | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

| Interactive Window | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Interactive Window | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| IPython with inline graphs | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

| Desktop | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Console/Windows application | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| IronPython WPF (with XAML designer) | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| IronPython Windows Forms | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

| Web | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Django web project | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004; |
| Bottle web project | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004; |
| Flask web project | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004; |
| Generic web project | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

| Azure | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Deploy to web site | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004;<sup>2</sup> |
| Deploy to web role | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>4</sup> | &#10004;<sup>4</sup> | &#10004;<sup>3</sup> | &#10007; |
| Deploy to worker role | ? | ? | ? | &#10007; | &#10004;<sup>4</sup> | &#10004;<sup>4</sup> | &#10004;<sup>3</sup> | &#10007; |
| Run in Azure emulator | ? | ? | ? | &#10007; | &#10004;<sup>4</sup> | &#10004;<sup>4</sup> | &#10004;<sup>3</sup> | &#10007; |
| Remote debugging | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>6</sup> | &#10004;<sup>8</sup> | &#10004;<sup>8</sup> | &#10007; |
| Server Explorer attach | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>7</sup> | &#10004;<sup>7</sup> | &#10007; | &#10007; |
<br/>

| Django templates | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Debugging | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004; |
| Auto-complete | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>5</sup> | &#10004;<sup>5</sup> | &#10004; | &#10004; |
| Auto-complete for CSS and JavaScript | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>5</sup> | &#10004;<sup>5</sup> | &#10007; | &#10007; |
<br/>

| Debugging | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Debugging | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Debugging without a project | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Debugging - attach to editing | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; |
| Mixed-mode debugging | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; |
| Remote debugging (Windows, Mac OS X, Linux) | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; |
| Debug interactive window | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
<br/>

<a name="matrix-profiling"></a>

| Profiling | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | ---|
| Profiling | &#10004; | &#10004; | &#10004; | &#10007; | &#10007; | &#10004; | &#10004; | &#10004; |
<br/>

| Test | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| --- | --- | --- | --- | --- | --- | --- | --- | --- |
| Test explorer | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; |
| Run test | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; |
| Debug test | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10007; |
<br/>

1. Git support for Visual Studio 2012 is available in the Visual Studio Tools for Git extension, available on the [Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/abafc7d6-dcaa-40f4-8a5e-d6724bdb980c).

1. Deployment to Azure Web Site requires [Azure SDK for .NET 2.1 - Visual Studio 2010 SP1](http://go.microsoft.com/fwlink/?LinkId=313855). Later versions don't support Visual Studio 2010.

1. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2012](http://go.microsoft.com/fwlink/?LinkId=323511) or later.

1. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

1. Django template editor in Visual Studio 2013 has some known issues that are resolved by installing Update 2.

1. Requires Windows 8 or later. Visual Studio 2013 Express for Web doesn't have the Attach to Process dialog, but Azure Web Site remote debugging is still possible using the Attach Debugger (Python) command in Server Explorer. Remote debugging requires [Azure SDK for .NET 2.3 - Visual Studio 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

1. Requires Windows 8 or later. Attach Debugger (Python) command in Server Explorer requires [Azure SDK for .NET 2.3 - Visual Studio 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

1. Requires Windows 8 or later.

## Additional resources

- [WFastCGI bridge between IIS and Python](https://pypi.python.org/pypi/wfastcgi) (python.org)
- [Free Python courses on Microsoft Virtual Academy](https://mva.microsoft.com/search/SearchResults.aspx#!q=python)
- [Top Python Questions at Microsoft Virtual Academy](https://aka.ms/mva-top-python-questions)
