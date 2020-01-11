---
title: "Analyze memory usage for .NET objects | Microsoft Docs"
ms.date: "12/9/2019"
ms.topic: "conceptual"
helpviewer_keywords:
  - "memory allocation, memory usage"
author: "Sagar-S-S"
ms.author: "sashe"
manager: AndSter
ms.workload:
  - "multiple"
---


# Analyze memory usage using the .NET Object Allocation tool

You can see how much memory your app is using and what code paths allocate the most memory using the .NET Object Allocation tool.

After running the tool, you can see the function execution paths where objects are being allocated so that you can trace back to the root of the call tree that is taking up the most amount of memory.

## Setup

1. Open the Performance Profiler (**Alt + F2)** in Visual Studio.
2.  Select the **.NET Object Allocation Tracking** checkbox.

![Diag Hub](../profiling/media/diaghub.png "Diag Hub")

> [!NOTE]
> The startup project is selected as the **Analysis Target** by default, but this can be changed to the running process, executables, running apps, and installed apps by opening the **Change Target** dropdown menu and then selecting from the available options.

   The .NET Object Allocation tool does not currently support executables via the dropdown menu. You will have to go through the exe project system to use the tool. To do this close your current solution (**File** -> **Close Solution**) and then hit **File** -> **Open a project or solution** -> select your .exe file.

![Analysis Target](../profiling/media/analysistarget.png "Analysis Target")

3. Click the **Start** button to run the tool.

![Stop Collection](../profiling/media/stopcollection.png "Stop Collection")

4. Once the tool starts running, go through the desired scenario in your app, then press **Stop Collection** or close your app to see your data.
5. Click on the **Allocation** tab and you should see an image similar to the one shown below.

![Allocation](../profiling/media/allocation.png "Allocation")

Congrats! You can now analyze the memory allocation of the objects.

## Understand Your Data

### Collection

![Collection](../profiling/media/collection.png "Collection")

The collection view allows you to see how many objects were collected during garbage collection and how many were retained. This view also provides a few pie charts to visualize collected and survived objects by type.

- The **Collected** column shows the number of objects that the garbage collector collected.
- The **Survived** column shows the number of objects that survived after the garbage collector was run.

### Allocation

![Allocation Expanded](../profiling/media/allocationexpanded.png "Allocation Expanded")

The allocation view allows you to see the location of objects that are allocating memory and how much memory those objects are allocating.

- The **Name** column is a list of various classes and structures that are taking up memory. Each item within the column is a node that can be expanded if there are items within that category taking up memory. (**Allocation** view only)
- The **Total (Allocations)** column shows the number of objects within a particular allocation type that are taking up memory. (**Allocation**, **Call Tree**, and **Functions** View)
- The **Self (Allocations)** column shows the number of objects within an individual item that is taking up memory. (**Allocation**, **Call Tree**, and **Functions** View)
- All three of these columns are sortable. In the case of the **Name** column, the items are sorted alphabetically (either forward or backwards). For **Total** and **Self (Allocations)**, you can sort numerically (either increasingly or decreasingly).
- The **Total Size (Bytes)** and **Self Size (Bytes)** columns are not on by default. To enable them, right click on the **Name**, **Total** or **Self (Allocations)** columns and then click **Total Size** and **Self Size** options to add them to the chart. The two columns are similar to **Total (Allocations)** and **Self (Allocations)** except that instead of showing the number of objects taking up memory, they show the total amount of memory in bytes that those objects are taking up. [Allocation view only]

### Call Tree

![Call Tree](../profiling/media/calltree.png "Call Tree")

The **Call Tree** view allows you to see the function execution paths that contain objects allocating a lot of memory.

- The **Function name** column shows the process or name of the function containing objects allocating memory based on the level of the node you are inspecting.
- The **Total** and **Self (Allocations)** columns show the same information as the **Allocation** view.
- The **Module name** column shows the module that contains the function or process that is calling.

![Hot Path](../profiling/media/hotpath.png "Hot Path")

- The **Expand Hot Path** button highlights a function execution pathway that contains a lot of objects that are allocating memory. The algorithm starts at a user-selected node of interest and highlights the path of most allocations, guiding a user in their investigation.
- The **Show Hot Path** button toggles on or off the flame icons that indicate which node are a part of the **Hot Path**.

### Functions

![Functions](../profiling/media/functions.png "Functions")

The **Functions** view shows processes, modules, and functions that are allocating memory.

- The **Name** column shows processes as the highest-level nodes. Underneath processes are modules, and under modules are functions.
- The **Total** and **Self (Allocations)** columns show the same information as the **Allocation** view.

The **Allocations**, **Call Tree**, and **Functions** views all contain the **Show Just My Code**, **Show Native Code**, and **Search** options:

![Filter Bar](../profiling/media/filterbar.png "Filter Bar")

- **Show Just My Code** collapses systems, frameworks, and other non-user code and into **[External Code]** frames so that user-code can be focused on. For more information, see [Debug user code with Just My Code](../debugger/just-my-code.md).
- **Show Native Code** shows native code within the analysis target including non-user code if selected.
- The **Filter box** allows you to filter down the **Name** or **Function name** column based on the parameter you provide. Simply type in the field and the table should filter down to show only types that contain the string provided.
