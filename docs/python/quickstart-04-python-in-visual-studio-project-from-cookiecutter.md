---
title: "Quickstart: Create Python projects with Cookiecutter"
description: Follow guided steps to create a Python project in Visual Studio by using a Cookiecutter template.
ms.date: 04/18/2024
ms.topic: quickstart
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to create Python projects in Visual Studio with boilerplate code from Cookiecutter templates.
---

# Quickstart: Create a project from a Cookiecutter template

In this quickstart, you follow guided steps to create a new project from a Cookiecutter template, including many that are published to GitHub. [Cookiecutter](https://cookiecutter.readthedocs.io/en/latest/) provides a graphical user interface to discover templates, input template options, and create projects and files. Visual Studio 2017 and later includes the Cookiecutter extension. It can be installed separately in earlier versions of Visual Studio.

## Prerequisites 

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- Python 3.3 or later (32-bit or 64-bit) or Anaconda 3 version 4.2 or later (32-bit or 64-bit).

   - If a suitable Python interpreter isn't available, Visual Studio displays a warning.
   
   - If you install a Python interpreter while Visual Studio is running, select the **Home** option on the **Cookiecutter Explorer** toolbar to detect the newly installed interpreter. For more information, see [Create and manage Python environments in Visual Studio](managing-python-environments-in-visual-studio.md).

## Create a project by using Cookiecutter 

1. In Visual Studio, select **File** > **New** > **From Cookiecutter**. This command opens the **Cookiecutter** window in Visual Studio where you can browse templates.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/quickstart-python-project-from-cookiecutter.png" alt-text="Screenshot that shows how to create a new project from a Cookiecutter template in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-project-from-cookiecutter.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-python-project-from-cookiecutter.png" alt-text="Screenshot that shows how to create a new project from a Cookiecutter template." lightbox="media/quickstart-python-project-from-cookiecutter.png":::

   ::: moniker-end

1. In the **Cookiecutter** window, select the **Microsoft/python-sklearn-classifier-cookiecutter** template under the **Recommended** section.

1. To clone and install the selected template, select **Next**.

   The process can take several minutes the first time you use a particular template, as Visual Studio installs the required Python packages.

1. After you install and clone a template locally, Cookiecutter displays the **Options** page, where you specify settings for your new project.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/quickstart-python-cookiecutter-project-options.png" alt-text="Screenshot that shows how to set options for the new project in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-cookiecutter-project-options.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-python-cookiecutter-project-options.png" alt-text="Screenshot that shows how to set options for the new project." lightbox="media/quickstart-python-cookiecutter-project-options.png":::

   ::: moniker-end

   1. Set the **Create To** field to the location where you want Visual Studio to store the new project files, such as `C:\repos\python-sklearn-classifier-cookiecutter\`.

   1. Select **Create and Open Project**. (If you're adding the new project to an existing solution, you see the **Add to Solution** option instead.)

   When the process completes, you see the message **Successfully created files using template...**. The project opens in **Solution Explorer** automatically.

1. To run the program, select **Debug** > **Start without Debugging** or use the keyboard shortcut **Ctrl**+**F5**. The program generates a precision-recall curve graph:

   :::image type="content" source="media/quickstart-python-cookiecutter-project-output.png" alt-text="Screenshot that shows the output of the python-sklearn-classifier-cookiecutter template project." border="false" lightbox="media/quickstart-python-cookiecutter-project-output.png":::

## Related content

- [Use the Cookiecutter extension](using-python-cookiecutter-templates.md)
- [Tutorial: Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
