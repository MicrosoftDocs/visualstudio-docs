---
title: Write C++ extensions for Python
description: A walkthrough of creating a C++ extension for Python using Visual Studio, CPython, and PyBind11, including mixed-mode debugging.
ms.date: 11/19/2018
ms.topic: conceptual
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.custom: seodec18
ms.workload:
  - python
  - data-science
---

# Create a C++ extension for Python

Modules written in C++ (or C) are commonly used to extend the capabilities of a Python interpreter as well as to enable access to low-level operating system capabilities. There are three primary types of modules:

- Accelerator modules: because Python is an interpreted language, certain pieces of code can be written in C++ for higher performance.
- Wrapper modules: expose existing C/C++ interfaces to Python code or expose a more "Pythonic" API that's easy to use from Python.
- Low-level system access modules: created to access lower-level features of the CPython runtime, the operating system, or the underlying hardware.

This article walks through building a C++ extension module for CPython that computes a hyperbolic tangent and calls it from Python code. The routine is implemented first in Python to demonstrate the relative performance gain of implementing the same routine in C++.

This article also demonstrates two ways to make the C++ available to Python:

- The standard CPython extensions as described in the [Python documentation](https://docs.python.org/3/c-api/)
- [PyBind11](https://github.com/pybind/pybind11), which is recommended for C++ 11 because of its simplicity.

A comparison between these and other means is found under [alternative approaches](#alternative-approaches) at the end of this article.

The completed sample from this walkthrough can be found on [python-samples-vs-cpp-extension](https://github.com/Microsoft/python-sample-vs-cpp-extension) (GitHub).

## Prerequisites

- Visual Studio 2017 or later with both the **Desktop Development with C++** and **Python Development** workloads installed with default options.
- In the **Python Development** workload, also select the box on the right for **Python native development tools**. This option sets up most of the configuration described in this article. (This option also includes the C++ workload automatically.)

    ![Selecting the Python native development tools option](media/cpp-install-native.png)

    > [!Tip]
    > Installing the **Data science and analytical applications** workload also includes Python and the **Python native development tools** option by default.

For more information, see [Install Python support for Visual Studio](installing-python-support-in-visual-studio.md), including using other versions of Visual Studio. If you install Python separately, be sure to select **Download debugging symbols** and **Download debug binaries** under **Advanced Options** in the installer. This option ensures that you have the necessary debug libraries available if you choose to do a debug build.

## Create the Python application

1. Create a new Python project in Visual Studio by selecting **File** > **New** > **Project**. Search for "Python", select the **Python Application** template, give it a suitable name and location, and select **OK**.

1. Working with C++ requires that you use a 32-bit Python interpreter (Python 3.6 or above recommended). In the **Solution Explorer** window of Visual Studio, expand the project node, then expand the **Python Environments** node. If you don't see a 32-bit environment as the default (either in bold, or labeled with **global default**), then follow the instructions on [Select a Python environment for a project](selecting-a-python-environment-for-a-project.md). If you don't have a 32-bit interpreter installed, see [Install Python interpreters](installing-python-interpreters.md).

1. In the project's *.py* file, paste the following code that benchmarks the computation of a hyperbolic tangent (implemented without using the math library for easier comparison). Feel free to enter the code manually to experience some of the [Python editing features](editing-python-code-in-visual-studio.md).

    ```python
    from itertools import islice
    from random import random
    from time import perf_counter

    COUNT = 500000  # Change this value depending on the speed of your computer
    DATA = list(islice(iter(lambda: (random() - 0.5) * 3.0, None), COUNT))

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

Follow the instructions in this section to create two identical C++ projects named "superfastcode" and "superfastcode2". Later you'll use different means in each project to expose the C++ code to Python.

1. Make sure the `PYTHONHOME` environment variable is set to the Python interpreter you want to use. The C++ projects in Visual Studio rely on this variable to locate files such as *python.h*, which are used when creating a Python extension.

1. Right-click the solution in **Solution Explorer** and select **Add** > **New Project**. A Visual Studio solution can contain both Python and C++ projects together (which is one of the advantages of using Visual Studio for Python).

1. Search on "C++", select **Empty project**, specify the name "superfastcode" ("superfastcode2" for the second project), and select **OK**.

    > [!Tip]
    > With the **Python native development tools** installed in Visual Studio, you can start with the **Python Extension Module** template instead, which has much of what's described below already in place. For this walkthrough, though, starting with an empty project demonstrates building the extension module step by step. Once you understand the process, the template saves you time when writing your own extensions.

1. Create a C++ file in the new project by right-clicking the **Source Files** node, then select **Add** > **New Item**, select **C++ File**, name it `module.cpp`, and select **OK**.

    > [!Important]
    > A file with the *.cpp* extension is necessary to turn on the C++ property pages in the steps that follow.

1. Right-click the C++ project in **Solution Explorer**, select **Properties**.

1. At the top of the **Property Pages** dialog that appears, set **Configuration** to **All Configurations** and **Platform** to **Win32**.

1. Set the specific properties as described in the following table, then select **OK**.

    | Tab | Property | Value |
    | --- | --- | --- |
    | **General** | **General** > **Target Name** | Specify the name of the module as you want to refer to it from Python in `from...import` statements. You use this same name in the C++ when defining the module for Python. If you want to use the name of the project as the module name, leave the default value of **$(ProjectName)**. |
    | | **General** > **Target Extension** | **.pyd** |
    | | **Project Defaults** > **Configuration Type** | **Dynamic Library (.dll)** |
    | **C/C++** > **General** | **Additional Include Directories** | Add the Python *include* folder as appropriate for your installation, for example, `c:\Python36\include`.  |
    | **C/C++** > **Preprocessor** | **Preprocessor Definitions** | **CPython only**: add `Py_LIMITED_API;` to the beginning of the string (including the semicolon). This definition restricts some of the functions you can call from Python and makes the code more portable between different versions of Python. If you're working with PyBind11, don't add this definition, otherwise you'll see build errors. |
    | **C/C++** > **Code Generation** | **Runtime Library** | **Multi-threaded DLL (/MD)** (see Warning below) |
    | **Linker** > **General** | **Additional Library Directories** | Add the Python *libs* folder containing *.lib* files as appropriate for your installation, for example, `c:\Python36\libs`. (Be sure to point to the *libs* folder that contains *.lib* files, and *not* the *Lib* folder that contains *.py* files.) |

    > [!Tip]
    > If you don't see the C/C++ tab in the project properties, it's because the project doesn't contain any files that it identifies as C/C++ source files. This condition can occur if you create a source file without a *.c* or *.cpp* extension. For example, if you accidentally entered `module.coo` instead of `module.cpp` in the new item dialog earlier, then Visual Studio creates the file but doesn't set the file type to "C/C+ Code," which is what activates the C/C++ properties tab. Such misidentification remains the case even if you rename the file with `.cpp`. To set the file type properly, right-click the file in **Solution Explorer**, select **Properties**, then set  **File Type** to **C/C++ Code**.

    > [!Warning]
    > Always set the **C/C++** > **Code Generation** > **Runtime Library** option to **Multi-threaded DLL (/MD)**, even for a debug configuration, because this setting is what the non-debug Python binaries are built with. With CPython, if you happen to set the **Multi-threaded Debug DLL (/MDd)** option, building a **Debug** configuration produces error **C1189: Py_LIMITED_API is incompatible with Py_DEBUG, Py_TRACE_REFS, and Py_REF_DEBUG**. Furthermore, if you remove `Py_LIMITED_API` (which is required with CPython, but not PyBind11) to avoid the build error, Python crashes when attempting to import the module. (The crash happens within the DLL's call to `PyModule_Create` as described later, with the output message of **Fatal Python error: PyThreadState_Get: no current thread**.)
    >
    > The /MDd option is used to build the Python debug binaries (such as *python_d.exe*), but selecting it for an extension DLL still causes the build error with `Py_LIMITED_API`.

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

The sections that follow explain how to perform these steps using both the CPython extensions and PyBind11.

### CPython extensions

For background on what's shown in this section for Python 3.x, refer to the [Python/C API Reference Manual](https://docs.python.org/3/c-api/index.html) and especially [Module Objects](https://docs.python.org/3/c-api/module.html) on python.org (remember to select your version of Python from the drop-down control on the upper right to view the correct documentation).

If you're working with Python 2.7, refer instead to [Extending Python 2.7 with C or C++](https://docs.python.org/2.7/extending/extending.html) and [Porting Extension Modules to Python 3](https://docs.python.org/2.7/howto/cporting.html) (python.org).

1. At the top of *module.cpp*, include *Python.h*:

    ```cpp
    #include <Python.h>
    ```

1. Modify the `tanh_impl` method to accept and return Python types (a `PyOjbect*`, that is):

    ```cpp
    PyObject* tanh_impl(PyObject *, PyObject* o) {
        double x = PyFloat_AsDouble(o);
        double tanh_x = sinh_impl(x) / cosh_impl(x);
        return PyFloat_FromDouble(tanh_x);
    }
    ```

1. Add a structure that defines how the C++ `tanh_impl` function is presented to Python:

    ```cpp
    static PyMethodDef superfastcode_methods[] = {
        // The first property is the name exposed to Python, fast_tanh, the second is the C++
        // function name that contains the implementation.
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

1. Set the target configuration to **Release** and build the C++ project again to verify your code. If you encounter errors, see the [Troubleshooting](#troubleshooting) section below.

### PyBind11

If you completed the steps in the previous section, you certainly noticed that you used lots of boilerplate code to create the necessary module structures for the C++ code. PyBind11 simplifies the process through macros in a C++ header file that accomplish the same result with much less code. For background on what's shown in this section, see [PyBind11 basics](https://github.com/pybind/pybind11/blob/master/docs/basics.rst) (github.com).

1. Install PyBind11 using pip: `pip install pybind11` or `py -m pip install pybind11`.

1. At the top of *module.cpp*, include *pybind11.h*:

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

1. Set the target configuration to **Release** and build the C++ project to verify your code. If you encounter errors, see the next section on troubleshooting.

### Troubleshooting

The C++ module may fail to compile for the following reasons:

- Unable to locate *Python.h* (**E1696: cannot open source file "Python.h"** and/or **C1083: Cannot open include file: "Python.h": No such file or directory**): verify that the path in **C/C++** > **General** > **Additional Include Directories** in the project properties points to your Python installation's *include* folder. See step 6 under [Create the core C++ project](#create-the-core-c-projects).

- Unable to locate Python libraries: verify that the path in **Linker** > **General** > **Additional Library Directories** in the project properties points to your Python installation's *libs* folder. See step 6 under [Create the core C++ project](#create-the-core-c-projects).

- Linker errors related to target architecture: change the C++ target's project architecture to match that of your Python installation. For example, if you're targeting x64 with the C++ project but your Python installation is x86, change the C++ project to target x86.

## Test the code and compare the results

Now that you have the DLLs structured as Python extensions, you can refer to them from the Python project, import the modules, and use their methods.

### Make the DLL available to Python

There are two ways to make the DLL available to Python.

The first method works if the Python project and the C++ project are in the same solution. Go to **Solution Explorer**, right-click the **References** node in your Python project, and then select **Add Reference**. In the dialog that appears, select the **Projects** tab, select both the **superfastcode** and **superfastcode2** projects, and then select **OK**.

![Adding a reference to the superfastcode project](media/cpp-add-reference.png)

The alternate method, described in the following steps, installs the module in the global Python environment, making it available to other Python projects as well. (Doing so typically requires that you refresh the IntelliSense completion database for that environment in Visual Studio 2017 version 15.5 and earlier. Refreshing is also necessary when removing the module from the environment.)

1. If you're using Visual Studio 2017 or later, run the Visual Studio installer, select **Modify**, select **Individual Components** > **Compilers, build tools, and runtimes** > **Visual C++ 2015.3 v140 toolset**. This step is necessary because Python (for Windows) is itself built with Visual Studio 2015 (version 14.0) and expects that those tools are available when building an extension through the method described here. (Note that you may need to install a 32-bit version of Python and target the DLL to Win32 and not x64.)

1. Create a file named *setup.py* in the C++ project by right-clicking the project and selecting **Add** > **New Item**. Then select **C++ File (.cpp)**, name the file `setup.py`, and select **OK** (naming the file with the *.py* extension makes Visual Studio recognize it as Python despite using the C++ file template). When the file appears in the editor, paste the following code into it as appropriate to the extension method:

    **CPython extensions (superfastcode project):**

    ```python
    from distutils.core import setup, Extension, DEBUG

    sfc_module = Extension('superfastcode', sources = ['module.cpp'])

    setup(name = 'superfastcode', version = '1.0',
        description = 'Python Package with superfastcode C++ extension',
        ext_modules = [sfc_module]
        )
    ```

    See [Building C and C++ extensions](https://docs.python.org/3/extending/building.html) (python.org) for documentation on this script.

    **PyBind11 (superfastcode2 project):**

    ```python
    import os, sys

    from distutils.core import setup, Extension
    from distutils import sysconfig

    cpp_args = ['-std=c++11', '-stdlib=libc++', '-mmacosx-version-min=10.7']

    sfc_module = Extension(
        'superfastcode2', sources = ['module.cpp'],
        include_dirs=['pybind11/include'],
        language='c++',
        extra_compile_args = cpp_args,
        )

    setup(
        name = 'superfastcode2',
        version = '1.0',
        description = 'Python package with superfastcode2 C++ extension (PyBind11)',
        ext_modules = [sfc_module],
    )
    ```

1. The *setup.py* code instructs Python to build the extension using the Visual Studio 2015 C++ toolset when used from the command line. Open an elevated command prompt, navigate to the folder containing the C++ project (that is, the folder that contains *setup.py*), and enter the following command:

    ```command
    pip install .
    ```

    or:

    ```command
    py -m pip install .
    ```

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

1. Try increasing the `COUNT` variable so that the differences are more pronounced. A **Debug** build of the C++ module also runs slower than a **Release** build because the **Debug** build is less optimized and contains various error checks. Feel free to switch between those configurations for comparison.

> [!NOTE]
> In the output, you can see that the PyBind11 extension isn't as fast as the CPython extension, though it's still significantly faster than the straight Python implementation. The difference is due to a small amount of per-call overhead that PyBind11 introduces in order to make its C++ interface dramatically simpler. This per-call difference is actually quite negligible: because the test code calls the extension functions 500,000 times, the results you see here greatly amplify that overhead! Typically, a C++ function does much more work than the trivial `fast_tanh[2]` methods used here, in which case the overhead is unimportant. However, if you're implementing methods that might be called thousands of times per second, using the CPython approach can result in better performance than PyBind11.

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

There are a variety of means to create Python extensions as described in the following table. The first two entries for CPython and PyBind11 are what has been discussed in this article already.

| Approach | Vintage | Representative user(s) | Pro(s) | Con(s) |
| --- | --- | --- | --- | --- |
| C/C++ extension modules for CPython | 1991 | Standard Library | [Extensive documentation and tutorials](https://docs.python.org/3/c-api/). Total control. | Compilation, portability, reference management. High C knowledge. |
| [PyBind11](https://github.com/pybind/pybind11) (Recommended for C++) | 2015 |  | Lightweight, header-only library for creating Python bindings of existing C++ code. Few dependencies. PyPy compatibility. | Newer, less mature. Heavy use of C++11 features. Short list of supported compilers (Visual Studio is included). |
| Cython (Recommended for C) | 2007 | [gevent](https://www.gevent.org/), [kivy](https://kivy.org/) | Python-like. Highly mature. High performance. | Compilation, new syntax, new toolchain. |
| [Boost.Python](https://www.boost.org/doc/libs/1_66_0/libs/python/doc/html/index.html) | 2002 | | Works with just about every C++ compiler. | Large and complex suite of libraries; contains many workarounds for old compilers. |
| ctypes | 2003 | [oscrypto](https://github.com/wbond/oscrypto) | No compilation, wide availability. | Accessing and mutating C structures cumbersome and error prone. |
| SWIG | 1996 | [crfsuite](http://www.chokkan.org/software/crfsuite/) | Generate bindings for many languages at once. | Excessive overhead if Python is the only target. |
| cffi | 2013 | [cryptography](https://cryptography.io/en/latest/), [pypy](https://pypy.org/) | Ease of integration, PyPy compatibility. | Newer, less mature. |
| [cppyy](https://cppyy.readthedocs.io/en/latest/) | 2017 | | Similar to cffi using C++. | Newer, may have some issues with VS 2017. |

## See also

The completed sample from this walkthrough can be found on [python-samples-vs-cpp-extension](https://github.com/Microsoft/python-sample-vs-cpp-extension) (GitHub).
