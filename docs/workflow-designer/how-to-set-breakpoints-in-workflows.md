---
title: Set breakpoints in workflows
description: Learn how to use the Workflow Designer to set breakpoints on your graphical workflows as you would in Visual Basic or C# code.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Set breakpoints in workflows

When you use Workflow Designer, you can set breakpoints on your graphical workflows as you would do in Visual Basic or C# code. As expected, workflow execution stops at each breakpoint that you set.

A breakpoint has three states: *Pending*, *Bound*, and *Error*. When you set a breakpoint, it is Pending, and it is represented by a solid red icon. When the runtime has loaded the workflow type, it becomes Bound. If you specify an incorrect format for the breakpoint, such as an activity name that is not valid, an error window appears. The breakpoint is still added to the breakpoint window, but it is marked with a small "x".

> [!NOTE]
> Setting breakpoints on invoked workflows is not supported.

> [!NOTE]
> Ensure that you select the option **Enable Just My Code (Managed Only)** and **Suppress JIT optimization on module load** from the **Tools** > **Options** > **Debugging** menu before you debug. If these options aren't selected and you have two sequences nested within another sequence, and you set a break point on the first inner sequence, pressing **F11** does not debug into the second inner sequence.

> [!NOTE]
> Breakpoints in a workflow are not hit if the full path to XAML file property is not accurate. The full path to XAML file is not accurate after moving the project or solution to another folder or to another machine. Select **Ctrl**+**S** to save and update the full path property.

## To set a breakpoint on an activity in the Design View

1. Select the activity you want the debugger to break on.

2. On the **Debug** menu, select **Toggle Breakpoint**. A red icon will appear at the top left edge of the activity.

   Alternatively, you can press **F9** after selecting the activity, or you can right-click the activity and select **Breakpoint** > **Insert Breakpoint** from the right-click menu.

## Related content

- [Debugging Workflows with the Workflow Designer](../workflow-designer/debugging-workflows-with-the-workflow-designer.md)
- [How to: Debug XAML with the Workflow Designer](../workflow-designer/how-to-debug-xaml-with-the-workflow-designer.md)
