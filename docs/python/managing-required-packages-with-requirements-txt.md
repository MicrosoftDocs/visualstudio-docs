---
title: Using a requirements.txt file to manage package requirements
description: You can use a requirements.txt file to manage a project's dependencies. If you receive a project that contains a requirements.txt file, you can easily install those dependencies in one step.
ms.date: 02/20/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: conceptual
author: kraigb
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Managing required packages with requirements.txt

If you're sharing a project with others, using a build system, or plan to [publish it to Microsoft Azure](python-azure-cloud-service-project-template.md), you need to specify the external packages that the project requires. The recommended approach is to use a [requirements.txt file](http://pip.readthedocs.org/en/latest/user_guide.html#requirements-files) (readthedocs.org) that contains a list of commands for pip that installs the required versions of dependent packages.

Technically, any filename may be used to track requirements (by using `-r <full path to file>` when installing a package), but Visual Studio provides specific support for `requirements.txt`:

- If you've loaded a project that contains `requirements.txt` and wish to install all the packages listed in that file, expand the **Python Environments** node in **Solution Explorer**, then right-click an environment node and select **Install from requirements.txt**:

    ![Install from requirements.txt](media/environments-requirements-txt-install.png)

- If you already have all the necessary packages installed in an environment, you can right-click that environment in Solution Explorer and select **Generate requirements.txt** to create the necessary file. If the file already exists, a prompt appears for how to update it:

    ![Update requirements.txt options](media/environments-requirements-txt-replace.png)

  - **Replace entire file** removes all items, comments, and options that exist.
  - **Refresh existing entries** detects package requirements and updates the version specifiers to match the version you currently have installed.
  - **Update and add entries** refreshes any requirements that are found, and adds all other packages to the end of the file.

Because `requirements.txt` files are intended to freeze the requirements of an environment, all installed packages are written with precise versions. Using precise versions ensures that you can easily reproduce your environment on another computer. Packages are included even if they were installed with a version range, as a dependency of another package, or with an installer other than pip.

If a package cannot be installed by pip and it appears in a `requirements.txt` file, the entire installation fails. In this case, manually edit the file to exclude this package or to use [pip's options](http://pip.readthedocs.org/en/latest/reference/pip_install.html#requirements-file-format) to refer to an installable version of the package. For example, you may prefer to use [`pip wheel`](http://pip.readthedocs.org/en/latest/reference/pip_wheel.html) to compile a dependency and add the `--find-links <path>` option to your `requirements.txt`:

```output
C:\Project>pip wheel azure
Downloading/unpacking azure
    Running setup.py (path:C:\Project\env\build\azure\setup.py) egg_info for package azure

Building wheels for collected packages: azure
    Running setup.py bdist_wheel for azure
    Destination directory: c:\project\wheelhouse
Successfully built azure
Cleaning up...

C:\Project>type requirements.txt
--find-links wheelhouse
--no-index
azure==0.8.0

C:\Project>pip install -r requirements.txt -v
Downloading/unpacking azure==0.8.0 (from -r requirements.txt (line 3))
    Local files found: C:/Project/wheelhouse/azure-0.8.0-py3-none-any.whl
Installing collected packages: azure
Successfully installed azure
Cleaning up...
    Removing temporary dir C:\Project\env\build...
```

## See also

- [Managing Python environments in Visual Studio](managing-python-environments-in-visual-studio.md)
- [Select an interpreter for a project](selecting-a-python-environment-for-a-project.md)
- [Search paths](search-paths.md)
- [Python Environments window reference](python-environments-window-tab-reference.md)