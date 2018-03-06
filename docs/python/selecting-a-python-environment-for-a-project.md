---
title: Selecting an environment for a project | Microsoft Docs
description: In Visual Studio Solution Explorer, you can assign a specific Python interpreter (environment) to always use for any given project, ignoring the default environment. You can also create and manage virtual environments.
ms.custom: ""
ms.date: 02/20/2018
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Selecting a Python interpreter and environment for use in a project

All code in a Python project runs within the context of a specific environment. Visual Studio also uses that environment for debugging, import and member completions, syntax checking, and any other tasks that require an environment.

All new Python projects in Visual Studio are initially configured to use the default global environment, which appears under the **Python Environments** node in Solution Explorer:

![Global default Python environment shown in Solution Explorer](media/environments-project.png)

You can make other environments available to the project, including virtual environments. Only one environment can be activated at any given time.

## Using global environments

To make specific global environments available to the project (including conda environments [identified manually](managing-python-environments-in-visual-studio.md#manually-identifying-an-existing-environment)), right-click the **Python Environments** node and select **Add/Remove Python Environments...**. From the displayed list, select the desired environments:

![Add/Remove Python Environments dialog](media/environments-add-remove.png)

Once you select **OK**, all the selected environments appear **Python Environments** node. The currently-activated environment appears in bold:

![Multiple Python environments shown in Solution Explorer](media/environments-project-multiple.png)

To activate a different environment, right click the environment name and select **Activate Environment**. Your choice is saved with the project and that environment is activated whenever you open the project in the future.

If you clear all the options in the **Add/Remove Python Environments** dialog, Visual Studio activates the global default environment.

## Using virtual environments

A virtual environment is a unique combination of a specific Python interpreter and a specific set of libraries that is different from other global and conda environments. You typically use a virtual environment when you have specific needs in a project and don't want to modify other environments to meet those needs.

Once a virtual environment is added to your project, it appears in the **Python Environments** window, you can activate it like any other environment, and you can manage its packages.

Note that one drawback to virtual environments is that they contain hard-coded file paths and thus cannot easily be shared or transported to other development computers. Fortunately, you can use the `requirements.txt` file to allow recipients of your project to easily restore the environment. For more information, see [Managing required packages with requirements.txt](managing-required-packages-with-requirements-txt.md).

### Activating an existing virtual environment

If you've already created a virtual environment elsewhere, you can activate it for a project as follows:

1. Right-click **Python Environments** in Solution Explorer and select **Add Existing Virtual Environment...**.

1. In the **Browse** dialog that appears, Navigate to and select the folder that contains the virtual environment, and select **OK**. If Visual Studio detects a `requirements.txt` file in that environment, it asks whether to install those packages.

1. After a few moments, the virtual environment appears under the **Python Environments** node in Solution Explorer. The virtual environment is not activated by default, so right-click it and select **Activate Environment**.

### Creating a virtual environment

You can create a new virtual environment directly from Visual Studio as follows:

1. Right-click **Python Environments** in Solution Explorer and select **Add Virtual Environment...**, which brings up the following dialog box:

    ![Creating a virtual environment](media/environments-add-virtual-1.png)

1. In the **Location of the virtual environment** field, specify a path for the virtual environment. If you specify a name only, the virtual environment is created within the current project in a subfolder with that name.

1. Select an environment as the base interpreter and select **Create**. Visual Studio displays a progress bar while it configures the environment and downloads any necessary packages. At this point the virtual environment appears in the **Python Environments** window for the containing project.

1. The virtual environment is not activated by default. To activate it for the project, right-click it and select **Activate Environment**.

> [!Note]
> If the location path identifies an existing virtual environment, Visual Studio detects the base interpreter automatically (using the `orig-prefix.txt` file in the environment's `lib` directory) and changes the create button to **Add**.
>
> If a `requirements.txt` file exists when adding a virtual environment, the **Add Virtual Environment** dialog displays an option to install the packages automatically, making it easy to recreate an environment on another computer:
>
> ![Create virtual environment with requirements.txt](media/environments-requirements-txt.png)
>
> Either way, the result is the same as if you'd used the **Add Existing Virtual Environment...** command.

### Remove a virtual environment

1. In Solution Explorer, right-click the virtual environment and select **Remove**.

1. Visual Studio asks whether to remove or delete the virtual environment. Selecting **Remove** makes it unavailable to the project but leaves it on the file system. Selecting **Delete** both removes the environment from the project and deletes it from the file system. The base interpreter is unaffected.

## Viewing installed packages

In Solution Explorer, expand any specific environment's node to quickly view the packages that are installed in that environment (meaning that you can import and use those packages in your code when the environment is active):

![Python packages for an environment in Solution Explorer](media/environments-installed-packages.png)

To install new packages, right-click the environment and select **Install Python Package...** to switch to the **Packages** tab in the **Python Environments** window. Enter a search term (usually the package name) and Visual Studio displays matching packages.

Within Visual Studio, packages (and dependencies) are downloaded from the [Python Package Index (PyPI)](https://pypi.python.org/pypi), where you can also search for available packages. Visual Studio's status bar and output window show information about the install. To uninstall a package, right-click it select **Remove**.

Be aware that the displayed entries may not always be accurate, and installation and uninstallation may not be reliable or available. Visual Studio uses the pip package manager if available, and downloads and installs it when required. Visual Studio can also use the easy_install package manager. Packages installed using `pip` or `easy_install` from the command line are also displayed.

Also note that Visual Studio does not presently support using `conda` to install packages into a conda environment. Use `conda` from the command line instead.

> [!Tip]
> A common situation where pip fails to install a package is when the package includes source code for native components in `*.pyd` files. Without the required version of Visual Studio installed, pip cannot compile these components. The error message displayed in this situation is `error: Unable to find vcvarsall.bat`. `easy_install` is often able to download pre-compiled binaries, and you can download a suitable compiler for older versions of Python from [http://aka.ms/VCPython27](http://aka.ms/VCPython27). For more details, see [How to deal with the pain of "unable to find vcvarsallbat"](https://blogs.msdn.microsoft.com/pythonengineering/2016/04/11/unable-to-find-vcvarsall-bat/) on the Python tools team blog.

## See also

- [Managing Python environments in Visual Studio](managing-python-environments-in-visual-studio.md)
- [Using requirements.txt for dependencies](managing-required-packages-with-requirements-txt.md)
- [Search paths](search-paths.md)
- [Python Environments window reference](python-environments-window-tab-reference.md)