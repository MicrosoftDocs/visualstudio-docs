---
title: "Quickstart: Creating a Python project from existing code in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 9/25/2017
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3fd90afb-8d76-4c93-81f2-e10edbed2069
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Quickstart: create a Python project from existing code

Once you've [installed Python support in Visual Studio 2017](quickstart-01-install.md), it's easy to bring existing Python code into a Visual Studio project. A project is used to organize source files, build settings, and configurations.

> [!Important]
> The process described here does not move or copy the original source files. If you want to work with a copy, duplicate the folder first.

1. Launch Visual Studio.

1. Select **File > New > Project**.

1. In the **New Project** dialog, search for "Python", select the "From Existing Python code" template, give the project a name and location, and select **OK**.

1. In the wizard that appears, set the path to your existing code, a filter for file types, and any search paths that your project requires, then select **Next**. If you don't know what search paths are, leave that field blank.

    ![New Project from Existing Code, step 1](media/projects-from-existing-1.png)

1. In the next dialog, select the startup file for your project and leave other values set to the defaults. Note that the dialog shows only files in the root folder; if the file you want is in a subfolder, leave the startup file blank and set it later in Solution Explorer (described below). 

    ![New Project from Existing Code, step 2](media/projects-from-existing-2.png)

1. Select the location in which to save the project file (a `.pyproj` file on disk). If applicable, you can also include auto-detection of virtual environments and customize the project for different web frameworks. If you're unsure of these options, leave them set to the defaults.

    ![New Project from Existing Code, step 3](media/projects-from-existing-3.png)

1.  Select **Finish** and Visual Studio creates the project and opens it in Solution Explorer. If you want to move the `.pyproj` file elsewhere, select it in Solution Explorer and choose **File > Save As**. This action updates file references in the project but does not move any code files.

1. To set a different startup file, locate the file in Solution Explorer, right-click, and select **Set as Startup File**.

1. If desired, run the program by pressing Ctrl+F5 or selecting **Debug > Start Without Debugging**. 


## Next Steps

> [!div class="nextstepaction"]
> [Tutorial: Working with Python in Visual Studio](vs-tutorial-01-01.md)

## See Also

- [Creating an environment for an existing Python interpreter](python-environments.md#creating-an-environment-for-an-existing-interpreter).
- [Install Python support in Visual Studio 2015 and earlier](installation.md).
- [Install locations](installation.md#install-locations).
