---
title: Write C++ extensions for Python
description: Explore how to create a C++ extension for Python by using Visual Studio, CPython, and PyBind11, including mixed-mode debugging.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

#customer intent: As a developer, I want to work with Python, C++, CPython, and PyBind11 in Visual Studio so that I can create and debug a C++ extension for Python.
---

# Create a C++ extension for Python in Visual Studio

In this article, you build a C++ extension module for CPython to compute a hyperbolic tangent and call it from Python code. The routine is implemented first in Python to demonstrate the relative performance gain of implementing the same routine in C++.

Code modules written in C++ (or C) are commonly used to extend the capabilities of a Python interpreter. There are three primary types of extension modules:

- **Accelerator modules**: Enable accelerated performance. Because Python is an interpreted language, you can write an accelerator module in C++ for higher performance.
- **Wrapper modules**: Expose existing C/C++ interfaces to Python code or expose a more python-like API that's easy to use from Python.
- **Low-level system access modules**: Create system access modules to reach lower-level features of the `CPython` runtime, the operating system, or the underlying hardware.

This article demonstrates two ways to make a C++ extension module available to Python:

- Use the standard `CPython` extensions, as described in the [Python documentation](https://docs.python.org/3/c-api/).
- Use [PyBind11](https://github.com/pybind/pybind11), which we recommend for C++11 because of its simplicity. To ensure compatibility, make sure you're working with one of the more recent versions of Python.

The completed sample for this walkthrough is available on GitHub at [python-samples-vs-cpp-extension](https://github.com/Microsoft/python-sample-vs-cpp-extension).

## Prerequisites

- Visual Studio 2017 or later, with the Python development workload installed. The workload includes the Python native development tools, which add the C++ workload and toolsets necessary for native extensions. 

   :::image type="content" source="media/cpp-install-native.png" alt-text="Screenshot of a list of Python development options, highlighting the Python native development tools option." border="false" lightbox="media/cpp-install-native.png":::

   For more information about the installation options, see [Install Python support for Visual Studio](installing-python-support-in-visual-studio.md).

   > [!NOTE]
   > When you install the **Data science and analytical applications** workload, Python and the **Python native development tools** option are installed by default.

- If you install Python separately, be sure to select **Download debugging symbols** under **Advanced Options** in the Python installer. This option is required for you to use mixed-mode debugging between your Python code and native code.

## Create the Python application

Follow these steps to create the Python application.

1. Create a new Python project in Visual Studio by selecting **File** > **New** > **Project**.

1. In the **Create a new project** dialog, search for _python_. Select the **Python Application** template and select **Next**.

1. Enter a **Project name** and **Location**, and select **Create**.

   Visual Studio creates the new project. The project opens in **Solution Explorer** and the project file (_.py_) opens in the code editor.

1. In the _.py_ file, paste the following code. To experience some of the [Python editing features](editing-python-code-in-visual-studio.md), try entering the code manually.

   This code computes a hyperbolic tangent without using the math library, and it's what you accelerate later with Python native extensions.

   > [!TIP]
   > Write your code in pure Python before you rewrite it in C++. This way, you can more easily check to ensure that your native Python code is correct.

   ```python
   from random import random
   from time import perf_counter

   # Change the value of COUNT according to the speed of your computer.
   # The value should enable the benchmark to complete in approximately 2 seconds.
   COUNT = 500000
   DATA = [(random() - 0.5) * 3 for _ in range(COUNT)]

   e = 2.7182818284590452353602874713527

   def sinh(x):
       return (1 - (e ** (-2 * x))) / (2 * (e ** -x))

   def cosh(x):
       return (1 + (e ** (-2 * x))) / (2 * (e ** -x))

   def tanh(x):
       tanh_x = sinh(x) / cosh(x)
       return tanh_x

   def test(fn, name):
       start = perf_counter()
       result = fn(DATA)
       duration = perf_counter() - start
       print('{} took {:.3f} seconds\n\n'.format(name, duration))

       for d in result:
           assert -1 <= d <= 1, " incorrect values"

   if __name__ == "__main__":
       print('Running benchmarks with COUNT = {}'.format(COUNT))

       test(lambda d: [tanh(x) for x in d], '[tanh(x) for x in d] (Python implementation)')
   ```

1. Run the program by selecting **Debug** > **Start without Debugging** or select the keyboard shortcut **Ctrl+F5**.

   A command window opens to show the program output.

1. In the output, notice the amount of time reported for the benchmark process.

   For this walkthrough, the benchmark process should take approximately 2 seconds. 

1. As needed, adjust the value of the `COUNT` variable in the code to enable the benchmark to complete in about 2 seconds on your computer.

1. Run the program again and confirm the modified `COUNT` value produces the benchmark in about 2 seconds.

> [!TIP]
> When you run benchmarks, always use the **Debug** > **Start without Debugging** option.
> This method helps avoid the overhead that can incur when you run the code within the Visual Studio debugger.

## Create the core C++ projects

Follow these steps to create two identical C++ projects, _superfastcode_ and _superfastcode2_. Later, you use a different approach in each project to expose the C++ code to Python.

1. In **Solution Explorer**, right-click the solution name, and select **Add** > **New Project**.

   A Visual Studio solution can contain both Python and C++ projects, which is one of the advantages of using Visual Studio for Python development.

1. In the **Add a new project** dialog, set the **Language** filter to **C++**, and enter _empty_ in the **Search** box.

1. In the list of project template results, select **Empty project**, and select **Next**.

1. In the **Configure your new project** dialog, enter the **Project name**:

   - For the first project, enter the name _superfastcode_.
   - For the second project, enter the name _superfastcode2_.

1. Select **Create**.

Be sure to repeat these steps and create two projects.

> [!TIP]
> An alternative approach is available when you have the Python native development tools installed in Visual Studio. You can start with the **Python Extension Module** template, which pre-completes many of the steps described in this article.
>
> For the walkthrough in this article, starting with an empty project helps to demonstrate how to build the extension module step by step. After you understand the process, you can use the alternate template to save time when you write your own extensions.

### Add C++ file to project

Next, add a C++ file to each project.

1. In **Solution Explorer**, expand the project, right-click the **Source Files** node, and select **Add** > **New Item**.

1. In the list of file templates, select **C++ File (.cpp)**.

1. Enter the **Name** for the file as _module.cpp_, and then select **Add**.

   > [!IMPORTANT]
   > Be sure the file name includes the _.cpp_ extension. Visual Studio looks for a file with the _.cpp_ extension to enable display of the C++ project property pages.

1. On the toolbar, expand the **Configuration** dropdown menu and select your target configuration type:

   :::image type="content" source="media/cpp-set-configuration.png" alt-text="Screenshot that shows how to set the target configuration type for the C++ project in Visual Studio." border="false" lightbox="media/cpp-set-configuration.png":::

   - For a 64-bit Python runtime, activate the **x64** configuration.
   - For a 32-bit Python runtime, activate the **Win32** configuration.

Be sure to repeat these steps for both projects.

### Configure project properties

Before you add code to the new C++ files, configure the properties for each C++ module project and test the configurations to make sure everything is working.

You need to set the project properties for both the _debug_ and _release_ build configurations of each module.

1. In **Solution Explorer**, right-click the C++ module project (_superfastcode_ or _superfastcode2_), and select **Properties**.

1. Configure the properties for the _debug_ build of the module, and then configure the same properties for the _release_ build:

   At the top of the project **Property Pages** dialog, configure the following file configuration options:

   :::image type="content" source="media/cpp-set-project-options.png" alt-text="Screenshot that shows how to set the project build and platform options for the C++ file in Visual Studio." border="false" lightbox="media/cpp-set-project-options.png":::

   1. For the **Configuration**, select **Debug** or **Release**. (You might see these options with the **Active** prefix.) 
   
   1. For the **Platform**, select **Active (x64)** or **Active (Win32)**, depending on your selection in the preceding step.

      > [!NOTE]
      > When you create your own projects, you'll want to configure the _debug_ and _release_ configurations separately, according to your specific scenario requirements. In this exercise, you set the configurations to use a release build of CPython. This configuration disables some debugging features of the C++ runtime, including assertions. Using CPython debug binaries (_python_d.exe_) requires different settings.

   1. Set other project properties as described in the following table.

      To change a property value, enter a value in the property field. For some fields, you can select the current value to expand a dropdown menu of choices or open a dialog to help define the value.

      After you update values on a tab, select **Apply** before switching to a different tab. This action helps to ensure your changes remain.

      | Tab and section | Property | Value |
      | --- | --- | --- |
      | **Configuration Properties** > **General**  | **Target Name**                    | Specify the name of the module to refer to it from Python in `from...import` statements, such as _superfastcode_. You use this same name in the C++ code when you define the module for Python. To use the name of the project as the module name, leave the default value of **$\<ProjectName>**. For `python_d.exe`, add `_d` to the end of the name. |
      |                                             | **Configuration Type**             | **Dynamic Library (.dll)** |
      | **Configuration Properties** > **Advanced** | **Target File Extension**          | **.pyd** (Python Extension Module) |
     | **C/C++** > **General**                     | **Additional Include Directories** | Add the Python _include_ folder as appropriate for your installation (for example, _c:\Python36\include_). |
      | **C/C++** > **Preprocessor**                | **Preprocessor Definitions**       | If it's present, change the **\_DEBUG** value to **NDEBUG** to match the nondebug version of CPython. When you use _python_d.exe_, leave this value unchanged. |
      | **C/C++** > **Code Generation**             | **Runtime Library**                | **Multi-threaded DLL (/MD)** to match the release (nondebug) version of CPython. When you use _python_d.exe_, leave this value as **Multi-threaded Debug DLL (/MDd)**. |
     |                                             | **Basic Runtime Checks**           | **Default** |
      | **Linker** > **General**                    | **Additional Library Directories** | Add the Python _libs_ folder that contains _.lib_ files, as appropriate for your installation (for example, _c:\Python36\libs_). Be sure to point to the _libs_ folder that contains _.lib_ files, and **not** the _Lib_ folder that contains _.py_ files. |

      > [!IMPORTANT]
      > If the **C/C++** tab isn't displayed as an option for the project properties, then the project contains no code files that Visual Studio identifies as C/C++ source files. This condition can occur if you create a source file without a _.c_ or _.cpp_ file extension.
      >
      > If you accidentally entered _module.coo_ instead of _module.cpp_ when you created the C++ file, Visual Studio creates the file but doesn't set the file type to _C/C+ compiler_. This file type is necessary to activate the presence of the C/C++ properties tab in the project properties dialog. The misidentification remains even if you rename the code file with a _.cpp_ file extension.
      >
      > To set the code file type properly, in **Solution Explorer**, right-click the code file and select **Properties**. For the **Item Type**, select **C/C++ compiler**.

   1. After you update all the properties, select **OK**. 

   Repeat the steps for the other build configuration.

1. Test your current configuration. Repeat the following steps for both the _debug_ and _release_ builds of both C++ projects.

   1. On the Visual Studio toolbar, set the **Build** configuration to **Debug** or **Release**:

      :::image type="content" source="media/cpp-set-build-target.png" alt-text="Screenshot that shows how to set the build configuration for the C++ project in Visual Studio." border="false" lightbox="media/cpp-set-build-target.png":::

   1. In **Solution Explorer**, right-click the C++ project, and select **Build**.

      The _.pyd_ files are in the _solution_ folder, under _Debug_ and _Release_, and not in the C++ project folder itself.

### Add code and test configuration

Now you're ready to add code to your C++ files and test the _release_ build.

1. For the _superfastcode_ C++ project, open the _module.cpp_ file in the code editor.

1. In the  _module.cpp_ file, paste the following code:

   ```cpp
   #include <Windows.h>
   #include <cmath>

   const double e = 2.7182818284590452353602874713527;

   double sinh_impl(double x) {
       return (1 - pow(e, (-2 * x))) / (2 * pow(e, -x));
   }

   double cosh_impl(double x) {
       return (1 + pow(e, (-2 * x))) / (2 * pow(e, -x));
   }

   double tanh_impl(double x) {
       return sinh_impl(x) / cosh_impl(x);
   }
   ```

1. Save your changes.

1. Build the _release_ configuration for the C++ project to confirm your code is correct.

Repeat the steps to add code to the C++ file for the _superfastcode2_ project and test the _release_ build.

## Convert C++ projects to Python extensions

To make the C++ DLL an extension for Python, first you modify the exported methods to interact with Python types. Then, add a function to export the module, along with definitions for the module's methods.

The following sections demonstrate how to create the extensions by using the CPython extensions and PyBind11. The _superfasctcode_ project uses the CPython extensions and the _superfasctcode2_ project implements PyBind11.

### Use CPython extensions

For more information about the code presented in this section, see [Python/C API Reference Manual](https://docs.python.org/3/c-api/index.html), especially the [Module Objects](https://docs.python.org/3/c-api/module.html) page. When you review the reference content, be sure to select your version of Python in the dropdown list at the top right.

1. For the _superfastcode_ C++ project, open the _module.cpp_ file in the code editor.

1. Add a statement at the top of the _module.cpp_ file to include the _Python.h_ header file:

   ```cpp
   #include <Python.h>
   ```

1. Replace the `tanh_impl` method code to accept and return Python types (that is, a `PyObject*`):

   ```cpp
   PyObject* tanh_impl(PyObject* /* unused module reference */, PyObject* o) {
       double x = PyFloat_AsDouble(o);
       double tanh_x = sinh_impl(x) / cosh_impl(x);
       return PyFloat_FromDouble(tanh_x);
   }
   ```

1. At the end of the file, add a structure to define how to present the C++ `tanh_impl` function to Python:

   ```cpp
   static PyMethodDef superfastcode_methods[] = {
       // The first property is the name exposed to Python, fast_tanh
       // The second is the C++ function with the implementation
       // METH_O means it takes a single PyObject argument
       { "fast_tanh", (PyCFunction)tanh_impl, METH_O, nullptr },

       // Terminate the array with an object containing nulls
       { nullptr, nullptr, 0, nullptr }
   };
   ```

1. Add another structure to define how to refer to the module in your Python code, specifically when you use the `from...import` statement.

   The name imported in this code should match the value in the project properties under **Configuration Properties** > **General** > **Target Name**.

   In the following example, the `"superfastcode"` name means you can use the `from superfastcode import fast_tanh` statement in Python because `fast_tanh` is defined within `superfastcode_methods`. File names that are internal to the C++ project, such as _module.cpp_, are inconsequential.

   ```cpp
   static PyModuleDef superfastcode_module = {
       PyModuleDef_HEAD_INIT,
       "superfastcode",                        // Module name to use with Python import statements
       "Provides some functions, but faster",  // Module description
       0,
       superfastcode_methods                   // Structure that defines the methods of the module
   };
   ```

1. Add a method that Python calls when it loads the module. The method name must be `PyInit_<module-name>`, where _\<module-name>_ exactly matches the C++ project's **Configuration Properties** > **General** > **Target Name** property. That is, the method name matches the file name of the _.pyd_ file built by the project.

   ```cpp
   PyMODINIT_FUNC PyInit_superfastcode() {
       return PyModule_Create(&superfastcode_module);
   }
   ```

1. Build the C++ project and verify your code. If you encounter errors, see the ["Troubleshoot compile errors"](#troubleshoot-compile-errors) section.

### Use PyBind11

If you complete the steps in the previous section for the _superfastcode_ project, you might notice that the exercise requires boilerplate code to create the module structures for C++ CPython extensions. In this exercise, you discover that PyBind11 simplifies the coding process. You use macros in a C++ header file to accomplish the same result, but with much less code. However, extra steps are required to ensure Visual Studio can locate the PyBind11 libraries and include files. For more information about the code in this section, see [PyBind11 basics](https://github.com/pybind/pybind11/blob/master/docs/basics.rst).

#### Install PyBind11

The first step is to install PyBind11 in your project configuration. In this exercise, you use the **Developer PowerShell** window.

1. Open the **Tools** > **Command Line** > **Developer PowerShell** window.

1. In the **Developer PowerShell** window, install PyBind11 by using the pip command `pip install pybind11` or `py -m pip install pybind11`.

   Visual Studio installs PyBind11 and its dependent packages.

#### Add PyBind11 paths to project

After PyBind11 installs, you need to add the PyBind11 paths to the **Additional Include Directories** property for the project.

1. In **Developer PowerShell** the window, run the command `python -m pybind11 --includes` or `py -m pybind11 --includes`.

   This action prints a list of PyBind11 paths that you need to add to your project properties.
   
1. Highlight the list of paths in the window and select **Copy** (double page) on the window toolbar.

   :::image type="content" source="media/install-pybind11-powershell.png" alt-text="Screenshot that shows how to highlight and copy the list of paths from the Developer PowerShell window in Visual Studio." border="false" lightbox="media/install-pybind11-powershell.png":::

   The list of concatenated paths is added to your clipboard.

1. In **Solution Explorer**, right-click the _superfastcode2_ project, and select **Properties**.

1. At the top of the **Property Pages** dialog, for the **Configuration** field, select **Release**. (You might see this option with the **Active** prefix.) 

1. In the dialog, in the **C/C++** > **General** tab, expand the dropdown menu for the **Additional Include Directories** property, and select **Edit**.

1. In the popup dialog, add the list of copied paths:

   Repeat these steps for each path in the concatenated list copied from the **Developer PowerShell** window:

   1. Select **New Line** (folder with plus symbol) on the popup dialog toolbar.

      :::image type="content" source="media/cpp-add-pybind11-path.png" alt-text="Screenshot that shows how to add a PyBind11 path to the Additional Include Directories property." border="false" lightbox="media/cpp-add-pybind11-path.png":::

      Visual Studio adds an empty line at the top of the list of paths and positions the insert cursor at the beginning.

   1. Paste the PyBind11 path into the empty line.
      
      You can also select **More options** (**...**) and use a popup file explorer dialog to browse to the path location.
   
      > [!IMPORTANT]
      > 
      > - If the path contains the `-I` prefix, remove the prefix from the path.
      > - For Visual Studio to recognize a path, the path needs to be on a separate line.
      
      After you add a new path, Visual Studio shows the confirmed path in the **Evaluated value** field.

1. Select **OK** to exit the popup dialog.

1. In the top of the **Property Pages** dialog, hover over the value for the **Additional Include Directories** property and confirm the PyBind11 paths are present.

1. Select **OK** to apply the property changes.

#### Update the module.cpp file

The last step is to add the PyBind11 header file and macro code to the project C++ file.

1. For the _superfastcode2_ C++ project, open the _module.cpp_ file in the code editor.

1. Add a statement at the top of the _module.cpp_ file to include the _pybind11.h_ header file:

   ```cpp
   #include <pybind11/pybind11.h>
   ```

1. At the end of the _module.cpp_ file, add code for the `PYBIND11_MODULE` macro to define the entry point to the C++ function:

   ```cpp
   namespace py = pybind11;

   PYBIND11_MODULE(superfastcode2, m) {
       m.def("fast_tanh2", &tanh_impl, R"pbdoc(
           Compute a hyperbolic tangent of a single argument expressed in radians.
       )pbdoc");

   #ifdef VERSION_INFO
       m.attr("__version__") = VERSION_INFO;
   #else
       m.attr("__version__") = "dev";
   #endif
   }
   ```

1. Build the C++ project and verify your code. If you encounter errors, see the next section, [Troubleshoot compile errors](#troubleshoot-compile-errors).

### Troubleshoot compile errors

Review the following sections for possible issues that can cause the C++ module build to fail.

#### Error: Unable to locate header file

Visual Studio returns an error message like **E1696: Cannot open source file "Python.h"** or **C1083: Cannot open include file: "Python.h": No such file or directory**.

This error indicates that the compiler can't locate a required header (_.h_) file for your project.

- For the _superfastcode_ project, verify that the **C/C++** > **General** > **Additional Include Directories** project property contains the path to the _include_ folder for your Python installation. Review the steps in [Configure project properties](#configure-project-properties).

- For the _superfastcode2_ project, verify that the same project property contains the path to the _include_ folder for your PyBind11 installation. Review the steps [Ad PyBind paths to project](#add-pybind11-paths-to-project).

For more information on accessing your Python installation configuration information, see the [Python documentation](https://docs.python.org/3/library/sysconfig.html).

#### Error: Unable to locate Python libraries

Visual Studio returns an error indicating that the compiler can't locate the required library (DLL) files for your project.

- For the C++ project (_superfastcode_ or _superfastcode2_), verify that the **Linker** > **General** > **Additional Library Directories** property contains the path to the _libs_ folder for your Python installation. Review the steps in [Configure project properties](#configure-project-properties).

For more information on accessing your Python installation configuration information, see the [Python documentation](https://docs.python.org/3/library/sysconfig.html).

#### Linker errors related to target architecture

Visual Studio reports linker errors related to the target architecture configuration for your project, such as x64 or Win32.

- For the C++ project (_superfastcode_ or _superfastcode2_), change the target configuration to match your Python installation. For example, if your C++ project target configuration is Win32, but your Python installation is 64-bit, change the C++ project target configuration to x64.

## Test the code and compare the results

Now that you have the DLLs structured as Python extensions, you can refer to them from the Python project, import the modules, and use their methods.

### Make your DLL available to Python

You can make your DLL available to Python in several ways. Here are two options to consider:

If your Python project and C++ project are in the same solution, you can use the following approach:

1. In **Solution Explorer**, right-click the **References** node in your Python project, and select **Add Reference**.

   Be sure to do this action for your Python project, and not for your C++ project.

1. In the **Add Reference** dialog, expand the **Projects** tab.

1. Select the checkboxes for both the **superfastcode** and **superfastcode2** projects, and select **OK**.

   :::image type="content" source="media/cpp-add-reference.png" alt-text="Screenshot that shows how to add a reference to the super fast code project in Visual Studio." border="false" lightbox="media/cpp-add-reference.png":::

An alternate approach is to install the C++ extension module in your Python environment. This method makes the module available to other Python projects. For more information, see the [setuptools project documentation](https://setuptools.readthedocs.io/). 

Complete the following steps to install the C++ extension module in your Python environment:

1. In **Solution Explorer**, right-click your C++ project, and select **Add** > **New Item**.

1. In the list of file templates, select **C++ File (.cpp)**.

1. Enter the **Name** for the file as _setup.py_, and then select **Add**.

   Be sure to enter the file name with the Python (_.py_) extension. Visual Studio recognizes the file as Python code despite the use of the C++ file template.

   Visual Studio opens the new file in the code editor.
   
1. Paste the following code into the new file. Choose the code version that corresponds to your extension method:

   - **CPython extensions** (_superfastcode_ project):

      ```python
      from setuptools import setup, Extension

      sfc_module = Extension('superfastcode', sources = ['module.cpp'])

      setup(
         name='superfastcode',
         version='1.0',
         description='Python Package with superfastcode C++ extension',
         ext_modules=[sfc_module]
      )
      ```

   - **PyBind11** (_superfastcode2_ project):

      ```python
      from setuptools import setup, Extension
      import pybind11

      cpp_args = ['-std=c++11', '-stdlib=libc++', '-mmacosx-version-min=10.7']

      sfc_module = Extension(
         'superfastcode2',
         sources=['module.cpp'],
         include_dirs=[pybind11.get_include()],
         language='c++',
         extra_compile_args=cpp_args,
      )

      setup(
         name='superfastcode2',
         version='1.0',
         description='Python package with superfastcode2 C++ extension (PyBind11)',
         ext_modules=[sfc_module],
      )
      ```

1. In the C++ project, create a second file named _pyproject.toml_, and paste the following code:

   ```toml
   [build-system]
   requires = ["setuptools", "wheel", "pybind11"]
   build-backend = "setuptools.build_meta"
   ```

   The [TOML](https://toml.io/) (_.toml_) file uses the Tom's Obvious, Minimal Language format for configuration files.

1. To build the extension, right-click the _pyproject.toml_ filename in the code window tab, and select **Copy Full Path**.

   :::image type="content" source="media/cpp-copy-full-path.png" alt-text="Screenshot that shows how to copy the full path to the py project toml file in Visual Studio." border="false" lightbox="media/cpp-copy-full-path.png":::

   You delete the _pyproject.toml_ name from the path before you use it.

1. In **Solution Explorer**, expand the **Python Environments** node for the solution.

1. Right-click the active Python environment (shown in bold), and select **Manage Python Packages**.

   The **Python Environments** pane opens. 

   If the necessary package is already installed, you see it listed in this pane.

   - Before you continue, select the **X** next to the package name to uninstall it.

   :::image type="content" source="media/cpp-uninstall-package.png" alt-text="Screenshot that shows how to uninstall a package in the Python Environments pane." border="false" lightbox="media/cpp-uninstall-package.png":::

1. In the search box for the **Python Environments** pane, paste the copied path, and delete _pyproject.toml_ filename from the end of the path.

   :::image type="content" source="media/cpp-install-module.png" alt-text="Screenshot that shows how to enter the path in the Python Environments pane to install the extension module." border="false" lightbox="media/cpp-install-module.png":::

1. Select **Enter** to install the module from the location of the copied path.

   > [!TIP]
   > If the installation fails because of a permission error, add the `--user` argument to the end of the command, and try the installation again.

### Call the DLL from Python

After you make the DLL available to Python, as described in the preceding section, you're ready to call the `superfastcode.fast_tanh` and `superfastcode2.fast_tanh2` functions from Python. You can then compare the function performance to the Python implementation.

Follow these steps to call the extension module DLL from Python:

1. Open the _.py_ file for your Python project in the code editor.

1. At the end of the file, add the following code to call the methods exported from the DLLs and display their output:

   ```python
   from superfastcode import fast_tanh
   test(lambda d: [fast_tanh(x) for x in d], '[fast_tanh(x) for x in d] (CPython C++ extension)')

   from superfastcode2 import fast_tanh2
   test(lambda d: [fast_tanh2(x) for x in d], '[fast_tanh2(x) for x in d] (PyBind11 C++ extension)')
   ```

1. Run the Python program by selecting **Debug** > **Start Without Debugging** or use the keyboard shortcut **Ctrl**+**F5**.

   > [!NOTE]
   > If the **Start Without Debugging** command isn't available, in **Solution Explorer**, right-click the Python project, and then select **Set as Startup Project**.

   When the program executes, notice that the C++ routines run approximately 5 to 20 times faster than the Python implementation.
   
   Here's an example of typical program output:

   ```output
   Running benchmarks with COUNT = 500000
   [tanh(x) for x in d] (Python implementation) took 0.758 seconds

   [fast_tanh(x) for x in d] (CPython C++ extension) took 0.076 seconds

   [fast_tanh2(x) for x in d] (PyBind11 C++ extension) took 0.204 seconds
   ```

1. Try increasing the `COUNT` variable so the time differences are more pronounced.

   A _debug_ build of the C++ module also runs slower than a _release_ build because the debug build is less optimized and contains various error checks. Try switching between the build configurations for comparison, but remember to update the properties that you set earlier for the release configuration.

### Address process speed and overhead

In the output, you might notice that the PyBind11 extension isn't as fast as the CPython extension, although it should be faster than the pure Python implementation. The major reason for the difference is because of the use of the [METH_O flag](https://docs.python.org/3/c-api/structures.html#c.METH_O). This flag doesn't support multiple parameters, parameter names, or keywords arguments. PyBind11 generates slightly more complex code to provide a more Python-like interface to callers. Because the test code calls the function 500,000 times, the results can greatly amplify the overhead.

You can reduce the overhead further by moving the `for` loop into the native Python code. This approach involves using the [iterator protocol](https://docs.python.org/c-api/iter.html) (or the PyBind11 `py::iterable` type for [the function parameter](https://pybind11.readthedocs.io/en/stable/advanced/functions.html#python-objects-as-args)) to process each element. Removing the repeated transitions between Python and C++ is an effective way to reduce the time it takes to process the sequence.

### Troubleshoot import errors

If you receive an `ImportError` message when you try to import your module, you can resolve it in one of the following ways:

- When you build through a project reference, ensure your C++ project properties match the Python environment activated for your Python project. Confirm the same folder locations are in use for the _Include_ (_.h_) and _Library_ (DLL) files.

- Ensure your output file is correctly named, such as _superfastcode.pyd_. An incorrect name or extension prevents import of the necessary file.

- If you install your module by using the _setup.py_ file, be sure to run the `pip` command in the Python environment activated for your Python project. When you expand the active Python environment for your project in **Solution Explorer**, you should see an entry for the C++ project, such as _superfastcode_.

## Debug C++ code

Visual Studio supports debugging Python and C++ code together. The following steps demonstrate the debug process for the _superfastcode_ C++ project, but the process is the same for the _superfastcode2_ project.

1. In **Solution Explorer**, right-click the Python project, and select **Properties**.

1. In the **Properties** pane, select the **Debug** tab, and then select the **Debug** > **Enable native code debugging** option.

   > [!TIP]
   > When you enable native code debugging, the Python output window might close immediately after the program finishes without pausing and showing the **Press any key to continue** prompt. To force the pause and prompt after you enable native code debugging, add the `-i` argument to the **Run** > **Interpreter Arguments** field on the **Debug** tab. This argument puts the Python interpreter into interactive mode after the code runs. The program waits for you to select **Ctrl**+**Z**+**Enter** to close the window. An alternate approach is to add `import os` and `os.system("pause")` statements at the end of your Python program. This code duplicates the original pause prompt.

1. Select **File** > **Save** (or **Ctrl**+**S**) to save the property changes.

1. On the Visual Studio toolbar, set the **Build** configuration to **Debug**.

1. Because code generally takes longer to run in the debugger, you might want to change the `COUNT` variable in your Python project _.py_ file to a value that's about five times smaller than the default value. For example, change it from **500000** to **100000**.

1. In your C++ code, set a breakpoint on the first line of the `tanh_impl` method.

1. Start the debugger by selecting **Debug** > **Start Debugging** or use the keyboard shortcut **F5**.

   The debugger stops when the breakpoint code is called. If the breakpoint isn't hit, check to ensure that the configuration is set to **Debug** and that you saved the project, which doesn't happen automatically when you start the debugger.

   :::image type="content" source="media/cpp-debugging.png" alt-text="Screenshot of C++ code that contains a breakpoint in Visual Studio." border="false" lightbox="media/cpp-debugging.png":::

1. At the breakpoint, you can step through the C++ code, examine variables, and so on. For more information about these features, see [Debug Python and C++ together](debugging-mixed-mode-c-cpp-python-in-visual-studio.md).

## Alternative approaches

You can create Python extensions in various ways, as described in the following table. The first two rows, `CPython` and `PyBind11`, are discussed in this article.

| Approach                                                                              | Vintage | Representative users                                                |
| ------------------------------------------------------------------------------------- | ------- | ------------------------------------------------------------------- |
| C/C++ extension modules for `CPython`                                                 | 1991    | Standard Library                                                    |
| [PyBind11](https://github.com/pybind/pybind11) (recommended for C++)                  | 2015    |                                                                     |
| [Cython](https://cython.org) (recommended for C)                                      | 2007    | [gevent](https://www.gevent.org/), [kivy](https://kivy.org/)        |
| [HPy](https://hpyproject.org/)                                                        | 2019    |                                                                     |
| [mypyc](https://mypyc.readthedocs.io/)                                                | 2017    |                                                                     |
| ctypes                                                                                | 2003    | [oscrypto](https://github.com/wbond/oscrypto)                       |
| cffi                                                                                  | 2013    | [cryptography](https://cryptography.io/), [pypy](https://pypy.org/) |
| SWIG                                                                                  | 1996    | [crfsuite](http://www.chokkan.org/software/crfsuite/)               |
| [Boost.Python](https://www.boost.org/doc/libs/1_66_0/libs/python/doc/html/index.html) | 2002    |                                                                     |
| [cppyy](https://cppyy.readthedocs.io/)                                                | 2017    |                                                                     |

## Related content

- [Access the completed sample files on GitHub (python-samples-vs-cpp-extension)](https://github.com/Microsoft/python-sample-vs-cpp-extension)
