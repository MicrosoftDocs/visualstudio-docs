---
title: Selecting and installing Python interpreters
description: A complete list of Python interpreters that are supported in Visual Studio with brief instructions on where to find their installers.
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

# Installing Python interpreters

By default, installing the Python development workload in Visual Studio 2017 also installs Python 3 (64-bit). You can optionally choose to install 32-bit and 64-bit versions of Python 2, Python 3, Anaconda 2, and Anaconda 3, as described in [Installation](installing-python-support-in-visual-studio.md).

You can also manually install any of the interpreters listed in the table below outside of the Visual Studio installer. For example, if you installed Anaconda 3 before installing Visual Studio, you don't need to install it again through the Visual Studio installer.

For **Visual Studio 2015 and earlier**, you must manually install one of the interpreters.

Visual Studio (all versions) automatically detects each installed Python interpreter and its environment by checking the registry (following [PEP 514 - Python registration in the Windows registry](https://www.python.org/dev/peps/pep-0514/)).

If Visual Studio does not detect an installed environment, see [Manually identify an existing environment](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment).

Visual Studio shows all known environments in the [Python Environments window](managing-python-environments-in-visual-studio.md), and automatically detects updates to existing interpreters.

| Interpreter | Description |
| --- | --- |
| [CPython](https://www.python.org/) | The "native" and most commonly-used interpreter, available in 32-bit and 64-bit versions (32-bit recommended). Includes the latest language features, maximum Python package compatibility, full debugging support, and interop with [IPython](http://ipython.org/). See also: [Should I use Python 2 or Python 3?](http://wiki.python.org/moin/Python2orPython3). Note that Visual Studio 2015 and earlier do not support Python 3.6 and can give the error "Unsupported python version 3.6". Use Python 3.5 or earlier instead. |
| [IronPython](https://github.com/IronLanguages/ironpython2) | A .NET implementation of Python, available in 32-bit and 64-bit versions, providing C#/F#/Visual Basic interop, access to .NET APIs, standard Python debugging (but not C++ mixed-mode debugging), and mixed IronPython/C# debugging. IronPython, however, does not support virtual environments. |
| [Anaconda](https://www.continuum.io) | An open data science platform powered by Python, and includes the latest version of CPython and most of the difficult-to-install packages. We recommend it if you can't otherwise decide. |
| [PyPy](http://www.pypy.org/) | A high-performance tracing JIT implementation of Python that's good for long-running programs and situations where you identify performance issues but cannot find other resolutions. Works with Visual Studio but with limited support for advanced debugging features. |
| [Jython](http://www.jython.org/) | An implementation of Python on the Java Virtual Machine (JVM). Similar to IronPython, code running in Jython can interact with Java classes and libraries, but may not be able to use many libraries intended for CPython. Works with Visual Studio but with limited support for advanced debugging features. |

Developers that want to provide new forms of detection for Python environments, see [PTVS Environment Detection](https://github.com/Microsoft/PTVS/wiki/Extensibility-Environments) (github.com).

## Moving an interpreter

If you move an existing interpreter to a new location using the file system, Visual Studio doesn't automatically detect the change.

- If you originally specified the location of the interpreter through the **Python Environments** window, the edit its environment using the **Configure** tab in that window to identify the new location. See [Manually identify an existing environment](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment).

- If you installed the interpreter using an installer program, then use the following steps to reinstall the interpreter in the new location:

  1. Restore the Python interpreter to its original location.
  2. Uninstall the interpreter using its installer, which clears the registry entries.
  3. Reinstall the interpreter at the desired location.
  4. Restart Visual Studio, which should auto-detect the new location in place of the old location.

Following this process ensures that the registry entries that identify the interpreter's location, which Visual Studio uses, are properly updated. Using an installer also handles any other side effects that may exist.

## See also

- [Managing Python environments](managing-python-environments-in-visual-studio.md)
- [Select an interpreter for a project](selecting-a-python-environment-for-a-project.md)
- [Using requirements.txt for dependencies](managing-required-packages-with-requirements-txt.md)
- [Search paths](search-paths.md)
- [Python Environments window reference](python-environments-window-tab-reference.md)