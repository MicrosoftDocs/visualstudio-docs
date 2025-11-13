---
title: 'Workflow Designer: Debug XAML'
description: Learn how workflows are defined in terms of XAML and how to debug XAML with the Workflow Designer.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Debug XAML with the Workflow Designer

Workflows are defined in terms of XAML. The UI representation of workflow is built on top of the XAML tree defining the workflow. The debugging experience is similar to debugging workflows in the Workflow Designer. For instance, while debugging XAML, the locals, watch, and threads windows work the same way as they do in Workflow Designer debugging. In addition, the call stack view during the XAML debugging is a line-based hierarchical view of the execution flow for the workflow.

> [!NOTE]
> If the XAML for a workflow is located in the same assembly as the activities, the assembly portion of the class names are not included. Without this portion of the class (activity) names, the XAML cannot be loaded at run time. It is not recommended to define activities in the same namespace as the main project; otherwise, the XAML will need to be hand-edited after being edited in the designer.

## To debug workflow XAML

1. Open a workflow or activity project in Visual Studio.

2. Set a breakpoint on the activity or activities you want to debug as described in [How to: Set Breakpoints in Workflows](../workflow-designer/how-to-set-breakpoints-in-workflows.md).

3. Right-click the .xaml file that contains your workflow definition and select **View Code**. You will see a breakpoint displayed on the same line as the XAML element declaration of the activity that you set the breakpoint on in the design view.

4. Invoke the debugger as described in [Debug workflows](debugging-workflows-with-the-workflow-designer.md).

5. When the code execution reaches one of your breakpoints, the XAML element associated with that breakpoint will be highlighted. To move to the next breakpoint, use the **F10** or **F11** key.

## Related content

- [How to: Set Breakpoints in Workflows](../workflow-designer/how-to-set-breakpoints-in-workflows.md)
- [Debug workflows](debugging-workflows-with-the-workflow-designer.md)
