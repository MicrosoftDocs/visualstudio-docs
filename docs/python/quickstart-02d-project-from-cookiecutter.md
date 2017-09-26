---
title: "Quickstart: Create a Python Projects from a Cookiecutter Template in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 9/22/2017
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a7bbb71c-fa07-42e8-bef9-0b9cf6dd628a
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Quickstart: create a project from a Cookiecutter template

Once you've [installed Python support in Visual Studio 2017](quickstart-01-install.md), it's easy to create a new project from a Cookiecutter template, including many that are published to GitHub. [Cookiecutter](https://cookiecutter.readthedocs.io/en/latest/) provides a graphical user interface to discover templates, input template options, and create projects and files. It's included with Visual Studio 2017 and can be installed separately in earlier versions of Visual Studio.

1. Launch Visual Studio.

1. Select **File > New > From Cookiecutter...**. This command opens a window in Visual Studio where you can browse templates. 

    ![New Project from Cookiecutter template](media/projects-from-cookiecutter1.png)

1. Double-click on one of your choice to generate a project from the template, such as "Microsoft/python-sklearn-classifier-cookiecutter". The first time you use Cookiecutter the process may take several minutes.

1. In the next step, set a location for the new project in the **Create To** field, then select **Create**.

    ![Second step using Cookiecutter, setting project properties](media/projects-from-cookiecutter2.png)

1. When the process is complete, you see the message "Files created successfully." Select the command **Open in Solution Explorer** to open the project.

1. It's next necessary to install the Python packages that the program requires. In the case of 

## Next Steps

> [!div class="nextstepaction"]
> [Tutorial: Working with Python in Visual Studio](vs-tutorial-01-01.md)

## See Also

- [Creating an environment for an existing Python interpreter](python-environments.md#creating-an-environment-for-an-existing-interpreter).
- [Install Python support in Visual Studio 2015 and earlier](installation.md).
- [Install locations](installation.md#install-locations).
