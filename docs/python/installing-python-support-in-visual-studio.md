---
title: Install Python Tools for Visual Studio (PTVS)
description: Install the Python Tools for Visual Studio (PTVS) in Visual Studio on Windows and check your installation in the Python Interactive window.
author: cwebster-99
ms.author: cowebster
ms.subservice: python
ms.topic: how-to
ms.date: 11/12/2025
manager: mijacobs

# CustomerIntent: As a developer, I want to install Python support in Visual Studio so that I can access Python features in the product.

---

# Install Python support in Visual Studio

Python support is available only in Visual Studio for Windows. For Mac and Linux, Python support is available through [Visual Studio Code](https://code.visualstudio.com/docs/python/python-tutorial).

## Prerequisites 

- Visual Studio on Windows. For installation steps, see [Install Visual Studio](../install/install-visual-studio.md).

> [!NOTE]
> You also need to install a Python interpreter in order to work with Python in Visual Studio. We recommend installing one from [python.org](https://www.python.org/downloads/) or Anaconda. To learn about Python interpreters, see [Install Python interpreters](installing-python-interpreters.md).

## Download and install the Python workload

Complete the following steps to download and install the Python workload.

1. Download and run the latest Visual Studio Installer for Windows. Python support is present in release 15.2 and later. If you have Visual Studio installed already, open Visual Studio and run the installer by selecting **Tools** > **Get Tools and Features**.

   > [!div class="nextstepaction"]
   > [Install Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)

   > [!Tip]
   > The Community edition is for individual developers, classroom learning, academic research, and open-source development. For other uses, install [Visual Studio Professional](https://visualstudio.microsoft.com/vs/professional/) or [Visual Studio Enterprise](https://visualstudio.microsoft.com/vs/enterprise/).

1. The installer provides a list of workloads that are groups of related options for specific development areas. For Python, select the **Python development** workload and select **Install**:

   :::image type="content" source="media/installation-python-workload.png" alt-text="Screenshot of the Python development workload selected in the Visual Studio installer." lightbox="media/installation-python-workload.png":::

   | Python installation options| Description |
   | --- | --- |
   | **Python distributions** | Choose any combination of Python distributions that you plan to work with. Common options include 32-bit and 64-bit variants of Python 2, Python 3, Miniconda, Anaconda 2, and Anaconda 3. Each option includes the distribution's interpreter, runtime, and libraries. Anaconda, specifically, is an open data science platform that includes a wide range of preinstalled packages. Visual Studio automatically detects existing Python installations. For more information, see [The Python Environments window](managing-python-environments-in-visual-studio.md#the-python-environments-window). Also, if a newer version of Python is available than the version shown in the installer, you can install the new version separately and Visual Studio detects it. |
   | **Cookiecutter template support** | Install the Cookiecutter graphical UI to discover templates, input template options, and create projects and files. For more information, see [Use the Cookiecutter extension](using-python-cookiecutter-templates.md). |
   | **Python web support** | Install tools for web development including HTML, CSS, and JavaScript editing support, along with templates for projects using the Bottle, Flask, and Django frameworks. For more information, see [Python web project templates](python-web-application-project-templates.md). |
   | **Python native development tools** | Install the C++ compiler and other necessary components to develop native extensions for Python. For more information, see [Create a C++ extension for Python](working-with-c-cpp-python-in-visual-studio.md). Also install the **Desktop development with C++** workload for full C++ support. |

   By default, the Python workload installs for all users on a computer in the following location:

   :::moniker range=">=vs-2022"

   _%ProgramFiles%\Microsoft Visual Studio\\<VS_version>\\<VS_edition>Common7\IDE\Extensions\Microsoft\Python_

   The _\<VS_version>_ is 2022, and _\<VS_edition>_ is Community, Professional, or Enterprise.

   :::moniker-end
   :::moniker range="<=vs-2019"

   _%ProgramFiles(x86)%\Microsoft Visual Studio\\<VS_version>\\<VS_edition>Common7\IDE\Extensions\Microsoft\Python_

   The _\<VS_version>_ is 2019 or 2017, and _\<VS_edition>_ is Community, Professional, or Enterprise.

   :::moniker-end

## Test your install

Quickly check your installation of Python support:

1. Launch Visual Studio.

1. Select Alt + I to open the **Python Interactive** window.

1. In the window, enter the statement `2+2`.

   The statement output `4` displays in the window. If you don't see the correct output, recheck your steps.

   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/installation-interactive-test.png" alt-text="Screenshot that shows a test of Python support through the interactive window." lightbox="media/installation-interactive-test.png":::

   ::: moniker-end

   ::: moniker range="vs-2022"

   :::image type="content" source="media/vs-2022/python-interactive.png" alt-text="Screenshot that shows a test of Python support through the Visual Studio 2022 interactive window." lightbox="media/vs-2022/python-interactive.png":::

   ::: moniker-end

## Related content

- [Tutorial step 1: Create a Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
- [Manually identify an existing Python environment](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment)
