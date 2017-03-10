---
title: "Python Environments in Python Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8876f8c1-4770-44dc-97d8-bf0035ae8196
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

# Python Environments

Python code always runs within a particular Python *environment*, consisting of an interpreter, a library (typically the Python Standard Library), and a set of installed packages. Together these determine which language constructs and syntax are valid, what operating-system functionality you can access, and which packages you can use.

The Python workload in Visual Studio makes it easy to manage multiple Python environments and easily switch between them for different projects. An environment also includes an IntelliSense database for an environment's libraries, such that typing a statement like `import` in the Visual Studio editor will automatically display a list of available libraries as well as the modules within those libraries.

Oftentimes, developers use only a single, global Python environment but others need to manage multiple global environments, project-specific environments, and perhaps also virtual environments as explained in this topic:

- [Selecting and installing Python interpreters](#selecting-and-installing-python-interpreters)
- [Managing Python environments in Visual Studio](#managing-python-environments-in-visual-studio)
- [Global environments](#global-environments)
- [Project-specific environments](#project-specific-environments)
- [Virtual environments](#virtual-environments)
- [Managing required packages](#managing-required-packages)
- [Search paths](#search-paths)

For a video introduction, see [Deep Dive: Python Interpreters](https://youtu.be/KY1GEOo3qy0) (youtube.com, 13m27s).

> [!VIDEO https://www.youtube.com/embed/KY1GEOo3qy0]

## Selecting and installing Python interpreters

Except with Visual Studio 2017 Preview, Python support does not come with a Python interpreter, so you need to install one of the following to run your code. In general, Visual Studio will automatically detect newly-installed interpreters and set up an environment for them. If it does not, see [Creating an environment for an existing interpreter](#creating-an-environment-for-an-existing-interpreter) below.

| Interpreter | Description | 
| --- | --- | 
| [CPython](https://www.python.org/) | The "native" and most commonly-used interpreter, available in 32- and 64-bit versions (32-bit recommended). Includes the latest language features, maximum Python package compatibility, full debugging support, and interop with [IPython](http://ipython.org/). See also: [Should I use Python 2 or Python 3?](http://wiki.python.org/moin/Python2orPython3) |
| [IronPython](http://ironpython.codeplex.com/) | A .NET implementation of Python, available in 32- and 64-bit versions, providing C#/F#/Visual Basic interop, access to .NET APIs, standard Python debugging (but not C++ mixed-mode debugging), and mixed IronPython/C# debugging. IronPython, however, does not support virtual environments. | 
| [Anaconda](https://www.continuum.io) | An open data science platform powered by Python, and includes the latest version of CPython and most of the difficult-to-install packages. We recommend it if you can't otherwise decide. |
| [PyPy](http://www.pypy.org/) | A high-performance tracing JIT implementation of Python that's good for long-running programs and situations where you identify performance issues but cannot find other resolutions. Works with Visual Studio but with limited support for advanced debugging features. |
| [Jython](http://www.jython.org/) | An implementation of Python on the Java Virtual Machine (JVM). Similar to IronPython, code running in Jython can interact with Java classes and libraries, but may not be able to use many libraries intended for CPython. Works with Visual Studio but with limited support for advanced debugging features. |

Developers that want to provide new forms of detection for Python environments, see [PTVS Environment Detection](https://github.com/Microsoft/PTVS/wiki/Extensibility-Environments) (github.com).

## Managing Python environments in Visual Studio

To open the Python Environments window, do one of the following:

1. Select the **View > Other Windows > Python Environments** menu command.
1. Right-click the **Python Environments** for a project in Solution Explorer and select **View All Python Environments**:

    ![View All Environments command in Solution Explorer](media/environments-view-all.png)
    
In either case, the Python Environments window appears as a sibling tab to Solution Explorer:

![Python Environments window](media/environments-default-view.png)

In the example above, we have Python 3.4 (32-bit CPython) installed along with 32- and 64-bit versions of IronPython. The default environment in boldface is Python 3.4, which will be used for any new projects. If you don't see any environments listed, it means that you've installed Python Tools for Visual Studio but haven't installed a Python interpreter (ee [Selecting and installing Python interpreters](#selecting-and-installing-python-interpreters) above).

> [!Tip]
> When the **Python Environments* window is narrow, as shown above, the environments are listed on the top and the various tabs on the bottom. If you expand the window enough, however, you'll see a wide view that you may find more convenient to work with.
>
> ![Python Environments window expanded view](media/environments-expanded-view.png)

Visual Studio normally locates an installed Python interpreter by checking the registry, it but may not find it if the interpreter is installed in a non-standard fashion. In such cases, you can point Visual Studio directly to the interpreter as follows:

1. Select **+ Custom...** in the Environments Window, which creates a new environment and opens the [**Configure** tab](#configure-tab) described below.)

    ![Default view for a new custom environment](media/environments-custom-1.png)

1. Enter a name for the environment in the **Description** field.
1. Enter or browse to the path of the interpreter in the **Prefix path** field.
1. Select **Auto Detect** to have Visual Studio complete the remaining fields, or complete them manually.
1. Select **Apply** to save the environment.
1. If you need to remove the environment, select the **Remove** command on the **Configure** tab.

> [!Note]
> Although Visual Studio respects the system-site-packages option, it doesn't provide a way to change it from within Visual Studio.

### Overview tab

Provides basic information and commands for the environment such as setting it as the default, opening an [interactive (REPL) window](interactive-repl.md) with that environment, and jumping to the dialog to configure the interactive window (identical to the **Tools > Options** menu command, selecting **Python Tools > Interactive Windows** and the name of the environment).

![Python Environments overview tab](media/environments-overview-tab.png)

> [!Note]
> Changing the active environment may cause Visual Studio to briefly become non-responsive while the IntelliSense database is loaded. Environments with many packages may be non-responsive for longer.

### Configure tab

If shown, contains details as described in the table below. If this tab isn't present, it means that Visual Studio is managing all the details automatically.

![Python Environments configure tab](media/environments-configure-tab.png)

| Field | Description |
| --- | --- |
| **Description** | The name to give the environment. |
| **Prefix path** | The base folder location of the interpreter. By filling this in and clicking **Auto Detect**, Visual Studio attempts to fill in the other fields for you. |
| **Interpreter path** | The path to the interpreter executable, commonly the prefix path followed by `python.exe` |
| **Windowed interpreter** | The path to the non-console executable, often the prefix path followed by `pythonw.exe`. |
| **Library path** | Specifies the root of the standard library, but this value may be ignored if Visual Studio is able to request a more accurate path from the interpreter. |
| **Language version** | Selected from the drop down menu. |
| **Architecture** | Normally detected and filled in automatically, otherwise specifies 32-bit or 64-bit. |
| **Path environment variable** | The environment variable that the interpreter uses to find search paths. Visual Studio changes the value of the variable when starting Python so that it contains the project's search paths. Typically this property should be set to `PYTHONPATH`, but some interpreters use a different value. |

### pip tab

Manages the packages installed in the environment, allowing you also to and search for and install new ones (including any dependencies). Searching will filter your currently installed packages as well as searching [PyPI](https://pypi.python.org). You can also directly enter any `pip install` command in the search box, including flags such as `--user` or `--no-deps`.

![Python environments pip tab](media/environments-pip-tab.png)

### IntelliSense tab

Shows the current status of the IntelliSense completion database:

![Python Environments IntelliSense tab](media/environments-intellisense-tab.png)

The database contains metadata for all the environment's libraries and improves IntelliSense speed and reduces memory usage. When Visual Studio detects a new environment (or you add one), it automatically begins to compile the database by analyzing the library source files. This process can take anywhere from a minute to an hour or more depending on what's installed. (Anaconda, for example, comes with many libraries and takes some time to compile the database.) Once complete, you'll get detailed IntelliSense and won't have to refresh the database again (with the **Refresh DB** button) until you install more libraries.

Libraries for which data haven't been compiled are marked with a **!**; if an environment's database isn't complete, a **!** also appears next to it in the main environment list.

## Global environments

Global (or system-wide) environments are available to all of your projects on a machine. Visual Studio usually detects global environments automatically, and they can be viewed in the Python Environments window. If not, you can add an environment manually as described earlier under [Managing Python environments in Visual Studio](#managing-python-environments-in-visual-studio).

Visual Studio uses the default environment for all new projects for executing, debugging, checking syntax, displaying import and member completions, and any other tasks that require an environment. Changing the default environment will affect all projects that have not had a [project-specific environment](#project-specific-environments) added, as described next.

## Project-specific environments

Project-specific environments ensure that a project always runs in a particular environment, ignoring the default global environment. For example, if the global default environment is CPython but a project requires IronPython and certain libraries that aren't installed in the global environment, then a project-specific environment is necessary.

Project environments are listed in Solution Explorer under the Python Environments node. The bold entry is currently active, and will be used for debugging, import and member completions, syntax checking, and any other tasks that require an environment:

![Project environments displayed in Solution Explorer](media/environments-project.png)

To activate a different environment for the project, right-click that environment and select **Activate Environment**.

Any global environment can be added as a project environment by right-clicking **Python Environments** and selecting **Add/Remove Python Environments...**. From the displayed list you can select or deselect those that are available in your project.

![Add/Remove Python Environments dialog](media/environments-add-remove.png)

In Solution Explorer, you can also expand the environment to show its installed packages (those you can import and use in your code when the environment is active):

![Python packages for an environment in Solution Explorer](media/environments-installed-packages.png)

To install new packages, right-click the environment, select **Install Python Package...**, and enter the name of the desired package. Packages (and dependencies) are downloaded from the [Python Package Index (PyPI)](https://pypi.python.org/pypi), where you can also search for available packages. Visual Studio's status bar and output window shows information about the install. To uninstall a package, right-click it select **Remove**.

> [!Note]
> Python's package management support is currently under development by the core Python development team. The displayed entries may not always be accurate, and installation and uninstallation may not be reliable or available. Visual Studio uses the pip package manager if available, and will download and install it when required. Visual Studio can also use the easy_install package manager. Packages installed using pip or easy_install from the command line are also displayed.

> [!Tip]
> A common situation where pip will fail to install a package is when the package includes source code for native components in `*.pyd` files. Without the required version of Visual Studio installed, pip will not be able to compile these components. The error message displayed in this situation is `error: Unable to find vcvarsall.bat.` `easy_install` is often able to download pre-compiled binaries, and you can download a suitable compiler for older versions of Python from [http://aka.ms/VCPython27](http://aka.ms/VCPython27). For more details, see [How to deal with the pain of "unable to find vcvarsallbat"](https://blogs.msdn.microsoft.com/pythonengineering/2016/04/11/unable-to-find-vcvarsall-bat/) on the Python tools team blog.


## Virtual Environments

Because packages installed into a global environment are available to all projects that use it, conflicts may occur when two projects require incompatible packages or different versions of the same package. To avoid such conflicts, Visual Studio provides the ability to create *virtual environments*, which are typically specific to a project.

Like any other Python environment, a virtual environment consists of a Python interpreter, a library, and a set of packages. In this case, though, the virtual environment uses the interpreter and library from one of your global environments (provided it supports virtual environments), but its packages are separate and isolated from the global and all other virtual environments. This again avoids conflicts and minimizes the virtual environment's footprint to the approximate size of its packages. 

To create a virtual environment:

1. Right-click **Python Environments** in Solution Explorer and select **Add Virtual Environment...**, which brings up the following:

    ![Creating a virtual environment](media/environments-add-virtual-1.png)

1. Specify a name to create the virtual environment in your project path, or a full path to create it elsewhere. (To ensure maximum compatibility with other tools, use only letters and numbers in the name.)

1. Select a global environment as the base interpreter and click **Create**. If `pip` and `virtualenv` or `venv` packages are not available, they will be downloaded and installed.

    If the provided path is an existing virtual environment, the base interpreter will be detected and the create button will change to **Add**:

    ![Adding an existing virtual environment](media/environments-add-virtual-2.png)

An existing virtual environment can also be added by right-clicking **Python Environments** in Solution Explorer and selecting **Add Existing Virtual Environment...**. Visual Studio automatically detects the base interpreter using the `orig-prefix.txt` file in the environment's `lib` directory.

Once a virtual environment is added to your project, it appears in the **Python Environments** window, you can activate it like any other environment, and you can manage its packages. Right-clicking it and selecting **Remove** either removes the reference to the environment, or deletes the environment and all its files on disk (but not the base interpreter, of course).

Note that one drawback to virtual environments is that they contain hard-coded file paths and thus cannot easily be shared or transported to other development machines. Fortunately, you can use the `requirements.txt` file as described in the next section.

## Managing required packages

If you're sharing a project with others, using a build system, or plan to [publish it to Microsoft Azure](template-azure-cloud-service.md), you'll need to specify the external packages it requires. The recommended approach is to use a [requirements.txt file](http://pip.readthedocs.org/en/latest/user_guide.html#requirements-files) (readthedocs.org) that contains a list of commands for pip that will install the required versions of dependent packages.

Technically, any filename may be used to track requirements (by using `-r <full path to file>` when installing a package), but Visual Studio provides specific support for `requirements.txt`:

- If you've loaded a project that contains `requirements.txt` and wish to install all the packages listed in that file, right-click the project and select **Install from requirements.txt**:

    ![Install from requirements.txt](media/environments-requirements-txt-install.png)

- When you have all the necessary packages installed in a project, you can right-click the project in Solution Explorer and select **Generate requirements.txt** to create the necessary file. If the file already exists, you'll be prompted for how to update it:

    ![Update requirements.txt options](media/environments-requirements-txt-replace.png)

    - **Replace entire file** removes all items, comments, and options that exist.
    - **Refresh existing entries** detects package requirements and update the version specifiers to match the version you currently have installed.
    - **Update and add entries** refreshes any requirements that are found, and adds all other packages to the end of the file.

Because `requirements.txt` files are intended to freeze the requirements of your project, all installed packages are written with precise versions. This ensures you can easily reproduce your environment on another machine. Packages are included even if they were installed with a version range, as a dependency of another package, or with an installer other than pip.

When adding a new virtual environment, if a` requirements.txt` file exists, the **Add Virtual Environment** dialog displays an option to install the packages automatically, making it easy to recreate an environment on another machine:

![Create virtual environment with requirements.txt](media/environments-requirements-txt.png)

If a package cannot be installed by pip and it appears in a `requirements.txt` file, the entire installation to fail. In this case, manually edit the file to exclude this package or to use [pip's options](http://pip.readthedocs.org/en/latest/reference/pip_install.html#requirements-file-format) to refer to an installable version of the package. For example, you may prefer to use [`pip wheel`](http://pip.readthedocs.org/en/latest/reference/pip_wheel.html) to compile a dependency and add the `--find-links <path>` option to your `requirements.txt`:

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

# Search paths

With typical Python usage, the `PYTHONPATH` environment variable (or `IRONPYTHONPATH`, etc.) provides the default search path for module files. That is, when you use an `import <name>` statement, Python first searches its built-in modules for a matching name, then searches folder containing the Python code you're running, then searches the "module search path" as defined by the applicable environment variable. (See [The Module Search Path](https://docs.python.org/2/tutorial/modules.html#the-module-search-path) and [Environment variables](https://docs.python.org/2/using/cmdline.html#envvar-PYTHONPATH) in the core Python documentation.)

The search path environment variable, however, is ignored by Visual Studio, even when it's been set for the entire system. It's ignored, in fact, precisely *because* it's set for the entire system and thus raise certain questions that cannot be answered automatically: Are the referenced modules meant for Python 2.7 or Python 3.3? Are they going to override standard library modules? Is the developer aware of this or is it a malicious hijacking attempt?

Python support in Visual Studio thus provides a means to specify search paths directly in both environments and projects. These are passed as the value of `PYTHONPATH` (or equivalent) when you debug or execute your script from Visual Studio. By adding search paths, Visual Studio inspects the libraries in those locations and build IntelliSense databases for them (this may take some time depending on the number of libraries).

To add a search path, right-click on the **Search Paths** item in Solution Explorer, select **Add Folder to Search Path...**, and select the folder to include. This path is used for any environment associated with the project.

Files with a `.zip` or `.egg` extension can also be added as search paths by selecting **Add Zip Archive to Search Path...**. As with folders, the contents of these files are scanned and made available to IntelliSense.

> [!Note]
> It is possible to add a search path to Python 2.7 modules while you are using Python 3.3, and you may see errors as a result.

If you are regularly using the same search paths and the contents do not often change, it may be more efficient to install it into your site-packages folder. It will then be analyzed and stored in the IntelliSense database, will always be associated with the intended environment, and will not require a search path to be added for each project.
