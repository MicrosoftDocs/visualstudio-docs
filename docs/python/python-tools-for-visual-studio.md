---
title: "Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "2/14/2017"
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

# Python Tools for Visual Studio

Python is a popular programming language that is reliable, flexible, easy to learn, free to use on all operating systems, and supported by a strong developer community and many free libraries. Python supports for all manners of development, including web applications, web services, desktop apps, scripting, and scientific computing and is used by many universities, scientists, casual developers, and professional developers alike. You can learn more about the language on [python.org]()https://www.python.org) and [Python for Beginners](https://www.python.org/about/gettingstarted/).

The Python Tools for Visual Studio (PTVS) is a free, [open-source](https://github.com/Microsoft/ptvs) extension for Visual Studio that brings the [development experience of Visual Studio](../ide/visual-studio-ide.md) to Python development. 

Follow our [installation instructions](installation.md) to get set up with PTVS, then use the links below to learn more about PTVS features as well as the capabilities of Visual Studio itself.

| PTVS Feature | Description | General Visual Studio Documentation |
| [Visual Studio project system](python-projects-in-visual-studio.md) | Implicitly picks up a folder structure of Python code while allowing explicit control to identify app code, test code, web pages, JavaScript, build scripts, etc. |[] Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md) |
| [Project templates](python-projects-in-visual-studio.md#project-templates) | Quickly creates project structure for console, web, Azure, data science, and other types of projects | [Visual Studio Templates](../ide/creating-project-and-item-templates.md#visual-studio-templates) |
| Multiple interpreter support | Supports various versions of CPython, IronPython, and IPython, including support for IPython with data visualizations, .NET, and Windows Presentation Foundation (WPF). | n/a |
| [Rich editing, IntelliSense, and code comprehension](editing-code.md) | Includes syntax coloring, auto-complete across all your code and libraries, [code formatting](formatting-code.md), signature help, class view, Go to Definition, Find All References, code snippets, [refactoring](code-refactoring.md), [PYLint](pylint.md), and more. | [Writing Code in the Code and Text Editor](../ide/writing-code-in-the-code-and-text-editor.md) |
| [Interactive Window](interactive-python-repl.md) | Provides a quick REPL experience for Python with the ability to easily highlight a portion of your code and send it to the Interactive Window. | |
| [Full-featured debugging](debugging.md) | Debugging can be done with or without a Visual Studio project, including the ability to an existing executable, [Python/C++ mixed-mode debugging](mixed-mode-debugging.md), [remote debugging](cross-platform-remote-debugging.md) to Windows/Linux/Mac, [remote debugging to Azure](azure-remote-debugging.md), and debugging within the Interactive Window. | [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md) |
| [Profiling tools with comprehensive reporting](profiling.md) | Explores how time is being spent within your application, including the ability to compare performance between different profiling runs. | [Profiling Tools](../profiling/profiling-tools.md) (not all Visual Studio profiling features are available for Python) |
| [Unit testing tools](unit-testing.md) | Discover, run, and manage tests in Visual Studio Test Explorer, and easily debug unit tests. | [Unit Test Your Code](../test/unit-test-your-code.md) |

The Python Tools for Visual Studio also include the [Azure SDK for Python](azure-sdk-for-python.md), which simplifies consuming Azure services, with support for Windows, Mac OS X, and Linux.

Also see our series of [getting started and deep dive videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff) on YouTube, along with the [Installation and features demo (27 min)](https://www.youtube.com/watch?v=JNNAOypc6Ek).


> [!Tip]
> Python is an excellent language for scientific computing. In addition to all the Python data-scientist libraries, the Python Tools for Visual Studio support IPython and IPython Notebooks, which can be hosted in Azure. We recommend obtaining IPython and scientific computing libraries (matplotlib, scipy, numpy, etc.) from [University of California, Irvine](http://www.lfd.uci.edu/~gohlke/pythonlibs/#scipy-stack).

## Features Matrix

PTVS can be installed in the following editions of Visual Studio:

- [Visual Studio 2015 (all editions)] (https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs)
- [Visual Studio 2013 Community Edition] (https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)
- [Visual Studio 2013 Express for Web, Update 2 or higher](http://www.microsoft.com/en-us/download/details.aspx?id=40747)
- [Visual Studio 2013 Express for Desktop, Update 2 or higher](http://www.microsoft.com/en-us/download/details.aspx?id=40787)
- Visual Studio 2013 (Pro edition or higher)
- Visual Studio 2012 (Pro edition or higher)
- Visual Studio 2010 SP1 (Pro edition or higher; .NET 4.5 required)

Supported features by Visual Studio version and edition:

| Python Support | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Multiple interpreters management | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; | &#10004; |
| Auto-detect popular interpreters | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Add custom interpreters | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Virtual Environments | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Pip/Easy Install | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |

| Project System | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| New project from existing code | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Show all files | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Source control | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Git integration | Yes | Yes | Yes | Yes | Yes | Yes | Yes<sup>1</sup> | &#10007; |

| Editing | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Syntax highlighting | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Auto-complete | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Signature help | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Quick info | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Object browser/class view | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Navigation bar | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Go to Definition | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Navigate to | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Find All References | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Auto indentation | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Code formatting | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Refactor - rename | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Refactor - extract method | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Refactor - add/remove import | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| PYLint | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |

| Interactive Window | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Interactive Window | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| IPython with inline graphs | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |

| Desktop | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Console/Windows application | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| IronPython WPF (with XAML designer) | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| IronPython Windows Forms | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |

| Web | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Djano web project | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes |
| Bottle web project | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes |
| Flask web project | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes |
| Generic web project | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes |

| Azure | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Web deploy to web site | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes<sup>2</sup> |
| Web deploy to web role | Yes | Yes | Yes | No | Yes<sup>4</sup> | Yes<sup>4</sup> | Yes<sup>3</sup> | No |
| Web deploy to worker role | ? | ? | ? | No | Yes<sup>4</sup> | Yes<sup>4</sup> | Yes<sup>3</sup> | No |
| Run in Azure emulator | ? | ? | ? | No | Yes<sup>4</sup> | Yes<sup>4</sup> | Yes<sup>3</sup> | No |
| Remote debugging | ? | ? | ? | No | Yes<sup>6</sup> | Yes<sup>8</sup> | Yes<sup>8</sup> | No |
| Server Explorer attach | ? | ? | ? | No | Yes<sup>7</sup> | Yes<sup>7</sup> | No | No |

| Django templates | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Debugging | Yes | Yes | Yes | No | Yes | Yes | Yes | Yes |
| Auto-complete | Yes | Yes | Yes | No | Yes<sup>5</sup> | Yes<sup>5</sup> | Yes | Yes |
| Auto-complete for CSS and JavaScript | ? | ? | ? | No | Yes<sup>5</sup> | Yes<sup>5</sup> | No | No |

| Debugging | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Debugging | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Debugging without a project | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Debugging - attach to editing | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes |
| Mixed-mode debugging | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Remote debugging (Windows, Mac OS X, Linux) | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes |
| Debug interactive window | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |

| Profiling | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Profiling | ? | ? | ? | No | No | Yes | Yes | Yes |

| Test | 2017 | 2015 | 2013 Comm | 2013 Desktop | 2013 Web | 2013 Pro+ | 2012 Pro+ | 2010 SP1 Pro+ |
| Test explorer | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Run test | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |
| Debug test | Yes | Yes | Yes | Yes | Yes | Yes | Yes | No |



1. Git support for VS 2012 is available in the Visual Studio Tools for Git extension, available on the [Visual Studio Gallery](http://visualstudiogallery.msdn.microsoft.com/abafc7d6-dcaa-40f4-8a5e-d6724bdb980c).

2. Deployment to Azure Web Site requires [Azure SDK for .NET 2.1 - VS 2010 SP1](http://go.microsoft.com/fwlink/?LinkId=313855).  Later versions don't support VS 2010.

3. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2012](http://go.microsoft.com/fwlink/?LinkId=323511) or later.

4. Support for Azure Web Role and Worker Role requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

5. Django template editor in Visual Studio 2013 has some known issues that are resolved by installing Update 2.

6. Requires Windows 8 or later. Visual Studio 2013 Express for Web doesn't have the Attach to Process dialog, but Azure Web Site remote debugging is still possible using the Attach Debugger (Python) command in Server Explorer. This requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

7. Requires Windows 8 or later. Attach Debugger (Python) command in Server Explorer requires [Azure SDK for .NET 2.3 - VS 2013](http://go.microsoft.com/fwlink/?LinkId=323510) or later.

8. Requires Windows 8 or later.
