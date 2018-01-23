---
title: Installing Python support in Visual Studio | Microsoft Docs
description: Detailed instructions on how to install the Python Tools for Visual Studio (PTVS) in Visual Studio 2017, 2015, 2013, 2012, and 2010, including options and installation locations.
ms.custom: ""
ms.date: 01/16/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Installing Python support in Visual Studio on Windows

To install Python support for Visual Studio (also known as Python Tools for Visual Studio or PTVS), follow the instructions in the section that matches your version of Visual Studio:

- [Visual Studio 2017](#visual-studio-2017)
- [Visual Studio 2015](#visual-studio-2015)
- [Visual Studio 2013 and earlier](#visual-studio-2013-and-earlier)

For Visual Studio 2015 and earlier you also need to separately install a Python interpreter of your choice (Python  3.5 and earlier; 3.6 is not supported and will generate the message "Unsupported Python version 3.6"). For details, see [Python environments](managing-python-environments-in-visual-studio.md). The same page also contains instructions for adding an existing Python interpreter to Visual Studio 2017.

To quickly test Python support after following the installation steps, Open the Python Interactive window by pressing Alt-I and entering `2+2`. If you don't see the output of `4`, recheck your steps.

> [!Tip]
> The Python workload includes the helpful Cookiecutter extension that provides a graphical user interface to discover templates, input template options, and create projects and files. For details, see [Using Cookiecutter](cookiecutter.md).

> [!Note]
> Python support is not presently available in Visual Studio for Mac, but is available on Mac and Linux through Visual Studio Code. See [questions and answers](overview-of-python-tools-for-visual-studio.md#questions-and-answers).

## Visual Studio 2017

1. Download and run the latest Visual Studio 2017 installer. You must install version 15.2 and above to use Python.

    > [!div class="nextstepaction"]
    > <a target="frameTarget" href="https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_install">Install Visual Studio 2017 Community</a>

    >[!Tip]
    > The Community edition is for individual developers, classroom learning, academic research, and open source development. For other uses, install <a target="frameTarget" href="https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Professional&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_install">Visual Studio 2017 Professional</a> or <a target="frameTarget" href="https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Enterprise&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_install">Visual Studio 2017 Enterprise</a>.

1. The installer presents you with a list of workloads, which are groups of related options for specific development areas. For Python, select the **Python development** workload.

    ![Python development workload in the Visual Studio installer](media/installation-python-workload.png)

    Optional: if you're working with data science, also consider the **Data science and analytical applications** workload (Visual Studio 2017 15.2 and later). This workload includes support for Python as well as the R and F# languages. For more information, see [Data science and analytical applications workload](../rtvs/data-science-workload.md).

1. On the right side of the installer, chose additional options if desired. Skip this step to accept the default options.

    ![Python development options in the Visual Studio installer](media/installation-python-options.png)

    | Option | Description |
    | --- | --- |
    | Python distributions | Choose any combination of the 32-bit and 64-bit variants of the Python 2, Python 3, Anaconda2, and Anaconda3 distributions that you plan to work with. Each includes the distribution's interpreter, runtime, and libraries. Anaconda, specifically, is an open data science platform that includes a wide range of pre-installed packages. (You can return to the Visual Studio installer at any time to add or remove distributions.) |
    | Cookiecutter template support | Installs the Cookiecutter graphical UI to discover templates, input template options, and create projects and files. See [Using the Cookiecutter extension](cookiecutter.md). |
    | Python web support | Installs tools for web development including HTML, CSS, and JavaScript editing support, along with templates for projects using the Bottle, Flask, and Django frameworks. See [Python web project templates](template-web.md). |
    | Python IoT support | Supports Windows IoT Core development using Python. |
    | Python native development tools | Installs the C++ compiler and other necessary components to develop native extensions for Python. See [Creating a C++ extension for Python](working-with-c-cpp-python-in-visual-studio.md). Also install the **Desktop development with C++** workload for full C++ support. |
    | Azure Cloud Services core tools | Provides additional support for developer Azure Cloud Services in Python. See [Azure cloud service Projects](template-azure-cloud-service.md). |

1. After installation, the installer provides options to modify, launch, repair, or uninstall Visual Studio. The **Modify** button changes to **Update** when updates to Visual Studio when updates are available for any installed components. (The modify option is then available on the drop-down menu.) You can also launch Visual Studio and the installer from the Windows Start menu by searching on "Visual Studio".

    ![Launching, modifying, modifying, or uninstalling Visual Studio from the installer](media/installation-vs-launch.png)

> [!VIDEO https://mva.microsoft.com/en-US/training-courses-embed/python-tools-for-visual-studio-2017-18121/Video-Installing-Visual-Studio-Python-Support-go1id3LWE_1705918567]

## Visual Studio 2015

1. Run the Visual Studio installer through **Control Panel > Programs and Features**, selecting **Microsoft Visual Studio 2015** and then **Change**.

1. In the installer, select **Modify**.

1. Select **Programming Languages > Python Tools for Visual Studio** and then **Next**:

    ![PTVS option in Visual Studio 2015 installer](media/installation-vs2015.png)

1. Once Visual Studio setup is complete, [install a Python interpreter of your choice](managing-python-environments-in-visual-studio.md#selecting-and-installing-python-interpreters). If you already have an interpreter installed, see [Creating an environment for an existing interpreter](managing-python-environments-in-visual-studio.md#creating-an-environment-for-an-existing-interpreter).

## Visual Studio 2013 and earlier

1. Install the appropriate version of Python Tools for Visual Studio for your version of Visual Studio:

    - Visual Studio 2013: [PTVS 2.2 for Visual Studio 2013](https://github.com/Microsoft/PTVS/releases/v2.2). The **File > New Project** dialog in Visual Studio 2013 gives you a shortcut for this process.
    - Visual Studio 2012: [PTVS 2.1 for Visual Studio 2012](https://pytools.codeplex.com/downloads/get/920478)
    - Visual Studio 2010: [PTVS 2.1 for Visual Studio 2010](https://pytools.codeplex.com/downloads/get/920479)

1. [Install a Python interpreter of your choice](managing-python-environments-in-visual-studio.md#selecting-and-installing-python-interpreters). If you already have an interpreter installed, see [Creating an environment for an existing interpreter](managing-python-environments-in-visual-studio.md#creating-an-environment-for-an-existing-interpreter).

## Install locations

By default, Python support is installed for all users on a computer.

For Visual Studio 2017, the Python workload is installed in `%ProgramFiles(x86)%\Microsoft Visual Studio\2017\<VS_edition>Common7\IDE\Extensions\Microsoft\Python` where &lt;VS_edition&gt; is Community, Professional, or Enterprise.

For Visual Studio 2015 and earlier, installation paths are as follows:

- 32-bit:
  - Path: `%Program Files(x86)%\Microsoft Visual Studio <VS_ver>\Common7\IDE\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>`
  - Registry location of path: `HKEY_LOCAL_MACHINE\Software\Microsoft\PythonTools\<VS_ver>\InstallDir`
- 64-bit:
  - Path: `%Program Files%\Microsoft Visual Studio <VS_ver>\Common7\IDE\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>`
  - Registry location of path: `HKEY_LOCAL_MACHINE\Software\Wow6432Node\Microsoft\PythonTools\<VS_ver>\InstallDir`

where:

- &lt;VS_ver&gt; is:
  - 14.0 for Visual Studio 2015
  - 12.0 for Visual Studio 2013
  - 11.0 for Visual Studio 2012
  - 10.0 for Visual Studio 2010
- &lt;PTVS_ver&gt; is a version number, such as 2.2, 2.1, 2.0, 1.5, 1.1, or 1.0.

### User-specific installations (1.5 and earlier)

Python Tools for Visual Studio 1.5 and earlier allowed installation for the current user only, in which case the installation path is `%LocalAppData%\Microsoft\VisualStudio\<VS_ver>\Extensions\Microsoft\Python Tools for Visual Studio\<PTVS_ver>` where &lt;VS_ver&gt; and &lt;PTVS_ver&gt; are the same as described above.

<iframe src="" height="0" width="0" frameborder="0" name="frameTarget" />
