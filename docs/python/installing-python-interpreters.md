---
title: Select and Install Python Interpreters
description: Review a complete list of Python interpreters that are supported in Visual Studio and follow brief instructions on where to find their installers.
ms.date: 07/28/2025
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to review considerations about Python interpreters so that I can install and work with the appropriate Python interpreter in my version of Visual Studio.

---
# Install Python interpreters

There are several options for installing Python interpreters to work with Visual Studio. You can install an interpreter when you install the Python workload, or you can install an interpreter after a workload is present. Interpreters can also be installed manually outside of the Visual Studio Installer.

When you install the Python development workload in Visual Studio 2017 and later, Python 3 (64-bit) also installs by default. As an option, you can choose to install the 32-bit or 64-bit version of Python 2 or Python 3, along with Miniconda (Visual Studio 2019) or Anaconda 2/Anaconda 3 (Visual Studio 2017). For installation steps, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

An alternate approach is to install standard Python interpreters by using the **Add Environment** feature in Visual Studio. This option is available in the **Python Environments** window and the Python toolbar.

Python interpreters can also be installed manually outside of the Visual Studio Installer. Suppose you install Anaconda 3 before you install Visual Studio. You don't need to reinstall Anaconda through the Visual Studio Installer. You can also install a newer version of an interpreter if it isn't yet listed in the Visual Studio Installer. 

## Prerequisites

- Visual Studio supports Python version 3.7. While it's possible to use an earlier version of Visual Studio to edit code written in earlier versions of Python, those versions of Python aren't officially supported. Visual Studio features such as IntelliSense and debugging might not work with earlier versions of Python.

- For Visual Studio 2015 and earlier, use Python 3.5 or earlier. You must manually install one of the Python interpreters.

### Anaconda distributions

Although Visual Studio offers to install the Anaconda distribution, your use of the distribution and other packages from Anaconda Repository are bound by the [Anaconda terms of service](https://www.anaconda.com/terms-of-service). These terms might require some organizations to pay Anaconda for a commercial license, or else configure the tools to access an alternate repository. For more information, see the [Conda channels documentation](https://docs.conda.io/projects/conda/en/latest/user-guide/concepts/channels.html).

## Review Python interpreters

The following table lists Python interpreters that can be used with Visual Studio.

| Interpreter | Description | Notes |
| --- | --- | --- |
| [CPython](https://www.python.org) | The *native* and most commonly used interpreter, available in 32-bit and 64-bit versions (32-bit recommended). Includes the latest language features, maximum Python package compatibility, full debugging support, and interop with [IPython](https://ipython.org). To determine which version of Python to install, see [Should I use Python 2 or Python 3?](https://wiki.python.org/moin/Python2orPython3).  | Visual Studio 2015 and earlier don't support Python 3.6 or later, and can return errors like **Unsupported python version 3.6**. For Visual Studio 2015 and earlier, use Python 3.5 or earlier. |
| [IronPython](https://github.com/IronLanguages/ironpython2) | A .NET implementation of Python, available in 32-bit and 64-bit versions. Provides C#/F#/Visual Basic interop, access to .NET APIs, standard Python debugging (but not C++ mixed-mode debugging), and mixed IronPython/C# debugging. | IronPython doesn't support virtual environments. |
| [Anaconda](https://anaconda.com) | An open data science platform powered by Python. Includes the latest version of CPython and most of the difficult-to-install packages. | If you're unable to decide on an interpreter, we recommend using Anaconda. |
| [PyPy](https://www.pypy.org) | A high-performance tracing JIT implementation of Python. Good for long-running programs and situations where you identify performance issues but can't find other resolutions. | Works with Visual Studio but with limited support for advanced debugging features. |
| [Jython](https://www.jython.org) | An implementation of Python on the Java Virtual Machine (JVM). Similar to IronPython, code running in Jython can interact with Java classes and libraries. However, many of the libraries intended for CPython might not be accessible. | Works with Visual Studio but with limited support for advanced debugging features. |

## Detect your environment

Visual Studio shows all known environments in the [**Python Environments**](managing-python-environments-in-visual-studio.md#the-python-environments-window) window. It automatically detects updates to existing interpreters.

If Visual Studio doesn't detect an installed environment, see [Manually identify an existing environment](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment).

If you want to provide new forms of detection for Python environments, see [PTVS Environment Detection](https://github.com/Microsoft/PTVS/wiki/Extensibility-Environments) on GitHub.

### Registry entries

Visual Studio (all versions) automatically detects each installed Python interpreter and its environment by checking the registry according to [PEP 514 - Python registration in the Windows registry](https://peps.python.org/pep-0514/). Python installations are typically found under the **HKEY_LOCAL_MACHINE\SOFTWARE\Python** (32-bit) and **HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Python** (64-bit) key within nodes for the distribution, such as **PythonCore** (CPython) and **ContinuumAnalytics** (Anaconda).

## Move an interpreter

If you move an existing interpreter to a new location by using the file system, Visual Studio doesn't automatically detect the change.

- If you originally specified the location of the interpreter through the **Python Environments** window, you can edit its environment by using the **Configure** tab in that window to identify the new location. For more information, see [Manually identify an existing environment](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment).

- If you installed the interpreter by using an installer program, use the following steps to reinstall the interpreter in the new location:

   1. Restore the Python interpreter to its original location.
   1. Uninstall the interpreter by using its installer, which clears the registry entries.
   1. Reinstall the interpreter at the new location.
   1. Restart Visual Studio, which should autodetect the new location in place of the old location.

This process ensures that the registry entries that identify the interpreter's location, which Visual Studio uses, are properly updated. Using an installer also handles any other side effects that might exist.

## Related content

- [Create and manage Python environments in Visual Studio](managing-python-environments-in-visual-studio.md)
- [Select a Python environment for a project in Visual Studio](selecting-a-python-environment-for-a-project.md)
- [Manage required Python packages with requirements.txt](managing-required-packages-with-requirements-txt.md)
- [Use Python folders in Visual Studio search paths](search-paths.md)
- [Python Environments window tabs reference](python-environments-window-tab-reference.md)
