---
title: "Getting Started with Python | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
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
# Getting Started with Python
The Python Tools for Visual Studio (PTVS), is a free, [open-source](https://github.com/Microsoft/ptvs) plug-in for Visual Studio that a powerful Python development experience.  
  
## Python the Language
  
Python is a popular programming language that is used by many universities, scientists, app scripters, casual developers, and professional developers, working on applications, web sites, and cloud services.

As a programming language, Python is:
  
- Reliable.
- Generally useful for scripting quick programs, app scripting, desktop apps, web servers, web services, and scientific computing.
- Easy to learn and has a good design to encourage good coding (many universities use it for introductory programming courses).
- Flexible, supporting imperative, functional, and object-oriented programming styles.
- Free and open source.
- Runs well on all major operating systems.  
- Supported by many free, useful, and well-designed libraries.  
- Supported by lots of documentation, samples, and a strong developer community.  

To learn more about the language, start with [Python for Beginners](https://www.python.org/about/gettingstarted/) on python.org.

To install Python itself, visit [http://python.org/download/](http://python.org/download/).
 
  
## Python Tools for Visual Studio
  
The Python Tools for Visual Studio, which you can install from [visualstudio.com](https://www.visualstudio.com/en-us/explore/python-vs), provide the following features:  
  
- Support for multiple interpreters: various versions of CPython, IronPython, and IPython  
- A project system that implicitly picks up a folder structure of Python code, and also allows explicit control so you can identify app code, test code, web pages, JavaScript, build scripts, and so on.  
- Project templates for console, web, Azure, data science, and other types of projects.    
- The Azure SDK for Python (see below)    
- Rich editing and code comprehension features including syntax coloring, auto-complete  across all your code and libraries, signature help, class view, Go to Definition, Find All References, refactoring, and more.    
- An Interactive (REPL) Window
- IPython with data visualizations.
- Support for IronPython and .NET/WPF.    
- Rich debugging without a Visual Studio project, the ability to an existing executable, mixed-mode debugging, remote debugging to Windows/Linux/Mac, and debugging within the Interactive Window.   
- Profiling tools.  
- Testing tools.  
  
The following resources will help you get started:

- [Installation guide](https://github.com/Microsoft/PTVS/wiki/PTVS-Installation)    
- [Getting started and deep dive short videos](https://www.youtube.com/playlist?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff)  
- Installation and features demo (27 min)](https://www.youtube.com/watch?v=JNNAOypc6Ek)  
- [Documentation](https://github.com/Microsoft/PTVS/wiki)  
  
  
## Azure SDK for Python
  
The Azure SDK for Python, which supports Windows, Mac, and Linux, makes it easy to consume and manage Microsoft Azure Services. Refer to the following resources for details: 

- To install the SDK, use the [Python Package Index](https://pypi.python.org/pypi/azure) or follow [Install Python and the SDK](https://azure.microsoft.com/documentation/articles/python-how-to-install/) in the Azure documentation. 
- [Azure SDK for Python Developer Center](http://azure.microsoft.com/en-us/develop/python/) has lots of help from installation to documentation with tutorials.  Some highlights follow:  
- How-to Guides:
  - [Storage Blob](http://azure.microsoft.com/en-us/develop/python/how-to-guides/blob-service/)  
  - [Storage Queue](http://azure.microsoft.com/en-us/develop/python/how-to-guides/queue-service/)  
  - [Storage Table](http://azure.microsoft.com/en-us/develop/python/how-to-guides/table-service/)  
  - [Service Bus Queues](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-bus-queues/)   - [Service Bus Topics/Subscriptions](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-bus-topics/) 
  - [Service Management](http://azure.microsoft.com/en-us/develop/python/how-to-guides/service-management/)  
- The [SDK's GitHub repository](https://github.com/Azure/azure-sdk-for-python) has [unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/tests) that are also a good source of information on APIs.  
  
  
## Scientific Computing  
In addition to all the Python data-scientist libraries, the Python Tools for Visual Studio support IPython and IPython Notebooks, which can be hosted in Azure.

We recommend obtaining IPython and scientific computing libraries (matplotlib, scipy, numpy, etc.) from [University of California, Irvine](http://www.lfd.uci.edu/~gohlke/pythonlibs/#scipy-stack).  
  
## See Also  
 [Getting Started with PTVS: Setting up Visual Studio](../python/getting-started-with-ptvs-setting-up-visual-studio.md)   
 [Getting Started with PTVS: Start Coding (Projects)](../python/getting-started-with-ptvs-start-coding-projects.md)   
 [Getting Started with PTVS: Editing Code](../python/getting-started-with-ptvs-editing-code.md)   
 [Getting Started with PTVS: Debugging](../python/getting-started-with-ptvs-debugging.md)   
 [Getting Started with PTVS: Interactive Python](../python/getting-started-with-ptvs-interactive-python.md)   
 [Getting Started with PTVS: Building a Website in Azure](../python/getting-started-with-ptvs-building-a-website-in-azure.md)