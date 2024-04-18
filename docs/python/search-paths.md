---
title: Use Python folders in search paths
description: Use the Add Folder to Search Path option in Solution Explorer to specify search paths for your Python environments and projects and avoid using system-wide variables.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use Python folders in my search path for environments and projects in Visual Studio so that I can avoid using system-wide variables.
---

# Use Python folders in Visual Studio search paths

In a typical Python program, the `PYTHONPATH` environment variable (or `IRONPYTHONPATH`, and so on) provides the default search path for module files. The `from <name> import...` or `import <name>` statements instruct Python to search the specific locations for files that match the specified `<name>`. The locations are searched in the following order:

1. Python built-in modules
1. The folder that contains the currently running Python code
1. The "module search path" as defined by the applicable environment variable (For more information, see [The Module Search Path](https://docs.python.org/2/tutorial/modules.html#the-module-search-path) and [Environment variables](https://docs.python.org/2/using/cmdline.html#envvar-PYTHONPATH) in the core Python documentation.)

Visual Studio ignores the search path environment variable, even when the variable is set for the entire system. The reason is because use of the variable raises questions that can't be easily answered, such as:

- *Do the referenced modules expect an installation of Python 2.7, Python 3.6, or other version?*
- *Should files found in the search path environment variable override standard library modules?*
- *Is any override behavior expected and addressed, or could the action be malicious?*

To assist developers, Visual Studio provides a way to specify search paths directly in both Python environments and projects. Code that you run or debug in Visual Studio receives search paths from the `PYTHONPATH` environment variable and equivalent variable. By adding search paths, Visual Studio inspects the libraries in the specified locations and builds IntelliSense databases for the libraries as needed. (In Visual Studio 2017 version 15.5 and earlier, constructing the database can take some time depending on the number of libraries).

## Prerequisites 

- Visual Studio. To install the product, follow the steps in [Install Visual Studio](../install/install-visual-studio.md).

- Python folders that you want to add to your search paths.

## Add Python folders to search paths

Follow these steps to add a Python folder to Visual Studio search paths:

1. In **Solution Explorer**, expand your Python project node, right-click **Search Paths**, and select **Add Folder to Search Path**:

   :::image type="content" source="media/search-paths-command.png" alt-text="Screenshot that shows how to access the Add Folder to Search Path command on Search Paths for a Python project in Solution Explorer." border="false" lightbox="media/search-paths-command.png":::

1. In the dialog, browse to the location of the folder that you want to add to the recognized search paths.

1. Select the folder, and then choose **Select folder**.

After folders are added to the search paths, Visual Studio uses those paths for any environment associated with the project.

> [!NOTE]
> If your environment is based on Python 3 and you attempt to add a search path to Python 2.7 modules, you might see errors.

## Add zip and egg files to search paths

You can add files with a `.zip` or `.egg` extension to your search paths with the **Add Zip Archive to Search Path** option. As with folders, the contents of these files are scanned and made available to IntelliSense.

## Related content

- [Manage Python environments in Visual Studio](managing-python-environments-in-visual-studio.md)
- [Select an interpreter for a project](selecting-a-python-environment-for-a-project.md)
- [Use `requirements.txt` for dependencies](managing-required-packages-with-requirements-txt.md)
- [Python Environments window reference](python-environments-window-tab-reference.md)
