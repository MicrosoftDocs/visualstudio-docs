---
title: Write C++ extensions for Python
description: A walkthrough of creating a C++ extension for Python using Visual Studio, CPython, and PyBind11, including mixed-mode debugging.
ms.date: 05/11/2021
ms.topic: how-to
author: JoshuaPartlow
ms.author: joshuapa
manager: jmartens
ms.custom: seodec18
ms.workload:
  - python
  - data-science
---

# Create a C++ extension for Python

Modules written in C++ (or C) are commonly used to extend the capabilities of a Python interpreter as well as to enable access to low-level operating system capabilities. There are three primary types of modules:

- Accelerator modules: because Python is an interpreted language, certain pieces of code can be written in C++ for higher performance.
- Wrapper modules: expose existing C/C++ interfaces to Python code or expose a more "Pythonic" API that's easy to use from Python.
- Low-level system access modules: created to access lower-level features of the `CPython` runtime, the operating system, or the underlying hardware.

This article walks through building a C++ extension module for `CPython` that computes a hyperbolic tangent and calls it from Python code. The routine is implemented first in Python to demonstrate the relative performance gain of implementing the same routine in C++.

This article also demonstrates two ways to make the C++ available to Python:

- The standard `CPython` extensions as described in the [Python documentation](https://docs.python.org/3/c-api/)
- [PyBind11](https://github.com/pybind/pybind11), which is recommended for C++ 11 because of its simplicity.

The completed sample from this walkthrough can be found on [python-samples-vs-cpp-extension](https://github.com/Microsoft/python-sample-vs-cpp-extension) (GitHub).

## Prerequisites

- Visual Studio 2017 or later with the **Python Development** workload installed, including the **Python native development tools**, which brings in the C++ workload and toolsets necessary for native extensions.

    ![Selecting the Python native development tools option](media/cpp-install-native.png)

    > [!Tip]
    > Installing the **Data science and analytical applications** workload also includes Python and the **Python native development tools** option by default.

For more information on install options, see [Install Python support for Visual Studio](installing-python-support-in-visual-studio.md). If you install Python separately, be sure to select **Download debugging symbols** under **Advanced Options** in its installer. This option is required to use mixed-mode debugging between your Python code and native code.

## Create the Python application

1. Create a new Python project in Visual Studio by selecting **File** > **New** > **Project**. Search for "Python", select the **Python Application** template, give it a name and location of your choice, and select **OK**.

1. In the project's *.py* file, paste the following code (or enter it manually to experience some of the [Python editing features](editing-python-code-in-visual-studio.md)). This code computes a hyperbolic tangent without using the math library, and is what we will be accelerating with native extensions.

    > [!Tip]
    > Write your code in pure Python before rewriting in C++. This way you can more easily check that
    > your native code is correct

    ```python
    from random import random
    from time import perf_counter

    COUNT = 500000  # Change this value depending on the speed of your computer
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

1. Run the program using **Debug** > **Start without Debugging** (**Ctrl**+**F5**) to see the results. You can adjust the `COUNT` variable to change how long the benchmark takes to run. For the purposes of this walkthrough, set the count so that the benchmark take around two seconds.

> [!TIP]
> When running benchmarks, always use **Debug** > **Start without Debugging** to avoid the overhead incurred when running code within the Visual Studio debugger.

## Create the core C++ projects

Follow the instructions in this section to create two identical C++ projects named "superfastcode" and "superfastcode2". Later you'll use two different approaches in each project to expose the C++ code to Python.

1. Right-click the solution in **Solution Explorer** and select **Add** > **New Project**. A Visual Studio solution can contain both Python and C++ projects together (which is one of the advantages of using Visual Studio for Python).

1. Search on "C++", select **Empty project**, specify the name "superfastcode" ("superfastcode2" for the second project), and select **OK**.

    > [!Tip]
    > With the **Python native development tools** installed in Visual Studio, you can start with the **Python Extension Module** template instead, which has much of what's described below already in place. For this walkthrough, though, starting with an empty project demonstrates building the extension module step by step. Once you understand the process, the template saves you time when writing your own extensions.

1. Create a C++ file in the new project by right-clicking the **Source Files** node, then select **Add** > **New Item**, select **C++ File**, name it `module.cpp`, and select **OK**.

    > [!Important]
    > A file with the *.cpp* extension is necessary to turn on the C++ property pages in the steps that follow.

1. If you are using a 64-bit Python runtime, activate the **x64** configuration using the dropdown menu in the main toolbar. For a 32-bit Python runtime, activate the **Win32** configuration.

1. Right-click the C++ project in **Solution Explorer**, select **Properties**. The value for **Configuration** should be **Active (Debug)** and **Platform** will be **Active (x64)** or **Active (Win32)** depending on your selection in the preceding step.

    > [!Tip]
    > For your own projects, you will want to configure both Debug and Release configurations. Here we only
    > configure the Debug configuration, and set it to use a *release* build of `CPython`, which disables some
    > debugging features of the C++ runtime including assertions. Using `CPython` *debug* binaries
    > (`python_d.exe`) will require different settings.

1. Set the specific properties as described in the following table, then select **OK**.
    ::: moniker range=">=vs-2019"
    | Tab | Property | Value |
    | --- | --- | --- |
    | **General** | **Target Name** | Specify the name of the module as you want to refer to it from Python in `from...import` statements. You use this same name in the C++ when defining the module for Python. If you want to use the name of the project as the module name, leave the default value of **$(ProjectName)**. For `python_d.exe`, add `_d` to the end of the name. |
    | | **Configuration Type** | **Dynamic Library (.dll)** |
    | **Advanced** | **Target File Extension** | **.pyd** |
    | **C/C++** > **General** | **Additional Include Directories** | Add the Python *include* folder as appropriate for your installation, for example, `c:\Python36\include`.  |
    | **C/C++** > **Preprocessor** | **Preprocessor Definitions** | If present, change the **_DEBUG** value to **NDEBUG**, to match the non-debug version of `CPython`. (When using `python_d.exe`, leave this unchanged.) |
    | **C/C++** > **Code Generation** | **Runtime Library** | **Multi-threaded DLL (/MD)** to match the non-debug version of `CPython`. (When using `python_d.exe`, leave this unchanged.) |
    | **Linker** > **General** | **Additional Library Directories** | Add the Python *libs* folder containing *.lib* files as appropriate for your installation, for example, `c:\Python36\libs`. (Be sure to point to the *libs* folder that contains *.lib* files, and *not* the *Lib* folder that contains *.py* files.) |
    ::: moniker-end
    ::: moniker range="=vs-2017"
    | Tab | Property | Value |
    | --- | --- | --- |
    | **General** | **General** > **Target Name** | Specify the name of the module as you want to refer to it from Python in `from...import` statements. You use this same name in the C++ when defining the module for Python. If you want to use the name of the project as the module name, leave the default value of **$(ProjectName)**. For `python_d.exe`, add `_d` to the end of the name. |
    | | **General** > **Target Extension** | **.pyd** |
    | | **Project Defaults** > **Configuration Type** | **Dynamic Library (.dll)** |
    | **C/C++** > **General** | **Additional Include Directories** | Add the Python *include* folder as appropriate for your installation, for example, `c:\Python36\include`.  |
    | **C/C++** > **Preprocessor** | **Preprocessor Definitions** | If present, change the **_DEBUG** value to **NDEBUG**, to match the non-debug version of `CPython`. (When using `python_d.exe`, leave this unchanged.) |
    | **C/C++** > **Code Generation** | **Runtime Library** | **Multi-threaded DLL (/MD)** to match the non-debug version of `CPython`. (When using `python_d.exe`, leave this unchanged.) |
    | **Linker** > **General** | **Additional Library Directories** | Add the Python *libs* folder containing *.lib* files as appropriate for your installation, for example, `c:\Python36\libs`. (Be sure to point to the *libs* folder that contains *.lib* files, and *not* the *Lib* folder that contains *.py* files.) |
    ::: moniker-end
    
    > [!Tip]
    > If you don't see the C/C++ tab in the project properties, it's because the project doesn't contain any files that it identifies as C/C++ source files. This condition can occur if you create a source file without a *.c* or *.cpp* extension. For example, if you accidentally entered `module.coo` instead of `module.cpp` in the new item dialog earlier, then Visual Studio creates the file but doesn't set the file type to "C/C+ Code," which is what activates the C/C++ properties tab. Such misidentification remains the case even if you rename the file with `.cpp`. To set the file type properly, right-click the file in **Solution Explorer**, select **Properties**, then set  **File Type** to **C/C++ Code**.

1. Right-click the C++ project and select **Build** to test your configurations (both **Debug** and **Release**). The *.pyd* files are located in the **solution** folder under **Debug** and **Release**, not the C++ project folder itself.

1. Add the following code to the C++ project's *module.cpp* file:

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

1. Build the C++ project again to confirm that your code is correct.

1. If you haven't already done so, repeat the steps above to create a second project named "superfastcode2" with identical contents.

## Convert the C++ projects to extensions for Python

To make the C++ DLL into an extension for Python, you first modify the exported methods to interact with Python types. You then add a function that exports the module, along with definitions of the module's methods.

The sections that follow explain how to perform these steps using both the `CPython` extensions and PyBind11.

### CPython extensions

For more background on what's shown in this section, refer to the [Python/C API Reference Manual](https://docs.python.org/3/c-api/index.html) and especially [Module Objects](https://docs.python.org/3/c-api/module.html) on python.org (remember to select your version of Python from the drop-down control on the upper right to view the correct documentation).

1. At the top of *module.cpp*, include *Python.h*:

    ```cpp
    #include <Python.h>
    ```

1. Modify the `tanh_impl` method to accept and return Python types (a `PyObject*`, that is):

    ```cpp
    PyObject* tanh_impl(PyObject* /* unused module reference */, PyObject* o) {
        double x = PyFloat_AsDouble(o);
        double tanh_x = sinh_impl(x) / cosh_impl(x);
        return PyFloat_FromDouble(tanh_x);
    }
    ```

1. Add a structure that defines how the C++ `tanh_impl` function is presented to Python:

    ```cpp
    static PyMethodDef superfastcode_methods[] = {
        // The first property is the name exposed to Python, fast_tanh
        // The second is the C++ function with the implementation
        // METH_O means it takes a single PyObject argument
        { "fast_tanh", (PyCFunction)tanh_impl, METH_O, nullptr },

        // Terminate the array with an object containing nulls.
        { nullptr, nullptr, 0, nullptr }
    };
    ```

1. Add a structure that defines the module as you want to refer to it in your Python code, specifically when using the `from...import` statement. (Make this match the value in the project properties under **Configuration Properties** > **General** > **Target Name**.) In the following example, the "superfastcode" module name means you can use `from superfastcode import fast_tanh` in Python, because `fast_tanh` is defined within `superfastcode_methods`. (Filenames internal to the C++ project, like *module.cpp*, are inconsequential.)

    ```cpp
    static PyModuleDef superfastcode_module = {
        PyModuleDef_HEAD_INIT,
        "superfastcode",                        // Module name to use with Python import statements
        "Provides some functions, but faster",  // Module description
        0,
        superfastcode_methods                   // Structure that defines the methods of the module
    };
    ```

1. Add a method that Python calls when it loads the module, which must be named `PyInit_<module-name>`, where &lt;module-name&gt; exactly matches the C++ project's **General** > **Target Name** property (that is, it matches the filename of the *.pyd* built by the project).

    ```cpp
    PyMODINIT_FUNC PyInit_superfastcode() {
        return PyModule_Create(&superfastcode_module);
    }
    ```

1. Build the C++ project again to verify your code. If you encounter errors, see the [Troubleshooting](#troubleshooting) section below.

### PyBind11

If you completed the steps in the previous section, you certainly noticed that you used lots of boilerplate code to create the necessary module structures for the C++ code. PyBind11 simplifies the process through macros in a C++ header file that accomplish the same result with much less code. For background on what's shown in this section, see [PyBind11 basics](https://github.com/pybind/pybind11/blob/master/docs/basics.rst) (github.com).

1. Install PyBind11 using pip: `pip install pybind11` or `py -m pip install pybind11`. (Alternatively, you can install using the Python Environments window, and then use its "Open in Powershell" command for the next step.)

1. In the same terminal, run `python -m pybind11 --includes` or `py -m pybind11 --includes`. This will print a list of paths that you should add to your project's **C/C++** > **General** > **Additional Include Directories** property (removing the `-I` prefix, if present).

1. At the top of a fresh *module.cpp*, that does not include any of the changes from the previous section, include *pybind11.h*:

    ```cpp
    #include <pybind11/pybind11.h>
    ```

1. At the bottom of *module.cpp*, use the `PYBIND11_MODULE` macro to define the entrypoint to the C++ function:

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

1. Build the C++ project to verify your code. If you encounter errors, see the next section on troubleshooting.

### Troubleshooting

The C++ module may fail to compile for the following reasons:

- Unable to locate *Python.h* (**E1696: cannot open source file "Python.h"** and/or **C1083: Cannot open include file: "Python.h": No such file or directory**): verify that the path in **C/C++** > **General** > **Additional Include Directories** in the project properties points to your Python installation's *include* folder. See step 6 under [Create the core C++ project](#create-the-core-c-projects).

- Unable to locate Python libraries: verify that the path in **Linker** > **General** > **Additional Library Directories** in the project properties points to your Python installation's *libs* folder. See step 6 under [Create the core C++ project](#create-the-core-c-projects).

- Linker errors related to target architecture: change the C++ target's project architecture to match that of your Python installation. For example, if you're targeting **Win32** with the C++ project but your Python installation is 64-bit, change the C++ project to **x64**.

## Test the code and compare the results

Now that you have the DLLs structured as Python extensions, you can refer to them from the Python project, import the modules, and use their methods.

### Make the DLL available to Python

There are two ways to make the DLL available to Python.

The first method works if the Python project and the C++ project are in the same solution. Go to **Solution Explorer**, right-click the **References** node in your Python project, and then select **Add Reference**. In the dialog that appears, select the **Projects** tab, select both the **superfastcode** and **superfastcode2** projects, and then select **OK**.

![Adding a reference to the superfastcode project](media/cpp-add-reference.png)

The alternate method, described in the following steps, installs the module in your Python environment, making it available to other Python projects as well. Visit the [**setuptools** project](https://setuptools.readthedocs.io/) for more complete documentation.

1. Create a file named *setup.py* in the C++ project by right-clicking the project and selecting **Add** > **New Item**. Then select **C++ File (.cpp)**, name the file `setup.py`, and select **OK** (naming the file with the *.py* extension makes Visual Studio recognize it as Python despite using the C++ file template). When the file appears in the editor, paste the following code into it as appropriate to the extension method:

    **`CPython` extensions (superfastcode project):**

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

    **`PyBind11` (superfastcode2 project):**

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

1. Create a second file named *pyproject.toml* in the C++ project, and paste the following code into it.

    ```toml
    [build-system]
    requires = ["setuptools", "wheel", "pybind11"]
    build-backend = "setuptools.build_meta"
    ```

1. To build the extension, right-click the open *pyproject.toml* tab and select "Copy Full Path" (we will delete the *pyproject.toml* name from the path before using it).

1. In Solution Explorer, right-click the active Python environment and select *Manage Python Packages*.

    > [!Tip]
    > If you have already installed the package, you will see it listed here. Click on the "X" to
    > uninstall it before continuing.

1. Paste the copied path into the search box and delete `pyproject.toml` from the end. Then press Enter to install from that directory.

    > [!Tip]
    > If the install fails due to a permission error, add `--user` and try the command again.


### Call the DLL from Python

After you've made the DLL available to Python as described in the previous section, you can now call the `superfastcode.fast_tanh` and `superfastcode2.fast_tanh2` functions from Python code and compare their performance to the Python implementation:

1. Add the following lines in your *.py* file to call methods exported from the DLLs and display their outputs:

    ```python
    from superfastcode import fast_tanh
    test(lambda d: [fast_tanh(x) for x in d], '[fast_tanh(x) for x in d] (CPython C++ extension)')

    from superfastcode2 import fast_tanh2
    test(lambda d: [fast_tanh2(x) for x in d], '[fast_tanh2(x) for x in d] (PyBind11 C++ extension)')
    ```

1. Run the Python program (**Debug** > **Start without Debugging** or **Ctrl**+**F5**) and observe that the C++ routines run approximately five to twenty times faster than the Python implementation. Typical output appears as follows:

    ```output
    Running benchmarks with COUNT = 500000
    [tanh(x) for x in d] (Python implementation) took 0.758 seconds

    [fast_tanh(x) for x in d] (CPython C++ extension) took 0.076 seconds

    [fast_tanh2(x) for x in d] (PyBind11 C++ extension) took 0.204 seconds
    ```

    If the **Start Without Debugging** command is disabled, right-click the Python project in **Solution Explorer** and select **Set as Startup Project**.

1. Try increasing the `COUNT` variable so that the differences are more pronounced. A **Debug** build of the C++ module also runs slower than a **Release** build because the **Debug** build is less optimized and contains various error checks. Feel free to switch between those configurations for comparison (but remember to go back and update the properties from earlier for the **Release** configuration).

In the output, you may see that the PyBind11 extension isn't as fast as the `CPython` extension, though it should be significantly faster than the pure Python implementation. This difference is largely because we used the `METH_O` call, which does not support multiple parameters, parameter names, or keywords arguments. PyBind11 generates slightly more complex code to provide a more Python-like interface to callers, but because the test code calls the function 500,000 times, the results may greatly amplify that overhead!

We could reduce the overhead further by moving the `for` loop into the native code. This would involve using the [iterator protocol](https://docs.python.org/c-api/iter.html) (or PyBind11's `py::iterable` type for [the function parameter](https://pybind11.readthedocs.io/en/stable/advanced/functions.html#python-objects-as-args)) to process each element. Removing the repeated transitions between Python and C++ is an effective way to reduce the time taken to process the sequence.

### Troubleshooting

If you receive an `ImportError` when trying to import your module, it is likely that one of the following issues is the cause:

* When building through a project reference, ensure that your C++ project properties match the Python environment activated for your Python project, especially the Include and Library directories.

* Ensure that your output file is named `superfastcode.pyd`. A different name or extension will prevent it from being imported.

* If you installed your module using the *setup.py* file, check that you ran the *pip* command in the Python environment activated for your Python project. Expanding the Python environment in Solution Explorer should show an entry for `superfastcode`.

## Debug the C++ code

Visual Studio supports debugging Python and C++ code together. This section walks through the process using the **superfastcode** project; the steps are the same for the **superfastcode2** project.

1. Right-click the Python project in **Solution Explorer**, select **Properties**, select the **Debug** tab, and then select the **Debug** > **Enable native code debugging** option.

    > [!Tip]
    > When you enable native code debugging, the Python output window may disappear immediately when the program has completed without giving you the usual **Press any key to continue** pause. To force a pause, add the `-i` option to the **Run** > **Interpreter Arguments** field on the **Debug** tab when you enable native code debugging. This argument puts the Python interpreter into interactive mode after the code finishes, at which point it waits for you to press **Ctrl**+**Z** > **Enter** to exit. (Alternately, if you don't mind modifying your Python code, you can add `import os` and `os.system("pause")` statements at the end of your program. This code duplicates the original pause prompt.)

1. Select **File** > **Save** to save the property changes.

1. Set the build configuration to **Debug** in the Visual Studio toolbar.

    ![Setting the build configuration to Debug](media/cpp-set-debug.png)

1. Because code generally takes longer to run in the debugger, you may want to change the `COUNT` variable in your *.py* file to a value that's about five times smaller (for example, change it from `500000` to `100000`).

1. In your C++ code, set a breakpoint on the first line of the `tanh_impl` method, then start the debugger (**F5** or **Debug** > **Start Debugging**). The debugger stops when that code is called. If the breakpoint is not hit, check that the configuration is set to **Debug** and that you've saved the project (which does not happen automatically when starting the debugger).

    ![Stopping at a breakpoint in C++ code](media/cpp-debugging.png)

1. At this point you can step through the C++ code, examine variables, and so on. These features are detailed in [Debug C++ and Python together](debugging-mixed-mode-c-cpp-python-in-visual-studio.md).

## Alternative approaches

There are a variety of means to create Python extensions as described in the following table. The first two entries for `CPython` and `PyBind11` are what has been discussed in this article already.

| Approach | Vintage | Representative user(s) | 
| --- | --- | --- |
| C/C++ extension modules for `CPython` | 1991 | Standard Library | 
| [PyBind11](https://github.com/pybind/pybind11) (Recommended for C++) | 2015 |  |
| [Cython](https://cython.org) (Recommended for C) | 2007 | [gevent](https://www.gevent.org/), [kivy](https://kivy.org/) |
| [HPy](https://hpyproject.org/) | 2019 | |
| [mypyc](https://mypyc.readthedocs.io/) | 2017 | |
| ctypes | 2003 | [oscrypto](https://github.com/wbond/oscrypto) | 
| cffi | 2013 | [cryptography](https://cryptography.io/), [pypy](https://pypy.org/) |
| SWIG | 1996 | [crfsuite](http://www.chokkan.org/software/crfsuite/) | 
| [Boost.Python](https://www.boost.org/doc/libs/1_66_0/libs/python/doc/html/index.html) | 2002 | |
| [cppyy](https://cppyy.readthedocs.io/) | 2017 | |

## See also

The completed sample from this walkthrough can be found on [python-samples-vs-cpp-extension](https://github.com/Microsoft/python-sample-vs-cpp-extension) (GitHub).
