---
title: "Workflow Designer - How to: Set Breakpoints in Workflows"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
ms.assetid: e41b21c9-c061-4358-8e2f-eb5e412864a8
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Set Breakpoints in Workflows

When you use Windows Workflow Designer, you can set breakpoints on your graphical workflows as you would do in Visual Basic or C# code. As expected, workflow execution stops at each breakpoint that you set.

 A breakpoint has three states: *Pending*, *Bound*, and *Error*. When you set a breakpoint, it is Pending, and it is represented by a solid red icon. When the runtime has loaded the workflow type, it becomes Bound. If you specify an incorrect format for the breakpoint, such as an activity name that is not valid, an error window appears. The breakpoint is still added to the breakpoint window, but it is marked with a small "x".

> [!NOTE]
> Setting breakpoints on invoked workflows is not supported.

> [!WARNING]
> Ensure that you select the option **Enable Just My Code (Managed Only)** from the **Tools**, **Options**, **Debugging** menu before you debug. If you have two sequences nested within another sequence and you set a break point on the first inner sequence, pressing **F11** will not debug into the second inner sequence if the **Enable Just My Code (Managed Only)**option is not selected.

> [!WARNING]
> Breakpoints in a workflow will not get hit if the full path to XAML file property is not accurate.The full path to XAML file is not accurate after moving the project/solution to another folder or to another machine.Select Ctrl+S to save and update full path property.

## To set a breakpoint on an activity in the Design View

1.  Select the activity you want the debugger to break on.

2.  On the **Debug** menu, select **Toggle Breakpoint**. A red icon will appear at the top left edge of the activity.

     Alternatively, you can also press the shortcut **F9** key after selecting the activity or you can right-click the activity and select **Breakpoint** then **Insert Breakpoint** from the context menu.

## See also

- [How to: Invoke the Workflow Debugger](../workflow-designer/how-to-invoke-the-workflow-debugger.md)
- [Debugging Workflows with the Workflow Designer](../workflow-designer/debugging-workflows-with-the-workflow-designer.md)
- [How to: Debug XAML with the Workflow Designer](../workflow-designer/how-to-debug-xaml-with-the-workflow-designer.md)