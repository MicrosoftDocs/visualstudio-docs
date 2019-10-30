---
title: "Use breakpoints in the debugger | Microsoft Docs"
ms.custom: ""
ms.date: "10/28/2019"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.breakpointswin"
  - "vs.debug.disassembly.insert"
  - "vs.debug.sourcewin.edit"
  - "vs.debug.file"
  - "vs.debug.breakpt.new"
  - "vs.debug.whenbreakpointishit"
  - "vs.debug.breakpt.location.address"
  - "vs.debug.breakpt.constraints"
  - "vs.debug.breakpoints.delete"
  - "vs.debug.breakpt.location.data"
  - "vc.breakpoints"
  - "vs.debug.breakpt.condition"
  - "vs.debug.breakpt.location.function"
  - "vs.debug.breakpoints"
  - "vs.debug.menu.insert"
  - "vs.debug.filenames"
  - "vs.debug.breakpt.action"
  - "vs.debug.sourcewin.insert"
  - "vs.debug.address"
  - "vs.debug.data"
  - "vs.debug.func"
  - "vs.debug.breakpt.location.file"
helpviewer_keywords:
  - "breakpoints, about breakpoints"
ms.assetid: 020b2e97-3b3e-4b2c-872d-b5c6025e120e
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Use breakpoints in the Visual Studio debugger

Breakpoints are one of the most important debugging techniques in your developer's toolbox. You set breakpoints wherever you want to pause debugger execution. For example, you may want to see the state of code variables or look at the call stack at a certain breakpoint.  If you are trying to resolve a warning or issue while using breakpoints, see [Troubleshoot breakpoints in the Visual Studio debugger](../debugger/troubleshooting-breakpoints.md).

> [!NOTE]
> If you know the task or problem you're trying to solve, but you need to know what kind of breakpoint to use, see [Find your debugging task](../debugger/find-your-debugging-task.md#pause-running-code).

## <a name="BKMK_Overview"></a> Set breakpoints in source code

You can set a breakpoint on any line of executable code. For example, in the following C# code, you could set a breakpoint on the variable declaration, the `for` loop, or any code inside the `for` loop. You can't set a breakpoint on the namespace or class declarations, or on the method signature.

To set a breakpoint in source code, click in the far left margin next to a line of code. You can also select the line and press **F9**, select **Debug** > **Toggle Breakpoint**, or right-click and select **Breakpoint** > **Insert breakpoint**. The breakpoint appears as a red dot in the left margin.

For most languages including C#, breakpoint and current execution lines are automatically highlighted. For C++ code, you can turn on highlighting of breakpoint and current lines by selecting **Tools** (or **Debug**) > **Options** > **Debugging** >  **Highlight entire source line for breakpoints and current statement (C++ only)**.

![Set a breakpoint](../debugger/media/basicbreakpoint.png "Basic breakpoint")

When you debug, execution pauses at the breakpoint, before the code on that line is executed. The breakpoint symbol shows a yellow arrow.

At the breakpoint in the following example, the value of `testInt` is still 1. So, the value hasn't changed since the variable was initialized (set to a value of 1) because the statement in yellow hasn't yet executed.

![Breakpoint execution stopped](../debugger/media/breakpointexecution.png "Breakpoint execution")

When the debugger stops at the breakpoint, you can look at the current state of the app, including [variable values](../debugger/debugger-feature-tour.md#inspect-variables-with-data-tips) and the [call stack](../debugger/how-to-use-the-call-stack-window.md).

Here are a few general instructions for working with breakpoints.

- The breakpoint is a toggle. You can click it, press **F9**, or use **Debug** > **Toggle Breakpoint** to delete or reinsert it.

- To disable a breakpoint without deleting it, hover over or right-click it, and select **Disable breakpoint**. Disabled breakpoints appear as empty dots in the left margin or the **Breakpoints** window. To re-enable a breakpoint, hover over or right-click it, and select **Enable breakpoint**.

- Set conditions and actions, add and edit labels, or export a breakpoint by right-clicking it and selecting the appropriate command, or hovering over it and selecting the **Settings** icon.

## <a name="BKMK_Print_to_the_Output_window_with_tracepoints"></a> Breakpoint actions and tracepoints

A *tracepoint* is a breakpoint that prints a message to the **Output** window. A tracepoint can act like a temporary trace statement in the programming language and does not pause the execution of code. You create a tracepoint by setting a special action in the **Breakpoint Settings** window. For detailed instructions, see [Use tracepoints in the Visual Studio debugger](../debugger/using-tracepoints.md).

## Breakpoint conditions

You can control when and where a breakpoint executes by setting conditions. The condition can be any valid expression that the debugger recognizes. For more information about valid expressions, see [Expressions in the debugger](../debugger/expressions-in-the-debugger.md).

**To set a breakpoint condition:**

1. Right-click the breakpoint symbol and select **Conditions**. Or hover over the breakpoint symbol, select the **Settings** icon, and then select **Conditions** in the **Breakpoint Settings** window.

   You can also set conditions in the **Breakpoints** window by right-clicking a breakpoint and selecting **Settings**, and then selecting **Conditions**.

   ![Breakpoint settings](../debugger/media/breakpointsettings.png "BreakpointSettings")

2. In the dropdown, select **Conditional Expression**, **Hit Count**, or **Filter**, and set the value accordingly.

3. Select **Close** or press **Ctrl**+**Enter** to close the **Breakpoint Settings** window. Or, from the **Breakpoints** window, select **OK** to close the dialog.

Breakpoints with conditions set appear with a **+** symbol in the source code and **Breakpoints** windows.

<a name="BKMK_Specify_a_breakpoint_condition_using_a_code_expression"></a>
### Create a conditional expression

When you select **Conditional Expression**, you can choose between two conditions: **Is true** or **When changed**. Choose **Is true** to break when the expression is satisfied, or **When changed** to break when the value of the expression has changed.

In the following example, the breakpoint is hit only when the value of `testInt` is **4**:

![Breakpoint condition is true](../debugger/media/breakpointconditionistrue.png "Breakpoint Is true")

In the following example, the breakpoint is hit only when the value of `testInt` changes:

![Breakpoint When changed](../debugger/media/breakpointwhenchanged.png "Breakpoint When changed")

If you set a breakpoint condition with invalid syntax, a warning message appears. If you specify a breakpoint condition with valid syntax but invalid semantics, a warning message appears the first time the breakpoint is hit. In either case, the debugger breaks when it hits the invalid breakpoint. The breakpoint is skipped only if the condition is valid and evaluates to `false`.

>[!NOTE]
>The behavior of the **When changed** field is different for different programming languages.
>- For native code, the debugger doesn't consider the first evaluation of the condition to be a change, so doesn't hit the breakpoint on the first evaluation.
>- For managed code, the debugger hits the breakpoint on the first evaluation after **When changed** is selected.

<a name="using-object-ids-in-breakpoint-conditions-c-and-f"></a>
### Use Object IDs in conditional expressions (C# and F# only)

 There are times when you want to observe the behavior of a specific object. For example, you might want to find out why an object was inserted into a collection more than once. In C# and F#, you can create object IDs for specific instances of [reference types](/dotnet/csharp/language-reference/keywords/reference-types), and use them in breakpoint conditions. The object ID is generated by the common language runtime (CLR) debugging services and associated with the object.

**To create an Object ID:**

1. Set a breakpoint in the code some place after the object has been created.

2. Start debugging, and when execution pauses at the breakpoint, select **Debug** > **Windows** > **Locals** or **Alt**+**4** to open the **Locals** window.

   Find the specific object instance in the **Locals** window, right-click it, and select **Make Object ID**.

   You should see a **$** plus a number in the **Locals** window. This is the object ID.

3. Add a new breakpoint at the point you want to investigate; for example, when the object is to be added to the collection. Right-click the breakpoint and select **Conditions**.

4. Use the Object ID in the **Conditional Expression** field. For example, if the variable `item` is the object to be added to the collection, select **Is true** and type **item == $\<n>**, where \<n> is the object ID number.

   Execution will break at the point when that object is to be added to the collection.

   To delete the Object ID, right-click the variable in the **Locals** window and select **Delete Object ID**.

> [!NOTE]
> Object IDs create weak references, and do not prevent the object from being garbage collected. They are valid only for the current debugging session.

### Set a hit count condition

If you suspect that a loop in your code starts misbehaving after a certain number of iterations, you can set a breakpoint to stop execution after that number of hits, rather than having to repeatedly press **F5** to reach that iteration.

Under **Conditions** in the **Breakpoint Settings** window, select **Hit Count**, and then specify the number of iterations. In the following example, the breakpoint is set to hit on every other iteration:

![Breakpoint hit count](../debugger/media/breakpointhitcount.png "BreakpointHitCount")

### Set a filter condition

You can restrict a breakpoint to fire only on specified devices, or in specified processes and threads.

Under **Conditions** in the **Breakpoint Settings** window, select **Filter**, and then enter one or more of the following expressions:

- MachineName = "name"
- ProcessId = value
- ProcessName = "name"
- ThreadId = value
- ThreadName = "name"

Enclose string values in double quotes. You can combine clauses using `&` (AND), `||` (OR), `!` (NOT), and parentheses.

## <a name="BKMK_Set_a_breakpoint_in_a_source_file"></a> Set function breakpoints

You can break execution when a function is called. This is useful, for example, when you know the function name but not its location. It is also useful if you have functions with the same name and you want to break on them all (such as overloaded functions or functions in different projects).

**To set a function breakpoint:**

1. Select **Debug** > **New Breakpoint** > **Function Breakpoint**, or press **Alt**+**F9** > **Ctrl**+**B**.

   You can also select **New** > **Function Breakpoint** in the **Breakpoints** window.

1. In the **New Function Breakpoint** dialog, enter the function name in the **Function Name** box.

   To narrow the function specification:

   - Use the fully qualified function name.

     Example:  `Namespace1.ClassX.MethodA()`

   - Add the parameter types of an overloaded function.

     Example:  `MethodA(int, string)`

   - Use the '!' symbol to specify the module.

     Example: `App1.dll!MethodA`

   - Use the context operator in native C++.

     `{function, , [module]} [+<line offset from start of method>]`

     Example: `{MethodA, , App1.dll}+2`

1. In the **Language** dropdown, choose the language of the function.

1. Select **OK**.

### Set a function breakpoint using a memory address (native C++ only)
 You can use the address of an object to set a function breakpoint on a method called by a specific instance of a class.  For example, given an addressable object of type `my_class`, you can set a function breakpoint on the `my_method` method that instance calls.

1. Set a breakpoint somewhere after the instance of the class is instantiated.

2. Find the address of the instance (for example, `0xcccccccc`).

3. Select **Debug** > **New Breakpoint** > **Function Breakpoint**, or press **Alt**+**F9** > **Ctrl**+**B**.

4. Add the following to the **Function Name** box, and select **C++** language.

   ```cpp
   ((my_class *) 0xcccccccc)->my_method
   ```

::: moniker range=">= vs-2019"

## <a name="BKMK_set_a_data_breakpoint_managed"></a>Set data breakpoints (.NET Core 3.0 or higher)

Data breakpoints break execution when a specific object's property changes.

**To set a data breakpoint**

1. In a .NET Core project, start debugging, and wait until a breakpoint is reached.

2. In the **Autos**, **Watch**, or **Locals** window, right-click a property and select **Break when value changes** in the context menu.

    ![Managed Data Breakpoint](../debugger/media/managed-data-breakpoint.png "Managed Data Breakpoint")

Data breakpoints in .NET Core won't work for:

- Properties that are not expandable in the tooltip, Locals, Autos, or Watch window
- Static variables
- Classes with the DebuggerTypeProxy Attribute
- Fields inside of structs

::: moniker-end

## <a name="BKMK_set_a_data_breakpoint_native_cplusplus"></a>Set data breakpoints (native C++ only)

 Data breakpoints break execution when a value stored at a specified memory address changes. If the value is read but not changed, execution doesn't break.

**To set a data breakpoint:**

1. In a C++ project, start debugging, and wait until a breakpoint is reached. On the **Debug** menu, choose **New Breakpoint** > **Data Breakpoint**

    You can also select **New** > **Data Breakpoint** in the **Breakpoints** window or right-click an item in the **Autos**, **Watch**, or **Locals** window and select **Break when value changes** in the context menu.

2. In the **Address** box, type a memory address, or an expression that evaluates to a memory address. For example, type `&avar` to break when the contents of the variable `avar` changes.

3. In the **Byte Count** dropdown, select the number of bytes you want the debugger to watch. For example, if you select **4**, the debugger will watch the four bytes starting at `&avar` and break if any of those bytes change value.

Data breakpoints don't work under the following conditions:
- A process that is not being debugged writes to the memory location.
- The memory location is shared between two or more processes.
- The memory location is updated within the kernel. For example, if memory is passed to the 32-bit Windows `ReadFile` function, the memory will be updated from kernel mode, so the debugger won't break on the update.
- Where the watch expression is larger than 4 bytes on 32-bit hardware and 8 bytes on 64-bit hardware. This is a limitation of the x86 architecture.

> [!NOTE]
> - Data breakpoints depend on specific memory addresses. The address of a variable changes from one debugging session to the next, so data breakpoints are automatically disabled at the end of each debugging session.
>
> - If you set a data breakpoint on a local variable, the breakpoint remains enabled when the function ends, but the memory address is no longer applicable, so the behavior of the breakpoint is unpredictable. If you set a data breakpoint on a local variable, you should delete or disable the breakpoint before the function ends.

## <a name="BKMK_Specify_advanced_properties_of_a_breakpoint_"></a> Manage breakpoints in the Breakpoints window

 You can use the **Breakpoints** window to see and manage all the breakpoints in your solution. This centralized location is especially helpful in a large solution, or for complex debugging scenarios where breakpoints are critical.

In the **Breakpoints** window, you can search, sort, filter, enable/disable, or delete breakpoints. You can also set conditions and actions, or add a new function or data breakpoint.

To open the **Breakpoints** window, select **Debug** > **Windows** > **Breakpoints**, or press **Alt**+**F9** or **Ctrl**+**Alt**+**B**.

![Breakpoints window](../debugger/media/breakpointswindow.png "Breakpoints window")

To select the columns to display in the **Breakpoints** window, select **Show Columns**. Select a column header to sort the breakpoints list by that column.

### <a name="BKMK_Set_a_breakpoint_at_a_function_return_in_the_Call_Stack_window"></a> Breakpoint labels
You can use labels to sort and filter the list of breakpoints in the **Breakpoints** window.

1. To add a label to a breakpoint, right-click the breakpoint in the source code or the **Breakpoints** window, and then select **Edit labels**. Add a new label or choose an existing one, and then select **OK**.
2. Sort the breakpoint list in the **Breakpoints** window by selecting the **Labels**, **Conditions**, or other column headers. You can select the columns to display by selecting **Show Columns** in the toolbar.

### Export and import breakpoints
 To save or share the state and location of your breakpoints, you can export or import them.

- To export a single breakpoint to an XML file, right-click the breakpoint in the source code or **Breakpoints** window, and select **Export** or **Export selected**. Select an export location, and then select **Save**. The default location is the solution folder.
- To export several breakpoints, in the **Breakpoints** window, select the boxes next to the breakpoints, or enter search criteria in the **Search** field. Select the **Export all breakpoints matching the current search criteria** icon, and save the file.
- To export all breakpoints, deselect all boxes and leave the **Search** field blank. Select the **Export all breakpoints matching the current search criteria** icon, and save the file.
- To import breakpoints, in the **Breakpoints** window, select the **Import breakpoints from a file** icon, navigate to the XML file location, and select **Open**.

## <a name="BKMK_Set_a_breakpoint_from_debugger_windows"></a> Set breakpoints from debugger windows

You can also set breakpoints from the **Call Stack** and **Disassembly** debugger windows.

### Set a breakpoint in the Call Stack window

 To break at the instruction or line that a calling function returns to, you can set a breakpoint in the **Call Stack** window.

**To set a breakpoint in the Call Stack window:**

1. To open the **Call Stack** window, you must be paused during debugging. Select **Debug** > **Windows** > **Call Stack**, or press **Ctrl**+**Alt**+**C**.

2. In the **Call Stack** window, right-click the calling function and select **Breakpoint** > **Insert Breakpoint**, or press **F9**.

   A breakpoint symbol appears next to the function call name in the left margin of the call stack.

The call stack breakpoint appears in the **Breakpoints** window as an address, with a memory location that corresponds to the next executable instruction in the function.

The debugger breaks at the instruction.

For more information about the call stack, see [How to: Use the Call Stack window](../debugger/how-to-use-the-call-stack-window.md).

To visually trace breakpoints during code execution, see [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md).

### Set a breakpoint in the Disassembly window

1. To open the **Disassembly** window, you must be paused during debugging. Select **Debug** > **Windows** > **Disassembly**, or press **Alt**+**8**.

2. In the **Disassembly** window, click in the left margin of the instruction you want to break at. You can also select it and press **F9**, or right-click and select **Breakpoint** > **Insert Breakpoint**.

## See also

- [What is debugging?](../debugger/what-is-debugging.md)
- [Write better C# code using Visual Studio](../debugger/write-better-code-with-visual-studio.md)
- [First look at debugging](../debugger/debugger-feature-tour.md)
- [Troubleshoot breakpoints in the Visual Studio debugger](../debugger/troubleshooting-breakpoints.md)
