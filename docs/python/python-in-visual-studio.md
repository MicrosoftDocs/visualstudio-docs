---
title: "Python in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 33f4f6fb-0ae4-4234-9df2-531f2d3af17f
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# Working with Python in Visual Studio

Python is a popular programming language that is reliable, flexible, easy to learn, free to use on all operating systems, and supported by a strong developer community and many free libraries. Python supports all manners of development, including web applications, web services, desktop apps, scripting, and scientific computing and is used by many universities, scientists, casual developers, and professional developers alike. You can learn more about the language on [python.org](https://www.python.org) and [Python for Beginners](https://www.python.org/about/gettingstarted/).

Visual Studio provides with [open-source](https://github.com/Microsoft/ptvs) support for the Python language through the Python workload (Visual Studio 2017) and the free Python Tools for Visual Studio extension (Visual Studio 2015 and earlier). 

Follow our [installation instructions](installation.md) to set up the Python workload, then use the links below to learn more about Python-related features as well as the capabilities of Visual Studio itself.

| Feature | Description | General Visual Studio Documentation | 
| --- | --- | --- |
| [Visual Studio project system](python-projects.md) | Implicitly picks up a folder structure of Python code while allowing explicit control to identify app code, test code, web pages, JavaScript, build scripts, etc. | [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md) |
| [Project templates](python-projects.md#project-templates) | Quickly creates project structure for console, web, Azure, data science, and other types of projects | [Visual Studio Templates](../ide/creating-project-and-item-templates.md#visual-studio-templates) |
| Multiple interpreter support | Supports various versions of CPython and IronPython. | n/a |
| IPython support | Includes support for IPython/Jupyter in the REPL for inline plots, .NET, and Windows Presentation Foundation (WPF). | n/a |
| [Rich editing, IntelliSense, and code comprehension](code-editing.md) | Includes syntax coloring, auto-complete across all your code and libraries, [code formatting](code-formatting.md), signature help, class view, Go to Definition, Find All References, code snippets, [refactoring](code-refactoring.md), [PyLint](code-pylint.md), and more. | [Writing Code in the Code and Text Editor](../ide/writing-code-in-the-code-and-text-editor.md) |
| [Interactive Window](interactive-repl.md) | Provides a quick REPL experience for Python with the ability to easily highlight a portion of your code and send it to the Interactive Window. | n/a |
| [Full-featured debugging](debugging.md) | Debugging can be done with or without a Visual Studio project, including the ability to an existing executable, [Python/C++ mixed-mode debugging](debugging-mixed-mode.md), [remote debugging](debugging-cross-platform-remote.md) to Windows/Linux/Mac, [remote debugging to Azure](debugging-azure-remote.md), and debugging within the Interactive Window. | [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md) |
| [Profiling tools with comprehensive reporting](profiling.md) | Explores how time is being spent within your application, including the ability to compare performance between different profiling runs. | [Profiling Tools](../profiling/profiling-tools.md) (not all Visual Studio profiling features are available for Python) |
| [Unit testing tools](unit-testing.md) | Discover, run, and manage tests in Visual Studio Test Explorer, and easily debug unit tests. | [Unit Test Your Code](../test/unit-test-your-code.md) |

The Python workload also includes the [Azure SDK for Python](azure-sdk-for-python.md), which simplifies consuming Azure services, with support for Windows, Mac OS X, and Linux.

Our series of [getting started and deep dive videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff) on YouTube give you an overview of the primary features.

[![Python Tools Videos](media/video-general.png)](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)

## Questions and Answers

**Q. What can I use to build UI with Python?**

A. The main offering in this area is the [Qt Project](https://www.qt.io/qt-for-application-development/), with bindings for Python known as [PySide (the official binding)](http://wiki.qt.io/PySide) (also see [PySide downloads](https://download.qt.io/official_releases/pyside/.))and [PyQt](https://wiki.python.org/moin/PyQt). At present, Python support in Visual Studio does not include any specific tools for UI development.

**Q. Can a Python project produce a stand-alone executable?**

A. Python is generally an interpreted language, with code run on demand in a suitable Python-capable environment such as Visual Studio and web servers. Visual Studio itself does not at present provide the means to create a stand-alone executable, which essentially means a program with an embedded Python interpreter. However, there are various means within the Python community to do this as described on [StackOverflow](http://stackoverflow.com/questions/5458048/how-to-make-a-python-script-standalone-executable-to-run-without-any-dependency). CPython also supports being embedded within a native application, as described on the blog post, [Using CPython's Embeddable Zip File](https://blogs.msdn.microsoft.com/pythonengineering/2016/04/26/cpython-embeddable-zip-file/).

## Features Matrix

Python support can be installed in the following editions of Visual Studio as described in the [installation guide](installation.md):

- [Visual Studio 2017 Preview](https://www.visualstudio.com/vs/preview)
- [Visual Studio 2015 (all editions)] (https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs)
- [Visual Studio 2013 Community Edition] (https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
- [Visual Studio 2013 Express for Web, Update 2 or higher](http://www.microsoft.com/en-us/download/details.aspx?id=40747)
- [Visual Studio 2013 Express for Desktop, Update 2 or higher](http://www.microsoft.com/en-us/download/details.aspx?id=40787)
- Visual Studio 2013 (Pro edition or higher)
- Visual Studio 2012 (Pro edition or higher)
- Visual Studio 2010 SP1 (Pro edition or higher; .NET 4.5 required)

Supported features by Visual Studio version and edition:

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
| Web deploy to web site | &#10004; | &#10004; | &#10004; | &#10007; | &#10004; | &#10004; | &#10004; | &#10004;<sup>2</sup> |
| Web deploy to web role | &#10004; | &#10004; | &#10004; | &#10007; | &#10004;<sup>4</sup> | &#10004;<sup>4</sup> | &#10004;<sup>3</sup> | &#10007; |
| Web deploy to worker role | ? | ? | ? | &#10007; | &#10004;<sup>4</sup> | &#10004;<sup>4</sup> | &#10004;<sup>3</sup> | &#10007; |
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

1. Git support for VS 2012 is available in the Visual Studio Tools for Git extension, available on the [Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/abafc7d6-dcaa-40f4-8a5e-d6724bdb980c).

2. Deployment to Azure Web Site requires [Azure SDK for .NET 2.1 - VS 2010 SP1](http://go.microsoft.com/fwlink/?LinkId=313855).  Later versions don't support VS 2010.

3. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2012](http://go.microsoft.com/fwlink/?LinkId=323511) or later.

4. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

5. Django template editor in Visual Studio 2013 has some known issues that are resolved by installing Update 2.

6. Requires Windows 8 or later. Visual Studio 2013 Express for Web doesn't have the Attach to Process dialog, but Azure Web Site remote debugging is still possible using the Attach Debugger (Python) command in Server Explorer. This requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

7. Requires Windows 8 or later. Attach Debugger (Python) command in Server Explorer requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

8. Requires Windows 8 or later.

## Additional resources

- [Writing Kinect games with Python using PyKinect](https://github.com/Microsoft/PTVS/wiki/PyKinect) (GitHub wiki)
- [WFastCGI bridge between IIS and Python](https://pypi.python.org/pypi/wfastcgi) (python.org)
