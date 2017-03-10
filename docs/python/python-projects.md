---
title: "Python Projects in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/7/2017"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-python"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c9c53f76-d0ef-4095-8b39-b7eb9bb33aba
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

# Python Projects

Python applications are typically defined using only folders and files, but this can become complex as applications become larger and perhaps involve auto-generated files, JavaScript for web applications, and so on. To help manage this complexity, You can create Visual Studio projects for Python applications. A Python project (a `.pyproj` file) identifies all the source and content files associated with your project, contains build information for each file, maintains the information to integrate with source-control systems, and helps you organize your application into logical components.

In addition, projects are always managed within a Visual Studio *solution*, which can contain any number of projects that might reference one another. For example, a Python project can reference a C++ project for an extension module, such that Visual Studio will automatically build the C++ project (if necessary) when you start debugging the Python project. (For a general discussion, see [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md).)

![Python project in Solution Explorer](media/projects-solution-explorer.png)

Visual Studio provides a variety of Python project templates to quickly set up a number of application structures, including a template to create a project from an existing folder tree and a template to create a clean, empty project. See [Project templates](#project-templates) below for an index.

In this topic:

- [Adding files, assigning a startup file, and setting environments](#adding-file-assigning-a-startup-file-and-setting-environments)
- [Project templates](#project-templates)
- [Linked files](#linked-files)
- [References](#references)

<a name="lightweight-usage-project-free"</a>
> [!Tip]
> Even without a project, Visual Studio works well with Python code, as you can open a Python file by itself and enjoy auto-complete, IntellSense, and debugging (by right-clicking in the editor and selecting **Start [with | without] Debugging**). Because such code will always use the default global environment, however, you may see incorrect completions or errors if the code is meant for a different environment. Furthermore, Visual Studio analyzes all files and packages in the folder from which the single file is opened, which could consume considerable CPU time.
>
> It's a simple matter to create a Visual Studio project from existing code, as described below in [Creating a project from existing files](#creating-a-project-from-existing-files).

For an introduction to Python projects in Visual Studio, see [Getting Started with Python Tools Part 2: Projects](https://youtu.be/KHPoVpL7zHg?list=PLReL099Y5nRdLgGAdrb_YeTdEnd23s6Ff) (youtube.com, 3m18s).

> [!VIDEO https://www.youtube.com/embed/KHPoVpL7zHg]

Also see the video [Deep Dive: Using source control with Python projects](https://youtu.be/Aq8eqApnugM) (youtube.com, 8m55s).

> [!VIDEO https://www.youtube.com/embed/Aq8eqApnugM]


## Adding files, assigning a startup file, and setting environments

As you develop your application, you'll typically need to add new files of different types to the project. This is easily done by right-clicking the project and selecting **Add > Existing Item...**, with which you browse for a file to add, or **Add > New Item...**, which brings up a dialog with a variety of item templates including empty python files, a python class, a unit test, and various files related to web applications. We encourage you to explore these options with a test project to learn what's available in your version Visual Studio.

Each Python project has one assigned start-up file, shown in boldface in Solution Explorer. This is the file that's run when you start debugging (F5 or **Debug > Start Debugging**) or execute your project in the interactive window (Shift+Alt+F5 or **Debug > Execute Project in Python Interactive**). To change it, right-click the new file and select **Set as Startup File**.

A new project is always associated with the default global Python environment. To associate the project with a different environment (including virtual environments), right-click with **Python Environments** node in the project, select **Add/Remove Python Environments**, and select the ones you want. To change the active environment, right click the desired environment and select **Activate Environment** as shown below. For more details, see [Python Environments](python-environments.md#project-specific-environments).

![Activating an environment for a Python project](media/projects-activate-environment.png)

<a name="project-types"</a>
## Project templates

Visual Studio gives you a number of ways to set up a Python project, either from scratch or from existing code. To use a template, select the **File > New > Project...** menu command or right-click the solution in Solution Explorer and select **Add > New Project...**, both of which bring up the **New Project** dialog below. To see Python-specific templates, either search on "Python" or select the **Templates > Other Languages > Python** node:

![New project dialog with Python templates](media/projects-new-project-dialog.png)

The following table summarizes the templates available in Visual Studio 2017 (not all templates are available in all previous versions):

| Template | Description | 
| --- | --- |
| [From Existing Python Code](#creating-a-project-from-existing-files) | Creates a Visual Studio project from existing Python code in a folder structure.  |
| Python Application | A basic project structure for a new Python application with a single, empty source file. By default, the project runs in the console interpreter of the default global environment, which you can change by [assigning a different environment](python-environments.md#project-specific-environments). |
| [Azure Cloud Service](template-azure-cloud-service.md) | A project for an Azure Cloud Service written in Python. |
| [Web Projects](template-web.md) | Projects for web servers based on various frameworks including Bottle, Django, Flask, and Flask/Jade. |
| IronPython Application | Similar to the Python Application template, but uses IronPython by default enabling .NET interop and mixed-mode debugging with .NET languages. |
| IronPython WPF Application | A project structure using IronPython with Windows Presentation Foundation XAML files for the application's user interface. Visual Studio provides a XAML UI designer, code-behind can be written in Python, and the application runs without displaying a console. |
| IronPython Silverlight Web Page | An IronPython project that runs in a browser using Silverlight. The application's Python code is included in the web page as script. A boilerplate script tag pulls down some JavaScript code which initializes IronPython running inside of Silverlight, from which your Python code can interact with the DOM. |
| IronPython Windows Forms Application | A project structure using IronPython withUI created using code with Windows Forms. The application runs without displaying a console. |
| Background Application (IoT) | Supports deploying Python projects to run as background services on devices. Visit the [Windows IoT Dev Center](https://dev.windows.com/en-us/iot) for more information. |

<a name="create-project-from-existing-files"</a>
### Creating a project from existing files

1. Select the **File > New > Project...** menu, then select the **From Existing Python Code** template.
1. In the following dialog, set the path to your existing code, a filter for file types, and any search paths that your project requires, then select **Next**:

    ![New Project from Existing Code, step one](media/projects-from-existing-1.png)

1. Choose an environment for the project and the startup file, then press **Next**. (Note that the dialog shows only files in the root of the folder tree; if the file you want is in a subfolder, leave the startup file blank and set it later in Solution Explorer).

    ![New Project from Existing Code, step two](media/projects-from-existing-2.png)

1. Select the location to save the project file (this does not move or copy the original source files, so if you want a copy you should make one before using the template). In this dialog you can also include auto-detection of virtual environments and customize the project for different web frameworks.

    ![New Project from Existing Code, step three](media/projects-from-existing-3.png)

1.  Select **Finish** and Visual Studio creates the project and open it in Solution Explorer. If you want to move the .pyproj file elsewhere, select it in Solution Explorer and choose **File > Save As**. This updates file references in the project but will not move any code file.

## Linked files

Linked files are those that are brought into a project but typically reside outside of the application's project folders. They appear in Solution Explorer as normal files with a overlaid shortcut icon: ![Linked file icon](media/projects-linked-file-icon.png)

Linked files are specified in the `.pyproj` file using the normal `<Compile Include="...">` element. They can be implicit linked files if they use a relative path outside of the directory structure, or they can be explicit link files by specifying their path within Solution Explorer:

```xml
<Compile Include="..\test2.py">
    <Link>MyProject\test2.py</Link>
</Compile>
```

Linked files will be ignored under any of the following conditions:

- The linked file contains Link metadata and the path specified in the Include attribute lives within the project directory
- The linked file duplicates a file which exists within the project hierarchy
- The linked file contains Link metadata and the Link path is a relative path outside of the project hierarchy
- The link path is rooted

### Working with linked files

To add an existing item as a link, right-click the folder in the project where you wish to add the file, then select **Add > Exiting Item...**. In the dialog that appears, select a file and choose **Add as Link** from the drop down on the **Add** button. Provided that there are no conflicting files, this creates a link in the selected folder. However, the link is not added if there is already a file with the same name or a link to that file already exists in the project.

If you attempt to link to a file that already exists in the project folders, it will be added as a normal file and not as a link. To convert a file into a link, select **File > Save As** to save the file to a location outside of the project hierarchy; Visual Studio will automatically convert it into a link. Similarly, a link can be converted back by using **File > Save As** to save the file somewhere within the project hierarchy. 

If you move a linked file in Solution Explorer, the link will be moved but the actual file is unaffected. Similarly, deleting a link will remove the link without affecting the file.

Linked files cannot be renamed.

## References

Visual Studio projects support adding references to projects and extensions, which appear under the **References** node in Solution Explorer:

![Extension references in Python projects](media/projects-extension-references.png)

Extension references typically indicate dependencies between projects and are used to provide IntelliSense at design time or linking at compile time. Python projects use references in a similar fashion, but due to the dynamic nature of Python they are primarily used at design time to provide improved IntelliSense. They can also be used for deployment to Microsoft Azure to install additional dependencies.

### Extension modules

A reference to a `.pyd` file enables IntelliSense for the generated module. Visual Studio loads the `.pyd` file is loaded into the Python interpreter and introspects its types types and functions. It also attempts to parse the doc strings for functions to provide signature help.

If at any time the extension module is updated on disk, Visual Studio re-analyzes the module in the background. This has no effect on runtime behavior but some completions won't be available until analysis is complete.

You may also need to add a [search path](python-environments.md#search-paths) to the folder containing the module.

### .NET projects

When working with IronPython you can add references to .NET assemblies to enable IntelliSense. For .NET projects in your solution, right-click the **References** node in your Python project, select **Add Reference**, select the **Projects** tab, and browse to the desired project. For DLLs that you've downloaded separately, select the **Browse** tab instead and browse to the desired DLL.

Because references in IronPython are not available until a call to `clr.AddReference('AssemblyName')` is made, you'll also need to add a `clr.AddReference` call to the assembly.

### WebPI projects

You can add references to WebPI product entries for deployment to Microsoft Azure Cloud Service where you can install additional components via the WebPI feed. By default, the feed displayed is Python specific and includes Django, CPython, and other core components. You can also select your own feed as shown below. When publishing to Microsoft Azure, a setup task installs all of the referenced products.

![WebPI References](media/projects-webPI-components.png)