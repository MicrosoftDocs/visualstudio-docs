---
title: Installation for Python in Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 9/22/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ce3d3656-7ba2-490d-92df-0bb3e3badf92
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Installing Python support in Visual Studio on Windows

To install Python support for Visual Studio, follow the instructions in the section that matches your version of Visual Studio:

- [Visual Studio 2017](vs-tutorial-01-00.md)
- [Visual Studio 2015](#visual-studio-2015)
- [Visual Studio 2013 and earlier](#visual-studio-2013-and-earlier)

For Visual Studio 2015 and earlier you also need to separately install a Python interpreter of your choice (Python  3.5 and earlier; 3.6 is not supported). For details, see [Python Environments](python-environments.md). The same page also contains instructions for adding an existing Python interpreter to Visual Studio 2017.

To quickly test Python support after following the installation steps, Open the Python Interactive window by pressing Alt-I and entering `2+2`. If you don't see the output of `4`, recheck your steps.

> [!Tip]
> The Python workload includes the helpful Cookiecutter extension that provides a graphical user interface to discover templates, input template options, and create projects and files. For details, see [Using Cookiecutter](cookiecutter.md).

> [!Note]
> Python support is not presently available in Visual Studio for Mac, but is available on Mac and Linux through Visual Studio Code. See [Questions and answers](python-in-visual-studio.md#questions-and-answers).

## Visual Studio 2017

Refer to [Tutorial Step 0: install Python support in Visual Studio 2017](vs-tutorial-01-00.md).


## Visual Studio 2015

1. Run the Visual Studio installer through **Control Panel > Programs and Features**, selecting **Microsoft Visual Studio 2015** and then **Change**.

1. In the installer, select **Modify**.

1. Select **Programming Languages > Python Tools for Visual Studio** and then **Next**:

    ![PTVS option in Visual Studio 2015 installer](media/installation-vs2015.png)    

1. Once Visual Studio setup is complete, [install a Python interpreter of your choice](python-environments.md#selecting-and-installing-python-interpreters). If you already have an interpreter installed, see [Creating an environment for an existing interpreter](python-environments.md#creating-an-environment-for-an-existing-interpreter).

## Visual Studio 2013 and earlier

1. Install the appropriate version of Python Tools for Visual Studio for your version of Visual Studio:

    - Visual Studio 2013: [PTVS 2.2 for Visual Studio 2013](https://github.com/Microsoft/PTVS/releases/v2.2). The **File > New Project** dialog in Visual Studio 2013 gives you a shortcut for this process.
    - Visual Studio 2012: [PTVS 2.1 for Visual Studio 2012](https://pytools.codeplex.com/downloads/get/920478)
    - Visual Studio 2010: [PTVS 2.1 for Visual Studio 2010](https://pytools.codeplex.com/downloads/get/920479)

1. [Install a Python interpreter of your choice](python-environments.md#selecting-and-installing-python-interpreters). If you already have an interpreter installed, see [Creating an environment for an existing interpreter](python-environments.md#creating-an-environment-for-an-existing-interpreter).

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
