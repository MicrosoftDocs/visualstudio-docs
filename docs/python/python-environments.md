---
title: Python Environments in Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 7/25/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8876f8c1-4770-44dc-97d8-bf0035ae8196
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Python environments

Python in Visual Studio makes it easy to manage multiple Python environments and easily switch between them for different projects. 

Note: if you're new to Python in Visual Studio, see the following topics first as this present discussion relies upon them:

- [Working with Python in Visual Studio](python-in-visual-studio.md)
- [Installing Python support in Visual Studio](installation.md)

A Python *environment*, in which you always run Python code, consists of an interpreter, a library (typically the Python Standard Library), and a set of installed packages. Together these components determine which language constructs and syntax are valid, what operating-system functionality you can access, and which packages you can use.

In Visual Studio, an environment also includes an IntelliSense database for an environment's libraries, such that typing a statement like `import` in the Visual Studio editor automatically displays a list of available libraries as well as the modules within those libraries.

Oftentimes, developers use only a single, global Python environment. Other developers, however, need to manage multiple global environments, project-specific environments, and virtual environments as explained in this topic:

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

Except with Visual Studio 2017, Python support does not come with a Python interpreter, so you need to install one of the following to run your code. In general, Visual Studio automatically detects newly installed interpreters and sets up an environment for each. If it does not detect an installed environment, see [Creating an environment for an existing interpreter](#creating-an-environment-for-an-existing-interpreter).

| Interpreter | Description | 
| --- | --- | 
| [CPython](https://www.python.org/) | The "native" and most commonly-used interpreter, available in 32-bit and 64-bit versions (32-bit recommended). Includes the latest language features, maximum Python package compatibility, full debugging support, and interop with [IPython](http://ipython.org/). See also: [Should I use Python 2 or Python 3?](http://wiki.python.org/moin/Python2orPython3). Note that Visual Studio 2015 and earlier do not support Python 3.6 and can give the error "Unsupported python version 3.6". Use Python 3.5 or earlier instead. |
| [IronPython](https://github.com/IronLanguages/main) | A .NET implementation of Python, available in 32-bit and 64-bit versions, providing C#/F#/Visual Basic interop, access to .NET APIs, standard Python debugging (but not C++ mixed-mode debugging), and mixed IronPython/C# debugging. IronPython, however, does not support virtual environments. | 
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

The example above shows that Python 3.4 (32-bit CPython) is installed along with 32-bit and 64-bit versions of IronPython 2.7. In this case, the default environment in boldface is Python 3.4, which is used for any new projects. If you don't see any environments listed, it means that you've installed Python Tools for Visual Studio in Visual Studio 2015 or earlier, but haven't installed a Python interpreter (see [Selecting and installing Python interpreters](#selecting-and-installing-python-interpreters) above). 

> [!Tip]
> When the **Python Environments** window is narrow, as shown above, the environments are listed on the top and the various tabs on the bottom. Expanding the window enough, however, changes to a wide view that you may find more convenient to work with.
>
> ![Python Environments window expanded view](media/environments-expanded-view.png)

> [!Note]
> Although Visual Studio respects the system-site-packages option, it doesn't provide a way to change it from within Visual Studio.

### Creating an environment for an existing interpreter

Visual Studio normally locates an installed Python interpreter by checking the registry (following [PEP 514 - Python registration in the Windows registry](https://www.python.org/dev/peps/pep-0514/)). However, Visual Studio may not find it if the interpreter is installed in a non-standard fashion. In such cases, you can point Visual Studio directly to the interpreter as follows:

1. Select **+ Custom...** in the Environments Window, which creates a new environment and opens the [**Configure** tab](#configure-tab) described below.)

    ![Default view for a new custom environment](media/environments-custom-1.png)

1. Enter a name for the environment in the **Description** field.
1. Enter or browse to the path of the interpreter in the **Prefix path** field.
1. Select **Auto Detect** to have Visual Studio complete the remaining fields, or complete them manually.
1. Select **Apply** to save the environment.
1. If you need to remove the environment, select the **Remove** command on the **Configure** tab. Auto-detected environments do not provide this option. See the next section for more information.

### Moving an existing interpreter

If you move an existing interpreter to a new location on the file system, Visual Studio doesn't automatically detect the change. Manual steps are necessary to update the list in the Environment window:

- If you originally created an environment for that interpreter, edit that environment to point to the new location.

- If the environment was originally auto-detected, it was installed on the computer with a distinct installer program that created the registry entries that Visual Studio examines. In this case, first restore the Python interpreter to its original location. Then uninstall it using the installer, which clears the registry entries. Then reinstall the interpreter at the desired location. Restart Visual Studio and it should auto-detect the new location. This process ensures that any other side effects of the installer are properly applied.

### Overview tab

Provides basic information and commands for the environment:

![Python Environments overview tab](media/environments-overview-tab.png)

| Command | Description |
| --- | --- |
| Make this environment the default for new projects | Sets the active environment, which may cause Visual Studio to briefly become non-responsive while it loads the IntelliSense database. Environments with many packages may be non-responsive for longer. |
| Visit the distributor's website | Opens a browser to the URL provided by the Python distribution. Python 3.x, for example, goes to python.org. |
| Open interactive window | Opens the [interactive (REPL) window](interactive-repl.md) for this environment within Visual Studio, applying any [startup scripts (see below)](#startup-scripts). |
| Use IPython interactive mode | When set, opens the interactive window with IPython by default. This enabled inline plots as well as the extended IPython syntax such as `name?` to view help and `!command` for shell commands. This option is recommended when using an Anaconda distribution, as it requires extra packages. For more information, see [Using IPython in the Interactive Window](interactive-repl-ipython.md). |
| Open in PowerShell | Starts the interpreter in a PowerShell command window. |
| (Folder links) | Provide you quick access to the environment's installation folder, the python.exe interpreter, and the pythonw.exe interpreter. The first opens in Windows Explorer, the latter two open a console window. |

#### Startup scripts

As you use interactive windows in your everyday workflow, you likely develop helper functions that you use regularly. For example, you may create a function that opens a DataFrame in Excel, and then save that code as a startup script so that it's always available in the interactive window.

Startup scripts contain code that the interactive window loads and runs automatically, including imports, function definitions, and literally anything else. Such scripts are referenced in two ways:

1. When you install an environment, Visual Studio creates a folder `Documents\Visual Studio 2017\Python Scripts\<environment>` where &lt;environment&gt' matches the name of the environment. You can easily navigate to the environment-specific folder with the **Explore interactive scripts** command. When you start the interactive window for that environment, it loads and runs whatever `.py` files are found here in alphabetical order.

1. The **Scripts** control in **Tools > Options > Python Tools > Interactive Windows** tab (see [Interactive windows options](options.md#interactive-windows-options)) is intended to specify an additional folder for startup scripts that are loaded and run in all environments. However, this feature doesn't work at present.


### Configure tab

If shown, contains details as described in the table below. If this tab isn't present, it means that Visual Studio is managing all the details automatically.

![Python Environments configure tab](media/environments-configure-tab.png)

| Field | Description |
| --- | --- |
| **Description** | The name to give the environment. |
| **Prefix path** | The base folder location of the interpreter. By filling this value and clicking **Auto Detect**, Visual Studio attempts to fill in the other fields for you. |
| **Interpreter path** | The path to the interpreter executable, commonly the prefix path followed by `python.exe` |
| **Windowed interpreter** | The path to the non-console executable, often the prefix path followed by `pythonw.exe`. |
| **Library path** | Specifies the root of the standard library, but this value may be ignored if Visual Studio is able to request a more accurate path from the interpreter. |
| **Language version** | Selected from the drop-down menu. |
| **Architecture** | Normally detected and filled in automatically, otherwise specifies 32-bit or 64-bit. |
| **Path environment variable** | The environment variable that the interpreter uses to find search paths. Visual Studio changes the value of the variable when starting Python so that it contains the project's search paths. Typically this property should be set to `PYTHONPATH`, but some interpreters use a different value. |

### pip tab

Manages the packages installed in the environment, allowing you also to and search for and install new ones (including any dependencies). Searching filters your currently installed packages and [PyPI](https://pypi.python.org). You can also directly enter any `pip install` command in the search box, including flags such as `--user` or `--no-deps`.

![Python environments pip tab](media/environments-pip-tab.png)

Installing a package creates subfolders within the environment's `Lib` folder on the file system. For example, if you have Python 3.6 installed in `c:\Python36`, packages are installed in `c:\Python36\Lib`; if you have Anaconda3 installed in `c:\Program Files\Anaconda3` then packages are installed in 
`c:\Program Files\Anaconda3\Lib`.

In the latter case, because the environment is located in a protected area of the file system, `c:\Program Files`, Visual Studio must run `pip install` elevated to allow it to create package subfolders. When elevation is required, Visual Studio displays the prompt, "Administrator privileges may be required to install, update or remove packages for this environment":

![Elevation prompt for package installation](media/environments-pip-elevate.png)

**Elevate now** grants administrative privileges to pip for a single operation, subject also to any operating system prompts for permissions. Selecting **Continue without Administrator privileges** attempts to install the package, but pip fails when trying to create folders with output such as "error: could not create 'C:\Program Files\Anaconda3\Lib\site-packages\png.py': Permission denied."

Selecting **Always elevate when installing or removing packages** prevents the dialog from appearing for the environment in question. To make the dialog appear again, go to **Tools > Options > Python Tools > General** and select the button, **Reset all permanently hidden dialogs**. 

In that same options tab, you can also select **Always run pip as administrator** to suppress the dialog for all environments. See [Options - General tab](options.md#general-options).


### IntelliSense tab

Shows the current status of the IntelliSense completion database:

![Python Environments IntelliSense tab](media/environments-intellisense-tab.png)

The database contains metadata for all the environment's libraries and improves IntelliSense speed and reduces memory usage. When Visual Studio detects a new environment (or you add one), it automatically begins to compile the database by analyzing the library source files. This process can take anywhere from a minute to an hour or more depending on what's installed. (Anaconda, for example, comes with many libraries and takes some time to compile the database.) Once complete, you get detailed IntelliSense and don't need to refresh the database again (with the **Refresh DB** button) until you install more libraries.

Libraries for which data haven't been compiled are marked with a **!**; if an environment's database isn't complete, a **!** also appears next to it in the main environment list.

## Global environments

Global (or system-wide) environments are available to all of your projects on a machine. Visual Studio usually detects global environments automatically, and they can be viewed in the Python Environments window. If not, you can add an environment manually as described earlier under [Managing Python environments in Visual Studio](#managing-python-environments-in-visual-studio).

Visual Studio uses the default environment for all new projects for executing, debugging, checking syntax, displaying import and member completions, and any other tasks that require an environment. Changing the default environment affects all projects that have not had a [project-specific environment](#project-specific-environments) added, as described next.

## Project-specific environments

Project-specific environments ensure that a project always runs in a particular environment, ignoring the default global environment. For example, if the global default environment is CPython but a project requires IronPython and certain libraries that aren't installed in the global environment, then a project-specific environment is necessary.

Project environments are listed in Solution Explorer under the Python Environments node. The bold entry is currently active, and Visual Studio uses it for debugging, import and member completions, syntax checking, and any other tasks that require an environment:

![Project environments displayed in Solution Explorer](media/environments-project.png)

To activate a different environment for the project, right-click that environment and select **Activate Environment**.

Any global environment can be added as a project environment by right-clicking **Python Environments** and selecting **Add/Remove Python Environments...**. From the displayed list you can select or deselect those environments that are available in your project.

![Add/Remove Python Environments dialog](media/environments-add-remove.png)

In Solution Explorer, you can also expand the environment to show its installed packages (those you can import and use in your code when the environment is active):

![Python packages for an environment in Solution Explorer](media/environments-installed-packages.png)

To install new packages, right-click the environment, select **Install Python Package...**, and enter the name of the desired package. Packages (and dependencies) are downloaded from the [Python Package Index (PyPI)](https://pypi.python.org/pypi), where you can also search for available packages. Visual Studio's status bar and output window shows information about the install. To uninstall a package, right-click it select **Remove**.

> [!Note]
> Python's package management support is currently under development by the core Python development team. The displayed entries may not always be accurate, and installation and uninstallation may not be reliable or available. Visual Studio uses the pip package manager if available, and downloads and installs it when required. Visual Studio can also use the easy_install package manager. Packages installed using pip or easy_install from the command line are also displayed.

> [!Tip]
> A common situation where pip fails to install a package is when the package includes source code for native components in `*.pyd` files. Without the required version of Visual Studio installed, pip cannot compile these components. The error message displayed in this situation is `error: Unable to find vcvarsall.bat`. `easy_install` is often able to download pre-compiled binaries, and you can download a suitable compiler for older versions of Python from [http://aka.ms/VCPython27](http://aka.ms/VCPython27). For more details, see [How to deal with the pain of "unable to find vcvarsallbat"](https://blogs.msdn.microsoft.com/pythonengineering/2016/04/11/unable-to-find-vcvarsall-bat/) on the Python tools team blog.


## Virtual Environments

Because packages installed into a global environment are available to all projects that use it, conflicts may occur when two projects require incompatible packages or different versions of the same package. To avoid such conflicts, Visual Studio provides the ability to create *virtual environments*, which are typically specific to a project.

Like any other Python environment, a virtual environment consists of a Python interpreter, a library, and a set of packages. In this case, though, the virtual environment uses the interpreter and library from one of your global environments (provided it supports virtual environments), but its packages are separate and isolated from the global and all other virtual environments. This isolation again avoids conflicts and minimizes the virtual environment's footprint to the approximate size of its packages. 

To create a virtual environment:

1. Right-click **Python Environments** in Solution Explorer and select **Add Virtual Environment...**, which brings up the following:

    ![Creating a virtual environment](media/environments-add-virtual-1.png)

1. Specify a name to create the virtual environment in your project path, or a full path to create it elsewhere. (To ensure maximum compatibility with other tools, use only letters and numbers in the name.)

1. Select a global environment as the base interpreter and click **Create**. If `pip` and `virtualenv` or `venv` packages are not available, they are downloaded and installed.

    If the provided path is an existing virtual environment, the base interpreter is detected and the create button changes to **Add**:

    ![Adding an existing virtual environment](media/environments-add-virtual-2.png)

An existing virtual environment can also be added by right-clicking **Python Environments** in Solution Explorer and selecting **Add Existing Virtual Environment...**. Visual Studio automatically detects the base interpreter using the `orig-prefix.txt` file in the environment's `lib` directory.

Once a virtual environment is added to your project, it appears in the **Python Environments** window, you can activate it like any other environment, and you can manage its packages. Right-clicking it and selecting **Remove** either removes the reference to the environment, or deletes the environment and all its files on disk (but not the base interpreter).

Note that one drawback to virtual environments is that they contain hard-coded file paths and thus cannot easily be shared or transported to other development machines. Fortunately, you can use the `requirements.txt` file as described in the next section.

## Managing required packages

If you're sharing a project with others, using a build system, or plan to [publish it to Microsoft Azure](template-azure-cloud-service.md), you need to specify the external packages it requires. The recommended approach is to use a [requirements.txt file](http://pip.readthedocs.org/en/latest/user_guide.html#requirements-files) (readthedocs.org) that contains a list of commands for pip that installs the required versions of dependent packages.

Technically, any filename may be used to track requirements (by using `-r <full path to file>` when installing a package), but Visual Studio provides specific support for `requirements.txt`:

- If you've loaded a project that contains `requirements.txt` and wish to install all the packages listed in that file, right-click the project and select **Install from requirements.txt**:

    ![Install from requirements.txt](media/environments-requirements-txt-install.png)

- When you have all the necessary packages installed in a project, you can right-click the project in Solution Explorer and select **Generate requirements.txt** to create the necessary file. If the file already exists, a prompt appears for how to update it:

    ![Update requirements.txt options](media/environments-requirements-txt-replace.png)

    - **Replace entire file** removes all items, comments, and options that exist.
    - **Refresh existing entries** detects package requirements and updates the version specifiers to match the version you currently have installed.
    - **Update and add entries** refreshes any requirements that are found, and adds all other packages to the end of the file.

Because `requirements.txt` files are intended to freeze the requirements of your project, all installed packages are written with precise versions. Using precise versions ensures that you can easily reproduce your environment on another machine. Packages are included even if they were installed with a version range, as a dependency of another package, or with an installer other than pip.

If a` requirements.txt` file exists when adding a new virtual environment, the **Add Virtual Environment** dialog displays an option to install the packages automatically, making it easy to recreate an environment on another machine:

![Create virtual environment with requirements.txt](media/environments-requirements-txt.png)

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

## Search paths

With typical Python usage, the `PYTHONPATH` environment variable (or `IRONPYTHONPATH`, etc.) provides the default search path for module files. That is, when you use an `import <name>` statement, Python first searches its built-in modules for a matching name, then searches folder containing the Python code you're running, then searches the "module search path" as defined by the applicable environment variable. (See [The Module Search Path](https://docs.python.org/2/tutorial/modules.html#the-module-search-path) and [Environment variables](https://docs.python.org/2/using/cmdline.html#envvar-PYTHONPATH) in the core Python documentation.)

The search path environment variable, however, is ignored by Visual Studio, even when it's been set for the entire system. It's ignored, in fact, precisely *because* it's set for the entire system and thus raises certain questions that cannot be answered automatically: Are the referenced modules meant for Python 2.7 or Python 3.3? Are they going to override standard library modules? Is the developer aware of this behavior or is it a malicious hijacking attempt?

Python support in Visual Studio thus provides a means to specify search paths directly in both environments and projects. Search paths are passed as the value of `PYTHONPATH` (or equivalent) when you debug or execute your script from Visual Studio. By adding search paths, Visual Studio inspects the libraries in those locations and builds IntelliSense databases for them (constructing the database may take some time depending on the number of libraries).

To add a search path, right-click on the **Search Paths** item in Solution Explorer, select **Add Folder to Search Path...**, and select the folder to include. This path is used for any environment associated with the project.

Files with a `.zip` or `.egg` extension can also be added as search paths by selecting **Add Zip Archive to Search Path...**. As with folders, the contents of these files are scanned and made available to IntelliSense.

> [!Note]
> It is possible to add a search path to Python 2.7 modules while you are using Python 3.3, and you may see errors as a result.

If you are regularly using the same search paths and the contents do not often change, it may be more efficient to install it into your site-packages folder. It's then be analyzed and stored in the IntelliSense database, is always be associated with the intended environment, and does not require a search path to be added for each project.
