---
title: Installation Options for Python in Visual Studio 2017 | Microsoft Docs
ms.custom: "" 
ms.date: 10/9/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c1236667-264e-4c42-b875-55f8be49d198
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Installation options Python support in Visual Studio 2017 on Windows

Python development options appear on the right side of the installer

  ![Python development options in the Visual Studio installer](media/installation-python-options.png)

  | Option | Description | 
  | --- | --- |
  | Python distributions | Choose any combination of the 32-bit and 64-bit variants of the Python 2, Python 3, Anaconda2, and Anaconda3 distributions that you plan to work with. Each includes the distribution's interpreter, runtime, and libraries. Anaconda, specifically, is an open data science platform that includes a wide range of packages. (You can return to the Visual Studio installer at any time to add or remove distributions.) |
  | Cookiecutter template support | Installs the Cookicutter graphical UI to discover templates, input template options, and create projects and files. See [Using the Cookicutter extension](cookiecutter.md). |
  | Python web support | Installs tools for web development including HTML, CSS, and JavaScript editing support, along with templates for projects using the Bottle, Flask, and Django frameworks. See [Python web project templates](template-web.md). |
  | Python IoT support | Supports Windows IoT Core development using Python. |
  | Python native development tools | Installs the C++ compiler and other necessary components to develop native extensions for Python. See [Creating a C++ extension for Python](cpp-and-python.md). |
  | Azure Cloud Services core tools | Provides additional support for developer Azure Cloud Services in Python. See [zure Cloud Service Projects](template-azure-cloud-service.md). |


After installation, the installer provides options to modify, launch, repair, or uninstall Visual Studio. The **Modify** button changes to **Update** when updates to Visual Studio when updates are available for any installed components. (The modify option is then available on the drop-down menu.) You can also launch Visual Studio and the installer from the Windows Start menu by searching on "Visual Studio".

    ![Launching, modifying, modifying, or uninstalling Visual Studio from the installer](media/installation-vs-launch.png)

If you're working with data science, also consider the **Data science and analytical applications** workload. This workload includes support for Python as well as the R and F# languages. For more information, see [Data science and analytical applications workload](../rtvs/data-science-workload.md).
