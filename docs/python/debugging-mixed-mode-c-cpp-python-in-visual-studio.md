---
title: Mixed-mode debugging for Python
description: Simultaneously debug C++ and Python in Visual Studio including stepping between environments, viewing values, and evaluating expressions.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

#customer intent: As a developer, I want to debug C++ and Python code at the same time in Visual Studio so that I can step between the environments, view shared values, and evaluate expressions.
---

# Debug Python and C++ together in Visual Studio

Most regular Python debuggers support debugging Python code only, but it's common practice for developers to use Python with C or C++. Some scenarios that use mixed code are applications that require high performance or the ability to directly invoke platform APIs are often coded in Python and C or C++.

Visual Studio provides integrated, simultaneous mixed-mode debugging for Python and native C/C++ code. The support is available when you select the **Python native development tools** option for the **Python Development** workload in the Visual Studio installer:

:::image type="content" source="media/python-native-development.png" alt-text="Screenshot that shows the Python native development tools option selected in the Visual Studio Installer." border="false" lightbox="media/python-native-development.png":::

In this article, you explore how to work with the following mixed-mode debugging features:

- Combined call stacks
- Step between Python and native code
- Breakpoints in both types of code
- View Python representations of objects in native frames and vice versa
- Debugging within the context of the Python project or the C++ project

:::image type="content" source="media/mixed-mode-debugging.png" alt-text="Screenshot that shows an example of mixed-mode debugging for Python and C++ code in Visual Studio." border="false" lightbox="media/mixed-mode-debugging.png":::

## Prerequisites

- Visual Studio 2017 and later. Mixed-mode debugging isn't available with Python Tools for Visual Studio 1.x in Visual Studio 2015 and earlier.

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

## Enable mixed-mode debugging in a Python project

The following steps describe how to enable mixed-mode debugging in a Python project:

1. In **Solution Explorer**, right-click the Python project, and select **Properties**.

1. In the **Properties** pane, select the **Debug** tab, and then select the **Debug** > **Enable native code debugging** option:

   :::image type="content" source="media/mixed-mode-debugging-enable-native.png" alt-text="Screenshot that shows how to set the Enable native code debugging property in Visual Studio." border="false" lightbox="media/mixed-mode-debugging-enable-native.png":::

   This option enables mixed-mode for all debugging sessions.

   > [!TIP]
   > When you enable native code debugging, the Python output window might close immediately after the program finishes without pausing and showing the **Press any key to continue** prompt. To force the pause and prompt after you enable native code debugging, add the `-i` argument to the **Run** > **Interpreter Arguments** field on the **Debug** tab. This argument puts the Python interpreter into interactive mode after the code runs. The program waits for you to select **Ctrl**+**Z**+**Enter** to close the window.

1. Select **File** > **Save** (or **Ctrl**+**S**) to save the property changes.

1. To attach the mixed-mode debugger to an existing process, select **Debug** > **Attach to Process**. A dialog opens.

    1. In the **Attach to Process** dialog, select the appropriate process from the list.
    
    1. For the **Attach to** field, use the **Select** option to open the **Select Code Type** dialog.

    1. In the **Select Code Type** dialog, choose the **Debug these code types** option.
    
    1. In the list, select the **Python (native)** checkbox, and select **OK**:

       :::image type="content" source="media/mixed-mode-debugging-attach-code-type.png" alt-text="Screenshot that shows how to select the Python (native) code type for debugging in the Visual Studio." border="false" lightbox="media/mixed-mode-debugging-attach-code-type.png":::

    1. Select **Attach** to start the debugger.

    The code type settings are persistent. If you want to disable mixed-mode debugging and attach to a different process later, clear the **Python (native)** code type checkbox and select the **Native** code type checkbox.

    You can select other code types in addition to or instead of the **Native** option. For example, if a managed application hosts CPython, which in turn uses native extension modules, and you want to debug all three code projects, select the **Python**, **Native**, and **Managed** checkboxes. This approach gives you a unified debugging experience including combined call stacks and stepping between all three runtimes.

### Work with virtual environments

When you use this method of mixed-mode debugging for virtual environments (venvs), Python for Windows uses a `python.exe` stub file for venvs that Visual Studio finds and loads as a subprocess.

- For Python 3.8 and later, mixed-mode doesn't support multi-process debugging. When you start the debugging session, the stub subprocess is debugged rather than the application. For attach scenarios, the workaround is to attach to the correct `python.exe` file. When you launch the application with debugging (such as through the **F5** keyboard shortcut), you can create your venv by using the command `C:\Python310-64\python.exe -m venv venv --symlinks`. In the command, insert your preferred version of Python. By default, only administrators can create symlinks on Windows.

- For Python versions earlier than 3.8, mixed mode debugging should work as expected with venvs.

Running in a global environment doesn't cause these issues for any version of Python.

### Install Python symbols

When you start debugging in mixed mode for the first time, you might see a **Python Symbols Required** dialog. You need to install the symbols only once for any given Python environment. Symbols are automatically included if you install Python support through the Visual Studio Installer (Visual Studio 2017 and later). For more information, see [Install debugging symbols for Python interpreters in Visual Studio](debugging-symbols-for-mixed-mode-c-cpp-python.md).

### Access Python source code

You can make the source code for standard Python itself available when debugging.

1. Go to [`https://www.python.org/downloads/source/`](https://www.python.org/downloads/source/).

1. Download the Python source code archive appropriate for your version, and extract the code to a folder.

1. When Visual Studio prompts for the location of the Python source code, point to the specific files in the extraction folder.

## Enable mixed-mode debugging in a C/C++ project

Visual Studio 2017 version 15.5 and later supports mixed-mode debugging from a C/C++ project. An example of this usage is when you want to [embed Python in another application as described on python.org](https://docs.python.org/3/extending/embedding.html).

The following steps describe how to enable mixed-mode debugging for a C/C++ project:

1. In **Solution Explorer**, right-click the C/C++ project, and select **Properties**.

1. In the **Property Pages** pane, select the **Configuration Properties** > **Debugging** tab.

1. Expand the dropdown menu for the **Debugger to launch** option and select **Python/Native Debugging**.

    :::image type="content" source="media/mixed-mode-debugging-select-cpp-debugger.png" alt-text="Screenshot that shows how to select the Python Native Debugging option for a C/C++ project in the Visual Studio." border="false" lightbox="media/mixed-mode-debugging-select-cpp-debugger.png":::

    > [!NOTE]
    > If you don't see the **Python/Native Debugging** option, you need to first install the **Python native development tools** by using the Visual Studio Installer. The native debugging option is available under the Python development workload. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

1. Select **OK** to save the changes.

### Debug the program launcher

When you use this method, you can't debug the `py.exe` program launcher because it spawns a child `python.exe` subprocess. The debugger doesn't attach to the subprocess. For this scenario, the workaround is to launch the `python.exe` program directly with arguments, as follows:

1. On the **Property Pages** pane for the C/C++ project, go to the **Configuration Properties** > **Debugging** tab.

1. For the **Command** option, specify the full path to the `python.exe` program file.

1. Specify your desired arguments in the **Command Arguments** field.

### Attach the mixed-mode debugger

For Visual Studio 2017 version 15.4 and earlier, direct mixed-mode debugging is enabled only when launching a Python project in Visual Studio. The support is limited because C/C++ projects use only the native debugger.

For this scenario, the workaround is to attach the debugger separately:

1. Start the C++ project without debugging by selecting **Debug** > **Start without Debugging** or use the keyboard shortcut **Ctrl**+**F5**.

1. To attach the mixed-mode debugger to an existing process, select **Debug** > **Attach to Process**. A dialog opens.

    1. In the **Attach to Process** dialog, select the appropriate process from the list.
    
    1. For the **Attach to** field, use the **Select** option to open the **Select Code Type** dialog.

    1. In the **Select Code Type** dialog, choose the **Debug these code types** option.
    
    1. In the list, select the **Python** checkbox, and select **OK**.

    1. Select **Attach** to start the debugger.

> [!TIP]
> You can add a pause or delay in the C++ application to ensure it doesn't call the Python code that you want to debug before you attach the debugger.

## Explore mixed-mode specific features

Visual Studio provides several mixed-mode debugging features to make it easier to debug your application: 

- [Combined call stack](#use-a-combined-call-stack)
- [Step between Python and native code](#step-between-python-and-native-code)
- [PyObject values view in native code](#use-pyobject-values-view-in-native-code)
- [Native values view in Python code](#view-native-values-in-python-code)

### Use a combined call stack

The **Call Stack** window shows both native and Python stack frames interleaved, with transitions marked between the two:

:::image type="content" source="media/mixed-mode-debugging-call-stack.png" alt-text="Screenshot of the combined call stack window with mixed-mode debugging in Visual Studio." border="false" lightbox="media/mixed-mode-debugging-call-stack.png":::

- To make transitions appear as **[External Code]** without specifying the direction of transition, set the **Tools** > **Options** > **Debugging** > **General** > **Enable Just My Code** option.

- To make any call frame active, double-click the frame. This action also opens the corresponding source code, if possible. If source code isn't available, the frame is still made active and local variables can be inspected.

### Step between Python and native code

Visual Studio provides the **Step Into** (**F11**) or **Step Out** (**Shift**+**F11**) commands to enable the mixed-mode debugger to correctly handle changes between code types.

- When Python calls a method of a type implemented in C, stepping in on a call to that method stops at the beginning of the native function that implements the method. 

- This same behavior occurs when native code calls a Python API function that results in Python code being invoked. Stepping into a call to `PyObject_CallObject` on a function value originally defined in Python stops at the beginning of the Python function.

- Stepping in from Python to native is also supported for native functions invoked from Python via [ctypes](https://docs.python.org/3/library/ctypes.html).

### Use PyObject values view in native code

When a native (C or C++) frame is active, its local variables show up in the debugger **Locals** window. In native Python extension modules, many of these variables are of type `PyObject` (which is a typedef for `_object`), or a few other [fundamental Python types](#c-types-that-show-python-view-nodes). In mixed-mode debugging, these values present another child node labeled **[Python view]**.

- To view the variable's Python representation, expand the node. The view of the variables is identical to what you see if a local variable referencing the same object is present in a Python frame. The children of this node are editable.

   :::image type="content" source="media/mixed-mode-debugging-python-view.png" alt-text="Screenshot that shows the Python View in the Locals window in Visual Studio." border="false" lightbox="media/mixed-mode-debugging-python-view.png":::

- To disable this feature, right-click anywhere in the **Locals** window and toggle the **Python** > **Show Python View Nodes** menu option:

   :::image type="content" source="media/mixed-mode-debugging-enable-python-view.png" alt-text="Screenshot that shows how to enable the Show Python View Nodes option for the Locals window." border="false" lightbox="media/mixed-mode-debugging-enable-python-view.png":::

#### C types that show Python view nodes 

The following C types show **[Python view]** nodes, if enabled:

- `PyObject`
- `PyVarObject`
- `PyTypeObject`
- `PyByteArrayObject`
- `PyBytesObject`
- `PyTupleObject`
- `PyListObject`
- `PyDictObject`
- `PySetObject`
- `PyIntObject`
- `PyLongObject`
- `PyFloatObject`
- `PyStringObject`
- `PyUnicodeObject`

**[Python view]** doesn't automatically appear for types you author yourself. When you author extensions for Python 3.x, this lack isn't usually an issue. Any object ultimately has an `ob_base` field of one of the listed C types, which causes **[Python view]** to appear.

### View native values in Python code

You can enable a **[C++ view]** for native values in the **Locals** window when a Python frame is active. This feature isn't enabled by default.

- To enable the feature, right-click in the **Locals** window and set the **Python** > **Show C++ View Nodes** menu option.

   :::image type="content" source="media/mixed-mode-debugging-enable-cpp-view.png" alt-text="Screenshot that shows how to enable the Show C++ View Nodes options for the Locals window." border="false" lightbox="media/mixed-mode-debugging-enable-cpp-view.png":::

- The **[C++ view]** node provides a representation of the underlying C/C++ structure for a value, identical to what you see in a native frame. It shows an instance of `_longobject` (for which `PyLongObject` is a typedef) for a Python long integer, and it tries to infer types for native classes that you author yourself. The children of this node are editable.

   :::image type="content" source="media/mixed-mode-debugging-cpp-view.png" alt-text="Screenshot that shows the C++ View in the Locals window in Visual Studio." border="false" lightbox="media/mixed-mode-debugging-cpp-view.png":::

If a child field of an object is of type `PyObject`, or another supported type, then it has a **[Python view]** representation node (if those representations are enabled). This behavior makes it possible to navigate object graphs where links aren't directly exposed to Python.

Unlike **[Python view]** nodes, which use Python object metadata to determine the type of the object, there's no similarly reliable mechanism for **[C++ view]**. Generally speaking, given a Python value (that is, a `PyObject` reference) it's not possible to reliably determine which C/C++ structure is backing it. The mixed-mode debugger tries to guess the type by looking at various fields of the object's type (such as the `PyTypeObject` referenced by its `ob_type` field) that have function pointer types. If one of those function pointers references a function that can be resolved, and that function has a `self` parameter with a type more specific than `PyObject*`, then that type is assumed to be the backing type.

Consider the following example, where the `ob_type->tp_init` value for of a given object points at the following function:

```c
static int FobObject_init(FobObject* self, PyObject* args, PyObject* kwds) {
    return 0;
}
```

In this case, the debugger can correctly deduce that the C type of the object is `FobObject`. If the debugger can't determine a more precise type from `tp_init`, it moves on to other fields. If it's unable to deduce the type from any of those fields, the **[C++ view]** node presents the object as a `PyObject` instance.

To always get a useful representation for custom authored types, it's best to register at least one special function when registering the type, and use a strongly typed `self` parameter. Most types fulfill that requirement naturally. For other types, the `tp_init` inspection is usually the most convenient entry to use for this purpose. A dummy implementation of `tp_init` for a type that's present solely to enable debugger type inference can just return zero immediately, as in the preceding example.

## Review differences from standard Python debugging

The mixed-mode debugger is distinct from the [standard Python debugger](debugging-python-in-visual-studio.md). It introduces some extra features but lacks some Python-related capabilities, as follows:

- Unsupported features include conditional breakpoints, the **Debug Interactive** window, and cross-platform remote debugging.
- The **Immediate** window is available but with a limited subset of its functionality, including all the limitations listed in this section.
- Supported Python versions include only CPython 2.7 and 3.3+.
- To use Python with Visual Studio Shell (for example, if you install it with the integrated installer), Visual Studio is unable to open C++ projects. As a result, the editing experience for C++ files is that of a basic text editor only. However, C/C++ debugging and mixed-mode debugging are fully supported in Shell with source code, stepping into native code, and C++ expression evaluation in debugger windows.
- When you view Python objects in the **Locals** and **Watch** debugger tool windows, the mixed-mode debugger shows only the structure of the objects. It doesn't automatically evaluate properties or show computed attributes. For collections, it shows only elements for built-in collection types (`tuple`, `list`, `dict`, `set`). Custom collection types aren't visualized as collections, unless they're inherited from some built-in collection type.
- Expression evaluation is handled as described in the following section.

### Use expression evaluation

The standard Python debugger allows evaluation of arbitrary Python expressions in the **Watch** and **Immediate** windows when the debugged process is paused at any point in the code, so long as it isn't blocked in an I/O operation or other similar system call. In mixed-mode debugging, arbitrary expressions can be evaluated only when stopped in Python code, after a breakpoint, or when stepping into the code. Expressions can be evaluated only on the thread on which the breakpoint or the stepping operation occurred.

When the debugger stops in native code, or in Python code where the described conditions don't apply, such as after a step-out operation, or on a different thread). Expression evaluation is limited to accessing local and global variables in scope of the currently selected frame, accessing their fields, and indexing built-in collection types with literals. For example, the following expression can be evaluated in any context (provided all identifiers refer to existing variables and fields of appropriate types):

```python
foo.bar[0].baz['key']
```

The mixed-mode debugger also resolves such expressions differently. All member-access operations look up only fields that are directly part of the object (such as an entry in its `__dict__` or `__slots__`, or a field of a native struct exposed to Python via `tp_members`), and ignore any `__getattr__`, `__getattribute__`, or descriptor logic. Similarly, all indexing operations ignore `__getitem__`, and access the inner data structures of collections directly.

For the sake of consistency, this name resolution scheme is used for all expressions that match the constraints for limited expression evaluation. This scheme is applied regardless of whether arbitrary expressions are allowed at the current stop point. To force proper Python semantics when a full-featured evaluator is available, enclose the expression in parentheses:

```python
(foo.bar[0].baz['key'])
```

## Related content

- [Create a C++ extension for Python](working-with-c-cpp-python-in-visual-studio.md)
- [Install debugging symbols for Python interpreters in Visual Studio](debugging-symbols-for-mixed-mode-c-cpp-python.md)
