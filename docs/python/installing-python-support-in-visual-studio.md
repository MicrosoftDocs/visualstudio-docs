---
title: Install Python Tools for Visual Studio (PTVS)
description: Install the Python Tools for Visual Studio (PTVS) in Visual Studio on Windows and check your installation in the Python Interactive window.
ms.date: 6/5/2023
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.technology: vs-python
---
# Install Python support in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Python support is available only on Visual Studio for Windows. On Mac and Linux, Python support is available through [Visual Studio Code](https://code.visualstudio.com/docs/python/python-tutorial).

## Download & install the Python workload

1. Download and run the latest Visual Studio installer for Windows. Python support is present in the release 15.2 and later. If you have Visual Studio installed already, open Visual Studio and run the installer by selecting **Tools** > **Get Tools and Features**.

    > [!div class="nextstepaction"]
    > [Install Visual Studio Community](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted)

    >[!Tip]
    > The Community edition is for individual developers, classroom learning, academic research, and open source development. For other uses, install [Visual Studio Professional](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Professional&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted) or [Visual Studio Enterprise](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Enterprise&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted).

1. The installer provides a list of workloads that are groups of related options for specific development areas.
   For Python, select the **Python development** workload and select **Install**:

   ![Screenshot of the Python development workload selected in the Visual Studio installer.](media/installation-python-workload.png)

   | Python&nbsp;installation&nbsp;options| Description |
   | --- | --- |
   | Python distributions | Choose any combination of the available options, such as 32-bit and 64-bit variants of the Python 2, Python 3, Miniconda, Anaconda2, and Anaconda3 distributions that you plan to work with. Each includes the distribution's interpreter, runtime, and libraries. Anaconda, specifically, is an open data science platform that includes a wide range of pre-installed packages. Visual Studio automatically detects existing Python installations. See [The Python Environments window](managing-python-environments-in-visual-studio.md#the-python-environments-window). Also, if a newer version of Python is available than what's shown in the installer, you can install that version separately and Visual Studio will detect it. |
   | **Cookiecutter template support** | Installs the Cookiecutter graphical UI to discover templates, input template options, and create projects and files. See [Use the Cookiecutter extension](using-python-cookiecutter-templates.md). |
   | **Python web support** | Installs tools for web development including HTML, CSS, and JavaScript editing support, along with templates for projects using the Bottle, Flask, and Django frameworks. See [Python web project templates](python-web-application-project-templates.md). |
   | **Python native development tools** | Installs the C++ compiler and other necessary components to develop native extensions for Python. See [Create a C++ extension for Python](working-with-c-cpp-python-in-visual-studio.md). Also install the **Desktop development with C++** workload for full C++ support. |

   By default, the Python workload gets installed for all users on a computer under: 

   :::moniker range=">=vs-2022"

   ```txt
   *%ProgramFiles%\Microsoft Visual Studio\\<VS_version>\\<VS_edition>Common7\IDE\Extensions\Microsoft\Python*
   ```

   where `<VS_version>` is 2022 and `<VS_edition>` is Community, Professional, or Enterprise.

   :::moniker-end
   :::moniker range="<=vs-2019"

   ```txt
   *%ProgramFiles(x86)%\Microsoft Visual Studio\\<VS_version>\\<VS_edition>Common7\IDE\Extensions\Microsoft\Python*
   ```

   where `<VS_version>` is 2019 or 2017 and `<VS_edition>` is Community, Professional, or Enterprise.

   :::moniker-end

## Test your install

To quickly test Python support:

1. Launch Visual Studio
2. Press **Alt**+**I** to open the **Python Interactive** window and enter `2+2`. If you don't see the output of **4**, recheck your steps.

    ::: moniker range="<=vs-2019"
    ![Screenshot of testing Python through the interactive window.](media/installation-interactive-test.png)
    ::: moniker-end

    ::: moniker range=">=vs-2022"
    ![Screenshot of testing Python through the Visual Studio 2022 interactive window.](media/vs-2022/python-interactive.png)
    ::: moniker-end

## Related content

- [Tutorial step 1: Create a Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)
- [Manually identify an existing Python interpreter](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment)
